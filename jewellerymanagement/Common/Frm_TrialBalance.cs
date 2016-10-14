using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BAL.Common;

namespace JewelleryManagement.Common
{
    public partial class Frm_TrialBalance : Form
    {
        Cls_BalanceSheet _objga = new Cls_BalanceSheet();
        cls_CashInHand _objCashInHand = new cls_CashInHand();
        clsCommon _common = new clsCommon();
        public Frm_TrialBalance()
        {
            InitializeComponent();
        }

        private void Frm_TrialBalance_Load(object sender, EventArgs e)
        {
            LoadTrialBalanceData();

        }

        private void LoadTrialBalanceData()
        {
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
                    dgv_TrialBalance.Rows.Add("Current Assest" ,Convert.ToString( opening+ Convert.ToDouble(getCashBalance())),sumDebit.ToString(),Convert.ToString(opening - sumCredit + sumDebit + Convert.ToDouble(getCashBalance())));

                }
                if (i == 1)
                {
                                    
                    dgv_TrialBalance.Rows.Add("Fixed Assest" ,( opening).ToString(),sumDebit.ToString(),Convert.ToString(opening - sumCredit + sumDebit));
                    
                }
                if (i == 2)
                {
                   
                     dgv_TrialBalance.Rows.Add("Current Assest" ,( opening).ToString(),sumDebit.ToString(),Convert.ToString(opening + sumCredit - sumDebit));
                }
                if (i == 3)
                {
                  
                    dgv_TrialBalance.Rows.Add("Capital Account " ,( opening).ToString(),sumDebit.ToString(),Convert.ToString(opening + sumCredit - sumDebit));
                }
                if (i == 4)
                {
                    
                    dgv_TrialBalance.Rows.Add("Loan " ,( opening).ToString(),sumDebit.ToString(),Convert.ToString(opening + sumCredit - sumDebit));
                }
                if (i == 5)
                {
                   
                     dgv_TrialBalance.Rows.Add("Direct Income " ,( opening).ToString(),sumDebit.ToString(),Convert.ToString(opening + sumCredit - sumDebit));
                }
                if (i == 6)
                {
                   
                      dgv_TrialBalance.Rows.Add("InDirect Income " ,( opening).ToString(),sumDebit.ToString(),Convert.ToString( opening + sumCredit - sumDebit));
                }
                if (i == 7)
                {
                 
                     dgv_TrialBalance.Rows.Add("InDirect Income " ,( opening).ToString(),sumDebit.ToString(),Convert.ToString( opening + sumCredit - sumDebit));
                }
                if (i == 8)
                {

                     dgv_TrialBalance.Rows.Add("InDirect Income " ,( opening).ToString(),sumDebit.ToString(),Convert.ToString( opening + sumCredit - sumDebit));
                }

            }

