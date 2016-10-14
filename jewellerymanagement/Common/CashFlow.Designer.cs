namespace JwelleryManagement.Common
{
    partial class CashFlow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCr = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCr = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdr = new System.Windows.Forms.DataGridView();
            this.DateDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 44);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Debit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Credit";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblDr);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTotalCr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 36);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Amount";
            // 
            // lblDr
            // 
            this.lblDr.AutoSize = true;
            this.lblDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDr.ForeColor = System.Drawing.Color.Red;
            this.lblDr.Location = new System.Drawing.Point(519, 3);
            this.lblDr.Name = "lblDr";
            this.lblDr.Size = new System.Drawing.Size(60, 24);
            this.lblDr.TabIndex = 2;
            this.lblDr.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Amount";
            // 
            // lblTotalCr
            // 
            this.lblTotalCr.AutoSize = true;
            this.lblTotalCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCr.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCr.Location = new System.Drawing.Point(223, 6);
            this.lblTotalCr.Name = "lblTotalCr";
            this.lblTotalCr.Size = new System.Drawing.Size(60, 24);
            this.lblTotalCr.TabIndex = 0;
            this.lblTotalCr.Text = "label1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCr);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvdr);
            this.splitContainer1.Size = new System.Drawing.Size(939, 504);
            this.splitContainer1.SplitterDistance = 441;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvCr
            // 
            this.dgvCr.AllowUserToAddRows = false;
            this.dgvCr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Credit,
            this.CName});
            this.dgvCr.Location = new System.Drawing.Point(12, 47);
            this.dgvCr.Name = "dgvCr";
            this.dgvCr.Size = new System.Drawing.Size(427, 421);
            this.dgvCr.TabIndex = 0;
            this.dgvCr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCr_MouseClick);
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
            // CName
            // 
            this.CName.HeaderText = "Creditor Name";
            this.CName.Name = "CName";
            // 
            // dgvdr
            // 
            this.dgvdr.AllowUserToAddRows = false;
            this.dgvdr.AllowUserToDeleteRows = false;
            this.dgvdr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateDebit,
            this.Debit,
            this.DName});
            this.dgvdr.Location = new System.Drawing.Point(0, 50);
            this.dgvdr.Name = "dgvdr";
            this.dgvdr.Size = new System.Drawing.Size(494, 418);
            this.dgvdr.TabIndex = 0;
            this.dgvdr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvdr_MouseClick);
            // 
            // DateDebit
            // 
            this.DateDebit.HeaderText = "Date";
            this.DateDebit.Name = "DateDebit";
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            // 
            // DName
            // 
            this.DName.HeaderText = "Debit Name";
            this.DName.Name = "DName";
            // 
            // CashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashFlow";
            this.Load += new System.EventHandler(this.CashFlow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCr;
        private System.Windows.Forms.DataGridView dgvdr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
    }
}