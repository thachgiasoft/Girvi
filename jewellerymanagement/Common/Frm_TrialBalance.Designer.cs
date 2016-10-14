namespace JewelleryManagement.Common
{
    partial class Frm_TrialBalance
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
            this.dgv_TrialBalance = new System.Windows.Forms.DataGridView();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrialBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TrialBalance
            // 
            this.dgv_TrialBalance.AllowUserToAddRows = false;
            this.dgv_TrialBalance.AllowUserToDeleteRows = false;
            this.dgv_TrialBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TrialBalance.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_TrialBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_TrialBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TrialBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Particulars,
            this.Opening,
            this.Debit,
            this.Credit,
            this.Balance});
            this.dgv_TrialBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TrialBalance.Location = new System.Drawing.Point(0, 0);
            this.dgv_TrialBalance.Name = "dgv_TrialBalance";
            this.dgv_TrialBalance.ReadOnly = true;
            this.dgv_TrialBalance.Size = new System.Drawing.Size(849, 416);
            this.dgv_TrialBalance.TabIndex = 344;
            // 
            // Particulars
            // 
            this.Particulars.HeaderText = "Particulars";
            this.Particulars.Name = "Particulars";
            this.Particulars.ReadOnly = true;
            // 
            // Opening
            // 
            this.Opening.HeaderText = "Opening";
            this.Opening.Name = "Opening";
            this.Opening.ReadOnly = true;
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // Frm_TrialBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(849, 416);
            this.Controls.Add(this.dgv_TrialBalance);
            this.KeyPreview = true;
            this.Name = "Frm_TrialBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trial Balance";
            this.Load += new System.EventHandler(this.Frm_TrialBalance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_TrialBalance_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrialBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TrialBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opening;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}