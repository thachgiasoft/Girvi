namespace JewelleryManagement.Reports.Girvi
{
    partial class Frm_BalansheetMonthly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BalansheetMonthly));
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_PrintReport = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.bttn_ViewRecord = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dgv_CashDetail = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartOpening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirviAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGirvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirviRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeningValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGiven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.pnl_PrintRbts = new System.Windows.Forms.Panel();
            this.rbt_PrintTrue = new System.Windows.Forms.RadioButton();
            this.rbt_PrintFalse = new System.Windows.Forms.RadioButton();
            this.pnl_languageRbts = new System.Windows.Forms.Panel();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CashDetail)).BeginInit();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.pnl_PrintRbts.SuspendLayout();
            this.pnl_languageRbts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_PrintReport);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 392);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(878, 38);
            this.pnl_Bottom.TabIndex = 99;
            // 
            // bttn_PrintReport
            // 
            this.bttn_PrintReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_PrintReport.BackgroundImage")));
            this.bttn_PrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_PrintReport.FlatAppearance.BorderSize = 0;
            this.bttn_PrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_PrintReport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_PrintReport.ForeColor = System.Drawing.Color.White;
            this.bttn_PrintReport.Location = new System.Drawing.Point(709, 6);
            this.bttn_PrintReport.Name = "bttn_PrintReport";
            this.bttn_PrintReport.Size = new System.Drawing.Size(89, 23);
            this.bttn_PrintReport.TabIndex = 275;
            this.bttn_PrintReport.Text = " PRINT \r\nREPORT";
            this.bttn_PrintReport.UseVisualStyleBackColor = true;
            this.bttn_PrintReport.Click += new System.EventHandler(this.bttn_PrintReport_Click);
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
            this.bttn_Close.Location = new System.Drawing.Point(804, 3);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Controls.Add(this.bttn_ViewRecord);
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(878, 38);
            this.pnl_Header.TabIndex = 98;
            // 
            // bttn_ViewRecord
            // 
            this.bttn_ViewRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_ViewRecord.BackgroundImage")));
            this.bttn_ViewRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_ViewRecord.FlatAppearance.BorderSize = 0;
            this.bttn_ViewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_ViewRecord.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_ViewRecord.ForeColor = System.Drawing.Color.White;
            this.bttn_ViewRecord.Location = new System.Drawing.Point(8, 5);
            this.bttn_ViewRecord.Name = "bttn_ViewRecord";
            this.bttn_ViewRecord.Size = new System.Drawing.Size(98, 28);
            this.bttn_ViewRecord.TabIndex = 361;
            this.bttn_ViewRecord.Text = "VIEW RECORD";
            this.bttn_ViewRecord.UseVisualStyleBackColor = true;
            this.bttn_ViewRecord.Click += new System.EventHandler(this.bttn_ViewRecord_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(720, 7);
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
            this.dtp_Date.Location = new System.Drawing.Point(767, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // dgv_CashDetail
            // 
            this.dgv_CashDetail.AllowUserToAddRows = false;
            this.dgv_CashDetail.AllowUserToDeleteRows = false;
            this.dgv_CashDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CashDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_CashDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CashDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.StartOpening,
            this.GirviAdded,
            this.TotalGirvi,
            this.GirviRelease,
            this.OpeningValue,
            this.Interest,
            this.AmountAdded,
            this.AmountGiven});
            this.dgv_CashDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CashDetail.Location = new System.Drawing.Point(0, 38);
            this.dgv_CashDetail.Name = "dgv_CashDetail";
            this.dgv_CashDetail.ReadOnly = true;
            this.dgv_CashDetail.Size = new System.Drawing.Size(878, 354);
            this.dgv_CashDetail.TabIndex = 100;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // StartOpening
            // 
            this.StartOpening.HeaderText = "StartOpening";
            this.StartOpening.Name = "StartOpening";
            this.StartOpening.ReadOnly = true;
            // 
            // GirviAdded
            // 
            this.GirviAdded.HeaderText = "GirviAdded";
            this.GirviAdded.Name = "GirviAdded";
            this.GirviAdded.ReadOnly = true;
            // 
            // TotalGirvi
            // 
            this.TotalGirvi.HeaderText = "TotalGirvi";
            this.TotalGirvi.Name = "TotalGirvi";
            this.TotalGirvi.ReadOnly = true;
            // 
            // GirviRelease
            // 
            this.GirviRelease.HeaderText = "GirviRelease";
            this.GirviRelease.Name = "GirviRelease";
            this.GirviRelease.ReadOnly = true;
            // 
            // OpeningValue
            // 
            this.OpeningValue.HeaderText = "OpeningValue";
            this.OpeningValue.Name = "OpeningValue";
            this.OpeningValue.ReadOnly = true;
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interest";
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            // 
            // AmountAdded
            // 
            this.AmountAdded.HeaderText = "AmountAdded";
            this.AmountAdded.Name = "AmountAdded";
            this.AmountAdded.ReadOnly = true;
            // 
            // AmountGiven
            // 
            this.AmountGiven.HeaderText = "AmountGiven";
            this.AmountGiven.Name = "AmountGiven";
            this.AmountGiven.ReadOnly = true;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.pnl_LanguageOther);
            this.pnl_Buttons.Controls.Add(this.pnl_PrintRbts);
            this.pnl_Buttons.Controls.Add(this.pnl_languageRbts);
            this.pnl_Buttons.Location = new System.Drawing.Point(291, 107);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(237, 131);
            this.pnl_Buttons.TabIndex = 372;
            this.pnl_Buttons.Visible = false;
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(23, 78);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(203, 36);
            this.pnl_LanguageOther.TabIndex = 75;
            this.pnl_LanguageOther.Visible = false;
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
            // 
            // rbt_OtherFalse
            // 
            this.rbt_OtherFalse.AutoSize = true;
            this.rbt_OtherFalse.Location = new System.Drawing.Point(95, 7);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = true;
            // 
            // pnl_PrintRbts
            // 
            this.pnl_PrintRbts.Controls.Add(this.rbt_PrintTrue);
            this.pnl_PrintRbts.Controls.Add(this.rbt_PrintFalse);
            this.pnl_PrintRbts.Location = new System.Drawing.Point(23, 40);
            this.pnl_PrintRbts.Name = "pnl_PrintRbts";
            this.pnl_PrintRbts.Size = new System.Drawing.Size(203, 35);
            this.pnl_PrintRbts.TabIndex = 74;
            // 
            // rbt_PrintTrue
            // 
            this.rbt_PrintTrue.AutoSize = true;
            this.rbt_PrintTrue.Location = new System.Drawing.Point(3, 8);
            this.rbt_PrintTrue.Name = "rbt_PrintTrue";
            this.rbt_PrintTrue.Size = new System.Drawing.Size(68, 17);
            this.rbt_PrintTrue.TabIndex = 372;
            this.rbt_PrintTrue.TabStop = true;
            this.rbt_PrintTrue.Text = "PrintTrue";
            this.rbt_PrintTrue.UseVisualStyleBackColor = true;
            // 
            // rbt_PrintFalse
            // 
            this.rbt_PrintFalse.AutoSize = true;
            this.rbt_PrintFalse.Location = new System.Drawing.Point(85, 8);
            this.rbt_PrintFalse.Name = "rbt_PrintFalse";
            this.rbt_PrintFalse.Size = new System.Drawing.Size(71, 17);
            this.rbt_PrintFalse.TabIndex = 373;
            this.rbt_PrintFalse.TabStop = true;
            this.rbt_PrintFalse.Text = "PrintFalse";
            this.rbt_PrintFalse.UseVisualStyleBackColor = true;
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
            this.rbt_English.Location = new System.Drawing.Point(12, 6);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 363;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            this.rbt_English.CheckedChanged += new System.EventHandler(this.rbt_English_CheckedChanged_1);
            this.rbt_English.Click += new System.EventHandler(this.rbt_English_Click);
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
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
            // Frm_BalansheetMonthly
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(878, 430);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.dgv_CashDetail);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.KeyPreview = true;
            this.Name = "Frm_BalansheetMonthly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance sheet Monthly";
            this.Load += new System.EventHandler(this.Frm_BalansheetMonthly_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_BalansheetMonthly_KeyDown);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CashDetail)).EndInit();
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.pnl_PrintRbts.ResumeLayout(false);
            this.pnl_PrintRbts.PerformLayout();
            this.pnl_languageRbts.ResumeLayout(false);
            this.pnl_languageRbts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DataGridView dgv_CashDetail;
        private System.Windows.Forms.Button bttn_ViewRecord;
        private System.Windows.Forms.Button bttn_PrintReport;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        private System.Windows.Forms.Panel pnl_PrintRbts;
        public System.Windows.Forms.RadioButton rbt_PrintTrue;
        public System.Windows.Forms.RadioButton rbt_PrintFalse;
        private System.Windows.Forms.Panel pnl_languageRbts;
        public System.Windows.Forms.RadioButton rbt_English;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartOpening;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGirvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeningValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGiven;

    }
}