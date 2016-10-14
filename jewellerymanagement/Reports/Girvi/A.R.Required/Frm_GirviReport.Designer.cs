namespace JewelleryManagement.Reports.Girvi.A.R.Required
{
    partial class Frm_GirviReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GirviReport));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.dtp_vyapariSale = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.grp_Date = new System.Windows.Forms.GroupBox();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.bttn_View = new System.Windows.Forms.Button();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndingDate = new System.Windows.Forms.Label();
            this.dgv_girvidetails = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GahanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muddalnaave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetalDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetWt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.pnl_Header.SuspendLayout();
            this.grp_Date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_girvidetails)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Header.Controls.Add(this.dtp_vyapariSale);
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1101, 35);
            this.pnl_Header.TabIndex = 36;
            // 
            // dtp_vyapariSale
            // 
            this.dtp_vyapariSale.Location = new System.Drawing.Point(965, 5);
            this.dtp_vyapariSale.Name = "dtp_vyapariSale";
            this.dtp_vyapariSale.Size = new System.Drawing.Size(85, 20);
            this.dtp_vyapariSale.TabIndex = 3;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Date.Location = new System.Drawing.Point(907, 7);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(41, 16);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_startDate.Location = new System.Drawing.Point(5, 21);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(98, 17);
            this.lbl_startDate.TabIndex = 105;
            this.lbl_startDate.Text = "Starting Date ";
            // 
            // grp_Date
            // 
            this.grp_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_Date.Controls.Add(this.bttn_Print);
            this.grp_Date.Controls.Add(this.bttn_View);
            this.grp_Date.Controls.Add(this.lbl_startDate);
            this.grp_Date.Controls.Add(this.dtp_EndDate);
            this.grp_Date.Controls.Add(this.dtp_StartDate);
            this.grp_Date.Controls.Add(this.lbl_EndingDate);
            this.grp_Date.Location = new System.Drawing.Point(0, 41);
            this.grp_Date.Name = "grp_Date";
            this.grp_Date.Size = new System.Drawing.Size(328, 89);
            this.grp_Date.TabIndex = 278;
            this.grp_Date.TabStop = false;
            this.grp_Date.Text = "Date";
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Print.BackgroundImage")));
            this.bttn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Print.FlatAppearance.BorderSize = 0;
            this.bttn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Print.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.ForeColor = System.Drawing.Color.White;
            this.bttn_Print.Location = new System.Drawing.Point(228, 49);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(94, 23);
            this.bttn_Print.TabIndex = 287;
            this.bttn_Print.Text = "PRINT";
            this.bttn_Print.UseVisualStyleBackColor = false;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // bttn_View
            // 
            this.bttn_View.BackColor = System.Drawing.Color.Transparent;
            this.bttn_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_View.BackgroundImage")));
            this.bttn_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_View.FlatAppearance.BorderSize = 0;
            this.bttn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_View.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_View.ForeColor = System.Drawing.Color.White;
            this.bttn_View.Location = new System.Drawing.Point(230, 16);
            this.bttn_View.Name = "bttn_View";
            this.bttn_View.Size = new System.Drawing.Size(92, 25);
            this.bttn_View.TabIndex = 286;
            this.bttn_View.Text = "VIEW";
            this.bttn_View.UseVisualStyleBackColor = false;
            this.bttn_View.Click += new System.EventHandler(this.bttn_View_Click);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_EndDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(109, 51);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(103, 20);
            this.dtp_EndDate.TabIndex = 104;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_StartDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartDate.Location = new System.Drawing.Point(109, 18);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(103, 20);
            this.dtp_StartDate.TabIndex = 103;
            // 
            // lbl_EndingDate
            // 
            this.lbl_EndingDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_EndingDate.AutoSize = true;
            this.lbl_EndingDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndingDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_EndingDate.Location = new System.Drawing.Point(6, 54);
            this.lbl_EndingDate.Name = "lbl_EndingDate";
            this.lbl_EndingDate.Size = new System.Drawing.Size(93, 17);
            this.lbl_EndingDate.TabIndex = 106;
            this.lbl_EndingDate.Text = "Ending Date ";
            // 
            // dgv_girvidetails
            // 
            this.dgv_girvidetails.AllowUserToAddRows = false;
            this.dgv_girvidetails.AllowUserToDeleteRows = false;
            this.dgv_girvidetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_girvidetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_girvidetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_girvidetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_girvidetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.khno,
            this.GahanNo,
            this.datenaave,
            this.muddalnaave,
            this.name,
            this.address,
            this.MetalDiscription,
            this.Qty,
            this.Wt,
            this.NetWt,
            this.ReleaseDate,
            this.RecieptNo});
            this.dgv_girvidetails.Location = new System.Drawing.Point(6, 121);
            this.dgv_girvidetails.Name = "dgv_girvidetails";
            this.dgv_girvidetails.ReadOnly = true;
            this.dgv_girvidetails.Size = new System.Drawing.Size(1085, 373);
            this.dgv_girvidetails.TabIndex = 279;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            this.SrNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // khno
            // 
            this.khno.HeaderText = "KhNo";
            this.khno.Name = "khno";
            this.khno.ReadOnly = true;
            this.khno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GahanNo
            // 
            this.GahanNo.HeaderText = "GahanNo";
            this.GahanNo.Name = "GahanNo";
            this.GahanNo.ReadOnly = true;
            // 
            // datenaave
            // 
            this.datenaave.HeaderText = "Date";
            this.datenaave.Name = "datenaave";
            this.datenaave.ReadOnly = true;
            // 
            // muddalnaave
            // 
            this.muddalnaave.HeaderText = "Amount";
            this.muddalnaave.Name = "muddalnaave";
            this.muddalnaave.ReadOnly = true;
            this.muddalnaave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MetalDiscription
            // 
            this.MetalDiscription.HeaderText = "MetalDiscription";
            this.MetalDiscription.Name = "MetalDiscription";
            this.MetalDiscription.ReadOnly = true;
            this.MetalDiscription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Wt
            // 
            this.Wt.HeaderText = "Wt";
            this.Wt.Name = "Wt";
            this.Wt.ReadOnly = true;
            // 
            // NetWt
            // 
            this.NetWt.HeaderText = "NetWt";
            this.NetWt.Name = "NetWt";
            this.NetWt.ReadOnly = true;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            // 
            // RecieptNo
            // 
            this.RecieptNo.HeaderText = "RecieptNo";
            this.RecieptNo.Name = "RecieptNo";
            this.RecieptNo.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.panel4.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.bttn_Close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 500);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1101, 35);
            this.panel4.TabIndex = 285;
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
            this.bttn_Close.Location = new System.Drawing.Point(1009, 3);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 59;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(748, 53);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(176, 45);
            this.pnl_LanguageOther.TabIndex = 384;
            this.pnl_LanguageOther.Visible = false;
            // 
            // rbt_OtherTrue
            // 
            this.rbt_OtherTrue.AutoSize = true;
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
            this.rbt_OtherFalse.Location = new System.Drawing.Point(98, 12);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = true;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(681, 68);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 383;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(617, 68);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 382;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            this.rbt_Hindi.CheckedChanged += new System.EventHandler(this.rbt_Hindi_CheckedChanged);
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(544, 68);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 381;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            this.rbt_English.CheckedChanged += new System.EventHandler(this.rbt_English_CheckedChanged);
            // 
            // Frm_GirviReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 535);
            this.Controls.Add(this.pnl_LanguageOther);
            this.Controls.Add(this.rbt_Marathi);
            this.Controls.Add(this.rbt_Hindi);
            this.Controls.Add(this.rbt_English);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_girvidetails);
            this.Controls.Add(this.grp_Date);
            this.Controls.Add(this.pnl_Header);
            this.KeyPreview = true;
            this.Name = "Frm_GirviReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Girvi Report";
            this.Load += new System.EventHandler(this.Frm_GirviReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_GirviReport_KeyDown);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.grp_Date.ResumeLayout(false);
            this.grp_Date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_girvidetails)).EndInit();
            this.panel4.ResumeLayout(false);
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.DateTimePicker dtp_vyapariSale;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.Button bttn_View;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.GroupBox grp_Date;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_EndingDate;
        private System.Windows.Forms.DataGridView dgv_girvidetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn khno;
        private System.Windows.Forms.DataGridViewTextBoxColumn GahanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaave;
        private System.Windows.Forms.DataGridViewTextBoxColumn muddalnaave;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetalDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetWt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptNo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
    }
}