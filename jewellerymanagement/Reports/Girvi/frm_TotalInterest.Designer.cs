namespace JewelleryManagement.Reports.Girvi
{
    partial class frm_TotalInterest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TotalInterest));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.dgv_InterestDetail = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.bttn_View = new System.Windows.Forms.Button();
            this.grp_Dates = new System.Windows.Forms.GroupBox();
            this.lbl_MonthYear = new System.Windows.Forms.Label();
            this.rbt_custome = new System.Windows.Forms.RadioButton();
            this.rbt_yearly = new System.Windows.Forms.RadioButton();
            this.rbt_monthly = new System.Windows.Forms.RadioButton();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Report = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InterestDetail)).BeginInit();
            this.pnl_Content.SuspendLayout();
            this.grp_Dates.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.pnl_Main.Controls.Add(this.pnl_Bottom);
            this.pnl_Main.Controls.Add(this.pnl_Body);
            this.pnl_Main.Controls.Add(this.pnl_Content);
            this.pnl_Main.Controls.Add(this.pnl_Header);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(329, 499);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Print);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Location = new System.Drawing.Point(3, 456);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(323, 40);
            this.pnl_Bottom.TabIndex = 3;
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Print.BackgroundImage")));
            this.bttn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Print.FlatAppearance.BorderSize = 0;
            this.bttn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Print.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.ForeColor = System.Drawing.Color.White;
            this.bttn_Print.Location = new System.Drawing.Point(107, 6);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(71, 28);
            this.bttn_Print.TabIndex = 230;
            this.bttn_Print.Text = "PRINT";
            this.bttn_Print.UseVisualStyleBackColor = true;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
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
            this.bttn_Close.Location = new System.Drawing.Point(205, 6);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 229;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // pnl_Body
            // 
            this.pnl_Body.Controls.Add(this.dgv_InterestDetail);
            this.pnl_Body.Location = new System.Drawing.Point(3, 197);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(320, 255);
            this.pnl_Body.TabIndex = 2;
            // 
            // dgv_InterestDetail
            // 
            this.dgv_InterestDetail.AllowUserToAddRows = false;
            this.dgv_InterestDetail.AllowUserToDeleteRows = false;
            this.dgv_InterestDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InterestDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_InterestDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InterestDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.InterestAmount});
            this.dgv_InterestDetail.Location = new System.Drawing.Point(1, 5);
            this.dgv_InterestDetail.Name = "dgv_InterestDetail";
            this.dgv_InterestDetail.ReadOnly = true;
            this.dgv_InterestDetail.Size = new System.Drawing.Size(320, 247);
            this.dgv_InterestDetail.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // InterestAmount
            // 
            this.InterestAmount.HeaderText = "InterestAmount";
            this.InterestAmount.Name = "InterestAmount";
            this.InterestAmount.ReadOnly = true;
            // 
            // pnl_Content
            // 
            this.pnl_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.pnl_Content.Controls.Add(this.bttn_View);
            this.pnl_Content.Controls.Add(this.grp_Dates);
            this.pnl_Content.Location = new System.Drawing.Point(3, 39);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(323, 155);
            this.pnl_Content.TabIndex = 1;
            // 
            // bttn_View
            // 
            this.bttn_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_View.BackgroundImage")));
            this.bttn_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_View.FlatAppearance.BorderSize = 0;
            this.bttn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_View.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_View.ForeColor = System.Drawing.Color.White;
            this.bttn_View.Location = new System.Drawing.Point(3, 119);
            this.bttn_View.Name = "bttn_View";
            this.bttn_View.Size = new System.Drawing.Size(317, 28);
            this.bttn_View.TabIndex = 82;
            this.bttn_View.Text = "VIEW";
            this.bttn_View.UseVisualStyleBackColor = true;
            this.bttn_View.Click += new System.EventHandler(this.bttn_View_Click);
            // 
            // grp_Dates
            // 
            this.grp_Dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_Dates.Controls.Add(this.lbl_MonthYear);
            this.grp_Dates.Controls.Add(this.rbt_custome);
            this.grp_Dates.Controls.Add(this.rbt_yearly);
            this.grp_Dates.Controls.Add(this.rbt_monthly);
            this.grp_Dates.Controls.Add(this.dtp_EndDate);
            this.grp_Dates.Controls.Add(this.dtp_StartDate);
            this.grp_Dates.Controls.Add(this.lbl_EndDate);
            this.grp_Dates.Controls.Add(this.lbl_StartDate);
            this.grp_Dates.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Dates.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_Dates.Location = new System.Drawing.Point(3, 3);
            this.grp_Dates.Name = "grp_Dates";
            this.grp_Dates.Size = new System.Drawing.Size(320, 110);
            this.grp_Dates.TabIndex = 81;
            this.grp_Dates.TabStop = false;
            this.grp_Dates.Text = "Dates";
            // 
            // lbl_MonthYear
            // 
            this.lbl_MonthYear.AutoSize = true;
            this.lbl_MonthYear.ForeColor = System.Drawing.Color.Black;
            this.lbl_MonthYear.Location = new System.Drawing.Point(135, 0);
            this.lbl_MonthYear.Name = "lbl_MonthYear";
            this.lbl_MonthYear.Size = new System.Drawing.Size(40, 16);
            this.lbl_MonthYear.TabIndex = 85;
            this.lbl_MonthYear.Text = "lable";
            this.lbl_MonthYear.Visible = false;
            // 
            // rbt_custome
            // 
            this.rbt_custome.AutoSize = true;
            this.rbt_custome.Location = new System.Drawing.Point(204, 89);
            this.rbt_custome.Name = "rbt_custome";
            this.rbt_custome.Size = new System.Drawing.Size(81, 20);
            this.rbt_custome.TabIndex = 84;
            this.rbt_custome.TabStop = true;
            this.rbt_custome.Text = "Custome";
            this.rbt_custome.UseVisualStyleBackColor = true;
            this.rbt_custome.CheckedChanged += new System.EventHandler(this.rbt_custome_CheckedChanged);
            // 
            // rbt_yearly
            // 
            this.rbt_yearly.AutoSize = true;
            this.rbt_yearly.Location = new System.Drawing.Point(113, 90);
            this.rbt_yearly.Name = "rbt_yearly";
            this.rbt_yearly.Size = new System.Drawing.Size(65, 20);
            this.rbt_yearly.TabIndex = 83;
            this.rbt_yearly.TabStop = true;
            this.rbt_yearly.Text = "Yearly";
            this.rbt_yearly.UseVisualStyleBackColor = true;
            this.rbt_yearly.CheckedChanged += new System.EventHandler(this.rbt_yearly_CheckedChanged);
            // 
            // rbt_monthly
            // 
            this.rbt_monthly.AutoSize = true;
            this.rbt_monthly.Location = new System.Drawing.Point(18, 89);
            this.rbt_monthly.Name = "rbt_monthly";
            this.rbt_monthly.Size = new System.Drawing.Size(76, 20);
            this.rbt_monthly.TabIndex = 82;
            this.rbt_monthly.TabStop = true;
            this.rbt_monthly.Text = "Monthly";
            this.rbt_monthly.UseVisualStyleBackColor = true;
            this.rbt_monthly.CheckedChanged += new System.EventHandler(this.rbt_monthly_CheckedChanged);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(135, 52);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_EndDate.TabIndex = 81;
            this.dtp_EndDate.Enter += new System.EventHandler(this.dtp_EndDate_Enter);
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(135, 21);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(138, 27);
            this.dtp_StartDate.TabIndex = 80;
            this.dtp_StartDate.Enter += new System.EventHandler(this.dtp_StartDate_Enter);
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_EndDate.Location = new System.Drawing.Point(52, 57);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(65, 16);
            this.lbl_EndDate.TabIndex = 79;
            this.lbl_EndDate.Text = "End Date";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.ForeColor = System.Drawing.Color.Black;
            this.lbl_StartDate.Location = new System.Drawing.Point(52, 29);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(71, 16);
            this.lbl_StartDate.TabIndex = 79;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Controls.Add(this.lbl_Report);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(329, 33);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Report
            // 
            this.lbl_Report.AutoSize = true;
            this.lbl_Report.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Report.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Report.Location = new System.Drawing.Point(102, 9);
            this.lbl_Report.Name = "lbl_Report";
            this.lbl_Report.Size = new System.Drawing.Size(61, 16);
            this.lbl_Report.TabIndex = 1;
            this.lbl_Report.Text = "REPORT";
            // 
            // frm_TotalInterest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(329, 499);
            this.Controls.Add(this.pnl_Main);
            this.KeyPreview = true;
            this.Name = "frm_TotalInterest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Interest";
            this.Load += new System.EventHandler(this.frm_TotalInterest_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TotalInterest_KeyDown);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InterestDetail)).EndInit();
            this.pnl_Content.ResumeLayout(false);
            this.grp_Dates.ResumeLayout(false);
            this.grp_Dates.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Label lbl_Report;
        private System.Windows.Forms.GroupBox grp_Dates;
        public System.Windows.Forms.DateTimePicker dtp_EndDate;
        public System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.DataGridView dgv_InterestDetail;
        private System.Windows.Forms.Button bttn_View;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestAmount;
        private System.Windows.Forms.RadioButton rbt_monthly;
        private System.Windows.Forms.RadioButton rbt_custome;
        private System.Windows.Forms.RadioButton rbt_yearly;
        private System.Windows.Forms.Label lbl_MonthYear;
    }
}