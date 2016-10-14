using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;

namespace JewelleryManagement.Girvi
{
    public partial class frm_ActualPayAmount : Form
    {

        Simplevalidations _objSimplevalidations = new Simplevalidations();
        SQLHelper SH = new SQLHelper();
        private TextBox txt_InvoiceNo;
        private string p;
        private string actualinterest;
        public string girvi { get; set; }
        public string loan { get; set; }
        public string nod { get; set; }


        public frm_ActualPayAmount(string girvino, string loanamount, string noofdays,string actualinterestt)
        {
            girvi = girvino;
            loan = loanamount;
            nod = noofdays;
            actualinterest = actualinterestt;
            InitializeComponent();
        }

        public frm_ActualPayAmount(TextBox txt_InvoiceNo, string p, string p_2)
        {
            // TODO: Complete member initialization
            this.txt_InvoiceNo = txt_InvoiceNo;
            this.p = p;
          
        }

        private void frm_ActualPayAmount_Load(object sender, EventArgs e)
        {
            
            txt_GirviNo.Text = girvi;
            txt_LoanAmount.Text = loan;
            txt_InterestInPer.Text = actualinterest;

        }

        private void txt_InterestInPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(nod) < 30)
                {
                    int amt = Convert.ToInt32(txt_LoanAmount.Text);
                    decimal rate = Convert.ToDecimal(Convert.ToDecimal(txt_InterestInPer.Text));
                    decimal dys = 31;
                    decimal intAmount = (((amt * rate) / 100) / 31) * dys;
                    txt_InterestAmount.Text = Convert.ToString(Math.Round(intAmount, 0));
                    txt_TotalAmount.Text = Convert.ToString(Convert.ToDecimal(txt_LoanAmount.Text) + Convert.ToDecimal(txt_InterestAmount.Text));
                }
                else
                {
                    int amt = Convert.ToInt32(txt_LoanAmount.Text);
                    decimal rate = Convert.ToDecimal(Convert.ToDecimal(txt_InterestInPer.Text));
                    decimal dys = Convert.ToDecimal(Convert.ToInt32(nod) + 1);
                    decimal intAmount = (((amt * rate) / 100) / 30) * dys;
                    txt_InterestAmount.Text = Convert.ToString(Math.Round(intAmount, 0));
                    txt_TotalAmount.Text = Convert.ToString(Convert.ToDecimal(txt_LoanAmount.Text) + Convert.ToDecimal(txt_InterestAmount.Text));
                }
            }
            catch { }
        }

        private void bttn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TotalAmount_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void frm_ActualPayAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }

}
