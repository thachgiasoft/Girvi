﻿namespace JewelleryManagement.Girvi
{
    partial class frm_DuplicateGirviRelease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DuplicateGirviRelease));
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.pnl_languageRbts = new System.Windows.Forms.Panel();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.dgv_GirviDetail = new System.Windows.Forms.DataGridView();
            this.gn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_FullName = new System.Windows.Forms.ComboBox();
            this.txt_KhatawaniNo = new System.Windows.Forms.TextBox();
            this.lbl_KhatawaniNo = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.bttn_login = new System.Windows.Forms.Button();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.lst_FullName = new System.Windows.Forms.ListBox();
            this.pnl_LanguageOther.SuspendLayout();
            this.pnl_languageRbts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviDetail)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(11, 55);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(181, 30);
            this.pnl_LanguageOther.TabIndex = 406;
            this.pnl_LanguageOther.Visible = false;
            // 
            // rbt_OtherFalse
            // 
            this.rbt_OtherFalse.AutoSize = true;
            this.rbt_OtherFalse.Location = new System.Drawing.Point(102, 3);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = true;
            // 
            // rbt_OtherTrue
            // 
            this.rbt_OtherTrue.AutoSize = true;
            this.rbt_OtherTrue.Location = new System.Drawing.Point(3, 3);
            this.rbt_OtherTrue.Name = "rbt_OtherTrue";
            this.rbt_OtherTrue.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherTrue.TabIndex = 374;
            this.rbt_OtherTrue.Text = "Other True";
            this.rbt_OtherTrue.UseVisualStyleBackColor = true;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(330, 32);
            this.pnl_Header.TabIndex = 398;
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(12, 3);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 363;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // pnl_languageRbts
            // 
            this.pnl_languageRbts.Controls.Add(this.rbt_English);
            this.pnl_languageRbts.Controls.Add(this.rbt_Hindi);
            this.pnl_languageRbts.Controls.Add(this.rbt_Marathi);
            this.pnl_languageRbts.Location = new System.Drawing.Point(56, 24);
            this.pnl_languageRbts.Name = "pnl_languageRbts";
            this.pnl_languageRbts.Size = new System.Drawing.Size(200, 26);
            this.pnl_languageRbts.TabIndex = 405;
            this.pnl_languageRbts.Visible = false;
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(85, 3);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 364;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(137, 3);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 371;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            // 
            // dgv_GirviDetail
            // 
            this.dgv_GirviDetail.AllowUserToAddRows = false;
            this.dgv_GirviDetail.AllowUserToDeleteRows = false;
            this.dgv_GirviDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GirviDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_GirviDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_GirviDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GirviDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gn,
            this.AmountDeposit});
            this.dgv_GirviDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_GirviDetail.Location = new System.Drawing.Point(0, 113);
            this.dgv_GirviDetail.Name = "dgv_GirviDetail";
            this.dgv_GirviDetail.ReadOnly = true;
            this.dgv_GirviDetail.Size = new System.Drawing.Size(330, 120);
            this.dgv_GirviDetail.TabIndex = 404;
            // 
            // gn
            // 
            this.gn.HeaderText = "Girvi No";
            this.gn.Name = "gn";
            this.gn.ReadOnly = true;
            // 
            // AmountDeposit
            // 
            this.AmountDeposit.HeaderText = "AmountDeposit";
            this.AmountDeposit.Name = "AmountDeposit";
            this.AmountDeposit.ReadOnly = true;
            // 
            // cmb_FullName
            // 
            this.cmb_FullName.AllowDrop = true;
            this.cmb_FullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_FullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_FullName.DisplayMember = "FullName";
            this.cmb_FullName.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_FullName.FormattingEnabled = true;
            this.cmb_FullName.Location = new System.Drawing.Point(110, 81);
            this.cmb_FullName.Name = "cmb_FullName";
            this.cmb_FullName.Size = new System.Drawing.Size(215, 25);
            this.cmb_FullName.TabIndex = 403;
            this.cmb_FullName.ValueMember = "FullName";
            this.cmb_FullName.TextChanged += new System.EventHandler(this.cmb_FullName_TextChanged);
            this.cmb_FullName.Enter += new System.EventHandler(this.cmb_FullName_Enter);
            this.cmb_FullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_FullName_KeyDown);
            // 
            // txt_KhatawaniNo
            // 
            this.txt_KhatawaniNo.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KhatawaniNo.Location = new System.Drawing.Point(110, 49);
            this.txt_KhatawaniNo.Name = "txt_KhatawaniNo";
            this.txt_KhatawaniNo.Size = new System.Drawing.Size(215, 28);
            this.txt_KhatawaniNo.TabIndex = 402;
            // 
            // lbl_KhatawaniNo
            // 
            this.lbl_KhatawaniNo.AutoSize = true;
            this.lbl_KhatawaniNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KhatawaniNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_KhatawaniNo.Location = new System.Drawing.Point(12, 54);
            this.lbl_KhatawaniNo.Name = "lbl_KhatawaniNo";
            this.lbl_KhatawaniNo.Size = new System.Drawing.Size(97, 16);
            this.lbl_KhatawaniNo.TabIndex = 401;
            this.lbl_KhatawaniNo.Text = "Khatawani No";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_FullName.Location = new System.Drawing.Point(12, 84);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(73, 16);
            this.lbl_FullName.TabIndex = 400;
            this.lbl_FullName.Text = "Full Name";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Controls.Add(this.bttn_login);
            this.pnl_Bottom.Controls.Add(this.bttn_Reset);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 239);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(330, 32);
            this.pnl_Bottom.TabIndex = 399;
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
            this.bttn_Close.Location = new System.Drawing.Point(256, 3);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 27);
            this.bttn_Close.TabIndex = 371;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // bttn_login
            // 
            this.bttn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_login.BackgroundImage")));
            this.bttn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_login.FlatAppearance.BorderSize = 0;
            this.bttn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_login.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_login.ForeColor = System.Drawing.Color.White;
            this.bttn_login.Location = new System.Drawing.Point(102, 2);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(71, 28);
            this.bttn_login.TabIndex = 370;
            this.bttn_login.Text = "Ok";
            this.bttn_login.UseVisualStyleBackColor = true;
            this.bttn_login.Click += new System.EventHandler(this.bttn_login_Click);
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(179, 3);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(71, 25);
            this.bttn_Reset.TabIndex = 369;
            this.bttn_Reset.Text = "RESET";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            // 
            // lst_FullName
            // 
            this.lst_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_FullName.FormattingEnabled = true;
            this.lst_FullName.ItemHeight = 20;
            this.lst_FullName.Location = new System.Drawing.Point(113, 106);
            this.lst_FullName.Name = "lst_FullName";
            this.lst_FullName.Size = new System.Drawing.Size(212, 124);
            this.lst_FullName.TabIndex = 407;
            this.lst_FullName.Visible = false;
            this.lst_FullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_FullName_KeyDown);
            // 
            // frm_DuplicateGirviRelease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 271);
            this.Controls.Add(this.lst_FullName);
            this.Controls.Add(this.pnl_LanguageOther);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_languageRbts);
            this.Controls.Add(this.dgv_GirviDetail);
            this.Controls.Add(this.cmb_FullName);
            this.Controls.Add(this.txt_KhatawaniNo);
            this.Controls.Add(this.lbl_KhatawaniNo);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.pnl_Bottom);
            this.KeyPreview = true;
            this.Name = "frm_DuplicateGirviRelease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicate Girvi Release";
            this.Load += new System.EventHandler(this.frm_DuplicateGirviRelease_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_DuplicateGirviRelease_KeyDown);
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.pnl_languageRbts.ResumeLayout(false);
            this.pnl_languageRbts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GirviDetail)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_login;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.Panel pnl_languageRbts;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        private System.Windows.Forms.DataGridView dgv_GirviDetail;
        private System.Windows.Forms.ComboBox cmb_FullName;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.TextBox txt_KhatawaniNo;
        private System.Windows.Forms.Label lbl_KhatawaniNo;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.ListBox lst_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountDeposit;
    }
}