namespace JewelleryManagement.Girvi
{
    partial class frm_TahsilMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TahsilMaster));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_Save = new System.Windows.Forms.Button();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.dgv_TahsilMaster = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tahsil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_TahsilDetail = new System.Windows.Forms.GroupBox();
            this.txt_srno = new System.Windows.Forms.TextBox();
            this.lbl_srno = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_TahsilDetail = new System.Windows.Forms.TextBox();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TahsilMaster)).BeginInit();
            this.grp_TahsilDetail.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Controls.Add(this.pnl_LanguageOther);
            this.pnl_Main.Controls.Add(this.rbt_Marathi);
            this.pnl_Main.Controls.Add(this.rbt_Hindi);
            this.pnl_Main.Controls.Add(this.rbt_English);
            this.pnl_Main.Controls.Add(this.dgv_TahsilMaster);
            this.pnl_Main.Controls.Add(this.grp_TahsilDetail);
            this.pnl_Main.Controls.Add(this.pnl_Bottom);
            this.pnl_Main.Controls.Add(this.pnl_Header);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(382, 430);
            this.pnl_Main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.panel1.Controls.Add(this.bttn_Update);
            this.panel1.Controls.Add(this.bttn_Delete);
            this.panel1.Controls.Add(this.bttn_Save);
            this.panel1.Location = new System.Drawing.Point(2, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 44);
            this.panel1.TabIndex = 382;
            // 
            // bttn_Update
            // 
            this.bttn_Update.BackColor = System.Drawing.Color.CadetBlue;
            this.bttn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Update.BackgroundImage")));
            this.bttn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Update.FlatAppearance.BorderSize = 0;
            this.bttn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Update.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.ForeColor = System.Drawing.Color.White;
            this.bttn_Update.Location = new System.Drawing.Point(137, 7);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(71, 28);
            this.bttn_Update.TabIndex = 231;
            this.bttn_Update.Text = "UPDATE";
            this.bttn_Update.UseVisualStyleBackColor = false;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Delete.BackgroundImage")));
            this.bttn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Delete.FlatAppearance.BorderSize = 0;
            this.bttn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Delete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Delete.ForeColor = System.Drawing.Color.White;
            this.bttn_Delete.Location = new System.Drawing.Point(254, 6);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(71, 28);
            this.bttn_Delete.TabIndex = 230;
            this.bttn_Delete.Text = "DELETE";
            this.bttn_Delete.UseVisualStyleBackColor = true;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // bttn_Save
            // 
            this.bttn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Save.BackgroundImage")));
            this.bttn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Save.FlatAppearance.BorderSize = 0;
            this.bttn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Save.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Save.ForeColor = System.Drawing.Color.White;
            this.bttn_Save.Location = new System.Drawing.Point(25, 7);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Size = new System.Drawing.Size(71, 28);
            this.bttn_Save.TabIndex = 229;
            this.bttn_Save.Text = "SAVE";
            this.bttn_Save.UseVisualStyleBackColor = true;
            this.bttn_Save.Click += new System.EventHandler(this.bttn_Save_Click);
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(66, 276);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(181, 30);
            this.pnl_LanguageOther.TabIndex = 381;
            this.pnl_LanguageOther.Visible = false;
            // 
            // rbt_OtherFalse
            // 
            this.rbt_OtherFalse.AutoSize = true;
            this.rbt_OtherFalse.Location = new System.Drawing.Point(85, 3);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = true;
            this.rbt_OtherFalse.Visible = false;
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
            this.rbt_OtherTrue.Visible = false;
            this.rbt_OtherTrue.CheckedChanged += new System.EventHandler(this.rbt_OtherTrue_CheckedChanged);
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(187, 322);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 380;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(131, 322);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 379;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            this.rbt_Hindi.CheckedChanged += new System.EventHandler(this.rbt_Hindi_CheckedChanged);
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(66, 322);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 378;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // dgv_TahsilMaster
            // 
            this.dgv_TahsilMaster.AllowUserToAddRows = false;
            this.dgv_TahsilMaster.AllowUserToDeleteRows = false;
            this.dgv_TahsilMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TahsilMaster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_TahsilMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TahsilMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Tahsil});
            this.dgv_TahsilMaster.Location = new System.Drawing.Point(0, 171);
            this.dgv_TahsilMaster.Name = "dgv_TahsilMaster";
            this.dgv_TahsilMaster.ReadOnly = true;
            this.dgv_TahsilMaster.Size = new System.Drawing.Size(375, 221);
            this.dgv_TahsilMaster.TabIndex = 350;
            this.dgv_TahsilMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TahsilMaster_CellClick);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // Tahsil
            // 
            this.Tahsil.HeaderText = "Tahsil";
            this.Tahsil.Name = "Tahsil";
            this.Tahsil.ReadOnly = true;
            // 
            // grp_TahsilDetail
            // 
            this.grp_TahsilDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.grp_TahsilDetail.Controls.Add(this.txt_srno);
            this.grp_TahsilDetail.Controls.Add(this.lbl_srno);
            this.grp_TahsilDetail.Controls.Add(this.lbl_Name);
            this.grp_TahsilDetail.Controls.Add(this.txt_TahsilDetail);
            this.grp_TahsilDetail.Font = new System.Drawing.Font("Mangal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TahsilDetail.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_TahsilDetail.Location = new System.Drawing.Point(3, 38);
            this.grp_TahsilDetail.Name = "grp_TahsilDetail";
            this.grp_TahsilDetail.Size = new System.Drawing.Size(375, 88);
            this.grp_TahsilDetail.TabIndex = 349;
            this.grp_TahsilDetail.TabStop = false;
            this.grp_TahsilDetail.Text = "Tahasil Detail";
            // 
            // txt_srno
            // 
            this.txt_srno.Location = new System.Drawing.Point(107, 22);
            this.txt_srno.Name = "txt_srno";
            this.txt_srno.Size = new System.Drawing.Size(183, 29);
            this.txt_srno.TabIndex = 3;
            this.txt_srno.Visible = false;
            // 
            // lbl_srno
            // 
            this.lbl_srno.AutoSize = true;
            this.lbl_srno.ForeColor = System.Drawing.Color.Black;
            this.lbl_srno.Location = new System.Drawing.Point(51, 25);
            this.lbl_srno.Name = "lbl_srno";
            this.lbl_srno.Size = new System.Drawing.Size(37, 23);
            this.lbl_srno.TabIndex = 2;
            this.lbl_srno.Text = "Srno";
            this.lbl_srno.Visible = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Name.Location = new System.Drawing.Point(51, 53);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 23);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // txt_TahsilDetail
            // 
            this.txt_TahsilDetail.Location = new System.Drawing.Point(107, 53);
            this.txt_TahsilDetail.Name = "txt_TahsilDetail";
            this.txt_TahsilDetail.Size = new System.Drawing.Size(183, 29);
            this.txt_TahsilDetail.TabIndex = 0;
            this.txt_TahsilDetail.Enter += new System.EventHandler(this.txt_TahsilDetail_Enter);
            this.txt_TahsilDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Tahsil_KeyDown);
            this.txt_TahsilDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tahsil_KeyPress);
            this.txt_TahsilDetail.Leave += new System.EventHandler(this.txt_TahsilDetail_Leave);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 392);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(382, 38);
            this.pnl_Bottom.TabIndex = 348;
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
            this.bttn_Close.Location = new System.Drawing.Point(257, 5);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 228;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(382, 38);
            this.pnl_Header.TabIndex = 79;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(237, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 360;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(280, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // frm_TahsilMaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(382, 430);
            this.Controls.Add(this.pnl_Main);
            this.KeyPreview = true;
            this.Name = "frm_TahsilMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tahsil Master";
            this.Load += new System.EventHandler(this.frm_TahsilMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TahsilMaster_KeyDown);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TahsilMaster)).EndInit();
            this.grp_TahsilDetail.ResumeLayout(false);
            this.grp_TahsilDetail.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_Save;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.GroupBox grp_TahsilDetail;
        private System.Windows.Forms.TextBox txt_TahsilDetail;
        private System.Windows.Forms.DataGridView dgv_TahsilMaster;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tahsil;
        private System.Windows.Forms.TextBox txt_srno;
        private System.Windows.Forms.Label lbl_srno;
    }
}