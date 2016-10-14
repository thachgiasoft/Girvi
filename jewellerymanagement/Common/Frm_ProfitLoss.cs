using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;

namespace JewelleryManagement.Common
{
    public partial class Frm_ProfitLoss : Form
    {
        public Frm_ProfitLoss()
        {
            InitializeComponent();
        }
        Cls_BalanceSheet _objga = new Cls_BalanceSheet();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsCommon _objCommon = new clsCommon();
        private void grp_Expences_Enter(object sender, EventArgs e)
        {

        }

        private void bttn_Show_Click(object sender, EventArgs e)
        {
            ProfitLoss();

        }
    
        private void ProfitLoss()
        {
            ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
           
            dgv_Expence.Rows.Clear();
            dgv_Income.Rows.Clear();
            double InterestTotal = _objGirviCommon.getTotalInterestBySelectectedFinancialYear(dtFiancialYear.Rows[0]["startyear"].ToString(), dtFiancialYear.Rows[0]["endyear"].ToString());
            dgv_Income.Rows.Add();
            dgv_Income.Rows[dgv_Income.RowCount - 1].Cells["DiParticular"].Value = "Interest Receipts";
            dgv_Income.Rows[dgv_Income.RowCount - 1].Cells["DiAmount"].Value = InterestTotal;

            foreach (DataRow dr in _objga.getTrialBalanceDatewise("Direct Income", dtFiancialYear.Rows[0]["startyear"].ToString(), dtFiancialYear.Rows[0]["endyear"].ToString()).Rows)
            {
                dgv_Income.Rows.Add();
                dgv_Income.Rows[dgv_Income.RowCount - 1].Cells["DiParticular"].Value =_objga.getallAccountLedgerDetailsByLedgerId( dr["LedgerId"].ToString()).Rows[0]["Name"];
                dgv_Income.Rows[dgv_Income.RowCount - 1].Cells["DiAmount"].Value = dr["debit"];

            }

            foreach (DataRow dr in _objga.getTrialBalanceDatewise("Direct Expenses", dtFiancialYear.Rows[0]["startyear"].ToString(), dtFiancialYear.Rows[0]["endyear"].ToString()).Rows)
            {
                dgv_Expence.Rows.Add();
                dgv_Expence.Rows[dgv_Expence.RowCount - 1].Cells["DeParticular"].Value = _objga.getallAccountLedgerDetailsByLedgerId(dr["LedgerId"].ToString()).Rows[0]["Name"];
                dgv_Expence.Rows[dgv_Expence.RowCount - 1].Cells["DeAmount"].Value = dr["credit"];
            }

            double Income = _objCommon.sumGridViewColumn(dgv_Income, "DiAmount");
            double Expenes = _objCommon.sumGridViewColumn(dgv_Expence, "DeAmount");
            double NetProfit = Income - Expenes;

            dgv_Expence.Rows.Add();
            dgv_Expence.Rows[dgv_Expence.RowCount - 1].Cells["DeParticular"].Value = "Net Profit for the year transferred to capital account";
            dgv_Expence.Rows[dgv_Expence.RowCount - 1].Cells["DeAmount"].Value = NetProfit;

            lbl_TotalExpences.Text = Income.ToString();
            lbl_TotalIncome.Text = _objCommon.sumGridViewColumn(dgv_Expence, "DeAmount").ToString();
           

        }

        private void dgvCashFlow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_ProfitLoss_Load(object sender, EventArgs e)
        {
            ProfitLoss();
        }

        private void Frm_ProfitLoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
