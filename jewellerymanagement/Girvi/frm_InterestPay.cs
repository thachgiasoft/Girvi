using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BAL.Reports.Girvi;
using BAL.Common;
namespace JewelleryManagement.Girvi
{
    public partial class frm_InterestPay : Form
    {
        cls_InterestPay _objInterestPay = new cls_InterestPay();
        clsGirviReport _objGirviReport = new clsGirviReport();
        clsCommon _objCommon = new clsCommon();
        string GirviNo;
        public string sumInterestPaid;

        public frm_InterestPay(string girvino)
        {
            InitializeComponent();
            GirviNo = girvino;
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            _objInterestPay.GetInterest(GirviNo, dtp_Date.Text, txt_AmountPaid.Text);
            MessageBox.Show("Amount Saved");

            DataTable dt = _objGirviReport.getInterestPayTableDetailByGirviNo(GirviNo);
            sumInterestPaid = _objCommon.sumDataTableColumn(dt, "Amount").ToString();
            this.Close();
        }

        private void txt_AmountPaid_Validated(object sender, EventArgs e)
        {
            if (txt_AmountPaid.Text == "")
            {
                txt_AmountPaid.Text = "0";
            }
            txt_AmountPaid.Text = (Math.Round(Convert.ToDouble(txt_AmountPaid.Text), 2)).ToString();
        }

        private void txt_AmountPaid_Validating(object sender, CancelEventArgs e)
        {
            if (txt_AmountPaid.Text == "")
            {
                txt_AmountPaid.Text = "0";
            }
            txt_AmountPaid.Text = (Math.Round(Convert.ToDouble(txt_AmountPaid.Text), 2)).ToString();
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            txt_AmountPaid.ResetText();
            dtp_Date.ResetText();
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_AmountPaid_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void frm_InterestPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frm_InterestPay_Load(object sender, EventArgs e)
        {

        }


    }


}

