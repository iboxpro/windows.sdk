namespace Example
{
    partial class DialogRegular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_QMonth = new System.Windows.Forms.Label();
            this.cbl_QMonth = new System.Windows.Forms.ComboBox();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.cbl_Day = new System.Windows.Forms.ComboBox();
            this.edt_ArbitraryDays = new System.Windows.Forms.TextBox();
            this.lbl_ArbitraryDays = new System.Windows.Forms.Label();
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_QMonth
            // 
            this.lbl_QMonth.AutoSize = true;
            this.lbl_QMonth.Location = new System.Drawing.Point(12, 146);
            this.lbl_QMonth.Name = "lbl_QMonth";
            this.lbl_QMonth.Size = new System.Drawing.Size(88, 13);
            this.lbl_QMonth.TabIndex = 36;
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
            this.cbl_QMonth.Location = new System.Drawing.Point(136, 143);
            this.cbl_QMonth.Name = "cbl_QMonth";
            this.cbl_QMonth.Size = new System.Drawing.Size(124, 21);
            this.cbl_QMonth.TabIndex = 37;
            // 
            // dtp_Time
            // 
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Time.Location = new System.Drawing.Point(136, 251);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(124, 20);
            this.dtp_Time.TabIndex = 45;
            // 
            // cbl_Day
            // 
            this.cbl_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_Day.FormattingEnabled = true;
            this.cbl_Day.Location = new System.Drawing.Point(136, 197);
            this.cbl_Day.Name = "cbl_Day";
            this.cbl_Day.Size = new System.Drawing.Size(124, 21);
            this.cbl_Day.TabIndex = 41;
            // 
            // edt_ArbitraryDays
            // 
            this.edt_ArbitraryDays.Location = new System.Drawing.Point(137, 277);
            this.edt_ArbitraryDays.Multiline = true;
            this.edt_ArbitraryDays.Name = "edt_ArbitraryDays";
            this.edt_ArbitraryDays.Size = new System.Drawing.Size(124, 32);
            this.edt_ArbitraryDays.TabIndex = 51;
            this.edt_ArbitraryDays.Text = "01.01.2016;\r\n02.02.2016";
            // 
            // lbl_ArbitraryDays
            // 
            this.lbl_ArbitraryDays.AutoSize = true;
            this.lbl_ArbitraryDays.Location = new System.Drawing.Point(12, 280);
            this.lbl_ArbitraryDays.Name = "lbl_ArbitraryDays";
            this.lbl_ArbitraryDays.Size = new System.Drawing.Size(34, 13);
            this.lbl_ArbitraryDays.TabIndex = 50;
            this.lbl_ArbitraryDays.Text = "Days:";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(12, 254);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(33, 13);
            this.lbl_Time.TabIndex = 44;
            this.lbl_Time.Text = "Time:";
            // 
            // lbl_DayOfWeek
            // 
            this.lbl_DayOfWeek.AutoSize = true;
            this.lbl_DayOfWeek.Location = new System.Drawing.Point(12, 227);
            this.lbl_DayOfWeek.Name = "lbl_DayOfWeek";
            this.lbl_DayOfWeek.Size = new System.Drawing.Size(70, 13);
            this.lbl_DayOfWeek.TabIndex = 42;
            this.lbl_DayOfWeek.Text = "Day of week:";
            // 
            // cbl_DayOfWeek
            // 
            this.cbl_DayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_DayOfWeek.FormattingEnabled = true;
            this.cbl_DayOfWeek.Location = new System.Drawing.Point(136, 224);
            this.cbl_DayOfWeek.Name = "cbl_DayOfWeek";
            this.cbl_DayOfWeek.Size = new System.Drawing.Size(124, 21);
            this.cbl_DayOfWeek.TabIndex = 43;
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Location = new System.Drawing.Point(12, 200);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(29, 13);
            this.lbl_Day.TabIndex = 40;
            this.lbl_Day.Text = "Day:";
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Location = new System.Drawing.Point(12, 173);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(40, 13);
            this.lbl_Month.TabIndex = 38;
            this.lbl_Month.Text = "Month:";
            // 
            // cbl_Month
            // 
            this.cbl_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_Month.FormattingEnabled = true;
            this.cbl_Month.Location = new System.Drawing.Point(136, 170);
            this.cbl_Month.Name = "cbl_Month";
            this.cbl_Month.Size = new System.Drawing.Size(124, 21);
            this.cbl_Month.TabIndex = 39;
            // 
            // edt_RepeatCount
            // 
            this.edt_RepeatCount.Location = new System.Drawing.Point(136, 117);
            this.edt_RepeatCount.Mask = "00";
            this.edt_RepeatCount.Name = "edt_RepeatCount";
            this.edt_RepeatCount.Size = new System.Drawing.Size(124, 20);
            this.edt_RepeatCount.TabIndex = 35;
            this.edt_RepeatCount.Text = " 1";
            // 
            // lbl_RepeatCount
            // 
            this.lbl_RepeatCount.AutoSize = true;
            this.lbl_RepeatCount.Location = new System.Drawing.Point(12, 120);
            this.lbl_RepeatCount.Name = "lbl_RepeatCount";
            this.lbl_RepeatCount.Size = new System.Drawing.Size(75, 13);
            this.lbl_RepeatCount.TabIndex = 34;
            this.lbl_RepeatCount.Text = "Repeat count:";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(11, 94);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(29, 13);
            this.lbl_EndDate.TabIndex = 32;
            this.lbl_EndDate.Text = "End:";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(136, 91);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(124, 20);
            this.dtp_EndDate.TabIndex = 33;
            this.dtp_EndDate.Value = new System.DateTime(2015, 8, 5, 0, 0, 0, 0);
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(12, 68);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(32, 13);
            this.lbl_StartDate.TabIndex = 30;
            this.lbl_StartDate.Text = "Start:";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(136, 65);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(124, 20);
            this.dtp_StartDate.TabIndex = 31;
            this.dtp_StartDate.Value = new System.DateTime(2015, 8, 5, 0, 0, 0, 0);
            // 
            // lbl_End
            // 
            this.lbl_End.AutoSize = true;
            this.lbl_End.Location = new System.Drawing.Point(12, 42);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(43, 13);
            this.lbl_End.TabIndex = 28;
            this.lbl_End.Text = "End by:";
            // 
            // cbl_End
            // 
            this.cbl_End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_End.FormattingEnabled = true;
            this.cbl_End.Location = new System.Drawing.Point(136, 39);
            this.cbl_End.Name = "cbl_End";
            this.cbl_End.Size = new System.Drawing.Size(124, 21);
            this.cbl_End.TabIndex = 29;
            // 
            // lbl_Repeat
            // 
            this.lbl_Repeat.AutoSize = true;
            this.lbl_Repeat.Location = new System.Drawing.Point(12, 15);
            this.lbl_Repeat.Name = "lbl_Repeat";
            this.lbl_Repeat.Size = new System.Drawing.Size(45, 13);
            this.lbl_Repeat.TabIndex = 26;
            this.lbl_Repeat.Text = "Repeat:";
            // 
            // cbl_RepeatType
            // 
            this.cbl_RepeatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbl_RepeatType.FormattingEnabled = true;
            this.cbl_RepeatType.Location = new System.Drawing.Point(136, 12);
            this.cbl_RepeatType.Name = "cbl_RepeatType";
            this.cbl_RepeatType.Size = new System.Drawing.Size(124, 21);
            this.cbl_RepeatType.TabIndex = 27;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(141, 315);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 23);
            this.btn_Cancel.TabIndex = 53;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(13, 315);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(120, 23);
            this.btn_OK.TabIndex = 52;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // DialogRegular
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(273, 349);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_QMonth);
            this.Controls.Add(this.cbl_QMonth);
            this.Controls.Add(this.dtp_Time);
            this.Controls.Add(this.cbl_Day);
            this.Controls.Add(this.edt_ArbitraryDays);
            this.Controls.Add(this.lbl_ArbitraryDays);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_DayOfWeek);
            this.Controls.Add(this.cbl_DayOfWeek);
            this.Controls.Add(this.lbl_Day);
            this.Controls.Add(this.lbl_Month);
            this.Controls.Add(this.cbl_Month);
            this.Controls.Add(this.edt_RepeatCount);
            this.Controls.Add(this.lbl_RepeatCount);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.lbl_End);
            this.Controls.Add(this.cbl_End);
            this.Controls.Add(this.lbl_Repeat);
            this.Controls.Add(this.cbl_RepeatType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DialogRegular";
            this.ShowInTaskbar = false;
            this.Text = "Regular payment";
            this.VisibleChanged += new System.EventHandler(this.DialogRegular_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QMonth;
        private System.Windows.Forms.ComboBox cbl_QMonth;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.ComboBox cbl_Day;
        private System.Windows.Forms.TextBox edt_ArbitraryDays;
        private System.Windows.Forms.Label lbl_ArbitraryDays;
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
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}