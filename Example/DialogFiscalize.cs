using Ibox.Pro.SDK.External;
using Newtonsoft.Json;
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
    public partial class DialogFiscalize : Form
    {
        public Action<string> Log { get; set; }
        public Action CheckCreadentials { get; set; }

        public DialogFiscalize()
        {
            InitializeComponent();
        }

        /*
         * 
        var transaction = result.TransactionItem;
        var uptime = new DateTime();
        var timeout = new TimeSpan(0, 1, 0);
        int i = 0;
        while (transaction.FiscalInfo == null || (transaction.FiscalInfo.FiscalStatus != FiscalStatus.Success && transaction.FiscalInfo.FiscalStatus != FiscalStatus.Failure))
        {
            if (new DateTime() - uptime > timeout)
            {
                log("Cancelling fiscal data request by timeout");
                break;
            }
            Thread.Sleep(5000);
            var statusRequestResult = PaymentController.Instance.TryGetFiscalInfo(transaction.ID);
            log("Get fiscal data attempt " + ++i);
            if (statusRequestResult != null && statusRequestResult.ErrorCode == 0)
            {
                if (statusRequestResult.Transaction != null)
                {
                    transaction = statusRequestResult.Transaction;
                    log(JsonConvert.SerializeObject(transaction.FiscalInfo, Formatting.Indented));
                }
                else
                    log("Failed : transaction not found or not unique");
            }
            else
                log("Failed : " + statusRequestResult == null ? "null" : statusRequestResult.ErrorMessage); 
         */

        private void Fiscalize()
        {
            CheckCreadentials();
            Log(MainForm.DIVIDER);

            string trID = edt_TrID.Text;
            Log("REQUEST FISCALIZE FOR TRAN ID : " + trID);
            var submitFiscalTask = Task.Factory.StartNew(() =>
            {
                var result = PaymentController.Instance.Fiscalize(trID);
                
                if (result != null && result.ErrorCode == 0)
                {
                    Log("FISCALIZE FINISHED :");
                    Log(result.Transaction == null ? "NULL" : JsonConvert.SerializeObject(result.Transaction, Formatting.Indented));
                }
                else
                {
                    Log(string.Format("FISCALIZEL ERROR : {0}({1})", (result == null ? "null" : result.ErrorMessage), (result == null ? "null" : result.ErrorCode.ToString())));
                }
                Log(MainForm.DIVIDER);
            });
            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Fiscalize();
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
