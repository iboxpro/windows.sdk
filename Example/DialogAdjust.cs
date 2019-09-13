using Ibox.Pro.SDK.External;
using Ibox.Pro.SDK.External.Result;
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
    public partial class DialogAdjust : Form
    {
        public string TransactionID
        {
            get
            {
                return edt_AdjustTrId.Text;
            }
            set
            {
                edt_AdjustTrId.Text = value;
            }
        }
        public string Email
        {
            get
            {
                return edt_AdjustEmail.Text;
            }
            set
            {
                edt_AdjustEmail.Text = value;
            }
        }
        public string Phone
        {
            get
            {
                return edt_AdjustPhone.Text;
            }
            set
            {
                edt_AdjustPhone.Text = value;
            }
        }

        public Action<string> Log { get; set; }
        public Action CheckCredentials { get; set; }

        public DialogAdjust()
        {
            InitializeComponent();
        }

        private void adjustPayment()
        {
            Log(MainForm.DIVIDER);
            Log("STARTING ADJUST");

            CheckCredentials();

            string TransactionID = this.TransactionID;
            string Email = this.Email;
            string Phone = this.Phone;
            Task adjustTask = Task.Factory.StartNew(() =>
            {
                APIResult result = null;
                if (rb_AdjustSimple.Checked)
                {
                    result = PaymentController.Instance.Adjust(TransactionID, Email, Phone);
                }
                else if (rb_AdjustRegular.Checked)
                {
                    result = PaymentController.Instance.AdjustRegular(TransactionID, Email, Phone);
                }
                else if (rb_AdjustReverse.Checked)
                {
                    result = PaymentController.Instance.AdjustReverse(TransactionID, Email, Phone);
                }
                if (result != null && result.ErrorCode == 0)
                    Log("ADJUST FINISHED OK");
                else
                    Log(string.Format("ADJUST ERROR : {0}({1})", (result == null ? "null" : result.ErrorMessage), (result == null ? "null" : result.ErrorCode.ToString())));
                Log(MainForm.DIVIDER);
            });
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            adjustPayment();
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
