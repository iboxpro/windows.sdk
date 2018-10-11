using Ibox.Pro.SDK.External.Entry;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public class Utils
    {
        private const int S_DECIMALS = 2;
        private const int Q_DECIMALS = 3;

        private static readonly Dictionary<String, decimal> TAX_RATES = new Dictionary<String, decimal>()
        {
            { Purchase.VAT_NA, 0 },
            { Purchase.VAT_0, 0 },
            { Purchase.VAT_10, 0.1m },
            { Purchase.VAT_18, 0.18m }
        };

        public static int ShowDialog(List<string> items, string title)
        {
            int selected = -1;
            Form prompt = new Form()
            {
                ClientSize = new Size(219, 84),
                AutoScaleDimensions = new SizeF(6F, 13F),
                AutoScaleMode = AutoScaleMode.Font,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false,
                ShowInTaskbar = false,
                Name = title,
                Text = title,
                StartPosition = FormStartPosition.CenterParent
            };
            Label lblTitle = new Label() { AutoSize = true, Location = new Point(12, 9), Text = title, TextAlign = ContentAlignment.TopCenter };
            ComboBox cmbSelection = new ComboBox() { FormattingEnabled = true, Location = new Point(12, 25), Size = new Size(199, 21) };
            Button btnAccept = new Button() { Location = new Point(12, 52), Size = new Size(96, 23), Text = "OK" };
            Button btnCancel = new Button() { Location = new Point(114, 52), Size = new Size(96, 23), Text = "Cancel" };

            cmbSelection.Items.AddRange(items.ToArray());
            btnAccept.Click += (object sender, EventArgs e) => {
                selected = cmbSelection.SelectedIndex;
                prompt.DialogResult = DialogResult.OK;
                prompt.Close();
            };
            btnCancel.Click += (object sender, EventArgs e) => {
                prompt.DialogResult = DialogResult.Cancel;
                prompt.Close();
            };
            if (items != null && items.Count > 0)
                cmbSelection.SelectedIndex = 0;

            prompt.Controls.Add(lblTitle);
            prompt.Controls.Add(cmbSelection);
            prompt.Controls.Add(btnAccept);
            prompt.Controls.Add(btnCancel);
            prompt.CancelButton = btnCancel;
            prompt.AcceptButton = btnAccept;

            return prompt.ShowDialog() == DialogResult.OK ? selected : -1;
        }

        public static string ShowDialog(string title, string defaultValue)
        {
            Form prompt = new Form()
            {
                ClientSize = new Size(219, 84),
                AutoScaleDimensions = new SizeF(6F, 13F),
                AutoScaleMode = AutoScaleMode.Font,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false,
                ShowInTaskbar = false,
                Name = title,
                Text = title,
                StartPosition = FormStartPosition.CenterParent
            };
            Label lblTitle = new Label() { AutoSize = true, Location = new Point(12, 9), Text = title, TextAlign = ContentAlignment.TopCenter };
            TextBox edtValue = new TextBox() { Location = new Point(12, 25), Size = new Size(199, 21), Multiline = false };
            Button btnAccept = new Button() { Location = new Point(12, 52), Size = new Size(96, 23), Text = "OK" };
            Button btnCancel = new Button() { Location = new Point(114, 52), Size = new Size(96, 23), Text = "Cancel" };
            btnAccept.Click += (object sender, EventArgs e) => {
                prompt.DialogResult = DialogResult.OK;
                prompt.Close();
            };
            btnCancel.Click += (object sender, EventArgs e) => {
                prompt.DialogResult = DialogResult.Cancel;
                prompt.Close();
            };
            prompt.Controls.Add(lblTitle);
            prompt.Controls.Add(edtValue);
            prompt.Controls.Add(btnAccept);
            prompt.Controls.Add(btnCancel);
            prompt.CancelButton = btnCancel;
            prompt.AcceptButton = btnAccept;

            edtValue.Text = defaultValue ?? "";

            return prompt.ShowDialog() == DialogResult.OK ? edtValue.Text : null;
        }

        public static decimal RoundClassic(decimal what, int decimals)
        {
            return Decimal.Round(what, decimals, MidpointRounding.AwayFromZero);
        }

        private static Dictionary<string, decimal> CalculateTaxes(TaxMode taxMode, decimal total, List<string> appliedTaxes)
        {
            var result = new Dictionary<string, decimal>();
            if (appliedTaxes != null && appliedTaxes.Count > 0)
            {
                decimal taxAmount = total;
                foreach (var taxCode in appliedTaxes)
                {
                    if (taxMode == TaxMode.ForEach)
                    {
                        if (!taxCode.Equals(Purchase.VAT_NA) && !taxCode.Equals(Purchase.VAT_0))
                        {
                            if (!TAX_RATES.ContainsKey(taxCode))
                                throw new ArgumentException("invalid tax code :" + taxCode);
                            decimal taxRate = TAX_RATES[taxCode];
                            taxRate = RoundClassic(taxRate, S_DECIMALS);
                            taxAmount = taxAmount - RoundClassic(total / (1 + taxRate), S_DECIMALS);
                        }
                    }

                    result.Add(taxCode, result.ContainsKey(taxCode) ? (result[taxCode] + taxAmount) : taxAmount);
                }
            }
            else
                result.Add(Purchase.VAT_NA, result.ContainsKey(Purchase.VAT_NA) ? (result[Purchase.VAT_NA] + total) : total);

            if (result.Count == 0)
                throw new ArgumentException("failed to calculate taxes");
            return result;
        }

        private static IEnumerable<string> SplitString(string str, int size)
        {
            for (int i = 0; i < str.Length; i += size)
                yield return str.Substring(i, Math.Min(size, str.Length - i));
        }

        private static void AppendKeyValue(StringBuilder builder, int lineWidth, string key, string value)
        {
            bool multiline = key.Length + 1 + value.Length > lineWidth;
            if (multiline)
            {
                foreach (var keyChunk in SplitString(key, lineWidth))
                    builder.AppendLine(keyChunk);
                foreach (var valueChunk in SplitString(value, lineWidth))
                    builder.AppendLine(valueChunk.Length == lineWidth ? valueChunk : string.Format("{0, -" + valueChunk.Length + "}", valueChunk));
            }
            else
                builder.AppendLine(string.Format("{0, -" + key.Length + "} {1, " + (lineWidth - (key.Length + 1)) + "}", key, value));
        }

        public static List<Purchase> GetPurchasesFromJson(string JSON)
        {
            try
            {
                List<Purchase> result = new List<Purchase>();
                JObject o = JObject.Parse(JSON);
                JArray purchases = (JArray)o["Purchases"];
                foreach (JObject purchase in purchases)
                {
                    Purchase p = JsonConvert.DeserializeObject<Purchase>(purchase.ToString());

                    result.Add(p);

                }
                return result;

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static string BuildInvoice(Account account, Transaction transaction)
        {
            int lineWidth = 37;
            string divider = new string('-', lineWidth);
            var invoiceBuilder = new StringBuilder()
                .AppendLine("-----------------ЧЕК-----------------")
                .AppendLine(transaction.State == 500 ? "ВОЗВРАТ ПРИХОДА" : "ПРИХОД");
            AppendKeyValue(invoiceBuilder, lineWidth, "КАССИР", account.Name);
            AppendKeyValue(invoiceBuilder, lineWidth, "ДАТА И ВРЕМЯ", transaction.Date.ToString("dd.MM.yy HH:mm:ss"));
            AppendKeyValue(invoiceBuilder, lineWidth, "НОМЕР ЧЕКА", transaction.Invoice);
                        
            bool paidByCard = !transaction.Card.IsCash() && !transaction.Card.IsCredit() && !transaction.Card.IsPrepaid();
            if (paidByCard)
                AppendKeyValue(invoiceBuilder, lineWidth, "КОД ПОДТВЕРЖДЕНИЯ", transaction.AcquirerApprovalCode);

            decimal tranAmount = RoundClassic(transaction.Amount, S_DECIMALS);
            decimal invoiceTotal = 0;
            decimal cashGot = RoundClassic(transaction.AmountCashGot, S_DECIMALS);
            var taxMode = transaction.TaxMode;
            var purchases = transaction.Purchases;
            var taxCalcs = new Dictionary<string, decimal>()
            {
                { Purchase.VAT_NA, 0 },
                { Purchase.VAT_0, 0 },
                { Purchase.VAT_10, 0 },
                { Purchase.VAT_18, 0 }
            };
            bool hasPurchases = purchases != null && purchases.Count > 0;

            if (hasPurchases && !string.IsNullOrWhiteSpace(transaction.Description))
                invoiceBuilder.AppendLine(transaction.Description);
            invoiceBuilder.AppendLine(divider);

            if (hasPurchases)
            {
                foreach (Purchase purchase in purchases)
                {
                    var price = RoundClassic(purchase.Price, S_DECIMALS);
                    var quantity = RoundClassic(purchase.Quantity, Q_DECIMALS);
                    var total = RoundClassic(price * quantity, S_DECIMALS);
                    invoiceTotal += total;
                    AppendKeyValue(invoiceBuilder, lineWidth, purchase.Title, string.Format("{0,5:F3}x{1,5:F2}={2,5:F2}", quantity, price, total));
                    var purchaseTaxes = CalculateTaxes(taxMode, total, purchase.TaxCode);
                    foreach (KeyValuePair<string, decimal> purchaseTax in purchaseTaxes)
                    {
                        string taxCode = purchaseTax.Key;
                        decimal taxAmount = purchaseTax.Value;
                        if (taxCalcs.ContainsKey(taxCode))
                            taxCalcs[taxCode] = taxCalcs[taxCode] + taxAmount;
                        else
                            taxCalcs.Add(taxCode, taxAmount);
                    }
                }
            }
            else
            {
                var description = transaction.Description;

                var price = tranAmount;
                var quantity = RoundClassic(1, Q_DECIMALS);
                var total = RoundClassic(price * quantity, S_DECIMALS);
                invoiceTotal += total;
                AppendKeyValue(invoiceBuilder, lineWidth, description, string.Format("{0,5:F3}x{1,5:F2}={2,5:F2}", quantity, price, total));
                taxCalcs = CalculateTaxes(taxMode, total, transaction.Taxes == null ? null : transaction.Taxes.Select(tt => tt.Code).ToList());
            }
            if (transaction.TaxContributions != null && transaction.TaxContributions.Count > 0)
            {
                taxCalcs.Clear();
                foreach (TaxContribution tc in transaction.TaxContributions)
                    taxCalcs.Add(tc.Code, RoundClassic(tc.Total, S_DECIMALS));
            }
            invoiceBuilder.AppendLine(divider);
            AppendKeyValue(invoiceBuilder, lineWidth, "ИТОГ", string.Format("{0:F2}", invoiceTotal));
            invoiceBuilder.AppendLine(divider);

            AppendKeyValue(invoiceBuilder, lineWidth, "НАЛИЧНЫМИ", string.Format("{0:F2}", (transaction.Card.IsCash() ? cashGot : 0)));
            AppendKeyValue(invoiceBuilder, lineWidth, "ЭЛЕКТРОННЫМИ", string.Format("{0:F2}", (paidByCard ? tranAmount : 0)));
            AppendKeyValue(invoiceBuilder, lineWidth, "ПРЕДВАРИТЕЛЬНАЯ ОПЛАТА (АВАНС)", string.Format("{0:F2}", (transaction.Card.IsPrepaid() ? tranAmount : (invoiceTotal - tranAmount))));
            AppendKeyValue(invoiceBuilder, lineWidth, "ПОСЛЕДУЮЩАЯ ОПЛАТА (КРЕДИТ)", string.Format("{0:F2}", (transaction.Card.IsCredit() ? tranAmount : 0)));
            AppendKeyValue(invoiceBuilder, lineWidth, "СДАЧА", string.Format("{0:F2}", (transaction.Card.IsCash() ? cashGot - tranAmount : 0)));

            AppendKeyValue(invoiceBuilder, lineWidth, "Сумма без НДС", string.Format("{0:F2}", taxCalcs.ContainsKey(Purchase.VAT_NA) ? taxCalcs[Purchase.VAT_NA] : 0));
            AppendKeyValue(invoiceBuilder, lineWidth, "Сумма по НДС 0%", string.Format("{0:F2}", taxCalcs.ContainsKey(Purchase.VAT_0) ? taxCalcs[Purchase.VAT_0] : 0));
            AppendKeyValue(invoiceBuilder, lineWidth, "Сумма НДС 10%", string.Format("{0:F2}", taxCalcs.ContainsKey(Purchase.VAT_10) ? taxCalcs[Purchase.VAT_10] : 0));
            AppendKeyValue(invoiceBuilder, lineWidth, "Сумма НДС 18%", string.Format("{0:F2}", taxCalcs.ContainsKey(Purchase.VAT_18) ? taxCalcs[Purchase.VAT_18] : 0));

            if (transaction.FiscalInfo != null)
            {
                invoiceBuilder.AppendLine("--------------ФИСК. БЛОК-------------");
                bool fz54 = transaction.FiscalInfo.FiscalMark != null;
                if (fz54)
                {
                    invoiceBuilder.AppendLine(transaction.FiscalInfo.FiscalDatetime.Value.ToString("dd.MM.yy HH:mm"));
                    AppendKeyValue(invoiceBuilder, lineWidth, "ИНН", account.TaxID);
                    AppendKeyValue(invoiceBuilder, lineWidth, "СНО", transaction.TaxSystemName);
                    AppendKeyValue(invoiceBuilder, lineWidth, "САЙТ ФНС", "http://nalog.ru");
                    AppendKeyValue(invoiceBuilder, lineWidth, "СМЕНА №", string.Format("{0:F0}", transaction.FiscalInfo.FiscalPrinterShift));
                    AppendKeyValue(invoiceBuilder, lineWidth, "ЧЕК №", string.Format("{0:F0}", transaction.FiscalInfo.FiscalDocSN));
                    AppendKeyValue(invoiceBuilder, lineWidth, "ЗН ККТ", transaction.FiscalInfo.FiscalDeviceID);
                    AppendKeyValue(invoiceBuilder, lineWidth, "РН ККТ", transaction.FiscalInfo.FiscalDeviceRegNumber);
                    AppendKeyValue(invoiceBuilder, lineWidth, "ФН", transaction.FiscalInfo.FiscalStorageNumber);
                    AppendKeyValue(invoiceBuilder, lineWidth, "ФД", transaction.FiscalInfo.FiscalDocumentNumber);
                    AppendKeyValue(invoiceBuilder, lineWidth, "ФПД", transaction.FiscalInfo.FiscalMark);
                }
                else if (!string.IsNullOrWhiteSpace(transaction.FiscalInfo.CVC))
                {
                    AppendKeyValue(invoiceBuilder, lineWidth, "ИНН", account.TaxID);
                    AppendKeyValue(invoiceBuilder, lineWidth, "СМЕНА №", string.Format("{0:F0}", transaction.FiscalInfo.FiscalPrinterShift));
                    AppendKeyValue(invoiceBuilder, lineWidth, "ДОКУМЕНТ №", string.Format("{0:F0}", transaction.FiscalInfo.FiscalDocSN));
                    AppendKeyValue(invoiceBuilder, lineWidth, "ЗН ККТ", transaction.FiscalInfo.FiscalDeviceID);
                    AppendKeyValue(invoiceBuilder, lineWidth, "КПК", string.Format("{0:F2}", transaction.FiscalInfo.CVC));
                }
                invoiceBuilder.AppendLine("-----------КОНЕЦ ФИСК. БЛОКА---------");
            }
            invoiceBuilder.AppendLine("--------------КОНЕЦ ЧЕКА-------------");
                                       
            return invoiceBuilder.ToString().Trim();
        }
    }
}
