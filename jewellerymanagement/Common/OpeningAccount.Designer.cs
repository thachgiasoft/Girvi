namespace JewelleryManagement.Common
{
    partial class OpeningAccount
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
            this.rdDebit = new System.Windows.Forms.RadioButton();
            this.rdcredit = new System.Windows.Forms.RadioButton();
            this.lbl_under = new System.Windows.Forms.Label();
            this.cmb_AccountGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_addDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_OpeningBal = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.bttn_reset = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dgv_AccountLedger = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_Nar = new System.Windows.Forms.TextBox();
            this.txt_NOB = new System.Windows.Forms.TextBox();
            this.txt_ChequeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // rdDebit
            // 
            this.rdDebit.AutoSize = true;
            this.rdDebit.Location = new System.Drawing.Point(124, 103);
            this.rdDebit.Name = "rdDebit";
            this.rdDebit.Size = new System.Drawing.Size(50, 17);
            this.rdDebit.TabIndex = 336;
            this.rdDebit.TabStop = true;
            this.rdDebit.Text = "Debit";
            this.rdDebit.UseVisualStyleBackColor = true;
            // 
            // rdcredit
            // 
            this.rdcredit.AutoSize = true;
            this.rdcredit.Location = new System.Drawing.Point(124, 84);
            this.rdcredit.Name = "rdcredit";
            this.rdcredit.Size = new System.Drawing.Size(52, 17);
            this.rdcredit.TabIndex = 335;
            this.rdcredit.TabStop = true;
            this.rdcredit.Text = "Credit";
            this.rdcredit.UseVisualStyleBackColor = true;
            // 
            // lbl_under
            // 
            this.lbl_under.AutoSize = true;
            this.lbl_under.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_under.Location = new System.Drawing.Point(15, 54);
            this.lbl_under.Name = "lbl_under";
            this.lbl_under.Size = new System.Drawing.Size(95, 16);
            this.lbl_under.TabIndex = 334;
            this.lbl_under.Text = "Account Group";
            this.lbl_under.Click += new System.EventHandler(this.lbl_under_Click);
            // 
            // cmb_AccountGroup
            // 
            this.cmb_AccountGroup.DisplayMember = "Under";
            this.cmb_AccountGroup.FormattingEnabled = true;
            this.cmb_AccountGroup.Location = new System.Drawing.Point(124, 53);
            this.cmb_AccountGroup.Name = "cmb_AccountGroup";
            this.cmb_AccountGroup.Size = new System.Drawing.Size(143, 21);
            this.cmb_AccountGroup.TabIndex = 332;
            this.cmb_AccountGroup.ValueMember = "srno";
            this.cmb_AccountGroup.SelectedIndexChanged += new System.EventHandler(this.cmb_under_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 330;
            this.label6.Text = "Date";
            // 
            // dateTimePicker_addDate
            // 
            this.dateTimePicker_addDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_addDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_addDate.Location = new System.Drawing.Point(124, 154);
            this.dateTimePicker_addDate.Name = "dateTimePicker_addDate";
            this.dateTimePicker_addDate.Size = new System.Drawing.Size(151, 27);
            this.dateTimePicker_addDate.TabIndex = 329;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 328;
            this.label2.Text = "Opening Balance";
            // 
            // txt_OpeningBal
            // 
            this.txt_OpeningBal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OpeningBal.Location = new System.Drawing.Point(124, 125);
            this.txt_OpeningBal.Name = "txt_OpeningBal";
            this.txt_OpeningBal.Size = new System.Drawing.Size(143, 23);
            this.txt_OpeningBal.TabIndex = 326;
            this.txt_OpeningBal.Enter += new System.EventHandler(this.txt_amount_Enter);
            this.txt_OpeningBal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_OpeningBal_KeyDown);
            this.txt_OpeningBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(15, 19);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(42, 16);
            this.lblname.TabIndex = 327;
            this.lblname.Text = "Name";
            // 
            // bttn_reset
            // 
            this.bttn_reset.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bttn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_reset.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_reset.ForeColor = System.Drawing.Color.White;
            this.bttn_reset.Location = new System.Drawing.Point(460, 140);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(74, 32);
            this.bttn_reset.TabIndex = 340;
            this.bttn_reset.Text = "Reset";
            this.bttn_reset.UseVisualStyleBackColor = false;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.Color.Red;
            this.bttn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_save.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bttn_save.FlatAppearance.BorderSize = 0;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_save.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.ForeColor = System.Drawing.Color.White;
            this.bttn_save.Location = new System.Drawing.Point(640, 140);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(64, 32);
            this.bttn_save.TabIndex = 337;
            this.bttn_save.Text = "Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(392, 140);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(62, 32);
            this.btnclose.TabIndex = 342;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(124, 17);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(143, 23);
            this.txt_name.TabIndex = 325;
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // dgv_AccountLedger
            // 
            this.dgv_AccountLedger.AllowUserToAddRows = false;
            this.dgv_AccountLedger.AllowUserToDeleteRows = false;
            this.dgv_AccountLedger.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_AccountLedger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_AccountLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AccountLedger.Location = new System.Drawing.Point(15, 184);
            this.dgv_AccountLedger.Name = "dgv_AccountLedger";
            this.dgv_AccountLedger.ReadOnly = true;
            this.dgv_AccountLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AccountLedger.Size = new System.Drawing.Size(689, 226);
            this.dgv_AccountLedger.TabIndex = 343;
            this.dgv_AccountLedger.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AccountLedger_CellClick);
            this.dgv_AccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_AccountLedger_KeyDown);
            this.dgv_AccountLedger.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_AccountLedger_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 344;
            this.label1.Text = "Transaction Type";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(551, 140);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(74, 32);
            this.btn_update.TabIndex = 345;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_Nar
            // 
            this.txt_Nar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nar.Location = new System.Drawing.Point(407, 48);
            this.txt_Nar.Name = "txt_Nar";
            this.txt_Nar.Size = new System.Drawing.Size(167, 23);
            this.txt_Nar.TabIndex = 346;
            this.txt_Nar.Enter += new System.EventHandler(this.txt_Nar_Enter);
            this.txt_Nar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nar_KeyDown);
            // 
            // txt_NOB
            // 
            this.txt_NOB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NOB.Location = new System.Drawing.Point(407, 79);
            this.txt_NOB.Name = "txt_NOB";
            this.txt_NOB.Size = new System.Drawing.Size(167, 23);
            this.txt_NOB.TabIndex = 347;
            this.txt_NOB.Enter += new System.EventHandler(this.txt_NOB_Enter);
            this.txt_NOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NOB_KeyDown);
            // 
            // txt_ChequeId
            // 
            this.txt_ChequeId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChequeId.Location = new System.Drawing.Point(408, 111);
            this.txt_ChequeId.Name = "txt_ChequeId";
            this.txt_ChequeId.Size = new System.Drawing.Size(166, 23);
            this.txt_ChequeId.TabIndex = 348;
            this.txt_ChequeId.Enter += new System.EventHandler(this.txt_ChequeId_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 349;
            this.label3.Text = "Narration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 350;
            this.label4.Text = "Name of Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 351;
            this.label5.Text = "Cheque Id";
            // 
            // OpeningAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(718, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ChequeId);
            this.Controls.Add(this.txt_NOB);
            this.Controls.Add(this.txt_Nar);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_AccountLedger);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.bttn_reset);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.rdDebit);
            this.Controls.Add(this.rdcredit);
            this.Controls.Add(this.lbl_under);
            this.Controls.Add(this.cmb_AccountGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_addDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_OpeningBal);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txt_name);
            this.KeyPreview = true;
            this.Name = "OpeningAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpeningAccount";
            this.Load += new System.EventHandler(this.OpeningAccount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpeningAccount_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountLedger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdDebit;
        private System.Windows.Forms.RadioButton rdcredit;
        private System.Windows.Forms.Label lbl_under;
        private System.Windows.Forms.ComboBox cmb_AccountGroup;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dateTimePicker_addDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OpeningBal;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button bttn_reset;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridView dgv_AccountLedger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_Nar;
        private System.Windows.Forms.TextBox txt_NOB;
        private System.Windows.Forms.TextBox txt_ChequeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}