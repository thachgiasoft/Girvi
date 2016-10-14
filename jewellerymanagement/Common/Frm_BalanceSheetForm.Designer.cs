namespace JewelleryManagement.Common
{
    partial class Frm_BalanceSheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BalanceSheetForm));
            this.btnshow = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtMarathi = new System.Windows.Forms.RadioButton();
            this.rbtEnglish = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dgv_creditdebit = new System.Windows.Forms.DataGridView();
            this.namelib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountLib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAssets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountAssets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_assets = new System.Windows.Forms.Label();
            this.lbl_lib = new System.Windows.Forms.Label();
            this.dtpBalSheetEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_TrialBalance = new System.Windows.Forms.DataGridView();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTrialBalance = new System.Windows.Forms.Panel();
            this.btn_TrailBalclose = new System.Windows.Forms.Button();
            this.pnlCashFlow = new System.Windows.Forms.Panel();
            this.btn_cashFlowclose = new System.Windows.Forms.Button();
            this.LedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCashFlow = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_creditdebit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrialBalance)).BeginInit();
            this.pnlTrialBalance.SuspendLayout();
            this.pnlCashFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshow.BackgroundImage")));
            this.btnshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.Location = new System.Drawing.Point(33, 16);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(86, 31);
            this.btnshow.TabIndex = 279;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(33, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 30);
            this.button3.TabIndex = 279;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtMarathi);
            this.panel2.Controls.Add(this.rbtEnglish);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Location = new System.Drawing.Point(854, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 70);
            this.panel2.TabIndex = 294;
            this.panel2.Visible = false;
            // 
            // rbtMarathi
            // 
            this.rbtMarathi.AutoSize = true;
            this.rbtMarathi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMarathi.Location = new System.Drawing.Point(8, 36);
            this.rbtMarathi.Name = "rbtMarathi";
            this.rbtMarathi.Size = new System.Drawing.Size(63, 27);
            this.rbtMarathi.TabIndex = 133;
            this.rbtMarathi.Text = "मराठी";
            this.rbtMarathi.UseVisualStyleBackColor = true;
            // 
            // rbtEnglish
            // 
            this.rbtEnglish.AutoSize = true;
            this.rbtEnglish.Checked = true;
            this.rbtEnglish.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEnglish.Location = new System.Drawing.Point(8, 7);
            this.rbtEnglish.Name = "rbtEnglish";
            this.rbtEnglish.Size = new System.Drawing.Size(74, 23);
            this.rbtEnglish.TabIndex = 132;
            this.rbtEnglish.TabStop = true;
            this.rbtEnglish.Text = "English";
            this.rbtEnglish.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(230, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label27.Location = new System.Drawing.Point(302, 57);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(18, 22);
            this.label27.TabIndex = 131;
            this.label27.Text = "*";
            this.label27.Visible = false;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label28.Location = new System.Drawing.Point(302, 86);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(18, 22);
            this.label28.TabIndex = 130;
            this.label28.Text = "*";
            this.label28.Visible = false;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label29.Location = new System.Drawing.Point(302, 113);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 22);
            this.label29.TabIndex = 129;
            this.label29.Text = "*";
            this.label29.Visible = false;
            // 
            // dgv_creditdebit
            // 
            this.dgv_creditdebit.AllowUserToAddRows = false;
            this.dgv_creditdebit.AllowUserToDeleteRows = false;
            this.dgv_creditdebit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_creditdebit.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgv_creditdebit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_creditdebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_creditdebit.ColumnHeadersVisible = false;
            this.dgv_creditdebit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namelib,
            this.AmountLib,
            this.NameAssets,
            this.AmountAssets});
            this.dgv_creditdebit.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_creditdebit.Location = new System.Drawing.Point(33, 143);
            this.dgv_creditdebit.Name = "dgv_creditdebit";
            this.dgv_creditdebit.ReadOnly = true;
            this.dgv_creditdebit.Size = new System.Drawing.Size(950, 333);
            this.dgv_creditdebit.TabIndex = 316;
            this.dgv_creditdebit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_creditdebit_CellClick);
            // 
            // namelib
            // 
            this.namelib.HeaderText = "Name";
            this.namelib.Name = "namelib";
            this.namelib.ReadOnly = true;
            // 
            // AmountLib
            // 
            this.AmountLib.HeaderText = "Amount";
            this.AmountLib.Name = "AmountLib";
            this.AmountLib.ReadOnly = true;
            // 
            // NameAssets
            // 
            this.NameAssets.HeaderText = "Name";
            this.NameAssets.Name = "NameAssets";
            this.NameAssets.ReadOnly = true;
            // 
            // AmountAssets
            // 
            this.AmountAssets.HeaderText = "Amount";
            this.AmountAssets.Name = "AmountAssets";
            this.AmountAssets.ReadOnly = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1014, 505);
            this.shapeContainer1.TabIndex = 317;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.SeaShell;
            this.rectangleShape3.FillColor = System.Drawing.Color.Maroon;
            this.rectangleShape3.Location = new System.Drawing.Point(529, 101);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(453, 34);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(261, 235);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(492, 34);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(31, 101);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(492, 34);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 514;
            this.lineShape1.X2 = 515;
            this.lineShape1.Y1 = 149;
            this.lineShape1.Y2 = 463;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(525, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 336);
            this.panel3.TabIndex = 318;
            // 
            // lbl_assets
            // 
            this.lbl_assets.AutoSize = true;
            this.lbl_assets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assets.ForeColor = System.Drawing.Color.White;
            this.lbl_assets.Location = new System.Drawing.Point(727, 111);
            this.lbl_assets.Name = "lbl_assets";
            this.lbl_assets.Size = new System.Drawing.Size(55, 13);
            this.lbl_assets.TabIndex = 319;
            this.lbl_assets.Text = "ASSETS";
            // 
            // lbl_lib
            // 
            this.lbl_lib.AutoSize = true;
            this.lbl_lib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lib.ForeColor = System.Drawing.Color.White;
            this.lbl_lib.Location = new System.Drawing.Point(230, 111);
            this.lbl_lib.Name = "lbl_lib";
            this.lbl_lib.Size = new System.Drawing.Size(77, 13);
            this.lbl_lib.TabIndex = 320;
            this.lbl_lib.Text = "LIABILITIES";
            // 
            // dtpBalSheetEndDate
            // 
            this.dtpBalSheetEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBalSheetEndDate.Location = new System.Drawing.Point(125, 60);
            this.dtpBalSheetEndDate.Name = "dtpBalSheetEndDate";
            this.dtpBalSheetEndDate.Size = new System.Drawing.Size(142, 20);
            this.dtpBalSheetEndDate.TabIndex = 321;
            // 
            // dgv_TrialBalance
            // 
            this.dgv_TrialBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TrialBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Particulars,
            this.Debit,
            this.Credit});
            this.dgv_TrialBalance.Location = new System.Drawing.Point(3, 3);
            this.dgv_TrialBalance.Name = "dgv_TrialBalance";
            this.dgv_TrialBalance.Size = new System.Drawing.Size(944, 296);
            this.dgv_TrialBalance.TabIndex = 322;
            this.dgv_TrialBalance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TrialBalance_CellClick);
            // 
            // Particulars
            // 
            this.Particulars.HeaderText = "Particular";
            this.Particulars.Name = "Particulars";
            this.Particulars.Width = 300;
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.Width = 300;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.Width = 300;
            // 
            // pnlTrialBalance
            // 
            this.pnlTrialBalance.Controls.Add(this.btn_TrailBalclose);
            this.pnlTrialBalance.Controls.Add(this.dgv_TrialBalance);
            this.pnlTrialBalance.Location = new System.Drawing.Point(33, 140);
            this.pnlTrialBalance.Name = "pnlTrialBalance";
            this.pnlTrialBalance.Size = new System.Drawing.Size(953, 347);
            this.pnlTrialBalance.TabIndex = 324;
            // 
            // btn_TrailBalclose
            // 
            this.btn_TrailBalclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TrailBalclose.BackgroundImage")));
            this.btn_TrailBalclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrailBalclose.FlatAppearance.BorderSize = 0;
            this.btn_TrailBalclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrailBalclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrailBalclose.ForeColor = System.Drawing.Color.White;
            this.btn_TrailBalclose.Location = new System.Drawing.Point(411, 305);
            this.btn_TrailBalclose.Name = "btn_TrailBalclose";
            this.btn_TrailBalclose.Size = new System.Drawing.Size(86, 31);
            this.btn_TrailBalclose.TabIndex = 325;
            this.btn_TrailBalclose.Text = "Close";
            this.btn_TrailBalclose.UseVisualStyleBackColor = true;
            this.btn_TrailBalclose.Click += new System.EventHandler(this.btn_TrailBalclose_Click);
            // 
            // pnlCashFlow
            // 
            this.pnlCashFlow.Controls.Add(this.btn_cashFlowclose);
            this.pnlCashFlow.Controls.Add(this.dgvCashFlow);
            this.pnlCashFlow.Location = new System.Drawing.Point(33, 140);
            this.pnlCashFlow.Name = "pnlCashFlow";
            this.pnlCashFlow.Size = new System.Drawing.Size(950, 347);
            this.pnlCashFlow.TabIndex = 325;
            // 
            // btn_cashFlowclose
            // 
            this.btn_cashFlowclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cashFlowclose.BackgroundImage")));
            this.btn_cashFlowclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cashFlowclose.FlatAppearance.BorderSize = 0;
            this.btn_cashFlowclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cashFlowclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashFlowclose.ForeColor = System.Drawing.Color.White;
            this.btn_cashFlowclose.Location = new System.Drawing.Point(439, 307);
            this.btn_cashFlowclose.Name = "btn_cashFlowclose";
            this.btn_cashFlowclose.Size = new System.Drawing.Size(86, 29);
            this.btn_cashFlowclose.TabIndex = 323;
            this.btn_cashFlowclose.Text = "Close";
            this.btn_cashFlowclose.UseVisualStyleBackColor = true;
            this.btn_cashFlowclose.Click += new System.EventHandler(this.btn_cashFlowclose_Click);
            // 
            // LedgerId
            // 
            this.LedgerId.HeaderText = "LedgerID";
            this.LedgerId.Name = "LedgerId";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Credit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Debit";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // opening
            // 
            this.opening.HeaderText = "opening";
            this.opening.Name = "opening";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Particular";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dgvCashFlow
            // 
            this.dgvCashFlow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCashFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashFlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.opening,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.LedgerId});
            this.dgvCashFlow.Location = new System.Drawing.Point(0, 3);
            this.dgvCashFlow.Name = "dgvCashFlow";
            this.dgvCashFlow.Size = new System.Drawing.Size(953, 296);
            this.dgvCashFlow.TabIndex = 322;
            this.dgvCashFlow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashFlow_CellClick);
            // 
            // Frm_BalanceSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1014, 505);
            this.Controls.Add(this.pnlCashFlow);
            this.Controls.Add(this.dtpBalSheetEndDate);
            this.Controls.Add(this.lbl_lib);
            this.Controls.Add(this.lbl_assets);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.dgv_creditdebit);
            this.Controls.Add(this.pnlTrialBalance);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frm_BalanceSheetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrediDebit";
            this.Load += new System.EventHandler(this.CrediDebit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CrediDebit_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_creditdebit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrialBalance)).EndInit();
            this.pnlTrialBalance.ResumeLayout(false);
            this.pnlCashFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashFlow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // private Mortgage.Dataset_GirviReportDataset dataset_GirviReportDataset1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton rbtMarathi;
        public System.Windows.Forms.RadioButton rbtEnglish;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView dgv_creditdebit;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn namelib;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountLib;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAssets;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountAssets;
        private System.Windows.Forms.Label lbl_assets;
        private System.Windows.Forms.Label lbl_lib;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.DateTimePicker dtpBalSheetEndDate;
        private System.Windows.Forms.DataGridView dgv_TrialBalance;
        private System.Windows.Forms.Panel pnlTrialBalance;
        private System.Windows.Forms.Panel pnlCashFlow;
        private System.Windows.Forms.Button btn_TrailBalclose;
        private System.Windows.Forms.Button btn_cashFlowclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridView dgvCashFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn opening;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn LedgerId;
    }
}