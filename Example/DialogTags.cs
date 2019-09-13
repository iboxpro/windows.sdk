using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class DialogTags : Form
    {
        public bool Cancelled { get; private set; } = false;
        public Dictionary<int, object> Tags
        {
            get
            {
                try
                {                
                    var tags = JObject.Parse(edt_Json.Text);
                    if (tags != null)
                    {
                        var result = new Dictionary<int, object>();
                        foreach (var keyValue in tags)
                        {
                            int tagNum = 0;
                            if (int.TryParse(keyValue.Key, out tagNum) && tagNum > 0)
                            {
                                switch (keyValue.Value.Type)
                                {
                                    case JTokenType.String:
                                        result.Add(tagNum, keyValue.Value.ToObject<string>());
                                        break;
                                    case JTokenType.Integer:
                                        result.Add(tagNum, keyValue.Value.ToObject<int>());
                                        break;
                                    case JTokenType.Float:
                                        result.Add(tagNum, keyValue.Value.ToObject<float>());
                                        break;
                                    default:
                                        return null;
                                }
                            }
                        }
                        return result;
                    }
                } 
                catch (Exception)
                {
                }
                return null;
            }
        }

        public DialogTags()
        {
            InitializeComponent();
            VisibleChanged += DialogTags_VisibleChanged;
            btn_OK.Click += btn_OK_Click;
            btn_Cancel.Click += btn_Cancel_Click;
        }

        private void DialogTags_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                Cancelled = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
