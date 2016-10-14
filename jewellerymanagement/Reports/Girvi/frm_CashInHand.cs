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
using System.Drawing.Text;
namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_CashInHand : Form
    {
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsCommon _objCommon = new clsCommon();
        Validation val = new Validation();
        public delegate void SendData(DataTable dtData, string EndDate, bool Other);
        public frm_CashInHand()
        {
            InitializeComponent();
        }

        private void frm_CashInHand_KeyDown(object sender, KeyEventArgs e)
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

        private void frm_CashInHand_Load(object sender, EventArgs e)
        {
            setDateAsFinancialYear();
            SetFont();
            dgv_CashDetail.Rows.Clear();
        }
        private void setDateAsFinancialYear()
        {
            try
            {
                ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
                DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
                dtp_StartDate.Text = dtFiancialYear.Rows[0]["startyear"].ToString();
                dtp_EndDate.Text = dtFiancialYear.Rows[0]["endyear"].ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void ShivajiFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
            }
            //dateTimePicker1.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_StartDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_khatawaniNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_Srno.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_DateOfDeposite.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_InterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_Loanamount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_DepositDays.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_InterestAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_InterestPaid.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_TotalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_PayAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_FinalWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_FinalWtInPercent.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_FineWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_Quantity.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_ActualRate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_TotalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_FinalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_InterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_EstimateInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_LoanAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_DateOfDeposit.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_Duration.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            // System.ComponentModel.TypeConverter converter = 
        }

        private void SetFont()
        {
            ShivajiFont();

        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            this.Text = "रोकड रक्कम जमा";
            label1.Text = "तारीख";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_StartDate.Text = "सुरवात तारीख";
            bttn_Close.Text = "बंद";
            bttn_Opening.Text = "ओपेनिंग";
            bttn_PrintReport.Text = "प्रिंट रिपोर्ट";
            bttn_ViewRecord.Text = "रिकोर्ड बघा";

            dgv_CashDetail.Columns["Date"].HeaderText = "तारीख";
            dgv_CashDetail.Columns["GirviAdded"].HeaderText = "नावे";
            dgv_CashDetail.Columns["GirviRelease"].HeaderText = "जमा";
            dgv_CashDetail.Columns["Interest"].HeaderText = "व्याज";
            dgv_CashDetail.Columns["OtherAmountAdded"].HeaderText = "इतर जमा";
            dgv_CashDetail.Columns["OpeningValue"].HeaderText = "ओपेनिंग रक्कम";
            dgv_CashDetail.Columns["OtherExpence"].HeaderText = "इतर खर्च";
            dgv_CashDetail.Columns["Diffrence"].HeaderText = "फरक";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
            lbl_Date.Font = new Font("Arial", sizetext);

        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            this.Text = "रोकड रक्कम जमा";
            label1.Text = "तारीख";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            lbl_StartDate.Text = "शुरवात तारीख";
            bttn_Close.Text = "बंद";
            bttn_Opening.Text = "ओपेनिंग";
            bttn_PrintReport.Text = "प्रिंट रिपोर्ट";
            bttn_ViewRecord.Text = "रिकोर्ड देखिये";

            dgv_CashDetail.Columns["Date"].HeaderText = "तारीख";
            dgv_CashDetail.Columns["GirviAdded"].HeaderText = "जमा";
            dgv_CashDetail.Columns["GirviRelease"].HeaderText = "नावे";
            dgv_CashDetail.Columns["Interest"].HeaderText = "ब्याज";
            dgv_CashDetail.Columns["OtherAmountAdded"].HeaderText = "इतर जमा";
            dgv_CashDetail.Columns["OpeningValue"].HeaderText = "ओपेनिंग रक्कम";
            dgv_CashDetail.Columns["OtherExpence"].HeaderText = "इतर खर्च";
            dgv_CashDetail.Columns["Diffrence"].HeaderText = "फरक";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
            lbl_Date.Font = new Font("Arial", sizetext);

        }

        private void bttn_ViewRecord_Click(object sender, EventArgs e)
        {
            DataTable openingData = new DataTable();
            try
            {
                openingData = _objGirviCommon.getOpeningLedger("Cash-In-Hand");
                double sumOpeningData = _objCommon.sumDataTableColumn(openingData, "openingBal");
                int count = 0;
                if (dgv_CashDetail.Rows.Count == 0)
                {
                    if (openingData.Rows.Count == 0)
                    {
                        count = 0;
                    }
                    else
                    {
                        dgv_CashDetail.Rows.Add(openingData.Rows[0][4].ToString(), "", "", "", "", "", sumOpeningData.ToString());
                        count = 1;
                    }
                }

                if (count == 1)
                {
                    int j = 0;
                    for (int i = 0; i <= (Convert.ToDateTime(dtp_date.Text) - Convert.ToDateTime(openingData.Rows[0][4].ToString())).TotalDays; i++)
                    {
                        double dtAddGirvi = _objGirviCommon.getAddgirviondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtReleaseGirvi = _objGirviCommon.getAddreleaseondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtInterest = _objGirviCommon.getInterestTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtExpense = _objGirviCommon.getexpenseTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtAddamt = _objGirviCommon.getamountaddtotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double previousvalue = Convert.ToDouble(dgv_CashDetail.Rows[(i + 1) - 1].Cells[6].Value.ToString());
                        double diffrence = dtAddGirvi - dtReleaseGirvi;
                        dgv_CashDetail.Rows.Add(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString(), dtAddGirvi, dtReleaseGirvi, dtInterest, dtAddamt, dtExpense, (previousvalue - Convert.ToDouble(dtAddGirvi) + Convert.ToDouble(dtReleaseGirvi) + Convert.ToDouble(dtInterest) + Convert.ToDouble(dtExpense) - Convert.ToDouble(dtAddamt)).ToString(), diffrence);
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
            int start = 0, end = 0;
            for (int i = 0; i < dgv_CashDetail.Rows.Count; i++)
            {
                if (data.Rows[i]["Date"].ToString() == dtp_StartDate.Text)
                {
                    start = i;
                }
                if (data.Rows[i]["Date"].ToString() == dtp_EndDate.Text)
                {
                    end = i;
                }
            }

            DataTable dataNew = val.DataGridView2DataTable(dgv_CashDetail, "table");
            dataNew.Rows.Clear();

            int j = 0;
            for (int i = start - 1; i <= end; i++)
            {
                dataNew.Rows.Add();
                dataNew.Rows[j]["Date"] = data.Rows[i]["Date"].ToString();
                //dataNew.Rows[j]["RokadPan"] = data.Rows[i]["RokadPan"].ToString();
                dataNew.Rows[j]["GirviAdded"] = data.Rows[i]["GirviAdded"].ToString();
                dataNew.Rows[j]["GirviRelease"] = data.Rows[i]["GirviRelease"].ToString();
                dataNew.Rows[j]["Interest"] = data.Rows[i]["Interest"].ToString();
                dataNew.Rows[j]["OtherExpence"] = data.Rows[i]["OtherExpence"].ToString();
                dataNew.Rows[j]["OtherAmountAdded"] = data.Rows[i]["OtherAmountAdded"].ToString();
                dataNew.Rows[j]["OpeningValue"] = data.Rows[i]["OpeningValue"].ToString();
                dataNew.Rows[j]["Diffrence"] = data.Rows[i]["Diffrence"].ToString();
                j++;
            }
            dataNew.Rows[0]["Date"] = "";
            dataNew.Rows[0]["Interest"] = "";
            dataNew.Rows[0]["GirviAdded"] = "";
            dataNew.Rows[0]["GirviRelease"] = "";
            dataNew.Rows[0]["OtherExpence"] = "";
            dataNew.Rows[0]["OtherAmountAdded"] = "";
            dataNew.Rows[0]["Diffrence"] = "";

            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveCashInHand);
            if (rbt_OtherTrue.Checked == true)
            {
                _obj(dataNew, dtp_EndDate.Text, true);
            }
            else
            {
                _obj(dataNew, dtp_EndDate.Text, false);

            }
            _objfrm_ReportViewer.Show();
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            this.Text = "रोकड रक्कम जमा";
            label1.Text = "तारीख";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_StartDate.Text = "सुरवात तारीख";
            bttn_Close.Text = "बंद";
            bttn_Opening.Text = "ओपेनिंग";
            bttn_PrintReport.Text = "प्रिंट रिपोर्ट";
            bttn_ViewRecord.Text = "रिकोर्ड बघा";

            dgv_CashDetail.Columns["Date"].HeaderText = "तारीख";
            dgv_CashDetail.Columns["GirviAdded"].HeaderText = "जमा";
            dgv_CashDetail.Columns["GirviRelease"].HeaderText = "नावे";
            dgv_CashDetail.Columns["Interest"].HeaderText = "व्याज";
            dgv_CashDetail.Columns["OtherAmountAdded"].HeaderText = "इतर जमा";
            dgv_CashDetail.Columns["OpeningValue"].HeaderText = "ओपेनिंग रक्कम";
            dgv_CashDetail.Columns["Diffrence"].HeaderText = "फरक";
            dgv_CashDetail.Columns["OtherExpence"].HeaderText = "इतर खर्च";
            dgv_CashDetail.Columns["Diffrence"].HeaderText = "फरक";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
            lbl_Date.Font = new Font("Arial", sizetext);

        }

        private void dtp_date_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void dtp_StartDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void dtp_EndDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }
    }
}
