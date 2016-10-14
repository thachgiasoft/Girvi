namespace JewelleryManagement.Reports.Girvi
{
    partial class frm_InterestPaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InterestPaid));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.grp_Dates = new System.Windows.Forms.GroupBox();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.grp_Name = new System.Windows.Forms.GroupBox();
            this.cmb_FullName = new System.Windows.Forms.ComboBox();
            this.bttn_Show = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.dgv_InterestPaid = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirviNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.pnl_Header.SuspendLayout();
            this.pnl_Body.SuspendLayout();
            this.grp_Dates.SuspendLayout();
            this.grp_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InterestPaid)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.SuspendLayout();
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
            this.pnl_Header.Size = new System.Drawing.Size(570, 38);
            this.pnl_Header.TabIndex = 79;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(417, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 360;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(461, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Controls.Add(this.grp_Dates);
            this.pnl_Body.Controls.Add(this.grp_Name);
            this.pnl_Body.Location = new System.Drawing.Point(4, 42);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(566, 105);
            this.pnl_Body.TabIndex = 86;
            // 
            // grp_Dates
            // 
            this.grp_Dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_Dates.Controls.Add(this.lbl_EndDate);
            this.grp_Dates.Controls.Add(this.dtp_EndDate);
            this.grp_Dates.Controls.Add(this.dtp_StartDate);
            this.grp_Dates.Controls.Add(this.lbl_StartDate);
            this.grp_Dates.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Dates.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_Dates.Location = new System.Drawing.Point(301, 4);
            this.grp_Dates.Name = "grp_Dates";
            this.grp_Dates.Size = new System.Drawing.Size(253, 96);
            this.grp_Dates.TabIndex = 88;
            this.grp_Dates.TabStop = false;
            this.grp_Dates.Text = "Dates";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_EndDate.Location = new System.Drawing.Point(16, 59);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(65, 16);
            this.lbl_EndDate.TabIndex = 79;
            this.lbl_EndDate.Text = "End Date";
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
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_StartDate.Location = new System.Drawing.Point(10, 22);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(71, 16);
            this.lbl_StartDate.TabIndex = 79;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // grp_Name
            // 
            this.grp_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_Name.Controls.Add(this.cmb_FullName);
            this.grp_Name.Controls.Add(this.bttn_Show);
            this.grp_Name.Controls.Add(this.lbl_Name);
            this.grp_Name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_Name.Location = new System.Drawing.Point(4, 4);
            this.grp_Name.Name = "grp_Name";
            this.grp_Name.Size = new System.Drawing.Size(282, 96);
            this.grp_Name.TabIndex = 87;
            this.grp_Name.TabStop = false;
            this.grp_Name.Text = "Name";
            // 
            // cmb_FullName
            // 
            this.cmb_FullName.AllowDrop = true;
            this.cmb_FullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_FullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_FullName.DisplayMember = "FullName";
            this.cmb_FullName.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_FullName.FormattingEnabled = true;
            this.cmb_FullName.Location = new System.Drawing.Point(79, 14);
            this.cmb_FullName.Name = "cmb_FullName";
            this.cmb_FullName.Size = new System.Drawing.Size(184, 25);
            this.cmb_FullName.TabIndex = 348;
            this.cmb_FullName.ValueMember = "FullName";
            this.cmb_FullName.Enter += new System.EventHandler(this.cmb_FullName_Enter);
            // 
            // bttn_Show
            // 
            this.bttn_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Show.BackgroundImage")));
            this.bttn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Show.FlatAppearance.BorderSize = 0;
            this.bttn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Show.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Show.ForeColor = System.Drawing.Color.White;
            this.bttn_Show.Location = new System.Drawing.Point(116, 50);
            this.bttn_Show.Name = "bttn_Show";
            this.bttn_Show.Size = new System.Drawing.Size(87, 28);
            this.bttn_Show.TabIndex = 88;
            this.bttn_Show.Text = "Show";
            this.bttn_Show.UseVisualStyleBackColor = true;
            this.bttn_Show.Click += new System.EventHandler(this.bttn_Show_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Name.Location = new System.Drawing.Point(16, 22);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 16);
            this.lbl_Name.TabIndex = 80;
            this.lbl_Name.Text = "Name";
            // 
            // dgv_InterestPaid
            // 
            this.dgv_InterestPaid.AllowUserToAddRows = false;
            this.dgv_InterestPaid.AllowUserToDeleteRows = false;
            this.dgv_InterestPaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InterestPaid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_InterestPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InterestPaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.GirviNo,
            this.Date,
            this.Amount});
            this.dgv_InterestPaid.Location = new System.Drawing.Point(4, 151);
            this.dgv_InterestPaid.Name = "dgv_InterestPaid";
            this.dgv_InterestPaid.ReadOnly = true;
            this.dgv_InterestPaid.Size = new System.Drawing.Size(565, 339);
            this.dgv_InterestPaid.TabIndex = 87;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // GirviNo
            // 
            this.GirviNo.HeaderText = "GirviNo";
            this.GirviNo.Name = "GirviNo";
            this.GirviNo.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 496);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(570, 38);
            this.pnl_Bottom.TabIndex = 101;
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
            this.bttn_Close.Location = new System.Drawing.Point(490, 5);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(255, 235);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 377;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(255, 282);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 376;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            this.rbt_Hindi.CheckedChanged += new System.EventHandler(this.rbt_Hindi_CheckedChanged);
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(255, 258);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 375;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(191, 305);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(176, 45);
            this.pnl_LanguageOther.TabIndex = 378;
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
            // frm_InterestPaid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 534);
            this.Controls.Add(this.pnl_LanguageOther);
            this.Controls.Add(this.rbt_Marathi);
            this.Controls.Add(this.rbt_Hindi);
            this.Controls.Add(this.rbt_English);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.dgv_InterestPaid);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Header);
            this.KeyPreview = true;
            this.Name = "frm_InterestPaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Paid";
            this.Load += new System.EventHandler(this.frm_InterestPaid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_InterestPaid_KeyDown);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Body.ResumeLayout(false);
            this.grp_Dates.ResumeLayout(false);
            this.grp_Dates.PerformLayout();
            this.grp_Name.ResumeLayout(false);
            this.grp_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InterestPaid)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.GroupBox grp_Name;
        private System.Windows.Forms.Button bttn_Show;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.DataGridView dgv_InterestPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.GroupBox grp_Dates;
        public System.Windows.Forms.DateTimePicker dtp_EndDate;
        public System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.ComboBox cmb_FullName;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
    }
}