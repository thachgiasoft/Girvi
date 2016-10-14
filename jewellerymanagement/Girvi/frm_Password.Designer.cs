namespace JewelleryManagement.Girvi
{
    partial class frm_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Password));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Girvi = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.bttn_login = new System.Windows.Forms.Button();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Controls.Add(this.lbl_Girvi);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(323, 32);
            this.pnl_Header.TabIndex = 75;
            // 
            // lbl_Girvi
            // 
            this.lbl_Girvi.AutoSize = true;
            this.lbl_Girvi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Girvi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Girvi.Location = new System.Drawing.Point(117, 9);
            this.lbl_Girvi.Name = "lbl_Girvi";
            this.lbl_Girvi.Size = new System.Drawing.Size(48, 16);
            this.lbl_Girvi.TabIndex = 0;
            this.lbl_Girvi.Text = " GIRVI";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(129, 54);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(179, 23);
            this.txt_Password.TabIndex = 264;
            this.txt_Password.Enter += new System.EventHandler(this.txt_Password_Enter);
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(21, 52);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(86, 23);
            this.lbl_Password.TabIndex = 265;
            this.lbl_Password.Text = "Password";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Controls.Add(this.bttn_login);
            this.pnl_Bottom.Controls.Add(this.bttn_Reset);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 100);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(323, 32);
            this.pnl_Bottom.TabIndex = 266;
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
            this.bttn_Close.Location = new System.Drawing.Point(246, 2);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 27);
            this.bttn_Close.TabIndex = 371;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // bttn_login
            // 
            this.bttn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_login.BackgroundImage")));
            this.bttn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_login.FlatAppearance.BorderSize = 0;
            this.bttn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_login.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_login.ForeColor = System.Drawing.Color.White;
            this.bttn_login.Location = new System.Drawing.Point(36, 2);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(71, 28);
            this.bttn_login.TabIndex = 370;
            this.bttn_login.Text = "Ok";
            this.bttn_login.UseVisualStyleBackColor = true;
            this.bttn_login.Click += new System.EventHandler(this.bttn_Ok_Click);
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(142, 4);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(71, 25);
            this.bttn_Reset.TabIndex = 369;
            this.bttn_Reset.Text = "RESET";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            this.bttn_Reset.Click += new System.EventHandler(this.bttn_Reset_Click);
            // 
            // frm_Password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(323, 132);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.pnl_Header);
            this.KeyPreview = true;
            this.Name = "frm_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.Load += new System.EventHandler(this.frm_Password_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Password_KeyDown);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Girvi;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.Button bttn_login;
        private System.Windows.Forms.Button bttn_Close;
    }
}