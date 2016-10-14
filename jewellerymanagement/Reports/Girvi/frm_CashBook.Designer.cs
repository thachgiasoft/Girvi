namespace JewelleryManagement.Reports.Girvi
{
    partial class frm_CashBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CashBook));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.dgv_GirviRelease = new System.Windows.Forms.DataGridView();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirviNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhatawaniPan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousBalanceRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_GirviAdded = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirviNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhatawaniPan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Released = new System.Windows.Forms.Panel();
            this.lbl_GirviRelease = new System.Windows.Forms.Label();
            this.pnl_Added = new System.Windows.Forms.Panel();
            this.lbl_GirviAdded = new System.Windows.Forms.Label();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.grp_Dates = new System.Windows.Forms.GroupBox();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.grp_Buttons = new System.Windows.Forms.GroupBox();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.bttn_View = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Main.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviRelease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviAdded)).BeginInit();
            this.pnl_Released.SuspendLayout();
            this.pnl_Added.SuspendLayout();
            this.pnl_Content.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.grp_Dates.SuspendLayout();
            this.grp_Buttons.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_Main.Controls.Add(this.pnl_Bottom);
            this.pnl_Main.Controls.Add(this.pnl_Body);
            this.pnl_Main.Controls.Add(this.pnl_Content);
            this.pnl_Main.Controls.Add(this.pnl_Header);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1234, 484);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 446);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(1234, 38);
            this.pnl_Bottom.TabIndex = 97;
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
            this.bttn_Close.Location = new System.Drawing.Point(1146, 5);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // pnl_Body
            // 
            this.pnl_Body.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Body.Controls.Add(this.dgv_GirviRelease);
            this.pnl_Body.Controls.Add(this.dgv_GirviAdded);
            this.pnl_Body.Controls.Add(this.pnl_Released);
            this.pnl_Body.Controls.Add(this.pnl_Added);
            this.pnl_Body.Location = new System.Drawing.Point(3, 132);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1228, 311);
            this.pnl_Body.TabIndex = 96;
            // 
            // dgv_GirviRelease
            // 
            this.dgv_GirviRelease.AllowUserToAddRows = false;
            this.dgv_GirviRelease.AllowUserToDeleteRows = false;
            this.dgv_GirviRelease.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GirviRelease.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_GirviRelease.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_GirviRelease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GirviRelease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date1,
            this.Name1,
            this.GirviNo1,
            this.KhatawaniPan1,
            this.Amount1,
            this.Interest,
            this.PreviousBalanceRelease});
            this.dgv_GirviRelease.Location = new System.Drawing.Point(598, 39);
            this.dgv_GirviRelease.Name = "dgv_GirviRelease";
            this.dgv_GirviRelease.ReadOnly = true;
            this.dgv_GirviRelease.Size = new System.Drawing.Size(630, 269);
            this.dgv_GirviRelease.TabIndex = 92;
            // 
            // Date1
            // 
            this.Date1.HeaderText = "Date";
            this.Date1.Name = "Date1";
            this.Date1.ReadOnly = true;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // GirviNo1
            // 
            this.GirviNo1.HeaderText = "GirviNo";
            this.GirviNo1.Name = "GirviNo1";
            this.GirviNo1.ReadOnly = true;
            // 
            // KhatawaniPan1
            // 
            this.KhatawaniPan1.HeaderText = "KhatawaniPan";
            this.KhatawaniPan1.Name = "KhatawaniPan1";
            this.KhatawaniPan1.ReadOnly = true;
            // 
            // Amount1
            // 
            this.Amount1.HeaderText = "Amount";
            this.Amount1.Name = "Amount1";
            this.Amount1.ReadOnly = true;
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interest";
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            // 
            // PreviousBalanceRelease
            // 
            this.PreviousBalanceRelease.HeaderText = "PreviousBalance";
            this.PreviousBalanceRelease.Name = "PreviousBalanceRelease";
            this.PreviousBalanceRelease.ReadOnly = true;
            // 
            // dgv_GirviAdded
            // 
            this.dgv_GirviAdded.AllowUserToAddRows = false;
            this.dgv_GirviAdded.AllowUserToDeleteRows = false;
            this.dgv_GirviAdded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GirviAdded.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_GirviAdded.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_GirviAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GirviAdded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Name,
            this.GirviNo,
            this.KhatawaniPan,
            this.Amount});
            this.dgv_GirviAdded.Location = new System.Drawing.Point(3, 39);
            this.dgv_GirviAdded.Name = "dgv_GirviAdded";
            this.dgv_GirviAdded.ReadOnly = true;
            this.dgv_GirviAdded.Size = new System.Drawing.Size(590, 269);
            this.dgv_GirviAdded.TabIndex = 89;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // GirviNo
            // 
            this.GirviNo.HeaderText = "GirviNo";
            this.GirviNo.Name = "GirviNo";
            this.GirviNo.ReadOnly = true;
            // 
            // KhatawaniPan
            // 
            this.KhatawaniPan.HeaderText = "KhatavaniPan";
            this.KhatawaniPan.Name = "KhatawaniPan";
            this.KhatawaniPan.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // pnl_Released
            // 
            this.pnl_Released.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Released.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Released.Controls.Add(this.lbl_GirviRelease);
            this.pnl_Released.Location = new System.Drawing.Point(598, 3);
            this.pnl_Released.Name = "pnl_Released";
            this.pnl_Released.Size = new System.Drawing.Size(630, 33);
            this.pnl_Released.TabIndex = 87;
            // 
            // lbl_GirviRelease
            // 
            this.lbl_GirviRelease.AutoSize = true;
            this.lbl_GirviRelease.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GirviRelease.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GirviRelease.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_GirviRelease.Location = new System.Drawing.Point(232, 11);
            this.lbl_GirviRelease.Name = "lbl_GirviRelease";
            this.lbl_GirviRelease.Size = new System.Drawing.Size(93, 16);
            this.lbl_GirviRelease.TabIndex = 0;
            this.lbl_GirviRelease.Text = "Girvi Release";
            // 
            // pnl_Added
            // 
            this.pnl_Added.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Added.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Added.Controls.Add(this.lbl_GirviAdded);
            this.pnl_Added.Location = new System.Drawing.Point(3, 4);
            this.pnl_Added.Name = "pnl_Added";
            this.pnl_Added.Size = new System.Drawing.Size(590, 33);
            this.pnl_Added.TabIndex = 91;
            // 
            // lbl_GirviAdded
            // 
            this.lbl_GirviAdded.AutoSize = true;
            this.lbl_GirviAdded.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GirviAdded.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GirviAdded.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_GirviAdded.Location = new System.Drawing.Point(259, 11);
            this.lbl_GirviAdded.Name = "lbl_GirviAdded";
            this.lbl_GirviAdded.Size = new System.Drawing.Size(83, 16);
            this.lbl_GirviAdded.TabIndex = 0;
            this.lbl_GirviAdded.Text = "Girvi Added";
            // 
            // pnl_Content
            // 
            this.pnl_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.pnl_Content.Controls.Add(this.pnl_LanguageOther);
            this.pnl_Content.Controls.Add(this.rbt_Marathi);
            this.pnl_Content.Controls.Add(this.rbt_Hindi);
            this.pnl_Content.Controls.Add(this.rbt_English);
            this.pnl_Content.Controls.Add(this.grp_Dates);
            this.pnl_Content.Controls.Add(this.grp_Buttons);
            this.pnl_Content.Location = new System.Drawing.Point(3, 43);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(1228, 87);
            this.pnl_Content.TabIndex = 95;
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(762, 25);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(200, 36);
            this.pnl_LanguageOther.TabIndex = 375;
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
            this.rbt_OtherFalse.Location = new System.Drawing.Point(95, 7);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = true;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(1154, 33);
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
            this.rbt_Hindi.Location = new System.Drawing.Point(1087, 33);
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
            this.rbt_English.Location = new System.Drawing.Point(1003, 33);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 372;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // grp_Dates
            // 
            this.grp_Dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_Dates.Controls.Add(this.dtp_EndDate);
            this.grp_Dates.Controls.Add(this.dtp_StartDate);
            this.grp_Dates.Controls.Add(this.lbl_EndDate);
            this.grp_Dates.Controls.Add(this.lbl_StartDate);
            this.grp_Dates.Font = new System.Drawing.Font("Mangal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Dates.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_Dates.Location = new System.Drawing.Point(3, 3);
            this.grp_Dates.Name = "grp_Dates";
            this.grp_Dates.Size = new System.Drawing.Size(257, 78);
            this.grp_Dates.TabIndex = 80;
            this.grp_Dates.TabStop = false;
            this.grp_Dates.Text = "DATE";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(99, 48);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_EndDate.TabIndex = 81;
            this.dtp_EndDate.ValueChanged += new System.EventHandler(this.dtp_EndDate_ValueChanged);
            this.dtp_EndDate.Enter += new System.EventHandler(this.dtp_EndDate_Enter);
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(99, 16);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_StartDate.TabIndex = 80;
            this.dtp_StartDate.Enter += new System.EventHandler(this.dtp_StartDate_Enter);
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_EndDate.Location = new System.Drawing.Point(16, 55);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(67, 23);
            this.lbl_EndDate.TabIndex = 79;
            this.lbl_EndDate.Text = "End Date";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_StartDate.Location = new System.Drawing.Point(16, 22);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(70, 23);
            this.lbl_StartDate.TabIndex = 79;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // grp_Buttons
            // 
            this.grp_Buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_Buttons.Controls.Add(this.bttn_Print);
            this.grp_Buttons.Controls.Add(this.bttn_View);
            this.grp_Buttons.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_Buttons.Location = new System.Drawing.Point(313, 3);
            this.grp_Buttons.Name = "grp_Buttons";
            this.grp_Buttons.Size = new System.Drawing.Size(151, 78);
            this.grp_Buttons.TabIndex = 81;
            this.grp_Buttons.TabStop = false;
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Print.BackgroundImage")));
            this.bttn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Print.FlatAppearance.BorderSize = 0;
            this.bttn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Print.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.ForeColor = System.Drawing.Color.White;
            this.bttn_Print.Location = new System.Drawing.Point(52, 46);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(71, 28);
            this.bttn_Print.TabIndex = 37;
            this.bttn_Print.Text = "PRINT";
            this.bttn_Print.UseVisualStyleBackColor = true;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // bttn_View
            // 
            this.bttn_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_View.BackgroundImage")));
            this.bttn_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_View.FlatAppearance.BorderSize = 0;
            this.bttn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_View.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_View.ForeColor = System.Drawing.Color.White;
            this.bttn_View.Location = new System.Drawing.Point(54, 11);
            this.bttn_View.Name = "bttn_View";
            this.bttn_View.Size = new System.Drawing.Size(71, 28);
            this.bttn_View.TabIndex = 36;
            this.bttn_View.Text = "VIEW";
            this.bttn_View.UseVisualStyleBackColor = true;
            this.bttn_View.Click += new System.EventHandler(this.bttn_View_Click);
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
            this.pnl_Header.Size = new System.Drawing.Size(1234, 38);
            this.pnl_Header.TabIndex = 79;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(1076, 7);
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
            this.dtp_Date.Location = new System.Drawing.Point(1123, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // frm_CashBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 484);
            this.Controls.Add(this.pnl_Main);
            this.KeyPreview = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Book";
            this.Load += new System.EventHandler(this.frm_CashBook_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_CashBook_KeyDown);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviRelease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviAdded)).EndInit();
            this.pnl_Released.ResumeLayout(false);
            this.pnl_Released.PerformLayout();
            this.pnl_Added.ResumeLayout(false);
            this.pnl_Added.PerformLayout();
            this.pnl_Content.ResumeLayout(false);
            this.pnl_Content.PerformLayout();
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.grp_Dates.ResumeLayout(false);
            this.grp_Dates.PerformLayout();
            this.grp_Buttons.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.GroupBox grp_Dates;
        public System.Windows.Forms.DateTimePicker dtp_EndDate;
        public System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.GroupBox grp_Buttons;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.Button bttn_View;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.DataGridView dgv_GirviRelease;
        private System.Windows.Forms.DataGridView dgv_GirviAdded;
        private System.Windows.Forms.Panel pnl_Released;
        private System.Windows.Forms.Label lbl_GirviRelease;
        private System.Windows.Forms.Panel pnl_Added;
        private System.Windows.Forms.Label lbl_GirviAdded;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhatawaniPan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousBalanceRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhatawaniPan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
    }
}