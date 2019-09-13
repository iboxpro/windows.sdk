using System;
using System.Windows.Forms;

using Ibox.Pro.SDK.External;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using Ibox.Pro.SDK.External.Result;
using System.IO;
using System.Management;
using Ibox.Pro.SDK.External.Context;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;

using InTheHand.Net.Sockets;
using InTheHand.Net;
using Ibox.Pro.SDK.External.Entry;
using Newtonsoft.Json;
using System.Text;

namespace Example
{
    public partial class MainForm : Form
    {
        public static readonly string DIVIDER = new string('=', 93);
        private const string ExtID = "TEST_APP_DOT_NET";       
               
        private Font fntRegular = new Font("Courier New", 8.25F);
        private Font fntStrikeout = new Font("Courier New", 8.25F, FontStyle.Strikeout);
        private DialogProduct dlgProduct = new DialogProduct();
        private DialogHistory dlgHistory = new DialogHistory();
        private DialogRegular dlgRegular = new DialogRegular();
        private DialogAdjust dlgAdjust = new DialogAdjust();
        private DialogPurchases dlgPurchases = new DialogPurchases();
        private DialogTags dlgTags = new DialogTags();
        private DialogReverse dlgReverse = new DialogReverse();
        private DialogFiscal dlgFiscal = new DialogFiscal();
        private DialogFiscalize dlgFiscalize = new DialogFiscalize();

        private PaymentController m_PaymentController = PaymentController.Instance;
        private APIAuthResult m_AuthResult;
        private List<LinkedCard> m_LinkedCards;
        private List<PortInfo> portInfos = new List<PortInfo>();

        public MainForm()
        {
            InitializeComponent();
            initControls();
            m_PaymentController.ClientProductCode = "SHARP_SDK_EXAMPLE";
            m_PaymentController.SelectApplicationDelegate = onRequestSelectApplication;
            m_PaymentController.ConfirmScheduleDelegate = onRequestConfirmSchedule;
            m_PaymentController.ScheduleCreationFailedDelegate = onScheduleCreationFailed;
            m_PaymentController.SelectInputTypeDelegate = onRequestSelectInputType;
            m_PaymentController.CancellationTimeoutDelegate = onCancellationTimeout;

            m_PaymentController.ErrorEvent += onPaymentError;
            m_PaymentController.ReaderEvent += onReaderEvent;
            m_PaymentController.TransactionStartedEvent += onTransactionStarted;
            m_PaymentController.TransactionFinishedEvent += onPaymentFinished;
            m_PaymentController.ReverseEvent += onReverseEvent;

            dlgProduct.FormClosing += DlgProduct_FormClosing;
            dlgProduct.Logger = delegate (string s_log) { log(s_log); };

            dlgHistory.Log = delegate (string s_log) { log(s_log); };
            dlgHistory.LogExtended = log;
            dlgHistory.CheckCredentials = checkCredentials;
            dlgHistory.BuildInvoice = delegate (Transaction transaction) 
            {
                if (m_AuthResult != null)
                    return Utils.BuildInvoice(m_AuthResult.Account, transaction);
                return "";
            };

            dlgRegular.FormClosing += DlgRegular_FormClosing;

            dlgAdjust.Log = delegate (string s_log) { log(s_log); };
            dlgAdjust.CheckCredentials = checkCredentials;

            dlgPurchases.FormClosing += DlgPurchases_FormClosing;
            dlgTags.FormClosing += DlgTags_FormClosing;

            dlgReverse.Reverse = reversePayment;

            dlgFiscal.Log = delegate (string s_log) { log(s_log); };
            dlgFiscal.CheckCreadentials = checkCredentials;

            dlgFiscalize.Log = delegate (string s_log) { log(s_log); };
            dlgFiscalize.CheckCreadentials = checkCredentials;
        }

        private void initControls()
        {
            cb_Product.Enabled = false;
        }

        private void checkCredentials()
        {
            if (!edt_Login.Text.Equals(m_PaymentController.Credentials.Email) || !edt_Password.Text.Equals(m_PaymentController.Credentials.Password))
                m_PaymentController.Credentials = new Credentials()
                {
                    Email = edt_Login.Text,
                    Password = edt_Password.Text
                };
        }

