namespace JwelleryManagement
{
    partial class frmBackupandRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupandRestore));
            this.panelmain = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_backup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_restore = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDataBase = new System.Windows.Forms.ComboBox();
            this.db_change = new System.Windows.Forms.Button();
            this.chk_Insec = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.White;
            this.panelmain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelmain.Controls.Add(this.btnBrowse);
            this.panelmain.Controls.Add(this.txtPath);
            this.panelmain.Controls.Add(this.pb_status);
            this.panelmain.Controls.Add(this.label3);
            this.panelmain.Controls.Add(this.btn_backup);
            this.panelmain.Controls.Add(this.button1);
            this.panelmain.Controls.Add(this.btn_restore);
            this.panelmain.Controls.Add(this.txtServer);
            this.panelmain.Controls.Add(this.label1);
            this.panelmain.Controls.Add(this.cmbDataBase);
            this.panelmain.Controls.Add(this.db_change);
            this.panelmain.Controls.Add(this.chk_Insec);
            this.panelmain.Controls.Add(this.label2);
            this.panelmain.Controls.Add(this.txt_username);
            this.panelmain.Controls.Add(this.label4);
            this.panelmain.Controls.Add(this.txt_password);
            this.panelmain.Controls.Add(this.label5);
            this.panelmain.Location = new System.Drawing.Point(5, 8);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(748, 640);
            this.panelmain.TabIndex = 0;
            this.panelmain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmain_Paint);
            // 
            // btnBrowse
            // 
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBrowse.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(574, 329);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 27);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "B&ROWSE";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtPath.Location = new System.Drawing.Point(402, 329);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(166, 23);
            this.txtPath.TabIndex = 6;
            // 
            // pb_status
            // 
            this.pb_status.Image = ((System.Drawing.Image)(resources.GetObject("pb_status.Image")));
            this.pb_status.Location = new System.Drawing.Point(42, 146);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(226, 200);
            this.pb_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_status.TabIndex = 8;
            this.pb_status.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(287, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Database Path";
            // 
            // btn_backup
            // 
            this.btn_backup.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Location = new System.Drawing.Point(391, 370);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(93, 30);
            this.btn_backup.TabIndex = 8;
            this.btn_backup.Text = "&BACKUP";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            this.btn_backup.Enter += new System.EventHandler(this.btn_backup_Enter);
            this.btn_backup.Leave += new System.EventHandler(this.btn_backup_Leave);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(487, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "&CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // btn_restore
            // 
            this.btn_restore.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.Location = new System.Drawing.Point(392, 370);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(93, 30);
            this.btn_restore.TabIndex = 9;
            this.btn_restore.Text = "&RESTORE";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Visible = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            this.btn_restore.Enter += new System.EventHandler(this.btn_restore_Enter);
            this.btn_restore.Leave += new System.EventHandler(this.btn_restore_Leave);
            // 
            // txtServer
            // 
            this.txtServer.Enabled = false;
            this.txtServer.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtServer.Location = new System.Drawing.Point(402, 156);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(166, 23);
            this.txtServer.TabIndex = 0;
            this.txtServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(289, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name";
            // 
            // cmbDataBase
            // 
            this.cmbDataBase.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.cmbDataBase.FormattingEnabled = true;
            this.cmbDataBase.Location = new System.Drawing.Point(402, 293);
            this.cmbDataBase.Name = "cmbDataBase";
            this.cmbDataBase.Size = new System.Drawing.Size(166, 23);
            this.cmbDataBase.TabIndex = 4;
            this.cmbDataBase.Text = "12-2-16";
            this.cmbDataBase.SelectedValueChanged += new System.EventHandler(this.cmbDataBase_SelectedValueChanged);
            this.cmbDataBase.Click += new System.EventHandler(this.cmbDataBase_Click);
            // 
            // db_change
            // 
            this.db_change.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_change.Location = new System.Drawing.Point(574, 292);
            this.db_change.Name = "db_change";
            this.db_change.Size = new System.Drawing.Size(80, 28);
            this.db_change.TabIndex = 5;
            this.db_change.Text = "C&HANGE";
            this.db_change.UseVisualStyleBackColor = true;
            this.db_change.Click += new System.EventHandler(this.db_change_Click);
            // 
            // chk_Insec
            // 
            this.chk_Insec.AutoSize = true;
            this.chk_Insec.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.chk_Insec.ForeColor = System.Drawing.Color.Black;
            this.chk_Insec.Location = new System.Drawing.Point(402, 261);
            this.chk_Insec.Name = "chk_Insec";
            this.chk_Insec.Size = new System.Drawing.Size(129, 19);
            this.chk_Insec.TabIndex = 3;
            this.chk_Insec.Text = "Integrated Security";
            this.chk_Insec.UseVisualStyleBackColor = true;
            this.chk_Insec.CheckedChanged += new System.EventHandler(this.chk_Insec_CheckedChanged);
            this.chk_Insec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chk_Insec_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(289, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txt_username.Location = new System.Drawing.Point(402, 191);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(166, 23);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "sa";
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(289, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Name";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txt_password.Location = new System.Drawing.Point(402, 226);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(166, 23);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "8118";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(289, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 497);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmBackupandRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(760, 653);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackupandRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Display";
            this.Load += new System.EventHandler(this.frmBackupandRestore_Load);
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.ComboBox cmbDataBase;
        private System.Windows.Forms.CheckBox chk_Insec;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button db_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
    }
}