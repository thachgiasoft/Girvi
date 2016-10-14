namespace JewelleryManagement.Common
{
    partial class frm_dbbackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dbbackup));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSqlAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSQLitePath = new System.Windows.Forms.TextBox();
            this.btnBrowseSQLitePath = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDatabases = new System.Windows.Forms.ComboBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxEncrypt = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbxIntegrated = new System.Windows.Forms.CheckBox();
            this.txtUserDB = new System.Windows.Forms.TextBox();
            this.txtPassDB = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbxTriggers = new System.Windows.Forms.CheckBox();
            this.cbxCreateViews = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttn_Upload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Server Address:";
            this.label1.Visible = false;
            // 
            // txtSqlAddress
            // 
            this.txtSqlAddress.Location = new System.Drawing.Point(845, 44);
            this.txtSqlAddress.Name = "txtSqlAddress";
            this.txtSqlAddress.Size = new System.Drawing.Size(429, 20);
            this.txtSqlAddress.TabIndex = 1;
            this.txtSqlAddress.Visible = false;
            this.txtSqlAddress.TextChanged += new System.EventHandler(this.txtSqlAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SQLite Database File Path:";
            this.label2.Visible = false;
            // 
            // txtSQLitePath
            // 
            this.txtSQLitePath.Location = new System.Drawing.Point(105, 39);
            this.txtSQLitePath.Name = "txtSQLitePath";
            this.txtSQLitePath.Size = new System.Drawing.Size(429, 20);
            this.txtSQLitePath.TabIndex = 11;
            this.txtSQLitePath.Visible = false;
            this.txtSQLitePath.TextChanged += new System.EventHandler(this.txtSQLitePath_TextChanged);
            // 
            // btnBrowseSQLitePath
            // 
            this.btnBrowseSQLitePath.BackColor = System.Drawing.Color.Red;
            this.btnBrowseSQLitePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowseSQLitePath.Location = new System.Drawing.Point(568, 39);
            this.btnBrowseSQLitePath.Name = "btnBrowseSQLitePath";
            this.btnBrowseSQLitePath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSQLitePath.TabIndex = 12;
            this.btnBrowseSQLitePath.Text = "Browse...";
            this.btnBrowseSQLitePath.UseVisualStyleBackColor = false;
            this.btnBrowseSQLitePath.Visible = false;
            this.btnBrowseSQLitePath.Click += new System.EventHandler(this.btnBrowseSQLitePath_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Maroon;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(320, 134);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(240, 38);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start ";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "db";
            this.saveFileDialog1.Filter = "SQLite Files|*.db|All Files|*.*";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select DB:";
            this.label3.Visible = false;
            // 
            // cboDatabases
            // 
            this.cboDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabases.Enabled = false;
            this.cboDatabases.FormattingEnabled = true;
            this.cboDatabases.Location = new System.Drawing.Point(86, 178);
            this.cboDatabases.Name = "cboDatabases";
            this.cboDatabases.Size = new System.Drawing.Size(429, 21);
            this.cboDatabases.TabIndex = 4;
            this.cboDatabases.Visible = false;
            this.cboDatabases.SelectedIndexChanged += new System.EventHandler(this.cboDatabases_SelectedIndexChanged);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Red;
            this.btnSet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSet.Location = new System.Drawing.Point(1280, 42);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Visible = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // pbrProgress
            // 
            this.pbrProgress.Location = new System.Drawing.Point(12, 77);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(652, 35);
            this.pbrProgress.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(14, 53);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(529, 13);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(568, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxEncrypt
            // 
            this.cbxEncrypt.AutoSize = true;
            this.cbxEncrypt.Location = new System.Drawing.Point(706, 154);
            this.cbxEncrypt.Name = "cbxEncrypt";
            this.cbxEncrypt.Size = new System.Drawing.Size(127, 17);
            this.cbxEncrypt.TabIndex = 13;
            this.cbxEncrypt.Text = "Encryption password:";
            this.cbxEncrypt.UseVisualStyleBackColor = true;
            this.cbxEncrypt.Visible = false;
            this.cbxEncrypt.CheckedChanged += new System.EventHandler(this.cbxEncrypt_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(845, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(197, 20);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Visible = false;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cbxIntegrated
            // 
            this.cbxIntegrated.Checked = true;
            this.cbxIntegrated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIntegrated.Location = new System.Drawing.Point(706, 98);
            this.cbxIntegrated.Name = "cbxIntegrated";
            this.cbxIntegrated.Size = new System.Drawing.Size(130, 21);
            this.cbxIntegrated.TabIndex = 5;
            this.cbxIntegrated.Text = "Integrated security";
            this.cbxIntegrated.UseVisualStyleBackColor = true;
            this.cbxIntegrated.Visible = false;
            this.cbxIntegrated.CheckedChanged += new System.EventHandler(this.ChkIntegratedCheckedChanged);
            // 
            // txtUserDB
            // 
            this.txtUserDB.Location = new System.Drawing.Point(880, 98);
            this.txtUserDB.Name = "txtUserDB";
            this.txtUserDB.Size = new System.Drawing.Size(100, 20);
            this.txtUserDB.TabIndex = 7;
            this.txtUserDB.Visible = false;
            // 
            // txtPassDB
            // 
            this.txtPassDB.Location = new System.Drawing.Point(1045, 98);
            this.txtPassDB.Name = "txtPassDB";
            this.txtPassDB.PasswordChar = '*';
            this.txtPassDB.Size = new System.Drawing.Size(113, 20);
            this.txtPassDB.TabIndex = 9;
            this.txtPassDB.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(842, 101);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User:";
            this.lblUser.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(986, 101);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // cbxTriggers
            // 
            this.cbxTriggers.AutoSize = true;
            this.cbxTriggers.Location = new System.Drawing.Point(706, 178);
            this.cbxTriggers.Name = "cbxTriggers";
            this.cbxTriggers.Size = new System.Drawing.Size(201, 17);
            this.cbxTriggers.TabIndex = 19;
            this.cbxTriggers.Text = "Create triggers enforcing foreign keys";
            this.cbxTriggers.UseVisualStyleBackColor = true;
            this.cbxTriggers.Visible = false;
            // 
            // cbxCreateViews
            // 
            this.cbxCreateViews.AutoSize = true;
            this.cbxCreateViews.Location = new System.Drawing.Point(913, 178);
            this.cbxCreateViews.Name = "cbxCreateViews";
            this.cbxCreateViews.Size = new System.Drawing.Size(249, 17);
            this.cbxCreateViews.TabIndex = 20;
            this.cbxCreateViews.Text = "Try to create views (works only in simple cases)";
            this.cbxCreateViews.UseVisualStyleBackColor = true;
            this.cbxCreateViews.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 33);
            this.panel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(652, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(213, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mobile BackUp";
            // 
            // bttn_Upload
            // 
            this.bttn_Upload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Upload.BackgroundImage")));
            this.bttn_Upload.ForeColor = System.Drawing.Color.White;
            this.bttn_Upload.Location = new System.Drawing.Point(195, 134);
            this.bttn_Upload.Name = "bttn_Upload";
            this.bttn_Upload.Size = new System.Drawing.Size(98, 38);
            this.bttn_Upload.TabIndex = 22;
            this.bttn_Upload.Text = "UPLOAD";
            this.bttn_Upload.UseVisualStyleBackColor = true;
            this.bttn_Upload.Click += new System.EventHandler(this.bttn_Upload_Click);
            // 
            // frm_dbbackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 189);
            this.Controls.Add(this.bttn_Upload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxCreateViews);
            this.Controls.Add(this.cbxTriggers);
            this.Controls.Add(this.txtPassDB);
            this.Controls.Add(this.txtUserDB);
            this.Controls.Add(this.cbxIntegrated);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbxEncrypt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbrProgress);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.cboDatabases);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowseSQLitePath);
            this.Controls.Add(this.txtSQLitePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSqlAddress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frm_dbbackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLITE DBCONVERTOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassDB;
        private System.Windows.Forms.TextBox txtUserDB;
        private System.Windows.Forms.CheckBox cbxIntegrated;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSqlAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQLitePath;
        private System.Windows.Forms.Button btnBrowseSQLitePath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDatabases;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxEncrypt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbxTriggers;
        private System.Windows.Forms.CheckBox cbxCreateViews;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttn_Upload;
    }
}