        private void log(string log, Color? color = null, bool strikethrough = false)
        {
            try
            {
                if (!this.Disposing && !this.IsDisposed)
                    this.Invoke((MethodInvoker)delegate
                        {
                            try
                            {
                                if (!edt_Log.Disposing && !edt_Log.IsDisposed)
                                {

                                    if (color == null)
                                        edt_Log.SelectionColor = Color.Black;
                                    else
                                        edt_Log.SelectionColor = (Color)color;

                                    if (strikethrough)
                                        edt_Log.SelectionFont = fntStrikeout;
                                    else
                                        edt_Log.SelectionFont = fntRegular;

                                    edt_Log.AppendText(log + Environment.NewLine);
                                    edt_Log.SelectionStart = edt_Log.Text.Length;
                                    edt_Log.ScrollToCaret();
                                }
                            }
                            catch (ObjectDisposedException e)
                            {

                            }
                        });
            }
            catch (ObjectDisposedException e)
            {

            }
        }

        private void startPayment()
        {
            checkCredentials();

            PaymentController.Instance.SinglestepEMV = cb_SinglestepEMV.Checked;
            bool hasProduct = cb_Product.Checked;
            bool isRegular = cb_Regular.Checked;
            PaymentContext paymentContext = isRegular ? new RegularPaymentContext() : new PaymentContext();
            paymentContext.Amount = decimal.Parse(edt_Amount.Text);
            paymentContext.Currency = rb_RUB.Checked ? Currency.RUB : Currency.VND;
            paymentContext.Description = edt_Description.Text;
            paymentContext.ReceiptEmail = edt_Email.Text;
            paymentContext.ReceiptPhone = edt_Phone.Text;
            paymentContext.ExtID = ExtID;


            if (cb_Purchases.Checked)
            {
               List<Purchase> purchases = dlgPurchases.Purchases;

                if (purchases == null)
                {
                    MessageBox.Show("Couldn't parse purchases!");
                }
                else
                {
                    foreach (Purchase p in purchases)
                        paymentContext.PutPurchase(p);
                }
            }

            if (cb_Tags.Checked)
            {
                var tags = dlgTags.Tags;

                if (tags == null)
                {
                    MessageBox.Show("Couldn't parse tags!");
                }
                else
                {
                    foreach (var tag in tags)
                        paymentContext.PutInvoiceTag(tag.Key, tag.Value);
                }
            }

            if (rb_Card.Checked)
                paymentContext.Method = PaymentMethod.Card;
            else if (rb_Cash.Checked)
            {
                paymentContext.Method = PaymentMethod.Cash;
                decimal cashGot= paymentContext.Amount;
                string s_AmountCashGot = Utils.ShowDialog("Cash got", cashGot.ToString("F2"));
                if (s_AmountCashGot == null || !decimal.TryParse(s_AmountCashGot, out cashGot))
                    return;
                paymentContext.AmountCashGot = cashGot;
            }
            else if (rb_Credit.Checked)
                paymentContext.Method = PaymentMethod.Credit;
            else if (rb_Link.Checked)
                paymentContext.Method = PaymentMethod.Other;
            else if (rb_Outer.Checked)
                paymentContext.Method = PaymentMethod.OuterCard;
            else if (rb_LinkedCard.Checked)
            {

                APIReadLinkedCardsResult result = PaymentController.Instance.GetLinkedCards();
                if (result.ErrorCode == 0)
                    m_LinkedCards = result.LinkedCards;
                paymentContext.Method = PaymentMethod.LinkedCard;
                if (m_LinkedCards != null && m_LinkedCards.Count > 0)
                {
                    int selectedCardIndex = Utils.ShowDialog(m_LinkedCards.ConvertAll(c => c.Alias), "Select card");
                    if (selectedCardIndex >= 0)
                    {
                        var selectedCard = m_LinkedCards[selectedCardIndex];
                        log("CARD " + selectedCard.ID + " ALIAS " + selectedCard.Alias);
                        paymentContext.LinkedCardID = selectedCard.ID;
                    }
                    else
                    {
                        log("ERROR : CANCEL SELECT CARD");
                        return;
                    }
                }
                else
                {
                    log("ERROR : NO LINKED CARDS");
                    return;
                }
            }

            string path = edt_ImageFilePath.Text;
            if (!string.IsNullOrEmpty(path))
            {
                if (File.Exists(path))
                {
                    try
                    {
                        paymentContext.Image = File.ReadAllBytes(path);
                    }
                    catch (Exception e)
                    {
                        log("ERROR : CANT READ IMAGE");
                        return;
                    }
                }
            }

            /*
            if (true)
            {
                paymentContext.PaymentProductCode = "TELE2";
                var paymentProductTextData = new Dictionary<string, string>(3);
                paymentProductTextData.Add("PHONE_NUMBER", edt_Field1.Text);
                paymentProductTextData.Add("AUTOPAY", "0");
                paymentProductTextData.Add("ReceiptEmail", "testibox85@gmail.com");
                paymentContext.PaymentProductTextDictionary = paymentProductTextData;
            }
            */

            
            if (hasProduct)
            {
                if (dlgProduct.CurrentProduct.Apply == PaymentProduct.PaymentType.None)
                {
                    log("ERROR : invalid product apply");
                    return;
                }
                else if (isRegular)
                {
                    if (dlgProduct.CurrentProduct.Apply == PaymentProduct.PaymentType.Payment)
                    {
                        log("ERROR : invalid product apply");
                        return;
                    }
                } 
                else
                {
                    if (dlgProduct.CurrentProduct.Apply == PaymentProduct.PaymentType.Recurrent)
                    {
                        log("ERROR : invalid product apply");
                        return;
                    }
                }
                

                paymentContext.PaymentProductCode = dlgProduct.CurrentProduct.Code;
                paymentContext.PaymentProductTextDictionary = dlgProduct.TextValues;
                paymentContext.PaymentProductImageDictionary = dlgProduct.ImageValues;
                if (dlgProduct.PreparedAmount != null)
                {
                    edt_Amount.Text = dlgProduct.PreparedAmount.ToString();
                    paymentContext.Amount = dlgProduct.PreparedAmount.Value;
                    log("Amount was changed according to product");
                }
                var email = dlgProduct.ReceiptEmail;
                var phone = dlgProduct.ReceiptPhone;
                if (email != null)
                {
                    edt_Email.Text = email;
                    paymentContext.ReceiptEmail = email;
                    log("Receipt notification data was changed according to product");
                }
                if (phone != null)
                {
                    edt_Phone.Text = phone;
                    paymentContext.ReceiptPhone = phone;
                    log("Receipt notification data was changed according to product");
                }
            }

            if (isRegular)
            {
                RegularPaymentContext regPaymentContext = paymentContext as RegularPaymentContext;

                if (string.IsNullOrEmpty(regPaymentContext.ReceiptEmail)  && string.IsNullOrEmpty(regPaymentContext.ReceiptPhone))
                {
                    log("ERROR : email or phone required");
                    return;
                }
                
                if (hasProduct && dlgProduct.CurrentProduct.RecurrentMode == PaymentProduct.ProductRecurrentMode.Managed)
                {
                    regPaymentContext.Managed = true;
                    regPaymentContext.PaymentRepeatType = RepeatType.DelayedOnce;
                    regPaymentContext.PaymentEndType = EndType.ByQuantity;
                    regPaymentContext.RepeatCount = 1;
                    regPaymentContext.StartDate = DateTime.Now;
                    regPaymentContext.EndDate = DateTime.Now;
                    regPaymentContext.ArbitraryDays = null;
                    regPaymentContext.Day = 0;
                    regPaymentContext.DayOfWeek = 0;
                    regPaymentContext.Hour = 0;
                    regPaymentContext.Minute = 0;
                    regPaymentContext.Month = 0;
                    log("Recurrent payment is managed by host!");
                }
                else
                {
                    dlgRegular.SetContextValues(regPaymentContext);
                }
            }

            if (paymentContext.Method != null)
                if (m_AuthResult != null && m_AuthResult.ErrorCode == 0 && m_AuthResult.Account != null)
                {
                    var acquirersByMethod = m_AuthResult.Account.AcquirersByMethods;
                    if (acquirersByMethod != null && acquirersByMethod.Count != 0)
                    {
                        if (acquirersByMethod.ContainsKey((PaymentMethod)paymentContext.Method))
                        {
                            var acquirers = acquirersByMethod[(PaymentMethod)paymentContext.Method];
                            if (acquirers.Count == 1)
                                paymentContext.AcquirerCode = acquirers.First().Key;
                            else {
                                int index = Utils.ShowDialog(acquirers.Values.ToList(), "Select acquirer");
                                paymentContext.AcquirerCode = acquirers.Keys.ToList()[Math.Max(0, index)];
                            }
                        }
                    }
                }

            try
            {
                m_PaymentController.StartPayment(paymentContext);
                log(DIVIDER);
                log(string.Format("STARTING NEW PAYMENT : {0}{1}", Environment.NewLine, JsonConvert.SerializeObject(paymentContext, Formatting.Indented)));
            }
            catch (InvalidOperationException e)
            {
                log(string.Format("ERROR : {0}", e.Message));
                return;
            }
        }

