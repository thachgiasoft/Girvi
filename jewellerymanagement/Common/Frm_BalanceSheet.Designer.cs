namespace JewelleryManagement.Common
{
    partial class Frm_BalanceSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BalanceSheet));
            this.button3 = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btn_cashFlowclose = new System.Windows.Forms.Button();
            this.dgv_liabilities = new System.Windows.Forms.DataGridView();
            this.ParticularLiabilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountLiabilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount2Liabilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_assets = new System.Windows.Forms.DataGridView();
            this.ParticularAssets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountAssets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lbl_lib = new System.Windows.Forms.Label();
            this.lbl_assets = new System.Windows.Forms.Label();
            this.lbl_TotalLiabilities = new System.Windows.Forms.Label();
            this.lbl_TotalAssets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liabilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assets)).BeginInit();
            this.SuspendLayout();
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
            this.button3.Location = new System.Drawing.Point(106, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 30);
            this.button3.TabIndex = 281;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnshow
            // 
            this.btnshow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshow.BackgroundImage")));
            this.btnshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.Location = new System.Drawing.Point(14, 36);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(86, 31);
            this.btnshow.TabIndex = 280;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btn_cashFlowclose
            // 
            this.btn_cashFlowclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cashFlowclose.BackgroundImage")));
            this.btn_cashFlowclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cashFlowclose.FlatAppearance.BorderSize = 0;
            this.btn_cashFlowclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cashFlowclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashFlowclose.ForeColor = System.Drawing.Color.White;
            this.btn_cashFlowclose.Location = new System.Drawing.Point(611, 522);
            this.btn_cashFlowclose.Name = "btn_cashFlowclose";
            this.btn_cashFlowclose.Size = new System.Drawing.Size(86, 29);
            this.btn_cashFlowclose.TabIndex = 324;
            this.btn_cashFlowclose.Text = "Close";
            this.btn_cashFlowclose.UseVisualStyleBackColor = true;
            // 
            // dgv_liabilities
            // 
            this.dgv_liabilities.AllowUserToAddRows = false;
            this.dgv_liabilities.AllowUserToDeleteRows = false;
            this.dgv_liabilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liabilities.BackgroundColor = System.Drawing.Color.White;
            this.dgv_liabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liabilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParticularLiabilities,
            this.AmountLiabilities,
            this.Amount2Liabilities});
            this.dgv_liabilities.Location = new System.Drawing.Point(14, 120);
            this.dgv_liabilities.Name = "dgv_liabilities";
            this.dgv_liabilities.ReadOnly = true;
            this.dgv_liabilities.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_liabilities.Size = new System.Drawing.Size(639, 396);
            this.dgv_liabilities.TabIndex = 325;
            // 
            // ParticularLiabilities
            // 
            this.ParticularLiabilities.HeaderText = "Particular";
            this.ParticularLiabilities.Name = "ParticularLiabilities";
            this.ParticularLiabilities.ReadOnly = true;
            // 
            // AmountLiabilities
            // 
            this.AmountLiabilities.HeaderText = "Amount";
            this.AmountLiabilities.Name = "AmountLiabilities";
            this.AmountLiabilities.ReadOnly = true;
            // 
            // Amount2Liabilities
            // 
            this.Amount2Liabilities.HeaderText = "Amount";
            this.Amount2Liabilities.Name = "Amount2Liabilities";
            this.Amount2Liabilities.ReadOnly = true;
            // 
            // dgv_assets
            // 
            this.dgv_assets.AllowUserToAddRows = false;
            this.dgv_assets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_assets.BackgroundColor = System.Drawing.Color.White;
            this.dgv_assets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_assets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParticularAssets,
            this.AmountAssets});
            this.dgv_assets.Location = new System.Drawing.Point(657, 120);
            this.dgv_assets.Name = "dgv_assets";
            this.dgv_assets.Size = new System.Drawing.Size(558, 396);
            this.dgv_assets.TabIndex = 326;
            // 
            // ParticularAssets
            // 
            this.ParticularAssets.HeaderText = "Particular";
            this.ParticularAssets.Name = "ParticularAssets";
            // 
            // AmountAssets
            // 
            this.AmountAssets.HeaderText = "Amount";
            this.AmountAssets.Name = "AmountAssets";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(14, 82);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(634, 29);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.SeaShell;
            this.rectangleShape3.FillColor = System.Drawing.Color.Maroon;
            this.rectangleShape3.Location = new System.Drawing.Point(656, 82);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(557, 29);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1225, 570);
            this.shapeContainer1.TabIndex = 327;
            this.shapeContainer1.TabStop = false;
            // 
            // lbl_lib
            // 
            this.lbl_lib.AutoSize = true;
            this.lbl_lib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lib.ForeColor = System.Drawing.Color.White;
            this.lbl_lib.Location = new System.Drawing.Point(280, 90);
            this.lbl_lib.Name = "lbl_lib";
            this.lbl_lib.Size = new System.Drawing.Size(77, 13);
            this.lbl_lib.TabIndex = 329;
            this.lbl_lib.Text = "LIABILITIES";
            // 
            // lbl_assets
            // 
            this.lbl_assets.AutoSize = true;
            this.lbl_assets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assets.ForeColor = System.Drawing.Color.White;
            this.lbl_assets.Location = new System.Drawing.Point(897, 90);
            this.lbl_assets.Name = "lbl_assets";
            this.lbl_assets.Size = new System.Drawing.Size(55, 13);
            this.lbl_assets.TabIndex = 328;
            this.lbl_assets.Text = "ASSETS";
            // 
            // lbl_TotalLiabilities
            // 
            this.lbl_TotalLiabilities.AutoSize = true;
            this.lbl_TotalLiabilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalLiabilities.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalLiabilities.Location = new System.Drawing.Point(280, 530);
            this.lbl_TotalLiabilities.Name = "lbl_TotalLiabilities";
            this.lbl_TotalLiabilities.Size = new System.Drawing.Size(93, 13);
            this.lbl_TotalLiabilities.TabIndex = 333;
            this.lbl_TotalLiabilities.Text = "Total Liabilities";
            // 
            // lbl_TotalAssets
            // 
            this.lbl_TotalAssets.AutoSize = true;
            this.lbl_TotalAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAssets.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalAssets.Location = new System.Drawing.Point(897, 530);
            this.lbl_TotalAssets.Name = "lbl_TotalAssets";
            this.lbl_TotalAssets.Size = new System.Drawing.Size(77, 13);
            this.lbl_TotalAssets.TabIndex = 332;
            this.lbl_TotalAssets.Text = "Total Assets";
            // 
            // Frm_BalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1225, 570);
            this.Controls.Add(this.lbl_TotalLiabilities);
            this.Controls.Add(this.lbl_TotalAssets);
            this.Controls.Add(this.lbl_lib);
            this.Controls.Add(this.lbl_assets);
            this.Controls.Add(this.dgv_assets);
            this.Controls.Add(this.dgv_liabilities);
            this.Controls.Add(this.btn_cashFlowclose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Frm_BalanceSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BalanceSheet";
            this.Load += new System.EventHandler(this.Frm_BalanceSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liabilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btn_cashFlowclose;
        private System.Windows.Forms.DataGridView dgv_liabilities;
        private System.Windows.Forms.DataGridView dgv_assets;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lbl_lib;
        private System.Windows.Forms.Label lbl_assets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticularAssets;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountAssets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticularLiabilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountLiabilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount2Liabilities;
        private System.Windows.Forms.Label lbl_TotalLiabilities;
        private System.Windows.Forms.Label lbl_TotalAssets;
    }
}