            double totalDebit = 0;
            for (int i = 0; i < dgv_TrialBalance.Rows.Count; i++)
            {
               totalDebit=totalDebit+Convert.ToDouble( dgv_TrialBalance.Rows[i].Cells["Debit"].Value);
            }
            double totalCredit = 0;
            for (int i = 0; i < dgv_TrialBalance.Rows.Count; i++)
            {
                totalCredit = totalCredit + Convert.ToDouble(dgv_TrialBalance.Rows[i].Cells["Credit"].Value);
            }
            dgv_TrialBalance.Rows.Add("Total", "", totalDebit.ToString(), totalCredit.ToString(), "");
        }
        string OpeningValue;
        //private string getCashBalance()
        //{
        //    DataTable openingData = new DataTable();

        //    double opning = 0;//int i=0;
        //    try
        //    {
        //        DataTable dt1 = new DataTable();
        //        openingData = _objga.getOpeningLedger("Cash-In-Hand");
        //        dt1.Columns.Add("");
        //        dt1.Columns.Add("");
        //        dt1.Columns.Add("");
        //        dt1.Columns.Add("");
        //        dt1.Columns.Add("");
        //        dt1.Columns.Add("");
        //        dt1.Columns.Add("");
        //        dt1.Columns.Add("");
        //        int count = 0;
        //        if (dt1.Rows.Count == 0)
        //        {


        //            if (openingData.Rows.Count == 0)
        //            {
        //                count = 0;

        //            }
        //            else
        //            {
        //                dt1.Rows.Add("", openingData.Rows[0][4].ToString(), "", "", "", "", "", openingData.Rows[0][1].ToString());
        //                count = 1;

        //            }

        //        }
             
        //        if (count == 1)
        //        {
        //            int j = 0;
        //            for (int i = 0; i <= (Convert.ToDateTime(DateTime.Now.ToString()) - Convert.ToDateTime(openingData.Rows[0][4].ToString())).TotalDays; i++)
        //            {

        //                double dtnew = _objBhandvalBal.getAddgirviondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
        //                double dtnew1 = _objBhandvalBal.getAddreleaseondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
        //                double dtvyaj = _objBhandvalBal.getInterestTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
        //                double dtexpense = _objBhandvalBal.getexpenseTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
        //                double dtaddamt = _objBhandvalBal.getamountaddtotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
        //                // string opening = ((Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString()) - Convert.ToDouble(dtnew)) + Convert.ToDouble(dtnew1)).ToString();
        //                double previousvalue = Convert.ToDouble(dt1.Rows[(i + 1) - 1].ItemArray[7].ToString());
        //                dt1.Rows.Add(i, Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(i + 1).ToShortDateString(), dtnew, dtnew1, dtvyaj, dtexpense, dtaddamt, (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) - Convert.ToDouble(dtexpense) + Convert.ToDouble(dtaddamt)).ToString());
        //                // Opening_Bal.Text= dataGridView1.Rows[i].Cells[5].Value.ToString();
        //                OpeningValue = (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) - Convert.ToDouble(dtexpense) + Convert.ToDouble(dtaddamt)).ToString();
        //                // opning=opning+ (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj));
        //                // dataGridView1.("", Convert.ToDateTime(dt.Rows[0][1].ToString()).AddDays(i + 1).ToShortDateString(), dtnew, dtnew1, (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex-1].Cells[4].Value.ToString()) - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1)).ToString());
        //                j++;
        //            }
        //            return OpeningValue;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Opening Balance is not entered");
        //            return OpeningValue;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return OpeningValue;
        //    }

        //}



        public string getCashBalance()
        {

            DataTable openingData = new DataTable();

            double opning = 0;//int i=0;
            try
            {
                DataTable dt1 = new DataTable();
                openingData = _objga.getOpeningLedger("Cash-In-Hand");
                double sumop = _common.sumDataTableColumn(openingData, "openingBal");
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
                        dt1.Rows.Add(openingData.Rows[0]["date"].ToString(), "", "", "", "", "", sumop);
                        count = 1;
                    }

                }
                int j = 0;
                if (count == 1)
                {
                    for (int i = 0; i <= (Convert.ToDateTime(DateTime.Now.ToString()) - Convert.ToDateTime(openingData.Rows[0]["Date"].ToString())).TotalDays; i++)
                    {
                        //double dtSale = _objCashInHand.getSaleSum(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        //double dtPurchase = _objCashInHand.getPurchaseSum(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        //double dtVyapari = _objCashInHand.getVyapariSum(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        //double dtMod = _objCashInHand.getModSum(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString().ToString());

                        double dtAddGirvi = _objCashInHand.getAddgirviondate(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtRelease = _objCashInHand.getAddreleaseondate(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtVyaj = _objCashInHand.getInterestTotal(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtCredit = _objCashInHand.getCreditSum(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtDebit = _objCashInHand.getDebitSum(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double previousvalue = Convert.ToDouble(dt1.Rows[(i + 1) - 1][6].ToString());
                        //dt1.Rows.Add(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString(), dtSale, dtPurchase, dtVyapari, dtMod, dtCredit, dtDebit, (previousvalue + Convert.ToDouble(dtSale) + Convert.ToDouble(dtVyapari) + Convert.ToDouble(dtMod) - Convert.ToDouble(dtPurchase) - Convert.ToDouble(dtCredit) + Convert.ToDouble(dtDebit)).ToString());
                        dt1.Rows.Add(Convert.ToDateTime(openingData.Rows[0]["date"].ToString()).AddDays(j).ToShortDateString(), dtAddGirvi, dtRelease, dtVyaj, dtCredit, dtDebit, (previousvalue - Convert.ToDouble(dtAddGirvi) + Convert.ToDouble(dtRelease) + Convert.ToDouble(dtVyaj)  - Convert.ToDouble(dtCredit) + Convert.ToDouble(dtDebit)).ToString());

                         //OpeningValue= (previousvalue + Convert.ToDouble(dtSale) + Convert.ToDouble(dtVyapari) + Convert.ToDouble(dtMod) - Convert.ToDouble(dtPurchase) - Convert.ToDouble(dtCredit) + Convert.ToDouble(dtDebit)).ToString();
                         OpeningValue = (previousvalue - Convert.ToDouble(dtAddGirvi) + Convert.ToDouble(dtRelease) + Convert.ToDouble(dtVyaj)- Convert.ToDouble(dtCredit) + Convert.ToDouble(dtDebit)).ToString();
                        
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

        private void Frm_TrialBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