        private void reversePayment()
        {
            checkCredentials();

            try
            {
                var reverseContext = new ReversePaymentContext();
                dlgReverse.SetContextValues(reverseContext);
                reverseContext.ReceiptEmail = edt_Email.Text;
                reverseContext.ReceiptPhone = edt_Phone.Text;
                reverseContext.ExtID = ExtID;

                if (cb_Purchases.Checked)
                {
                    List<Purchase> purchases = dlgPurchases.Purchases;

                    if (purchases == null)
                    {
                        MessageBox.Show("Couldn't parse purchases!");
                    }
                    else
                    {
                        foreach (Purchase p in purchases)
                            reverseContext.PutPurchase(p);
                    }

                }

                if (cb_Tags.Checked)
                {
                    var tags = dlgTags.Tags;

                    if (tags == null)
                    {
                        MessageBox.Show("Couldn't parse tags!");
                    }
                    else
                    {
                        foreach (var tag in tags)
                            reverseContext.PutInvoiceTag(tag.Key, tag.Value);
                    }
                }

                m_PaymentController.StartReverse(reverseContext);
                log(DIVIDER);
                log(string.Format("{0} PAYMENT : {1}{2}", reverseContext.Mode == ReverseMode.Cancel ? "CANCEL" : "RETURN", Environment.NewLine, reverseContext.TransactionID));
            }
            catch (InvalidOperationException e)
            {
                log(string.Format("ERROR : {0}", e.Message));
                return;
            }
        }
        
