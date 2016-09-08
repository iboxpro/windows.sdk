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
            this.gp_Regular = new System.Windows.Forms.GroupBox();
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
            this.gp_Adjust = new System.Windows.Forms.GroupBox();
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
            this.gp_History = new System.Windows.Forms.GroupBox();
            this.edt_HistoryPage = new System.Windows.Forms.MaskedTextBox();
            this.lbl_HistoryPage = new System.Windows.Forms.Label();
            this.btn_History = new System.Windows.Forms.Button();
            this.cb_Product = new System.Windows.Forms.CheckBox();
            this.gp_Product = new System.Windows.Forms.GroupBox();
            this.edt_Field2 = new System.Windows.Forms.TextBox();
            this.edt_Field1 = new System.Windows.Forms.TextBox();
            this.lbl_Field2 = new System.Windows.Forms.Label();
            this.lbl_Field1 = new System.Windows.Forms.Label();
            this.lbl_ImageFilePath = new System.Windows.Forms.Label();
            this.edt_ImageFilePath = new System.Windows.Forms.TextBox();
            this.edt_Com = new System.Windows.Forms.TextBox();
            this.lbl_Com = new System.Windows.Forms.Label();
            this.btn_Reverse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.gp_Regular.SuspendLayout();
            this.gp_Adjust.SuspendLayout();
            this.gp_History.SuspendLayout();
            this.gp_Product.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_Currency.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Enable
            // 
            this.btn_Enable.Location = new System.Drawing.Point(278, 39);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(258, 30);
            this.btn_Enable.TabIndex = 0;
            this.btn_Enable.Text = "Enable";
            this.btn_Enable.UseVisualStyleBackColor = true;
            this.btn_Enable.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Disable
            // 
            this.btn_Disable.Location = new System.Drawing.Point(278, 75);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(258, 30);
            this.btn_Disable.TabIndex = 99;
            this.btn_Disable.Text = "Disable";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_StartPayment
            // 
            this.btn_StartPayment.Location = new System.Drawing.Point(278, 111);
            this.btn_StartPayment.Name = "btn_StartPayment";
            this.btn_StartPayment.Size = new System.Drawing.Size(115, 30);
            this.btn_StartPayment.TabIndex = 3;
            this.btn_StartPayment.Text = "Start payment";
            this.btn_StartPayment.UseVisualStyleBackColor = true;
            this.btn_StartPayment.Click += new System.EventHandler(this.btn_StartPayment_Click);
            // 
            // edt_Description
            // 
            this.edt_Description.Location = new System.Drawing.Point(139, 91);
            this.edt_Description.Name = "edt_Description";
            this.edt_Description.Size = new System.Drawing.Size(130, 20);
            this.edt_Description.TabIndex = 4;
            this.edt_Description.Text = "description_sdk_csharp";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(8, 68);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(46, 13);
            this.lbl_Amount.TabIndex = 6;
            this.lbl_Amount.Text = "Amount:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(8, 94);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 7;
            this.lbl_Description.Text = "Description:";
            // 
            // edt_Amount
            // 
            this.edt_Amount.Location = new System.Drawing.Point(139, 65);
            this.edt_Amount.Name = "edt_Amount";
            this.edt_Amount.PromptChar = ' ';
            this.edt_Amount.Size = new System.Drawing.Size(130, 20);
            this.edt_Amount.TabIndex = 3;
            this.edt_Amount.Text = "100";
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.Location = new System.Drawing.Point(275, 678);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(258, 30);
            this.btn_ClearLog.TabIndex = 9;
            this.btn_ClearLog.Text = "Clear log";
            this.btn_ClearLog.UseVisualStyleBackColor = true;
            this.btn_ClearLog.Click += new System.EventHandler(this.btn_ClearLog_Click);
            // 
            // cb_Regular
            // 
            this.cb_Regular.AutoSize = true;
            this.cb_Regular.Location = new System.Drawing.Point(284, 235);
            this.cb_Regular.Name = "cb_Regular";
            this.cb_Regular.Size = new System.Drawing.Size(106, 17);
            this.cb_Regular.TabIndex = 11;
            this.cb_Regular.Text = "Regular payment";
            this.cb_Regular.UseVisualStyleBackColor = true;
            this.cb_Regular.CheckedChanged += new System.EventHandler(this.cb_Regular_CheckedChanged);
            // 
            // gp_Regular
            // 
            this.gp_Regular.Controls.Add(this.lbl_QMonth);
            this.gp_Regular.Controls.Add(this.cbl_QMonth);
            this.gp_Regular.Controls.Add(this.dtp_Time);
            this.gp_Regular.Controls.Add(this.cbl_Day);
            this.gp_Regular.Controls.Add(this.edt_ArbitraryDays);
            this.gp_Regular.Controls.Add(this.lbl_ArbitraryDays);
            this.gp_Regular.Controls.Add(this.edt_Phone);
            this.gp_Regular.Controls.Add(this.edt_Email);
            this.gp_Regular.Controls.Add(this.lbl_Phone);
            this.gp_Regular.Controls.Add(this.lbl_Email);
            this.gp_Regular.Controls.Add(this.lbl_Time);
            this.gp_Regular.Controls.Add(this.lbl_DayOfWeek);
            this.gp_Regular.Controls.Add(this.cbl_DayOfWeek);
            this.gp_Regular.Controls.Add(this.lbl_Day);
            this.gp_Regular.Controls.Add(this.lbl_Month);
            this.gp_Regular.Controls.Add(this.cbl_Month);
            this.gp_Regular.Controls.Add(this.edt_RepeatCount);
            this.gp_Regular.Controls.Add(this.lbl_RepeatCount);
            this.gp_Regular.Controls.Add(this.lbl_EndDate);
            this.gp_Regular.Controls.Add(this.dtp_EndDate);
            this.gp_Regular.Controls.Add(this.lbl_StartDate);
            this.gp_Regular.Controls.Add(this.dtp_StartDate);
            this.gp_Regular.Controls.Add(this.lbl_End);
            this.gp_Regular.Controls.Add(this.cbl_End);
            this.gp_Regular.Controls.Add(this.lbl_Repeat);
            this.gp_Regular.Controls.Add(this.cbl_RepeatType);
            this.gp_Regular.Enabled = false;
            this.gp_Regular.Location = new System.Drawing.Point(11, 141);
            this.gp_Regular.Name = "gp_Regular";
            this.gp_Regular.Size = new System.Drawing.Size(261, 412);
            this.gp_Regular.TabIndex = 12;
            this.gp_Regular.TabStop = false;
            this.gp_Regular.Text = "Regular payment";
            // 
            // lbl_QMonth
            // 
            this.lbl_QMonth.AutoSize = true;
            this.lbl_QMonth.Location = new System.Drawing.Point(7, 153);
            this.lbl_QMonth.Name = "lbl_QMonth";
            this.lbl_QMonth.Size = new System.Drawing.Size(88, 13);
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
            this.cbl_QMonth.Location = new System.Drawing.Point(131, 150);
            this.cbl_QMonth.Name = "cbl_QMonth";
            this.cbl_QMonth.Size = new System.Drawing.Size(124, 21);
            this.cbl_QMonth.TabIndex = 49;
            // 
            // dtp_Time
            // 
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Time.Location = new System.Drawing.Point(131, 258);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(124, 20);
            this.dtp_Time.TabIndex = 48;
            // 
            // cbl_Day
            // 
            this.cbl_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_Day.FormattingEnabled = true;
            this.cbl_Day.Location = new System.Drawing.Point(131, 204);
            this.cbl_Day.Name = "cbl_Day";
            this.cbl_Day.Size = new System.Drawing.Size(124, 21);
            this.cbl_Day.TabIndex = 47;
            // 
            // edt_ArbitraryDays
            // 
            this.edt_ArbitraryDays.Location = new System.Drawing.Point(131, 336);
            this.edt_ArbitraryDays.Multiline = true;
            this.edt_ArbitraryDays.Name = "edt_ArbitraryDays";
            this.edt_ArbitraryDays.Size = new System.Drawing.Size(124, 70);
            this.edt_ArbitraryDays.TabIndex = 46;
            this.edt_ArbitraryDays.Text = "01.01.2016;\r\n02.02.2016;\r\n03.03.2016";
            // 
            // lbl_ArbitraryDays
            // 
            this.lbl_ArbitraryDays.AutoSize = true;
            this.lbl_ArbitraryDays.Location = new System.Drawing.Point(6, 339);
            this.lbl_ArbitraryDays.Name = "lbl_ArbitraryDays";
            this.lbl_ArbitraryDays.Size = new System.Drawing.Size(34, 13);
            this.lbl_ArbitraryDays.TabIndex = 45;
            this.lbl_ArbitraryDays.Text = "Days:";
            // 
            // edt_Phone
            // 
            this.edt_Phone.Location = new System.Drawing.Point(131, 310);
            this.edt_Phone.Mask = "+7(000)000-00-00";
            this.edt_Phone.Name = "edt_Phone";
            this.edt_Phone.Size = new System.Drawing.Size(124, 20);
            this.edt_Phone.TabIndex = 44;
            this.edt_Phone.Text = "0123456789";
            // 
            // edt_Email
            // 
            this.edt_Email.Location = new System.Drawing.Point(131, 284);
            this.edt_Email.Name = "edt_Email";
            this.edt_Email.Size = new System.Drawing.Size(124, 20);
            this.edt_Email.TabIndex = 43;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(7, 313);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_Phone.TabIndex = 30;
            this.lbl_Phone.Text = "Phone:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(7, 287);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.lbl_Email.TabIndex = 31;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(7, 261);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(33, 13);
            this.lbl_Time.TabIndex = 41;
            this.lbl_Time.Text = "Time:";
            // 
            // lbl_DayOfWeek
            // 
            this.lbl_DayOfWeek.AutoSize = true;
            this.lbl_DayOfWeek.Location = new System.Drawing.Point(7, 234);
            this.lbl_DayOfWeek.Name = "lbl_DayOfWeek";
            this.lbl_DayOfWeek.Size = new System.Drawing.Size(70, 13);
            this.lbl_DayOfWeek.TabIndex = 40;
            this.lbl_DayOfWeek.Text = "Day of week:";
            // 
            // cbl_DayOfWeek
            // 
            this.cbl_DayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_DayOfWeek.FormattingEnabled = true;
            this.cbl_DayOfWeek.Location = new System.Drawing.Point(131, 231);
            this.cbl_DayOfWeek.Name = "cbl_DayOfWeek";
            this.cbl_DayOfWeek.Size = new System.Drawing.Size(124, 21);
            this.cbl_DayOfWeek.TabIndex = 39;
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Location = new System.Drawing.Point(7, 207);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(29, 13);
            this.lbl_Day.TabIndex = 38;
            this.lbl_Day.Text = "Day:";
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Location = new System.Drawing.Point(7, 180);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(40, 13);
            this.lbl_Month.TabIndex = 33;
            this.lbl_Month.Text = "Month:";
            // 
            // cbl_Month
            // 
            this.cbl_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_Month.FormattingEnabled = true;
            this.cbl_Month.Location = new System.Drawing.Point(131, 177);
            this.cbl_Month.Name = "cbl_Month";
            this.cbl_Month.Size = new System.Drawing.Size(124, 21);
            this.cbl_Month.TabIndex = 29;
            // 
            // edt_RepeatCount
            // 
            this.edt_RepeatCount.Location = new System.Drawing.Point(131, 124);
            this.edt_RepeatCount.Mask = "00";
            this.edt_RepeatCount.Name = "edt_RepeatCount";
            this.edt_RepeatCount.Size = new System.Drawing.Size(124, 20);
            this.edt_RepeatCount.TabIndex = 28;
            this.edt_RepeatCount.Text = " 1";
            // 
            // lbl_RepeatCount
            // 
            this.lbl_RepeatCount.AutoSize = true;
            this.lbl_RepeatCount.Location = new System.Drawing.Point(7, 127);
            this.lbl_RepeatCount.Name = "lbl_RepeatCount";
            this.lbl_RepeatCount.Size = new System.Drawing.Size(75, 13);
            this.lbl_RepeatCount.TabIndex = 27;
            this.lbl_RepeatCount.Text = "Repeat count:";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(6, 101);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(29, 13);
            this.lbl_EndDate.TabIndex = 26;
            this.lbl_EndDate.Text = "End:";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(131, 98);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(124, 20);
            this.dtp_EndDate.TabIndex = 25;
            this.dtp_EndDate.Value = new System.DateTime(2015, 8, 5, 0, 0, 0, 0);
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(7, 75);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(32, 13);
            this.lbl_StartDate.TabIndex = 24;
            this.lbl_StartDate.Text = "Start:";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(131, 72);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(124, 20);
            this.dtp_StartDate.TabIndex = 23;
            this.dtp_StartDate.Value = new System.DateTime(2015, 8, 5, 0, 0, 0, 0);
            // 
            // lbl_End
            // 
            this.lbl_End.AutoSize = true;
            this.lbl_End.Location = new System.Drawing.Point(7, 49);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(43, 13);
            this.lbl_End.TabIndex = 22;
            this.lbl_End.Text = "End by:";
            // 
            // cbl_End
            // 
            this.cbl_End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_End.FormattingEnabled = true;
            this.cbl_End.Location = new System.Drawing.Point(131, 46);
            this.cbl_End.Name = "cbl_End";
            this.cbl_End.Size = new System.Drawing.Size(124, 21);
            this.cbl_End.TabIndex = 21;
            this.cbl_End.SelectedIndexChanged += new System.EventHandler(this.cbl_End_SelectedIndexChanged);
            this.cbl_End.EnabledChanged += new System.EventHandler(this.cbl_End_EnabledChanged);
            // 
            // lbl_Repeat
            // 
            this.lbl_Repeat.AutoSize = true;
            this.lbl_Repeat.Location = new System.Drawing.Point(7, 22);
            this.lbl_Repeat.Name = "lbl_Repeat";
            this.lbl_Repeat.Size = new System.Drawing.Size(45, 13);
            this.lbl_Repeat.TabIndex = 20;
            this.lbl_Repeat.Text = "Repeat:";
            // 
            // cbl_RepeatType
            // 
            this.cbl_RepeatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_RepeatType.FormattingEnabled = true;
            this.cbl_RepeatType.Location = new System.Drawing.Point(131, 19);
            this.cbl_RepeatType.Name = "cbl_RepeatType";
            this.cbl_RepeatType.Size = new System.Drawing.Size(124, 21);
            this.cbl_RepeatType.TabIndex = 19;
            this.cbl_RepeatType.SelectedIndexChanged += new System.EventHandler(this.cbl_RepeatType_SelectedIndexChanged);
            // 
            // gp_Adjust
            // 
            this.gp_Adjust.Controls.Add(this.rb_AdjustReverse);
            this.gp_Adjust.Controls.Add(this.rb_AdjustSimple);
            this.gp_Adjust.Controls.Add(this.rb_AdjustRegular);
            this.gp_Adjust.Controls.Add(this.edt_AdjustTrId);
            this.gp_Adjust.Controls.Add(this.lbl_AdjustTrId);
            this.gp_Adjust.Controls.Add(this.edt_AdjustPhone);
            this.gp_Adjust.Controls.Add(this.edt_AdjustEmail);
            this.gp_Adjust.Controls.Add(this.lbl_AdjustPhone);
            this.gp_Adjust.Controls.Add(this.lbl_AdjustEmail);
            this.gp_Adjust.Location = new System.Drawing.Point(275, 380);
            this.gp_Adjust.Name = "gp_Adjust";
            this.gp_Adjust.Size = new System.Drawing.Size(258, 170);
            this.gp_Adjust.TabIndex = 13;
            this.gp_Adjust.TabStop = false;
            this.gp_Adjust.Text = "Adjust payment";
            // 
            // rb_AdjustReverse
            // 
            this.rb_AdjustReverse.AutoSize = true;
            this.rb_AdjustReverse.Location = new System.Drawing.Point(9, 64);
            this.rb_AdjustReverse.Name = "rb_AdjustReverse";
            this.rb_AdjustReverse.Size = new System.Drawing.Size(135, 17);
            this.rb_AdjustReverse.TabIndex = 54;
            this.rb_AdjustReverse.Text = "Adjust reverse payment";
            this.rb_AdjustReverse.UseVisualStyleBackColor = true;
            // 
            // rb_AdjustSimple
            // 
            this.rb_AdjustSimple.AutoSize = true;
            this.rb_AdjustSimple.Checked = true;
            this.rb_AdjustSimple.Location = new System.Drawing.Point(9, 19);
            this.rb_AdjustSimple.Name = "rb_AdjustSimple";
            this.rb_AdjustSimple.Size = new System.Drawing.Size(97, 17);
            this.rb_AdjustSimple.TabIndex = 53;
            this.rb_AdjustSimple.TabStop = true;
            this.rb_AdjustSimple.Text = "Adjust payment";
            this.rb_AdjustSimple.UseVisualStyleBackColor = true;
            // 
            // rb_AdjustRegular
            // 
            this.rb_AdjustRegular.AutoSize = true;
            this.rb_AdjustRegular.Location = new System.Drawing.Point(9, 41);
            this.rb_AdjustRegular.Name = "rb_AdjustRegular";
            this.rb_AdjustRegular.Size = new System.Drawing.Size(132, 17);
            this.rb_AdjustRegular.TabIndex = 52;
            this.rb_AdjustRegular.Text = "Adjust regular payment";
            this.rb_AdjustRegular.UseVisualStyleBackColor = true;
            // 
            // edt_AdjustTrId
            // 
            this.edt_AdjustTrId.Location = new System.Drawing.Point(128, 90);
            this.edt_AdjustTrId.Name = "edt_AdjustTrId";
            this.edt_AdjustTrId.Size = new System.Drawing.Size(124, 20);
            this.edt_AdjustTrId.TabIndex = 51;
            // 
            // lbl_AdjustTrId
            // 
            this.lbl_AdjustTrId.AutoSize = true;
            this.lbl_AdjustTrId.Location = new System.Drawing.Point(6, 93);
            this.lbl_AdjustTrId.Name = "lbl_AdjustTrId";
            this.lbl_AdjustTrId.Size = new System.Drawing.Size(80, 13);
            this.lbl_AdjustTrId.TabIndex = 50;
            this.lbl_AdjustTrId.Text = "Transaction ID:";
            // 
            // edt_AdjustPhone
            // 
            this.edt_AdjustPhone.Location = new System.Drawing.Point(128, 142);
            this.edt_AdjustPhone.Mask = "+7(000)000-00-00";
            this.edt_AdjustPhone.Name = "edt_AdjustPhone";
            this.edt_AdjustPhone.Size = new System.Drawing.Size(124, 20);
            this.edt_AdjustPhone.TabIndex = 48;
            this.edt_AdjustPhone.Text = "0123456789";
            // 
            // edt_AdjustEmail
            // 
            this.edt_AdjustEmail.Location = new System.Drawing.Point(128, 116);
            this.edt_AdjustEmail.Name = "edt_AdjustEmail";
            this.edt_AdjustEmail.Size = new System.Drawing.Size(124, 20);
            this.edt_AdjustEmail.TabIndex = 47;
            // 
            // lbl_AdjustPhone
            // 
            this.lbl_AdjustPhone.AutoSize = true;
            this.lbl_AdjustPhone.Location = new System.Drawing.Point(6, 145);
            this.lbl_AdjustPhone.Name = "lbl_AdjustPhone";
            this.lbl_AdjustPhone.Size = new System.Drawing.Size(41, 13);
            this.lbl_AdjustPhone.TabIndex = 45;
            this.lbl_AdjustPhone.Text = "Phone:";
            // 
            // lbl_AdjustEmail
            // 
            this.lbl_AdjustEmail.AutoSize = true;
            this.lbl_AdjustEmail.Location = new System.Drawing.Point(6, 119);
            this.lbl_AdjustEmail.Name = "lbl_AdjustEmail";
            this.lbl_AdjustEmail.Size = new System.Drawing.Size(35, 13);
            this.lbl_AdjustEmail.TabIndex = 46;
            this.lbl_AdjustEmail.Text = "Email:";
            // 
            // btn_Adjust
            // 
            this.btn_Adjust.Location = new System.Drawing.Point(275, 556);
            this.btn_Adjust.Name = "btn_Adjust";
            this.btn_Adjust.Size = new System.Drawing.Size(258, 30);
            this.btn_Adjust.TabIndex = 14;
            this.btn_Adjust.Text = "Adjust payment";
            this.btn_Adjust.UseVisualStyleBackColor = true;
            this.btn_Adjust.Click += new System.EventHandler(this.btn_Adjust_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(8, 42);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 17;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(8, 16);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(36, 13);
            this.lbl_Login.TabIndex = 16;
            this.lbl_Login.Text = "Login:";
            // 
            // edt_Password
            // 
            this.edt_Password.Location = new System.Drawing.Point(139, 39);
            this.edt_Password.Name = "edt_Password";
            this.edt_Password.Size = new System.Drawing.Size(130, 20);
            this.edt_Password.TabIndex = 2;
            this.edt_Password.Text = "triton";
            // 
            // edt_Login
            // 
            this.edt_Login.Location = new System.Drawing.Point(139, 13);
            this.edt_Login.Name = "edt_Login";
            this.edt_Login.Size = new System.Drawing.Size(130, 20);
            this.edt_Login.TabIndex = 1;
            this.edt_Login.Text = "pf@cardport.kiev";
            // 
            // gp_History
            // 
            this.gp_History.Controls.Add(this.edt_HistoryPage);
            this.gp_History.Controls.Add(this.lbl_HistoryPage);
            this.gp_History.Location = new System.Drawing.Point(275, 592);
            this.gp_History.Name = "gp_History";
            this.gp_History.Size = new System.Drawing.Size(258, 44);
            this.gp_History.TabIndex = 19;
            this.gp_History.TabStop = false;
            this.gp_History.Text = "History";
            // 
            // edt_HistoryPage
            // 
            this.edt_HistoryPage.Location = new System.Drawing.Point(131, 15);
            this.edt_HistoryPage.Name = "edt_HistoryPage";
            this.edt_HistoryPage.PromptChar = '0';
            this.edt_HistoryPage.Size = new System.Drawing.Size(121, 20);
            this.edt_HistoryPage.TabIndex = 30;
            this.edt_HistoryPage.Text = " 1";
            // 
            // lbl_HistoryPage
            // 
            this.lbl_HistoryPage.AutoSize = true;
            this.lbl_HistoryPage.Location = new System.Drawing.Point(6, 18);
            this.lbl_HistoryPage.Name = "lbl_HistoryPage";
            this.lbl_HistoryPage.Size = new System.Drawing.Size(58, 13);
            this.lbl_HistoryPage.TabIndex = 29;
            this.lbl_HistoryPage.Text = "Page num:";
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(275, 642);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(258, 30);
            this.btn_History.TabIndex = 20;
            this.btn_History.Text = "Get history";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // cb_Product
            // 
            this.cb_Product.AutoSize = true;
            this.cb_Product.Location = new System.Drawing.Point(284, 258);
            this.cb_Product.Name = "cb_Product";
            this.cb_Product.Size = new System.Drawing.Size(127, 17);
            this.cb_Product.TabIndex = 100;
            this.cb_Product.Text = "Add payment product";
            this.cb_Product.UseVisualStyleBackColor = true;
            this.cb_Product.CheckedChanged += new System.EventHandler(this.cb_Product_CheckedChanged);
            // 
            // gp_Product
            // 
            this.gp_Product.Controls.Add(this.edt_Field2);
            this.gp_Product.Controls.Add(this.edt_Field1);
            this.gp_Product.Controls.Add(this.lbl_Field2);
            this.gp_Product.Controls.Add(this.lbl_Field1);
            this.gp_Product.Location = new System.Drawing.Point(275, 306);
            this.gp_Product.Name = "gp_Product";
            this.gp_Product.Size = new System.Drawing.Size(258, 73);
            this.gp_Product.TabIndex = 101;
            this.gp_Product.TabStop = false;
            this.gp_Product.Text = "Payment product";
            // 
            // edt_Field2
            // 
            this.edt_Field2.Location = new System.Drawing.Point(128, 45);
            this.edt_Field2.Name = "edt_Field2";
            this.edt_Field2.Size = new System.Drawing.Size(124, 20);
            this.edt_Field2.TabIndex = 5;
            // 
            // edt_Field1
            // 
            this.edt_Field1.Location = new System.Drawing.Point(128, 19);
            this.edt_Field1.Name = "edt_Field1";
            this.edt_Field1.Size = new System.Drawing.Size(124, 20);
            this.edt_Field1.TabIndex = 4;
            // 
            // lbl_Field2
            // 
            this.lbl_Field2.AutoSize = true;
            this.lbl_Field2.Location = new System.Drawing.Point(6, 48);
            this.lbl_Field2.Name = "lbl_Field2";
            this.lbl_Field2.Size = new System.Drawing.Size(102, 13);
            this.lbl_Field2.TabIndex = 1;
            this.lbl_Field2.Text = "Field 2 (image path):";
            // 
            // lbl_Field1
            // 
            this.lbl_Field1.AutoSize = true;
            this.lbl_Field1.Location = new System.Drawing.Point(6, 22);
            this.lbl_Field1.Name = "lbl_Field1";
            this.lbl_Field1.Size = new System.Drawing.Size(41, 13);
            this.lbl_Field1.TabIndex = 0;
            this.lbl_Field1.Text = "Field 1:";
            // 
            // lbl_ImageFilePath
            // 
            this.lbl_ImageFilePath.AutoSize = true;
            this.lbl_ImageFilePath.Location = new System.Drawing.Point(8, 120);
            this.lbl_ImageFilePath.Name = "lbl_ImageFilePath";
            this.lbl_ImageFilePath.Size = new System.Drawing.Size(79, 13);
            this.lbl_ImageFilePath.TabIndex = 102;
            this.lbl_ImageFilePath.Text = "Image file path:";
            // 
            // edt_ImageFilePath
            // 
            this.edt_ImageFilePath.Location = new System.Drawing.Point(139, 117);
            this.edt_ImageFilePath.Name = "edt_ImageFilePath";
            this.edt_ImageFilePath.Size = new System.Drawing.Size(130, 20);
            this.edt_ImageFilePath.TabIndex = 103;
            // 
            // edt_Com
            // 
            this.edt_Com.Location = new System.Drawing.Point(406, 13);
            this.edt_Com.Name = "edt_Com";
            this.edt_Com.Size = new System.Drawing.Size(130, 20);
            this.edt_Com.TabIndex = 104;
            // 
            // lbl_Com
            // 
            this.lbl_Com.AutoSize = true;
            this.lbl_Com.Location = new System.Drawing.Point(277, 15);
            this.lbl_Com.Name = "lbl_Com";
            this.lbl_Com.Size = new System.Drawing.Size(129, 13);
            this.lbl_Com.TabIndex = 105;
            this.lbl_Com.Text = "COM port name (BT only):";
            // 
            // btn_Reverse
            // 
            this.btn_Reverse.Location = new System.Drawing.Point(11, 678);
            this.btn_Reverse.Name = "btn_Reverse";
            this.btn_Reverse.Size = new System.Drawing.Size(261, 30);
            this.btn_Reverse.TabIndex = 107;
            this.btn_Reverse.Text = "Reverse Payment";
            this.btn_Reverse.UseVisualStyleBackColor = true;
            this.btn_Reverse.Click += new System.EventHandler(this.btn_Reverse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_ReverseAmount);
            this.groupBox1.Controls.Add(this.lbl_ReverseAmount);
            this.groupBox1.Controls.Add(this.edt_ReverseID);
            this.groupBox1.Controls.Add(this.rb_Cancel);
            this.groupBox1.Controls.Add(this.rb_Return);
            this.groupBox1.Controls.Add(this.lbl_ReverseID);
            this.groupBox1.Location = new System.Drawing.Point(11, 558);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 114);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reverse";
            // 
            // edt_ReverseAmount
            // 
            this.edt_ReverseAmount.Location = new System.Drawing.Point(92, 41);
            this.edt_ReverseAmount.Name = "edt_ReverseAmount";
            this.edt_ReverseAmount.PromptChar = ' ';
            this.edt_ReverseAmount.Size = new System.Drawing.Size(163, 20);
            this.edt_ReverseAmount.TabIndex = 58;
            // 
            // lbl_ReverseAmount
            // 
            this.lbl_ReverseAmount.AutoSize = true;
            this.lbl_ReverseAmount.Location = new System.Drawing.Point(6, 44);
            this.lbl_ReverseAmount.Name = "lbl_ReverseAmount";
            this.lbl_ReverseAmount.Size = new System.Drawing.Size(46, 13);
            this.lbl_ReverseAmount.TabIndex = 57;
            this.lbl_ReverseAmount.Text = "Amount:";
            // 
            // edt_ReverseID
            // 
            this.edt_ReverseID.Location = new System.Drawing.Point(92, 15);
            this.edt_ReverseID.Name = "edt_ReverseID";
            this.edt_ReverseID.Size = new System.Drawing.Size(163, 20);
            this.edt_ReverseID.TabIndex = 56;
            // 
            // rb_Cancel
            // 
            this.rb_Cancel.AutoSize = true;
            this.rb_Cancel.Checked = true;
            this.rb_Cancel.Location = new System.Drawing.Point(9, 67);
            this.rb_Cancel.Name = "rb_Cancel";
            this.rb_Cancel.Size = new System.Drawing.Size(58, 17);
            this.rb_Cancel.TabIndex = 55;
            this.rb_Cancel.TabStop = true;
            this.rb_Cancel.Text = "Cancel";
            this.rb_Cancel.UseVisualStyleBackColor = true;
            // 
            // rb_Return
            // 
            this.rb_Return.AutoSize = true;
            this.rb_Return.Location = new System.Drawing.Point(9, 90);
            this.rb_Return.Name = "rb_Return";
            this.rb_Return.Size = new System.Drawing.Size(57, 17);
            this.rb_Return.TabIndex = 54;
            this.rb_Return.Text = "Return";
            this.rb_Return.UseVisualStyleBackColor = true;
            // 
            // lbl_ReverseID
            // 
            this.lbl_ReverseID.AutoSize = true;
            this.lbl_ReverseID.Location = new System.Drawing.Point(6, 18);
            this.lbl_ReverseID.Name = "lbl_ReverseID";
            this.lbl_ReverseID.Size = new System.Drawing.Size(80, 13);
            this.lbl_ReverseID.TabIndex = 29;
            this.lbl_ReverseID.Text = "Transaction ID:";
            // 
            // gb_Currency
            // 
            this.gb_Currency.Controls.Add(this.rb_VND);
            this.gb_Currency.Controls.Add(this.rb_RUB);
            this.gb_Currency.Location = new System.Drawing.Point(275, 141);
            this.gb_Currency.Name = "gb_Currency";
            this.gb_Currency.Size = new System.Drawing.Size(261, 62);
            this.gb_Currency.TabIndex = 108;
            this.gb_Currency.TabStop = false;
            this.gb_Currency.Text = "Currency";
            // 
            // rb_VND
            // 
            this.rb_VND.AutoSize = true;
            this.rb_VND.Location = new System.Drawing.Point(9, 42);
            this.rb_VND.Name = "rb_VND";
            this.rb_VND.Size = new System.Drawing.Size(51, 17);
            this.rb_VND.TabIndex = 1;
            this.rb_VND.TabStop = true;
            this.rb_VND.Text = "Dong";
            this.rb_VND.UseVisualStyleBackColor = true;
            // 
            // rb_RUB
            // 
            this.rb_RUB.AutoSize = true;
            this.rb_RUB.Checked = true;
            this.rb_RUB.Location = new System.Drawing.Point(9, 19);
            this.rb_RUB.Name = "rb_RUB";
            this.rb_RUB.Size = new System.Drawing.Size(59, 17);
            this.rb_RUB.TabIndex = 0;
            this.rb_RUB.TabStop = true;
            this.rb_RUB.Text = "Rouble";
            this.rb_RUB.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(399, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 30);
            this.btnCancel.TabIndex = 109;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cb_SinglestepEMV
            // 
            this.cb_SinglestepEMV.AutoSize = true;
            this.cb_SinglestepEMV.Location = new System.Drawing.Point(284, 281);
            this.cb_SinglestepEMV.Name = "cb_SinglestepEMV";
            this.cb_SinglestepEMV.Size = new System.Drawing.Size(101, 17);
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
            this.edt_Log.Location = new System.Drawing.Point(542, 13);
            this.edt_Log.Name = "edt_Log";
            this.edt_Log.ReadOnly = true;
            this.edt_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.edt_Log.Size = new System.Drawing.Size(698, 695);
            this.edt_Log.TabIndex = 111;
            this.edt_Log.Text = "";
            // 
            // cb_Cash
            // 
            this.cb_Cash.AutoSize = true;
            this.cb_Cash.Location = new System.Drawing.Point(284, 212);
            this.cb_Cash.Name = "cb_Cash";
            this.cb_Cash.Size = new System.Drawing.Size(50, 17);
            this.cb_Cash.TabIndex = 112;
            this.cb_Cash.Text = "Cash";
            this.cb_Cash.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 720);
            this.Controls.Add(this.cb_Cash);
            this.Controls.Add(this.edt_Log);
            this.Controls.Add(this.cb_SinglestepEMV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gb_Currency);
            this.Controls.Add(this.btn_Reverse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.edt_Com);
            this.Controls.Add(this.lbl_Com);
            this.Controls.Add(this.edt_ImageFilePath);
            this.Controls.Add(this.lbl_ImageFilePath);
            this.Controls.Add(this.gp_Product);
            this.Controls.Add(this.cb_Product);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.gp_History);
            this.Controls.Add(this.edt_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.edt_Password);
            this.Controls.Add(this.btn_Adjust);
            this.Controls.Add(this.gp_Adjust);
            this.Controls.Add(this.gp_Regular);
            this.Controls.Add(this.cb_Regular);
            this.Controls.Add(this.btn_ClearLog);
            this.Controls.Add(this.edt_Amount);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.edt_Description);
            this.Controls.Add(this.btn_StartPayment);
            this.Controls.Add(this.btn_Disable);
            this.Controls.Add(this.btn_Enable);
            this.Name = "MainForm";
            this.Text = "Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.gp_Regular.ResumeLayout(false);
            this.gp_Regular.PerformLayout();
            this.gp_Adjust.ResumeLayout(false);
            this.gp_Adjust.PerformLayout();
            this.gp_History.ResumeLayout(false);
            this.gp_History.PerformLayout();
            this.gp_Product.ResumeLayout(false);
            this.gp_Product.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Currency.ResumeLayout(false);
            this.gb_Currency.PerformLayout();
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
        private System.Windows.Forms.GroupBox gp_Regular;
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
        private System.Windows.Forms.GroupBox gp_Adjust;
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
        private System.Windows.Forms.GroupBox gp_History;
        private System.Windows.Forms.MaskedTextBox edt_HistoryPage;
        private System.Windows.Forms.Label lbl_HistoryPage;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.CheckBox cb_Product;
        private System.Windows.Forms.GroupBox gp_Product;
        private System.Windows.Forms.TextBox edt_Field2;
        private System.Windows.Forms.TextBox edt_Field1;
        private System.Windows.Forms.Label lbl_Field2;
        private System.Windows.Forms.Label lbl_Field1;
        private System.Windows.Forms.Label lbl_ImageFilePath;
        private System.Windows.Forms.TextBox edt_ImageFilePath;
        private System.Windows.Forms.TextBox edt_Com;
        private System.Windows.Forms.Label lbl_Com;
        private System.Windows.Forms.RadioButton rb_AdjustReverse;
        private System.Windows.Forms.RadioButton rb_AdjustSimple;
        private System.Windows.Forms.RadioButton rb_AdjustRegular;
        private System.Windows.Forms.Button btn_Reverse;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

