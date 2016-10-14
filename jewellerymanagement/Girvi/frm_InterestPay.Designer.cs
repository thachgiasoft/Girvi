namespace JewelleryManagement.Girvi
{
    partial class frm_InterestPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InterestPay));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Save = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AmountPaid = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(284, 32);
            this.pnl_Header.TabIndex = 352;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.Controls.Add(this.bttn_Reset);
            this.pnl_Bottom.Controls.Add(this.bttn_Save);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 131);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(284, 32);
            this.pnl_Bottom.TabIndex = 353;
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(107, 4);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(71, 25);
            this.bttn_Reset.TabIndex = 373;
            this.bttn_Reset.Text = "RESET";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            this.bttn_Reset.Click += new System.EventHandler(this.bttn_Reset_Click);
            // 
            // bttn_Save
            // 
            this.bttn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Save.BackgroundImage")));
            this.bttn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Save.FlatAppearance.BorderSize = 0;
            this.bttn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Save.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Save.ForeColor = System.Drawing.Color.White;
            this.bttn_Save.Location = new System.Drawing.Point(3, 1);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Size = new System.Drawing.Size(79, 29);
            this.bttn_Save.TabIndex = 372;
            this.bttn_Save.Text = "SAVE";
            this.bttn_Save.UseVisualStyleBackColor = true;
            this.bttn_Save.Click += new System.EventHandler(this.bttn_Save_Click);
            // 
            // bttn_Close
            // 
            this.bttn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Close.BackgroundImage")));
            this.bttn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Close.FlatAppearance.BorderSize = 0;
            this.bttn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Close.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Close.ForeColor = System.Drawing.Color.White;
            this.bttn_Close.Location = new System.Drawing.Point(210, 3);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 27);
            this.bttn_Close.TabIndex = 371;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 356;
            this.label2.Text = "Amount Paid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 357;
            this.label1.Text = "Date";
            // 
            // txt_AmountPaid
            // 
            this.txt_AmountPaid.Location = new System.Drawing.Point(160, 83);
            this.txt_AmountPaid.Name = "txt_AmountPaid";
            this.txt_AmountPaid.Size = new System.Drawing.Size(102, 20);
            this.txt_AmountPaid.TabIndex = 355;
            this.txt_AmountPaid.Enter += new System.EventHandler(this.txt_AmountPaid_Enter);
            this.txt_AmountPaid.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AmountPaid_Validating);
            this.txt_AmountPaid.Validated += new System.EventHandler(this.txt_AmountPaid_Validated);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(166, 45);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(96, 20);
            this.dtp_Date.TabIndex = 354;
            this.dtp_Date.Enter += new System.EventHandler(this.txt_AmountPaid_Enter);
            // 
            // frm_InterestPay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AmountPaid);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_InterestPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Pay";
            this.Load += new System.EventHandler(this.frm_InterestPay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_InterestPay_KeyDown);
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button bttn_Save;
        private System.Windows.Forms.Button bttn_Reset;
        public System.Windows.Forms.TextBox txt_AmountPaid;
    }
}