        private void auth()
        {
            checkCredentials();
            log(DIVIDER);
            log("AUTH");

            Task authTask = Task.Factory.StartNew(() =>
            {
                var result = PaymentController.Instance.Auth();
                m_AuthResult = result;
                if (result != null && result.ErrorCode == 0)
                {
                    getLinkedCards();

                    dlgProduct.Products = m_AuthResult.Products;
                    cb_Product.Invoke((MethodInvoker)delegate
                    {
                        cb_Product.Checked = false;
                        cb_Product.Enabled = m_AuthResult.Products != null && m_AuthResult.Products.Count > 0;
                    });

                    log(JsonConvert.SerializeObject(result.Account, Formatting.Indented));
                }
                else
                {
                    log(string.Format("AUTH ERROR : {0}({1})", (result == null ? "null" : result.ErrorMessage), (result == null ? "null" : result.ErrorCode.ToString())));
                }
                log(DIVIDER);
            });
        }

        private void attachLinkedCard()
        {
            checkCredentials();
            var currency = rb_RUB.Checked ? Currency.RUB : Currency.VND;
            string acquirerCode = null;
            if (m_AuthResult != null && m_AuthResult.ErrorCode == 0 && m_AuthResult.Account != null)
            {
                var acquirersByMethod = m_AuthResult.Account.AcquirersByMethods;
                if (acquirersByMethod != null && acquirersByMethod.Count != 0)
                {
                    if (acquirersByMethod.ContainsKey(PaymentMethod.Card))
                    {
                        var acquirers = acquirersByMethod[PaymentMethod.Card];
                        if (acquirers.Count == 1)
                            acquirerCode = acquirers.First().Key;
                        else
                        {
                            int index = Utils.ShowDialog(acquirers.Values.ToList(), "Select acquirer");
                            acquirerCode = acquirers.Keys.ToList()[Math.Max(0, index)];
                        }
                    }
                }
            }
            try
            {
                m_PaymentController.AddLinkedCard(currency, acquirerCode);
                log(DIVIDER);
                log("STARTING LINKED CARD ATTACH");
            }
            catch (InvalidOperationException e)
            {
                log(string.Format("ERROR : {0}", e.Message));
                return;
            }
        }

