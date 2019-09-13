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
    public partial class DialogPurchases : Form
    {
        public bool Cancelled { get; private set; } = false;
        public List<Purchase> Purchases
        {
            get
            {
                return Utils.GetPurchasesFromJson(edt_Json.Text);
            }
        }

        public DialogPurchases()
        {
            InitializeComponent();
            VisibleChanged += DialogPurchases_VisibleChanged;
        }

        private void DialogPurchases_VisibleChanged(object sender, EventArgs e)
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
