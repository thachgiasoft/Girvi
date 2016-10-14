namespace JewelleryManagement.Reports
{
    partial class frm_CreditDebitRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CreditDebitRecord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_Dates = new System.Windows.Forms.GroupBox();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_record = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Result = new System.Windows.Forms.GroupBox();
            this.bttn_Show = new System.Windows.Forms.Button();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_CreditDebit = new System.Windows.Forms.Label();
            this.dtp_vyapariSale = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grp_Dates.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_record)).BeginInit();
            this.grp_Result.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grp_Dates);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dgv_record);
            this.panel1.Controls.Add(this.grp_Result);
            this.panel1.Controls.Add(this.pnl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 498);
            this.panel1.TabIndex = 0;
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
            this.grp_Dates.Location = new System.Drawing.Point(12, 41);
            this.grp_Dates.Name = "grp_Dates";
            this.grp_Dates.Size = new System.Drawing.Size(257, 83);
            this.grp_Dates.TabIndex = 283;
            this.grp_Dates.TabStop = false;
            this.grp_Dates.Text = "DATE";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(99, 45);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_EndDate.TabIndex = 81;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(99, 12);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_StartDate.TabIndex = 80;
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_EndDate.Location = new System.Drawing.Point(16, 50);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(65, 16);
            this.lbl_EndDate.TabIndex = 79;
            this.lbl_EndDate.Text = "End Date";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_StartDate.Location = new System.Drawing.Point(16, 20);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(71, 16);
            this.lbl_StartDate.TabIndex = 79;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.panel4.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.bttn_Close);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 463);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1015, 35);
            this.panel4.TabIndex = 282;
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
            this.bttn_Close.Location = new System.Drawing.Point(929, 0);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 59;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1114, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1068, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // dgv_record
            // 
            this.dgv_record.AllowUserToAddRows = false;
            this.dgv_record.AllowUserToDeleteRows = false;
            this.dgv_record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_record.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Credit,
            this.Debit,
            this.AccountName});
            this.dgv_record.Location = new System.Drawing.Point(11, 130);
            this.dgv_record.Name = "dgv_record";
            this.dgv_record.Size = new System.Drawing.Size(991, 327);
            this.dgv_record.TabIndex = 280;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "From";
            this.AccountName.Name = "AccountName";
            // 
            // grp_Result
            // 
            this.grp_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_Result.Controls.Add(this.bttn_Show);
            this.grp_Result.Controls.Add(this.bttn_Print);
            this.grp_Result.Location = new System.Drawing.Point(275, 41);
            this.grp_Result.Name = "grp_Result";
            this.grp_Result.Size = new System.Drawing.Size(117, 83);
            this.grp_Result.TabIndex = 277;
            this.grp_Result.TabStop = false;
            this.grp_Result.Text = "Result";
            // 
            // bttn_Show
            // 
            this.bttn_Show.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Show.BackgroundImage")));
            this.bttn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Show.FlatAppearance.BorderSize = 0;
            this.bttn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Show.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Show.ForeColor = System.Drawing.Color.White;
            this.bttn_Show.Location = new System.Drawing.Point(6, 16);
            this.bttn_Show.Name = "bttn_Show";
            this.bttn_Show.Size = new System.Drawing.Size(101, 26);
            this.bttn_Show.TabIndex = 62;
            this.bttn_Show.Text = "SHOW ";
            this.bttn_Show.UseVisualStyleBackColor = false;
            this.bttn_Show.Click += new System.EventHandler(this.bttn_Show_Click);
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
            this.bttn_Print.Location = new System.Drawing.Point(6, 45);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(100, 27);
            this.bttn_Print.TabIndex = 61;
            this.bttn_Print.Text = "PRINT";
            this.bttn_Print.UseVisualStyleBackColor = false;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Header.Controls.Add(this.lbl_CreditDebit);
            this.pnl_Header.Controls.Add(this.dtp_vyapariSale);
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1015, 35);
            this.pnl_Header.TabIndex = 1;
            // 
            // lbl_CreditDebit
            // 
            this.lbl_CreditDebit.AutoSize = true;
            this.lbl_CreditDebit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CreditDebit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreditDebit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_CreditDebit.Location = new System.Drawing.Point(472, 10);
            this.lbl_CreditDebit.Name = "lbl_CreditDebit";
            this.lbl_CreditDebit.Size = new System.Drawing.Size(83, 16);
            this.lbl_CreditDebit.TabIndex = 4;
            this.lbl_CreditDebit.Text = "Credit Debit";
            // 
            // dtp_vyapariSale
            // 
            this.dtp_vyapariSale.Location = new System.Drawing.Point(1114, 6);
            this.dtp_vyapariSale.Name = "dtp_vyapariSale";
            this.dtp_vyapariSale.Size = new System.Drawing.Size(85, 20);
            this.dtp_vyapariSale.TabIndex = 3;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Date.Location = new System.Drawing.Point(1068, 8);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(41, 16);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // frm_CreditDebitRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 498);
            this.Controls.Add(this.panel1);
            this.Name = "frm_CreditDebitRecord";
            this.Load += new System.EventHandler(this.frm_CreditDebitRecord_Load);
            this.panel1.ResumeLayout(false);
            this.grp_Dates.ResumeLayout(false);
            this.grp_Dates.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_record)).EndInit();
            this.grp_Result.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_CreditDebit;
        private System.Windows.Forms.DateTimePicker dtp_vyapariSale;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.GroupBox grp_Result;
        private System.Windows.Forms.Button bttn_Show;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_record;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.GroupBox grp_Dates;
        public System.Windows.Forms.DateTimePicker dtp_EndDate;
        public System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
    }
}