        private void removeLinkedCard()
        {
            checkCredentials();
            log(DIVIDER);
            if (m_LinkedCards != null && m_LinkedCards.Count > 0)
            {
                int selectedCardIndex = Utils.ShowDialog(m_LinkedCards.ConvertAll(c => c.Alias), "Select card");
                if (selectedCardIndex >= 0)
                {
                    var selectedCard = m_LinkedCards[selectedCardIndex];
                    Task.Factory.StartNew(() =>
                    {
                        log("REMOVE LINKED CARD " + selectedCard.ID + " ALIAS " + selectedCard.Alias);
                        try
                        {
                            var result = m_PaymentController.RemoveLinkedCard(selectedCard.ID);
                            if (result != null && result.ErrorCode == 0)
                            {
                                log("SUCCESS!");
                                getLinkedCards();
                            }
                            else
                                log(string.Format("REMOVE LINKED CARD ERROR : {0}({1})", (result == null ? "null" : result.ErrorMessage), (result == null ? "null" : result.ErrorCode.ToString())));
                        }
                        catch (InvalidOperationException e)
                        {
                            log(string.Format("ERROR : {0}", e.Message));
                            return;
                        }
                    });
                }
                else
                {
                    log("ERROR : CANCEL SELECT CARD");
                    return;
                }
            }
            else
                log("ERROR : NO LINKED CARDS");
        }

        private void getLinkedCards()
        {
            checkCredentials();
            log(DIVIDER);
            Task.Factory.StartNew(() =>
            {
                log("GET LINKED CARDS");
                try
                {
                    var result = m_PaymentController.GetLinkedCards();
                    if (result != null && result.ErrorCode == 0)
                    {
                        m_LinkedCards = result.LinkedCards;
                        log(JsonConvert.SerializeObject(result, Formatting.Indented));
                    }
                    else
                        log(string.Format("GET LINKED CARDS ERROR : {0}({1})", (result == null ? "null" : result.ErrorMessage), (result == null ? "null" : result.ErrorCode.ToString())));
                }
                catch (InvalidOperationException e)
                {
                    log(string.Format("ERROR : {0}", e.Message));
                    return;
                }
            });
        }

        private int onRequestSelectApplication(List<string> apps)
        {
            log("REQUEST SELECT APP");
            log(string.Join(Environment.NewLine, apps));
            
            var selected = Utils.ShowDialog(apps, "Select application");
            return Math.Max(0, selected);
        }

