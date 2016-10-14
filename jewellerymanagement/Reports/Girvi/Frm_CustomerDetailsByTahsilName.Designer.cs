namespace JewelleryManagement.Reports.Girvi
{
    partial class Frm_CustomerDetailsByTahsilName
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
            this.lbl_VillageName = new System.Windows.Forms.Label();
            this.cmb_TahsilName = new SergeUtils.EasyCompletionComboBox();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.dataGridView_GirviDetails = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirviNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receipt_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemwt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbk_Date = new System.Windows.Forms.CheckBox();
            this.bttn_print = new System.Windows.Forms.Button();
            this.bttn_view = new System.Windows.Forms.Button();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.pnl_Print = new System.Windows.Forms.Panel();
            this.rbt_PrintFalse = new System.Windows.Forms.RadioButton();
            this.rbt_PrintTrue = new System.Windows.Forms.RadioButton();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.Grp_Dates = new System.Windows.Forms.GroupBox();
            this.lbl_InterestDate = new System.Windows.Forms.Label();
            this.dtp_InterestDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartingDate = new System.Windows.Forms.Label();
            this.lbl_EndingDate = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.lst_FullName = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GirviDetails)).BeginInit();
            this.pnl_Print.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.Grp_Dates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_VillageName
            // 
            this.lbl_VillageName.AutoSize = true;
            this.lbl_VillageName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VillageName.Location = new System.Drawing.Point(248, 51);
            this.lbl_VillageName.Name = "lbl_VillageName";
            this.lbl_VillageName.Size = new System.Drawing.Size(86, 16);
            this.lbl_VillageName.TabIndex = 1;
            this.lbl_VillageName.Text = "Tahsil Name";
            // 
            // cmb_TahsilName
            // 
            this.cmb_TahsilName.AllowDrop = true;
            this.cmb_TahsilName.DisplayMember = "Address2";
            this.cmb_TahsilName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TahsilName.FormattingEnabled = true;
            this.cmb_TahsilName.Location = new System.Drawing.Point(247, 71);
            this.cmb_TahsilName.Name = "cmb_TahsilName";
            this.cmb_TahsilName.Size = new System.Drawing.Size(171, 31);
            this.cmb_TahsilName.TabIndex = 327;
            this.cmb_TahsilName.ValueMember = "Address2";
            this.cmb_TahsilName.SelectedIndexChanged += new System.EventHandler(this.cmb_VillageName_SelectedIndexChanged);
            this.cmb_TahsilName.TextChanged += new System.EventHandler(this.cmb_VillageName_TextChanged_1);
            this.cmb_TahsilName.Enter += new System.EventHandler(this.cmb_VillageName_Enter);
            this.cmb_TahsilName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_VillageName_KeyDown);
            // 
            // bttn_Close
            // 
            this.bttn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.bttn_Close.FlatAppearance.BorderSize = 0;
            this.bttn_Close.ForeColor = System.Drawing.Color.Black;
            this.bttn_Close.Location = new System.Drawing.Point(815, 2);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(75, 32);
            this.bttn_Close.TabIndex = 329;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // dataGridView_GirviDetails
            // 
            this.dataGridView_GirviDetails.AllowUserToAddRows = false;
            this.dataGridView_GirviDetails.AllowUserToDeleteRows = false;
            this.dataGridView_GirviDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_GirviDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_GirviDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GirviDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.FullName,
            this.ContactNo,
            this.Address,
            this.DateOfDeposit,
            this.GirviNo,
            this.ReceiptNo,
            this.Amount,
            this.Column12,
            this.InterestAmount,
            this.ekun,
            this.Column13,
            this.Column14,
            this.Forward,
            this.Column20,
            this.receipt_no,
            this.itemdes,
            this.itemwt,
            this.itemamt});
            this.dataGridView_GirviDetails.Location = new System.Drawing.Point(11, 163);
            this.dataGridView_GirviDetails.Name = "dataGridView_GirviDetails";
            this.dataGridView_GirviDetails.ReadOnly = true;
            this.dataGridView_GirviDetails.Size = new System.Drawing.Size(884, 259);
            this.dataGridView_GirviDetails.TabIndex = 330;
            this.dataGridView_GirviDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GirviDetails_CellContentClick);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
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
            // DateOfDeposit
            // 
            this.DateOfDeposit.HeaderText = "Date of Deposite";
            this.DateOfDeposit.Name = "DateOfDeposit";
            this.DateOfDeposit.ReadOnly = true;
            // 
            // GirviNo
            // 
            this.GirviNo.HeaderText = "Girvi no";
            this.GirviNo.Name = "GirviNo";
            this.GirviNo.ReadOnly = true;
            this.GirviNo.Visible = false;
            // 
            // ReceiptNo
            // 
            this.ReceiptNo.HeaderText = "Receipt_No";
            this.ReceiptNo.Name = "ReceiptNo";
            this.ReceiptNo.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Interest Rate";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // InterestAmount
            // 
            this.InterestAmount.HeaderText = "InterestAmount";
            this.InterestAmount.Name = "InterestAmount";
            this.InterestAmount.ReadOnly = true;
            // 
            // ekun
            // 
            this.ekun.HeaderText = "Total";
            this.ekun.Name = "ekun";
            this.ekun.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Duration";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Status";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Forward
            // 
            this.Forward.HeaderText = "Forward";
            this.Forward.Name = "Forward";
            this.Forward.ReadOnly = true;
            this.Forward.Visible = false;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Forward To";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            // 
            // receipt_no
            // 
            this.receipt_no.HeaderText = "receipt_no";
            this.receipt_no.Name = "receipt_no";
            this.receipt_no.ReadOnly = true;
            this.receipt_no.Visible = false;
            // 
            // itemdes
            // 
            this.itemdes.HeaderText = "Description";
            this.itemdes.Name = "itemdes";
            this.itemdes.ReadOnly = true;
            // 
            // itemwt
            // 
            this.itemwt.HeaderText = "wt";
            this.itemwt.Name = "itemwt";
            this.itemwt.ReadOnly = true;
            // 
            // itemamt
            // 
            this.itemamt.HeaderText = "Item Amount";
            this.itemamt.Name = "itemamt";
            this.itemamt.ReadOnly = true;
            // 
            // chbk_Date
            // 
            this.chbk_Date.AutoSize = true;
            this.chbk_Date.Location = new System.Drawing.Point(880, 53);
            this.chbk_Date.Name = "chbk_Date";
            this.chbk_Date.Size = new System.Drawing.Size(15, 14);
            this.chbk_Date.TabIndex = 335;
            this.chbk_Date.UseVisualStyleBackColor = true;
            this.chbk_Date.Visible = false;
            // 
            // bttn_print
            // 
            this.bttn_print.Image = global::JewelleryManagement.Properties.Resources.greenbutton;
            this.bttn_print.Location = new System.Drawing.Point(725, 2);
            this.bttn_print.Name = "bttn_print";
            this.bttn_print.Size = new System.Drawing.Size(85, 30);
            this.bttn_print.TabIndex = 336;
            this.bttn_print.Text = "Print";
            this.bttn_print.UseVisualStyleBackColor = true;
            this.bttn_print.Click += new System.EventHandler(this.bttn_print_Click);
            // 
            // bttn_view
            // 
            this.bttn_view.Image = global::JewelleryManagement.Properties.Resources.ADDBUTTON;
            this.bttn_view.Location = new System.Drawing.Point(437, 71);
            this.bttn_view.Name = "bttn_view";
            this.bttn_view.Size = new System.Drawing.Size(79, 31);
            this.bttn_view.TabIndex = 339;
            this.bttn_view.Text = "View";
            this.bttn_view.UseVisualStyleBackColor = true;
            this.bttn_view.Click += new System.EventHandler(this.bttn_view_Click);
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(761, 51);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 377;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            this.rbt_Hindi.CheckedChanged += new System.EventHandler(this.rbt_Hindi_CheckedChanged);
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(695, 51);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 378;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(816, 51);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 379;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // pnl_Print
            // 
            this.pnl_Print.Controls.Add(this.rbt_PrintFalse);
            this.pnl_Print.Controls.Add(this.rbt_PrintTrue);
            this.pnl_Print.Location = new System.Drawing.Point(695, 111);
            this.pnl_Print.Name = "pnl_Print";
            this.pnl_Print.Size = new System.Drawing.Size(200, 46);
            this.pnl_Print.TabIndex = 380;
            this.pnl_Print.Visible = false;
            // 
            // rbt_PrintFalse
            // 
            this.rbt_PrintFalse.AutoSize = true;
            this.rbt_PrintFalse.Location = new System.Drawing.Point(107, 15);
            this.rbt_PrintFalse.Name = "rbt_PrintFalse";
            this.rbt_PrintFalse.Size = new System.Drawing.Size(71, 17);
            this.rbt_PrintFalse.TabIndex = 373;
            this.rbt_PrintFalse.TabStop = true;
            this.rbt_PrintFalse.Text = "PrintFalse";
            this.rbt_PrintFalse.UseVisualStyleBackColor = true;
            this.rbt_PrintFalse.Visible = false;
            // 
            // rbt_PrintTrue
            // 
            this.rbt_PrintTrue.AutoSize = true;
            this.rbt_PrintTrue.Location = new System.Drawing.Point(13, 15);
            this.rbt_PrintTrue.Name = "rbt_PrintTrue";
            this.rbt_PrintTrue.Size = new System.Drawing.Size(68, 17);
            this.rbt_PrintTrue.TabIndex = 372;
            this.rbt_PrintTrue.TabStop = true;
            this.rbt_PrintTrue.Text = "PrintTrue";
            this.rbt_PrintTrue.UseVisualStyleBackColor = true;
            this.rbt_PrintTrue.Visible = false;
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(695, 74);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(200, 36);
            this.pnl_LanguageOther.TabIndex = 381;
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
            this.rbt_OtherTrue.Visible = false;
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
            this.rbt_OtherFalse.Visible = false;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_print);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 428);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(903, 38);
            this.pnl_Bottom.TabIndex = 383;
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
            this.pnl_Header.Size = new System.Drawing.Size(903, 38);
            this.pnl_Header.TabIndex = 382;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(746, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(44, 19);
            this.lbl_Date.TabIndex = 360;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(796, 3);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // Grp_Dates
            // 
            this.Grp_Dates.Controls.Add(this.lbl_InterestDate);
            this.Grp_Dates.Controls.Add(this.dtp_InterestDate);
            this.Grp_Dates.Controls.Add(this.lbl_StartingDate);
            this.Grp_Dates.Controls.Add(this.lbl_EndingDate);
            this.Grp_Dates.Controls.Add(this.dtp_StartDate);
            this.Grp_Dates.Controls.Add(this.dtp_EndDate);
            this.Grp_Dates.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Dates.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Grp_Dates.Location = new System.Drawing.Point(12, 44);
            this.Grp_Dates.Name = "Grp_Dates";
            this.Grp_Dates.Size = new System.Drawing.Size(230, 113);
            this.Grp_Dates.TabIndex = 384;
            this.Grp_Dates.TabStop = false;
            this.Grp_Dates.Text = "Dates";
            // 
            // lbl_InterestDate
            // 
            this.lbl_InterestDate.AutoSize = true;
            this.lbl_InterestDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InterestDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_InterestDate.Location = new System.Drawing.Point(6, 87);
            this.lbl_InterestDate.Name = "lbl_InterestDate";
            this.lbl_InterestDate.Size = new System.Drawing.Size(88, 16);
            this.lbl_InterestDate.TabIndex = 344;
            this.lbl_InterestDate.Text = "Interest Date";
            // 
            // dtp_InterestDate
            // 
            this.dtp_InterestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtp_InterestDate.Location = new System.Drawing.Point(108, 87);
            this.dtp_InterestDate.Name = "dtp_InterestDate";
            this.dtp_InterestDate.Size = new System.Drawing.Size(97, 20);
            this.dtp_InterestDate.TabIndex = 343;
            this.dtp_InterestDate.Enter += new System.EventHandler(this.dtp_InterestDate_Enter_1);
            // 
            // lbl_StartingDate
            // 
            this.lbl_StartingDate.AutoSize = true;
            this.lbl_StartingDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartingDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_StartingDate.Location = new System.Drawing.Point(6, 19);
            this.lbl_StartingDate.Name = "lbl_StartingDate";
            this.lbl_StartingDate.Size = new System.Drawing.Size(91, 16);
            this.lbl_StartingDate.TabIndex = 342;
            this.lbl_StartingDate.Text = "Starting Date";
            // 
            // lbl_EndingDate
            // 
            this.lbl_EndingDate.AutoSize = true;
            this.lbl_EndingDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndingDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_EndingDate.Location = new System.Drawing.Point(6, 52);
            this.lbl_EndingDate.Name = "lbl_EndingDate";
            this.lbl_EndingDate.Size = new System.Drawing.Size(85, 16);
            this.lbl_EndingDate.TabIndex = 341;
            this.lbl_EndingDate.Text = "Ending Date";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Location = new System.Drawing.Point(108, 17);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(96, 22);
            this.dtp_StartDate.TabIndex = 340;
            this.dtp_StartDate.Enter += new System.EventHandler(this.dtp_InterestDate_Enter_1);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtp_EndDate.Location = new System.Drawing.Point(108, 52);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(97, 20);
            this.dtp_EndDate.TabIndex = 339;
            this.dtp_EndDate.Enter += new System.EventHandler(this.dtp_InterestDate_Enter_1);
            // 
            // lst_FullName
            // 
            this.lst_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_FullName.FormattingEnabled = true;
            this.lst_FullName.ItemHeight = 20;
            this.lst_FullName.Location = new System.Drawing.Point(249, 104);
            this.lst_FullName.Name = "lst_FullName";
            this.lst_FullName.Size = new System.Drawing.Size(169, 164);
            this.lst_FullName.TabIndex = 385;
            this.lst_FullName.Visible = false;
            this.lst_FullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_FullName_KeyDown);
            // 
            // Frm_CustomerDetailsByTahsilName
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(903, 464);
            this.Controls.Add(this.lst_FullName);
            this.Controls.Add(this.Grp_Dates);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_LanguageOther);
            this.Controls.Add(this.pnl_Print);
            this.Controls.Add(this.rbt_English);
            this.Controls.Add(this.bttn_view);
            this.Controls.Add(this.rbt_Marathi);
            this.Controls.Add(this.rbt_Hindi);
            this.Controls.Add(this.chbk_Date);
            this.Controls.Add(this.dataGridView_GirviDetails);
            this.Controls.Add(this.cmb_TahsilName);
            this.Controls.Add(this.lbl_VillageName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Frm_CustomerDetailsByTahsilName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "गिरवी माहिती तहसील प्रमाणे";
            this.Load += new System.EventHandler(this.Frm_CustomerDetailsByTahsilName_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_CustomerDetailsByVillageName_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GirviDetails)).EndInit();
            this.pnl_Print.ResumeLayout(false);
            this.pnl_Print.PerformLayout();
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.Grp_Dates.ResumeLayout(false);
            this.Grp_Dates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_VillageName;
        public SergeUtils.EasyCompletionComboBox cmb_TahsilName;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.DataGridView dataGridView_GirviDetails;
        private System.Windows.Forms.CheckBox chbk_Date;
        private System.Windows.Forms.Button bttn_print;
        private System.Windows.Forms.Button bttn_view;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn receipt_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdes;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemwt;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemamt;
        private System.Windows.Forms.Panel pnl_Print;
        public System.Windows.Forms.RadioButton rbt_PrintFalse;
        public System.Windows.Forms.RadioButton rbt_PrintTrue;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.GroupBox Grp_Dates;
        private System.Windows.Forms.Label lbl_InterestDate;
        private System.Windows.Forms.DateTimePicker dtp_InterestDate;
        private System.Windows.Forms.Label lbl_StartingDate;
        private System.Windows.Forms.Label lbl_EndingDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.ListBox lst_FullName;
    }
}