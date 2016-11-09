namespace JewelleryManagement.Common
{
    partial class Frm_ProfitLoss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProfitLoss));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Show = new System.Windows.Forms.Button();
            this.bttn_Print = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.dgv_Expence = new System.Windows.Forms.DataGridView();
            this.DeParticular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            //this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            //this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lbl_Expences = new System.Windows.Forms.Label();
            this.lbl_Income = new System.Windows.Forms.Label();
            this.dgv_Income = new System.Windows.Forms.DataGridView();
            this.DiParticular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TotalExpences = new System.Windows.Forms.Label();
            this.lbl_TotalIncome = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Income)).BeginInit();
            this.SuspendLayout();
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
            this.pnl_Header.Size = new System.Drawing.Size(986, 32);
            this.pnl_Header.TabIndex = 75;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(786, 7);
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
            this.dtp_Date.Location = new System.Drawing.Point(841, 2);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(139, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Show);
            this.pnl_Bottom.Controls.Add(this.bttn_Print);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 431);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(986, 35);
            this.pnl_Bottom.TabIndex = 78;
            // 
            // bttn_Show
            // 
            this.bttn_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Show.BackgroundImage")));
            this.bttn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Show.FlatAppearance.BorderSize = 0;
            this.bttn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Show.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Show.ForeColor = System.Drawing.Color.White;
            this.bttn_Show.Location = new System.Drawing.Point(658, 4);
            this.bttn_Show.Name = "bttn_Show";
            this.bttn_Show.Size = new System.Drawing.Size(100, 28);
            this.bttn_Show.TabIndex = 228;
            this.bttn_Show.Text = "Show";
            this.bttn_Show.UseVisualStyleBackColor = true;
            this.bttn_Show.Click += new System.EventHandler(this.bttn_Show_Click);
            // 
            // bttn_Print
            // 
            this.bttn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Print.BackgroundImage")));
            this.bttn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Print.FlatAppearance.BorderSize = 0;
            this.bttn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Print.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Print.ForeColor = System.Drawing.Color.White;
            this.bttn_Print.Location = new System.Drawing.Point(773, 4);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(100, 28);
            this.bttn_Print.TabIndex = 227;
            this.bttn_Print.Text = "PRINT";
            this.bttn_Print.UseVisualStyleBackColor = true;
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
            this.bttn_Close.Location = new System.Drawing.Point(881, 4);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(99, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // dgv_Expence
            // 
            this.dgv_Expence.AllowUserToAddRows = false;
            this.dgv_Expence.AllowUserToDeleteRows = false;
            this.dgv_Expence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Expence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeParticular,
            this.DeAmount});
            this.dgv_Expence.Location = new System.Drawing.Point(3, 86);
            this.dgv_Expence.Name = "dgv_Expence";
            this.dgv_Expence.ReadOnly = true;
            this.dgv_Expence.Size = new System.Drawing.Size(501, 309);
            this.dgv_Expence.TabIndex = 323;
            this.dgv_Expence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashFlow_CellContentClick);
            // 
            // DeParticular
            // 
            this.DeParticular.HeaderText = "Particular";
            this.DeParticular.Name = "DeParticular";
            this.DeParticular.ReadOnly = true;
            // 
            // DeAmount
            // 
            this.DeAmount.HeaderText = "Amount";
            this.DeAmount.Name = "DeAmount";
            this.DeAmount.ReadOnly = true;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(3, 44);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(492, 34);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.SeaShell;
            this.rectangleShape3.FillColor = System.Drawing.Color.Maroon;
            this.rectangleShape3.Location = new System.Drawing.Point(508, 44);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(464, 34);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(986, 466);
            this.shapeContainer1.TabIndex = 324;
            this.shapeContainer1.TabStop = false;
            // 
            // lbl_Expences
            // 
            this.lbl_Expences.AutoSize = true;
            this.lbl_Expences.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expences.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expences.Location = new System.Drawing.Point(206, 53);
            this.lbl_Expences.Name = "lbl_Expences";
            this.lbl_Expences.Size = new System.Drawing.Size(62, 13);
            this.lbl_Expences.TabIndex = 326;
            this.lbl_Expences.Text = "Expences";
            // 
            // lbl_Income
            // 
            this.lbl_Income.AutoSize = true;
            this.lbl_Income.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Income.ForeColor = System.Drawing.Color.Black;
            this.lbl_Income.Location = new System.Drawing.Point(703, 53);
            this.lbl_Income.Name = "lbl_Income";
            this.lbl_Income.Size = new System.Drawing.Size(48, 13);
            this.lbl_Income.TabIndex = 325;
            this.lbl_Income.Text = "Income";
            // 
            // dgv_Income
            // 
            this.dgv_Income.AllowUserToAddRows = false;
            this.dgv_Income.AllowUserToDeleteRows = false;
            this.dgv_Income.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Income.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiParticular,
            this.DiAmount});
            this.dgv_Income.Location = new System.Drawing.Point(509, 85);
            this.dgv_Income.Name = "dgv_Income";
            this.dgv_Income.ReadOnly = true;
            this.dgv_Income.Size = new System.Drawing.Size(463, 310);
            this.dgv_Income.TabIndex = 327;
            // 
            // DiParticular
            // 
            this.DiParticular.HeaderText = "Particular";
            this.DiParticular.Name = "DiParticular";
            this.DiParticular.ReadOnly = true;
            // 
            // DiAmount
            // 
            this.DiAmount.HeaderText = "Amount";
            this.DiAmount.Name = "DiAmount";
            this.DiAmount.ReadOnly = true;
            // 
            // lbl_TotalExpences
            // 
            this.lbl_TotalExpences.AutoSize = true;
            this.lbl_TotalExpences.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalExpences.ForeColor = System.Drawing.Color.Black;
            this.lbl_TotalExpences.Location = new System.Drawing.Point(368, 408);
            this.lbl_TotalExpences.Name = "lbl_TotalExpences";
            this.lbl_TotalExpences.Size = new System.Drawing.Size(91, 13);
            this.lbl_TotalExpences.TabIndex = 328;
            this.lbl_TotalExpences.Text = "TotalExpences";
            // 
            // lbl_TotalIncome
            // 
            this.lbl_TotalIncome.AutoSize = true;
            this.lbl_TotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalIncome.ForeColor = System.Drawing.Color.Black;
            this.lbl_TotalIncome.Location = new System.Drawing.Point(826, 408);
            this.lbl_TotalIncome.Name = "lbl_TotalIncome";
            this.lbl_TotalIncome.Size = new System.Drawing.Size(77, 13);
            this.lbl_TotalIncome.TabIndex = 329;
            this.lbl_TotalIncome.Text = "TotalIncome";
            // 
            // Frm_ProfitLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 466);
            this.Controls.Add(this.lbl_TotalIncome);
            this.Controls.Add(this.lbl_TotalExpences);
            this.Controls.Add(this.dgv_Income);
            this.Controls.Add(this.lbl_Expences);
            this.Controls.Add(this.lbl_Income);
            this.Controls.Add(this.dgv_Expence);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.shapeContainer1);
            this.KeyPreview = true;
            this.Name = "Frm_ProfitLoss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit/Loss";
            this.Load += new System.EventHandler(this.Frm_ProfitLoss_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ProfitLoss_KeyDown);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Income)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_Show;
        private System.Windows.Forms.Button bttn_Print;
        private System.Windows.Forms.DataGridView dgv_Expence;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lbl_Expences;
        private System.Windows.Forms.Label lbl_Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeParticular;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeAmount;
        private System.Windows.Forms.DataGridView dgv_Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiParticular;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiAmount;
        private System.Windows.Forms.Label lbl_TotalExpences;
        private System.Windows.Forms.Label lbl_TotalIncome;
    }
}