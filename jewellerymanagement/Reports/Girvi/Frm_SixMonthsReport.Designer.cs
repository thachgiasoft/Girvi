namespace JewelleryManagement.Reports.Girvi
{
    partial class Frm_SixMonthsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SixMonthsReport));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.panel_sixmonthreport = new System.Windows.Forms.Panel();
            this.rbt_threemonths = new System.Windows.Forms.RadioButton();
            this.rbt_sixmonth = new System.Windows.Forms.RadioButton();
            this.rbt_ninemonths = new System.Windows.Forms.RadioButton();
            this.rbt_Twlevemonths = new System.Windows.Forms.RadioButton();
            this.cmb_VillageName = new SergeUtils.EasyCompletionComboBox();
            this.lbl_VillageName = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dgv_SixMonthReport = new System.Windows.Forms.DataGridView();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_monthwiseReport = new System.Windows.Forms.Button();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.lst_FullName = new System.Windows.Forms.ListBox();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhatawaniNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntrestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntrestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PavtiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Header.SuspendLayout();
            this.panel_sixmonthreport.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SixMonthReport)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Controls.Add(this.panel_sixmonthreport);
            this.pnl_Header.Controls.Add(this.cmb_VillageName);
            this.pnl_Header.Controls.Add(this.lbl_VillageName);
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Controls.Add(this.pnl_LanguageOther);
            this.pnl_Header.Controls.Add(this.rbt_Marathi);
            this.pnl_Header.Controls.Add(this.rbt_Hindi);
            this.pnl_Header.Controls.Add(this.rbt_English);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1230, 53);
            this.pnl_Header.TabIndex = 82;
            this.pnl_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Header_Paint);
            // 
            // panel_sixmonthreport
            // 
            this.panel_sixmonthreport.BackColor = System.Drawing.Color.Transparent;
            this.panel_sixmonthreport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_sixmonthreport.Controls.Add(this.rbt_threemonths);
            this.panel_sixmonthreport.Controls.Add(this.rbt_sixmonth);
            this.panel_sixmonthreport.Controls.Add(this.rbt_ninemonths);
            this.panel_sixmonthreport.Controls.Add(this.rbt_Twlevemonths);
            this.panel_sixmonthreport.Location = new System.Drawing.Point(3, 7);
            this.panel_sixmonthreport.Name = "panel_sixmonthreport";
            this.panel_sixmonthreport.Size = new System.Drawing.Size(382, 35);
            this.panel_sixmonthreport.TabIndex = 401;
            // 
            // rbt_threemonths
            // 
            this.rbt_threemonths.AutoSize = true;
            this.rbt_threemonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_threemonths.Location = new System.Drawing.Point(3, 8);
            this.rbt_threemonths.Name = "rbt_threemonths";
            this.rbt_threemonths.Size = new System.Drawing.Size(87, 20);
            this.rbt_threemonths.TabIndex = 395;
            this.rbt_threemonths.Text = "3 Months";
            this.rbt_threemonths.UseVisualStyleBackColor = true;
            this.rbt_threemonths.CheckedChanged += new System.EventHandler(this.rbt_threemonths_CheckedChanged);
            // 
            // rbt_sixmonth
            // 
            this.rbt_sixmonth.AutoSize = true;
            this.rbt_sixmonth.Checked = true;
            this.rbt_sixmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_sixmonth.Location = new System.Drawing.Point(96, 8);
            this.rbt_sixmonth.Name = "rbt_sixmonth";
            this.rbt_sixmonth.Size = new System.Drawing.Size(87, 20);
            this.rbt_sixmonth.TabIndex = 398;
            this.rbt_sixmonth.TabStop = true;
            this.rbt_sixmonth.Text = "6 Months";
            this.rbt_sixmonth.UseVisualStyleBackColor = true;
            this.rbt_sixmonth.CheckedChanged += new System.EventHandler(this.rbt_sixmonth_CheckedChanged);
            // 
            // rbt_ninemonths
            // 
            this.rbt_ninemonths.AutoSize = true;
            this.rbt_ninemonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_ninemonths.Location = new System.Drawing.Point(189, 8);
            this.rbt_ninemonths.Name = "rbt_ninemonths";
            this.rbt_ninemonths.Size = new System.Drawing.Size(87, 20);
            this.rbt_ninemonths.TabIndex = 396;
            this.rbt_ninemonths.Text = "9 Months";
            this.rbt_ninemonths.UseVisualStyleBackColor = true;
            this.rbt_ninemonths.CheckedChanged += new System.EventHandler(this.rbt_ninemonths_CheckedChanged);
            // 
            // rbt_Twlevemonths
            // 
            this.rbt_Twlevemonths.AutoSize = true;
            this.rbt_Twlevemonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Twlevemonths.Location = new System.Drawing.Point(282, 7);
            this.rbt_Twlevemonths.Name = "rbt_Twlevemonths";
            this.rbt_Twlevemonths.Size = new System.Drawing.Size(95, 20);
            this.rbt_Twlevemonths.TabIndex = 397;
            this.rbt_Twlevemonths.Text = "12 Months";
            this.rbt_Twlevemonths.UseVisualStyleBackColor = true;
            this.rbt_Twlevemonths.CheckedChanged += new System.EventHandler(this.rbt_12months_CheckedChanged);
            // 
            // cmb_VillageName
            // 
            this.cmb_VillageName.AllowDrop = true;
            this.cmb_VillageName.DisplayMember = "Address";
            this.cmb_VillageName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_VillageName.FormattingEnabled = true;
            this.cmb_VillageName.Location = new System.Drawing.Point(492, 2);
            this.cmb_VillageName.Name = "cmb_VillageName";
            this.cmb_VillageName.Size = new System.Drawing.Size(171, 31);
            this.cmb_VillageName.TabIndex = 400;
            this.cmb_VillageName.ValueMember = "Address";
            this.cmb_VillageName.Visible = false;
            this.cmb_VillageName.TextChanged += new System.EventHandler(this.cmb_VillageName_TextChanged);
            this.cmb_VillageName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_VillageName_KeyDown);
            // 
            // lbl_VillageName
            // 
            this.lbl_VillageName.AutoSize = true;
            this.lbl_VillageName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VillageName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VillageName.Location = new System.Drawing.Point(389, 7);
            this.lbl_VillageName.Name = "lbl_VillageName";
            this.lbl_VillageName.Size = new System.Drawing.Size(99, 18);
            this.lbl_VillageName.TabIndex = 399;
            this.lbl_VillageName.Text = "Village Name";
            this.lbl_VillageName.Visible = false;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Date.Location = new System.Drawing.Point(1065, 12);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(41, 16);
            this.lbl_Date.TabIndex = 389;
            this.lbl_Date.Text = "Date";
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(884, 3);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(176, 31);
            this.pnl_LanguageOther.TabIndex = 388;
            this.pnl_LanguageOther.Visible = false;
            // 
            // rbt_OtherTrue
            // 
            this.rbt_OtherTrue.AutoSize = true;
            this.rbt_OtherTrue.ForeColor = System.Drawing.Color.White;
            this.rbt_OtherTrue.Location = new System.Drawing.Point(16, 13);
            this.rbt_OtherTrue.Name = "rbt_OtherTrue";
            this.rbt_OtherTrue.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherTrue.TabIndex = 372;
            this.rbt_OtherTrue.Text = "Other True";
            this.rbt_OtherTrue.UseVisualStyleBackColor = true;
            // 
            // rbt_OtherFalse
            // 
            this.rbt_OtherFalse.AutoSize = true;
            this.rbt_OtherFalse.BackColor = System.Drawing.Color.Transparent;
            this.rbt_OtherFalse.ForeColor = System.Drawing.Color.White;
            this.rbt_OtherFalse.Location = new System.Drawing.Point(98, 12);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = false;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.BackColor = System.Drawing.Color.Transparent;
            this.rbt_Marathi.ForeColor = System.Drawing.Color.White;
            this.rbt_Marathi.Location = new System.Drawing.Point(817, 12);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 387;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = false;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.BackColor = System.Drawing.Color.Transparent;
            this.rbt_Hindi.ForeColor = System.Drawing.Color.White;
            this.rbt_Hindi.Location = new System.Drawing.Point(754, 11);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 386;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = false;
            this.rbt_Hindi.Visible = false;
            this.rbt_Hindi.CheckedChanged += new System.EventHandler(this.rbt_Hindi_CheckedChanged);
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.BackColor = System.Drawing.Color.Transparent;
            this.rbt_English.ForeColor = System.Drawing.Color.White;
            this.rbt_English.Location = new System.Drawing.Point(680, 12);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 385;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = false;
            this.rbt_English.Visible = false;
            this.rbt_English.CheckedChanged += new System.EventHandler(this.rbt_English_CheckedChanged);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(1112, 9);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // dgv_SixMonthReport
            // 
            this.dgv_SixMonthReport.AllowUserToAddRows = false;
            this.dgv_SixMonthReport.AllowUserToDeleteRows = false;
            this.dgv_SixMonthReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SixMonthReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_SixMonthReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SixMonthReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.KhatawaniNo,
            this.CName,
            this.ContactNo,
            this.Address,
            this.Amount,
            this.DateOfDeposit,
            this.Duration,
            this.IntrestRate,
            this.IntrestAmount,
            this.TotalAmount,
            this.PavtiNo});
            this.dgv_SixMonthReport.Location = new System.Drawing.Point(0, 82);
            this.dgv_SixMonthReport.Name = "dgv_SixMonthReport";
            this.dgv_SixMonthReport.Size = new System.Drawing.Size(1230, 399);
            this.dgv_SixMonthReport.TabIndex = 102;
            this.dgv_SixMonthReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhatawaniDetail_CellContentClick);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.Controls.Add(this.bttn_monthwiseReport);
            this.pnl_Bottom.Controls.Add(this.bttn_Print);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 483);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(1230, 38);
            this.pnl_Bottom.TabIndex = 103;
            // 
            // bttn_monthwiseReport
            // 
            this.bttn_monthwiseReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_monthwiseReport.BackgroundImage")));
            this.bttn_monthwiseReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_monthwiseReport.FlatAppearance.BorderSize = 0;
            this.bttn_monthwiseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_monthwiseReport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_monthwiseReport.ForeColor = System.Drawing.Color.White;
            this.bttn_monthwiseReport.Location = new System.Drawing.Point(792, 4);
            this.bttn_monthwiseReport.Name = "bttn_monthwiseReport";
            this.bttn_monthwiseReport.Size = new System.Drawing.Size(238, 28);
            this.bttn_monthwiseReport.TabIndex = 232;
            this.bttn_monthwiseReport.Text = "Monthwise Report";
            this.bttn_monthwiseReport.UseVisualStyleBackColor = true;
            this.bttn_monthwiseReport.Click += new System.EventHandler(this.bttn_monthwiseReport_Click);
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Print.BackgroundImage")));
            this.bttn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Print.FlatAppearance.BorderSize = 0;
            this.bttn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Print.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.ForeColor = System.Drawing.Color.White;
            this.bttn_Print.Location = new System.Drawing.Point(1036, 5);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(71, 28);
            this.bttn_Print.TabIndex = 231;
            this.bttn_Print.Text = "PRINT";
            this.bttn_Print.UseVisualStyleBackColor = true;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
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
            this.bttn_Close.Location = new System.Drawing.Point(1131, 5);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // lst_FullName
            // 
            this.lst_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_FullName.FormattingEnabled = true;
            this.lst_FullName.ItemHeight = 20;
            this.lst_FullName.Location = new System.Drawing.Point(492, 32);
            this.lst_FullName.Name = "lst_FullName";
            this.lst_FullName.Size = new System.Drawing.Size(171, 44);
            this.lst_FullName.TabIndex = 386;
            this.lst_FullName.Visible = false;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            // 
            // KhatawaniNo
            // 
            this.KhatawaniNo.HeaderText = "KhatawaniNo";
            this.KhatawaniNo.Name = "KhatawaniNo";
            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            // 
            // ContactNo
            // 
            this.ContactNo.HeaderText = "ContactNo";
            this.ContactNo.Name = "ContactNo";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // DateOfDeposit
            // 
            this.DateOfDeposit.HeaderText = "DateOfDeposit";
            this.DateOfDeposit.Name = "DateOfDeposit";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // IntrestRate
            // 
            this.IntrestRate.HeaderText = "IntrestRate";
            this.IntrestRate.Name = "IntrestRate";
            // 
            // IntrestAmount
            // 
            this.IntrestAmount.HeaderText = "IntrestAmount";
            this.IntrestAmount.Name = "IntrestAmount";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // PavtiNo
            // 
            this.PavtiNo.HeaderText = "PavtiNo";
            this.PavtiNo.Name = "PavtiNo";
            // 
            // Frm_SixMonthsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 521);
            this.Controls.Add(this.lst_FullName);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.dgv_SixMonthReport);
            this.Controls.Add(this.pnl_Header);
            this.KeyPreview = true;
            this.Name = "Frm_SixMonthsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Six Months Report";
            this.Load += new System.EventHandler(this.Frm_SixMonthsReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_SixMonthsReport_KeyDown);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.panel_sixmonthreport.ResumeLayout(false);
            this.panel_sixmonthreport.PerformLayout();
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SixMonthReport)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DataGridView dgv_SixMonthReport;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.RadioButton rbt_Twlevemonths;
        private System.Windows.Forms.RadioButton rbt_ninemonths;
        private System.Windows.Forms.RadioButton rbt_threemonths;
        private System.Windows.Forms.RadioButton rbt_sixmonth;
        private System.Windows.Forms.Panel panel_sixmonthreport;
        public SergeUtils.EasyCompletionComboBox cmb_VillageName;
        private System.Windows.Forms.Label lbl_VillageName;
        private System.Windows.Forms.ListBox lst_FullName;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.Button bttn_monthwiseReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhatawaniNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntrestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntrestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PavtiNo;
    }
}