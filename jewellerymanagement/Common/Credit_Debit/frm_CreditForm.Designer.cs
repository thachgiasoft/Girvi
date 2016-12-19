namespace JewelleryManagement.Common.Credit_Debit
{
    partial class frm_CreditForm
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
            this.dgv_DebitData = new System.Windows.Forms.DataGridView();
            this.MasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_chequeno = new System.Windows.Forms.Label();
            this.txt_chequeNo = new System.Windows.Forms.TextBox();
            this.lblamount = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_chequeDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bttn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_narration = new System.Windows.Forms.TextBox();
            this.lbl_AccountLedger = new System.Windows.Forms.Label();
            this.cmb_AcountLedger = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cachedCrt_BabulgaonGirviReliese1 = new JewelleryManagement.bin.Debug.CachedCrt_BabulgaonGirviReliese();
            this.bttn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DebitData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DebitData
            // 
            this.dgv_DebitData.AllowUserToAddRows = false;
            this.dgv_DebitData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DebitData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_DebitData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_DebitData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DebitData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MasterId,
            this.Date,
            this.DebitAmount,
            this.FromAccount,
            this.ChequeNo,
            this.ChequeDate});
            this.dgv_DebitData.Location = new System.Drawing.Point(15, 199);
            this.dgv_DebitData.Name = "dgv_DebitData";
            this.dgv_DebitData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DebitData.Size = new System.Drawing.Size(793, 235);
            this.dgv_DebitData.TabIndex = 0;
            this.dgv_DebitData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DebitData_CellContentClick);
            this.dgv_DebitData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_CreditData_KeyDown);
            // 
            // MasterId
            // 
            this.MasterId.HeaderText = "MasterId";
            this.MasterId.Name = "MasterId";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // DebitAmount
            // 
            this.DebitAmount.HeaderText = "Credit Amount";
            this.DebitAmount.Name = "DebitAmount";
            // 
            // FromAccount
            // 
            this.FromAccount.HeaderText = "From Account";
            this.FromAccount.Name = "FromAccount";
            // 
            // ChequeNo
            // 
            this.ChequeNo.HeaderText = "BankName/Cheque No";
            this.ChequeNo.Name = "ChequeNo";
            // 
            // ChequeDate
            // 
            this.ChequeDate.HeaderText = "Cheque Date";
            this.ChequeDate.Name = "ChequeDate";
            // 
            // lbl_chequeno
            // 
            this.lbl_chequeno.AutoSize = true;
            this.lbl_chequeno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chequeno.Location = new System.Drawing.Point(13, 106);
            this.lbl_chequeno.Name = "lbl_chequeno";
            this.lbl_chequeno.Size = new System.Drawing.Size(155, 16);
            this.lbl_chequeno.TabIndex = 338;
            this.lbl_chequeno.Text = "Cheque No/Bank Name";
            // 
            // txt_chequeNo
            // 
            this.txt_chequeNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chequeNo.Location = new System.Drawing.Point(174, 104);
            this.txt_chequeNo.Name = "txt_chequeNo";
            this.txt_chequeNo.Size = new System.Drawing.Size(143, 23);
            this.txt_chequeNo.TabIndex = 336;
            this.txt_chequeNo.Enter += new System.EventHandler(this.txt_chequeNo_Enter);
            this.txt_chequeNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_chequeNo_KeyDown);
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(13, 80);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(57, 16);
            this.lblamount.TabIndex = 337;
            this.lblamount.Text = "Amount";
            this.lblamount.Click += new System.EventHandler(this.lblamount_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(174, 78);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(143, 23);
            this.txt_amount.TabIndex = 335;
            this.txt_amount.Enter += new System.EventHandler(this.txt_amount_Enter);
            this.txt_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 344;
            this.label2.Text = "Cheque Date";
            // 
            // dtp_chequeDate
            // 
            this.dtp_chequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_chequeDate.Location = new System.Drawing.Point(174, 133);
            this.dtp_chequeDate.Name = "dtp_chequeDate";
            this.dtp_chequeDate.Size = new System.Drawing.Size(143, 20);
            this.dtp_chequeDate.TabIndex = 345;
            this.dtp_chequeDate.Enter += new System.EventHandler(this.dtp_chequeDate_Enter);
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(174, 25);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(143, 20);
            this.dtp_date.TabIndex = 346;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 347;
            this.label3.Text = "Date";
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.Color.Red;
            this.bttn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_save.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.ForeColor = System.Drawing.Color.White;
            this.bttn_save.Location = new System.Drawing.Point(24, 164);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(55, 29);
            this.bttn_save.TabIndex = 349;
            this.bttn_save.Text = "Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 351;
            this.label4.Text = "Narration";
            // 
            // txt_narration
            // 
            this.txt_narration.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_narration.Location = new System.Drawing.Point(402, 51);
            this.txt_narration.Multiline = true;
            this.txt_narration.Name = "txt_narration";
            this.txt_narration.Size = new System.Drawing.Size(296, 65);
            this.txt_narration.TabIndex = 350;
            this.txt_narration.Enter += new System.EventHandler(this.txt_narration_Enter);
            this.txt_narration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_narration_KeyDown);
            // 
            // lbl_AccountLedger
            // 
            this.lbl_AccountLedger.AutoSize = true;
            this.lbl_AccountLedger.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccountLedger.Location = new System.Drawing.Point(13, 54);
            this.lbl_AccountLedger.Name = "lbl_AccountLedger";
            this.lbl_AccountLedger.Size = new System.Drawing.Size(102, 16);
            this.lbl_AccountLedger.TabIndex = 360;
            this.lbl_AccountLedger.Text = "Account Group";
            // 
            // cmb_AcountLedger
            // 
            this.cmb_AcountLedger.DisplayMember = "Name";
            this.cmb_AcountLedger.FormattingEnabled = true;
            this.cmb_AcountLedger.Location = new System.Drawing.Point(174, 51);
            this.cmb_AcountLedger.Name = "cmb_AcountLedger";
            this.cmb_AcountLedger.Size = new System.Drawing.Size(143, 21);
            this.cmb_AcountLedger.TabIndex = 359;
            this.cmb_AcountLedger.ValueMember = "Id";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(93, 164);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 29);
            this.btn_Update.TabIndex = 361;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 362;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // bttn_Print
            // 
            this.bttn_Print.Location = new System.Drawing.Point(270, 164);
            this.bttn_Print.Name = "bttn_Print";
            this.bttn_Print.Size = new System.Drawing.Size(75, 29);
            this.bttn_Print.TabIndex = 363;
            this.bttn_Print.Text = "Print";
            this.bttn_Print.UseVisualStyleBackColor = true;
            this.bttn_Print.Click += new System.EventHandler(this.bttn_Print_Click);
            // 
            // frm_CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(817, 439);
            this.Controls.Add(this.bttn_Print);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lbl_AccountLedger);
            this.Controls.Add(this.cmb_AcountLedger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_narration);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.dtp_chequeDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_chequeno);
            this.Controls.Add(this.txt_chequeNo);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.dgv_DebitData);
            this.KeyPreview = true;
            this.Name = "frm_CreditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Form";
            this.Load += new System.EventHandler(this.frm_CreditForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_CreditForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DebitData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DebitData;
        private System.Windows.Forms.Label lbl_chequeno;
        private System.Windows.Forms.TextBox txt_chequeNo;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_chequeDate;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_narration;
        private System.Windows.Forms.Label lbl_AccountLedger;
        private System.Windows.Forms.ComboBox cmb_AcountLedger;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btnDelete;
        private bin.Debug.CachedCrt_BabulgaonGirviReliese cachedCrt_BabulgaonGirviReliese1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeDate;
        private System.Windows.Forms.Button bttn_Print;
    }
}