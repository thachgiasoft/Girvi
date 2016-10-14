namespace JewelleryManagement.Girvi
{
    partial class frm_ActualPayAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ActualPayAmount));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Ok = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.lbl_Interest = new System.Windows.Forms.Label();
            this.txt_InterestAmount = new System.Windows.Forms.TextBox();
            this.lbl_InterestAmount = new System.Windows.Forms.Label();
            this.txt_InterestInPer = new System.Windows.Forms.TextBox();
            this.lbl_InterestInPer = new System.Windows.Forms.Label();
            this.txt_LoanAmount = new System.Windows.Forms.TextBox();
            this.lbl_LoanAmount = new System.Windows.Forms.Label();
            this.txt_GirviNo = new System.Windows.Forms.TextBox();
            this.lbl_GirviNo = new System.Windows.Forms.Label();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(297, 38);
            this.pnl_Header.TabIndex = 269;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.Controls.Add(this.bttn_Ok);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 226);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(297, 38);
            this.pnl_Bottom.TabIndex = 271;
            // 
            // bttn_Ok
            // 
            this.bttn_Ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Ok.BackgroundImage")));
            this.bttn_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Ok.FlatAppearance.BorderSize = 0;
            this.bttn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Ok.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Ok.ForeColor = System.Drawing.Color.White;
            this.bttn_Ok.Location = new System.Drawing.Point(121, 7);
            this.bttn_Ok.Name = "bttn_Ok";
            this.bttn_Ok.Size = new System.Drawing.Size(71, 28);
            this.bttn_Ok.TabIndex = 231;
            this.bttn_Ok.Text = "Ok";
            this.bttn_Ok.UseVisualStyleBackColor = true;
            this.bttn_Ok.Click += new System.EventHandler(this.bttn_Ok_Click);
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
            this.bttn_Close.Location = new System.Drawing.Point(217, 7);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 230;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.BackColor = System.Drawing.Color.White;
            this.txt_TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_TotalAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalAmount.ForeColor = System.Drawing.Color.Red;
            this.txt_TotalAmount.Location = new System.Drawing.Point(140, 190);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.ReadOnly = true;
            this.txt_TotalAmount.Size = new System.Drawing.Size(126, 24);
            this.txt_TotalAmount.TabIndex = 281;
            this.txt_TotalAmount.Enter += new System.EventHandler(this.txt_TotalAmount_Enter);
            // 
            // lbl_Interest
            // 
            this.lbl_Interest.AutoSize = true;
            this.lbl_Interest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Interest.ForeColor = System.Drawing.Color.Black;
            this.lbl_Interest.Location = new System.Drawing.Point(11, 193);
            this.lbl_Interest.Name = "lbl_Interest";
            this.lbl_Interest.Size = new System.Drawing.Size(99, 19);
            this.lbl_Interest.TabIndex = 280;
            this.lbl_Interest.Text = "TotalAmount";
            // 
            // txt_InterestAmount
            // 
            this.txt_InterestAmount.BackColor = System.Drawing.Color.White;
            this.txt_InterestAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_InterestAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InterestAmount.Location = new System.Drawing.Point(140, 155);
            this.txt_InterestAmount.Name = "txt_InterestAmount";
            this.txt_InterestAmount.ReadOnly = true;
            this.txt_InterestAmount.Size = new System.Drawing.Size(126, 20);
            this.txt_InterestAmount.TabIndex = 279;
            this.txt_InterestAmount.Enter += new System.EventHandler(this.txt_TotalAmount_Enter);
            // 
            // lbl_InterestAmount
            // 
            this.lbl_InterestAmount.AutoSize = true;
            this.lbl_InterestAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InterestAmount.ForeColor = System.Drawing.Color.Black;
            this.lbl_InterestAmount.Location = new System.Drawing.Point(11, 155);
            this.lbl_InterestAmount.Name = "lbl_InterestAmount";
            this.lbl_InterestAmount.Size = new System.Drawing.Size(122, 19);
            this.lbl_InterestAmount.TabIndex = 278;
            this.lbl_InterestAmount.Text = "Interset Amount";
            // 
            // txt_InterestInPer
            // 
            this.txt_InterestInPer.BackColor = System.Drawing.Color.White;
            this.txt_InterestInPer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_InterestInPer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InterestInPer.Location = new System.Drawing.Point(140, 121);
            this.txt_InterestInPer.Name = "txt_InterestInPer";
            this.txt_InterestInPer.Size = new System.Drawing.Size(126, 20);
            this.txt_InterestInPer.TabIndex = 277;
            this.txt_InterestInPer.TextChanged += new System.EventHandler(this.txt_InterestInPer_TextChanged);
            this.txt_InterestInPer.Enter += new System.EventHandler(this.txt_TotalAmount_Enter);
            // 
            // lbl_InterestInPer
            // 
            this.lbl_InterestInPer.AutoSize = true;
            this.lbl_InterestInPer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InterestInPer.ForeColor = System.Drawing.Color.Black;
            this.lbl_InterestInPer.Location = new System.Drawing.Point(12, 121);
            this.lbl_InterestInPer.Name = "lbl_InterestInPer";
            this.lbl_InterestInPer.Size = new System.Drawing.Size(95, 19);
            this.lbl_InterestInPer.TabIndex = 276;
            this.lbl_InterestInPer.Text = "Interest in %";
            // 
            // txt_LoanAmount
            // 
            this.txt_LoanAmount.BackColor = System.Drawing.Color.White;
            this.txt_LoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoanAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoanAmount.Location = new System.Drawing.Point(140, 86);
            this.txt_LoanAmount.Name = "txt_LoanAmount";
            this.txt_LoanAmount.ReadOnly = true;
            this.txt_LoanAmount.Size = new System.Drawing.Size(126, 20);
            this.txt_LoanAmount.TabIndex = 275;
            this.txt_LoanAmount.Enter += new System.EventHandler(this.txt_TotalAmount_Enter);
            // 
            // lbl_LoanAmount
            // 
            this.lbl_LoanAmount.AutoSize = true;
            this.lbl_LoanAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoanAmount.ForeColor = System.Drawing.Color.Black;
            this.lbl_LoanAmount.Location = new System.Drawing.Point(12, 87);
            this.lbl_LoanAmount.Name = "lbl_LoanAmount";
            this.lbl_LoanAmount.Size = new System.Drawing.Size(110, 19);
            this.lbl_LoanAmount.TabIndex = 274;
            this.lbl_LoanAmount.Text = "Loan  Amount ";
            // 
            // txt_GirviNo
            // 
            this.txt_GirviNo.BackColor = System.Drawing.Color.White;
            this.txt_GirviNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_GirviNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GirviNo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_GirviNo.Location = new System.Drawing.Point(140, 52);
            this.txt_GirviNo.Name = "txt_GirviNo";
            this.txt_GirviNo.ReadOnly = true;
            this.txt_GirviNo.Size = new System.Drawing.Size(126, 20);
            this.txt_GirviNo.TabIndex = 273;
            this.txt_GirviNo.Enter += new System.EventHandler(this.txt_TotalAmount_Enter);
            // 
            // lbl_GirviNo
            // 
            this.lbl_GirviNo.AutoSize = true;
            this.lbl_GirviNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GirviNo.ForeColor = System.Drawing.Color.Black;
            this.lbl_GirviNo.Location = new System.Drawing.Point(12, 52);
            this.lbl_GirviNo.Name = "lbl_GirviNo";
            this.lbl_GirviNo.Size = new System.Drawing.Size(65, 19);
            this.lbl_GirviNo.TabIndex = 272;
            this.lbl_GirviNo.Text = "Girvi No";
            // 
            // frm_ActualPayAmount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(297, 264);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.lbl_Interest);
            this.Controls.Add(this.txt_InterestAmount);
            this.Controls.Add(this.lbl_InterestAmount);
            this.Controls.Add(this.txt_InterestInPer);
            this.Controls.Add(this.lbl_InterestInPer);
            this.Controls.Add(this.txt_LoanAmount);
            this.Controls.Add(this.lbl_LoanAmount);
            this.Controls.Add(this.txt_GirviNo);
            this.Controls.Add(this.lbl_GirviNo);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_ActualPayAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actual Pay Amount";
            this.Load += new System.EventHandler(this.frm_ActualPayAmount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ActualPayAmount_KeyDown);
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Ok;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.Label lbl_Interest;
        private System.Windows.Forms.TextBox txt_InterestAmount;
        private System.Windows.Forms.Label lbl_InterestAmount;
        public System.Windows.Forms.TextBox txt_InterestInPer;
        private System.Windows.Forms.Label lbl_InterestInPer;
        private System.Windows.Forms.TextBox txt_LoanAmount;
        private System.Windows.Forms.Label lbl_LoanAmount;
        private System.Windows.Forms.TextBox txt_GirviNo;
        private System.Windows.Forms.Label lbl_GirviNo;
    }
}