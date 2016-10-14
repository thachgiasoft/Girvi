namespace JewelleryManagement.Girvi
{
    partial class frm_GirviForword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GirviForword));
            this.lbl_GirviNumber = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_AmountNo = new System.Windows.Forms.Label();
            this.lbl_ContactNo = new System.Windows.Forms.Label();
            this.txt_AmountNo = new System.Windows.Forms.TextBox();
            this.txt_ContactNo = new System.Windows.Forms.TextBox();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Forword = new System.Windows.Forms.Button();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.rbt_Other = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.txt_GirviNo = new System.Windows.Forms.TextBox();
            this.txt_bankinterest = new System.Windows.Forms.TextBox();
            this.lbl_bankintrest = new System.Windows.Forms.Label();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_GirviNumber
            // 
            this.lbl_GirviNumber.AutoSize = true;
            this.lbl_GirviNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GirviNumber.Location = new System.Drawing.Point(63, 59);
            this.lbl_GirviNumber.Name = "lbl_GirviNumber";
            this.lbl_GirviNumber.Size = new System.Drawing.Size(59, 16);
            this.lbl_GirviNumber.TabIndex = 0;
            this.lbl_GirviNumber.Text = "Girvi No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(5, 106);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(129, 16);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Bank/Person Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(142, 102);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(230, 20);
            this.txt_Name.TabIndex = 3;
            this.txt_Name.Enter += new System.EventHandler(this.txt_Name_Enter);
            this.txt_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyDown);
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(34, 155);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(96, 16);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "Deposite Date";
            this.lbl_Date.Click += new System.EventHandler(this.lbl_Date_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(142, 150);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(230, 20);
            this.dtp_Date.TabIndex = 5;
            this.dtp_Date.Enter += new System.EventHandler(this.txt_ContactNo_Enter);
            this.dtp_Date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_Date_KeyDown);
            // 
            // lbl_AmountNo
            // 
            this.lbl_AmountNo.AutoSize = true;
            this.lbl_AmountNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AmountNo.Location = new System.Drawing.Point(69, 206);
            this.lbl_AmountNo.Name = "lbl_AmountNo";
            this.lbl_AmountNo.Size = new System.Drawing.Size(57, 16);
            this.lbl_AmountNo.TabIndex = 6;
            this.lbl_AmountNo.Text = "Amount";
            // 
            // lbl_ContactNo
            // 
            this.lbl_ContactNo.AutoSize = true;
            this.lbl_ContactNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContactNo.Location = new System.Drawing.Point(47, 251);
            this.lbl_ContactNo.Name = "lbl_ContactNo";
            this.lbl_ContactNo.Size = new System.Drawing.Size(77, 16);
            this.lbl_ContactNo.TabIndex = 7;
            this.lbl_ContactNo.Text = "Contact No";
            // 
            // txt_AmountNo
            // 
            this.txt_AmountNo.Location = new System.Drawing.Point(142, 204);
            this.txt_AmountNo.Name = "txt_AmountNo";
            this.txt_AmountNo.Size = new System.Drawing.Size(230, 20);
            this.txt_AmountNo.TabIndex = 8;
            this.txt_AmountNo.Enter += new System.EventHandler(this.txt_ContactNo_Enter);
            this.txt_AmountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AmountNo_KeyDown);
            // 
            // txt_ContactNo
            // 
            this.txt_ContactNo.Location = new System.Drawing.Point(142, 249);
            this.txt_ContactNo.Name = "txt_ContactNo";
            this.txt_ContactNo.Size = new System.Drawing.Size(230, 20);
            this.txt_ContactNo.TabIndex = 9;
            this.txt_ContactNo.Enter += new System.EventHandler(this.txt_ContactNo_Enter);
            this.txt_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ContactNo_KeyPress);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(427, 36);
            this.pnl_Header.TabIndex = 12;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.Controls.Add(this.bttn_Delete);
            this.pnl_Bottom.Controls.Add(this.bttn_Reset);
            this.pnl_Bottom.Controls.Add(this.bttn_Forword);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 332);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(427, 38);
            this.pnl_Bottom.TabIndex = 13;
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Delete.BackgroundImage")));
            this.bttn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Delete.FlatAppearance.BorderSize = 0;
            this.bttn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Delete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Delete.ForeColor = System.Drawing.Color.White;
            this.bttn_Delete.Location = new System.Drawing.Point(269, 5);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(99, 28);
            this.bttn_Delete.TabIndex = 228;
            this.bttn_Delete.Text = "Close";
            this.bttn_Delete.UseVisualStyleBackColor = false;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(142, 5);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(100, 28);
            this.bttn_Reset.TabIndex = 227;
            this.bttn_Reset.Text = "RESET";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            this.bttn_Reset.Click += new System.EventHandler(this.bttn_Reset_Click);
            // 
            // bttn_Forword
            // 
            this.bttn_Forword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Forword.BackgroundImage")));
            this.bttn_Forword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Forword.FlatAppearance.BorderSize = 0;
            this.bttn_Forword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Forword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Forword.ForeColor = System.Drawing.Color.White;
            this.bttn_Forword.Location = new System.Drawing.Point(21, 5);
            this.bttn_Forword.Name = "bttn_Forword";
            this.bttn_Forword.Size = new System.Drawing.Size(100, 28);
            this.bttn_Forword.TabIndex = 226;
            this.bttn_Forword.Text = "FORWARD";
            this.bttn_Forword.UseVisualStyleBackColor = true;
            this.bttn_Forword.Click += new System.EventHandler(this.bttn_Forword_Click);
            // 
            // pnl_Button
            // 
            this.pnl_Button.Controls.Add(this.rbt_Hindi);
            this.pnl_Button.Controls.Add(this.rbt_English);
            this.pnl_Button.Controls.Add(this.rbt_Other);
            this.pnl_Button.Controls.Add(this.rbt_Marathi);
            this.pnl_Button.Location = new System.Drawing.Point(269, 217);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(158, 67);
            this.pnl_Button.TabIndex = 14;
            this.pnl_Button.Visible = false;
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(84, 43);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 18;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(3, 45);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 17;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            // 
            // rbt_Other
            // 
            this.rbt_Other.AutoSize = true;
            this.rbt_Other.Location = new System.Drawing.Point(84, 14);
            this.rbt_Other.Name = "rbt_Other";
            this.rbt_Other.Size = new System.Drawing.Size(51, 17);
            this.rbt_Other.TabIndex = 16;
            this.rbt_Other.TabStop = true;
            this.rbt_Other.Text = "Other";
            this.rbt_Other.UseVisualStyleBackColor = true;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(3, 14);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 15;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // txt_GirviNo
            // 
            this.txt_GirviNo.Location = new System.Drawing.Point(142, 55);
            this.txt_GirviNo.Name = "txt_GirviNo";
            this.txt_GirviNo.Size = new System.Drawing.Size(230, 20);
            this.txt_GirviNo.TabIndex = 1;
            this.txt_GirviNo.Enter += new System.EventHandler(this.txt_ContactNo_Enter);
            this.txt_GirviNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_GirviNo_KeyDown);
            this.txt_GirviNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GirviNo_KeyPress);
            // 
            // txt_bankinterest
            // 
            this.txt_bankinterest.Location = new System.Drawing.Point(144, 289);
            this.txt_bankinterest.Name = "txt_bankinterest";
            this.txt_bankinterest.Size = new System.Drawing.Size(228, 20);
            this.txt_bankinterest.TabIndex = 16;
            // 
            // lbl_bankintrest
            // 
            this.lbl_bankintrest.AutoSize = true;
            this.lbl_bankintrest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bankintrest.Location = new System.Drawing.Point(39, 295);
            this.lbl_bankintrest.Name = "lbl_bankintrest";
            this.lbl_bankintrest.Size = new System.Drawing.Size(55, 16);
            this.lbl_bankintrest.TabIndex = 15;
            this.lbl_bankintrest.Text = "Interest";
            // 
            // frm_GirviForword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(427, 370);
            this.Controls.Add(this.txt_bankinterest);
            this.Controls.Add(this.lbl_bankintrest);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.txt_ContactNo);
            this.Controls.Add(this.txt_AmountNo);
            this.Controls.Add(this.lbl_ContactNo);
            this.Controls.Add(this.lbl_AmountNo);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_GirviNo);
            this.Controls.Add(this.lbl_GirviNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frm_GirviForword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Girvi Forward";
            this.Load += new System.EventHandler(this.frm_GirviForword_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_GirviForword_KeyDown);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Button.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GirviNumber;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_AmountNo;
        private System.Windows.Forms.Label lbl_ContactNo;
        private System.Windows.Forms.TextBox txt_AmountNo;
        private System.Windows.Forms.TextBox txt_ContactNo;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.Button bttn_Forword;
        public System.Windows.Forms.TextBox txt_Name;
        public System.Windows.Forms.TextBox txt_GirviNo;
        public System.Windows.Forms.RadioButton rbt_Other;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.TextBox txt_bankinterest;
        private System.Windows.Forms.Label lbl_bankintrest;
        private System.Windows.Forms.DateTimePicker dtp_Date;
    }
}