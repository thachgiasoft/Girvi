using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;
using BAL;

namespace JewelleryManagement.Girvi
{
    public partial class frm_EmiCalculetor : Form
    {
        public frm_EmiCalculetor()
        {
            InitializeComponent();
        }
        public string nod { get; set; }
        clsGirviCommon _objCommon = new clsGirviCommon();
        Simplevalidations _objSimplevalidations = new Simplevalidations();
        private void txt_DepositDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_DepositDays_Click(object sender, EventArgs e)
        {

        }

        private void dtp_EndDate_ValueChanged(object sender, EventArgs e)
        {
           
            if (dtp_StartDate.Text != "" && dtp_EndDate.Text != "")
            {
                txt_DepositDays.Text = ((Convert.ToDateTime(dtp_EndDate.Text) - Convert.ToDateTime(dtp_StartDate.Text)).TotalDays).ToString();
               
            }
        }

        private void txt_InterestInPer_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Loanamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Interset.Text = _objCommon.InterestAmount(txt_Loanamount.Text, txt_InterestInPer.Text, txt_DepositDays.Text).ToString();
                txt_TotalAmount.Text = (Convert.ToDouble(txt_Interset.Text) + Convert.ToDouble(txt_Loanamount.Text)).ToString();

            }
            catch
            { }
        }

        private void frm_EmiCalculetor_Load(object sender, EventArgs e)
        {
            ClearData();
            dtp_StartDate.Select();
        }

        private void ClearData()
        {
            txt_TotalAmount.ResetText();
            txt_Loanamount.ResetText();
            txt_InterestInPer.ResetText();
            txt_Interset.ResetText();
            txt_DepositDays.ResetText();
        }

        private void dtp_EndDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_DepositDays.Focus();
            }
        }

        private void txt_DepositDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_InterestInPer.Focus();
            }
        }

        private void txt_InterestInPer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Loanamount.Focus();
            }
        }

        private void txt_Interset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_TotalAmount.Focus();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_EmiCalculetor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;   
            lbl_DepositDays.Text = "एकून दिवस  ";
            lbl_EndDate.Text = "सोडवण्याची तारीख";
            lbl_Interest.Text = "व्याज घेणे ";
            lbl_InterestInPer.Text = "व्याज";
            lbl_LoanAmount.Text = "रक्कम";
         
            lbl_StartDate.Text = "सुरवात तारीख";
            bttn_Close.Text = "बंद";
            lbl_TotalAmount.Text = "एकून रक्कम";

        
            lbl_DepositDays.Font = new Font("Arial", sizetext);
          
            lbl_EndDate.Font = new Font("Arial", sizetext);
            
            lbl_Interest.Font = new Font("Arial", sizetext);
          
            lbl_InterestInPer.Font = new Font("Arial", sizetext);
           
            lbl_LoanAmount.Font = new Font("Arial", sizetext);
           
            lbl_StartDate.Font = new Font("Arial", sizetext);
       
            bttn_Close.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
        }

        private void txt_DepositDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_InterestInPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send("^(2)");
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_InterestInPer.Text);
        }

        private void txt_Loanamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Interset.Focus();
            }
        }

        private void txt_Loanamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send("^(2)");
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_Loanamount.Text);
        }

        private void dtp_StartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_EndDate.Focus();
            }
        }

        private void dtp_StartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_StartDate.Text != "" && dtp_EndDate.Text != "")
            {
                txt_DepositDays.Text = ((Convert.ToDateTime(dtp_EndDate.Text) - Convert.ToDateTime(dtp_StartDate.Text)).TotalDays).ToString();
                
            }
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            dtp_StartDate.ResetText();
            dtp_EndDate.ResetText();
            txt_DepositDays.ResetText();
            txt_InterestInPer.ResetText();
            txt_Loanamount.ResetText();
            txt_Interset.ResetText();
            txt_TotalAmount.ResetText();
        }

        private void txt_TotalAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Reset.Focus();
            }
        }

        private void txt_DepositDays_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_InterestInPer_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_Loanamount_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_Interset_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_TotalAmount_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_Interset_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_TotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send("^(2)");
        }
    }
}
