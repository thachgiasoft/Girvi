namespace JewelleryManagement.Reports.Girvi
{
    partial class frm_CashInHand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CashInHand));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.rbt_PrintFalse = new System.Windows.Forms.RadioButton();
            this.rbt_PrintTrue = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_PrintReport = new System.Windows.Forms.Button();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.dgv_CashDetail = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirviAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirviRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherExpence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherAmountAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeningValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diffrence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.bttn_Opening = new System.Windows.Forms.Button();
            this.bttn_ViewRecord = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Main.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CashDetail)).BeginInit();
            this.pnl_Content.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.pnl_Header);
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_Bottom);
            this.pnl_Main.Controls.Add(this.pnl_Body);
            this.pnl_Main.Controls.Add(this.pnl_Content);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(968, 471);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Controls.Add(this.label1);
            this.pnl_Header.Controls.Add(this.dateTimePicker1);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(968, 42);
            this.pnl_Header.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(797, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 360;
            this.label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(850, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 27);
            this.dateTimePicker1.TabIndex = 359;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.rbt_PrintFalse);
            this.pnl_Buttons.Controls.Add(this.rbt_PrintTrue);
            this.pnl_Buttons.Controls.Add(this.rbt_Marathi);
            this.pnl_Buttons.Controls.Add(this.rbt_Hindi);
            this.pnl_Buttons.Controls.Add(this.rbt_English);
            this.pnl_Buttons.Location = new System.Drawing.Point(490, 46);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(230, 49);
            this.pnl_Buttons.TabIndex = 103;
            this.pnl_Buttons.Visible = false;
            // 
            // rbt_PrintFalse
            // 
            this.rbt_PrintFalse.AutoSize = true;
            this.rbt_PrintFalse.Location = new System.Drawing.Point(99, 25);
            this.rbt_PrintFalse.Name = "rbt_PrintFalse";
            this.rbt_PrintFalse.Size = new System.Drawing.Size(71, 17);
            this.rbt_PrintFalse.TabIndex = 373;
            this.rbt_PrintFalse.TabStop = true;
            this.rbt_PrintFalse.Text = "PrintFalse";
            this.rbt_PrintFalse.UseVisualStyleBackColor = true;
            // 
            // rbt_PrintTrue
            // 
            this.rbt_PrintTrue.AutoSize = true;
            this.rbt_PrintTrue.Location = new System.Drawing.Point(15, 26);
            this.rbt_PrintTrue.Name = "rbt_PrintTrue";
            this.rbt_PrintTrue.Size = new System.Drawing.Size(68, 17);
            this.rbt_PrintTrue.TabIndex = 372;
            this.rbt_PrintTrue.TabStop = true;
            this.rbt_PrintTrue.Text = "PrintTrue";
            this.rbt_PrintTrue.UseVisualStyleBackColor = true;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(168, 4);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 371;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(97, 5);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 364;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            this.rbt_Hindi.CheckedChanged += new System.EventHandler(this.rbt_Hindi_CheckedChanged);
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(15, 8);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 363;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_PrintReport);
            this.pnl_Bottom.Controls.Add(this.dtp_EndDate);
            this.pnl_Bottom.Controls.Add(this.dtp_StartDate);
            this.pnl_Bottom.Controls.Add(this.lbl_EndDate);
            this.pnl_Bottom.Controls.Add(this.lbl_StartDate);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 403);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(968, 68);
            this.pnl_Bottom.TabIndex = 92;
            // 
            // bttn_PrintReport
            // 
            this.bttn_PrintReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_PrintReport.BackgroundImage")));
            this.bttn_PrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_PrintReport.FlatAppearance.BorderSize = 0;
            this.bttn_PrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_PrintReport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_PrintReport.ForeColor = System.Drawing.Color.White;
            this.bttn_PrintReport.Location = new System.Drawing.Point(263, 7);
            this.bttn_PrintReport.Name = "bttn_PrintReport";
            this.bttn_PrintReport.Size = new System.Drawing.Size(71, 56);
            this.bttn_PrintReport.TabIndex = 274;
            this.bttn_PrintReport.Text = " PRINT \r\nREPORT";
            this.bttn_PrintReport.UseVisualStyleBackColor = true;
            this.bttn_PrintReport.Click += new System.EventHandler(this.bttn_PrintReport_Click);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(100, 37);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_EndDate.TabIndex = 232;
            this.dtp_EndDate.Enter += new System.EventHandler(this.dtp_EndDate_Enter);
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(100, 7);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_StartDate.TabIndex = 231;
            this.dtp_StartDate.Enter += new System.EventHandler(this.dtp_StartDate_Enter);
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EndDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndDate.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_EndDate.Location = new System.Drawing.Point(16, 45);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(65, 16);
            this.lbl_EndDate.TabIndex = 229;
            this.lbl_EndDate.Text = "End Date";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartDate.ForeColor = System.Drawing.Color.White;
            this.lbl_StartDate.Location = new System.Drawing.Point(16, 15);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(71, 16);
            this.lbl_StartDate.TabIndex = 230;
            this.lbl_StartDate.Text = "Start Date";
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
            this.bttn_Close.Location = new System.Drawing.Point(873, 20);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // pnl_Body
            // 
            this.pnl_Body.Controls.Add(this.dgv_CashDetail);
            this.pnl_Body.Location = new System.Drawing.Point(3, 96);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(962, 304);
            this.pnl_Body.TabIndex = 83;
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
            this.GirviAdded,
            this.GirviRelease,
            this.Interest,
            this.OtherExpence,
            this.OtherAmountAdded,
            this.OpeningValue,
            this.Diffrence});
            this.dgv_CashDetail.Location = new System.Drawing.Point(3, 4);
            this.dgv_CashDetail.Name = "dgv_CashDetail";
            this.dgv_CashDetail.ReadOnly = true;
            this.dgv_CashDetail.Size = new System.Drawing.Size(954, 295);
            this.dgv_CashDetail.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // GirviAdded
            // 
            this.GirviAdded.HeaderText = "GirviAdded";
            this.GirviAdded.Name = "GirviAdded";
            this.GirviAdded.ReadOnly = true;
            // 
            // GirviRelease
            // 
            this.GirviRelease.HeaderText = "GirviRelease";
            this.GirviRelease.Name = "GirviRelease";
            this.GirviRelease.ReadOnly = true;
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interest";
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            // 
            // OtherExpence
            // 
            this.OtherExpence.HeaderText = "OtherExpence";
            this.OtherExpence.Name = "OtherExpence";
            this.OtherExpence.ReadOnly = true;
            // 
            // OtherAmountAdded
            // 
            this.OtherAmountAdded.HeaderText = "OtherAmountAdded";
            this.OtherAmountAdded.Name = "OtherAmountAdded";
            this.OtherAmountAdded.ReadOnly = true;
            // 
            // OpeningValue
            // 
            this.OpeningValue.HeaderText = "OpeningValue";
            this.OpeningValue.Name = "OpeningValue";
            this.OpeningValue.ReadOnly = true;
            // 
            // Diffrence
            // 
            this.Diffrence.HeaderText = "Diffrence";
            this.Diffrence.Name = "Diffrence";
            this.Diffrence.ReadOnly = true;
            // 
            // pnl_Content
            // 
            this.pnl_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.pnl_Content.Controls.Add(this.pnl_LanguageOther);
            this.pnl_Content.Controls.Add(this.bttn_Opening);
            this.pnl_Content.Controls.Add(this.bttn_ViewRecord);
            this.pnl_Content.Controls.Add(this.lbl_Date);
            this.pnl_Content.Controls.Add(this.dtp_date);
            this.pnl_Content.Location = new System.Drawing.Point(3, 46);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(959, 48);
            this.pnl_Content.TabIndex = 82;
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(723, 9);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(186, 30);
            this.pnl_LanguageOther.TabIndex = 377;
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
            // bttn_Opening
            // 
            this.bttn_Opening.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Opening.BackgroundImage")));
            this.bttn_Opening.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Opening.FlatAppearance.BorderSize = 0;
            this.bttn_Opening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Opening.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Opening.ForeColor = System.Drawing.Color.White;
            this.bttn_Opening.Location = new System.Drawing.Point(389, 9);
            this.bttn_Opening.Name = "bttn_Opening";
            this.bttn_Opening.Size = new System.Drawing.Size(92, 28);
            this.bttn_Opening.TabIndex = 273;
            this.bttn_Opening.Text = "OPENING ";
            this.bttn_Opening.UseVisualStyleBackColor = true;
            this.bttn_Opening.Visible = false;
            // 
            // bttn_ViewRecord
            // 
            this.bttn_ViewRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_ViewRecord.BackgroundImage")));
            this.bttn_ViewRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_ViewRecord.FlatAppearance.BorderSize = 0;
            this.bttn_ViewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_ViewRecord.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_ViewRecord.ForeColor = System.Drawing.Color.White;
            this.bttn_ViewRecord.Location = new System.Drawing.Point(251, 9);
            this.bttn_ViewRecord.Name = "bttn_ViewRecord";
            this.bttn_ViewRecord.Size = new System.Drawing.Size(98, 28);
            this.bttn_ViewRecord.TabIndex = 272;
            this.bttn_ViewRecord.Text = "VIEW RECORD";
            this.bttn_ViewRecord.UseVisualStyleBackColor = true;
            this.bttn_ViewRecord.Click += new System.EventHandler(this.bttn_ViewRecord_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(19, 14);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(37, 16);
            this.lbl_Date.TabIndex = 271;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(73, 9);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(150, 22);
            this.dtp_date.TabIndex = 270;
            this.dtp_date.Enter += new System.EventHandler(this.dtp_date_Enter);
            // 
            // frm_CashInHand
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(968, 471);
            this.Controls.Add(this.pnl_Main);
            this.KeyPreview = true;
            this.Name = "frm_CashInHand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash In Hand";
            this.Load += new System.EventHandler(this.frm_CashInHand_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_CashInHand_KeyDown);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_Buttons.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CashDetail)).EndInit();
            this.pnl_Content.ResumeLayout(false);
            this.pnl_Content.PerformLayout();
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Button bttn_Opening;
        private System.Windows.Forms.Button bttn_ViewRecord;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.DataGridView dgv_CashDetail;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_PrintReport;
        public System.Windows.Forms.DateTimePicker dtp_EndDate;
        public System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnl_Buttons;
        public System.Windows.Forms.RadioButton rbt_PrintFalse;
        public System.Windows.Forms.RadioButton rbt_PrintTrue;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherExpence;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherAmountAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeningValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diffrence;
    }
}