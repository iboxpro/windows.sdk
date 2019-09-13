using Ibox.Pro.SDK.External.Context;
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
    public partial class DialogRegular : Form
    {
        public bool Cancelled { get; private set; } = false;

        public RepeatType RepeatType { get { return (RepeatType)cbl_RepeatType.SelectedIndex; } }
        public EndType EndType { get { return (EndType)cbl_End.SelectedIndex; } }
        public DateTime StartDate { get { return dtp_StartDate.Value; } }
        public DateTime EndDate { get { return dtp_EndDate.Value; } }
        public int RepeatCount { get { return int.Parse(edt_RepeatCount.Text); } } 
        public int MonthOfQuarter { get { return cbl_QMonth.SelectedIndex + 1; } }
        public int Month { get { return cbl_Month.SelectedIndex + 1; } }
        public int Day
        {
            get
            {
                try
                {
                    return int.Parse(cbl_Day.Text);
                }
                catch (FormatException ex)
                {
                    return RegularPaymentContext.LAST_DAY_OF_MONTH;
                }
            }
        }
        public int DayOfWeek { get { return cbl_DayOfWeek.SelectedIndex; } }
        public int Hour { get { return dtp_Time.Value.Hour; } }
        public int Minute { get { return dtp_Time.Value.Minute; } }
        public List<DateTime> ArbitraryDays
        {
            get
            {
                if (!string.IsNullOrEmpty(edt_ArbitraryDays.Text))
                {
                    List<DateTime> result = new List<DateTime>();
                    string[] days = edt_ArbitraryDays.Text.Split(new char[] { ';' });
                    foreach (string day in days)
                        result.Add(DateTime.ParseExact(day.Trim(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture));
                    return result;
                }
                return null;
            }
        }


        public DialogRegular()
        {
            InitializeComponent();

            btn_OK.Click += btn_OK_Click;
            btn_Cancel.Click += btn_Cancel_Click;
            cbl_RepeatType.SelectedIndexChanged += cbl_RepeatType_SelectedIndexChanged;
            cbl_End.SelectedIndexChanged += cbl_End_EnabledChanged;
            cbl_End.EnabledChanged += cbl_End_EnabledChanged;

            cbl_RepeatType.Items.AddRange(Enum.GetValues(typeof(RepeatType)).Cast<object>().ToArray());
            cbl_End.Items.AddRange(Enum.GetValues(typeof(EndType)).Cast<object>().ToArray());
            dtp_StartDate.MinDate = DateTime.Today;
            dtp_EndDate.MinDate = DateTime.Today;
            dtp_Time.Format = DateTimePickerFormat.Custom;
            dtp_Time.CustomFormat = "HH:mm";
            dtp_Time.ShowUpDown = true;
            cbl_Month.Items.AddRange(System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.MonthNames);
            cbl_DayOfWeek.Items.AddRange(System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.DayNames);
            cbl_Month.SelectedIndex = 0;
            int countOfDays = DateTime.DaysInMonth(1980, cbl_Month.SelectedIndex + 1);
            object[] days = new object[countOfDays + 1];
            for (int i = 0; i < countOfDays; i++)
                days[i] = (i + 1).ToString();
            days[countOfDays] = "Last day of month";
            cbl_Day.Items.AddRange(days);

            SetDefaultValues();
        }
               
        public void SetContextValues(RegularPaymentContext regPaymentContext)
        {
            regPaymentContext.PaymentRepeatType = RepeatType;
            regPaymentContext.PaymentEndType = EndType;
            regPaymentContext.StartDate = StartDate;
            regPaymentContext.EndDate = EndDate;
            regPaymentContext.RepeatCount = RepeatCount;
            regPaymentContext.MonthOfQuarter = MonthOfQuarter;
            regPaymentContext.Month = Month;
            regPaymentContext.Day = Day;
            regPaymentContext.DayOfWeek = DayOfWeek;
            regPaymentContext.Hour = Hour;
            regPaymentContext.Minute = Minute;
            var arbitraryDays = ArbitraryDays;
            if (arbitraryDays != null)
                regPaymentContext.ArbitraryDays.AddRange(arbitraryDays);
        }

        private void SetDefaultValues()
        {
            cbl_RepeatType.SelectedIndex = 0;
            cbl_End.SelectedIndex = 0;
            cbl_QMonth.SelectedIndex = 0;
            cbl_DayOfWeek.SelectedIndex = 0;
            cbl_Day.SelectedIndex = cbl_Day.Items.Count - 1;// countOfDays;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
            Cancelled = true;
            Close();
        }

        private void cbl_RepeatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepeatType repeatType = (RepeatType)cbl_RepeatType.SelectedIndex;

            foreach (Control control in Controls)
                if (!(control is Button))
                    control.Enabled = false;

            cbl_RepeatType.Enabled = true;
            cbl_End.Enabled = true;
            dtp_StartDate.Enabled = true;
            dtp_Time.Enabled = true;
            lbl_Repeat.Enabled = true;
            lbl_End.Enabled = true;
            lbl_StartDate.Enabled = true;
            lbl_Time.Enabled = true;

            switch (repeatType)
            {
                case RepeatType.DelayedOnce:
                    break;
                case RepeatType.Weekly:
                    cbl_DayOfWeek.Enabled = true;
                    lbl_DayOfWeek.Enabled = true;
                    break;
                case RepeatType.Monthly:
                    cbl_Day.Enabled = true;
                    lbl_Day.Enabled = true;
                    break;
                case RepeatType.Quarterly:
                    cbl_QMonth.Enabled = true;
                    cbl_Day.Enabled = true;
                    lbl_QMonth.Enabled = true;
                    lbl_Day.Enabled = true;
                    break;
                case RepeatType.Annual:
                    cbl_Month.Enabled = true;
                    cbl_Day.Enabled = true;
                    lbl_Month.Enabled = true;
                    lbl_Day.Enabled = true;
                    break;
                case RepeatType.ArbitraryDates:
                    edt_ArbitraryDays.Enabled = true;
                    dtp_StartDate.Enabled = false;
                    cbl_End.Enabled = false;
                    edt_RepeatCount.Enabled = false;
                    lbl_StartDate.Enabled = false;
                    lbl_ArbitraryDays.Enabled = true;
                    lbl_End.Enabled = false;
                    lbl_RepeatCount.Enabled = false;
                    break;

            }
        }

        private void cbl_End_EnabledChanged(object sender, EventArgs e)
        {
            EndType endType = (EndType)cbl_End.SelectedIndex;

            edt_RepeatCount.Enabled = cbl_End.Enabled ? endType == EndType.ByQuantity : false;
            dtp_EndDate.Enabled = cbl_End.Enabled ? endType == EndType.AtDay : false;
            lbl_RepeatCount.Enabled = cbl_End.Enabled ? endType == EndType.ByQuantity : false;
            lbl_EndDate.Enabled = cbl_End.Enabled ? endType == EndType.AtDay : false;
        }

        private void cbl_End_SelectedIndexChanged(object sender, EventArgs e)
        {
            EndType endType = (EndType)cbl_End.SelectedIndex;
            edt_RepeatCount.Enabled = endType == EndType.ByQuantity;
            lbl_RepeatCount.Enabled = endType == EndType.ByQuantity;
            dtp_EndDate.Enabled = endType == EndType.AtDay;
            lbl_EndDate.Enabled = endType == EndType.AtDay;
        }

        private void DialogRegular_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                Cancelled = false;
        }
    }
}
