using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example
{
    /**
     * Alex Skalozub
     * https://github.com/pieceofsummer/WTReTextField
     */
    public class WTReParser
    {
        public class NSRange
        {
            public int location;
            public int length;

            public NSRange(int loc, int len)
            {
                location = loc;
                length = len;
            }
        }

        public class WTReNode
        {
            public NSRange sourceRange;

            public WTReNode parent;
            public WTReNode nextSibling;

            public virtual string displayString(string pattern)
            {
                return pattern.Substring(sourceRange.location, sourceRange.length);
            }
        }

        public class WTReGroup : WTReNode
        {
            public bool capturing;

            public List<WTReNode> children;
        
            public override string displayString(string pattern)
            {
                return "(" + base.displayString(pattern) + ")";
            }

            public WTReGroup()
            {
                children = new List<WTReNode>();
            }
        }

        public class WTReAlteration : WTReNode
        {
            public List<WTReNode> children;

            public WTReAlteration()
            {
                children = new List<WTReNode>();
            }
        }

        public class WTReQuantifier : WTReNode
        {
            public WTReNode child;
            public bool greedy;
            public int countFrom;
            public int countTo;

            public WTReQuantifier()
            {
                greedy = true;
                countFrom = 1;
                countTo = 1;
            }

            public WTReQuantifier(int from, int to)
            {
                greedy = true;
                countFrom = from;
                countTo = to;
            }

            public string displayQuantifier()
            {
                string pat;

                if (countFrom == 0)
                {
                    if (countTo == int.MaxValue)
                    {
                        pat = "*";
                    }
                    else if (countTo == 1)
                    {
                        pat = "?";
                    }
                    else
                    {
                        pat = string.Format("{{,{0}}}", countTo); //{,%u} !
                    }
                }
                else if (countFrom == 1 && countTo == int.MaxValue)
                {
                    pat = "+";
                }
                else if (countFrom == countTo)
                {
                    pat = string.Format("{{{0}}}", countFrom);
                }
                else if (countTo == int.MaxValue)
                {
                    pat = string.Format("{{{0},}}", countFrom);
                }
                else
                {
                    pat = string.Format("{{{0},{1}}}", countFrom, countTo);
                }
                if (!greedy) pat += "?";

                return pat;

            }

            public override string displayString(string pattern)
            {
                return child.displayString(pattern) + displayQuantifier();
            }
        }

        public class WTReCharacterBase : WTReNode
        {
            public bool ignoreCase;

            public virtual bool matchesCharacter(char c)
            {
                throw new Exception("Invalid operation!");
            }
        }

        public class WTReCharacterSet : WTReCharacterBase
        {
            public bool negation;
            public string chars;

            public override bool matchesCharacter(char c)
            {
                bool contains = Regex.IsMatch(c.ToString(), chars);

                return contains ^ negation;
            }

            public override string displayString(string pattern)
            {
                return "[" + base.displayString(pattern) + "]";
            }
        }

        public class WTReLiteral : WTReCharacterBase
        {
            public char character;

            public override bool matchesCharacter(char c)
            {
                bool contains = character == c;
                if (!contains && ignoreCase)
                {
                    contains = c.ToString().ToLower() == character.ToString().ToLower();
                }

                return contains;
            }

            public override string displayString(string pattern)
            {
                return "'" + character + "'";
            }
        }

        public class WTReAnyCharacter : WTReCharacterBase
        {
            public override bool matchesCharacter(char c)
            {
                return true;
            }

            public override string displayString(string pattern)
            {
                return ".";
            }
        }

        public class WTReEndOfString : WTReCharacterBase
        {
            public override string displayString(string pattern)
            {
                return "$";
            }

            public override bool matchesCharacter(char c)
            {
                return c == 0;
            }
        }

        public class WTState
        {
            public List<WTTransition> transitions;
            public bool isFinal;

            public WTState()
            {
                transitions = new List<WTTransition>();
            }
        }

        public class WTTransition
        {
            public WTReCharacterBase node;
            public WTReLiteral bypassNode;
            public WTState nextState;
        }

        string _pattern;
        bool _ignoreCase;
        WTReGroup node;
        bool _finished;
        Regex _exactQuantifierRegex;
        Regex _rangeQuantifierRegex;

        public WTReParser(string pattern, bool ignoreCase)
        {
            _pattern = pattern;
            _ignoreCase = ignoreCase;
            node = null;
            this.parsePattern();
        }

        public WTReParser(string pattern) : this(pattern, false)
        {
        }

        public void parsePattern()
        {
            if (node != null) return;

            if (!_pattern.StartsWith("^")) throw new Exception("Invalid pattern start");

            _finished = false;

            _exactQuantifierRegex = new Regex("^\\{\\s*(\\d+)\\s*\\}$");
            _rangeQuantifierRegex = new Regex("^\\{\\s*(\\d*)\\s*,\\s*(\\d*)\\s*\\}$");

            node = parseSubpattern(_pattern, new NSRange(1, _pattern.Length - 1), false);

            _exactQuantifierRegex = null;
            _rangeQuantifierRegex = null;

            if (!_finished) throw new Exception("Invalid pattern end");
        }

        bool isValidEscapedChar(char c, bool inCharset)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                case '\\':
                case '|':
                case 'd':
                case 'D':
                case 'w':
                case 'W':
                case 's':
                case 'S':
                case 'u':
                case '\'':
                case '.':
                case '+':
                case '*':
                case '?':
                case '$':
                case '^':
                    return true;

                case '-':
                    return inCharset;

                default:
                    return false;
            }
        }

        WTReCharacterBase parseCharset(String pattern, NSRange range, bool enclosed)
        {
            bool negation = false;
            int count = 0;
            char lastChar = (char)0;
            string chars = "";
            bool escape = false;

            for (int i = 0; i < range.length; i++) {
                char c = pattern[range.location + i];

                string strRegex = "";

                if (enclosed && i == 0 && c == '^') {
                    negation = true;
                    continue;
                }

                if (c == '\\' && !escape) {
                    escape = true;
                    continue;
                }

                if (escape) {
                    // process character classes and escaped special chars
                    if (!this.isValidEscapedChar(c, enclosed)) throw new Exception("isValidEscapedChar");

                    if (c == 'd') {
                        strRegex = "\\d";
                        count += 2;
                    } else if (c == 'D') {
                        strRegex = "\\D";
                        count += 2;
                    } else if (c == 'w') {
                        strRegex = "\\w";
                        count += 2;
                    } else if (c == 'W') {
                        strRegex = "\\W";
                        count += 2;
                    } else if (c == 's') {
                        strRegex = "\\s";
                        count += 2;
                    } else if (c == 'S') {
                        strRegex = "\\S";
                        count += 2;
                    } else if (c == 'u') {
                        // unicode character in format \uFFFF

                        if (i + 4 >= range.length) throw new Exception("Expected a four-digit hexadecimal character code");
                        string str = _pattern.Substring(range.location + i + 1, 4);
                        //range.location = i + 1;
                        range.location = i + 1 + 4;
                        strRegex = "\\u" + str;
                        i += 4;
                        count++;
                    } else {
                        // todo: check for other escape sequences

                        lastChar = c;
                        chars += c;
                        count++;
                        // [chars addCharactersInRange:NSMakeRange(c, 1)];
                        // lastChar = c;
                        // count++;
                    }

                    escape = false;
                } else if (enclosed && c == '-' && i > 0 && i < range.length - 1) {
                    // process character range

                    char rangeStart = _pattern[range.location + i - 1];
                    char rangeEnd = _pattern[range.location + i + 1];

                    if (rangeEnd < rangeStart) throw new Exception("Invalid character range");

                    strRegex = "[" + rangeStart + "-" + rangeEnd + "]";

                    i++;
                    count += 2;
                } else {
                    strRegex = c.ToString();
                    lastChar = c;
                    count++;
                }

                chars += strRegex + "|";
            }

            if (!negation && count == 1) {
                WTReLiteral l = new WTReLiteral();
                l.character = lastChar;
                l.sourceRange = range;
                l.ignoreCase = _ignoreCase;
                return l;
            } else {
                WTReCharacterSet s = new WTReCharacterSet();
                s.negation = negation;
                if (chars[chars.Length - 1] == '|')
                    chars = chars.Substring(0, chars.Length - 1);
                s.chars = chars;
                s.sourceRange = range;
                s.ignoreCase = _ignoreCase;
                return s;
            }
        }

        public WTReGroup groupFromNodes(List<WTReNode> nodes, bool enclosed)
        {
            if ((nodes.Count == 1) && (nodes[0] is WTReGroup)) {
                WTReGroup t = (WTReGroup)nodes[0];
                if (t is WTReGroup) {
                    t.capturing |= enclosed;
                    return t;
                }
            }

            WTReGroup g = new WTReGroup();

            g.children = new List<WTReNode>(nodes);
            g.capturing = enclosed;

            // setup links
            WTReNode prev = g.children[0];

            prev.parent = g;

            for (int i = 1; i < g.children.Count; i++)
            {
                WTReNode curr = g.children[i];
                curr.parent = g;
                prev.nextSibling = curr;
                prev = curr;
            }

            return g;
        }

        WTReGroup parseSubpattern(string pattern, NSRange range, bool enclosed)
        {
            List<WTReNode> nodes = new List<WTReNode>(range.length);

            List<WTReNode> alternations = null;
            int startPos = 0, endPos = range.length;

            bool escape = false;
            WTReNode lastnode = null;

            for (int i = 0; i < range.length; i++) {
                if (_finished) throw new Exception("Found pattern end in the middle of string");

                char c = pattern[range.location + i];

                if (enclosed && i == 0 && c == '?') {
                    // group modifiers are present

                    if (range.length < 3) throw new Exception("Invalid group found in pattern");


                    char d = pattern[range.location + i + 1];
                    if (d == '<') {
                        // tagged group (?<style1>…)
                        for (int j = i + 2; j < range.length; j++) {
                            d = pattern[range.location + j];
                            ;

                            if (d == '<') {
                                throw new Exception("Invalid group tag found in pattern");
                            } else if (d == '>') {
                                if (j == i + 2) throw new Exception("Empty group tag found in pattern");
                                i = j;
                                break;

                            } else if (char.IsLetterOrDigit(d)) {
                                throw new Exception("Group tag contains invalid chars");
                            }
                        }
                    } else if (d == '\'') {
                        // tagged group (?'style2'…)
                        for (int j = i + 2; j < range.length; j++) {
                            d = pattern[range.location + j];

                            if (d == '\'') {
                                if (j == i + 2) throw new Exception("Empty group tag found in pattern");
                                i = j;
                                break;
                            } else if (!char.IsLetterOrDigit(d)) {
                                throw new Exception("Group tag contains invalid chars");
                            }
                        }
                    } else if (d == ':') {
                        // non-capturing group
                        enclosed = false;
                        i++;
                    } else {
                        throw new Exception("Unknown group modifier");
                    }

                    continue;
                }

                if (c == '\\' && !escape) {
                    escape = true;
                    continue;
                }

                if (escape) {
                    if (!isValidEscapedChar(c, false) || i == 0) throw new Exception("Invalid escape sequence");

                    lastnode = this.parseCharset(pattern, new NSRange(range.location + i - 1, 2), false);
                    nodes.Add(lastnode);

                    escape = false;
                } else if (c == '(') {
                    int brackets = 1;
                    bool escape2 = true;

                    for (int j = i + 1; j < range.length; j++) {
                        char d = pattern[range.location + j];

                        if (escape2) {
                            escape2 = false;
                        } else if (d == '\\') {
                            escape2 = true;
                        } else if (d == '(') {
                            brackets++;
                        } else if (d == ')') {
                            brackets--;

                            if (brackets == 0) {
                                lastnode = this.parseSubpattern(pattern, new NSRange(range.location + i + 1, j - i - 1), true);
                                nodes.Add(lastnode);
                                i = j;
                                break;
                            }
                        }
                    }

                    if (brackets != 0) throw new Exception("Unclosed group bracket");
                } else if (c == ')') {
                    throw new Exception("Unopened group bracket");
                } else if (c == '[') {
                    bool escape2 = false;
                    bool valid = false;

                    for (int j = i + 1; j < range.length; j++) {
                        char d = pattern[range.location + j];

                        if (escape2) {
                            escape2 = false;
                        } else if (d == '\\') {
                            escape2 = true;
                        } else if (d == '[' || d == '(' || d == ')') {
                            // invalid character
                            break;
                        } else if (d == ']') {
                            lastnode = this.parseCharset(pattern, new NSRange(range.location + i + 1, j - i - 1), true);
                            nodes.Add(lastnode);

                            i = j;
                            valid = true;
                            break;
                        }
                    }

                    if (!valid) throw new Exception("Unclosed character set bracket");
                } else if (c == ']') {
                    throw new Exception("Unopened character set bracket");
                } else if (c == '{') {
                    if (lastnode == null || lastnode is WTReQuantifier) throw new Exception("Invalid quantifier usage");

                    bool valid = false;

                    for (int j = i + 1; j < range.length; j++) {
                        char d = pattern[range.location + j];

                        if (d == '}') {
                            string from, to;

                            string str = pattern.Substring(range.location + i, j + 1 - i);
                            Match m = _exactQuantifierRegex.Match(str);

                            if (m.Success) {
                                from = m.Groups[1].Value;
                                to = from;
                            } else {
                                m = _rangeQuantifierRegex.Match(str);
                                if (!m.Success) {
                                    throw new Exception("Invalid quantifier format");
                                } else {
                                    from = m.Groups[1].Value;
                                    to = m.Groups[2].Value;
                                }
                            }

                            WTReQuantifier qtf = new WTReQuantifier();

                            if (from == null || from.Equals("")) qtf.countFrom = 0;
                            else qtf.countFrom = int.Parse(from);

                            if (to == null || to.Equals("")) qtf.countTo = int.MaxValue;
                            else qtf.countTo = int.Parse(to);

                            if (qtf.countFrom > qtf.countTo) throw new Exception("Invalid quantifier range");

                            nodes.RemoveAt(nodes.Count - 1); //removeLastObject
                            qtf.child = lastnode;
                            lastnode.parent = qtf;
                            lastnode = qtf;
                            nodes.Add(lastnode);

                            i = j;
                            valid = true;
                            break;
                        }
                    }

                    if (!valid) throw new Exception("Unclosed quantifier bracket");
                } else if (c == '}') {
                    throw new Exception("Unopened qualifier bracket");
                } else if (c == '*') {
                    if (lastnode == null || lastnode is WTReQuantifier) throw new Exception("Invalid quantifier usage");

                    nodes.RemoveAt(nodes.Count - 1);
                    WTReQuantifier qtf = new WTReQuantifier(0, int.MaxValue);
                    qtf.child = lastnode;
                    lastnode.parent = qtf;
                    lastnode = qtf;
                    nodes.Add(lastnode);
                } else if (c == '+') {
                    if (lastnode == null || lastnode is WTReQuantifier) throw new Exception("Invalid quantifier usage");

                    nodes.RemoveAt(nodes.Count - 1);
                    WTReQuantifier qtf = new WTReQuantifier(1, int.MaxValue);
                    qtf.child = lastnode;
                    lastnode.parent = qtf;
                    lastnode = qtf;
                    nodes.Add(lastnode);
                } else if (c == '?') {
                    if (lastnode == null) throw new Exception("Invalid quantifier usage");

                    if (lastnode is WTReQuantifier) {
                        ((WTReQuantifier) lastnode).greedy = false;
                    } else {
                        nodes.RemoveAt(nodes.Count - 1);
                        WTReQuantifier qtf = new WTReQuantifier(0, 1);
                        qtf.child = lastnode;
                        lastnode.parent = qtf;
                        lastnode = qtf;
                        nodes.Add(lastnode);
                    }

                    lastnode = null;
                } else if (c == '.') {
                    // any character
                    lastnode = new WTReAnyCharacter();
                    nodes.Add(lastnode);
                } else if (c == '|') {
                    // alternation
                    if (alternations == null) alternations = new List<WTReNode>(2);

                    WTReGroup gr = groupFromNodes(nodes, enclosed);

                    gr.sourceRange = new NSRange(range.location + startPos, i - startPos);
                    startPos = i + 1;

                    alternations.Add(gr);
                    nodes.Clear();
                    lastnode = null;
                } else if (c == '$') {
                    if (alternations != null && enclosed) throw new Exception("End of string shouldn't be inside alternation");

                    if (range.location + i + 1 < pattern.Length) throw new Exception("Unexpected end of string");

                    lastnode = new WTReEndOfString();
                    nodes.Add(lastnode);

                    endPos = i + 1;
                    _finished = true;
                    break;
                } else {
                    lastnode = this.parseCharset(pattern, new NSRange(range.location + i, 1), false);
                    nodes.Add(lastnode);
                }
            }

            if (escape) throw new Exception("Invalid group ending");

            WTReGroup g = groupFromNodes(nodes, enclosed);
            g.sourceRange = new NSRange(range.location + startPos, endPos - startPos);
            g.capturing = enclosed;

            if (alternations != null) {
                // build alternation and enclose it into group
                alternations.Add(g);

                WTReAlteration a = new WTReAlteration();
                a.children = alternations;
                a.sourceRange = new NSRange(range.location, endPos);

                // setup links
                WTReNode prev = alternations[0];
                prev.parent = a;

                for (int i = 1; i < alternations.Count; i++) {
                    WTReNode curr = alternations[i];
                    curr.parent = a;
                    prev.nextSibling = curr;
                    prev = curr;
                }

                g = new WTReGroup();
                g.children = new List<WTReNode>();
                g.children.Add(a);
                g.capturing = enclosed;
                g.sourceRange = a.sourceRange;

                a.parent = g;
            }
            return g;
        }

        public string reformatString(string input)
        {
            StringBuilder builder = new StringBuilder(input);
            // empty strings are ok
            if (input == null || input.Equals("")) return input;


            WTState initialState = new WTState();
            WTState finalState = processNode(node, initialState, input.Length);

            WTState x = stateDSF(initialState, finalState, builder, 0);

            if (x == null)
                return null;
            return x.isFinal? builder.ToString() : null;
        }

        WTState processNode(WTReNode node, WTState state, int length)
        {
            if (node is WTReEndOfString)
            {
                WTState finalState = new WTState();;
                finalState.isFinal = true;

                WTTransition tran = new WTTransition();
                tran.node = (WTReCharacterBase)node;
                tran.nextState = finalState;
                state.transitions.Add(tran);

                return finalState;
            }
            else if (node is WTReCharacterBase)
            {
                WTState finalState = new WTState();

                WTTransition tran = new WTTransition();;
                tran.node = (WTReCharacterBase)node;
                tran.nextState = finalState;
                state.transitions.Add(tran);

                return finalState;
            }
            else if (node is WTReQuantifier)
            {
                WTReQuantifier qtf = (WTReQuantifier)node;

                WTState curState = state;
                for (int i = 0; i < qtf.countFrom; i++) {
                    curState = processNode(qtf.child, curState, length);
                }

                if (qtf.countTo == qtf.countFrom)
                {
                    // strict quantifier
                    return curState;
                }

                WTState finalState = new WTState();;

                for (int i = qtf.countFrom; i < Math.Min(qtf.countTo, length); i++) {
                    WTState nextState = processNode(qtf.child, curState, length);

                    WTTransition _tran = new WTTransition();
                    _tran.node = null;
                    _tran.nextState = finalState;

                    if (qtf.greedy)
                        curState.transitions.Add(_tran);
                    else
                        curState.transitions.Insert(0, _tran);

                    curState = nextState;
                }

                WTTransition tran = new WTTransition();
                tran.node = null;
                tran.nextState = finalState;
                curState.transitions.Add(tran);

                return finalState;
            }
            else if (node is WTReGroup)
            {
                WTReGroup grp = (WTReGroup)node;

                WTState curState = state;
                for (int i = 0; i < grp.children.Count; i++) {
                    curState = processNode(grp.children[i], curState,length);
                }

                if (!grp.capturing && grp.children.Count == 1 && (grp.children[0] is WTReLiteral))
                {
                    WTTransition tran = new WTTransition();
                    tran.node = null;
                    tran.bypassNode = (WTReLiteral)grp.children[0];
                    tran.nextState = curState;
                    state.transitions.Add(tran);
                }

                return curState;
            }
            else if (node is WTReAlteration)
            {
                WTReAlteration alt = (WTReAlteration)node;

                WTState finalState = new WTState();

                for (int i = 0; i < alt.children.Count; i++) {
                    WTState curState = processNode(alt.children[i],state, length);

                    WTTransition tran = new WTTransition();
                    tran.node = null;
                    tran.nextState = finalState;
                    curState.transitions.Add(tran);
                }

                return finalState;
            }
            else
            {
                return null;
            }
        }

        WTState stateDSF(WTState initial, WTState fin, StringBuilder input, int startPos)
        {
            List<PathEntry> path = new List<PathEntry>();

            path.Add(new PathEntry(initial, startPos));

            while (path.Count > 0) {
                int depth = path.Count - 1;

                WTState parent = path[depth].getState();
                int vertexNum = path[depth].getVertex();
                int position = path[depth].getPosition();

                if (parent != null && parent.isFinal) {
                    try {
                        for (int i = path.Count - 1; i > 0; i --) {
                            WTTransition tran = path[i - 1].getState().transitions[path[i - 1].getVertex() - 1];
                            if (tran.bypassNode != null)
                                input.Insert(path[i].getPosition(), tran.bypassNode.character.ToString());
                        }
                    } catch (Exception e) {
                        //e.printStackTrace();
                    }
                    return parent;
                }

                if (position > input.Length) {
                    path[depth].setVertex(vertexNum + 1);
                    path.Add(new PathEntry(fin));
                    continue;
                }

                if (parent != null && parent.transitions.Count > vertexNum) {
                    WTTransition nextTransition = parent.transitions[vertexNum];

                    if (nextTransition.node != null) {
                        char c = (position < input.Length) ? input[position] : (char)0;
                        if (!nextTransition.node.matchesCharacter(c)) {
                            if (c == 0) {
                                path[depth].setVertex(vertexNum + 1);
                                path.Add(new PathEntry(fin));
                                continue;
                            } else {
                                path[depth].setVertex(vertexNum + 1);
                                continue;
                            }
                        } else {

                        }
                        position ++;
                    }

                    path[depth].setVertex(vertexNum + 1);
                    path.Add(new PathEntry(nextTransition.nextState, position));
                } else {
                    path.RemoveAt(depth);
                }
            }
            return null;
        }

        WTState nextState(WTState state, WTState fin, StringBuilder input, int pos)
        {
            if (state.isFinal) return state;

            if (pos > input.Length) return fin;

            foreach (WTTransition tran in state.transitions) {

                int nextPos = pos;

                if (tran.node != null) {
                    char c = (pos < input.Length) ? input[pos] : (char)0;
                    if (!tran.node.matchesCharacter(c))
                    {
                        if (c == 0) return fin;
                        continue;
                    }
                    else
                    {

                    }
                    nextPos += 1;
                }

                WTState s = nextState(tran.nextState, fin, input, nextPos);
                if (s != null && s.isFinal)
                {
                    if (tran.bypassNode != null)

                        input.Insert(nextPos, tran.bypassNode.character.ToString());

                    return s;
                }
            }

            return null;
        }

        private class PathEntry
        {
            private readonly WTState state;
            private int vertexIndex, position;

            public PathEntry(WTState state) {
                this.state = state;
                this.vertexIndex = 0;
                this.position = 0;
            }

            public PathEntry(WTState state, int position) {
                this.state = state;
                this.vertexIndex = 0;
                this.position = position;
            }

            public WTState getState() {
                return state;
            }

            public int getVertex() {
                return vertexIndex;
            }

            public void setVertex(int integer) {
                vertexIndex = integer;
            }

            public void setPosition(int position) {
                this.position = position;
            }

            public int getPosition() {
                return position;
            }
        }
    }
}
