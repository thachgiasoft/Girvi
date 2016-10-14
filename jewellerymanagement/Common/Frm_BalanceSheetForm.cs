using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BAL.Girvi;
using BAL.Common;
using JwelleryManagement.Common;


namespace JewelleryManagement.Common
{
    public partial class Frm_BalanceSheetForm : Form
    {
        public Frm_BalanceSheetForm()
        {
            InitializeComponent();
        }
        //BLL.VyapariApprovalBal _objFrm_VypariapprovalBal = new BLL.VyapariApprovalBal();
        Cls_BalanceSheet _objga = new Cls_BalanceSheet();
        cls_CashInHand _objCashInHand = new cls_CashInHand();
        DataTable dt;
      
        private void btnshow_Click(object sender, EventArgs e)
        {
            pnlTrialBalance.SendToBack();
            dgv_creditdebit.BringToFront();
            pnlCashFlow.SendToBack();
            LoadBalanceSheet();
        }

        private void LoadBalanceSheet()
        {
               pnlTrialBalance.SendToBack();
            dgv_creditdebit.BringToFront();
            pnlCashFlow.SendToBack();
            double BalanceAssets = 0;
            double BalanceLiabilities = 0;
            double BalanceCapitalAccount = 0;
            double BalanceLoan = 0;
            double BalanceFixesAssets = 0;
            double BalanceDirectIncome = 0;
            double BalanceInDirectIncome = 0;
            double BalanceDirectExpenses = 0;
            double BalanceInDirectExpenses = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("Natures");
            dt.Rows.Add("Current Assets");
            dt.Rows.Add("Fixed Assests");
            dt.Rows.Add("Current Liabilities");
            dt.Rows.Add("Capital Account");
            dt.Rows.Add("Loans");
            dt.Rows.Add("Direct Income");
            dt.Rows.Add("Indirect Income");
            dt.Rows.Add("Direct Expenses");
            dt.Rows.Add("Indirect Expenses");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double sumDebit = 0;
                double sumCredit = 0;
                double opening = 0;


                DataTable dtTrailBalance = _objga.getTrialBalance(dt.Rows[i]["Natures"].ToString());
                for (int j = 0; j < dtTrailBalance.Rows.Count; j++)
                {
                    sumDebit = sumDebit + Convert.ToDouble(dtTrailBalance.Rows[j]["debit"].ToString());
                    sumCredit = sumCredit + Convert.ToDouble(dtTrailBalance.Rows[j]["credit"].ToString());
                }

                if (dt.Rows[i]["Natures"].ToString() == "Fixed Assests")
                {
                    DataTable openingData = _objga.getOpeningLedger(dt.Rows[i]["Natures"].ToString());

                    for (int k = 0; k < openingData.Rows.Count; k++)
                    {
                        if (openingData.Rows[k]["CreditOrDebit"].ToString() == "Debit")
                        {
                            opening = opening + Convert.ToDouble(openingData.Rows[k]["openingBal"].ToString());
                        }
                        if (openingData.Rows[k]["CreditOrDebit"].ToString() == "Credit")
                        {
                            opening = opening - Convert.ToDouble(openingData.Rows[k]["openingBal"].ToString());
                        }
                    }
                }
                else if (dt.Rows[i]["Natures"].ToString() == "Current Assets")
                {
                    DataTable openingData = _objga.getOpeningLedger(dt.Rows[i]["Natures"].ToString());

                    for (int k = 0; k < openingData.Rows.Count; k++)
                    {
                        if (openingData.Rows[k]["CreditOrDebit"].ToString() == "Debit")
                        {
                            opening = opening + Convert.ToDouble(openingData.Rows[k]["openingBal"].ToString());
                        }
                        if (openingData.Rows[k]["CreditOrDebit"].ToString() == "Credit")
                        {
                            opening = opening - Convert.ToDouble(openingData.Rows[k]["openingBal"].ToString());
                        }
                    }
                }

                else
                {
                    DataTable openingData = _objga.getOpeningLedger(dt.Rows[i]["Natures"].ToString());

                    for (int k = 0; k < openingData.Rows.Count; k++)
                    {
                        if (openingData.Rows[k]["CreditOrDebit"].ToString() == "Credit")
                        {
                            opening = opening + Convert.ToDouble(openingData.Rows[k]["openingBal"].ToString());
                        }
                        if (openingData.Rows[k]["CreditOrDebit"].ToString() == "Debit")
                        {
                            opening = opening - Convert.ToDouble(openingData.Rows[k]["openingBal"].ToString());
                        }
                    }
                }
          
                if (i == 0)
                {
                    BalanceAssets = opening - sumCredit + sumDebit + Convert.ToDouble(getCashBalance());

                }
                if (i == 1)
                {
                    BalanceFixesAssets = opening - sumCredit + sumDebit;
                }
                if (i == 2)
                {
                    BalanceLiabilities = opening + sumCredit - sumDebit;

                }
                if (i == 3)
                {
                    BalanceCapitalAccount = opening + sumCredit - sumDebit;
                }
                if (i == 4)
                {
                    BalanceLoan = opening + sumCredit - sumDebit;
                }
                if (i == 5)
                {
                    BalanceDirectIncome = opening + sumCredit - sumDebit;
                }
                if (i == 6)
                {
                    BalanceInDirectIncome = opening + sumCredit - sumDebit;
                }
                if (i == 7)
                {
                    BalanceDirectExpenses = opening + sumCredit - sumDebit;
                }
                if (i == 8)
                {
                    BalanceInDirectExpenses = opening + sumCredit - sumDebit;
                }

            }

