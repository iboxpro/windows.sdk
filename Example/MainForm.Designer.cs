namespace Example
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Enable = new System.Windows.Forms.Button();
            this.btn_Disable = new System.Windows.Forms.Button();
            this.btn_StartPayment = new System.Windows.Forms.Button();
            this.edt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.edt_Amount = new System.Windows.Forms.MaskedTextBox();
            this.btn_ClearLog = new System.Windows.Forms.Button();
            this.cb_Regular = new System.Windows.Forms.CheckBox();
            this.gb_Regular = new System.Windows.Forms.GroupBox();
            this.lbl_QMonth = new System.Windows.Forms.Label();
            this.cbl_QMonth = new System.Windows.Forms.ComboBox();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.cbl_Day = new System.Windows.Forms.ComboBox();
            this.edt_ArbitraryDays = new System.Windows.Forms.TextBox();
            this.lbl_ArbitraryDays = new System.Windows.Forms.Label();
            this.edt_Phone = new System.Windows.Forms.MaskedTextBox();
            this.edt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_DayOfWeek = new System.Windows.Forms.Label();
            this.cbl_DayOfWeek = new System.Windows.Forms.ComboBox();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.cbl_Month = new System.Windows.Forms.ComboBox();
            this.edt_RepeatCount = new System.Windows.Forms.MaskedTextBox();
            this.lbl_RepeatCount = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_End = new System.Windows.Forms.Label();
            this.cbl_End = new System.Windows.Forms.ComboBox();
            this.lbl_Repeat = new System.Windows.Forms.Label();
            this.cbl_RepeatType = new System.Windows.Forms.ComboBox();
            this.gb_Adjust = new System.Windows.Forms.GroupBox();
            this.rb_AdjustReverse = new System.Windows.Forms.RadioButton();
            this.rb_AdjustSimple = new System.Windows.Forms.RadioButton();
            this.rb_AdjustRegular = new System.Windows.Forms.RadioButton();
            this.edt_AdjustTrId = new System.Windows.Forms.TextBox();
            this.lbl_AdjustTrId = new System.Windows.Forms.Label();
            this.edt_AdjustPhone = new System.Windows.Forms.MaskedTextBox();
            this.edt_AdjustEmail = new System.Windows.Forms.TextBox();
            this.lbl_AdjustPhone = new System.Windows.Forms.Label();
            this.lbl_AdjustEmail = new System.Windows.Forms.Label();
            this.btn_Adjust = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.edt_Password = new System.Windows.Forms.TextBox();
            this.edt_Login = new System.Windows.Forms.TextBox();
            this.gb_History = new System.Windows.Forms.GroupBox();
            this.edt_HistoryPage = new System.Windows.Forms.MaskedTextBox();
            this.lbl_HistoryPage = new System.Windows.Forms.Label();
            this.btn_History = new System.Windows.Forms.Button();
            this.cb_Product = new System.Windows.Forms.CheckBox();
            this.gb_Product = new System.Windows.Forms.GroupBox();
            this.edt_Field2 = new System.Windows.Forms.TextBox();
            this.edt_Field1 = new System.Windows.Forms.TextBox();
            this.lbl_Field2 = new System.Windows.Forms.Label();
            this.lbl_Field1 = new System.Windows.Forms.Label();
            this.lbl_ImageFilePath = new System.Windows.Forms.Label();
            this.edt_ImageFilePath = new System.Windows.Forms.TextBox();
            this.lbl_PairedDevices = new System.Windows.Forms.Label();
            this.btn_Reverse = new System.Windows.Forms.Button();
            this.gb_Reverse = new System.Windows.Forms.GroupBox();
            this.edt_ReverseAmount = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ReverseAmount = new System.Windows.Forms.Label();
            this.edt_ReverseID = new System.Windows.Forms.TextBox();
            this.rb_Cancel = new System.Windows.Forms.RadioButton();
            this.rb_Return = new System.Windows.Forms.RadioButton();
            this.lbl_ReverseID = new System.Windows.Forms.Label();
            this.gb_Currency = new System.Windows.Forms.GroupBox();
            this.rb_VND = new System.Windows.Forms.RadioButton();
            this.rb_RUB = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cb_SinglestepEMV = new System.Windows.Forms.CheckBox();
            this.edt_Log = new System.Windows.Forms.RichTextBox();
            this.cb_Cash = new System.Windows.Forms.CheckBox();
            this.gb_Reader = new System.Windows.Forms.GroupBox();
            this.rb_EmvSwipe = new System.Windows.Forms.RadioButton();
            this.rb_Wisepad2 = new System.Windows.Forms.RadioButton();
            this.rb_Qpos_mini = new System.Windows.Forms.RadioButton();
            this.rb_Wisepad = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmb_Paired = new System.Windows.Forms.ComboBox();
            this.cb_Usb = new System.Windows.Forms.CheckBox();
            this.gb_Regular.SuspendLayout();
            this.gb_Adjust.SuspendLayout();
            this.gb_History.SuspendLayout();
            this.gb_Product.SuspendLayout();
            this.gb_Reverse.SuspendLayout();
            this.gb_Currency.SuspendLayout();
            this.gb_Reader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Enable
            // 
            this.btn_Enable.Location = new System.Drawing.Point(812, 131);
            this.btn_Enable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(254, 58);
            this.btn_Enable.TabIndex = 0;
            this.btn_Enable.Text = "Enable";
            this.btn_Enable.UseVisualStyleBackColor = true;
            this.btn_Enable.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Disable
            // 
            this.btn_Disable.Location = new System.Drawing.Point(812, 200);
            this.btn_Disable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(254, 58);
            this.btn_Disable.TabIndex = 99;
            this.btn_Disable.Text = "Disable";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_StartPayment
            // 
            this.btn_StartPayment.Location = new System.Drawing.Point(812, 269);
            this.btn_StartPayment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_StartPayment.Name = "btn_StartPayment";
            this.btn_StartPayment.Size = new System.Drawing.Size(254, 58);
            this.btn_StartPayment.TabIndex = 3;
            this.btn_StartPayment.Text = "Start payment";
            this.btn_StartPayment.UseVisualStyleBackColor = true;
            this.btn_StartPayment.Click += new System.EventHandler(this.btn_StartPayment_Click);
            // 
            // edt_Description
            // 
            this.edt_Description.Location = new System.Drawing.Point(278, 175);
            this.edt_Description.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_Description.Name = "edt_Description";
            this.edt_Description.Size = new System.Drawing.Size(256, 31);
            this.edt_Description.TabIndex = 4;
            this.edt_Description.Text = "description_sdk_csharp";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(16, 131);
            this.lbl_Amount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(91, 25);
            this.lbl_Amount.TabIndex = 6;
            this.lbl_Amount.Text = "Amount:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(16, 181);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(126, 25);
            this.lbl_Description.TabIndex = 7;
            this.lbl_Description.Text = "Description:";
            // 
            // edt_Amount
            // 
            this.edt_Amount.Location = new System.Drawing.Point(278, 125);
            this.edt_Amount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_Amount.Name = "edt_Amount";
            this.edt_Amount.PromptChar = ' ';
            this.edt_Amount.Size = new System.Drawing.Size(256, 31);
            this.edt_Amount.TabIndex = 3;
            this.edt_Amount.Text = "100";
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.Location = new System.Drawing.Point(550, 1304);
            this.btn_ClearLog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(516, 58);
            this.btn_ClearLog.TabIndex = 9;
            this.btn_ClearLog.Text = "Clear log";
            this.btn_ClearLog.UseVisualStyleBackColor = true;
            this.btn_ClearLog.Click += new System.EventHandler(this.btn_ClearLog_Click);
            // 
            // cb_Regular
            // 
            this.cb_Regular.AutoSize = true;
            this.cb_Regular.Location = new System.Drawing.Point(568, 452);
            this.cb_Regular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Regular.Name = "cb_Regular";
            this.cb_Regular.Size = new System.Drawing.Size(194, 29);
            this.cb_Regular.TabIndex = 11;
            this.cb_Regular.Text = "Regular payment";
            this.cb_Regular.UseVisualStyleBackColor = true;
            this.cb_Regular.CheckedChanged += new System.EventHandler(this.cb_Regular_CheckedChanged);
            // 
            // gb_Regular
            // 
            this.gb_Regular.Controls.Add(this.lbl_QMonth);
            this.gb_Regular.Controls.Add(this.cbl_QMonth);
            this.gb_Regular.Controls.Add(this.dtp_Time);
            this.gb_Regular.Controls.Add(this.cbl_Day);
            this.gb_Regular.Controls.Add(this.edt_ArbitraryDays);
            this.gb_Regular.Controls.Add(this.lbl_ArbitraryDays);
            this.gb_Regular.Controls.Add(this.edt_Phone);
            this.gb_Regular.Controls.Add(this.edt_Email);
            this.gb_Regular.Controls.Add(this.lbl_Phone);
            this.gb_Regular.Controls.Add(this.lbl_Email);
            this.gb_Regular.Controls.Add(this.lbl_Time);
            this.gb_Regular.Controls.Add(this.lbl_DayOfWeek);
            this.gb_Regular.Controls.Add(this.cbl_DayOfWeek);
            this.gb_Regular.Controls.Add(this.lbl_Day);
            this.gb_Regular.Controls.Add(this.lbl_Month);
            this.gb_Regular.Controls.Add(this.cbl_Month);
            this.gb_Regular.Controls.Add(this.edt_RepeatCount);
            this.gb_Regular.Controls.Add(this.lbl_RepeatCount);
            this.gb_Regular.Controls.Add(this.lbl_EndDate);
            this.gb_Regular.Controls.Add(this.dtp_EndDate);
            this.gb_Regular.Controls.Add(this.lbl_StartDate);
            this.gb_Regular.Controls.Add(this.dtp_StartDate);
            this.gb_Regular.Controls.Add(this.lbl_End);
            this.gb_Regular.Controls.Add(this.cbl_End);
            this.gb_Regular.Controls.Add(this.lbl_Repeat);
            this.gb_Regular.Controls.Add(this.cbl_RepeatType);
            this.gb_Regular.Enabled = false;
            this.gb_Regular.Location = new System.Drawing.Point(22, 271);
            this.gb_Regular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Regular.Name = "gb_Regular";
            this.gb_Regular.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Regular.Size = new System.Drawing.Size(522, 792);
            this.gb_Regular.TabIndex = 12;
            this.gb_Regular.TabStop = false;
            this.gb_Regular.Text = "Regular payment";
            // 
            // lbl_QMonth
            // 
            this.lbl_QMonth.AutoSize = true;
            this.lbl_QMonth.Location = new System.Drawing.Point(14, 294);
            this.lbl_QMonth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_QMonth.Name = "lbl_QMonth";
            this.lbl_QMonth.Size = new System.Drawing.Size(176, 25);
            this.lbl_QMonth.TabIndex = 50;
            this.lbl_QMonth.Text = "Month of quarter:";
            // 
            // cbl_QMonth
            // 
            this.cbl_QMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_QMonth.FormattingEnabled = true;
            this.cbl_QMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbl_QMonth.Location = new System.Drawing.Point(262, 288);
            this.cbl_QMonth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbl_QMonth.Name = "cbl_QMonth";
            this.cbl_QMonth.Size = new System.Drawing.Size(244, 33);
            this.cbl_QMonth.TabIndex = 49;
            // 
            // dtp_Time
            // 
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Time.Location = new System.Drawing.Point(262, 496);
            this.dtp_Time.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(244, 31);
            this.dtp_Time.TabIndex = 48;
            // 
            // cbl_Day
            // 
            this.cbl_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_Day.FormattingEnabled = true;
            this.cbl_Day.Location = new System.Drawing.Point(262, 392);
            this.cbl_Day.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbl_Day.Name = "cbl_Day";
            this.cbl_Day.Size = new System.Drawing.Size(244, 33);
            this.cbl_Day.TabIndex = 47;
            // 
            // edt_ArbitraryDays
            // 
            this.edt_ArbitraryDays.Location = new System.Drawing.Point(262, 646);
            this.edt_ArbitraryDays.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_ArbitraryDays.Multiline = true;
            this.edt_ArbitraryDays.Name = "edt_ArbitraryDays";
            this.edt_ArbitraryDays.Size = new System.Drawing.Size(244, 131);
            this.edt_ArbitraryDays.TabIndex = 46;
            this.edt_ArbitraryDays.Text = "01.01.2016;\r\n02.02.2016;\r\n03.03.2016";
            // 
            // lbl_ArbitraryDays
            // 
            this.lbl_ArbitraryDays.AutoSize = true;
            this.lbl_ArbitraryDays.Location = new System.Drawing.Point(12, 652);
            this.lbl_ArbitraryDays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ArbitraryDays.Name = "lbl_ArbitraryDays";
            this.lbl_ArbitraryDays.Size = new System.Drawing.Size(67, 25);
            this.lbl_ArbitraryDays.TabIndex = 45;
            this.lbl_ArbitraryDays.Text = "Days:";
            // 
            // edt_Phone
            // 
            this.edt_Phone.Location = new System.Drawing.Point(262, 596);
            this.edt_Phone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_Phone.Mask = "+7(000)000-00-00";
            this.edt_Phone.Name = "edt_Phone";
            this.edt_Phone.Size = new System.Drawing.Size(244, 31);
            this.edt_Phone.TabIndex = 44;
            this.edt_Phone.Text = "0123456789";
            // 
            // edt_Email
            // 
            this.edt_Email.Location = new System.Drawing.Point(262, 546);
            this.edt_Email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_Email.Name = "edt_Email";
            this.edt_Email.Size = new System.Drawing.Size(244, 31);
            this.edt_Email.TabIndex = 43;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(14, 602);
            this.lbl_Phone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(80, 25);
            this.lbl_Phone.TabIndex = 30;
            this.lbl_Phone.Text = "Phone:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(14, 552);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(71, 25);
            this.lbl_Email.TabIndex = 31;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(14, 502);
            this.lbl_Time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(65, 25);
            this.lbl_Time.TabIndex = 41;
            this.lbl_Time.Text = "Time:";
            // 
            // lbl_DayOfWeek
            // 
            this.lbl_DayOfWeek.AutoSize = true;
            this.lbl_DayOfWeek.Location = new System.Drawing.Point(14, 450);
            this.lbl_DayOfWeek.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_DayOfWeek.Name = "lbl_DayOfWeek";
            this.lbl_DayOfWeek.Size = new System.Drawing.Size(136, 25);
            this.lbl_DayOfWeek.TabIndex = 40;
            this.lbl_DayOfWeek.Text = "Day of week:";
            // 
            // cbl_DayOfWeek
            // 
            this.cbl_DayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_DayOfWeek.FormattingEnabled = true;
            this.cbl_DayOfWeek.Location = new System.Drawing.Point(262, 444);
            this.cbl_DayOfWeek.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbl_DayOfWeek.Name = "cbl_DayOfWeek";
            this.cbl_DayOfWeek.Size = new System.Drawing.Size(244, 33);
            this.cbl_DayOfWeek.TabIndex = 39;
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Location = new System.Drawing.Point(14, 398);
            this.lbl_Day.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(56, 25);
            this.lbl_Day.TabIndex = 38;
            this.lbl_Day.Text = "Day:";
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Location = new System.Drawing.Point(14, 346);
            this.lbl_Month.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(78, 25);
            this.lbl_Month.TabIndex = 33;
            this.lbl_Month.Text = "Month:";
            // 
            // cbl_Month
            // 
            this.cbl_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_Month.FormattingEnabled = true;
            this.cbl_Month.Location = new System.Drawing.Point(262, 340);
            this.cbl_Month.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbl_Month.Name = "cbl_Month";
            this.cbl_Month.Size = new System.Drawing.Size(244, 33);
            this.cbl_Month.TabIndex = 29;
            // 
            // edt_RepeatCount
            // 
            this.edt_RepeatCount.Location = new System.Drawing.Point(262, 238);
            this.edt_RepeatCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_RepeatCount.Mask = "00";
            this.edt_RepeatCount.Name = "edt_RepeatCount";
            this.edt_RepeatCount.Size = new System.Drawing.Size(244, 31);
            this.edt_RepeatCount.TabIndex = 28;
            this.edt_RepeatCount.Text = " 1";
            // 
            // lbl_RepeatCount
            // 
            this.lbl_RepeatCount.AutoSize = true;
            this.lbl_RepeatCount.Location = new System.Drawing.Point(14, 244);
            this.lbl_RepeatCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_RepeatCount.Name = "lbl_RepeatCount";
            this.lbl_RepeatCount.Size = new System.Drawing.Size(146, 25);
            this.lbl_RepeatCount.TabIndex = 27;
            this.lbl_RepeatCount.Text = "Repeat count:";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(12, 194);
            this.lbl_EndDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(56, 25);
            this.lbl_EndDate.TabIndex = 26;
            this.lbl_EndDate.Text = "End:";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(262, 188);
            this.dtp_EndDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(244, 31);
            this.dtp_EndDate.TabIndex = 25;
            this.dtp_EndDate.Value = new System.DateTime(2015, 8, 5, 0, 0, 0, 0);
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(14, 144);
            this.lbl_StartDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(63, 25);
            this.lbl_StartDate.TabIndex = 24;
            this.lbl_StartDate.Text = "Start:";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(262, 138);
            this.dtp_StartDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(244, 31);
            this.dtp_StartDate.TabIndex = 23;
            this.dtp_StartDate.Value = new System.DateTime(2015, 8, 5, 0, 0, 0, 0);
            // 
            // lbl_End
            // 
            this.lbl_End.AutoSize = true;
            this.lbl_End.Location = new System.Drawing.Point(14, 94);
            this.lbl_End.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(85, 25);
            this.lbl_End.TabIndex = 22;
            this.lbl_End.Text = "End by:";
            // 
            // cbl_End
            // 
            this.cbl_End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_End.FormattingEnabled = true;
            this.cbl_End.Location = new System.Drawing.Point(262, 88);
            this.cbl_End.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbl_End.Name = "cbl_End";
            this.cbl_End.Size = new System.Drawing.Size(244, 33);
            this.cbl_End.TabIndex = 21;
            this.cbl_End.SelectedIndexChanged += new System.EventHandler(this.cbl_End_SelectedIndexChanged);
            this.cbl_End.EnabledChanged += new System.EventHandler(this.cbl_End_EnabledChanged);
            // 
            // lbl_Repeat
            // 
            this.lbl_Repeat.AutoSize = true;
            this.lbl_Repeat.Location = new System.Drawing.Point(14, 42);
            this.lbl_Repeat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Repeat.Name = "lbl_Repeat";
            this.lbl_Repeat.Size = new System.Drawing.Size(87, 25);
            this.lbl_Repeat.TabIndex = 20;
            this.lbl_Repeat.Text = "Repeat:";
            // 
            // cbl_RepeatType
            // 
            this.cbl_RepeatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_RepeatType.FormattingEnabled = true;
            this.cbl_RepeatType.Location = new System.Drawing.Point(262, 37);
            this.cbl_RepeatType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbl_RepeatType.Name = "cbl_RepeatType";
            this.cbl_RepeatType.Size = new System.Drawing.Size(244, 33);
            this.cbl_RepeatType.TabIndex = 19;
            this.cbl_RepeatType.SelectedIndexChanged += new System.EventHandler(this.cbl_RepeatType_SelectedIndexChanged);
            // 
            // gb_Adjust
            // 
            this.gb_Adjust.Controls.Add(this.rb_AdjustReverse);
            this.gb_Adjust.Controls.Add(this.rb_AdjustSimple);
            this.gb_Adjust.Controls.Add(this.rb_AdjustRegular);
            this.gb_Adjust.Controls.Add(this.edt_AdjustTrId);
            this.gb_Adjust.Controls.Add(this.lbl_AdjustTrId);
            this.gb_Adjust.Controls.Add(this.edt_AdjustPhone);
            this.gb_Adjust.Controls.Add(this.edt_AdjustEmail);
            this.gb_Adjust.Controls.Add(this.lbl_AdjustPhone);
            this.gb_Adjust.Controls.Add(this.lbl_AdjustEmail);
            this.gb_Adjust.Location = new System.Drawing.Point(550, 731);
            this.gb_Adjust.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Adjust.Name = "gb_Adjust";
            this.gb_Adjust.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Adjust.Size = new System.Drawing.Size(516, 327);
            this.gb_Adjust.TabIndex = 13;
            this.gb_Adjust.TabStop = false;
            this.gb_Adjust.Text = "Adjust payment";
            // 
            // rb_AdjustReverse
            // 
            this.rb_AdjustReverse.AutoSize = true;
            this.rb_AdjustReverse.Location = new System.Drawing.Point(18, 123);
            this.rb_AdjustReverse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_AdjustReverse.Name = "rb_AdjustReverse";
            this.rb_AdjustReverse.Size = new System.Drawing.Size(256, 29);
            this.rb_AdjustReverse.TabIndex = 54;
            this.rb_AdjustReverse.Text = "Adjust reverse payment";
            this.rb_AdjustReverse.UseVisualStyleBackColor = true;
            // 
            // rb_AdjustSimple
            // 
            this.rb_AdjustSimple.AutoSize = true;
            this.rb_AdjustSimple.Checked = true;
            this.rb_AdjustSimple.Location = new System.Drawing.Point(18, 37);
            this.rb_AdjustSimple.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_AdjustSimple.Name = "rb_AdjustSimple";
            this.rb_AdjustSimple.Size = new System.Drawing.Size(178, 29);
            this.rb_AdjustSimple.TabIndex = 53;
            this.rb_AdjustSimple.TabStop = true;
            this.rb_AdjustSimple.Text = "Adjust payment";
            this.rb_AdjustSimple.UseVisualStyleBackColor = true;
            // 
            // rb_AdjustRegular
            // 
            this.rb_AdjustRegular.AutoSize = true;
            this.rb_AdjustRegular.Location = new System.Drawing.Point(18, 79);
            this.rb_AdjustRegular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_AdjustRegular.Name = "rb_AdjustRegular";
            this.rb_AdjustRegular.Size = new System.Drawing.Size(251, 29);
            this.rb_AdjustRegular.TabIndex = 52;
            this.rb_AdjustRegular.Text = "Adjust regular payment";
            this.rb_AdjustRegular.UseVisualStyleBackColor = true;
            // 
            // edt_AdjustTrId
            // 
            this.edt_AdjustTrId.Location = new System.Drawing.Point(262, 173);
            this.edt_AdjustTrId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_AdjustTrId.Name = "edt_AdjustTrId";
            this.edt_AdjustTrId.Size = new System.Drawing.Size(238, 31);
            this.edt_AdjustTrId.TabIndex = 51;
            // 
            // lbl_AdjustTrId
            // 
            this.lbl_AdjustTrId.AutoSize = true;
            this.lbl_AdjustTrId.Location = new System.Drawing.Point(12, 179);
            this.lbl_AdjustTrId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_AdjustTrId.Name = "lbl_AdjustTrId";
            this.lbl_AdjustTrId.Size = new System.Drawing.Size(157, 25);
            this.lbl_AdjustTrId.TabIndex = 50;
            this.lbl_AdjustTrId.Text = "Transaction ID:";
            // 
            // edt_AdjustPhone
            // 
            this.edt_AdjustPhone.Location = new System.Drawing.Point(262, 273);
            this.edt_AdjustPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_AdjustPhone.Mask = "+7(000)000-00-00";
            this.edt_AdjustPhone.Name = "edt_AdjustPhone";
            this.edt_AdjustPhone.Size = new System.Drawing.Size(238, 31);
            this.edt_AdjustPhone.TabIndex = 48;
            this.edt_AdjustPhone.Text = "0123456789";
            // 
            // edt_AdjustEmail
            // 
            this.edt_AdjustEmail.Location = new System.Drawing.Point(262, 223);
            this.edt_AdjustEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_AdjustEmail.Name = "edt_AdjustEmail";
            this.edt_AdjustEmail.Size = new System.Drawing.Size(238, 31);
            this.edt_AdjustEmail.TabIndex = 47;
            // 
            // lbl_AdjustPhone
            // 
            this.lbl_AdjustPhone.AutoSize = true;
            this.lbl_AdjustPhone.Location = new System.Drawing.Point(12, 279);
            this.lbl_AdjustPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_AdjustPhone.Name = "lbl_AdjustPhone";
            this.lbl_AdjustPhone.Size = new System.Drawing.Size(80, 25);
            this.lbl_AdjustPhone.TabIndex = 45;
            this.lbl_AdjustPhone.Text = "Phone:";
            // 
            // lbl_AdjustEmail
            // 
            this.lbl_AdjustEmail.AutoSize = true;
            this.lbl_AdjustEmail.Location = new System.Drawing.Point(12, 229);
            this.lbl_AdjustEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_AdjustEmail.Name = "lbl_AdjustEmail";
            this.lbl_AdjustEmail.Size = new System.Drawing.Size(71, 25);
            this.lbl_AdjustEmail.TabIndex = 46;
            this.lbl_AdjustEmail.Text = "Email:";
            // 
            // btn_Adjust
            // 
            this.btn_Adjust.Location = new System.Drawing.Point(550, 1069);
            this.btn_Adjust.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Adjust.Name = "btn_Adjust";
            this.btn_Adjust.Size = new System.Drawing.Size(516, 58);
            this.btn_Adjust.TabIndex = 14;
            this.btn_Adjust.Text = "Adjust payment";
            this.btn_Adjust.UseVisualStyleBackColor = true;
            this.btn_Adjust.Click += new System.EventHandler(this.btn_Adjust_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(16, 81);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(112, 25);
            this.lbl_Password.TabIndex = 17;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(16, 31);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(71, 25);
            this.lbl_Login.TabIndex = 16;
            this.lbl_Login.Text = "Login:";
            // 
            // edt_Password
            // 
            this.edt_Password.Location = new System.Drawing.Point(278, 75);
            this.edt_Password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_Password.Name = "edt_Password";
            this.edt_Password.Size = new System.Drawing.Size(256, 31);
            this.edt_Password.TabIndex = 2;
            this.edt_Password.Text = "";
            // 
            // edt_Login
            // 
            this.edt_Login.Location = new System.Drawing.Point(278, 25);
            this.edt_Login.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_Login.Name = "edt_Login";
            this.edt_Login.Size = new System.Drawing.Size(256, 31);
            this.edt_Login.TabIndex = 1;
            this.edt_Login.Text = "";
            // 
            // gb_History
            // 
            this.gb_History.Controls.Add(this.edt_HistoryPage);
            this.gb_History.Controls.Add(this.lbl_HistoryPage);
            this.gb_History.Location = new System.Drawing.Point(550, 1138);
            this.gb_History.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_History.Name = "gb_History";
            this.gb_History.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_History.Size = new System.Drawing.Size(516, 85);
            this.gb_History.TabIndex = 19;
            this.gb_History.TabStop = false;
            this.gb_History.Text = "History";
            // 
            // edt_HistoryPage
            // 
            this.edt_HistoryPage.Location = new System.Drawing.Point(262, 29);
            this.edt_HistoryPage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_HistoryPage.Name = "edt_HistoryPage";
            this.edt_HistoryPage.PromptChar = '0';
            this.edt_HistoryPage.Size = new System.Drawing.Size(238, 31);
            this.edt_HistoryPage.TabIndex = 30;
            this.edt_HistoryPage.Text = " 1";
            // 
            // lbl_HistoryPage
            // 
            this.lbl_HistoryPage.AutoSize = true;
            this.lbl_HistoryPage.Location = new System.Drawing.Point(12, 35);
            this.lbl_HistoryPage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_HistoryPage.Name = "lbl_HistoryPage";
            this.lbl_HistoryPage.Size = new System.Drawing.Size(115, 25);
            this.lbl_HistoryPage.TabIndex = 29;
            this.lbl_HistoryPage.Text = "Page num:";
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(550, 1235);
            this.btn_History.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(516, 58);
            this.btn_History.TabIndex = 20;
            this.btn_History.Text = "Get history";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // cb_Product
            // 
            this.cb_Product.AutoSize = true;
            this.cb_Product.Location = new System.Drawing.Point(568, 496);
            this.cb_Product.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Product.Name = "cb_Product";
            this.cb_Product.Size = new System.Drawing.Size(235, 29);
            this.cb_Product.TabIndex = 100;
            this.cb_Product.Text = "Add payment product";
            this.cb_Product.UseVisualStyleBackColor = true;
            this.cb_Product.CheckedChanged += new System.EventHandler(this.cb_Product_CheckedChanged);
            // 
            // gb_Product
            // 
            this.gb_Product.Controls.Add(this.edt_Field2);
            this.gb_Product.Controls.Add(this.edt_Field1);
            this.gb_Product.Controls.Add(this.lbl_Field2);
            this.gb_Product.Controls.Add(this.lbl_Field1);
            this.gb_Product.Location = new System.Drawing.Point(550, 588);
            this.gb_Product.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Product.Name = "gb_Product";
            this.gb_Product.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Product.Size = new System.Drawing.Size(516, 140);
            this.gb_Product.TabIndex = 101;
            this.gb_Product.TabStop = false;
            this.gb_Product.Text = "Payment product";
            // 
            // edt_Field2
            // 
            this.edt_Field2.Location = new System.Drawing.Point(262, 87);
            this.edt_Field2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_Field2.Name = "edt_Field2";
            this.edt_Field2.Size = new System.Drawing.Size(238, 31);
            this.edt_Field2.TabIndex = 5;
            // 
            // edt_Field1
            // 
            this.edt_Field1.Location = new System.Drawing.Point(262, 37);
            this.edt_Field1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_Field1.Name = "edt_Field1";
            this.edt_Field1.Size = new System.Drawing.Size(238, 31);
            this.edt_Field1.TabIndex = 4;
            // 
            // lbl_Field2
            // 
            this.lbl_Field2.AutoSize = true;
            this.lbl_Field2.Location = new System.Drawing.Point(12, 92);
            this.lbl_Field2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Field2.Name = "lbl_Field2";
            this.lbl_Field2.Size = new System.Drawing.Size(209, 25);
            this.lbl_Field2.TabIndex = 1;
            this.lbl_Field2.Text = "Field 2 (image path):";
            // 
            // lbl_Field1
            // 
            this.lbl_Field1.AutoSize = true;
            this.lbl_Field1.Location = new System.Drawing.Point(12, 42);
            this.lbl_Field1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Field1.Name = "lbl_Field1";
            this.lbl_Field1.Size = new System.Drawing.Size(83, 25);
            this.lbl_Field1.TabIndex = 0;
            this.lbl_Field1.Text = "Field 1:";
            // 
            // lbl_ImageFilePath
            // 
            this.lbl_ImageFilePath.AutoSize = true;
            this.lbl_ImageFilePath.Location = new System.Drawing.Point(16, 231);
            this.lbl_ImageFilePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ImageFilePath.Name = "lbl_ImageFilePath";
            this.lbl_ImageFilePath.Size = new System.Drawing.Size(158, 25);
            this.lbl_ImageFilePath.TabIndex = 102;
            this.lbl_ImageFilePath.Text = "Image file path:";
            // 
            // edt_ImageFilePath
            // 
            this.edt_ImageFilePath.Location = new System.Drawing.Point(278, 225);
            this.edt_ImageFilePath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_ImageFilePath.Name = "edt_ImageFilePath";
            this.edt_ImageFilePath.Size = new System.Drawing.Size(256, 31);
            this.edt_ImageFilePath.TabIndex = 103;
            // 
            // lbl_PairedDevices
            // 
            this.lbl_PairedDevices.AutoSize = true;
            this.lbl_PairedDevices.Enabled = false;
            this.lbl_PairedDevices.Location = new System.Drawing.Point(554, 85);
            this.lbl_PairedDevices.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_PairedDevices.Name = "lbl_PairedDevices";
            this.lbl_PairedDevices.Size = new System.Drawing.Size(147, 25);
            this.lbl_PairedDevices.TabIndex = 105;
            this.lbl_PairedDevices.Text = "Select device:";
            // 
            // btn_Reverse
            // 
            this.btn_Reverse.Location = new System.Drawing.Point(22, 1304);
            this.btn_Reverse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Reverse.Name = "btn_Reverse";
            this.btn_Reverse.Size = new System.Drawing.Size(522, 58);
            this.btn_Reverse.TabIndex = 107;
            this.btn_Reverse.Text = "Reverse Payment";
            this.btn_Reverse.UseVisualStyleBackColor = true;
            this.btn_Reverse.Click += new System.EventHandler(this.btn_Reverse_Click);
            // 
            // gb_Reverse
            // 
            this.gb_Reverse.Controls.Add(this.edt_ReverseAmount);
            this.gb_Reverse.Controls.Add(this.lbl_ReverseAmount);
            this.gb_Reverse.Controls.Add(this.edt_ReverseID);
            this.gb_Reverse.Controls.Add(this.rb_Cancel);
            this.gb_Reverse.Controls.Add(this.rb_Return);
            this.gb_Reverse.Controls.Add(this.lbl_ReverseID);
            this.gb_Reverse.Location = new System.Drawing.Point(22, 1073);
            this.gb_Reverse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Reverse.Name = "gb_Reverse";
            this.gb_Reverse.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Reverse.Size = new System.Drawing.Size(522, 219);
            this.gb_Reverse.TabIndex = 106;
            this.gb_Reverse.TabStop = false;
            this.gb_Reverse.Text = "Reverse";
            // 
            // edt_ReverseAmount
            // 
            this.edt_ReverseAmount.Location = new System.Drawing.Point(184, 79);
            this.edt_ReverseAmount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_ReverseAmount.Name = "edt_ReverseAmount";
            this.edt_ReverseAmount.PromptChar = ' ';
            this.edt_ReverseAmount.Size = new System.Drawing.Size(322, 31);
            this.edt_ReverseAmount.TabIndex = 58;
            // 
            // lbl_ReverseAmount
            // 
            this.lbl_ReverseAmount.AutoSize = true;
            this.lbl_ReverseAmount.Location = new System.Drawing.Point(12, 85);
            this.lbl_ReverseAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ReverseAmount.Name = "lbl_ReverseAmount";
            this.lbl_ReverseAmount.Size = new System.Drawing.Size(91, 25);
            this.lbl_ReverseAmount.TabIndex = 57;
            this.lbl_ReverseAmount.Text = "Amount:";
            // 
            // edt_ReverseID
            // 
            this.edt_ReverseID.Location = new System.Drawing.Point(184, 29);
            this.edt_ReverseID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_ReverseID.Name = "edt_ReverseID";
            this.edt_ReverseID.Size = new System.Drawing.Size(322, 31);
            this.edt_ReverseID.TabIndex = 56;
            // 
            // rb_Cancel
            // 
            this.rb_Cancel.AutoSize = true;
            this.rb_Cancel.Checked = true;
            this.rb_Cancel.Location = new System.Drawing.Point(18, 129);
            this.rb_Cancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_Cancel.Name = "rb_Cancel";
            this.rb_Cancel.Size = new System.Drawing.Size(97, 29);
            this.rb_Cancel.TabIndex = 55;
            this.rb_Cancel.TabStop = true;
            this.rb_Cancel.Text = "Cancel";
            this.rb_Cancel.UseVisualStyleBackColor = true;
            // 
            // rb_Return
            // 
            this.rb_Return.AutoSize = true;
            this.rb_Return.Location = new System.Drawing.Point(18, 173);
            this.rb_Return.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_Return.Name = "rb_Return";
            this.rb_Return.Size = new System.Drawing.Size(94, 29);
            this.rb_Return.TabIndex = 54;
            this.rb_Return.Text = "Return";
            this.rb_Return.UseVisualStyleBackColor = true;
            // 
            // lbl_ReverseID
            // 
            this.lbl_ReverseID.AutoSize = true;
            this.lbl_ReverseID.Location = new System.Drawing.Point(12, 35);
            this.lbl_ReverseID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ReverseID.Name = "lbl_ReverseID";
            this.lbl_ReverseID.Size = new System.Drawing.Size(157, 25);
            this.lbl_ReverseID.TabIndex = 29;
            this.lbl_ReverseID.Text = "Transaction ID:";
            // 
            // gb_Currency
            // 
            this.gb_Currency.Controls.Add(this.rb_VND);
            this.gb_Currency.Controls.Add(this.rb_RUB);
            this.gb_Currency.Location = new System.Drawing.Point(812, 408);
            this.gb_Currency.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Currency.Name = "gb_Currency";
            this.gb_Currency.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Currency.Size = new System.Drawing.Size(254, 165);
            this.gb_Currency.TabIndex = 108;
            this.gb_Currency.TabStop = false;
            this.gb_Currency.Text = "Currency";
            // 
            // rb_VND
            // 
            this.rb_VND.AutoSize = true;
            this.rb_VND.Location = new System.Drawing.Point(18, 81);
            this.rb_VND.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_VND.Name = "rb_VND";
            this.rb_VND.Size = new System.Drawing.Size(81, 29);
            this.rb_VND.TabIndex = 1;
            this.rb_VND.TabStop = true;
            this.rb_VND.Text = "Dong";
            this.rb_VND.UseVisualStyleBackColor = true;
            // 
            // rb_RUB
            // 
            this.rb_RUB.AutoSize = true;
            this.rb_RUB.Checked = true;
            this.rb_RUB.Location = new System.Drawing.Point(18, 37);
            this.rb_RUB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_RUB.Name = "rb_RUB";
            this.rb_RUB.Size = new System.Drawing.Size(98, 29);
            this.rb_RUB.TabIndex = 0;
            this.rb_RUB.TabStop = true;
            this.rb_RUB.Text = "Rouble";
            this.rb_RUB.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(812, 338);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(254, 58);
            this.btnCancel.TabIndex = 109;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cb_SinglestepEMV
            // 
            this.cb_SinglestepEMV.AutoSize = true;
            this.cb_SinglestepEMV.Location = new System.Drawing.Point(568, 540);
            this.cb_SinglestepEMV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_SinglestepEMV.Name = "cb_SinglestepEMV";
            this.cb_SinglestepEMV.Size = new System.Drawing.Size(184, 29);
            this.cb_SinglestepEMV.TabIndex = 110;
            this.cb_SinglestepEMV.Text = "Singlestep EMV";
            this.cb_SinglestepEMV.UseVisualStyleBackColor = true;
            // 
            // edt_Log
            // 
            this.edt_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_Log.BackColor = System.Drawing.SystemColors.Control;
            this.edt_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_Log.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.edt_Log.Location = new System.Drawing.Point(1084, 25);
            this.edt_Log.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edt_Log.Name = "edt_Log";
            this.edt_Log.ReadOnly = true;
            this.edt_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.edt_Log.Size = new System.Drawing.Size(1392, 1333);
            this.edt_Log.TabIndex = 111;
            this.edt_Log.Text = "";
            // 
            // cb_Cash
            // 
            this.cb_Cash.AutoSize = true;
            this.cb_Cash.Location = new System.Drawing.Point(568, 408);
            this.cb_Cash.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Cash.Name = "cb_Cash";
            this.cb_Cash.Size = new System.Drawing.Size(81, 29);
            this.cb_Cash.TabIndex = 112;
            this.cb_Cash.Text = "Cash";
            this.cb_Cash.UseVisualStyleBackColor = true;
            // 
            // gb_Reader
            // 
            this.gb_Reader.Controls.Add(this.rb_EmvSwipe);
            this.gb_Reader.Controls.Add(this.rb_Wisepad2);
            this.gb_Reader.Controls.Add(this.rb_Qpos_mini);
            this.gb_Reader.Controls.Add(this.rb_Wisepad);
            this.gb_Reader.Location = new System.Drawing.Point(550, 131);
            this.gb_Reader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Reader.Name = "gb_Reader";
            this.gb_Reader.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_Reader.Size = new System.Drawing.Size(244, 265);
            this.gb_Reader.TabIndex = 113;
            this.gb_Reader.TabStop = false;
            this.gb_Reader.Text = "Reader type";
            // 
            // rb_EmvSwipe
            // 
            this.rb_EmvSwipe.AutoSize = true;
            this.rb_EmvSwipe.Enabled = false;
            this.rb_EmvSwipe.Location = new System.Drawing.Point(18, 163);
            this.rb_EmvSwipe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_EmvSwipe.Name = "rb_EmvSwipe";
            this.rb_EmvSwipe.Size = new System.Drawing.Size(134, 29);
            this.rb_EmvSwipe.TabIndex = 3;
            this.rb_EmvSwipe.Text = "EMVSwipe";
            this.rb_EmvSwipe.UseVisualStyleBackColor = true;
            this.rb_EmvSwipe.Visible = false;
            // 
            // rb_Wisepad2
            // 
            this.rb_Wisepad2.AutoSize = true;
            this.rb_Wisepad2.Location = new System.Drawing.Point(18, 79);
            this.rb_Wisepad2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_Wisepad2.Name = "rb_Wisepad2";
            this.rb_Wisepad2.Size = new System.Drawing.Size(138, 29);
            this.rb_Wisepad2.TabIndex = 2;
            this.rb_Wisepad2.Text = "Wisepad_2";
            this.rb_Wisepad2.UseVisualStyleBackColor = true;
            // 
            // rb_Qpos_mini
            // 
            this.rb_Qpos_mini.AutoSize = true;
            this.rb_Qpos_mini.Location = new System.Drawing.Point(18, 121);
            this.rb_Qpos_mini.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_Qpos_mini.Name = "rb_Qpos_mini";
            this.rb_Qpos_mini.Size = new System.Drawing.Size(134, 29);
            this.rb_Qpos_mini.TabIndex = 1;
            this.rb_Qpos_mini.Text = "QPos_mini";
            this.rb_Qpos_mini.UseVisualStyleBackColor = true;
            // 
            // rb_Wisepad
            // 
            this.rb_Wisepad.AutoSize = true;
            this.rb_Wisepad.Checked = true;
            this.rb_Wisepad.Location = new System.Drawing.Point(18, 37);
            this.rb_Wisepad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_Wisepad.Name = "rb_Wisepad";
            this.rb_Wisepad.Size = new System.Drawing.Size(114, 29);
            this.rb_Wisepad.TabIndex = 0;
            this.rb_Wisepad.TabStop = true;
            this.rb_Wisepad.Text = "Wisepad";
            this.rb_Wisepad.UseVisualStyleBackColor = true;
            // 
            // cmb_Paired
            // 
            this.cmb_Paired.Enabled = false;
            this.cmb_Paired.FormattingEnabled = true;
            this.cmb_Paired.Location = new System.Drawing.Point(716, 79);
            this.cmb_Paired.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmb_Paired.Name = "cmb_Paired";
            this.cmb_Paired.Size = new System.Drawing.Size(346, 33);
            this.cmb_Paired.TabIndex = 114;
            // 
            // cb_Usb
            // 
            this.cb_Usb.AutoSize = true;
            this.cb_Usb.Checked = true;
            this.cb_Usb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Usb.Location = new System.Drawing.Point(568, 35);
            this.cb_Usb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Usb.Name = "cb_Usb";
            this.cb_Usb.Size = new System.Drawing.Size(133, 29);
            this.cb_Usb.TabIndex = 115;
            this.cb_Usb.Text = "USB mode";
            this.cb_Usb.UseVisualStyleBackColor = true;
            this.cb_Usb.CheckedChanged += new System.EventHandler(this.cb_Usb_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2504, 1385);
            this.Controls.Add(this.cb_Usb);
            this.Controls.Add(this.cmb_Paired);
            this.Controls.Add(this.gb_Reader);
            this.Controls.Add(this.cb_Cash);
            this.Controls.Add(this.edt_Log);
            this.Controls.Add(this.cb_SinglestepEMV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gb_Currency);
            this.Controls.Add(this.btn_Reverse);
            this.Controls.Add(this.gb_Reverse);
            this.Controls.Add(this.lbl_PairedDevices);
            this.Controls.Add(this.edt_ImageFilePath);
            this.Controls.Add(this.lbl_ImageFilePath);
            this.Controls.Add(this.gb_Product);
            this.Controls.Add(this.cb_Product);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.gb_History);
            this.Controls.Add(this.edt_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.edt_Password);
            this.Controls.Add(this.btn_Adjust);
            this.Controls.Add(this.gb_Adjust);
            this.Controls.Add(this.gb_Regular);
            this.Controls.Add(this.cb_Regular);
            this.Controls.Add(this.btn_ClearLog);
            this.Controls.Add(this.edt_Amount);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.edt_Description);
            this.Controls.Add(this.btn_StartPayment);
            this.Controls.Add(this.btn_Disable);
            this.Controls.Add(this.btn_Enable);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gb_Regular.ResumeLayout(false);
            this.gb_Regular.PerformLayout();
            this.gb_Adjust.ResumeLayout(false);
            this.gb_Adjust.PerformLayout();
            this.gb_History.ResumeLayout(false);
            this.gb_History.PerformLayout();
            this.gb_Product.ResumeLayout(false);
            this.gb_Product.PerformLayout();
            this.gb_Reverse.ResumeLayout(false);
            this.gb_Reverse.PerformLayout();
            this.gb_Currency.ResumeLayout(false);
            this.gb_Currency.PerformLayout();
            this.gb_Reader.ResumeLayout(false);
            this.gb_Reader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enable;
        private System.Windows.Forms.Button btn_Disable;
        private System.Windows.Forms.Button btn_StartPayment;
        private System.Windows.Forms.TextBox edt_Description;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.MaskedTextBox edt_Amount;
        private System.Windows.Forms.Button btn_ClearLog;
        private System.Windows.Forms.CheckBox cb_Regular;
        private System.Windows.Forms.GroupBox gb_Regular;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_DayOfWeek;
        private System.Windows.Forms.ComboBox cbl_DayOfWeek;
        private System.Windows.Forms.Label lbl_Day;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.ComboBox cbl_Month;
        private System.Windows.Forms.MaskedTextBox edt_RepeatCount;
        private System.Windows.Forms.Label lbl_RepeatCount;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_End;
        private System.Windows.Forms.ComboBox cbl_End;
        private System.Windows.Forms.Label lbl_Repeat;
        private System.Windows.Forms.ComboBox cbl_RepeatType;
        private System.Windows.Forms.MaskedTextBox edt_Phone;
        private System.Windows.Forms.TextBox edt_Email;
        private System.Windows.Forms.TextBox edt_ArbitraryDays;
        private System.Windows.Forms.Label lbl_ArbitraryDays;
        private System.Windows.Forms.ComboBox cbl_Day;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.Label lbl_QMonth;
        private System.Windows.Forms.ComboBox cbl_QMonth;
        private System.Windows.Forms.GroupBox gb_Adjust;
        private System.Windows.Forms.MaskedTextBox edt_AdjustPhone;
        private System.Windows.Forms.TextBox edt_AdjustEmail;
        private System.Windows.Forms.Label lbl_AdjustPhone;
        private System.Windows.Forms.Label lbl_AdjustEmail;
        private System.Windows.Forms.TextBox edt_AdjustTrId;
        private System.Windows.Forms.Label lbl_AdjustTrId;
        private System.Windows.Forms.Button btn_Adjust;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox edt_Password;
        private System.Windows.Forms.TextBox edt_Login;
        private System.Windows.Forms.GroupBox gb_History;
        private System.Windows.Forms.MaskedTextBox edt_HistoryPage;
        private System.Windows.Forms.Label lbl_HistoryPage;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.CheckBox cb_Product;
        private System.Windows.Forms.GroupBox gb_Product;
        private System.Windows.Forms.TextBox edt_Field2;
        private System.Windows.Forms.TextBox edt_Field1;
        private System.Windows.Forms.Label lbl_Field2;
        private System.Windows.Forms.Label lbl_Field1;
        private System.Windows.Forms.Label lbl_ImageFilePath;
        private System.Windows.Forms.TextBox edt_ImageFilePath;
        private System.Windows.Forms.Label lbl_PairedDevices;
        private System.Windows.Forms.RadioButton rb_AdjustReverse;
        private System.Windows.Forms.RadioButton rb_AdjustSimple;
        private System.Windows.Forms.RadioButton rb_AdjustRegular;
        private System.Windows.Forms.Button btn_Reverse;
        private System.Windows.Forms.GroupBox gb_Reverse;
        private System.Windows.Forms.RadioButton rb_Cancel;
        private System.Windows.Forms.RadioButton rb_Return;
        private System.Windows.Forms.Label lbl_ReverseID;
        private System.Windows.Forms.TextBox edt_ReverseID;
        private System.Windows.Forms.GroupBox gb_Currency;
        private System.Windows.Forms.RadioButton rb_VND;
        private System.Windows.Forms.RadioButton rb_RUB;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cb_SinglestepEMV;
        private System.Windows.Forms.RichTextBox edt_Log;
        private System.Windows.Forms.Label lbl_ReverseAmount;
        private System.Windows.Forms.MaskedTextBox edt_ReverseAmount;
        private System.Windows.Forms.CheckBox cb_Cash;
        private System.Windows.Forms.GroupBox gb_Reader;
        private System.Windows.Forms.RadioButton rb_Qpos_mini;
        private System.Windows.Forms.RadioButton rb_Wisepad;
        private System.Windows.Forms.RadioButton rb_EmvSwipe;
        private System.Windows.Forms.RadioButton rb_Wisepad2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmb_Paired;
        private System.Windows.Forms.CheckBox cb_Usb;
    }
}

