namespace JewelleryManagement
{
    partial class Frm_All_Settings
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
            this.lbl_receipt = new System.Windows.Forms.Label();
            this.rbt_receiptYes = new System.Windows.Forms.RadioButton();
            this.rbt_ReceiptNo = new System.Windows.Forms.RadioButton();
            this.rbt_PrintNo = new System.Windows.Forms.RadioButton();
            this.rbt_PrintYes = new System.Windows.Forms.RadioButton();
            this.lbl_print = new System.Windows.Forms.Label();
            this.lbl_PavtiNo = new System.Windows.Forms.Label();
            this.rbt_PavtiNo = new System.Windows.Forms.RadioButton();
            this.rbt_PavtiYes = new System.Windows.Forms.RadioButton();
            this.lbl_accType = new System.Windows.Forms.Label();
            this.rbt_AccType2 = new System.Windows.Forms.RadioButton();
            this.rbt_AccType1 = new System.Windows.Forms.RadioButton();
            this.lbl_hideFields = new System.Windows.Forms.Label();
            this.rbt_hideNo = new System.Windows.Forms.RadioButton();
            this.rbt_hideYes = new System.Windows.Forms.RadioButton();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.cmb_Duration = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_receipt
            // 
            this.lbl_receipt.AutoSize = true;
            this.lbl_receipt.Location = new System.Drawing.Point(27, 30);
            this.lbl_receipt.Name = "lbl_receipt";
            this.lbl_receipt.Size = new System.Drawing.Size(101, 13);
            this.lbl_receipt.TabIndex = 0;
            this.lbl_receipt.Text = "Receipt Compulsary";
            // 
            // rbt_receiptYes
            // 
            this.rbt_receiptYes.AutoSize = true;
            this.rbt_receiptYes.Location = new System.Drawing.Point(12, 7);
            this.rbt_receiptYes.Name = "rbt_receiptYes";
            this.rbt_receiptYes.Size = new System.Drawing.Size(43, 17);
            this.rbt_receiptYes.TabIndex = 1;
            this.rbt_receiptYes.TabStop = true;
            this.rbt_receiptYes.Text = "Yes";
            this.rbt_receiptYes.UseVisualStyleBackColor = true;
            this.rbt_receiptYes.CheckedChanged += new System.EventHandler(this.rbt_receiptYes_CheckedChanged);
            // 
            // rbt_ReceiptNo
            // 
            this.rbt_ReceiptNo.AutoSize = true;
            this.rbt_ReceiptNo.Location = new System.Drawing.Point(116, 7);
            this.rbt_ReceiptNo.Name = "rbt_ReceiptNo";
            this.rbt_ReceiptNo.Size = new System.Drawing.Size(39, 17);
            this.rbt_ReceiptNo.TabIndex = 2;
            this.rbt_ReceiptNo.TabStop = true;
            this.rbt_ReceiptNo.Text = "No";
            this.rbt_ReceiptNo.UseVisualStyleBackColor = true;
            this.rbt_ReceiptNo.CheckedChanged += new System.EventHandler(this.rbt_ReceiptNo_CheckedChanged);
            // 
            // rbt_PrintNo
            // 
            this.rbt_PrintNo.AutoSize = true;
            this.rbt_PrintNo.Location = new System.Drawing.Point(115, 3);
            this.rbt_PrintNo.Name = "rbt_PrintNo";
            this.rbt_PrintNo.Size = new System.Drawing.Size(39, 17);
            this.rbt_PrintNo.TabIndex = 4;
            this.rbt_PrintNo.TabStop = true;
            this.rbt_PrintNo.Tag = "1";
            this.rbt_PrintNo.Text = "No";
            this.rbt_PrintNo.UseVisualStyleBackColor = true;
            this.rbt_PrintNo.CheckedChanged += new System.EventHandler(this.rbt_PrintNo_CheckedChanged);
            // 
            // rbt_PrintYes
            // 
            this.rbt_PrintYes.AutoSize = true;
            this.rbt_PrintYes.Location = new System.Drawing.Point(11, 3);
            this.rbt_PrintYes.Name = "rbt_PrintYes";
            this.rbt_PrintYes.Size = new System.Drawing.Size(43, 17);
            this.rbt_PrintYes.TabIndex = 3;
            this.rbt_PrintYes.TabStop = true;
            this.rbt_PrintYes.Tag = "1";
            this.rbt_PrintYes.Text = "Yes";
            this.rbt_PrintYes.UseVisualStyleBackColor = true;
            this.rbt_PrintYes.CheckedChanged += new System.EventHandler(this.rbt_PrintYes_CheckedChanged);
            // 
            // lbl_print
            // 
            this.lbl_print.AutoSize = true;
            this.lbl_print.Location = new System.Drawing.Point(27, 62);
            this.lbl_print.Name = "lbl_print";
            this.lbl_print.Size = new System.Drawing.Size(48, 13);
            this.lbl_print.TabIndex = 5;
            this.lbl_print.Text = "Print Out";
            // 
            // lbl_PavtiNo
            // 
            this.lbl_PavtiNo.AutoSize = true;
            this.lbl_PavtiNo.Location = new System.Drawing.Point(27, 92);
            this.lbl_PavtiNo.Name = "lbl_PavtiNo";
            this.lbl_PavtiNo.Size = new System.Drawing.Size(122, 13);
            this.lbl_PavtiNo.TabIndex = 8;
            this.lbl_PavtiNo.Text = "Pavti No. Autoincrement";
            // 
            // rbt_PavtiNo
            // 
            this.rbt_PavtiNo.AutoSize = true;
            this.rbt_PavtiNo.Location = new System.Drawing.Point(115, 3);
            this.rbt_PavtiNo.Name = "rbt_PavtiNo";
            this.rbt_PavtiNo.Size = new System.Drawing.Size(39, 17);
            this.rbt_PavtiNo.TabIndex = 7;
            this.rbt_PavtiNo.TabStop = true;
            this.rbt_PavtiNo.Text = "No";
            this.rbt_PavtiNo.UseVisualStyleBackColor = true;
            this.rbt_PavtiNo.CheckedChanged += new System.EventHandler(this.rbt_PavtiNo_CheckedChanged);
            // 
            // rbt_PavtiYes
            // 
            this.rbt_PavtiYes.AutoSize = true;
            this.rbt_PavtiYes.Location = new System.Drawing.Point(11, 3);
            this.rbt_PavtiYes.Name = "rbt_PavtiYes";
            this.rbt_PavtiYes.Size = new System.Drawing.Size(43, 17);
            this.rbt_PavtiYes.TabIndex = 6;
            this.rbt_PavtiYes.TabStop = true;
            this.rbt_PavtiYes.Text = "Yes";
            this.rbt_PavtiYes.UseVisualStyleBackColor = true;
            this.rbt_PavtiYes.CheckedChanged += new System.EventHandler(this.rbt_PavtiYes_CheckedChanged);
            // 
            // lbl_accType
            // 
            this.lbl_accType.AutoSize = true;
            this.lbl_accType.Location = new System.Drawing.Point(27, 123);
            this.lbl_accType.Name = "lbl_accType";
            this.lbl_accType.Size = new System.Drawing.Size(74, 13);
            this.lbl_accType.TabIndex = 11;
            this.lbl_accType.Text = "Account Type";
            // 
            // rbt_AccType2
            // 
            this.rbt_AccType2.AutoSize = true;
            this.rbt_AccType2.Location = new System.Drawing.Point(114, 10);
            this.rbt_AccType2.Name = "rbt_AccType2";
            this.rbt_AccType2.Size = new System.Drawing.Size(31, 17);
            this.rbt_AccType2.TabIndex = 10;
            this.rbt_AccType2.TabStop = true;
            this.rbt_AccType2.Text = "2";
            this.rbt_AccType2.UseVisualStyleBackColor = true;
            this.rbt_AccType2.CheckedChanged += new System.EventHandler(this.rbt_AccType2_CheckedChanged);
            // 
            // rbt_AccType1
            // 
            this.rbt_AccType1.AutoSize = true;
            this.rbt_AccType1.Location = new System.Drawing.Point(10, 10);
            this.rbt_AccType1.Name = "rbt_AccType1";
            this.rbt_AccType1.Size = new System.Drawing.Size(31, 17);
            this.rbt_AccType1.TabIndex = 9;
            this.rbt_AccType1.TabStop = true;
            this.rbt_AccType1.Text = "1";
            this.rbt_AccType1.UseVisualStyleBackColor = true;
            this.rbt_AccType1.CheckedChanged += new System.EventHandler(this.rbt_AccType1_CheckedChanged);
            // 
            // lbl_hideFields
            // 
            this.lbl_hideFields.AutoSize = true;
            this.lbl_hideFields.Location = new System.Drawing.Point(27, 155);
            this.lbl_hideFields.Name = "lbl_hideFields";
            this.lbl_hideFields.Size = new System.Drawing.Size(59, 13);
            this.lbl_hideFields.TabIndex = 14;
            this.lbl_hideFields.Text = "Hide Fields";
            // 
            // rbt_hideNo
            // 
            this.rbt_hideNo.AutoSize = true;
            this.rbt_hideNo.Location = new System.Drawing.Point(112, 3);
            this.rbt_hideNo.Name = "rbt_hideNo";
            this.rbt_hideNo.Size = new System.Drawing.Size(39, 17);
            this.rbt_hideNo.TabIndex = 13;
            this.rbt_hideNo.TabStop = true;
            this.rbt_hideNo.Text = "No";
            this.rbt_hideNo.UseVisualStyleBackColor = true;
            this.rbt_hideNo.CheckedChanged += new System.EventHandler(this.rbt_hideNo_CheckedChanged);
            // 
            // rbt_hideYes
            // 
            this.rbt_hideYes.AutoSize = true;
            this.rbt_hideYes.Location = new System.Drawing.Point(8, 3);
            this.rbt_hideYes.Name = "rbt_hideYes";
            this.rbt_hideYes.Size = new System.Drawing.Size(43, 17);
            this.rbt_hideYes.TabIndex = 12;
            this.rbt_hideYes.TabStop = true;
            this.rbt_hideYes.Text = "Yes";
            this.rbt_hideYes.UseVisualStyleBackColor = true;
            this.rbt_hideYes.CheckedChanged += new System.EventHandler(this.rbt_hideYes_CheckedChanged);
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Location = new System.Drawing.Point(27, 187);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(100, 13);
            this.lbl_Duration.TabIndex = 15;
            this.lbl_Duration.Text = "Kalavadhi(Duration)";
            // 
            // cmb_Duration
            // 
            this.cmb_Duration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Duration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Duration.DisplayMember = "Duration";
            this.cmb_Duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Duration.FormattingEnabled = true;
            this.cmb_Duration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmb_Duration.Location = new System.Drawing.Point(165, 183);
            this.cmb_Duration.Name = "cmb_Duration";
            this.cmb_Duration.Size = new System.Drawing.Size(121, 21);
            this.cmb_Duration.TabIndex = 18;
            this.cmb_Duration.ValueMember = "Duration";
            this.cmb_Duration.SelectedIndexChanged += new System.EventHandler(this.cmb_Duration_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbt_ReceiptNo);
            this.panel1.Controls.Add(this.rbt_receiptYes);
            this.panel1.Location = new System.Drawing.Point(153, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 29);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbt_PrintNo);
            this.panel2.Controls.Add(this.rbt_PrintYes);
            this.panel2.Location = new System.Drawing.Point(153, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 25);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbt_PavtiNo);
            this.panel3.Controls.Add(this.rbt_PavtiYes);
            this.panel3.Location = new System.Drawing.Point(154, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 25);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbt_AccType2);
            this.panel4.Controls.Add(this.rbt_AccType1);
            this.panel4.Location = new System.Drawing.Point(155, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 29);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbt_hideNo);
            this.panel5.Controls.Add(this.rbt_hideYes);
            this.panel5.Location = new System.Drawing.Point(157, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 25);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.cmb_Duration);
            this.panel6.Controls.Add(this.lbl_Duration);
            this.panel6.Controls.Add(this.lbl_hideFields);
            this.panel6.Controls.Add(this.lbl_accType);
            this.panel6.Controls.Add(this.lbl_PavtiNo);
            this.panel6.Controls.Add(this.lbl_print);
            this.panel6.Controls.Add(this.lbl_receipt);
            this.panel6.Location = new System.Drawing.Point(25, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(344, 231);
            this.panel6.TabIndex = 24;
            // 
            // Frm_All_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JewelleryManagement.Properties.Resources._742618_jewelry_wallpaper;
            this.ClientSize = new System.Drawing.Size(387, 264);
            this.Controls.Add(this.panel6);
            this.Name = "Frm_All_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Settings";
            this.Load += new System.EventHandler(this.Frm_All_Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_receipt;
        private System.Windows.Forms.RadioButton rbt_receiptYes;
        private System.Windows.Forms.RadioButton rbt_ReceiptNo;
        private System.Windows.Forms.RadioButton rbt_PrintNo;
        private System.Windows.Forms.RadioButton rbt_PrintYes;
        private System.Windows.Forms.Label lbl_print;
        private System.Windows.Forms.Label lbl_PavtiNo;
        private System.Windows.Forms.RadioButton rbt_PavtiNo;
        private System.Windows.Forms.RadioButton rbt_PavtiYes;
        private System.Windows.Forms.Label lbl_accType;
        private System.Windows.Forms.RadioButton rbt_AccType2;
        private System.Windows.Forms.RadioButton rbt_AccType1;
        private System.Windows.Forms.Label lbl_hideFields;
        private System.Windows.Forms.RadioButton rbt_hideNo;
        private System.Windows.Forms.RadioButton rbt_hideYes;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.ComboBox cmb_Duration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}