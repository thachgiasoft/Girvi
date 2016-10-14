namespace JewelleryManagement.Common
{
    partial class Frm_CashInHandOpening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CashInHandOpening));
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.bttn_PrintReport = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.bttn_UpdateRecord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_OpeningBal = new System.Windows.Forms.TextBox();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.Controls.Add(this.bttn_UpdateRecord);
            this.pnl_Bottom.Controls.Add(this.bttn_PrintReport);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 105);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(278, 38);
            this.pnl_Bottom.TabIndex = 101;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(278, 38);
            this.pnl_Header.TabIndex = 100;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(120, 7);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 360;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(167, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // bttn_PrintReport
            // 
            this.bttn_PrintReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_PrintReport.BackgroundImage")));
            this.bttn_PrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_PrintReport.FlatAppearance.BorderSize = 0;
            this.bttn_PrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_PrintReport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_PrintReport.ForeColor = System.Drawing.Color.White;
            this.bttn_PrintReport.Location = new System.Drawing.Point(709, 6);
            this.bttn_PrintReport.Name = "bttn_PrintReport";
            this.bttn_PrintReport.Size = new System.Drawing.Size(89, 23);
            this.bttn_PrintReport.TabIndex = 275;
            this.bttn_PrintReport.Text = " PRINT \r\nREPORT";
            this.bttn_PrintReport.UseVisualStyleBackColor = true;
            // 
            // bttn_Close
            // 
            this.bttn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Close.BackgroundImage")));
            this.bttn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Close.FlatAppearance.BorderSize = 0;
            this.bttn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Close.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Close.ForeColor = System.Drawing.Color.White;
            this.bttn_Close.Location = new System.Drawing.Point(202, 5);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            // 
            // bttn_UpdateRecord
            // 
            this.bttn_UpdateRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_UpdateRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_UpdateRecord.BackgroundImage")));
            this.bttn_UpdateRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_UpdateRecord.FlatAppearance.BorderSize = 0;
            this.bttn_UpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_UpdateRecord.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_UpdateRecord.ForeColor = System.Drawing.Color.White;
            this.bttn_UpdateRecord.Location = new System.Drawing.Point(93, 5);
            this.bttn_UpdateRecord.Name = "bttn_UpdateRecord";
            this.bttn_UpdateRecord.Size = new System.Drawing.Size(98, 28);
            this.bttn_UpdateRecord.TabIndex = 361;
            this.bttn_UpdateRecord.Text = "Save";
            this.bttn_UpdateRecord.UseVisualStyleBackColor = true;
            this.bttn_UpdateRecord.Click += new System.EventHandler(this.bttn_UpdateRecord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 330;
            this.label2.Text = "Opening Balance";
            // 
            // txt_OpeningBal
            // 
            this.txt_OpeningBal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OpeningBal.Location = new System.Drawing.Point(125, 54);
            this.txt_OpeningBal.Name = "txt_OpeningBal";
            this.txt_OpeningBal.Size = new System.Drawing.Size(143, 23);
            this.txt_OpeningBal.TabIndex = 329;
            // 
            // Frm_CashInHandOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 143);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_OpeningBal);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_CashInHandOpening";
            this.Text = "Frm_CashInHandOpening";
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_PrintReport;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button bttn_UpdateRecord;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OpeningBal;
    }
}