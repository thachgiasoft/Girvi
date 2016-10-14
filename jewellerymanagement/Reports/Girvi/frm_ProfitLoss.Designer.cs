namespace JewelleryManagement.Reports.Girvi
{
    partial class frm_ProfitLoss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProfitLoss));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.bttn_reset = new System.Windows.Forms.Button();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.lbl_Profit = new System.Windows.Forms.Label();
            this.lbl_CurrentProfit = new System.Windows.Forms.Label();
            this.bttn_ActualRI = new System.Windows.Forms.Button();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.dgv_GirviDetail = new System.Windows.Forms.DataGridView();
            this.GirviNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDateOfRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentLoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentGirviAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_itemDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Main.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemDetails)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.pnl_Main.Controls.Add(this.rbt_English);
            this.pnl_Main.Controls.Add(this.rbt_Hindi);
            this.pnl_Main.Controls.Add(this.rbt_Marathi);
            this.pnl_Main.Controls.Add(this.pnl_LanguageOther);
            this.pnl_Main.Controls.Add(this.bttn_reset);
            this.pnl_Main.Controls.Add(this.pnl_Bottom);
            this.pnl_Main.Controls.Add(this.bttn_ActualRI);
            this.pnl_Main.Controls.Add(this.pnl_Body);
            this.pnl_Main.Controls.Add(this.pnl_Header);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(987, 479);
            this.pnl_Main.TabIndex = 0;
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(571, 50);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 372;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(650, 50);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 373;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            this.rbt_Hindi.CheckedChanged += new System.EventHandler(this.rbt_Hindi_CheckedChanged);
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(715, 50);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 374;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(794, 43);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(176, 32);
            this.pnl_LanguageOther.TabIndex = 380;
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
            // bttn_reset
            // 
            this.bttn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_reset.BackgroundImage")));
            this.bttn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_reset.FlatAppearance.BorderSize = 0;
            this.bttn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_reset.ForeColor = System.Drawing.Color.White;
            this.bttn_reset.Location = new System.Drawing.Point(117, 45);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(98, 28);
            this.bttn_reset.TabIndex = 275;
            this.bttn_reset.Text = "Reset";
            this.bttn_reset.UseVisualStyleBackColor = true;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Controls.Add(this.lbl_Profit);
            this.pnl_Bottom.Controls.Add(this.lbl_CurrentProfit);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 442);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(987, 37);
            this.pnl_Bottom.TabIndex = 274;
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
            this.bttn_Close.Location = new System.Drawing.Point(899, 4);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // lbl_Profit
            // 
            this.lbl_Profit.AutoSize = true;
            this.lbl_Profit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Profit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Profit.Location = new System.Drawing.Point(126, 12);
            this.lbl_Profit.Name = "lbl_Profit";
            this.lbl_Profit.Size = new System.Drawing.Size(64, 13);
            this.lbl_Profit.TabIndex = 2;
            this.lbl_Profit.Text = "...................";
            // 
            // lbl_CurrentProfit
            // 
            this.lbl_CurrentProfit.AutoSize = true;
            this.lbl_CurrentProfit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentProfit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentProfit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_CurrentProfit.Location = new System.Drawing.Point(6, 10);
            this.lbl_CurrentProfit.Name = "lbl_CurrentProfit";
            this.lbl_CurrentProfit.Size = new System.Drawing.Size(114, 18);
            this.lbl_CurrentProfit.TabIndex = 1;
            this.lbl_CurrentProfit.Text = "Current Profit :";
            // 
            // bttn_ActualRI
            // 
            this.bttn_ActualRI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_ActualRI.BackgroundImage")));
            this.bttn_ActualRI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_ActualRI.FlatAppearance.BorderSize = 0;
            this.bttn_ActualRI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_ActualRI.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_ActualRI.ForeColor = System.Drawing.Color.White;
            this.bttn_ActualRI.Location = new System.Drawing.Point(13, 45);
            this.bttn_ActualRI.Name = "bttn_ActualRI";
            this.bttn_ActualRI.Size = new System.Drawing.Size(98, 28);
            this.bttn_ActualRI.TabIndex = 273;
            this.bttn_ActualRI.Text = "ACTUAL RI";
            this.bttn_ActualRI.UseVisualStyleBackColor = true;
            this.bttn_ActualRI.Click += new System.EventHandler(this.bttn_ActualRI_Click);
            // 
            // pnl_Body
            // 
            this.pnl_Body.Controls.Add(this.dgv_GirviDetail);
            this.pnl_Body.Controls.Add(this.dgv_itemDetails);
            this.pnl_Body.Location = new System.Drawing.Point(3, 79);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(981, 358);
            this.pnl_Body.TabIndex = 1;
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
            this.Name,
            this.Amount,
            this.DateOfDeposit,
            this.InterestRate,
            this.LastDateOfRelease,
            this.CurrentLoanAmount,
            this.CurrentGirviAmount,
            this.ProfitValue});
            this.dgv_GirviDetail.Location = new System.Drawing.Point(3, 3);
            this.dgv_GirviDetail.Name = "dgv_GirviDetail";
            this.dgv_GirviDetail.ReadOnly = true;
            this.dgv_GirviDetail.Size = new System.Drawing.Size(975, 349);
            this.dgv_GirviDetail.TabIndex = 92;
            // 
            // GirviNo
            // 
            this.GirviNo.HeaderText = "GirviNo";
            this.GirviNo.Name = "GirviNo";
            this.GirviNo.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DateOfDeposit
            // 
            this.DateOfDeposit.HeaderText = "DateOfDeposit";
            this.DateOfDeposit.Name = "DateOfDeposit";
            this.DateOfDeposit.ReadOnly = true;
            // 
            // InterestRate
            // 
            this.InterestRate.HeaderText = "InterestRate";
            this.InterestRate.Name = "InterestRate";
            this.InterestRate.ReadOnly = true;
            // 
            // LastDateOfRelease
            // 
            this.LastDateOfRelease.HeaderText = "LastDate OfRelease";
            this.LastDateOfRelease.Name = "LastDateOfRelease";
            this.LastDateOfRelease.ReadOnly = true;
            // 
            // CurrentLoanAmount
            // 
            this.CurrentLoanAmount.HeaderText = "CurrentLoan Amount";
            this.CurrentLoanAmount.Name = "CurrentLoanAmount";
            this.CurrentLoanAmount.ReadOnly = true;
            // 
            // CurrentGirviAmount
            // 
            this.CurrentGirviAmount.HeaderText = "CurrentGirvi Amount";
            this.CurrentGirviAmount.Name = "CurrentGirviAmount";
            this.CurrentGirviAmount.ReadOnly = true;
            // 
            // ProfitValue
            // 
            this.ProfitValue.HeaderText = "ProfitValue";
            this.ProfitValue.Name = "ProfitValue";
            this.ProfitValue.ReadOnly = true;
            // 
            // dgv_itemDetails
            // 
            this.dgv_itemDetails.AllowUserToAddRows = false;
            this.dgv_itemDetails.AllowUserToDeleteRows = false;
            this.dgv_itemDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_itemDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgv_itemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.Column26,
            this.Column27,
            this.Profit});
            this.dgv_itemDetails.Location = new System.Drawing.Point(6, 3);
            this.dgv_itemDetails.Name = "dgv_itemDetails";
            this.dgv_itemDetails.ReadOnly = true;
            this.dgv_itemDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemDetails.Size = new System.Drawing.Size(817, 197);
            this.dgv_itemDetails.TabIndex = 375;
            this.dgv_itemDetails.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Girvi_no";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Metal_Type";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Metal_type";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Item_Type";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Item_type";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Gross_wt";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "red_wt";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Net_wt";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "wt_in_per";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "fine_wt";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "Previous_rate";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "amount";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // Column26
            // 
            this.Column26.HeaderText = "Current_rate";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            // 
            // Column27
            // 
            this.Column27.HeaderText = "Amount";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
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
            this.pnl_Header.Size = new System.Drawing.Size(987, 37);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(833, 7);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 360;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(877, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // frm_ProfitLoss
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 479);
            this.Controls.Add(this.pnl_Main);
            this.KeyPreview = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit / Loss";
            this.Load += new System.EventHandler(this.frm_ProfitLoss_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ProfitLoss_KeyDown);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemDetails)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.Button bttn_ActualRI;
        private System.Windows.Forms.DataGridView dgv_GirviDetail;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Label lbl_Profit;
        private System.Windows.Forms.Label lbl_CurrentProfit;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirviNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDateOfRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentLoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentGirviAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitValue;
        private System.Windows.Forms.DataGridView dgv_itemDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        private System.Windows.Forms.Button bttn_reset;
    }
}