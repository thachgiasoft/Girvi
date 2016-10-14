using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;

namespace JewelleryManagement.Reports
{
    public partial class frm_CreditDebitRecord : Form
    {
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
        Cls_BalanceSheet _objBalanceSheet = new Cls_BalanceSheet();

        public frm_CreditDebitRecord()
        {
            InitializeComponent();
        }

        private void bttn_Show_Click(object sender, EventArgs e)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            for (int i = 0; i <= (Convert.ToDateTime(dtp_EndDate.Text) - Convert.ToDateTime(dtp_StartDate.Text)).TotalDays + 1; i++)
            {
                string Date = Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(i).ToShortDateString();

                foreach (DataRow dtr in _objBalanceSheet.getallCreditDetailsOnDate(Date).Rows)
                {
                    dgv_record.Rows.Add(Date, dtr["Credit"], "", dtr["FromAccount"]);
                }

                foreach (DataRow dtr in _objBalanceSheet.getallDebitDetailsOnDate(Date).Rows)
                {
                    dgv_record.Rows.Add(Date, "", dtr["Debit"], dtr["FromAccount"]);
                }
            }
        }

        private void frm_CreditDebitRecord_Load(object sender, EventArgs e)
        {
            setDateAsFinancialYear();
        }

        private void setDateAsFinancialYear()
        {
            try
            {
             
                DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
                dtp_StartDate.Text = dtFiancialYear.Rows[0]["startyear"].ToString();
                dtp_EndDate.Text = dtFiancialYear.Rows[0]["endyear"].ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
