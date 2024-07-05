namespace Example
{
    partial class DialogHistory
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pan_History = new System.Windows.Forms.Panel();
            this.edt_RRN = new System.Windows.Forms.TextBox();
            this.rb_RRN = new System.Windows.Forms.RadioButton();
            this.edt_Invoice = new System.Windows.Forms.TextBox();
            this.rb_Invoice = new System.Windows.Forms.RadioButton();
            this.edt_TrID = new System.Windows.Forms.TextBox();
            this.rb_TrID = new System.Windows.Forms.RadioButton();
            this.edt_Page = new System.Windows.Forms.TextBox();
            this.rb_Page = new System.Windows.Forms.RadioButton();
            this.edt_ExtID = new System.Windows.Forms.TextBox();
            this.rb_ExtID = new System.Windows.Forms.RadioButton();
            this.pan_History.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(12, 146);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(150, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(174, 146);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(150, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // pan_History
            // 
            this.pan_History.Controls.Add(this.edt_ExtID);
            this.pan_History.Controls.Add(this.rb_ExtID);
            this.pan_History.Controls.Add(this.edt_RRN);
            this.pan_History.Controls.Add(this.rb_RRN);
            this.pan_History.Controls.Add(this.edt_Invoice);
            this.pan_History.Controls.Add(this.rb_Invoice);
            this.pan_History.Controls.Add(this.edt_TrID);
            this.pan_History.Controls.Add(this.rb_TrID);
            this.pan_History.Controls.Add(this.edt_Page);
            this.pan_History.Controls.Add(this.rb_Page);
            this.pan_History.Location = new System.Drawing.Point(12, 12);
            this.pan_History.Name = "pan_History";
            this.pan_History.Size = new System.Drawing.Size(312, 128);
            this.pan_History.TabIndex = 0;
            // 
            // edt_RRN
            // 
            this.edt_RRN.Location = new System.Drawing.Point(112, 80);
            this.edt_RRN.Name = "edt_RRN";
            this.edt_RRN.Size = new System.Drawing.Size(200, 20);
            this.edt_RRN.TabIndex = 7;
            // 
            // rb_RRN
            // 
            this.rb_RRN.AutoSize = true;
            this.rb_RRN.Location = new System.Drawing.Point(0, 80);
            this.rb_RRN.Name = "rb_RRN";
            this.rb_RRN.Size = new System.Drawing.Size(64, 17);
            this.rb_RRN.TabIndex = 6;
            this.rb_RRN.TabStop = true;
            this.rb_RRN.Text = "By RRN";
            this.rb_RRN.UseVisualStyleBackColor = true;
            // 
            // edt_Invoice
            // 
            this.edt_Invoice.Location = new System.Drawing.Point(112, 54);
            this.edt_Invoice.Name = "edt_Invoice";
            this.edt_Invoice.Size = new System.Drawing.Size(200, 20);
            this.edt_Invoice.TabIndex = 5;
            // 
            // rb_Invoice
            // 
            this.rb_Invoice.AutoSize = true;
            this.rb_Invoice.Location = new System.Drawing.Point(0, 54);
            this.rb_Invoice.Name = "rb_Invoice";
            this.rb_Invoice.Size = new System.Drawing.Size(97, 17);
            this.rb_Invoice.TabIndex = 4;
            this.rb_Invoice.TabStop = true;
            this.rb_Invoice.Text = "By invoice num";
            this.rb_Invoice.UseVisualStyleBackColor = true;
            // 
            // edt_TrID
            // 
            this.edt_TrID.Location = new System.Drawing.Point(112, 28);
            this.edt_TrID.Name = "edt_TrID";
            this.edt_TrID.Size = new System.Drawing.Size(200, 20);
            this.edt_TrID.TabIndex = 3;
            // 
            // rb_TrID
            // 
            this.rb_TrID.AutoSize = true;
            this.rb_TrID.Location = new System.Drawing.Point(0, 28);
            this.rb_TrID.Name = "rb_TrID";
            this.rb_TrID.Size = new System.Drawing.Size(106, 17);
            this.rb_TrID.TabIndex = 2;
            this.rb_TrID.TabStop = true;
            this.rb_TrID.Text = "By transaction ID";
            this.rb_TrID.UseVisualStyleBackColor = true;
            // 
            // edt_Page
            // 
            this.edt_Page.Location = new System.Drawing.Point(112, 2);
            this.edt_Page.Name = "edt_Page";
            this.edt_Page.Size = new System.Drawing.Size(200, 20);
            this.edt_Page.TabIndex = 1;
            this.edt_Page.Text = "1";
            // 
            // rb_Page
            // 
            this.rb_Page.AutoSize = true;
            this.rb_Page.Location = new System.Drawing.Point(0, 2);
            this.rb_Page.Name = "rb_Page";
            this.rb_Page.Size = new System.Drawing.Size(100, 17);
            this.rb_Page.TabIndex = 0;
            this.rb_Page.TabStop = true;
            this.rb_Page.Text = "All by page num";
            this.rb_Page.UseVisualStyleBackColor = true;
            // 
            // edt_ExtID
            // 
            this.edt_ExtID.Location = new System.Drawing.Point(112, 106);
            this.edt_ExtID.Name = "edt_ExtID";
            this.edt_ExtID.Size = new System.Drawing.Size(200, 20);
            this.edt_ExtID.TabIndex = 9;
            // 
            // rb_ExtID
            // 
            this.rb_ExtID.AutoSize = true;
            this.rb_ExtID.Location = new System.Drawing.Point(0, 106);
            this.rb_ExtID.Name = "rb_ExtID";
            this.rb_ExtID.Size = new System.Drawing.Size(66, 17);
            this.rb_ExtID.TabIndex = 8;
            this.rb_ExtID.TabStop = true;
            this.rb_ExtID.Text = "By ExtID";
            this.rb_ExtID.UseVisualStyleBackColor = true;
            // 
            // DialogHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 174);
            this.ControlBox = false;
            this.Controls.Add(this.pan_History);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DialogHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Get history";
            this.pan_History.ResumeLayout(false);
            this.pan_History.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel pan_History;
        private System.Windows.Forms.TextBox edt_RRN;
        private System.Windows.Forms.RadioButton rb_RRN;
        private System.Windows.Forms.TextBox edt_Invoice;
        private System.Windows.Forms.RadioButton rb_Invoice;
        private System.Windows.Forms.TextBox edt_TrID;
        private System.Windows.Forms.RadioButton rb_TrID;
        private System.Windows.Forms.TextBox edt_Page;
        private System.Windows.Forms.RadioButton rb_Page;
        private System.Windows.Forms.TextBox edt_ExtID;
        private System.Windows.Forms.RadioButton rb_ExtID;
    }
}