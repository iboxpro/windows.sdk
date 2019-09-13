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
            this.btn_Adjust = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.edt_Password = new System.Windows.Forms.TextBox();
            this.edt_Login = new System.Windows.Forms.TextBox();
            this.btn_History = new System.Windows.Forms.Button();
            this.cb_Product = new System.Windows.Forms.CheckBox();
            this.lbl_ImageFilePath = new System.Windows.Forms.Label();
            this.edt_ImageFilePath = new System.Windows.Forms.TextBox();
            this.lbl_PairedDevices = new System.Windows.Forms.Label();
            this.btn_Reverse = new System.Windows.Forms.Button();
            this.gb_Currency = new System.Windows.Forms.GroupBox();
            this.rb_VND = new System.Windows.Forms.RadioButton();
            this.rb_RUB = new System.Windows.Forms.RadioButton();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cb_SinglestepEMV = new System.Windows.Forms.CheckBox();
            this.edt_Log = new System.Windows.Forms.RichTextBox();
            this.gb_Reader = new System.Windows.Forms.GroupBox();
            this.rb_Wisepad2 = new System.Windows.Forms.RadioButton();
            this.rb_Qpos_mini = new System.Windows.Forms.RadioButton();
            this.rb_Wisepad = new System.Windows.Forms.RadioButton();
            this.cmb_Paired = new System.Windows.Forms.ComboBox();
            this.cb_Usb = new System.Windows.Forms.CheckBox();
            this.btn_CheckConnection = new System.Windows.Forms.Button();
            this.btn_Auth = new System.Windows.Forms.Button();
            this.gb_Input = new System.Windows.Forms.GroupBox();
            this.rb_LinkedCard = new System.Windows.Forms.RadioButton();
            this.rb_Outer = new System.Windows.Forms.RadioButton();
            this.rb_Link = new System.Windows.Forms.RadioButton();
            this.rb_Cash = new System.Windows.Forms.RadioButton();
            this.rb_Credit = new System.Windows.Forms.RadioButton();
            this.rb_Card = new System.Windows.Forms.RadioButton();
            this.btn_Attach = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.cb_TestServerFisc = new System.Windows.Forms.CheckBox();
            this.cb_Purchases = new System.Windows.Forms.CheckBox();
            this.cb_notup = new System.Windows.Forms.CheckBox();
            this.edt_Phone = new System.Windows.Forms.MaskedTextBox();
            this.edt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.btn_SubmitFiscal = new System.Windows.Forms.Button();
            this.btn_Fiscalize = new System.Windows.Forms.Button();
            this.btnDisableReaderSound = new System.Windows.Forms.Button();
            this.btnEnableReaderSound = new System.Windows.Forms.Button();
            this.cb_Tags = new System.Windows.Forms.CheckBox();
            this.gb_Currency.SuspendLayout();
            this.gb_Reader.SuspendLayout();
            this.gb_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Enable
            // 
            this.btn_Enable.Location = new System.Drawing.Point(275, 68);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(258, 30);
            this.btn_Enable.TabIndex = 27;
            this.btn_Enable.Text = "Enable";
            this.btn_Enable.UseVisualStyleBackColor = true;
            this.btn_Enable.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Disable
            // 
            this.btn_Disable.Location = new System.Drawing.Point(275, 104);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(258, 30);
            this.btn_Disable.TabIndex = 28;
            this.btn_Disable.Text = "Disable";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_StartPayment
            // 
            this.btn_StartPayment.Location = new System.Drawing.Point(275, 228);
            this.btn_StartPayment.Name = "btn_StartPayment";
            this.btn_StartPayment.Size = new System.Drawing.Size(258, 30);
            this.btn_StartPayment.TabIndex = 31;
            this.btn_StartPayment.Text = "Start payment";
            this.btn_StartPayment.UseVisualStyleBackColor = true;
            this.btn_StartPayment.Click += new System.EventHandler(this.btn_StartPayment_Click);
            // 
            // edt_Description
            // 
            this.edt_Description.Location = new System.Drawing.Point(139, 125);
            this.edt_Description.Name = "edt_Description";
            this.edt_Description.Size = new System.Drawing.Size(130, 20);
            this.edt_Description.TabIndex = 8;
            this.edt_Description.Text = "description_sdk_csharp";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(8, 102);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(46, 13);
            this.lbl_Amount.TabIndex = 5;
            this.lbl_Amount.Text = "Amount:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(8, 128);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 7;
            this.lbl_Description.Text = "Description:";
            // 
            // edt_Amount
            // 
            this.edt_Amount.Location = new System.Drawing.Point(139, 99);
            this.edt_Amount.Name = "edt_Amount";
            this.edt_Amount.PromptChar = ' ';
            this.edt_Amount.Size = new System.Drawing.Size(130, 20);
            this.edt_Amount.TabIndex = 6;
            this.edt_Amount.Text = "1";
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.Location = new System.Drawing.Point(272, 531);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(260, 30);
            this.btn_ClearLog.TabIndex = 42;
            this.btn_ClearLog.Text = "Clear log";
            this.btn_ClearLog.UseVisualStyleBackColor = true;
            this.btn_ClearLog.Click += new System.EventHandler(this.btn_ClearLog_Click);
            // 
            // cb_Regular
            // 
            this.cb_Regular.AutoSize = true;
            this.cb_Regular.Location = new System.Drawing.Point(11, 273);
            this.cb_Regular.Name = "cb_Regular";
            this.cb_Regular.Size = new System.Drawing.Size(106, 17);
            this.cb_Regular.TabIndex = 17;
            this.cb_Regular.Text = "Regular payment";
            this.cb_Regular.UseVisualStyleBackColor = true;
            this.cb_Regular.CheckedChanged += new System.EventHandler(this.cb_Regular_CheckedChanged);
            // 
            // btn_Adjust
            // 
            this.btn_Adjust.Location = new System.Drawing.Point(11, 388);
            this.btn_Adjust.Name = "btn_Adjust";
            this.btn_Adjust.Size = new System.Drawing.Size(258, 30);
            this.btn_Adjust.TabIndex = 36;
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
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(8, 16);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(36, 13);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login:";
            // 
            // edt_Password
            // 
            this.edt_Password.Location = new System.Drawing.Point(139, 39);
            this.edt_Password.Name = "edt_Password";
            this.edt_Password.Size = new System.Drawing.Size(130, 20);
            this.edt_Password.TabIndex = 3;
            // 
            // edt_Login
            // 
            this.edt_Login.Location = new System.Drawing.Point(139, 13);
            this.edt_Login.Name = "edt_Login";
            this.edt_Login.Size = new System.Drawing.Size(130, 20);
            this.edt_Login.TabIndex = 1;
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(11, 496);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(258, 30);
            this.btn_History.TabIndex = 39;
            this.btn_History.Text = "Get history";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // cb_Product
            // 
            this.cb_Product.AutoSize = true;
            this.cb_Product.Location = new System.Drawing.Point(11, 294);
            this.cb_Product.Name = "cb_Product";
            this.cb_Product.Size = new System.Drawing.Size(127, 17);
            this.cb_Product.TabIndex = 18;
            this.cb_Product.Text = "Add payment product";
            this.cb_Product.UseVisualStyleBackColor = true;
            this.cb_Product.CheckedChanged += new System.EventHandler(this.cb_Product_CheckedChanged);
            // 
            // lbl_ImageFilePath
            // 
            this.lbl_ImageFilePath.AutoSize = true;
            this.lbl_ImageFilePath.Location = new System.Drawing.Point(8, 154);
            this.lbl_ImageFilePath.Name = "lbl_ImageFilePath";
            this.lbl_ImageFilePath.Size = new System.Drawing.Size(79, 13);
            this.lbl_ImageFilePath.TabIndex = 9;
            this.lbl_ImageFilePath.Text = "Image file path:";
            // 
            // edt_ImageFilePath
            // 
            this.edt_ImageFilePath.Location = new System.Drawing.Point(139, 151);
            this.edt_ImageFilePath.Name = "edt_ImageFilePath";
            this.edt_ImageFilePath.Size = new System.Drawing.Size(130, 20);
            this.edt_ImageFilePath.TabIndex = 10;
            // 
            // lbl_PairedDevices
            // 
            this.lbl_PairedDevices.AutoSize = true;
            this.lbl_PairedDevices.Enabled = false;
            this.lbl_PairedDevices.Location = new System.Drawing.Point(277, 44);
            this.lbl_PairedDevices.Name = "lbl_PairedDevices";
            this.lbl_PairedDevices.Size = new System.Drawing.Size(75, 13);
            this.lbl_PairedDevices.TabIndex = 25;
            this.lbl_PairedDevices.Text = "Select device:";
            // 
            // btn_Reverse
            // 
            this.btn_Reverse.Location = new System.Drawing.Point(275, 298);
            this.btn_Reverse.Name = "btn_Reverse";
            this.btn_Reverse.Size = new System.Drawing.Size(258, 30);
            this.btn_Reverse.TabIndex = 33;
            this.btn_Reverse.Text = "Reverse Payment";
            this.btn_Reverse.UseVisualStyleBackColor = true;
            this.btn_Reverse.Click += new System.EventHandler(this.btn_Reverse_Click);
            // 
            // gb_Currency
            // 
            this.gb_Currency.Controls.Add(this.rb_VND);
            this.gb_Currency.Controls.Add(this.rb_RUB);
            this.gb_Currency.Location = new System.Drawing.Point(406, 140);
            this.gb_Currency.Name = "gb_Currency";
            this.gb_Currency.Size = new System.Drawing.Size(130, 82);
            this.gb_Currency.TabIndex = 30;
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
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(275, 262);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(258, 30);
            this.btn_Cancel.TabIndex = 32;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cb_SinglestepEMV
            // 
            this.cb_SinglestepEMV.AutoSize = true;
            this.cb_SinglestepEMV.Location = new System.Drawing.Point(11, 231);
            this.cb_SinglestepEMV.Name = "cb_SinglestepEMV";
            this.cb_SinglestepEMV.Size = new System.Drawing.Size(101, 17);
            this.cb_SinglestepEMV.TabIndex = 15;
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
            this.edt_Log.Size = new System.Drawing.Size(688, 550);
            this.edt_Log.TabIndex = 43;
            this.edt_Log.Text = "";
            // 
            // gb_Reader
            // 
            this.gb_Reader.Controls.Add(this.rb_Wisepad2);
            this.gb_Reader.Controls.Add(this.rb_Qpos_mini);
            this.gb_Reader.Controls.Add(this.rb_Wisepad);
            this.gb_Reader.Location = new System.Drawing.Point(278, 140);
            this.gb_Reader.Name = "gb_Reader";
            this.gb_Reader.Size = new System.Drawing.Size(122, 82);
            this.gb_Reader.TabIndex = 29;
            this.gb_Reader.TabStop = false;
            this.gb_Reader.Text = "Reader type";
            // 
            // rb_Wisepad2
            // 
            this.rb_Wisepad2.AutoSize = true;
            this.rb_Wisepad2.Location = new System.Drawing.Point(9, 38);
            this.rb_Wisepad2.Name = "rb_Wisepad2";
            this.rb_Wisepad2.Size = new System.Drawing.Size(44, 17);
            this.rb_Wisepad2.TabIndex = 1;
            this.rb_Wisepad2.Text = "P16";
            this.rb_Wisepad2.UseVisualStyleBackColor = true;
            // 
            // rb_Qpos_mini
            // 
            this.rb_Qpos_mini.AutoSize = true;
            this.rb_Qpos_mini.Checked = true;
            this.rb_Qpos_mini.Location = new System.Drawing.Point(9, 60);
            this.rb_Qpos_mini.Name = "rb_Qpos_mini";
            this.rb_Qpos_mini.Size = new System.Drawing.Size(44, 17);
            this.rb_Qpos_mini.TabIndex = 2;
            this.rb_Qpos_mini.TabStop = true;
            this.rb_Qpos_mini.Text = "P17";
            this.rb_Qpos_mini.UseVisualStyleBackColor = true;
            // 
            // rb_Wisepad
            // 
            this.rb_Wisepad.AutoSize = true;
            this.rb_Wisepad.Location = new System.Drawing.Point(9, 16);
            this.rb_Wisepad.Name = "rb_Wisepad";
            this.rb_Wisepad.Size = new System.Drawing.Size(44, 17);
            this.rb_Wisepad.TabIndex = 0;
            this.rb_Wisepad.Text = "P15";
            this.rb_Wisepad.UseVisualStyleBackColor = true;
            // 
            // cmb_Paired
            // 
            this.cmb_Paired.Enabled = false;
            this.cmb_Paired.FormattingEnabled = true;
            this.cmb_Paired.Location = new System.Drawing.Point(358, 41);
            this.cmb_Paired.Name = "cmb_Paired";
            this.cmb_Paired.Size = new System.Drawing.Size(175, 21);
            this.cmb_Paired.TabIndex = 26;
            // 
            // cb_Usb
            // 
            this.cb_Usb.AutoSize = true;
            this.cb_Usb.Checked = true;
            this.cb_Usb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Usb.Location = new System.Drawing.Point(284, 18);
            this.cb_Usb.Name = "cb_Usb";
            this.cb_Usb.Size = new System.Drawing.Size(77, 17);
            this.cb_Usb.TabIndex = 23;
            this.cb_Usb.Text = "USB mode";
            this.cb_Usb.UseVisualStyleBackColor = true;
            this.cb_Usb.CheckedChanged += new System.EventHandler(this.cb_Usb_CheckedChanged);
            // 
            // btn_CheckConnection
            // 
            this.btn_CheckConnection.Location = new System.Drawing.Point(406, 12);
            this.btn_CheckConnection.Name = "btn_CheckConnection";
            this.btn_CheckConnection.Size = new System.Drawing.Size(127, 23);
            this.btn_CheckConnection.TabIndex = 24;
            this.btn_CheckConnection.Text = "Check connection";
            this.btn_CheckConnection.UseVisualStyleBackColor = true;
            this.btn_CheckConnection.Click += new System.EventHandler(this.btn_CheckConnection_Click);
            // 
            // btn_Auth
            // 
            this.btn_Auth.Location = new System.Drawing.Point(11, 66);
            this.btn_Auth.Name = "btn_Auth";
            this.btn_Auth.Size = new System.Drawing.Size(258, 27);
            this.btn_Auth.TabIndex = 4;
            this.btn_Auth.Text = "Auth";
            this.btn_Auth.UseVisualStyleBackColor = true;
            this.btn_Auth.Click += new System.EventHandler(this.btn_Auth_Click);
            // 
            // gb_Input
            // 
            this.gb_Input.Controls.Add(this.rb_LinkedCard);
            this.gb_Input.Controls.Add(this.rb_Outer);
            this.gb_Input.Controls.Add(this.rb_Link);
            this.gb_Input.Controls.Add(this.rb_Cash);
            this.gb_Input.Controls.Add(this.rb_Credit);
            this.gb_Input.Controls.Add(this.rb_Card);
            this.gb_Input.Location = new System.Drawing.Point(147, 231);
            this.gb_Input.Name = "gb_Input";
            this.gb_Input.Size = new System.Drawing.Size(122, 151);
            this.gb_Input.TabIndex = 22;
            this.gb_Input.TabStop = false;
            this.gb_Input.Text = "Payment method";
            // 
            // rb_LinkedCard
            // 
            this.rb_LinkedCard.AutoSize = true;
            this.rb_LinkedCard.Location = new System.Drawing.Point(9, 128);
            this.rb_LinkedCard.Name = "rb_LinkedCard";
            this.rb_LinkedCard.Size = new System.Drawing.Size(81, 17);
            this.rb_LinkedCard.TabIndex = 5;
            this.rb_LinkedCard.Text = "Linked card";
            this.rb_LinkedCard.UseVisualStyleBackColor = true;
            // 
            // rb_Outer
            // 
            this.rb_Outer.AutoSize = true;
            this.rb_Outer.Location = new System.Drawing.Point(9, 105);
            this.rb_Outer.Name = "rb_Outer";
            this.rb_Outer.Size = new System.Drawing.Size(75, 17);
            this.rb_Outer.TabIndex = 4;
            this.rb_Outer.Text = "Outer card";
            this.rb_Outer.UseVisualStyleBackColor = true;
            // 
            // rb_Link
            // 
            this.rb_Link.AutoSize = true;
            this.rb_Link.Location = new System.Drawing.Point(9, 82);
            this.rb_Link.Name = "rb_Link";
            this.rb_Link.Size = new System.Drawing.Size(56, 17);
            this.rb_Link.TabIndex = 3;
            this.rb_Link.Text = "By link";
            this.rb_Link.UseVisualStyleBackColor = true;
            // 
            // rb_Cash
            // 
            this.rb_Cash.AutoSize = true;
            this.rb_Cash.Location = new System.Drawing.Point(9, 38);
            this.rb_Cash.Name = "rb_Cash";
            this.rb_Cash.Size = new System.Drawing.Size(49, 17);
            this.rb_Cash.TabIndex = 1;
            this.rb_Cash.Text = "Cash";
            this.rb_Cash.UseVisualStyleBackColor = true;
            // 
            // rb_Credit
            // 
            this.rb_Credit.AutoSize = true;
            this.rb_Credit.Location = new System.Drawing.Point(9, 60);
            this.rb_Credit.Name = "rb_Credit";
            this.rb_Credit.Size = new System.Drawing.Size(52, 17);
            this.rb_Credit.TabIndex = 2;
            this.rb_Credit.Text = "Credit";
            this.rb_Credit.UseVisualStyleBackColor = true;
            // 
            // rb_Card
            // 
            this.rb_Card.AutoSize = true;
            this.rb_Card.Checked = true;
            this.rb_Card.Location = new System.Drawing.Point(9, 16);
            this.rb_Card.Name = "rb_Card";
            this.rb_Card.Size = new System.Drawing.Size(47, 17);
            this.rb_Card.TabIndex = 0;
            this.rb_Card.TabStop = true;
            this.rb_Card.Text = "Card";
            this.rb_Card.UseVisualStyleBackColor = true;
            // 
            // btn_Attach
            // 
            this.btn_Attach.Location = new System.Drawing.Point(275, 334);
            this.btn_Attach.Name = "btn_Attach";
            this.btn_Attach.Size = new System.Drawing.Size(258, 30);
            this.btn_Attach.TabIndex = 34;
            this.btn_Attach.Text = "Attach card";
            this.btn_Attach.UseVisualStyleBackColor = true;
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(275, 370);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(258, 30);
            this.btn_Remove.TabIndex = 35;
            this.btn_Remove.Text = "Remove card";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // cb_TestServerFisc
            // 
            this.cb_TestServerFisc.AutoSize = true;
            this.cb_TestServerFisc.Location = new System.Drawing.Point(11, 357);
            this.cb_TestServerFisc.Name = "cb_TestServerFisc";
            this.cb_TestServerFisc.Size = new System.Drawing.Size(136, 17);
            this.cb_TestServerFisc.TabIndex = 21;
            this.cb_TestServerFisc.Text = "Test server fiscalization";
            this.cb_TestServerFisc.UseVisualStyleBackColor = true;
            // 
            // cb_Purchases
            // 
            this.cb_Purchases.AutoSize = true;
            this.cb_Purchases.Location = new System.Drawing.Point(11, 315);
            this.cb_Purchases.Name = "cb_Purchases";
            this.cb_Purchases.Size = new System.Drawing.Size(97, 17);
            this.cb_Purchases.TabIndex = 19;
            this.cb_Purchases.Text = "Add purchases";
            this.cb_Purchases.UseVisualStyleBackColor = true;
            this.cb_Purchases.CheckedChanged += new System.EventHandler(this.cb_Purchases_CheckedChanged);
            // 
            // cb_notup
            // 
            this.cb_notup.AutoSize = true;
            this.cb_notup.Location = new System.Drawing.Point(11, 252);
            this.cb_notup.Name = "cb_notup";
            this.cb_notup.Size = new System.Drawing.Size(94, 17);
            this.cb_notup.TabIndex = 16;
            this.cb_notup.Text = "P17 Auto NFC";
            this.cb_notup.UseVisualStyleBackColor = true;
            // 
            // edt_Phone
            // 
            this.edt_Phone.Location = new System.Drawing.Point(139, 202);
            this.edt_Phone.Mask = "+7(000)000-00-00";
            this.edt_Phone.Name = "edt_Phone";
            this.edt_Phone.Size = new System.Drawing.Size(130, 20);
            this.edt_Phone.TabIndex = 14;
            this.edt_Phone.Text = "0123456789";
            // 
            // edt_Email
            // 
            this.edt_Email.Location = new System.Drawing.Point(139, 176);
            this.edt_Email.Name = "edt_Email";
            this.edt_Email.Size = new System.Drawing.Size(130, 20);
            this.edt_Email.TabIndex = 12;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(8, 205);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_Phone.TabIndex = 13;
            this.lbl_Phone.Text = "Phone:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(8, 179);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.lbl_Email.TabIndex = 11;
            this.lbl_Email.Text = "Email:";
            // 
            // btn_SubmitFiscal
            // 
            this.btn_SubmitFiscal.Location = new System.Drawing.Point(11, 424);
            this.btn_SubmitFiscal.Name = "btn_SubmitFiscal";
            this.btn_SubmitFiscal.Size = new System.Drawing.Size(258, 30);
            this.btn_SubmitFiscal.TabIndex = 37;
            this.btn_SubmitFiscal.Text = "Submit fiscal data";
            this.btn_SubmitFiscal.UseVisualStyleBackColor = true;
            this.btn_SubmitFiscal.Click += new System.EventHandler(this.btn_SubmitFiscal_Click);
            // 
            // btn_Fiscalize
            // 
            this.btn_Fiscalize.Location = new System.Drawing.Point(11, 460);
            this.btn_Fiscalize.Name = "btn_Fiscalize";
            this.btn_Fiscalize.Size = new System.Drawing.Size(258, 30);
            this.btn_Fiscalize.TabIndex = 38;
            this.btn_Fiscalize.Text = "Fiscalize";
            this.btn_Fiscalize.UseVisualStyleBackColor = true;
            this.btn_Fiscalize.Click += new System.EventHandler(this.btn_Fiscalize_Click);
            // 
            // btnDisableReaderSound
            // 
            this.btnDisableReaderSound.Location = new System.Drawing.Point(11, 531);
            this.btnDisableReaderSound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisableReaderSound.Name = "btnDisableReaderSound";
            this.btnDisableReaderSound.Size = new System.Drawing.Size(134, 30);
            this.btnDisableReaderSound.TabIndex = 40;
            this.btnDisableReaderSound.Text = "Disable sound";
            this.btnDisableReaderSound.UseVisualStyleBackColor = true;
            this.btnDisableReaderSound.Click += new System.EventHandler(this.btnDisableReaderSound_Click);
            // 
            // btnEnableReaderSound
            // 
            this.btnEnableReaderSound.Location = new System.Drawing.Point(147, 531);
            this.btnEnableReaderSound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnableReaderSound.Name = "btnEnableReaderSound";
            this.btnEnableReaderSound.Size = new System.Drawing.Size(122, 30);
            this.btnEnableReaderSound.TabIndex = 41;
            this.btnEnableReaderSound.Text = "Enable sound";
            this.btnEnableReaderSound.UseVisualStyleBackColor = true;
            this.btnEnableReaderSound.Click += new System.EventHandler(this.btnEnableReaderSound_Click);
            // 
            // cb_Tags
            // 
            this.cb_Tags.AutoSize = true;
            this.cb_Tags.Location = new System.Drawing.Point(11, 336);
            this.cb_Tags.Name = "cb_Tags";
            this.cb_Tags.Size = new System.Drawing.Size(105, 17);
            this.cb_Tags.TabIndex = 20;
            this.cb_Tags.Text = "Add invoice tags";
            this.cb_Tags.UseVisualStyleBackColor = true;
            this.cb_Tags.CheckedChanged += new System.EventHandler(this.cb_Tags_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 572);
            this.Controls.Add(this.cb_Tags);
            this.Controls.Add(this.btnEnableReaderSound);
            this.Controls.Add(this.btnDisableReaderSound);
            this.Controls.Add(this.btn_Fiscalize);
            this.Controls.Add(this.btn_SubmitFiscal);
            this.Controls.Add(this.cb_TestServerFisc);
            this.Controls.Add(this.edt_Phone);
            this.Controls.Add(this.edt_Email);
            this.Controls.Add(this.cb_Purchases);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.cb_notup);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Attach);
            this.Controls.Add(this.cb_Regular);
            this.Controls.Add(this.gb_Input);
            this.Controls.Add(this.btn_Auth);
            this.Controls.Add(this.btn_CheckConnection);
            this.Controls.Add(this.cb_Usb);
            this.Controls.Add(this.cmb_Paired);
            this.Controls.Add(this.gb_Reader);
            this.Controls.Add(this.edt_Log);
            this.Controls.Add(this.cb_SinglestepEMV);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.gb_Currency);
            this.Controls.Add(this.btn_Reverse);
            this.Controls.Add(this.lbl_PairedDevices);
            this.Controls.Add(this.edt_ImageFilePath);
            this.Controls.Add(this.lbl_ImageFilePath);
            this.Controls.Add(this.cb_Product);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.edt_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.edt_Password);
            this.Controls.Add(this.btn_Adjust);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gb_Currency.ResumeLayout(false);
            this.gb_Currency.PerformLayout();
            this.gb_Reader.ResumeLayout(false);
            this.gb_Reader.PerformLayout();
            this.gb_Input.ResumeLayout(false);
            this.gb_Input.PerformLayout();
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
        private System.Windows.Forms.Button btn_Adjust;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox edt_Password;
        private System.Windows.Forms.TextBox edt_Login;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.CheckBox cb_Product;
        private System.Windows.Forms.Label lbl_ImageFilePath;
        private System.Windows.Forms.TextBox edt_ImageFilePath;
        private System.Windows.Forms.Label lbl_PairedDevices;
        private System.Windows.Forms.Button btn_Reverse;
        private System.Windows.Forms.GroupBox gb_Currency;
        private System.Windows.Forms.RadioButton rb_VND;
        private System.Windows.Forms.RadioButton rb_RUB;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckBox cb_SinglestepEMV;
        private System.Windows.Forms.RichTextBox edt_Log;
        private System.Windows.Forms.GroupBox gb_Reader;
        private System.Windows.Forms.RadioButton rb_Qpos_mini;
        private System.Windows.Forms.RadioButton rb_Wisepad;
        private System.Windows.Forms.RadioButton rb_Wisepad2;
        private System.Windows.Forms.ComboBox cmb_Paired;
        private System.Windows.Forms.CheckBox cb_Usb;
        private System.Windows.Forms.Button btn_CheckConnection;
        private System.Windows.Forms.Button btn_Auth;
        private System.Windows.Forms.GroupBox gb_Input;
        private System.Windows.Forms.RadioButton rb_Cash;
        private System.Windows.Forms.RadioButton rb_Credit;
        private System.Windows.Forms.RadioButton rb_Card;
        private System.Windows.Forms.RadioButton rb_LinkedCard;
        private System.Windows.Forms.RadioButton rb_Outer;
        private System.Windows.Forms.RadioButton rb_Link;
        private System.Windows.Forms.Button btn_Attach;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.CheckBox cb_TestServerFisc;
        private System.Windows.Forms.CheckBox cb_Purchases;
        private System.Windows.Forms.CheckBox cb_notup;
        private System.Windows.Forms.MaskedTextBox edt_Phone;
        private System.Windows.Forms.TextBox edt_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Button btn_SubmitFiscal;
        private System.Windows.Forms.Button btn_Fiscalize;
        private System.Windows.Forms.Button btnDisableReaderSound;
        private System.Windows.Forms.Button btnEnableReaderSound;
        private System.Windows.Forms.CheckBox cb_Tags;
    }
}