            dgv_creditdebit.Rows.Add("Current liabilities", BalanceLiabilities.ToString(), "Current Assets", BalanceAssets.ToString());
            dgv_creditdebit.Rows.Add("Capital Account", BalanceCapitalAccount.ToString(), "Fixed Assets", BalanceFixesAssets.ToString());
            dgv_creditdebit.Rows.Add("Loan Liabilities", BalanceLoan.ToString(), "", "");


            double totalassets = BalanceAssets + BalanceFixesAssets;
            double totalliabilities = BalanceLiabilities + BalanceCapitalAccount + BalanceLoan;
            double difference = totalassets - totalliabilities;
            double profitvalue;

            if ((BalanceInDirectIncome + BalanceDirectIncome + BalanceDirectExpenses + BalanceInDirectExpenses) < 0)
            {
                profitvalue = Math.Abs(BalanceInDirectIncome) + Math.Abs(BalanceDirectIncome) + BalanceDirectExpenses + BalanceInDirectExpenses;
                dgv_creditdebit.Rows.Add("", "", "_______________________", "");
                dgv_creditdebit.Rows.Add("", "", "Profit And Loss", Math.Abs(profitvalue));
                dgv_creditdebit.Rows.Add("", "", "_______________________", "");
                dgv_creditdebit.Rows.Add("Difference", difference - profitvalue, "Opening", "");
                dgv_creditdebit.Rows.Add("", "__________________________", "", "__________________________");
                totalassets = totalassets + Math.Abs(profitvalue);
            }
            else
            {
                profitvalue = Math.Abs(BalanceInDirectIncome) + Math.Abs(BalanceDirectIncome) + BalanceDirectExpenses + BalanceInDirectExpenses;
                dgv_creditdebit.Rows.Add("_______________________", "", "", "");
                dgv_creditdebit.Rows.Add("Profit And Loss", Math.Abs(profitvalue), "", "");
                dgv_creditdebit.Rows.Add("_______________________", "", "", "");
                dgv_creditdebit.Rows.Add("Difference", difference - profitvalue, "Opening", "");
                dgv_creditdebit.Rows.Add("", "__________________________", "", "__________________________");
                totalassets = totalassets + Math.Abs(profitvalue);
            }
            dgv_creditdebit.Rows.Add("Total", totalassets, "Total", totalassets);
        }
        string OpeningValue;
        private string getCashBalance()
        {
            DataTable openingData = new DataTable();

            double opning = 0;//int i=0;
            try
            {
                DataTable dt1 = new DataTable();
                openingData = _objga.getOpeningLedger("Cash-In-Hand");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                int count = 0;
                if (dt1.Rows.Count == 0)
                {


                    if (openingData.Rows.Count == 0)
                    {
                        count = 0;

                    }
                    else
                    {
                        dt1.Rows.Add("", openingData.Rows[0][4].ToString(), "", "", "", "", "", openingData.Rows[0][1].ToString());
                        count = 1;

                    }

                }
                string str = dtpBalSheetEndDate.Text;
                if (count == 1)
                {
                    int j = 0;
                    for (int i = 0; i <= (Convert.ToDateTime(DateTime.Now.ToString()) - Convert.ToDateTime(openingData.Rows[0][4].ToString())).TotalDays; i++)
                    {

                        double dtnew = _objCashInHand.getAddgirviondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtnew1 = _objCashInHand.getAddreleaseondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtvyaj = _objCashInHand.getInterestTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtaddamt = _objCashInHand.getCreditSum(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtexpense = _objCashInHand.getDebitSum(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        // string opening = ((Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString()) - Convert.ToDouble(dtnew)) + Convert.ToDouble(dtnew1)).ToString();
                        double previousvalue = Convert.ToDouble(dt1.Rows[(i + 1) - 1].ItemArray[7].ToString());
                        dt1.Rows.Add(i, Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(i + 1).ToShortDateString(), dtnew, dtnew1, dtvyaj, dtexpense, dtaddamt, (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) - Convert.ToDouble(dtexpense) + Convert.ToDouble(dtaddamt)).ToString());
                        // Opening_Bal.Text= dataGridView1.Rows[i].Cells[5].Value.ToString();
                        OpeningValue = (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) - Convert.ToDouble(dtexpense) + Convert.ToDouble(dtaddamt)).ToString();
                        // opning=opning+ (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj));
                        // dataGridView1.("", Convert.ToDateTime(dt.Rows[0][1].ToString()).AddDays(i + 1).ToShortDateString(), dtnew, dtnew1, (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex-1].Cells[4].Value.ToString()) - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1)).ToString());
                        j++;
                    }
                    return OpeningValue;
                }
                else
                {
                    MessageBox.Show("Opening Balance is not entered");
                    return OpeningValue;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return OpeningValue;
            }

        }
        private void CrediDebit_Load(object sender, EventArgs e)
        {
            pnlTrialBalance.SendToBack();
            dgv_creditdebit.BringToFront();
            pnlCashFlow.SendToBack();
        }
        double SUM = 0;
        double SUM2 = 0;


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Validation val = new Validation();


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CrediDebit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgv_creditdebit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgvCashFlow.Rows.Clear();

                if (e.ColumnIndex == 3 && e.RowIndex == 0)
                {
                    

                    DataTable dtcurrenall = _objga.getOpeningLedger("CurrentAssetsAll");
                    for (int i = 0; i < dtcurrenall.Rows.Count; i++)
                    {
                        double sumDebit = 0;
                        double sumCredit = 0;
                        double opening = 0;
                        DataTable dtTrailBalance = _objga.getbalanceTrailflow(dtcurrenall.Rows[i][0].ToString(), "Current Assets");
                        for (int j = 0; j < dtTrailBalance.Rows.Count; j++)
                        {
                            sumDebit = sumDebit + Convert.ToDouble(dtTrailBalance.Rows[j]["debit"].ToString());
                            sumCredit = sumCredit + Convert.ToDouble(dtTrailBalance.Rows[j]["credit"].ToString());
                        }
                        dgv_TrialBalance.Rows.Add(dtcurrenall.Rows[i][0].ToString(), sumDebit.ToString(), sumCredit.ToString(), "", "");

                    }
                 
                }
                if (e.ColumnIndex == 3 && e.RowIndex == 1)
                {


                    DataTable dtcurrenall = _objga.getOpeningLedger("OnlyFixedAssest");
                    for (int i = 0; i < dtcurrenall.Rows.Count; i++)
                    {
                        double sumDebit = 0;
                        double sumCredit = 0;
                        double opening = 0;
                        DataTable dtTrailBalance = _objga.getbalanceTrailflow(dtcurrenall.Rows[i][0].ToString(), "Fixed Assets");
                        for (int j = 0; j < dtTrailBalance.Rows.Count; j++)
                        {
                            sumDebit = sumDebit + Convert.ToDouble(dtTrailBalance.Rows[j]["debit"].ToString());
                            sumCredit = sumCredit + Convert.ToDouble(dtTrailBalance.Rows[j]["credit"].ToString());
                        }
                        dgv_TrialBalance.Rows.Add(dtcurrenall.Rows[i][0].ToString(), sumDebit.ToString(), sumCredit.ToString(), "", "");

                    }

                }
                if (e.ColumnIndex == 1 && e.RowIndex == 0)
                {


                    DataTable dtcurrenall = _objga.getOpeningLedger("onlyCurrentLiabilities");
                    for (int i = 0; i < dtcurrenall.Rows.Count; i++)
                    {
                        double sumDebit = 0;
                        double sumCredit = 0;
                        double opening = 0;
                        DataTable dtTrailBalance = _objga.getbalanceTrailflow(dtcurrenall.Rows[i][0].ToString(), "Current Liabilities");
                        for (int j = 0; j < dtTrailBalance.Rows.Count; j++)
                        {
                            sumDebit = sumDebit + Convert.ToDouble(dtTrailBalance.Rows[j]["debit"].ToString());
                            sumCredit = sumCredit + Convert.ToDouble(dtTrailBalance.Rows[j]["credit"].ToString());
                        }
                        dgv_TrialBalance.Rows.Add(dtcurrenall.Rows[i][0].ToString(), sumDebit.ToString(), sumCredit.ToString(), "", "");

                    }

                }
                if (e.ColumnIndex == 1 && e.RowIndex == 1)
                {


                    DataTable dtcurrenall = _objga.getOpeningLedger("onlyCapitalAccount");
                    for (int i = 0; i < dtcurrenall.Rows.Count; i++)
                    {
                        double sumDebit = 0;
                        double sumCredit = 0;
                        double opening = 0;
                        DataTable dtTrailBalance = _objga.getbalanceTrailflow(dtcurrenall.Rows[i][0].ToString(), "Capital Liabilities");
                        for (int j = 0; j < dtTrailBalance.Rows.Count; j++)
                        {
                            sumDebit = sumDebit + Convert.ToDouble(dtTrailBalance.Rows[j]["debit"].ToString());
                            sumCredit = sumCredit + Convert.ToDouble(dtTrailBalance.Rows[j]["credit"].ToString());
                        }
                        dgv_TrialBalance.Rows.Add(dtcurrenall.Rows[i][0].ToString(), sumDebit.ToString(), sumCredit.ToString(), "", "");

                    }

                }
                if (e.ColumnIndex == 1 && e.RowIndex == 2)
                {


                    DataTable dtcurrenall = _objga.getOpeningLedger("onlyLoans");
                    for (int i = 0; i < dtcurrenall.Rows.Count; i++)
                    {
                        double sumDebit = 0;
                        double sumCredit = 0;
                        double opening = 0;
                        DataTable dtTrailBalance = _objga.getbalanceTrailflow(dtcurrenall.Rows[i][0].ToString(), "Loans");
                        for (int j = 0; j < dtTrailBalance.Rows.Count; j++)
                        {
                            sumDebit = sumDebit + Convert.ToDouble(dtTrailBalance.Rows[j]["debit"].ToString());
                            sumCredit = sumCredit + Convert.ToDouble(dtTrailBalance.Rows[j]["credit"].ToString());
                        }
                        dgv_TrialBalance.Rows.Add(dtcurrenall.Rows[i][0].ToString(), sumDebit.ToString(), sumCredit.ToString(), "", "");

                    }

                }
                pnlTrialBalance.BringToFront();
                dgv_creditdebit.SendToBack();
                pnlCashFlow.SendToBack();



            }
        }

        private void dgv_TrialBalance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgvCashFlow.Rows.Clear();
                DataTable dtAcountLedgerFromgroup = _objga.getAcountLedgerFromgroup(dgv_TrialBalance.Rows[dgv_TrialBalance.CurrentRow.Index].Cells[0].Value.ToString());
                for (int i = 0; i < dtAcountLedgerFromgroup.Rows.Count; i++)
                {
                    double sumDebit = 0;
                    double sumCredit = 0;
                    double opening = 0;
                    DataTable dtBalanceCashFlow = _objga.getBalanceCashflow(dtAcountLedgerFromgroup.Rows[i][0].ToString());
                    for (int j = 0; j < dtBalanceCashFlow.Rows.Count; j++)
                    {
                        sumDebit = sumDebit + Convert.ToDouble(dtBalanceCashFlow.Rows[j]["debit"].ToString());
                        sumCredit = sumCredit + Convert.ToDouble(dtBalanceCashFlow.Rows[j]["credit"].ToString());
                       
                    }
                    if (dtBalanceCashFlow.Rows.Count>0)
                    {
                        dgvCashFlow.Rows.Add(dtAcountLedgerFromgroup.Rows[i][0].ToString(), "0", sumDebit.ToString(), sumCredit.ToString(), dtBalanceCashFlow.Rows[0]["ledgerId"].ToString());
                    }
                    else
                    {
                        dgvCashFlow.Rows.Add(dtAcountLedgerFromgroup.Rows[i][0].ToString(), "0", sumDebit.ToString(), sumCredit.ToString(),"");
                    }

                }
                pnlTrialBalance.SendToBack();
                dgv_creditdebit.SendToBack();
                pnlCashFlow.BringToFront();
            }
        }

        private void btn_TrailBalclose_Click(object sender, EventArgs e)
        {
            dgv_TrialBalance.Rows.Clear();
            pnlTrialBalance.SendToBack();
            dgv_creditdebit.BringToFront();
            pnlCashFlow.SendToBack();


        }

        private void btn_cashFlowclose_Click(object sender, EventArgs e)
        {
            dgvCashFlow.Rows.Clear();
            pnlTrialBalance.BringToFront();
            dgv_creditdebit.SendToBack();
            pnlCashFlow.SendToBack();

        }

        private void dgvCashFlow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string id = null;
                CashFlow _objCashFlow = new CashFlow(dgvCashFlow.Rows[dgvCashFlow.CurrentRow.Index].Cells["ledgerId"].Value.ToString());
                _objCashFlow.Show();

            }
        }

        

     


    }
}

