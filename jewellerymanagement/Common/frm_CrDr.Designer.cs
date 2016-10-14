namespace JewelleryManagement.Common
{
    partial class frm_AccountDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AccountDetail));
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lbl_Cr = new System.Windows.Forms.Label();
            this.lbl_Dr = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dgv_Credit = new System.Windows.Forms.DataGridView();
            this.CrDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Debit = new System.Windows.Forms.DataGridView();
            this.DrDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Debit)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(2, 36);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(370, 34);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.SeaShell;
            this.rectangleShape3.FillColor = System.Drawing.Color.Maroon;
            this.rectangleShape3.Location = new System.Drawing.Point(379, 37);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(343, 34);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(726, 437);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lbl_Cr
            // 
            this.lbl_Cr.AutoSize = true;
            this.lbl_Cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cr.ForeColor = System.Drawing.Color.Black;
            this.lbl_Cr.Location = new System.Drawing.Point(542, 50);
            this.lbl_Cr.Name = "lbl_Cr";
            this.lbl_Cr.Size = new System.Drawing.Size(53, 13);
            this.lbl_Cr.TabIndex = 327;
            this.lbl_Cr.Text = "CREDIT";
            // 
            // lbl_Dr
            // 
            this.lbl_Dr.AutoSize = true;
            this.lbl_Dr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dr.ForeColor = System.Drawing.Color.Black;
            this.lbl_Dr.Location = new System.Drawing.Point(137, 50);
            this.lbl_Dr.Name = "lbl_Dr";
            this.lbl_Dr.Size = new System.Drawing.Size(44, 13);
            this.lbl_Dr.TabIndex = 328;
            this.lbl_Dr.Text = "DEBIT";
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
            this.pnl_Header.Size = new System.Drawing.Size(726, 32);
            this.pnl_Header.TabIndex = 329;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(526, 7);
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
            this.dtp_Date.Location = new System.Drawing.Point(581, 2);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(139, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // dgv_Credit
            // 
            this.dgv_Credit.AllowUserToAddRows = false;
            this.dgv_Credit.AllowUserToDeleteRows = false;
            this.dgv_Credit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Credit.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Credit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Credit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CrDate,
            this.CrAmount});
            this.dgv_Credit.Location = new System.Drawing.Point(3, 74);
            this.dgv_Credit.Name = "dgv_Credit";
            this.dgv_Credit.ReadOnly = true;
            this.dgv_Credit.Size = new System.Drawing.Size(370, 322);
            this.dgv_Credit.TabIndex = 330;
            // 
            // CrDate
            // 
            this.CrDate.HeaderText = "Date";
            this.CrDate.Name = "CrDate";
            this.CrDate.ReadOnly = true;
            // 
            // CrAmount
            // 
            this.CrAmount.HeaderText = "Amount";
            this.CrAmount.Name = "CrAmount";
            this.CrAmount.ReadOnly = true;
            // 
            // dgv_Debit
            // 
            this.dgv_Debit.AllowUserToAddRows = false;
            this.dgv_Debit.AllowUserToDeleteRows = false;
            this.dgv_Debit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Debit.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Debit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Debit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrDate,
            this.DrAmount});
            this.dgv_Debit.Location = new System.Drawing.Point(379, 74);
            this.dgv_Debit.Name = "dgv_Debit";
            this.dgv_Debit.ReadOnly = true;
            this.dgv_Debit.Size = new System.Drawing.Size(344, 322);
            this.dgv_Debit.TabIndex = 331;
            // 
            // DrDate
            // 
            this.DrDate.HeaderText = "Date";
            this.DrDate.Name = "DrDate";
            this.DrDate.ReadOnly = true;
            // 
            // DrAmount
            // 
            this.DrAmount.HeaderText = "Amount";
            this.DrAmount.Name = "DrAmount";
            this.DrAmount.ReadOnly = true;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.label1);
            this.pnl_Bottom.Controls.Add(this.lbl_Total);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 402);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(726, 35);
            this.pnl_Bottom.TabIndex = 332;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 330;
            this.label1.Text = "Balance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(318, 11);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(36, 13);
            this.lbl_Total.TabIndex = 329;
            this.lbl_Total.Text = "Total";
            this.lbl_Total.Click += new System.EventHandler(this.lbl_Total_Click);
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
            this.bttn_Close.Location = new System.Drawing.Point(615, 4);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(99, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // frm_AccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 437);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.dgv_Debit);
            this.Controls.Add(this.dgv_Credit);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.lbl_Dr);
            this.Controls.Add(this.lbl_Cr);
            this.Controls.Add(this.shapeContainer1);
            this.KeyPreview = true;
            this.Name = "frm_AccountDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account  Detail";
            this.Load += new System.EventHandler(this.frm_AccountDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_AccountDetail_KeyDown);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Debit)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lbl_Cr;
        private System.Windows.Forms.Label lbl_Dr;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DataGridView dgv_Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrAmount;
        private System.Windows.Forms.DataGridView dgv_Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrAmount;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label1;
    }
}