        private bool onRequestConfirmSchedule(List<KeyValuePair<DateTime, decimal>> steps, decimal totalAmount)
        {
            log("REQUEST CONFIRM SCHEDULE :");
            log(string.Join(Environment.NewLine, steps));
            log(string.Format("Total : {0}", totalAmount));
            return MessageBox.Show("Confirm schedule", "Schedule confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private bool onScheduleCreationFailed(PaymentError error, string description = null)
        {
            log(string.Format("PAYMENT CREATION FAILED : {0}({1})", error, description ?? ""));
            return MessageBox.Show("Payment creation failed. Retry?", "Payment creation failed", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
        
        private InputType onRequestSelectInputType(List<InputType> allowedInputTypes)
        {
            log("REQUEST SELECT INPUT TYPE");
            log(string.Join(Environment.NewLine, allowedInputTypes.Select(it => it.ToString())));

            var selected = Utils.ShowDialog(allowedInputTypes.ConvertAll(ait => ait.ToString()), "Select input type");
            return allowedInputTypes[Math.Max(0, selected)];
        }

        private bool onCancellationTimeout()
        {
            log(string.Format("CANCELLATION TIMEOUT"));
            return MessageBox.Show("Cancellation not available. Perform refund?", "Cancellation failed", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        #region PaymentController events    
        private void onReaderEvent(ReaderEvent readerEvent)
        {
            log(string.Format("EVENT : {0}", readerEvent.ToString()));
        }

        private void onPaymentError(PaymentError error, string errorMsg)
        {
            log(string.Format("ERROR : {0} ({1})", error.ToString(), errorMsg ?? ""));
        }

        private void onTransactionStarted(string transactionID)
        {
            log(string.Format("TRANSACTION {0} STARTED", transactionID));
        }

        private void onPaymentFinished(PaymentResultContext result)
        {
            try
            {
                if (result.ScheduleItem != null)
                {
                    log("PAYMENT FINISHED :");
                    log(JsonConvert.SerializeObject(result.ScheduleItem, Formatting.Indented));
                }
                else if (result.TransactionItem != null)
                {
                    Transaction resultTran = result.TransactionItem;

                    if (cb_TestServerFisc.Checked) { 
                        resultTran = Task.Factory.StartNew<Transaction>(() =>
                        {
                            var transaction = result.TransactionItem;
                            var uptime = DateTime.Now;
                            var timeout = new TimeSpan(0, 1, 0);
                            int i = 0;
                            while (transaction.FiscalInfo == null || (transaction.FiscalInfo.FiscalStatus != FiscalStatus.Success && transaction.FiscalInfo.FiscalStatus != FiscalStatus.Failure))
                            {
                                if (DateTime.Now - uptime > timeout)
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
                            }
                            return transaction ?? result.TransactionItem;
                        }
                        ).GetAwaiter().GetResult();
                    }
                    string emvdata = string.Empty;
                    if (resultTran.EMVData != null)
                        foreach (String key in resultTran.EMVData.Keys)
                            emvdata += string.Format("{0}: {1}\n", key, resultTran.EMVData[key]);

                    log("PAYMENT FINISHED : " + Environment.NewLine + JsonConvert.SerializeObject(resultTran, Formatting.Indented));
                    log(DIVIDER);

                    if (cb_TestServerFisc.Checked) log(Utils.BuildInvoice(m_AuthResult.Account, resultTran));
                    StringBuilder slipBuilder = new StringBuilder();
                    slipBuilder.Append("___________SLIP___________\n");
                    if (m_AuthResult != null && m_AuthResult.ErrorCode == 0)
                    {
                        slipBuilder.AppendLine(m_AuthResult.Account.BankName);
                        slipBuilder.AppendLine(m_AuthResult.Account.ClientName);
                        slipBuilder.AppendLine(m_AuthResult.Account.ClientLegalName);
                        slipBuilder.AppendLine(m_AuthResult.Account.ClientPhone);
                        slipBuilder.AppendLine(m_AuthResult.Account.ClientWeb);
                    }
                    slipBuilder.AppendFormat("Дата и время операции: {0}\n", resultTran.Date);
                    slipBuilder.AppendFormat("Терминал: {0}\n", resultTran.TerminalName);
                    slipBuilder.AppendFormat("Чек: {0}\n", resultTran.Invoice);
                    slipBuilder.AppendFormat("Код подтверждения: {0}\n", resultTran.AcquirerApprovalCode);
                    slipBuilder.AppendFormat("Карта: {0} {1}\n", resultTran.Card.IIN, resultTran.Card.PANMasked.Replace("*", " **** "));

                    if (resultTran.EMVData != null)
                        foreach (String key in resultTran.EMVData.Keys)
                            slipBuilder.AppendFormat("{0}: {1}\n", key, resultTran.EMVData[key]);

                    slipBuilder.AppendFormat("Имя: {0}\n", resultTran.CardholderName);
                    slipBuilder.AppendFormat("Операция: {0}\n", resultTran.Operation);

                    slipBuilder.AppendFormat("Итого: {0} р\n", resultTran.Amount);
                    slipBuilder.Append("Комиссия: 0.00 р\n");
                    slipBuilder.Append("Статус: Успешно\n");

                    if (resultTran.SignatureRequired)
                    {
                        slipBuilder.Append("Подпись клиента____________________\n");
                    }
                    else
                    {
                        if (resultTran.InputType == Ibox.Pro.SDK.External.Entry.InputType.Chip || resultTran.InputType == Ibox.Pro.SDK.External.Entry.InputType.NFC)
                            slipBuilder.Append("Подтверждено вводом PIN\n");
                    }

                    log(slipBuilder.ToString());
                }
                else if (result.AttachedCard != null)
                {
                    log("ATTACH FINISHED :" + Environment.NewLine + JsonConvert.SerializeObject(result, Formatting.Indented));
                    getLinkedCards();
                }
                else
                {                
                    log("PAYMENT FINISHED");
                }

                log(DIVIDER);
            }
            catch (Exception ex)
            {
            }
        }

        private void onReverseEvent(ReverseEvent reverseEvent, string message)
        {
            log(string.Format("REVERSE : {0}", message));
        }    
        #endregion

        #region UI actions
        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                ReaderType readerType =  ReaderType.P17;
                if (rb_Wisepad.Checked) readerType = ReaderType.P15;
                else if (rb_Wisepad2.Checked) readerType = ReaderType.P16;
                else if (rb_Qpos_mini.Checked) readerType = ReaderType.P17;
                
                PortInfo selectedPort = null;
                if (!cb_Usb.Checked && portInfos != null && portInfos.Count > 0)
                    selectedPort = portInfos[cmb_Paired.SelectedIndex];

                //P17 only
                Dictionary<String, object> settings = new Dictionary<string, object>();
                settings["NOTUP"] = cb_notup.Checked;
                
                m_PaymentController.SetReaderType(readerType, (cb_Usb.Checked || selectedPort == null) ? null : selectedPort.portName, settings);
            }
            catch (InvalidOperationException ex)
            {
                log(string.Format("ERROR : {0}", ex.Message));
            }

            //DEBUG
            m_PaymentController.Logger = delegate (string s_log) { log(s_log, Color.Blue); };
            //

            m_PaymentController.Enable();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            m_PaymentController.Disable();
        }

        private void btn_StartPayment_Click(object sender, EventArgs e)
        {
            startPayment();
        }

        private void btn_Reverse_Click(object sender, EventArgs e)
        {
            if (!dlgReverse.Visible)
                dlgReverse.ShowDialog();
        }

        private void btn_ClearLog_Click(object sender, EventArgs e)
        {
            edt_Log.Clear();
        }

        private void cb_Regular_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Regular.Checked)
                dlgRegular.ShowDialog();
        }

        private void cb_Usb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Usb.Checked)
            {
                lbl_PairedDevices.Enabled = false;
                cmb_Paired.Enabled = false;
            }
            else
            {
                lbl_PairedDevices.Enabled = true;
                if (portInfos != null && portInfos.Count > 0)
                    cmb_Paired.Enabled = true;
            }
        }

