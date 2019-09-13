namespace Example
{
    partial class DialogAdjust
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
            this.rb_AdjustReverse = new System.Windows.Forms.RadioButton();
            this.rb_AdjustSimple = new System.Windows.Forms.RadioButton();
            this.rb_AdjustRegular = new System.Windows.Forms.RadioButton();
            this.edt_AdjustTrId = new System.Windows.Forms.TextBox();
            this.lbl_AdjustTrId = new System.Windows.Forms.Label();
            this.edt_AdjustPhone = new System.Windows.Forms.MaskedTextBox();
            this.edt_AdjustEmail = new System.Windows.Forms.TextBox();
            this.lbl_AdjustPhone = new System.Windows.Forms.Label();
            this.lbl_AdjustEmail = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_AdjustReverse
            // 
            this.rb_AdjustReverse.AutoSize = true;
            this.rb_AdjustReverse.Location = new System.Drawing.Point(12, 57);
            this.rb_AdjustReverse.Name = "rb_AdjustReverse";
            this.rb_AdjustReverse.Size = new System.Drawing.Size(135, 17);
            this.rb_AdjustReverse.TabIndex = 11;
            this.rb_AdjustReverse.Text = "Adjust reverse payment";
            this.rb_AdjustReverse.UseVisualStyleBackColor = true;
            // 
            // rb_AdjustSimple
            // 
            this.rb_AdjustSimple.AutoSize = true;
            this.rb_AdjustSimple.Checked = true;
            this.rb_AdjustSimple.Location = new System.Drawing.Point(12, 12);
            this.rb_AdjustSimple.Name = "rb_AdjustSimple";
            this.rb_AdjustSimple.Size = new System.Drawing.Size(97, 17);
            this.rb_AdjustSimple.TabIndex = 9;
            this.rb_AdjustSimple.TabStop = true;
            this.rb_AdjustSimple.Text = "Adjust payment";
            this.rb_AdjustSimple.UseVisualStyleBackColor = true;
            // 
            // rb_AdjustRegular
            // 
            this.rb_AdjustRegular.AutoSize = true;
            this.rb_AdjustRegular.Location = new System.Drawing.Point(12, 34);
            this.rb_AdjustRegular.Name = "rb_AdjustRegular";
            this.rb_AdjustRegular.Size = new System.Drawing.Size(132, 17);
            this.rb_AdjustRegular.TabIndex = 10;
            this.rb_AdjustRegular.Text = "Adjust regular payment";
            this.rb_AdjustRegular.UseVisualStyleBackColor = true;
            // 
            // edt_AdjustTrId
            // 
            this.edt_AdjustTrId.Location = new System.Drawing.Point(134, 83);
            this.edt_AdjustTrId.Name = "edt_AdjustTrId";
            this.edt_AdjustTrId.Size = new System.Drawing.Size(121, 20);
            this.edt_AdjustTrId.TabIndex = 13;
            // 
            // lbl_AdjustTrId
            // 
            this.lbl_AdjustTrId.AutoSize = true;
            this.lbl_AdjustTrId.Location = new System.Drawing.Point(9, 86);
            this.lbl_AdjustTrId.Name = "lbl_AdjustTrId";
            this.lbl_AdjustTrId.Size = new System.Drawing.Size(80, 13);
            this.lbl_AdjustTrId.TabIndex = 12;
            this.lbl_AdjustTrId.Text = "Transaction ID:";
            // 
            // edt_AdjustPhone
            // 
            this.edt_AdjustPhone.Location = new System.Drawing.Point(134, 135);
            this.edt_AdjustPhone.Mask = "+7(000)000-00-00";
            this.edt_AdjustPhone.Name = "edt_AdjustPhone";
            this.edt_AdjustPhone.Size = new System.Drawing.Size(121, 20);
            this.edt_AdjustPhone.TabIndex = 17;
            // 
            // edt_AdjustEmail
            // 
            this.edt_AdjustEmail.Location = new System.Drawing.Point(134, 109);
            this.edt_AdjustEmail.Name = "edt_AdjustEmail";
            this.edt_AdjustEmail.Size = new System.Drawing.Size(121, 20);
            this.edt_AdjustEmail.TabIndex = 15;
            // 
            // lbl_AdjustPhone
            // 
            this.lbl_AdjustPhone.AutoSize = true;
            this.lbl_AdjustPhone.Location = new System.Drawing.Point(9, 138);
            this.lbl_AdjustPhone.Name = "lbl_AdjustPhone";
            this.lbl_AdjustPhone.Size = new System.Drawing.Size(41, 13);
            this.lbl_AdjustPhone.TabIndex = 16;
            this.lbl_AdjustPhone.Text = "Phone:";
            // 
            // lbl_AdjustEmail
            // 
            this.lbl_AdjustEmail.AutoSize = true;
            this.lbl_AdjustEmail.Location = new System.Drawing.Point(9, 112);
            this.lbl_AdjustEmail.Name = "lbl_AdjustEmail";
            this.lbl_AdjustEmail.Size = new System.Drawing.Size(35, 13);
            this.lbl_AdjustEmail.TabIndex = 14;
            this.lbl_AdjustEmail.Text = "Email:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(140, 161);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 23);
            this.btn_Cancel.TabIndex = 55;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(12, 161);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(115, 23);
            this.btn_OK.TabIndex = 54;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // DialogAdjust
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(266, 194);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.rb_AdjustReverse);
            this.Controls.Add(this.rb_AdjustSimple);
            this.Controls.Add(this.rb_AdjustRegular);
            this.Controls.Add(this.edt_AdjustTrId);
            this.Controls.Add(this.lbl_AdjustTrId);
            this.Controls.Add(this.edt_AdjustPhone);
            this.Controls.Add(this.edt_AdjustEmail);
            this.Controls.Add(this.lbl_AdjustPhone);
            this.Controls.Add(this.lbl_AdjustEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DialogAdjust";
            this.ShowInTaskbar = false;
            this.Text = "Adjust payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_AdjustReverse;
        private System.Windows.Forms.RadioButton rb_AdjustSimple;
        private System.Windows.Forms.RadioButton rb_AdjustRegular;
        private System.Windows.Forms.TextBox edt_AdjustTrId;
        private System.Windows.Forms.Label lbl_AdjustTrId;
        private System.Windows.Forms.MaskedTextBox edt_AdjustPhone;
        private System.Windows.Forms.TextBox edt_AdjustEmail;
        private System.Windows.Forms.Label lbl_AdjustPhone;
        private System.Windows.Forms.Label lbl_AdjustEmail;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}