namespace JewelleryManagement.DataBaseForms
{
    partial class UpdateDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDataBase));
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Save = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.grp_RatesDetail = new System.Windows.Forms.GroupBox();
            this.lbl_ColumName = new System.Windows.Forms.Label();
            this.lbl_tablename = new System.Windows.Forms.Label();
            this.txt_columname = new System.Windows.Forms.TextBox();
            this.cmb_datatype = new System.Windows.Forms.Label();
            this.cmb_DATATYPEVALUE = new System.Windows.Forms.ComboBox();
            this.lbl_defaultvalue = new System.Windows.Forms.Label();
            this.txt_defaultvalue = new System.Windows.Forms.TextBox();
            this.cmb_TableName = new System.Windows.Forms.ComboBox();
            this.chb_nullvalue = new System.Windows.Forms.CheckBox();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.grp_RatesDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Controls.Add(this.bttn_Reset);
            this.pnl_Bottom.Controls.Add(this.bttn_Save);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 436);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(695, 36);
            this.pnl_Bottom.TabIndex = 2;
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
            this.bttn_Close.Location = new System.Drawing.Point(612, 5);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 231;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(527, 5);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(71, 28);
            this.bttn_Reset.TabIndex = 228;
            this.bttn_Reset.Text = "RESET";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            this.bttn_Reset.Click += new System.EventHandler(this.bttn_Reset_Click);
            // 
            // bttn_Save
            // 
            this.bttn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Save.BackgroundImage")));
            this.bttn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Save.FlatAppearance.BorderSize = 0;
            this.bttn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Save.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Save.ForeColor = System.Drawing.Color.White;
            this.bttn_Save.Location = new System.Drawing.Point(439, 5);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Size = new System.Drawing.Size(71, 28);
            this.bttn_Save.TabIndex = 227;
            this.bttn_Save.Text = "SAVE";
            this.bttn_Save.UseVisualStyleBackColor = true;
            this.bttn_Save.Click += new System.EventHandler(this.bttn_Save_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(695, 36);
            this.pnl_Header.TabIndex = 77;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(542, 8);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 358;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(583, 4);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 357;
            // 
            // grp_RatesDetail
            // 
            this.grp_RatesDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.grp_RatesDetail.Controls.Add(this.chb_nullvalue);
            this.grp_RatesDetail.Controls.Add(this.cmb_TableName);
            this.grp_RatesDetail.Controls.Add(this.txt_defaultvalue);
            this.grp_RatesDetail.Controls.Add(this.lbl_defaultvalue);
            this.grp_RatesDetail.Controls.Add(this.cmb_DATATYPEVALUE);
            this.grp_RatesDetail.Controls.Add(this.cmb_datatype);
            this.grp_RatesDetail.Controls.Add(this.txt_columname);
            this.grp_RatesDetail.Controls.Add(this.lbl_ColumName);
            this.grp_RatesDetail.Controls.Add(this.lbl_tablename);
            this.grp_RatesDetail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_RatesDetail.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_RatesDetail.Location = new System.Drawing.Point(12, 58);
            this.grp_RatesDetail.Name = "grp_RatesDetail";
            this.grp_RatesDetail.Size = new System.Drawing.Size(671, 361);
            this.grp_RatesDetail.TabIndex = 78;
            this.grp_RatesDetail.TabStop = false;
            this.grp_RatesDetail.Text = "Tables Detail";
            // 
            // lbl_ColumName
            // 
            this.lbl_ColumName.AutoSize = true;
            this.lbl_ColumName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColumName.ForeColor = System.Drawing.Color.Black;
            this.lbl_ColumName.Location = new System.Drawing.Point(98, 91);
            this.lbl_ColumName.Name = "lbl_ColumName";
            this.lbl_ColumName.Size = new System.Drawing.Size(86, 16);
            this.lbl_ColumName.TabIndex = 275;
            this.lbl_ColumName.Text = "ColumName";
            // 
            // lbl_tablename
            // 
            this.lbl_tablename.AutoSize = true;
            this.lbl_tablename.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tablename.ForeColor = System.Drawing.Color.Black;
            this.lbl_tablename.Location = new System.Drawing.Point(100, 40);
            this.lbl_tablename.Name = "lbl_tablename";
            this.lbl_tablename.Size = new System.Drawing.Size(84, 16);
            this.lbl_tablename.TabIndex = 273;
            this.lbl_tablename.Text = "Table Name";
            // 
            // txt_columname
            // 
            this.txt_columname.Location = new System.Drawing.Point(190, 88);
            this.txt_columname.Name = "txt_columname";
            this.txt_columname.Size = new System.Drawing.Size(135, 22);
            this.txt_columname.TabIndex = 279;
            // 
            // cmb_datatype
            // 
            this.cmb_datatype.AutoSize = true;
            this.cmb_datatype.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_datatype.ForeColor = System.Drawing.Color.Black;
            this.cmb_datatype.Location = new System.Drawing.Point(117, 128);
            this.cmb_datatype.Name = "cmb_datatype";
            this.cmb_datatype.Size = new System.Drawing.Size(67, 16);
            this.cmb_datatype.TabIndex = 280;
            this.cmb_datatype.Text = "DataType";
            // 
            // cmb_DATATYPEVALUE
            // 
            this.cmb_DATATYPEVALUE.FormattingEnabled = true;
            this.cmb_DATATYPEVALUE.Items.AddRange(new object[] {
            "int",
            "bigint",
            "binary(50)",
            "bit",
            "char(10)",
            "datetime",
            "decimal(18, 0)",
            "float",
            "image",
            "money",
            "nchar(10)",
            "ntext",
            "numeric(18, 0)",
            "nvarchar(50)",
            "nvarchar(MAX)",
            "real",
            "smalldatetime",
            "smallint",
            "smallmoney",
            "sql_variant",
            "text",
            "timestamp",
            "tinyint",
            "uniqueidentifier",
            "varbinary(50)",
            "varbinary(MAX)",
            "varchar(50)",
            "varchar(MAX)",
            "xml"});
            this.cmb_DATATYPEVALUE.Location = new System.Drawing.Point(190, 125);
            this.cmb_DATATYPEVALUE.Name = "cmb_DATATYPEVALUE";
            this.cmb_DATATYPEVALUE.Size = new System.Drawing.Size(135, 24);
            this.cmb_DATATYPEVALUE.TabIndex = 281;
            // 
            // lbl_defaultvalue
            // 
            this.lbl_defaultvalue.AutoSize = true;
            this.lbl_defaultvalue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_defaultvalue.ForeColor = System.Drawing.Color.Black;
            this.lbl_defaultvalue.Location = new System.Drawing.Point(99, 171);
            this.lbl_defaultvalue.Name = "lbl_defaultvalue";
            this.lbl_defaultvalue.Size = new System.Drawing.Size(85, 16);
            this.lbl_defaultvalue.TabIndex = 282;
            this.lbl_defaultvalue.Text = "Defult Value";
            // 
            // txt_defaultvalue
            // 
            this.txt_defaultvalue.Location = new System.Drawing.Point(190, 167);
            this.txt_defaultvalue.Name = "txt_defaultvalue";
            this.txt_defaultvalue.Size = new System.Drawing.Size(135, 22);
            this.txt_defaultvalue.TabIndex = 283;
            // 
            // cmb_TableName
            // 
            this.cmb_TableName.AllowDrop = true;
            this.cmb_TableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_TableName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_TableName.DisplayMember = "TABLE_NAME";
            this.cmb_TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TableName.FormattingEnabled = true;
            this.cmb_TableName.Location = new System.Drawing.Point(190, 34);
            this.cmb_TableName.Name = "cmb_TableName";
            this.cmb_TableName.Size = new System.Drawing.Size(319, 28);
            this.cmb_TableName.TabIndex = 348;
            this.cmb_TableName.ValueMember = "TABLE_NAME";
            // 
            // chb_nullvalue
            // 
            this.chb_nullvalue.AutoSize = true;
            this.chb_nullvalue.Location = new System.Drawing.Point(190, 211);
            this.chb_nullvalue.Name = "chb_nullvalue";
            this.chb_nullvalue.Size = new System.Drawing.Size(77, 20);
            this.chb_nullvalue.TabIndex = 349;
            this.chb_nullvalue.Text = "Not Null";
            this.chb_nullvalue.UseVisualStyleBackColor = true;
            // 
            // UpdateDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 472);
            this.Controls.Add(this.grp_RatesDetail);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_Bottom);
            this.Name = "UpdateDataBase";
            this.Text = "UpdateDataBase";
            this.Load += new System.EventHandler(this.UpdateDataBase_Load);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.grp_RatesDetail.ResumeLayout(false);
            this.grp_RatesDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.Button bttn_Save;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.GroupBox grp_RatesDetail;
        private System.Windows.Forms.TextBox txt_defaultvalue;
        public System.Windows.Forms.Label lbl_defaultvalue;
        private System.Windows.Forms.ComboBox cmb_DATATYPEVALUE;
        public System.Windows.Forms.Label cmb_datatype;
        private System.Windows.Forms.TextBox txt_columname;
        public System.Windows.Forms.Label lbl_ColumName;
        public System.Windows.Forms.Label lbl_tablename;
        private System.Windows.Forms.ComboBox cmb_TableName;
        private System.Windows.Forms.CheckBox chb_nullvalue;
    }
}