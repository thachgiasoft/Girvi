namespace JewelleryManagement.Girvi
{
    partial class EMICalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMICalculator));
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.pnl_languageRbts = new System.Windows.Forms.Panel();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.txtPropertyTax = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txt_Month = new System.Windows.Forms.TextBox();
            this.lbl_per_year2 = new System.Windows.Forms.Label();
            this.lbl_pmi = new System.Windows.Forms.Label();
            this.lbl_per_year1 = new System.Windows.Forms.Label();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.lbl_property_tax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.udTerm = new System.Windows.Forms.NumericUpDown();
            this.lbl_loan_term = new System.Windows.Forms.Label();
            this.lbl_monthly_payment = new System.Windows.Forms.Label();
            this.lbl_down_payment = new System.Windows.Forms.Label();
            this.lbl_interest = new System.Windows.Forms.Label();
            this.lbl_purchase_price = new System.Windows.Forms.Label();
            this.udInterest = new System.Windows.Forms.NumericUpDown();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_languageRbts.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udInterest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(9, 178);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(0, 13);
            this.lblMonthlyPayment.TabIndex = 15;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.pnl_languageRbts);
            this.pnl_Buttons.Location = new System.Drawing.Point(369, 352);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(244, 41);
            this.pnl_Buttons.TabIndex = 373;
            this.pnl_Buttons.Visible = false;
            // 
            // pnl_languageRbts
            // 
            this.pnl_languageRbts.Controls.Add(this.rbt_English);
            this.pnl_languageRbts.Controls.Add(this.rbt_Hindi);
            this.pnl_languageRbts.Controls.Add(this.rbt_Marathi);
            this.pnl_languageRbts.Location = new System.Drawing.Point(23, 9);
            this.pnl_languageRbts.Name = "pnl_languageRbts";
            this.pnl_languageRbts.Size = new System.Drawing.Size(203, 26);
            this.pnl_languageRbts.TabIndex = 73;
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(12, 6);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 363;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(72, 6);
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
            this.rbt_Marathi.Location = new System.Drawing.Point(127, 6);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 371;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(613, 38);
            this.pnl_Header.TabIndex = 376;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.Controls.Add(this.btnCalculate);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 399);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(613, 38);
            this.pnl_Bottom.TabIndex = 377;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculate.BackgroundImage")));
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(173, 7);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 28);
            this.btnCalculate.TabIndex = 231;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(238, 287);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(117, 20);
            this.txtPayment.TabIndex = 396;
            // 
            // txtInsurance
            // 
            this.txtInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsurance.Location = new System.Drawing.Point(238, 250);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(117, 20);
            this.txtInsurance.TabIndex = 395;
            // 
            // txtPropertyTax
            // 
            this.txtPropertyTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyTax.Location = new System.Drawing.Point(239, 212);
            this.txtPropertyTax.Name = "txtPropertyTax";
            this.txtPropertyTax.Size = new System.Drawing.Size(117, 20);
            this.txtPropertyTax.TabIndex = 394;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownPayment.Location = new System.Drawing.Point(239, 171);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(117, 20);
            this.txtDownPayment.TabIndex = 393;
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanAmount.Location = new System.Drawing.Point(238, 56);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(117, 20);
            this.txtLoanAmount.TabIndex = 392;
            // 
            // txt_Month
            // 
            this.txt_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Month.Location = new System.Drawing.Point(422, 95);
            this.txt_Month.Name = "txt_Month";
            this.txt_Month.Size = new System.Drawing.Size(91, 20);
            this.txt_Month.TabIndex = 391;
            this.txt_Month.TextChanged += new System.EventHandler(this.txt_Month_TextChanged);
            // 
            // lbl_per_year2
            // 
            this.lbl_per_year2.AutoSize = true;
            this.lbl_per_year2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_per_year2.Location = new System.Drawing.Point(362, 254);
            this.lbl_per_year2.Name = "lbl_per_year2";
            this.lbl_per_year2.Size = new System.Drawing.Size(63, 15);
            this.lbl_per_year2.TabIndex = 390;
            this.lbl_per_year2.Text = "per year.";
            // 
            // lbl_pmi
            // 
            this.lbl_pmi.AutoSize = true;
            this.lbl_pmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pmi.Location = new System.Drawing.Point(116, 250);
            this.lbl_pmi.Name = "lbl_pmi";
            this.lbl_pmi.Size = new System.Drawing.Size(109, 15);
            this.lbl_pmi.TabIndex = 389;
            this.lbl_pmi.Text = "PMI (Insurance)";
            // 
            // lbl_per_year1
            // 
            this.lbl_per_year1.AutoSize = true;
            this.lbl_per_year1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_per_year1.Location = new System.Drawing.Point(362, 217);
            this.lbl_per_year1.Name = "lbl_per_year1";
            this.lbl_per_year1.Size = new System.Drawing.Size(63, 15);
            this.lbl_per_year1.TabIndex = 388;
            this.lbl_per_year1.Text = "per year.";
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percent.Location = new System.Drawing.Point(362, 134);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(18, 15);
            this.lbl_percent.TabIndex = 387;
            this.lbl_percent.Text = "%";
            // 
            // lbl_property_tax
            // 
            this.lbl_property_tax.AutoSize = true;
            this.lbl_property_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_property_tax.Location = new System.Drawing.Point(128, 212);
            this.lbl_property_tax.Name = "lbl_property_tax";
            this.lbl_property_tax.Size = new System.Drawing.Size(91, 15);
            this.lbl_property_tax.TabIndex = 386;
            this.lbl_property_tax.Text = "Property Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 385;
            this.label7.Text = "years";
            // 
            // udTerm
            // 
            this.udTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udTerm.Location = new System.Drawing.Point(238, 91);
            this.udTerm.Name = "udTerm";
            this.udTerm.Size = new System.Drawing.Size(118, 20);
            this.udTerm.TabIndex = 378;
            this.udTerm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udTerm.ValueChanged += new System.EventHandler(this.udTerm_ValueChanged);
            this.udTerm.TabIndexChanged += new System.EventHandler(this.udTerm_TabIndexChanged);
            // 
            // lbl_loan_term
            // 
            this.lbl_loan_term.AutoSize = true;
            this.lbl_loan_term.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loan_term.Location = new System.Drawing.Point(116, 95);
            this.lbl_loan_term.Name = "lbl_loan_term";
            this.lbl_loan_term.Size = new System.Drawing.Size(80, 15);
            this.lbl_loan_term.TabIndex = 384;
            this.lbl_loan_term.Text = "Loan Term:";
            // 
            // lbl_monthly_payment
            // 
            this.lbl_monthly_payment.AutoSize = true;
            this.lbl_monthly_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthly_payment.Location = new System.Drawing.Point(116, 287);
            this.lbl_monthly_payment.Name = "lbl_monthly_payment";
            this.lbl_monthly_payment.Size = new System.Drawing.Size(120, 15);
            this.lbl_monthly_payment.TabIndex = 383;
            this.lbl_monthly_payment.Text = "Monthly Payment:";
            // 
            // lbl_down_payment
            // 
            this.lbl_down_payment.AutoSize = true;
            this.lbl_down_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_down_payment.Location = new System.Drawing.Point(116, 174);
            this.lbl_down_payment.Name = "lbl_down_payment";
            this.lbl_down_payment.Size = new System.Drawing.Size(106, 15);
            this.lbl_down_payment.TabIndex = 382;
            this.lbl_down_payment.Text = "Down Payment:";
            // 
            // lbl_interest
            // 
            this.lbl_interest.AutoSize = true;
            this.lbl_interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interest.Location = new System.Drawing.Point(128, 134);
            this.lbl_interest.Name = "lbl_interest";
            this.lbl_interest.Size = new System.Drawing.Size(59, 15);
            this.lbl_interest.TabIndex = 381;
            this.lbl_interest.Text = "Interest:";
            // 
            // lbl_purchase_price
            // 
            this.lbl_purchase_price.AutoSize = true;
            this.lbl_purchase_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchase_price.Location = new System.Drawing.Point(116, 59);
            this.lbl_purchase_price.Name = "lbl_purchase_price";
            this.lbl_purchase_price.Size = new System.Drawing.Size(108, 15);
            this.lbl_purchase_price.TabIndex = 380;
            this.lbl_purchase_price.Text = "Purchase Price:";
            // 
            // udInterest
            // 
            this.udInterest.DecimalPlaces = 4;
            this.udInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udInterest.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.udInterest.Location = new System.Drawing.Point(238, 132);
            this.udInterest.Name = "udInterest";
            this.udInterest.Size = new System.Drawing.Size(118, 20);
            this.udInterest.TabIndex = 379;
            this.udInterest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 437);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.txtPropertyTax);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.txt_Month);
            this.Controls.Add(this.lbl_per_year2);
            this.Controls.Add(this.lbl_pmi);
            this.Controls.Add(this.lbl_per_year1);
            this.Controls.Add(this.lbl_percent);
            this.Controls.Add(this.lbl_property_tax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.udTerm);
            this.Controls.Add(this.lbl_loan_term);
            this.Controls.Add(this.lbl_monthly_payment);
            this.Controls.Add(this.lbl_down_payment);
            this.Controls.Add(this.lbl_interest);
            this.Controls.Add(this.lbl_purchase_price);
            this.Controls.Add(this.udInterest);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Name = "EMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMICalculator";
            this.Load += new System.EventHandler(this.EMICalculator_Load);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_languageRbts.ResumeLayout(false);
            this.pnl_languageRbts.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udInterest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Panel pnl_languageRbts;
        public System.Windows.Forms.RadioButton rbt_English;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.TextBox txtPropertyTax;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txt_Month;
        private System.Windows.Forms.Label lbl_per_year2;
        private System.Windows.Forms.Label lbl_pmi;
        private System.Windows.Forms.Label lbl_per_year1;
        private System.Windows.Forms.Label lbl_percent;
        private System.Windows.Forms.Label lbl_property_tax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown udTerm;
        private System.Windows.Forms.Label lbl_loan_term;
        private System.Windows.Forms.Label lbl_monthly_payment;
        private System.Windows.Forms.Label lbl_down_payment;
        private System.Windows.Forms.Label lbl_interest;
        private System.Windows.Forms.Label lbl_purchase_price;
        private System.Windows.Forms.NumericUpDown udInterest;

    }
}