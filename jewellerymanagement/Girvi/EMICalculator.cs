using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JewelleryManagement.Girvi
{
    public partial class EMICalculator : Form
    {

        public EMICalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double LoanAmount = 0;
            //double Payment = 0;
            //double InterestRate = 0;
            //int PaymentPeriods = 0;
            //try
            //{
            //    InterestRate = Convert.ToDouble(txtRate.Text);
            //    PaymentPeriods = Convert.ToInt16(Convert.ToDouble(txtTime.Text) * 12);
            //    LoanAmount = Convert.ToDouble(txtLoan.Text);
            //    if (InterestRate > 1)
            //    {
            //        InterestRate = InterestRate / 100;
            //    }
            //    Payment = (LoanAmount * Math.Pow((InterestRate / 12) + 1, (PaymentPeriods)) * InterestRate / 12) / (Math.Pow(InterestRate / 12 + 1, (PaymentPeriods)) - 1);
            //    lblMonthlyPayment.Text = "Monthly Payment: " + Payment.ToString("N2");
            //}
            //catch
            //{
            //}
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTheMortgage();
        }

        private void CalculateTheMortgage()
        {
            //  (Loan Value) *  (1 + r/12) ^ p =  (12x / r)  *  ((1 + r/12)^p - 1)
            // payment = (((Loan Value) *  (1 + r/12) ^ p) * r)/ (12 * ((1 + r/12)^p - 1)));
            double loanAmount = Convert.ToDouble(txtLoanAmount.Text); // price of total mortgage before down payment
            // double taxesPerYear = (double)txtPropertyTax.CurrentValue; // this will divided by 12 and added to the monthly payment
            double downPayment = Convert.ToDouble(txtDownPayment.Text); // down payment will be subtracted from the loan
            double interestRate = (double)udInterest.Value / 100;  // calculate interest from 100%
            double termOfLoan = (double)(udTerm.Value * 12); // monthly term
            double propertyTax = Convert.ToDouble(txtPropertyTax.Text);
            double insurance = Convert.ToDouble(txtInsurance.Text);

            double payment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 12), termOfLoan) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termOfLoan) - 1));

            // add on a monthly property tax
            payment = payment + (propertyTax + insurance) / 12;

            txtPayment.Text = Convert.ToString(payment);
        }

        private void udTerm_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Month.Text = Convert.ToString(Convert.ToDouble(udTerm.Value) * 12);
            }
            catch { }
        }

        private void txt_Month_TextChanged(object sender, EventArgs e)
        {
            try
            {
                udTerm.Value = Convert.ToDecimal(Convert.ToDouble(txt_Month.Text) / 12);
            }
            catch { }
        }

        private void EMICalculator_Load(object sender, EventArgs e)
        {
            txtDownPayment.Text = "0";
            txtPropertyTax.Text = "0";
            txtInsurance.Text = "0";
            txtPayment.Text = "0";
            txt_Month.Text = "12";

        }

        private void udTerm_TabIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Month.Text = Convert.ToString(Convert.ToDouble(udTerm.Value) * 12);
            }
            catch { }
        }
     

     
        }

    }

