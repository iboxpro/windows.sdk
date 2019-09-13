using Ibox.Pro.SDK.External;
using Ibox.Pro.SDK.External.Entry;
using Ibox.Pro.SDK.External.Result;
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
    public partial class DialogHistory : Form
    {
        public Action<string> Log { get; set; }
        public Action<string, Color?, bool> LogExtended { get; set; }
        public Action CheckCredentials { get; set; }
        public Func<Transaction, string> BuildInvoice { get; set; }

        public DialogHistory()
        {
            InitializeComponent();
            AcceptButton = btn_OK;
            CancelButton = btn_Cancel;
            pan_History.Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.CheckedChanged += Rb_CheckedChanged);
            rb_Page.Checked = true;
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            var button = (sender as RadioButton);
            if (button.Checked)
                pan_History.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Enabled = tb.Location.Y == button.Location.Y);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            CheckCredentials();
            var selected = pan_History.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            var selectedValue = pan_History.Controls.OfType<TextBox>().FirstOrDefault(n => n.Enabled).Text;

            if (selected != null)
            {
                Log(MainForm.DIVIDER);
                Task getHistoryTask = Task.Factory.StartNew(() =>
                {
                    try
                    {
                        APIGetHistoryResult result = getHistory(selected, selectedValue);
                        if (result != null && result.ErrorCode == 0)
                        {
                            List<Transaction> transactions = new List<Transaction>();
                            if (result.InProcessTransactions != null)
                                transactions.AddRange(result.InProcessTransactions);
                            if (result.Transactions != null)
                                transactions.AddRange(result.Transactions);
                            if (transactions != null)
                            {
                                if (selected == rb_Page)
                                {
                                    Log(string.Format("{0,-18}  {1,-25} {2,-10} {3}", "DateTime", "Description", "Balance", "ID"));
                                    foreach (Transaction transaction in transactions)
                                    {
                                        Color color = Color.Black;
                                        switch (transaction.DisplayMode)
                                        {
                                            case DisplayMode.Success:
                                                color = Color.Green;
                                                break;
                                            case DisplayMode.Reverse:
                                            case DisplayMode.Reversed:
                                                color = Color.SlateGray;
                                                break;
                                            case DisplayMode.Declined:
                                                color = Color.OrangeRed;
                                                break;
                                        }
                                        string description = transaction.Description;
                                        if (result.InProcessTransactions != null && result.InProcessTransactions.Contains(transaction))
                                            description += "    (IN PROCESS)";
                                        LogExtended(string.Format("{0,-17:dd.MM.yyyy hh:mm}   {1,-25} {2,-10} {3}",
                                            transaction.Date, description, string.Format(transaction.AmountFormat, transaction.Balance), transaction.ID),
                                            color, !transaction.Canceled);
                                    }
                                }
                                else
                                {
                                    if (transactions.Count == 1)
                                    {
                                        Log(JsonConvert.SerializeObject(transactions[0], Formatting.Indented));
                                        Log(BuildInvoice(transactions[0]));
                                    }
                                    else
                                        Log("GET HISTORY ERROR : TRANSACTION NOT FOUND OR NOT UNIQUE");

                                }
                            }
                        }
                        else
                        {
                            Log(string.Format("GET HISTORY ERROR : {0}({1})", (result == null ? "null" : result.ErrorMessage), (result == null ? "null" : result.ErrorCode.ToString())));
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Log(string.Format("GET HISTORY ERROR : {0}", ex.Message));
                    }
                    Log(MainForm.DIVIDER);
                });
            }
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            edt_Page.Text = "1";
            edt_TrID.Text = "";
            edt_Invoice.Text = "";
            edt_RRN.Text = "";
            rb_Page.Checked = true;
            Close();
        }
        
        private APIGetHistoryResult getHistory(RadioButton selected, string value)
        {
            if (selected == rb_Page)
            {
                int page = 0;
                try
                {
                    page = int.Parse(value);
                    Log(string.Format("GET HISTORY BY PAGE #{0} :", page));
                    return PaymentController.Instance.GetHistory(page);
                }
                catch (FormatException)
                {
                    throw new ArgumentException("GET HISTORY ERROR : INVALID PAGE NUM");
                }
            }
            else if (selected == rb_TrID)
            {
                Log(string.Format("GET HISTORY BY TRAN ID #{0} :", value));
                return PaymentController.Instance.GetTransactionByID(value);
            }
            else if (selected == rb_Invoice)
            {
                Log(string.Format("GET HISTORY BY INVOICE #{0} :", value));
                return PaymentController.Instance.GetTransactionByInvoice(value);
            }
            else if (selected == rb_RRN)
            {
                Log(string.Format("GET HISTORY BY RRN #{0} :", value));
                return PaymentController.Instance.GetTransactionByRRN(value);
            }
            else
            {
                throw new ArgumentException("GET HISTORY ERROR : INVALID SELECTION");
            }
        }
    }
}
