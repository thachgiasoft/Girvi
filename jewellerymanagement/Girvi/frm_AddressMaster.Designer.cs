namespace JewelleryManagement.Girvi
{
    partial class frm_AddressMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddressMaster));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Language = new System.Windows.Forms.Panel();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_ResetItemDetail = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_SaveAddress = new System.Windows.Forms.Button();
            this.dgv_AddressMaster = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_AddressDetail = new System.Windows.Forms.GroupBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.bttn_CloseAddress = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.pnl_Language.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddressMaster)).BeginInit();
            this.grp_AddressDetail.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.pnl_Language);
            this.pnl_Main.Controls.Add(this.pnl_Button);
            this.pnl_Main.Controls.Add(this.dgv_AddressMaster);
            this.pnl_Main.Controls.Add(this.grp_AddressDetail);
            this.pnl_Main.Controls.Add(this.pnl_Bottom);
            this.pnl_Main.Controls.Add(this.pnl_Header);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(356, 479);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Language
            // 
            this.pnl_Language.Controls.Add(this.rbt_Marathi);
            this.pnl_Language.Controls.Add(this.rbt_Hindi);
            this.pnl_Language.Controls.Add(this.rbt_English);
            this.pnl_Language.Location = new System.Drawing.Point(65, 195);
            this.pnl_Language.Name = "pnl_Language";
            this.pnl_Language.Size = new System.Drawing.Size(247, 53);
            this.pnl_Language.TabIndex = 351;
            this.pnl_Language.Visible = false;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(171, 23);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 380;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(98, 23);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 379;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(15, 23);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 378;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Button.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Button.Controls.Add(this.bttn_Delete);
            this.pnl_Button.Controls.Add(this.bttn_ResetItemDetail);
            this.pnl_Button.Controls.Add(this.bttn_Update);
            this.pnl_Button.Controls.Add(this.bttn_SaveAddress);
            this.pnl_Button.Location = new System.Drawing.Point(3, 102);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(350, 37);
            this.pnl_Button.TabIndex = 350;
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
            this.bttn_Delete.Location = new System.Drawing.Point(270, 3);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(71, 28);
            this.bttn_Delete.TabIndex = 234;
            this.bttn_Delete.Text = "DELETE";
            this.bttn_Delete.UseVisualStyleBackColor = false;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // bttn_ResetItemDetail
            // 
            this.bttn_ResetItemDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_ResetItemDetail.BackgroundImage")));
            this.bttn_ResetItemDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_ResetItemDetail.FlatAppearance.BorderSize = 0;
            this.bttn_ResetItemDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_ResetItemDetail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_ResetItemDetail.ForeColor = System.Drawing.Color.White;
            this.bttn_ResetItemDetail.Location = new System.Drawing.Point(179, 3);
            this.bttn_ResetItemDetail.Name = "bttn_ResetItemDetail";
            this.bttn_ResetItemDetail.Size = new System.Drawing.Size(71, 28);
            this.bttn_ResetItemDetail.TabIndex = 233;
            this.bttn_ResetItemDetail.Text = "RESET";
            this.bttn_ResetItemDetail.UseVisualStyleBackColor = true;
            // 
            // bttn_Update
            // 
            this.bttn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Update.BackgroundImage")));
            this.bttn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Update.FlatAppearance.BorderSize = 0;
            this.bttn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Update.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.ForeColor = System.Drawing.Color.White;
            this.bttn_Update.Location = new System.Drawing.Point(89, 3);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(71, 28);
            this.bttn_Update.TabIndex = 232;
            this.bttn_Update.Text = "UPDATE";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttn_SaveAddress
            // 
            this.bttn_SaveAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_SaveAddress.BackgroundImage")));
            this.bttn_SaveAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_SaveAddress.FlatAppearance.BorderSize = 0;
            this.bttn_SaveAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_SaveAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_SaveAddress.ForeColor = System.Drawing.Color.White;
            this.bttn_SaveAddress.Location = new System.Drawing.Point(3, 3);
            this.bttn_SaveAddress.Name = "bttn_SaveAddress";
            this.bttn_SaveAddress.Size = new System.Drawing.Size(71, 28);
            this.bttn_SaveAddress.TabIndex = 230;
            this.bttn_SaveAddress.Text = "SAVE";
            this.bttn_SaveAddress.UseVisualStyleBackColor = true;
            this.bttn_SaveAddress.Click += new System.EventHandler(this.bttn_SaveAddress_Click);
            this.bttn_SaveAddress.Leave += new System.EventHandler(this.bttn_SaveAddress_Leave);
            // 
            // dgv_AddressMaster
            // 
            this.dgv_AddressMaster.AllowUserToAddRows = false;
            this.dgv_AddressMaster.AllowUserToDeleteRows = false;
            this.dgv_AddressMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AddressMaster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_AddressMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AddressMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Address});
            this.dgv_AddressMaster.Location = new System.Drawing.Point(3, 142);
            this.dgv_AddressMaster.Name = "dgv_AddressMaster";
            this.dgv_AddressMaster.ReadOnly = true;
            this.dgv_AddressMaster.Size = new System.Drawing.Size(350, 298);
            this.dgv_AddressMaster.TabIndex = 349;
            this.dgv_AddressMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AddressMaster_CellClick);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // grp_AddressDetail
            // 
            this.grp_AddressDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.grp_AddressDetail.Controls.Add(this.lbl_Address);
            this.grp_AddressDetail.Controls.Add(this.txt_Address);
            this.grp_AddressDetail.Font = new System.Drawing.Font("Mangal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_AddressDetail.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_AddressDetail.Location = new System.Drawing.Point(3, 42);
            this.grp_AddressDetail.Name = "grp_AddressDetail";
            this.grp_AddressDetail.Size = new System.Drawing.Size(350, 55);
            this.grp_AddressDetail.TabIndex = 348;
            this.grp_AddressDetail.TabStop = false;
            this.grp_AddressDetail.Text = "Address Detail";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Address.Location = new System.Drawing.Point(25, 24);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(58, 23);
            this.lbl_Address.TabIndex = 1;
            this.lbl_Address.Text = "Address";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(141, 21);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(183, 29);
            this.txt_Address.TabIndex = 0;
            this.txt_Address.Enter += new System.EventHandler(this.txt_Address_Enter);
            this.txt_Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Address_KeyDown);
            this.txt_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Address_KeyPress);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.pnl_LanguageOther);
            this.pnl_Bottom.Controls.Add(this.bttn_CloseAddress);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 441);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(356, 38);
            this.pnl_Bottom.TabIndex = 347;
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(65, 5);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(181, 30);
            this.pnl_LanguageOther.TabIndex = 379;
            this.pnl_LanguageOther.Visible = false;
            // 
            // rbt_OtherTrue
            // 
            this.rbt_OtherTrue.AutoSize = true;
            this.rbt_OtherTrue.ForeColor = System.Drawing.Color.White;
            this.rbt_OtherTrue.Location = new System.Drawing.Point(3, 3);
            this.rbt_OtherTrue.Name = "rbt_OtherTrue";
            this.rbt_OtherTrue.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherTrue.TabIndex = 374;
            this.rbt_OtherTrue.Text = "Other True";
            this.rbt_OtherTrue.UseVisualStyleBackColor = true;
            this.rbt_OtherTrue.CheckedChanged += new System.EventHandler(this.rbt_OtherTrue_CheckedChanged);
            // 
            // rbt_OtherFalse
            // 
            this.rbt_OtherFalse.AutoSize = true;
            this.rbt_OtherFalse.ForeColor = System.Drawing.Color.White;
            this.rbt_OtherFalse.Location = new System.Drawing.Point(80, 3);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = true;
            // 
            // bttn_CloseAddress
            // 
            this.bttn_CloseAddress.BackColor = System.Drawing.Color.Transparent;
            this.bttn_CloseAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_CloseAddress.BackgroundImage")));
            this.bttn_CloseAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_CloseAddress.FlatAppearance.BorderSize = 0;
            this.bttn_CloseAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_CloseAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_CloseAddress.ForeColor = System.Drawing.Color.White;
            this.bttn_CloseAddress.Location = new System.Drawing.Point(273, 5);
            this.bttn_CloseAddress.Name = "bttn_CloseAddress";
            this.bttn_CloseAddress.Size = new System.Drawing.Size(71, 28);
            this.bttn_CloseAddress.TabIndex = 228;
            this.bttn_CloseAddress.Text = "CLOSE";
            this.bttn_CloseAddress.UseVisualStyleBackColor = false;
            this.bttn_CloseAddress.Click += new System.EventHandler(this.lbl_CloseAddress_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(356, 38);
            this.pnl_Header.TabIndex = 78;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(253, 6);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(101, 27);
            this.dtp_Date.TabIndex = 360;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(213, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 359;
            this.lbl_Date.Text = "Date";
            // 
            // frm_AddressMaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(356, 479);
            this.Controls.Add(this.pnl_Main);
            this.KeyPreview = true;
            this.Name = "frm_AddressMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Master";
            this.Load += new System.EventHandler(this.frm_AddressMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_AddressMaster_KeyDown);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Language.ResumeLayout(false);
            this.pnl_Language.PerformLayout();
            this.pnl_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddressMaster)).EndInit();
            this.grp_AddressDetail.ResumeLayout(false);
            this.grp_AddressDetail.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.GroupBox grp_AddressDetail;
        private System.Windows.Forms.Button bttn_CloseAddress;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.DataGridView dgv_AddressMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button bttn_SaveAddress;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_ResetItemDetail;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        private System.Windows.Forms.Panel pnl_Language;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
    }
}