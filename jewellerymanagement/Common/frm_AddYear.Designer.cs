namespace JewelleryManagement.Common
{
    partial class frm_AddYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddYear));
            this.dgv_YearsDetail = new System.Windows.Forms.DataGridView();
            this.StartYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedYear = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.grp_Years = new System.Windows.Forms.GroupBox();
            this.lbl_EndYear = new System.Windows.Forms.Label();
            this.lbl_StartYear = new System.Windows.Forms.Label();
            this.dtp_EndYear = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartYear = new System.Windows.Forms.DateTimePicker();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_SaveAddress = new System.Windows.Forms.Button();
            this.bttn_CloseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YearsDetail)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.grp_Years.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_YearsDetail
            // 
            this.dgv_YearsDetail.AllowUserToAddRows = false;
            this.dgv_YearsDetail.AllowUserToDeleteRows = false;
            this.dgv_YearsDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_YearsDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_YearsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_YearsDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartYear,
            this.id,
            this.EndYear,
            this.SelectedYear});
            this.dgv_YearsDetail.Location = new System.Drawing.Point(4, 40);
            this.dgv_YearsDetail.Name = "dgv_YearsDetail";
            this.dgv_YearsDetail.Size = new System.Drawing.Size(466, 182);
            this.dgv_YearsDetail.TabIndex = 267;
            this.dgv_YearsDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_YearsDetail_CellClick);
            this.dgv_YearsDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_YearsDetail_MouseClick);
            // 
            // StartYear
            // 
            this.StartYear.HeaderText = "Starting Year";
            this.StartYear.Name = "StartYear";
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // EndYear
            // 
            this.EndYear.HeaderText = "End Year";
            this.EndYear.Name = "EndYear";
            // 
            // SelectedYear
            // 
            this.SelectedYear.HeaderText = "SelectedYear";
            this.SelectedYear.Name = "SelectedYear";
            this.SelectedYear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.pnl_Header.Size = new System.Drawing.Size(475, 38);
            this.pnl_Header.TabIndex = 268;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(326, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 360;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(370, 7);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // grp_Years
            // 
            this.grp_Years.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_Years.Controls.Add(this.lbl_EndYear);
            this.grp_Years.Controls.Add(this.lbl_StartYear);
            this.grp_Years.Controls.Add(this.dtp_EndYear);
            this.grp_Years.Controls.Add(this.dtp_StartYear);
            this.grp_Years.Font = new System.Drawing.Font("Mangal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Years.Location = new System.Drawing.Point(3, 229);
            this.grp_Years.Name = "grp_Years";
            this.grp_Years.Size = new System.Drawing.Size(285, 99);
            this.grp_Years.TabIndex = 269;
            this.grp_Years.TabStop = false;
            this.grp_Years.Text = "Year";
            // 
            // lbl_EndYear
            // 
            this.lbl_EndYear.AutoSize = true;
            this.lbl_EndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndYear.Location = new System.Drawing.Point(9, 66);
            this.lbl_EndYear.Name = "lbl_EndYear";
            this.lbl_EndYear.Size = new System.Drawing.Size(72, 16);
            this.lbl_EndYear.TabIndex = 265;
            this.lbl_EndYear.Text = "End Year";
            // 
            // lbl_StartYear
            // 
            this.lbl_StartYear.AutoSize = true;
            this.lbl_StartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartYear.Location = new System.Drawing.Point(9, 29);
            this.lbl_StartYear.Name = "lbl_StartYear";
            this.lbl_StartYear.Size = new System.Drawing.Size(77, 16);
            this.lbl_StartYear.TabIndex = 266;
            this.lbl_StartYear.Text = "Start Year";
            // 
            // dtp_EndYear
            // 
            this.dtp_EndYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndYear.Location = new System.Drawing.Point(96, 61);
            this.dtp_EndYear.Name = "dtp_EndYear";
            this.dtp_EndYear.Size = new System.Drawing.Size(166, 29);
            this.dtp_EndYear.TabIndex = 263;
            this.dtp_EndYear.Enter += new System.EventHandler(this.dtp_EndYear_Enter);
            // 
            // dtp_StartYear
            // 
            this.dtp_StartYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartYear.Location = new System.Drawing.Point(96, 24);
            this.dtp_StartYear.Name = "dtp_StartYear";
            this.dtp_StartYear.Size = new System.Drawing.Size(166, 29);
            this.dtp_StartYear.TabIndex = 264;
            this.dtp_StartYear.Enter += new System.EventHandler(this.dtp_StartYear_Enter);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.lbl_id);
            this.pnl_Main.Controls.Add(this.pnl_LanguageOther);
            this.pnl_Main.Controls.Add(this.rbt_Marathi);
            this.pnl_Main.Controls.Add(this.rbt_Hindi);
            this.pnl_Main.Controls.Add(this.rbt_English);
            this.pnl_Main.Controls.Add(this.pnl_Bottom);
            this.pnl_Main.Controls.Add(this.grp_Years);
            this.pnl_Main.Controls.Add(this.pnl_Header);
            this.pnl_Main.Controls.Add(this.dgv_YearsDetail);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(475, 371);
            this.pnl_Main.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(306, 258);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 16);
            this.lbl_id.TabIndex = 267;
            this.lbl_id.Text = "Id";
            this.lbl_id.Visible = false;
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(130, 133);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(185, 27);
            this.pnl_LanguageOther.TabIndex = 378;
            this.pnl_LanguageOther.Visible = false;
            // 
            // rbt_OtherTrue
            // 
            this.rbt_OtherTrue.AutoSize = true;
            this.rbt_OtherTrue.Location = new System.Drawing.Point(16, 7);
            this.rbt_OtherTrue.Name = "rbt_OtherTrue";
            this.rbt_OtherTrue.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherTrue.TabIndex = 372;
            this.rbt_OtherTrue.Text = "Other True";
            this.rbt_OtherTrue.UseVisualStyleBackColor = true;
            this.rbt_OtherTrue.CheckedChanged += new System.EventHandler(this.rbt_OtherTrue_CheckedChanged);
            // 
            // rbt_OtherFalse
            // 
            this.rbt_OtherFalse.AutoSize = true;
            this.rbt_OtherFalse.Location = new System.Drawing.Point(98, 7);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = true;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(255, 166);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 377;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(195, 166);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 376;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            this.rbt_Hindi.CheckedChanged += new System.EventHandler(this.rbt_Hindi_CheckedChanged);
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(130, 166);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 375;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Update);
            this.pnl_Bottom.Controls.Add(this.bttn_SaveAddress);
            this.pnl_Bottom.Controls.Add(this.bttn_CloseForm);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 333);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(475, 38);
            this.pnl_Bottom.TabIndex = 270;
            // 
            // bttn_Update
            // 
            this.bttn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Update.BackgroundImage")));
            this.bttn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Update.FlatAppearance.BorderSize = 0;
            this.bttn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Update.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.ForeColor = System.Drawing.Color.White;
            this.bttn_Update.Location = new System.Drawing.Point(244, 5);
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
            this.bttn_SaveAddress.Location = new System.Drawing.Point(321, 5);
            this.bttn_SaveAddress.Name = "bttn_SaveAddress";
            this.bttn_SaveAddress.Size = new System.Drawing.Size(71, 28);
            this.bttn_SaveAddress.TabIndex = 231;
            this.bttn_SaveAddress.Text = "SAVE";
            this.bttn_SaveAddress.UseVisualStyleBackColor = true;
            this.bttn_SaveAddress.Click += new System.EventHandler(this.bttn_SaveAddress_Click);
            // 
            // bttn_CloseForm
            // 
            this.bttn_CloseForm.BackColor = System.Drawing.Color.Transparent;
            this.bttn_CloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_CloseForm.BackgroundImage")));
            this.bttn_CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_CloseForm.FlatAppearance.BorderSize = 0;
            this.bttn_CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_CloseForm.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_CloseForm.ForeColor = System.Drawing.Color.White;
            this.bttn_CloseForm.Location = new System.Drawing.Point(398, 5);
            this.bttn_CloseForm.Name = "bttn_CloseForm";
            this.bttn_CloseForm.Size = new System.Drawing.Size(71, 28);
            this.bttn_CloseForm.TabIndex = 230;
            this.bttn_CloseForm.Text = "CLOSE";
            this.bttn_CloseForm.UseVisualStyleBackColor = false;
            this.bttn_CloseForm.Click += new System.EventHandler(this.bttn_CloseForm_Click);
            // 
            // frm_AddYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 371);
            this.Controls.Add(this.pnl_Main);
            this.KeyPreview = true;
            this.Name = "frm_AddYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Year";
            this.Load += new System.EventHandler(this.frm_AddYear_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_AddYear_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YearsDetail)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.grp_Years.ResumeLayout(false);
            this.grp_Years.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_YearsDetail;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.GroupBox grp_Years;
        private System.Windows.Forms.Label lbl_EndYear;
        private System.Windows.Forms.Label lbl_StartYear;
        private System.Windows.Forms.DateTimePicker dtp_EndYear;
        private System.Windows.Forms.DateTimePicker dtp_StartYear;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_CloseForm;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button bttn_SaveAddress;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndYear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedYear;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Label lbl_id;


    }
}