using Ibox.Pro.SDK.External;
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
    public partial class DialogFiscal : Form
    {
        public Action<string> Log { get; set; }
        public Action CheckCreadentials { get; set; }

        public DialogFiscal()
        {
            InitializeComponent();
        }

        private void SubmitFiscal()
        {
            CheckCreadentials();

            Log(MainForm.DIVIDER);
            try
            {
                string trID = edt_TrID.Text;
                string printerID = edt_PrinterSN.Text;
                int shift = int.Parse(edt_Shift.Text);
                int docSN = int.Parse(edt_DocNum.Text);
                string fdn = edt_FNum.Text;
                string fdm = edt_FSign.Text;
                string fs = edt_FStrorage.Text;
                DateTime fdt = dt_FDt.Value;

                Log("SUBMIT FISCAL DATA FOR TRAN ID : " + trID);
                var submitFiscalTask = Task.Factory.StartNew(() =>
                {
                    var result = PaymentController.Instance.SubmitFiscal(
                            trID,
                            printerID,
                            shift,
                            docSN,
                            fdn,
                            fdm,
                            fs,
                            fdt
                        );
                    if (result != null && result.ErrorCode == 0)
                    {
                        Log("SUBMIT FISCAL : SUCCESS");
                    }
                    else
                    {
                        Log(string.Format("SUBMIT FISCAL ERROR : {0}({1})", (result == null ? "null" : result.ErrorMessage), (result == null ? "null" : result.ErrorCode.ToString())));
                    }
                    Log(MainForm.DIVIDER);
                });
            }
            catch (FormatException ex)
            {
                Log("SUBMIT FISCAL ERROR : INVALID INPUT");
                Log(MainForm.DIVIDER);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SubmitFiscal();
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
