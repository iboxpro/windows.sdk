namespace Example
{
    partial class DialogProduct
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
            this.cb_Product = new System.Windows.Forms.ComboBox();
            this.pan_Fields = new System.Windows.Forms.Panel();
            this.tlp_Fields = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Prepare = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pan_Fields.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Product
            // 
            this.cb_Product.FormattingEnabled = true;
            this.cb_Product.Location = new System.Drawing.Point(13, 9);
            this.cb_Product.Name = "cb_Product";
            this.cb_Product.Size = new System.Drawing.Size(265, 21);
            this.cb_Product.TabIndex = 0;
            this.cb_Product.SelectedIndexChanged += new System.EventHandler(this.cb_Product_SelectedIndexChanged);
            // 
            // pan_Fields
            // 
            this.pan_Fields.AutoScroll = true;
            this.pan_Fields.Controls.Add(this.tlp_Fields);
            this.pan_Fields.Location = new System.Drawing.Point(13, 36);
            this.pan_Fields.Name = "pan_Fields";
            this.pan_Fields.Size = new System.Drawing.Size(265, 319);
            this.pan_Fields.TabIndex = 1;
            // 
            // tlp_Fields
            // 
            this.tlp_Fields.AutoSize = true;
            this.tlp_Fields.ColumnCount = 2;
            this.tlp_Fields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_Fields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlp_Fields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Fields.Location = new System.Drawing.Point(0, 0);
            this.tlp_Fields.Name = "tlp_Fields";
            this.tlp_Fields.RowCount = 2;
            this.tlp_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Fields.Size = new System.Drawing.Size(265, 319);
            this.tlp_Fields.TabIndex = 0;
            // 
            // btn_Prepare
            // 
            this.btn_Prepare.Location = new System.Drawing.Point(13, 361);
            this.btn_Prepare.Name = "btn_Prepare";
            this.btn_Prepare.Size = new System.Drawing.Size(265, 23);
            this.btn_Prepare.TabIndex = 2;
            this.btn_Prepare.Text = "Prepare";
            this.btn_Prepare.UseVisualStyleBackColor = true;
            this.btn_Prepare.Click += new System.EventHandler(this.btn_Prepare_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(13, 390);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(265, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(13, 419);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(265, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // DialogProduct
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(290, 451);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Prepare);
            this.Controls.Add(this.pan_Fields);
            this.Controls.Add(this.cb_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select product";
            this.pan_Fields.ResumeLayout(false);
            this.pan_Fields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Product;
        private System.Windows.Forms.Panel pan_Fields;
        private System.Windows.Forms.Button btn_Prepare;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TableLayoutPanel tlp_Fields;
    }
}