        private void btn_Adjust_Click(object sender, EventArgs e)
        {
            if (!dlgAdjust.Visible)
                dlgAdjust.ShowDialog();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            if (!dlgHistory.Visible)
                dlgHistory.ShowDialog();
        }

        private void cb_Product_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Product.Checked)
                dlgProduct.ShowDialog();
        }


        private void cb_Purchases_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Purchases.Checked)
                dlgPurchases.ShowDialog();
        }
   
        private void cb_Tags_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Tags.Checked)
                dlgTags.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_PaymentController.Disable();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            m_PaymentController.CancelPayment();
        }

        private void btn_CheckConnection_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PaymentController.Instance.IsConnected.ToString());
        }

        private void btn_Auth_Click(object sender, EventArgs e)
        {
            auth();
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            attachLinkedCard();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            removeLinkedCard();
        }
        
        private void btn_SubmitFiscal_Click(object sender, EventArgs e)
        {
            if (!dlgFiscal.Visible)
                dlgFiscal.ShowDialog();
        }
        
        private void btn_Fiscalize_Click(object sender, EventArgs e)
        {
            if (!dlgFiscalize.Visible)
                dlgFiscalize.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    cmb_Paired.Invoke((MethodInvoker)delegate
                    {
                        cmb_Paired.Items.Clear();
                        cmb_Paired.Enabled = false;
                        cmb_Paired.Text = "Loading paired devices...";
                    });

                    ManagementObjectSearcher ManObjSearch = new ManagementObjectSearcher("Select * from Win32_SerialPort where PNPDeviceID like 'BTHENUM%'");
                    ManagementObjectCollection ManObjReturn = ManObjSearch.Get();

                    foreach (ManagementObject ManObj in ManObjReturn)
                    {
                        string portName = ManObj["DeviceID"].ToString();
                        string pnpDeviceID = ManObj["PNPDeviceID"].ToString();


                        //Console.WriteLine(portName + " " + pnpDeviceID);

                        string macAddress;

                        try
                        {
                            int startIndex = pnpDeviceID.LastIndexOf('&') + 1;
                            int endIndex = pnpDeviceID.LastIndexOf('_');
                            macAddress = pnpDeviceID.Substring(startIndex, endIndex - startIndex);
                        }
                        catch
                        {
                            continue;
                        }

                        if (macAddress == "000000000000")
                        {
                            continue;
                        }

                        BluetoothAddress bluetoothAddress = BluetoothAddress.CreateFromBigEndian(hexToByteArray(macAddress));
                        BluetoothDeviceInfo bluetoothDeviceInfo = new BluetoothDeviceInfo(bluetoothAddress);
                        string deviceName = bluetoothDeviceInfo.DeviceName;

                        portInfos.Add(new PortInfo(portName, deviceName));
                        cmb_Paired.Invoke((MethodInvoker)delegate { cmb_Paired.Items.Add(deviceName); });
                    }

                    if (cmb_Paired.Items.Count == 0)
                    {
                        string[] ports = SerialPort.GetPortNames();
                        for (int i = 0; i < ports.Length; ++i)
                        {
                            portInfos.Add(new PortInfo(ports[i], ""));
                            cmb_Paired.Invoke((MethodInvoker)delegate { cmb_Paired.Items.Add(ports[i]); });
                        }
                    }

                    cmb_Paired.Invoke((MethodInvoker)delegate
                    {
                        if (cmb_Paired.Items.Count == 0)
                        {
                            cmb_Paired.Text = "Device not found";
                        }
                        else
                        {
                            cmb_Paired.Text = "";
                            if (!cb_Usb.Checked)
                                cmb_Paired.Enabled = true;
                        }
                    });
                }
                catch { }
            }).Start();
        }

        private void DlgProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlgProduct.CurrentProduct == null)
                cb_Product.Checked = false;
        }

        private void DlgRegular_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlgRegular.Cancelled)
                cb_Regular.Checked = false;
        }
        
        private void DlgPurchases_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlgPurchases.Cancelled)
                cb_Purchases.Checked = false;
        }

        private void DlgTags_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlgTags.Cancelled)
                cb_Purchases.Checked = false;
        }
        #endregion

        public class PortInfo
        {
            public string portName { get; set; }
            public string deviceName { get; set; }

            public PortInfo(string portName, string deviceName)
            {
                this.portName = portName;
                this.deviceName = deviceName;
            }
        }

        private static byte[] hexToByteArray(string hex)
        {
            byte[] result = new byte[hex.Length / 2];
            for (int i = 0; i < result.Length; ++i)
            {
                result[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return result;
        }

        private void btnEnableReaderSound_Click(object sender, EventArgs e)
        {
            PaymentController.Instance.SetSoundEnabled(true);
        }

        private void btnDisableReaderSound_Click(object sender, EventArgs e)
        {
            PaymentController.Instance.SetSoundEnabled(false);

        }
    }
}
 