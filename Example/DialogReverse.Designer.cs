namespace Example
{
    partial class DialogReverse
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
            this.edt_ReverseAmount = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ReverseAmount = new System.Windows.Forms.Label();
            this.edt_ReverseID = new System.Windows.Forms.TextBox();
            this.rb_Cancel = new System.Windows.Forms.RadioButton();
            this.rb_Return = new System.Windows.Forms.RadioButton();
            this.lbl_ReverseID = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edt_ReverseAmount
            // 
            this.edt_ReverseAmount.Location = new System.Drawing.Point(98, 41);
            this.edt_ReverseAmount.Name = "edt_ReverseAmount";
            this.edt_ReverseAmount.PromptChar = ' ';
            this.edt_ReverseAmount.Size = new System.Drawing.Size(163, 20);
            this.edt_ReverseAmount.TabIndex = 9;
            // 
            // lbl_ReverseAmount
            // 
            this.lbl_ReverseAmount.AutoSize = true;
            this.lbl_ReverseAmount.Location = new System.Drawing.Point(12, 44);
            this.lbl_ReverseAmount.Name = "lbl_ReverseAmount";
            this.lbl_ReverseAmount.Size = new System.Drawing.Size(46, 13);
            this.lbl_ReverseAmount.TabIndex = 8;
            this.lbl_ReverseAmount.Text = "Amount:";
            // 
            // edt_ReverseID
            // 
            this.edt_ReverseID.Location = new System.Drawing.Point(98, 15);
            this.edt_ReverseID.Name = "edt_ReverseID";
            this.edt_ReverseID.Size = new System.Drawing.Size(163, 20);
            this.edt_ReverseID.TabIndex = 7;
            // 
            // rb_Cancel
            // 
            this.rb_Cancel.AutoSize = true;
            this.rb_Cancel.Checked = true;
            this.rb_Cancel.Location = new System.Drawing.Point(15, 67);
            this.rb_Cancel.Name = "rb_Cancel";
            this.rb_Cancel.Size = new System.Drawing.Size(58, 17);
            this.rb_Cancel.TabIndex = 10;
            this.rb_Cancel.TabStop = true;
            this.rb_Cancel.Text = "Cancel";
            this.rb_Cancel.UseVisualStyleBackColor = true;
            // 
            // rb_Return
            // 
            this.rb_Return.AutoSize = true;
            this.rb_Return.Location = new System.Drawing.Point(15, 90);
            this.rb_Return.Name = "rb_Return";
            this.rb_Return.Size = new System.Drawing.Size(57, 17);
            this.rb_Return.TabIndex = 11;
            this.rb_Return.Text = "Return";
            this.rb_Return.UseVisualStyleBackColor = true;
            // 
            // lbl_ReverseID
            // 
            this.lbl_ReverseID.AutoSize = true;
            this.lbl_ReverseID.Location = new System.Drawing.Point(12, 18);
            this.lbl_ReverseID.Name = "lbl_ReverseID";
            this.lbl_ReverseID.Size = new System.Drawing.Size(80, 13);
            this.lbl_ReverseID.TabIndex = 6;
            this.lbl_ReverseID.Text = "Transaction ID:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(141, 136);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 23);
            this.btn_Cancel.TabIndex = 57;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(15, 137);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(120, 23);
            this.btn_OK.TabIndex = 56;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // DialogReverse
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(273, 172);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.edt_ReverseAmount);
            this.Controls.Add(this.lbl_ReverseAmount);
            this.Controls.Add(this.edt_ReverseID);
            this.Controls.Add(this.rb_Cancel);
            this.Controls.Add(this.rb_Return);
            this.Controls.Add(this.lbl_ReverseID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DialogReverse";
            this.ShowInTaskbar = false;
            this.Text = "Reverse payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox edt_ReverseAmount;
        private System.Windows.Forms.Label lbl_ReverseAmount;
        private System.Windows.Forms.TextBox edt_ReverseID;
        private System.Windows.Forms.RadioButton rb_Cancel;
        private System.Windows.Forms.RadioButton rb_Return;
        private System.Windows.Forms.Label lbl_ReverseID;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}