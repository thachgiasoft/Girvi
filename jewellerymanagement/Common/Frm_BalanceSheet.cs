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
    public partial class Frm_BalanceSheet : Form
    {
        Cls_BalanceSheet _objBalanceSheet = new Cls_BalanceSheet();
        clsCommon _objCommon = new clsCommon();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();

        public Frm_BalanceSheet()
        {
            InitializeComponent();
        }

        private void Frm_BalanceSheet_Load(object sender, EventArgs e)
        {

        }


        public void FillGrid()
        {
            dgv_assets.Rows.Clear();
            dgv_liabilities.Rows.Clear();
            ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            string startdate = dtFiancialYear.Rows[0]["startyear"].ToString();
            string enddate = dtFiancialYear.Rows[0]["endyear"].ToString();

            DataTable dtNetProfitForPreviousYears = _objBalanceSheet.getValuesFromProfitLossExceptCurrentFinancialYear();
            DataTable dtNetProfitForCurrent = _objBalanceSheet.getValuesFromProfitLossTillCurrentFinancialYear();

            //////////////////////////////////LIABILITIES//////////////////////////////////////
            #region LIABILITIES

            ///Capital Account///
            #region Capital Account

            dgv_liabilities.Rows.Add("I. PROPRIETOR CAPITAL ACCOUNT");
            dgv_liabilities.Columns[0].Width = 400;
            dgv_liabilities.Rows[dgv_liabilities.Rows.Count - 1].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Underline);

            DataTable dtCapitalAccDetails = new DataTable();
            dtCapitalAccDetails.Columns.Add("LedgerName");
            dtCapitalAccDetails.Columns.Add("TotalCredit");
            dtCapitalAccDetails.Columns.Add("TotalDebit");
            dtCapitalAccDetails.Columns.Add("FinalAmount");


            DataTable dtAccLedger = _objBalanceSheet.getAcountLedgerFromgroup("Capital Account");
            for (int i = 0; i < dtAccLedger.Rows.Count; i++)
            {
                DataTable dtCashFlow = _objBalanceSheet.getBalanceCashflow(dtAccLedger.Rows[i]["name"].ToString(), enddate);
                double sumTotalCredit = _objCommon.sumDataTableColumn(dtCashFlow, "debit");
                double sumTotalDebit = _objCommon.sumDataTableColumn(dtCashFlow, "credit");
                dtCapitalAccDetails.Rows.Add(dtAccLedger.Rows[i]["name"].ToString(), sumTotalCredit, sumTotalDebit, sumTotalCredit - sumTotalDebit);
                dgv_liabilities.Rows.Add(dtAccLedger.Rows[i]["name"].ToString(), sumTotalCredit - sumTotalDebit);
            }

            dgv_liabilities.Rows.Add("NetProfit Last year", Convert.ToDouble(dtNetProfitForPreviousYears.Rows[0]["NetProfit"]));


            dgv_liabilities.Rows.Add("Add: Net Profit for the year", dtNetProfitForCurrent.Rows[0]["NetProfit"], _objCommon.sumDataTableColumn(dtCapitalAccDetails, "FinalAmount") + Convert.ToDouble(dtNetProfitForPreviousYears.Rows[0]["NetProfit"]) + Convert.ToDouble(dtNetProfitForCurrent.Rows[0]["NetProfit"]));

            dgv_liabilities.Rows.Add();

            #endregion



            DataTable dtLiabilitiesGroups = _objBalanceSheet.getAcountFromNature("Liabilities");


            foreach (DataRow dtr in dtLiabilitiesGroups.Rows)
            {
                DataTable dtAccLedgerLoans = _objBalanceSheet.getAcountLedgerFromgroup(dtr["Under"].ToString());
                if (dtAccLedgerLoans.Rows.Count > 0)
                {
                    dgv_liabilities.Rows.Add(dtr["Under"]);

                    dgv_liabilities.Rows[dgv_liabilities.Rows.Count - 1].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Underline);

                    for (int i = 0; i < dtAccLedgerLoans.Rows.Count; i++)
                    {
                        DataTable dtCashFlow = _objBalanceSheet.getBalanceCashflow(dtAccLedgerLoans.Rows[i]["name"].ToString(), enddate);
                        double sumTotalCredit = _objCommon.sumDataTableColumn(dtCashFlow, "debit");
                        double sumTotalDebit = _objCommon.sumDataTableColumn(dtCashFlow, "credit");

                        dtCapitalAccDetails.Rows.Add(dtAccLedgerLoans.Rows[i]["name"].ToString(), sumTotalCredit, sumTotalDebit, sumTotalCredit - sumTotalDebit);
                        if ((sumTotalCredit - sumTotalDebit) > 0)
                        {
                            dgv_liabilities.Rows.Add(dtAccLedgerLoans.Rows[i]["name"].ToString(), "", sumTotalCredit - sumTotalDebit);
                        }
                    }
                }
            }
            #endregion

            ////////////////////////////////////ASSETS/////////////////////////////////////////
            #region ASSETS

            string CashInHand = _objGirviCommon.getCashInHand(enddate);
            string GahaniKhata = _objGirviCommon.getBhandwalWithLastDate(enddate);

            dgv_assets.Rows.Add("I. GAHANI KHATA", GahaniKhata);

            dgv_assets.Rows.Add();

            dgv_assets.Rows.Add("II. CASH IN HAND", CashInHand);


            DataTable dtAssetsGroups = _objBalanceSheet.getAcountFromNature("Assets");
            foreach (DataRow dtr in dtAssetsGroups.Rows)
            {
                DataTable dtAccLedgerassets = _objBalanceSheet.getAcountLedgerFromgroup(dtr["Under"].ToString());
                if (dtAccLedgerassets.Rows.Count > 0)
                {
                    dgv_assets.Rows.Add(dtr["Under"]);

                    dgv_assets.Rows[dgv_assets.Rows.Count - 1].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Underline);

                    for (int i = 0; i < dtAccLedgerassets.Rows.Count; i++)
                    {
                        DataTable dtCashFlow = _objBalanceSheet.getBalanceCashflow(dtAccLedgerassets.Rows[i]["name"].ToString(), enddate);
                        double sumTotalCredit = _objCommon.sumDataTableColumn(dtCashFlow, "credit");
                        double sumTotalDebit = _objCommon.sumDataTableColumn(dtCashFlow, "debit");

                        if ((sumTotalCredit - sumTotalDebit) != 0)
                        {
                            dgv_assets.Rows.Add(dtAccLedgerassets.Rows[i]["name"].ToString(), sumTotalCredit - sumTotalDebit);
                        }
                    }
                }
            }

            #endregion

            lbl_TotalAssets.Text = _objCommon.sumGridViewColumn(dgv_assets, "AmountAssets").ToString();
            lbl_TotalLiabilities.Text = _objCommon.sumGridViewColumn(dgv_liabilities, "Amount2Liabilities").ToString();
            dgv_liabilities.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_assets.CellBorderStyle = DataGridViewCellBorderStyle.None;

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btn_cashFlowclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
