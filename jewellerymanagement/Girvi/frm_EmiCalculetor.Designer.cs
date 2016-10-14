namespace JewelleryManagement.Girvi
{
    partial class frm_EmiCalculetor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmiCalculetor));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.pnl_languageRbts = new System.Windows.Forms.Panel();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.txt_DepositDays = new System.Windows.Forms.TextBox();
            this.lbl_DepositDays = new System.Windows.Forms.Label();
            this.txt_InterestInPer = new System.Windows.Forms.TextBox();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.lbl_LoanAmount = new System.Windows.Forms.Label();
            this.lbl_InterestInPer = new System.Windows.Forms.Label();
            this.txt_Loanamount = new System.Windows.Forms.TextBox();
            this.lbl_Interest = new System.Windows.Forms.Label();
            this.txt_Interset = new System.Windows.Forms.TextBox();
            this.lbl_TotalAmount = new System.Windows.Forms.Label();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.pnl_Header.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_languageRbts.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Controls.Add(this.pnl_Buttons);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(397, 38);
            this.pnl_Header.TabIndex = 272;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Buttons.Controls.Add(this.pnl_languageRbts);
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 7);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(267, 47);
            this.pnl_Buttons.TabIndex = 372;
            this.pnl_Buttons.Visible = false;
            // 
            // pnl_languageRbts
            // 
            this.pnl_languageRbts.Controls.Add(this.rbt_English);
            this.pnl_languageRbts.Controls.Add(this.rbt_Hindi);
            this.pnl_languageRbts.Controls.Add(this.rbt_Marathi);
            this.pnl_languageRbts.Location = new System.Drawing.Point(23, 9);
            this.pnl_languageRbts.Name = "pnl_languageRbts";
            this.pnl_languageRbts.Size = new System.Drawing.Size(203, 26);
            this.pnl_languageRbts.TabIndex = 73;
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.ForeColor = System.Drawing.Color.White;
            this.rbt_English.Location = new System.Drawing.Point(12, 6);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 363;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.ForeColor = System.Drawing.Color.White;
            this.rbt_Hindi.Location = new System.Drawing.Point(77, 6);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 364;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.ForeColor = System.Drawing.Color.White;
            this.rbt_Marathi.Location = new System.Drawing.Point(132, 6);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 371;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Reset);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 361);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(397, 38);
            this.pnl_Bottom.TabIndex = 273;
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(99, 5);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(71, 28);
            this.bttn_Reset.TabIndex = 231;
            this.bttn_Reset.Text = "RESET";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            this.bttn_Reset.Click += new System.EventHandler(this.bttn_Reset_Click);
            // 
            // bttn_Close
            // 
            this.bttn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Close.BackgroundImage")));
            this.bttn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Close.FlatAppearance.BorderSize = 0;
            this.bttn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Close.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Close.ForeColor = System.Drawing.Color.White;
            this.bttn_Close.Location = new System.Drawing.Point(187, 5);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 230;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(121, 86);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(240, 27);
            this.dtp_EndDate.TabIndex = 277;
            this.dtp_EndDate.ValueChanged += new System.EventHandler(this.dtp_EndDate_ValueChanged);
            this.dtp_EndDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_EndDate_KeyDown);
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(121, 49);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(240, 27);
            this.dtp_StartDate.TabIndex = 276;
            this.dtp_StartDate.ValueChanged += new System.EventHandler(this.dtp_StartDate_ValueChanged);
            this.dtp_StartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_StartDate_KeyDown);
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_EndDate.Location = new System.Drawing.Point(12, 94);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(65, 16);
            this.lbl_EndDate.TabIndex = 274;
            this.lbl_EndDate.Text = "End Date";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_StartDate.Location = new System.Drawing.Point(12, 57);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(71, 16);
            this.lbl_StartDate.TabIndex = 275;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // txt_DepositDays
            // 
            this.txt_DepositDays.BackColor = System.Drawing.Color.White;
            this.txt_DepositDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DepositDays.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DepositDays.Location = new System.Drawing.Point(121, 129);
            this.txt_DepositDays.Name = "txt_DepositDays";
            this.txt_DepositDays.ReadOnly = true;
            this.txt_DepositDays.Size = new System.Drawing.Size(240, 27);
            this.txt_DepositDays.TabIndex = 357;
            this.txt_DepositDays.TextChanged += new System.EventHandler(this.txt_DepositDays_TextChanged);
            this.txt_DepositDays.Enter += new System.EventHandler(this.txt_DepositDays_Enter);
            this.txt_DepositDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DepositDays_KeyDown);
            this.txt_DepositDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DepositDays_KeyPress);
            // 
            // lbl_DepositDays
            // 
            this.lbl_DepositDays.AutoSize = true;
            this.lbl_DepositDays.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DepositDays.ForeColor = System.Drawing.Color.Black;
            this.lbl_DepositDays.Location = new System.Drawing.Point(12, 133);
            this.lbl_DepositDays.Name = "lbl_DepositDays";
            this.lbl_DepositDays.Size = new System.Drawing.Size(89, 16);
            this.lbl_DepositDays.TabIndex = 358;
            this.lbl_DepositDays.Text = "Deposit Days";
            this.lbl_DepositDays.Click += new System.EventHandler(this.lbl_DepositDays_Click);
            // 
            // txt_InterestInPer
            // 
            this.txt_InterestInPer.BackColor = System.Drawing.Color.White;
            this.txt_InterestInPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InterestInPer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InterestInPer.Location = new System.Drawing.Point(121, 169);
            this.txt_InterestInPer.Name = "txt_InterestInPer";
            this.txt_InterestInPer.Size = new System.Drawing.Size(182, 27);
            this.txt_InterestInPer.TabIndex = 359;
            this.txt_InterestInPer.TextChanged += new System.EventHandler(this.txt_InterestInPer_TextChanged);
            this.txt_InterestInPer.Enter += new System.EventHandler(this.txt_InterestInPer_Enter);
            this.txt_InterestInPer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_InterestInPer_KeyDown);
            this.txt_InterestInPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InterestInPer_KeyPress);
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Percent.ForeColor = System.Drawing.Color.Black;
            this.lbl_Percent.Location = new System.Drawing.Point(182, 173);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(20, 19);
            this.lbl_Percent.TabIndex = 363;
            this.lbl_Percent.Text = "%";
            // 
            // lbl_LoanAmount
            // 
            this.lbl_LoanAmount.AutoSize = true;
            this.lbl_LoanAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoanAmount.ForeColor = System.Drawing.Color.Black;
            this.lbl_LoanAmount.Location = new System.Drawing.Point(12, 223);
            this.lbl_LoanAmount.Name = "lbl_LoanAmount";
            this.lbl_LoanAmount.Size = new System.Drawing.Size(97, 16);
            this.lbl_LoanAmount.TabIndex = 361;
            this.lbl_LoanAmount.Text = "Loan Amount ";
            // 
            // lbl_InterestInPer
            // 
            this.lbl_InterestInPer.AutoSize = true;
            this.lbl_InterestInPer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InterestInPer.ForeColor = System.Drawing.Color.Black;
            this.lbl_InterestInPer.Location = new System.Drawing.Point(12, 174);
            this.lbl_InterestInPer.Name = "lbl_InterestInPer";
            this.lbl_InterestInPer.Size = new System.Drawing.Size(85, 16);
            this.lbl_InterestInPer.TabIndex = 362;
            this.lbl_InterestInPer.Text = "Interest in %";
            // 
            // txt_Loanamount
            // 
            this.txt_Loanamount.BackColor = System.Drawing.Color.White;
            this.txt_Loanamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Loanamount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Loanamount.Location = new System.Drawing.Point(121, 219);
            this.txt_Loanamount.Name = "txt_Loanamount";
            this.txt_Loanamount.Size = new System.Drawing.Size(229, 27);
            this.txt_Loanamount.TabIndex = 360;
            this.txt_Loanamount.TextChanged += new System.EventHandler(this.txt_Loanamount_TextChanged);
            this.txt_Loanamount.Enter += new System.EventHandler(this.txt_Loanamount_Enter);
            this.txt_Loanamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Loanamount_KeyDown);
            this.txt_Loanamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Loanamount_KeyPress);
            // 
            // lbl_Interest
            // 
            this.lbl_Interest.AutoSize = true;
            this.lbl_Interest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Interest.ForeColor = System.Drawing.Color.Black;
            this.lbl_Interest.Location = new System.Drawing.Point(12, 264);
            this.lbl_Interest.Name = "lbl_Interest";
            this.lbl_Interest.Size = new System.Drawing.Size(55, 16);
            this.lbl_Interest.TabIndex = 365;
            this.lbl_Interest.Text = "Interset";
            // 
            // txt_Interset
            // 
            this.txt_Interset.BackColor = System.Drawing.Color.White;
            this.txt_Interset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Interset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Interset.Location = new System.Drawing.Point(121, 260);
            this.txt_Interset.Name = "txt_Interset";
            this.txt_Interset.ReadOnly = true;
            this.txt_Interset.Size = new System.Drawing.Size(229, 27);
            this.txt_Interset.TabIndex = 364;
            this.txt_Interset.Enter += new System.EventHandler(this.txt_Interset_Enter);
            this.txt_Interset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Interset_KeyDown);
            this.txt_Interset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Interset_KeyPress);
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.AutoSize = true;
            this.lbl_TotalAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lbl_TotalAmount.Location = new System.Drawing.Point(12, 314);
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Size = new System.Drawing.Size(96, 16);
            this.lbl_TotalAmount.TabIndex = 367;
            this.lbl_TotalAmount.Text = "Total Amount ";
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.BackColor = System.Drawing.Color.White;
            this.txt_TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalAmount.Location = new System.Drawing.Point(121, 310);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.ReadOnly = true;
            this.txt_TotalAmount.Size = new System.Drawing.Size(229, 27);
            this.txt_TotalAmount.TabIndex = 366;
            this.txt_TotalAmount.Enter += new System.EventHandler(this.txt_TotalAmount_Enter);
            this.txt_TotalAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TotalAmount_KeyDown);
            this.txt_TotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TotalAmount_KeyPress);
            // 
            // frm_EmiCalculetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 399);
            this.Controls.Add(this.lbl_TotalAmount);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.lbl_Interest);
            this.Controls.Add(this.txt_Interset);
            this.Controls.Add(this.txt_InterestInPer);
            this.Controls.Add(this.lbl_Percent);
            this.Controls.Add(this.lbl_LoanAmount);
            this.Controls.Add(this.lbl_InterestInPer);
            this.Controls.Add(this.txt_Loanamount);
            this.Controls.Add(this.txt_DepositDays);
            this.Controls.Add(this.lbl_DepositDays);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_Bottom);
            this.KeyPreview = true;
            this.Name = "frm_EmiCalculetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMI Calculator";
            this.Load += new System.EventHandler(this.frm_EmiCalculetor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_EmiCalculetor_KeyDown);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_languageRbts.ResumeLayout(false);
            this.pnl_languageRbts.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        public System.Windows.Forms.DateTimePicker dtp_EndDate;
        public System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.TextBox txt_DepositDays;
        private System.Windows.Forms.Label lbl_DepositDays;
        private System.Windows.Forms.TextBox txt_InterestInPer;
        private System.Windows.Forms.Label lbl_Percent;
        private System.Windows.Forms.Label lbl_LoanAmount;
        private System.Windows.Forms.Label lbl_InterestInPer;
        private System.Windows.Forms.TextBox txt_Loanamount;
        private System.Windows.Forms.Label lbl_Interest;
        private System.Windows.Forms.TextBox txt_Interset;
        private System.Windows.Forms.Label lbl_TotalAmount;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Panel pnl_languageRbts;
        public System.Windows.Forms.RadioButton rbt_English;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        private System.Windows.Forms.Button bttn_Reset;
    }
}