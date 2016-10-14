namespace JewelleryManagement.Common
{
    partial class CrystalReportUpdates
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrystalReportUpdates));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.chk_selectall = new System.Windows.Forms.CheckBox();
            this.dgv_CrystalReport = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpdateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Query = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_crystalreport = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CrystalReport)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Controls.Add(this.btn_Execute);
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(621, 32);
            this.pnl_Header.TabIndex = 331;
            // 
            // btn_Execute
            // 
            this.btn_Execute.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Execute.Location = new System.Drawing.Point(12, 3);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(81, 26);
            this.btn_Execute.TabIndex = 361;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = false;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(421, 7);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 360;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(476, 2);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(139, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // chk_selectall
            // 
            this.chk_selectall.AutoSize = true;
            this.chk_selectall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_selectall.Location = new System.Drawing.Point(7, 38);
            this.chk_selectall.Name = "chk_selectall";
            this.chk_selectall.Size = new System.Drawing.Size(86, 19);
            this.chk_selectall.TabIndex = 336;
            this.chk_selectall.Text = "Select All";
            this.chk_selectall.UseVisualStyleBackColor = true;
            this.chk_selectall.CheckedChanged += new System.EventHandler(this.chk_selectall_CheckedChanged);
            // 
            // dgv_CrystalReport
            // 
            this.dgv_CrystalReport.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.dgv_CrystalReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CrystalReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CrystalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CrystalReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.UpdateName,
            this.Query,
            this.Date});
            this.dgv_CrystalReport.Location = new System.Drawing.Point(0, 63);
            this.dgv_CrystalReport.Name = "dgv_CrystalReport";
            this.dgv_CrystalReport.Size = new System.Drawing.Size(621, 300);
            this.dgv_CrystalReport.TabIndex = 337;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // UpdateName
            // 
            this.UpdateName.HeaderText = "UpdateName";
            this.UpdateName.Name = "UpdateName";
            // 
            // Query
            // 
            this.Query.HeaderText = "Query";
            this.Query.Name = "Query";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_crystalreport);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 369);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(621, 34);
            this.pnl_Bottom.TabIndex = 338;
            // 
            // bttn_crystalreport
            // 
            this.bttn_crystalreport.BackColor = System.Drawing.Color.Transparent;
            this.bttn_crystalreport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_crystalreport.BackgroundImage")));
            this.bttn_crystalreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_crystalreport.FlatAppearance.BorderSize = 0;
            this.bttn_crystalreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_crystalreport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_crystalreport.ForeColor = System.Drawing.Color.White;
            this.bttn_crystalreport.Location = new System.Drawing.Point(516, 3);
            this.bttn_crystalreport.Name = "bttn_crystalreport";
            this.bttn_crystalreport.Size = new System.Drawing.Size(99, 28);
            this.bttn_crystalreport.TabIndex = 229;
            this.bttn_crystalreport.Text = "CLOSE";
            this.bttn_crystalreport.UseVisualStyleBackColor = false;
            this.bttn_crystalreport.Click += new System.EventHandler(this.bttn_crystalreport_Click);
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
            this.bttn_Close.Location = new System.Drawing.Point(662, 3);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(99, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            // 
            // CrystalReportUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 403);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.dgv_CrystalReport);
            this.Controls.Add(this.chk_selectall);
            this.Controls.Add(this.pnl_Header);
            this.Name = "CrystalReportUpdates";
            this.Text = "CrystalReportUpdates";
            this.Load += new System.EventHandler(this.CrystalReportUpdates_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CrystalReport)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.CheckBox chk_selectall;
        private System.Windows.Forms.DataGridView dgv_CrystalReport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Query;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_crystalreport;
    }
}