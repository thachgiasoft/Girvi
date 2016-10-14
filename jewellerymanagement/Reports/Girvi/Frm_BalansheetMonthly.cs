using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;
using System.Globalization;
using BAL;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class Frm_BalansheetMonthly : Form
    {
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsCommon _objCommon = new clsCommon();
        public delegate void SendData(DataTable dtData, bool Other);
        Validation val = new Validation();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();

        public Frm_BalansheetMonthly()
        {
            InitializeComponent();
        }

        private void Frm_BalansheetMonthly_Load(object sender, EventArgs e)
        {
            FillGrid();
        }


        private void FillGrid()
        {
            DataTable dtBalanceSheet = _objGirviCommon.getAllGirviData();
            DataTable dtFiancialYear=_objFinancialYear.getFinancialYear();
           int month=Convert.ToInt32(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).Month);
        }

        private void bttn_ViewRecord_Click(object sender, EventArgs e)
        {
            dgv_CashDetail.Rows.Clear();
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            DataTable openingData = new DataTable();

            try
            {
                DataTable dtCashDetails = new DataTable();
                dtCashDetails.Columns.Add();
                dtCashDetails.Columns.Add();
                dtCashDetails.Columns.Add();
                dtCashDetails.Columns.Add();
                dtCashDetails.Columns.Add();
                dtCashDetails.Columns.Add();
                dtCashDetails.Columns.Add();
                dtCashDetails.Columns.Add();



                //openingData = _objGirviCommon.getOpeningLedger("Cash-In-Hand");
                openingData = _objGirviCommon.getOpeningBhandwal();//(dtFiancialYear.Rows[0]["StartDate"].ToString());

                //double sumOpeningData = _objCommon.sumDataTableColumn(openingData, "openingBal");
                double sumOpeningData = Convert.ToDouble(_objGirviCommon.getBhandwalWithLastDate(dtFiancialYear.Rows[0]["startyear"].ToString()));
                // Convert.ToDouble(openingData.Rows[0]["Bhandval"].ToString());
                int count = 0;
                if (dtCashDetails.Rows.Count == 0)
                {
                    if (openingData.Rows.Count == 0)
                    {
                        count = 0;
                    }
                    else
                    {
                        dtCashDetails.Rows.Add(openingData.Rows[0]["Date"].ToString(), "", "", "", "", "", sumOpeningData.ToString());
                        count = 1;
                    }
                }

                if (count == 1)
                {
                    double sumdtAddGirvi = 0, sumdtReleaseGirvi = 0, sumdtInterest = 0, sumdtAddAmount = 0, sumdtAmountGiven = 0;
                    int j = 0;
                    int rowGrid = 0;
                    int month = Convert.ToInt32(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).Month);
                    for (int i = 0; i <= (Convert.ToDateTime(dtFiancialYear.Rows[0]["endyear"].ToString()) - Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString())).TotalDays + 1; i++)
                    {
                        //if (Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).Day.ToString() == "2")
                        //{
                        //    j--;
                        //}
                        //string day = Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).Day.ToString();
                        string Date = Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString();
                        //double dtAddGirvi = _objGirviCommon.getAddgirviondate(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtAddGirvi = _objGirviCommon.getAddgirviondate(Date);

                        double dtAmountGiven = _objGirviCommon.getamountaddtotal(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtAddAmount = _objGirviCommon.getexpenseTotal(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString().ToString());

                        double dtReleaseGirvi = _objGirviCommon.getAddreleaseondate(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtInterest = _objGirviCommon.getInterestTotal(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double previousvalue = Convert.ToDouble(dtCashDetails.Rows[(i + 1) - 1][6].ToString());
                        dtCashDetails.Rows.Add(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString(), dtAddGirvi, dtReleaseGirvi, dtInterest, dtAddAmount, dtAmountGiven, (previousvalue + Convert.ToDouble(dtAddGirvi) - Convert.ToDouble(dtReleaseGirvi)).ToString());
                        double final = previousvalue + Convert.ToDouble(dtAddGirvi) + Convert.ToDouble(dtAddAmount) + Convert.ToDouble(dtReleaseGirvi) + Convert.ToDouble(dtInterest);

                        int monthdate = Convert.ToInt32(Convert.ToDateTime(Date).Month);
                        if (month == 13)
                        {
                            month = 1;
                        }
                        if (month == monthdate)
                        {
                            sumdtAddGirvi += dtAddGirvi;
                            sumdtInterest += dtInterest;
                            sumdtReleaseGirvi += dtReleaseGirvi;
                            sumdtAddAmount += dtAddAmount;
                            sumdtAmountGiven += dtAmountGiven;
                        }
                        else
                        {
                            double previous_value = 0;
                            string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                            if (rowGrid == 0)
                            {
                                previous_value = sumOpeningData;
                            }
                            else
                            {
                                string dgv = dgv_CashDetail.Rows[rowGrid - 1].Cells["OpeningValue"].Value.ToString();
                                previous_value = Convert.ToDouble(dgv_CashDetail.Rows[rowGrid - 1].Cells["OpeningValue"].Value.ToString());
                            }
                            dgv_CashDetail.Rows.Add(strMonthName, previous_value, sumdtAddGirvi, sumdtAddGirvi + previous_value, sumdtReleaseGirvi, previousvalue, sumdtInterest, sumdtAddAmount, sumdtAmountGiven);

                            month++;
                            sumdtAddGirvi = 0;
                            sumdtInterest = 0;
                            sumdtReleaseGirvi = 0;
                            sumdtAddAmount = 0;

                            sumdtAddGirvi = _objGirviCommon.getAddgirviondate(Date);

                            sumdtAddAmount = _objGirviCommon.getexpenseTotal(Date);
                            sumdtAmountGiven = _objGirviCommon.getamountaddtotal(Date);

                            sumdtReleaseGirvi = _objGirviCommon.getAddreleaseondate(Date);
                            sumdtInterest = _objGirviCommon.getInterestTotal(Date);





                            rowGrid++;
                        }
                        j++;
                    }
                }
                else
                {
                    MessageBox.Show("Opening Balance is not entered");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bttn_PrintReport_Click(object sender, EventArgs e)
        {
            DataTable data = val.DataGridView2DataTable(dgv_CashDetail, "table");
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataBalanceSheetMonthwise);

            _obj(data, false);
      
            _objfrm_ReportViewer.Show();
        }

        private void Frm_BalansheetMonthly_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            bttn_PrintReport.Text = "प्रिंट";
            bttn_Close.Text = "बंद ";
            bttn_ViewRecord.Text = "रेकॉर्ड बघा ";
            lbl_Date.Text = "दिनांक";


            dgv_CashDetail.Columns["Date"].HeaderText = "दिनांक ";
            dgv_CashDetail.Columns["StartOpening"].HeaderText = "ओपनिग	गहान";
            dgv_CashDetail.Columns["Girviadded"].HeaderText = "ठेवलेला गहान";
            dgv_CashDetail.Columns["TotalGirvi"].HeaderText = "एकूण गहान";
            dgv_CashDetail.Columns["GirviRelease"].HeaderText = " सुटलेला गहान ";
            dgv_CashDetail.Columns["AmountAdded"].HeaderText = "जमा रक्कम ";
            dgv_CashDetail.Columns["AmountGiven"].HeaderText = "रक्क्म दिलेली ";
            dgv_CashDetail.Columns["OpeningValue"].HeaderText = "ओपनिग रक्कम ";
            dgv_CashDetail.Columns["Interest"].HeaderText = "महिन्याचा व्याज";
           
        }

        private void rbt_Marathi_CheckedChanged_1(object sender, EventArgs e)
        {
            bttn_PrintReport.Text = "प्रिंट";
            bttn_Close.Text = "बंद ";
            bttn_ViewRecord.Text = "रेकॉर्ड बघा ";
            lbl_Date.Text = "दिनांक";


            dgv_CashDetail.Columns["Date"].HeaderText = "दिनांक ";
            dgv_CashDetail.Columns["StartOpening"].HeaderText = "ओपनिग	गहान";
            dgv_CashDetail.Columns["Girviadded"].HeaderText = "ठेवलेला गहान";
            dgv_CashDetail.Columns["TotalGirvi"].HeaderText = "एकूण गहान";
            dgv_CashDetail.Columns["GirviRelease"].HeaderText = " सुटलेला गहान ";
            dgv_CashDetail.Columns["AmountAdded"].HeaderText = "जमा रक्कम ";
            dgv_CashDetail.Columns["AmountGiven"].HeaderText = "रक्क्म दिलेली ";
            dgv_CashDetail.Columns["OpeningValue"].HeaderText = "ओपनिग रक्कम ";
            dgv_CashDetail.Columns["Interest"].HeaderText = "महिन्याचा व्याज";

        }
        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            bttn_PrintReport.Text = "प्रिंट";
            bttn_Close.Text = "बंद ";
            bttn_ViewRecord.Text = "रेकॉर्ड बघा ";
            lbl_Date.Text = "दिनांक";


            dgv_CashDetail.Columns["Date"].HeaderText = "दिनांक ";
            dgv_CashDetail.Columns["StartOpening"].HeaderText = "ओपनिग	गहान";
            dgv_CashDetail.Columns["Girviadded"].HeaderText = "ठेवलेला गहान";
            dgv_CashDetail.Columns["TotalGirvi"].HeaderText = "एकूण गहान";
            dgv_CashDetail.Columns["GirviRelease"].HeaderText = " सुटलेला गहान ";
            dgv_CashDetail.Columns["AmountAdded"].HeaderText = "जमा रक्कम ";
            dgv_CashDetail.Columns["AmountGiven"].HeaderText = "रक्क्म दिलेली ";
            dgv_CashDetail.Columns["OpeningValue"].HeaderText = "ओपनिग रक्कम ";
            dgv_CashDetail.Columns["Interest"].HeaderText = "महिन्याचा व्याज";

        }
        private void rbt_English_CheckedChanged(object sender, EventArgs e)
        {
            bttn_PrintReport.Text = "Print";
            bttn_Close.Text = "Close ";
            bttn_ViewRecord.Text = "View Record ";
            lbl_Date.Text = "Date";


            dgv_CashDetail.Columns["Date"].HeaderText = "Date ";
            dgv_CashDetail.Columns["StartOpening"].HeaderText = "Start Opening";
            dgv_CashDetail.Columns["Girviadded"].HeaderText = "Girvi Added";
            dgv_CashDetail.Columns["TotalGirvi"].HeaderText = "Total Girvi";
            dgv_CashDetail.Columns["GirviRelease"].HeaderText = " Girvi Release ";
            dgv_CashDetail.Columns["AmountAdded"].HeaderText = "Amount Added ";
            dgv_CashDetail.Columns["AmountGiven"].HeaderText = "Amount Given ";
            dgv_CashDetail.Columns["OpeningValue"].HeaderText = "Opening Value ";
            dgv_CashDetail.Columns["Interest"].HeaderText = "Interest";
        }

        private void rbt_English_Click(object sender, EventArgs e)
        {

        }

        private void rbt_English_CheckedChanged_1(object sender, EventArgs e)
        {
            bttn_PrintReport.Text = "Print";
            bttn_Close.Text = "Close ";
            bttn_ViewRecord.Text = "View Record ";
            lbl_Date.Text = "Date";


            dgv_CashDetail.Columns["Date"].HeaderText = "Date ";
            dgv_CashDetail.Columns["StartOpening"].HeaderText = "Start Opening";
            dgv_CashDetail.Columns["Girviadded"].HeaderText = "Girvi Added";
            dgv_CashDetail.Columns["TotalGirvi"].HeaderText = "Total Girvi";
            dgv_CashDetail.Columns["GirviRelease"].HeaderText = " Girvi Release ";
            dgv_CashDetail.Columns["AmountAdded"].HeaderText = "Amount Added ";
            dgv_CashDetail.Columns["AmountGiven"].HeaderText = "Amount Given ";
            dgv_CashDetail.Columns["OpeningValue"].HeaderText = "Opening Value ";
            dgv_CashDetail.Columns["Interest"].HeaderText = "Interest";
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            bttn_PrintReport.Text = "प्रिंट";
            bttn_Close.Text = "बंद ";
            bttn_ViewRecord.Text = "रेकॉर्ड बघा ";
            lbl_Date.Text = "दिनांक";


            dgv_CashDetail.Columns["Date"].HeaderText = "दिनांक ";
            dgv_CashDetail.Columns["StartOpening"].HeaderText = "ओपनिग	गहान";
            dgv_CashDetail.Columns["Girviadded"].HeaderText = "ठेवलेला गहान";
            dgv_CashDetail.Columns["TotalGirvi"].HeaderText = "एकूण गहान";
            dgv_CashDetail.Columns["GirviRelease"].HeaderText = " सुटलेला गहान ";
            dgv_CashDetail.Columns["AmountAdded"].HeaderText = "जमा रक्कम ";
            dgv_CashDetail.Columns["AmountGiven"].HeaderText = "रक्क्म दिली ";
            dgv_CashDetail.Columns["OpeningValue"].HeaderText = "ओपनिग रक्कम ";
            dgv_CashDetail.Columns["Interest"].HeaderText = "महिन्याचा व्याज";
        }

      }
    }
