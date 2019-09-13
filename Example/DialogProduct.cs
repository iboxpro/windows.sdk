using Ibox.Pro.SDK.External;
using Ibox.Pro.SDK.External.Entry;
using Ibox.Pro.SDK.External.Result;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class DialogProduct : Form
    {
        public Action<string> Logger { get; set; }

        private List<TextInputListener> m_Listeners = new List<TextInputListener>();

        private List<PaymentProduct> m_Products;
        public List<PaymentProduct> Products
        {
            get
            {
                return m_Products;
            }
            set
            {
                clear();
                m_Products = value;
                cb_Product.DataSource = m_Products;
                cb_Product.DisplayMember = "Title";
            }
        }

        public PaymentProduct CurrentProduct
        {
            get
            {
                return cb_Product.SelectedIndex >= 0 ? Products[cb_Product.SelectedIndex] : null;
            }
        }
        public string ReceiptEmail
        {
            get
            {
                if (CurrentProduct != null)
                {
                    var fields = CurrentProduct.Fields?.Where(f => f.ReceiptEmail);
                    if (fields != null && fields.Count() > 0)
                        return TextValues[fields.First().Code];
                }
                return null;
            }
        }
        public string ReceiptPhone
        {
            get
            {
                if (CurrentProduct != null)
                {
                    var fields = CurrentProduct.Fields?.Where(f => f.ReceiptPhone);
                    if (fields != null && fields.Count() > 0)
                        return TextValues[fields.First().Code];
                }
                return null;
            }
        }
        public decimal? PreparedAmount { get; private set; }


        public Dictionary<string, string> TextValues
        {
            get
            {
                if (CurrentProduct != null && CurrentProduct.Fields != null)
                {
                    Dictionary<string, string> result = new Dictionary<string, string>();
                    foreach (var field in CurrentProduct.Fields.Where(f => f.InputType == PaymentProductField.Type.Text))
                    {
                        var textView = tlp_Fields.Controls.Find(field.Code, false);
                        if (textView != null && textView.Length == 1)
                        {
                            if (textView[0].GetType() == typeof(TextBox))
                                result.Add(field.Code, ((TextBox)textView[0]).Text);
                        }
                    }
                    return result;
                }
                return null;
            }
        }
        public Dictionary<string, byte[]> ImageValues
        {
            get
            {
                if (CurrentProduct != null && CurrentProduct.Fields != null)
                {
                    Dictionary<string, byte[]> result = new Dictionary<string, byte[]>();
                    foreach (var field in CurrentProduct.Fields.Where(f => f.InputType == PaymentProductField.Type.Image))
                    {
                        var textView = tlp_Fields.Controls.Find(field.Code, false);
                        if (textView != null && textView.Length == 1)
                        {
                            if (textView[0].GetType() == typeof(TextBox))
                            {
                                string path = ((TextBox)textView[0]).Text;
                                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                                {
                                    try
                                    {
                                        var image = File.ReadAllBytes(path);
                                        result.Add(field.Code, image);
                                    }
                                    catch
                                    {
                                        log("ERROR : CANT READ IMAGE " + field.Title);
                                    }
                                }
                            }
                        }
                    }
                    return result;
                }
                return null;
            }
        }
        
        public string ValidReport
        {
            get
            {
                if (CurrentProduct != null)
                {
                    if (CurrentProduct.Fields != null)
                    {
                        foreach (var field in CurrentProduct.Fields)
                        {
                            switch (field.InputType)
                            {
                                case PaymentProductField.Type.Image:
                                    if (field.Required && ImageValues[field.Code] == null)
                                        return "Invalid value: " + field.Title;
                                    break;
                                case PaymentProductField.Type.Text:
                                    try
                                    {
                                        var regex = field.TextRegExp;
                                        var value = TextValues[field.Code];
                                        var required = field.Required;

                                        bool valid = string.IsNullOrEmpty(regex)
                                            ? !string.IsNullOrEmpty(value) || !required
                                            : (!string.IsNullOrEmpty(value) ? new Regex(regex).Match(value).Success : !required);
                                        if (!valid)
                                            return "Invalid value: " + field.Title;
                                    }
                                    catch
                                    {
                                        return "Invalid value: " + field.Title;
                                    }

                                    break;
                            }
                        }
                    }
                    return "";
                }
                return "Invalid product";
            }
        }

        public DialogProduct()
        {
            InitializeComponent();
            VisibleChanged += DialogProduct_VisibleChanged;
        }

        private void log(string log)
        {
            if (Logger != null)
                Logger(log);
        }

        private void clear()
        {
            PreparedAmount = null;
            cb_Product.SelectedIndex = -1;
            m_Listeners.Clear();
            tlp_Fields.Controls.Clear();
            tlp_Fields.RowStyles.Clear();
        }
        
        private void applyPrepared(APIPrepareResult prepareResult)
        {
            if (prepareResult != null)
            {
                if (prepareResult.ErrorCode == 0)
                {
                    log(JsonConvert.SerializeObject(prepareResult.PreparedFields, Formatting.Indented));
                    if (prepareResult.PreparedFields != null)
                    {
                        foreach (var prepared in prepareResult.PreparedFields)
                        {
                            if (prepared.IsPaymentAmount)
                            {
                                decimal preparedAmount = -1;
                                if (!decimal.TryParse(prepared.Value, NumberStyles.Number, CultureInfo.InvariantCulture, out preparedAmount))
                                    MessageBox.Show("Invalid amount", "Prepare failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else if (preparedAmount != -1)
                                    PreparedAmount = preparedAmount;
                            }
                            else
                            {
                                var fields = CurrentProduct.Fields.Where(f => f.Code.Equals(prepared.Code));
                                var field = fields != null && fields.Count() > 0 ? fields.First() : null;
                                if (field != null && field.InputType == PaymentProductField.Type.Text)
                                {
                                    var fieldEditText = tlp_Fields.Controls.Find(field.Code, false);
                                    if (fieldEditText != null && fieldEditText.Length > 0)
                                        (fieldEditText[0] as TextBox).Text = prepared.Value;
                                    else
                                    {
                                        var label = new Label()
                                        {
                                            Text = field.Title + ":",
                                            Anchor = AnchorStyles.Left,
                                            AutoSize = true,
                                            Dock = DockStyle.Fill,
                                            Enabled = field.UserVisible && CurrentProduct.PreparableEditable,
                                        };
                                        var textBox = new TextBox()
                                        {
                                            Dock = DockStyle.Fill,
                                            Enabled = field.UserVisible && CurrentProduct.PreparableEditable,
                                            Multiline = field.TextMultiLine,
                                            ScrollBars = field.TextMultiLine ? ScrollBars.Vertical : ScrollBars.None,
                                            WordWrap = field.TextMultiLine,
                                            Name = field.Code,
                                            Tag = field.InputType
                                        };
                                        if (!string.IsNullOrEmpty(field.TextMask))
                                        {
                                            TextInputListener inputListener = new TextInputListener(this, field);
                                            m_Listeners.Add(inputListener);
                                            textBox.TextChanged += inputListener.TextBox_TextChanged;
                                        }
                                        textBox.Text = prepared.Value;
                                        tlp_Fields.Controls.Add(label, 0, tlp_Fields.RowCount);
                                        tlp_Fields.Controls.Add(textBox, 1, tlp_Fields.RowCount++);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(prepareResult.ErrorMessage, "Prepare failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log(string.Format("PREPARE ERROR : {0}({1})", prepareResult.ErrorMessage, prepareResult.ErrorCode.ToString()));
                }
            }
            else
            {
                MessageBox.Show("Connection error", "Prepare failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log(string.Format("PREPARE ERROR : {0}({1})", "null", "null"));
            }
            log(MainForm.DIVIDER);
        }

        private void btn_Prepare_Click(object sender, EventArgs e)
        {
            if (CurrentProduct != null)
            {
                btn_Prepare.Enabled = false;
                var currentProduct = CurrentProduct.Code;

                Dictionary<string, string> valuesForPrepare = new Dictionary<string, string>();
                foreach (var field in CurrentProduct.Fields.Where(f => f.InputType == PaymentProductField.Type.Text && f.Preparable))
                {
                    var textView = tlp_Fields.Controls.Find(field.Code, false);
                    if (textView != null && textView.Length == 1)
                    {
                        if (textView[0].GetType() == typeof(TextBox))
                            valuesForPrepare.Add(field.Code, ((TextBox)textView[0]).Text);
                    }
                }

                log(MainForm.DIVIDER);
                log("PREPARE");
                log(JsonConvert.SerializeObject(valuesForPrepare, Formatting.Indented));
                Task.Factory.StartNew(() =>
                {
                    var prepareResult = PaymentController.Instance.Prepare(currentProduct, valuesForPrepare);
                        Invoke((MethodInvoker)delegate
                        {
                            log("PREPARE RESULT:");
                            applyPrepared(prepareResult);
                            btn_Prepare.Enabled = true;
                        });
                    }
                );
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            var validReport = ValidReport;
            if (!string.IsNullOrEmpty(validReport))
                MessageBox.Show(validReport, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Close();

        }
        
        private void cb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreparedAmount = null;
            m_Listeners.Clear();
            tlp_Fields.Controls.Clear();
            tlp_Fields.RowStyles.Clear();
            if (CurrentProduct != null && CurrentProduct.Fields != null)
            {
                var preparable = CurrentProduct.Preparable;
                btn_Prepare.Enabled = preparable;

                foreach (var field in CurrentProduct.Fields)
                {
                    if (!preparable || CurrentProduct.PrepareOptional || field.Preparable)
                    {
                        var label = new Label()
                        {
                            Text = field.Title + (field.InputType == PaymentProductField.Type.Text ? ":" : " (img) : "),
                            Anchor = AnchorStyles.Left,
                            AutoSize = true,
                            Dock = DockStyle.Fill,
                            Enabled = field.UserVisible

                        };
                        var textBox = new TextBox()
                        {
                            Dock = DockStyle.Fill,
                            Enabled = field.UserVisible,
                            Multiline = field.TextMultiLine,
                            ScrollBars = field.TextMultiLine ? ScrollBars.Vertical : ScrollBars.None,
                            WordWrap = field.TextMultiLine,
                            Name = field.Code,
                            Tag = field.InputType
                        };
                        if (!string.IsNullOrEmpty(field.TextMask))
                        {
                            TextInputListener inputListener = new TextInputListener(this, field);
                            m_Listeners.Add(inputListener);
                            textBox.TextChanged += inputListener.TextBox_TextChanged;
                        }
                        textBox.Text = field.InputType == PaymentProductField.Type.Text ? field.DefaultValue : "";
                        tlp_Fields.Controls.Add(label, 0, tlp_Fields.RowCount);
                        tlp_Fields.Controls.Add(textBox, 1, tlp_Fields.RowCount++);
                    }
                }
            }
        }

        private void DialogProduct_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (CurrentProduct == null)
                    if (Products != null && Products.Count > 0)
                        cb_Product.SelectedIndex = 0;

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private class TextInputListener
        {
            private PaymentProductField field;
            private WTReParser parser;
            private string lastAcceptedValue = "";

            public TextInputListener(DialogProduct parent, PaymentProductField field)
            {
                try
                {
                    parser = new WTReParser(field.TextMask);
                }
                catch
                {
                    var textViews = parent.tlp_Fields.Controls.Find(field.Code, false);
                    if (textViews != null && textViews.Count() > 0)
                        textViews.First().Enabled = false;
                }
            }

            public void TextBox_TextChanged(object sender, EventArgs e)
            {
                if (sender is TextBox)
                    ProcessTextChanged((sender as TextBox).Text, sender as TextBox);
            }

            public void ProcessTextChanged(string newText, TextBox edtText)
            {
                edtText.TextChanged -= TextBox_TextChanged;
                try 
                {
                    string str = parser.reformatString(newText);
                    if (str != null)
                    {
                        edtText.Text = str;
                        lastAcceptedValue = str;
                    }
                    else
                    {
                        edtText.Text = lastAcceptedValue;
                    }
                    edtText.SelectionStart = edtText.Text.Length;
                    edtText.SelectionLength = 0;
                }
                catch
                {

                }
                edtText.TextChanged += TextBox_TextChanged;
            }
        }

    }
}
