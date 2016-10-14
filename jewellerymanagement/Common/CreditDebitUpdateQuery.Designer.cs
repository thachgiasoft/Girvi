namespace JewelleryManagement.Common
{
    partial class CreditDebitUpdateQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditDebitUpdateQuery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.dgv_CreaditDebit = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpdateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Query = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_selectall = new System.Windows.Forms.CheckBox();
            this.pnl_Header.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CreaditDebit)).BeginInit();
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
            this.pnl_Header.Size = new System.Drawing.Size(761, 32);
            this.pnl_Header.TabIndex = 330;
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
            this.lbl_Date.Location = new System.Drawing.Point(561, 7);
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
            this.dtp_Date.Location = new System.Drawing.Point(616, 2);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(139, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 352);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(761, 35);
            this.pnl_Bottom.TabIndex = 333;
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
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // dgv_CreaditDebit
            // 
            this.dgv_CreaditDebit.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.dgv_CreaditDebit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CreaditDebit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CreaditDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CreaditDebit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.UpdateName,
            this.Query,
            this.Date});
            this.dgv_CreaditDebit.Location = new System.Drawing.Point(3, 65);
            this.dgv_CreaditDebit.Name = "dgv_CreaditDebit";
            this.dgv_CreaditDebit.Size = new System.Drawing.Size(758, 285);
            this.dgv_CreaditDebit.TabIndex = 334;
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
            // chk_selectall
            // 
            this.chk_selectall.AutoSize = true;
            this.chk_selectall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_selectall.Location = new System.Drawing.Point(12, 37);
            this.chk_selectall.Name = "chk_selectall";
            this.chk_selectall.Size = new System.Drawing.Size(86, 19);
            this.chk_selectall.TabIndex = 335;
            this.chk_selectall.Text = "Select All";
            this.chk_selectall.UseVisualStyleBackColor = true;
            this.chk_selectall.CheckedChanged += new System.EventHandler(this.chk_selectall_CheckedChanged);
            // 
            // CreditDebitUpdateQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 387);
            this.Controls.Add(this.chk_selectall);
            this.Controls.Add(this.dgv_CreaditDebit);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Name = "CreditDebitUpdateQuery";
            this.Text = "CreditDebitUpdateQuery";
            this.Load += new System.EventHandler(this.CreditDebitUpdateQuery_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CreaditDebit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.DataGridView dgv_CreaditDebit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Query;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.CheckBox chk_selectall;
    }
}