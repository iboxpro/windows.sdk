using Ibox.Pro.SDK.External.Context;
using Ibox.Pro.SDK.External.Entry;
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
    public partial class DialogReverse : Form
    {
        public Action Reverse { get; set; }

        public DialogReverse()
        {
            InitializeComponent();
        }

        public void SetContextValues(ReversePaymentContext reverseContext)
        {
            string trID = edt_ReverseID.Text;
            ReverseMode mode = rb_Cancel.Checked ? ReverseMode.Cancel : ReverseMode.Return;
            decimal? amountToReverse = string.IsNullOrEmpty(edt_ReverseAmount.Text) ? null : (decimal?)decimal.Parse(edt_ReverseAmount.Text);

            reverseContext.TransactionID = trID.Trim();
            reverseContext.Mode = mode;
            reverseContext.AmountToReverse = amountToReverse;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
            Reverse();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
