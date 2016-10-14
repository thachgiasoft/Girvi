namespace JewelleryManagement.Common.Sql
{
    partial class Frm_DatabaseBackup
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
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbackup = new System.Windows.Forms.Button();
            this.ComboBoxDatabaseName = new System.Windows.Forms.ComboBox();
            this.lbl_DatabaseName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "Bakup files (*.Bak)|*.Bak";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = "Bakup files (*.Bak)|*.Bak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(349, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "label3";
            // 
            // cmbbackup
            // 
            this.cmbbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbackup.Location = new System.Drawing.Point(31, 86);
            this.cmbbackup.Name = "cmbbackup";
            this.cmbbackup.Size = new System.Drawing.Size(288, 32);
            this.cmbbackup.TabIndex = 30;
            this.cmbbackup.Text = "BackUp";
            this.cmbbackup.UseVisualStyleBackColor = true;
            this.cmbbackup.Click += new System.EventHandler(this.cmbbackup_Click_1);
            // 
            // ComboBoxDatabaseName
            // 
            this.ComboBoxDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDatabaseName.FormattingEnabled = true;
            this.ComboBoxDatabaseName.Location = new System.Drawing.Point(407, 28);
            this.ComboBoxDatabaseName.Name = "ComboBoxDatabaseName";
            this.ComboBoxDatabaseName.Size = new System.Drawing.Size(223, 24);
            this.ComboBoxDatabaseName.TabIndex = 25;
            this.ComboBoxDatabaseName.Visible = false;
            // 
            // lbl_DatabaseName
            // 
            this.lbl_DatabaseName.AutoSize = true;
            this.lbl_DatabaseName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatabaseName.Location = new System.Drawing.Point(159, 46);
            this.lbl_DatabaseName.Name = "lbl_DatabaseName";
            this.lbl_DatabaseName.Size = new System.Drawing.Size(47, 15);
            this.lbl_DatabaseName.TabIndex = 31;
            this.lbl_DatabaseName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Database Name :";
            // 
            // Frm_DatabaseBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DatabaseName);
            this.Controls.Add(this.cmbbackup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxDatabaseName);
            this.Name = "Frm_DatabaseBackup";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmbbackup;
        public System.Windows.Forms.ComboBox ComboBoxDatabaseName;
        private System.Windows.Forms.Label lbl_DatabaseName;
        private System.Windows.Forms.Label label1;
    }
}

