namespace JewelleryManagement.Reports.Girvi
{
    partial class frm_ForwordGirvi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ForwordGirvi));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.dgv_GirviDetail = new System.Windows.Forms.DataGridView();
            this.GirviNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhatawaniName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfForword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForwordTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForwordContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forwardamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.bttn_ForwordReport = new System.Windows.Forms.Button();
            this.grp_Dates = new System.Windows.Forms.GroupBox();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Main.SuspendLayout();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviDetail)).BeginInit();
            this.pnl_Content.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.grp_Dates.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Main.Controls.Add(this.pnl_Body);
            this.pnl_Main.Controls.Add(this.pnl_Content);
            this.pnl_Main.Controls.Add(this.pnl_Bottom);
            this.pnl_Main.Controls.Add(this.pnl_Header);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1077, 457);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Controls.Add(this.dgv_GirviDetail);
            this.pnl_Body.Location = new System.Drawing.Point(3, 131);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1070, 286);
            this.pnl_Body.TabIndex = 102;
            // 
            // dgv_GirviDetail
            // 
            this.dgv_GirviDetail.AllowUserToAddRows = false;
            this.dgv_GirviDetail.AllowUserToDeleteRows = false;
            this.dgv_GirviDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GirviDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_GirviDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GirviDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GirviNo,
            this.DateOfDeposit,
            this.KhatawaniName,
            this.ContactNo,
            this.Address,
            this.DateOfForword,
            this.ForwordTo,
            this.ForwordContactNo,
            this.forwardamount,
            this.InterestRate,
            this.Days,
            this.Interest,
            this.TotalAmount});
            this.dgv_GirviDetail.Location = new System.Drawing.Point(3, 2);
            this.dgv_GirviDetail.Name = "dgv_GirviDetail";
            this.dgv_GirviDetail.ReadOnly = true;
            this.dgv_GirviDetail.Size = new System.Drawing.Size(1064, 284);
            this.dgv_GirviDetail.TabIndex = 91;
            // 
            // GirviNo
            // 
            this.GirviNo.HeaderText = "GirviNo";
            this.GirviNo.Name = "GirviNo";
            this.GirviNo.ReadOnly = true;
            // 
            // DateOfDeposit
            // 
            this.DateOfDeposit.HeaderText = "DateOfDeposit";
            this.DateOfDeposit.Name = "DateOfDeposit";
            this.DateOfDeposit.ReadOnly = true;
            // 
            // KhatawaniName
            // 
            this.KhatawaniName.HeaderText = "Name";
            this.KhatawaniName.Name = "KhatawaniName";
            this.KhatawaniName.ReadOnly = true;
            // 
            // ContactNo
            // 
            this.ContactNo.HeaderText = "ContactNo";
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // DateOfForword
            // 
            this.DateOfForword.HeaderText = "DateOfForword";
            this.DateOfForword.Name = "DateOfForword";
            this.DateOfForword.ReadOnly = true;
            // 
            // ForwordTo
            // 
            this.ForwordTo.HeaderText = "ForwordTo";
            this.ForwordTo.Name = "ForwordTo";
            this.ForwordTo.ReadOnly = true;
            // 
            // ForwordContactNo
            // 
            this.ForwordContactNo.HeaderText = "FContactNo";
            this.ForwordContactNo.Name = "ForwordContactNo";
            this.ForwordContactNo.ReadOnly = true;
            // 
            // forwardamount
            // 
            this.forwardamount.HeaderText = "FAmount";
            this.forwardamount.Name = "forwardamount";
            this.forwardamount.ReadOnly = true;
            // 
            // InterestRate
            // 
            this.InterestRate.HeaderText = "InterestRate";
            this.InterestRate.Name = "InterestRate";
            this.InterestRate.ReadOnly = true;
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interest";
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // pnl_Content
            // 
            this.pnl_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.pnl_Content.Controls.Add(this.bttn_Print);
            this.pnl_Content.Controls.Add(this.pnl_LanguageOther);
            this.pnl_Content.Controls.Add(this.rbt_Marathi);
            this.pnl_Content.Controls.Add(this.rbt_Hindi);
            this.pnl_Content.Controls.Add(this.rbt_English);
            this.pnl_Content.Controls.Add(this.bttn_ForwordReport);
            this.pnl_Content.Controls.Add(this.grp_Dates);
            this.pnl_Content.Location = new System.Drawing.Point(2, 40);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(1071, 89);
            this.pnl_Content.TabIndex = 101;
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Print.BackgroundImage")));
            this.bttn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Print.FlatAppearance.BorderSize = 0;
            this.bttn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Print.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.ForeColor = System.Drawing.Color.White;
            this.bttn_Print.Location = new System.Drawing.Point(267, 54);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(68, 28);
            this.bttn_Print.TabIndex = 381;
            this.bttn_Print.Text = "PRINT";
            this.bttn_Print.UseVisualStyleBackColor = true;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(648, 26);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(176, 45);
            this.pnl_LanguageOther.TabIndex = 380;
            this.pnl_LanguageOther.Visible = false;
            this.pnl_LanguageOther.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_LanguageOther_Paint);
            // 
            // rbt_OtherTrue
            // 
            this.rbt_OtherTrue.AutoSize = true;
            this.rbt_OtherTrue.Location = new System.Drawing.Point(16, 7);
            this.rbt_OtherTrue.Name = "rbt_OtherTrue";
            this.rbt_OtherTrue.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherTrue.TabIndex = 372;
            this.rbt_OtherTrue.Text = "Other True";
            this.rbt_OtherTrue.UseVisualStyleBackColor = true;
            this.rbt_OtherTrue.CheckedChanged += new System.EventHandler(this.rbt_OtherTrue_CheckedChanged);
            // 
            // rbt_OtherFalse
            // 
            this.rbt_OtherFalse.AutoSize = true;
            this.rbt_OtherFalse.Location = new System.Drawing.Point(98, 7);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = true;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(582, 37);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 374;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(517, 34);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 373;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            this.rbt_Hindi.CheckedChanged += new System.EventHandler(this.rbt_Hindi_CheckedChanged);
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(429, 37);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 372;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // bttn_ForwordReport
            // 
            this.bttn_ForwordReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_ForwordReport.BackgroundImage")));
            this.bttn_ForwordReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_ForwordReport.FlatAppearance.BorderSize = 0;
            this.bttn_ForwordReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_ForwordReport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_ForwordReport.ForeColor = System.Drawing.Color.White;
            this.bttn_ForwordReport.Location = new System.Drawing.Point(267, 17);
            this.bttn_ForwordReport.Name = "bttn_ForwordReport";
            this.bttn_ForwordReport.Size = new System.Drawing.Size(68, 28);
            this.bttn_ForwordReport.TabIndex = 36;
            this.bttn_ForwordReport.Text = "View";
            this.bttn_ForwordReport.UseVisualStyleBackColor = true;
            this.bttn_ForwordReport.Click += new System.EventHandler(this.bttn_ForwordReport_Click);
            // 
            // grp_Dates
            // 
            this.grp_Dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_Dates.Controls.Add(this.dtp_EndDate);
            this.grp_Dates.Controls.Add(this.dtp_StartDate);
            this.grp_Dates.Controls.Add(this.lbl_EndDate);
            this.grp_Dates.Controls.Add(this.lbl_StartDate);
            this.grp_Dates.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Dates.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_Dates.Location = new System.Drawing.Point(4, 4);
            this.grp_Dates.Name = "grp_Dates";
            this.grp_Dates.Size = new System.Drawing.Size(257, 82);
            this.grp_Dates.TabIndex = 82;
            this.grp_Dates.TabStop = false;
            this.grp_Dates.Text = "Dates";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(99, 51);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_EndDate.TabIndex = 81;
            this.dtp_EndDate.Enter += new System.EventHandler(this.dtp_EndDate_Enter);
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(99, 14);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_StartDate.TabIndex = 80;
            this.dtp_StartDate.Enter += new System.EventHandler(this.dtp_StartDate_Enter);
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_EndDate.Location = new System.Drawing.Point(16, 56);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(65, 16);
            this.lbl_EndDate.TabIndex = 79;
            this.lbl_EndDate.Text = "End Date";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_StartDate.Location = new System.Drawing.Point(16, 22);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(71, 16);
            this.lbl_StartDate.TabIndex = 79;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 419);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(1077, 38);
            this.pnl_Bottom.TabIndex = 100;
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
            this.bttn_Close.Location = new System.Drawing.Point(983, 5);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1077, 38);
            this.pnl_Header.TabIndex = 83;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(926, 7);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 360;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(970, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // frm_ForwordGirvi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1077, 457);
            this.Controls.Add(this.pnl_Main);
            this.KeyPreview = true;
            this.Name = "frm_ForwordGirvi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forword Girvi";
            this.Load += new System.EventHandler(this.frm_ForwordGirvi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ForwordGirvi_KeyDown);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviDetail)).EndInit();
            this.pnl_Content.ResumeLayout(false);
            this.pnl_Content.PerformLayout();
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.grp_Dates.ResumeLayout(false);
            this.grp_Dates.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Button bttn_ForwordReport;
        private System.Windows.Forms.GroupBox grp_Dates;
        public System.Windows.Forms.DateTimePicker dtp_EndDate;
        public System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.DataGridView dgv_GirviDetail;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhatawaniName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfForword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForwordTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForwordContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn forwardamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    }
}