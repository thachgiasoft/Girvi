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

namespace JewelleryManagement.Report.Girvi.ARRequired
{
    public partial class Frm_allkhatawaniGirviAddedDetails : Form
    {

        KhatawaniWithGirviBAL _objKhatwaniWithGirviBal = new KhatawaniWithGirviBAL();
        Validation val = new Validation();
        clsCommon _objCommon = new clsCommon();
        public delegate void SendData(DataTable dtData, string EndDate, bool other);

        public Frm_allkhatawaniGirviAddedDetails()
        {
            InitializeComponent();
        }
        public string interest(string amount, string rate_of_interest, string no_of_days)
        {
            int amt = Convert.ToInt32(amount);
            decimal rate = Convert.ToDecimal(Convert.ToDecimal(rate_of_interest));
            decimal dys = Convert.ToDecimal(Convert.ToInt32(no_of_days));
            decimal intAmount = (((amt * rate) / 100) / 30) * dys;
            return Convert.ToString(Math.Round(intAmount));

        }



        private void bttn_reset_Click(object sender, EventArgs e)
        {
            DataTable data = val.DataGridView2DataTable(dgv_girvidetails, "table");
            //clsVariable.ReportType = "KhatawaniWithGirviOnlyAdded";
            //clsVariable.enddate = dtp_enddate.Text;
            //Mortgage.RokadAllReport _objReport = new Mortgage.RokadAllReport(data);
            //_objReport.Show();


        }

        private void Frm_allkhatawaniGirviAddedDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Show_Click(object sender, EventArgs e)
        {
            dgv_girvidetails.Rows.Clear();

            DataTable dtGirvi = null;
            DataTable dtkhatawniDetails = null;
            DataTable dtkhatawani = _objKhatwaniWithGirviBal.getallkhatawaniNoinGirvi();
            int SrNo = 1;
            for (int i = 0; i < dtkhatawani.Rows.Count; i++)
            {
                string khatawani_no = dtkhatawani.Rows[i]["khatawani_No"].ToString();

                dtGirvi = _objKhatwaniWithGirviBal.getallgirvidata(khatawani_no, dtp_StartDate.Text, dtp_EndDate.Text);
                dtkhatawniDetails = _objKhatwaniWithGirviBal.getkhatawanidetail(khatawani_no);

                for (int j = 0; j < dtGirvi.Rows.Count; j++)
                {
                    if (dtGirvi.Rows[j]["status"].ToString() == "unchange")
                    {
                        string name = dtkhatawniDetails.Rows[0]["FullName"].ToString();
                        string address = dtkhatawniDetails.Rows[0]["Address"].ToString();
                        string khno = dtkhatawniDetails.Rows[0]["khatawani_No"].ToString();

                        string datenaave = dtGirvi.Rows[j]["Date_of_deposit"].ToString();
                        string amountnaave = dtGirvi.Rows[j]["Amount"].ToString();
                        string interest_rate = dtGirvi.Rows[j]["interset_rate"].ToString();
                        string ReceiptNo = dtGirvi.Rows[j]["receipt_no"].ToString();

                        string no_of_days = ((Convert.ToDateTime(dtp_EndDate.Text) - Convert.ToDateTime(datenaave)).TotalDays).ToString();

                        string intrest_amt = interest(amountnaave, interest_rate, no_of_days);
                        double sum_amtnaave_interest = Convert.ToDouble(amountnaave) + Convert.ToDouble(intrest_amt);

                        string gn = dtGirvi.Rows[j]["GirviRecordNo"].ToString();
                        string girviMetal = _objKhatwaniWithGirviBal.GetGirviItemMetalByGirviNo(gn);


                        //if (j == 0)
                        //{
                        dgv_girvidetails.Rows.Add(SrNo, name, address, khno, girviMetal, datenaave, amountnaave, "", "", "", "", amountnaave, intrest_amt, sum_amtnaave_interest.ToString(), "", ReceiptNo);
                        //}
                        //else
                        //{
                        //    dgv_girvidetails.Rows.Add("", "", "", girviMetal, datenaave, amountnaave, "", "", "", "", amountnaave, intrest_amt, sum_amtnaave_interest.ToString(), "");

                        //}
                        SrNo++;
                    }
                    else
                    {
                        string name = dtkhatawniDetails.Rows[0]["FullName"].ToString();
                        string address = dtkhatawniDetails.Rows[0]["Address"].ToString();
                        string khno = dtkhatawniDetails.Rows[0]["khatawani_No"].ToString();

                        string datenaave = dtGirvi.Rows[j]["Date_of_deposit"].ToString();
                        string amountnaave = dtGirvi.Rows[j]["Amount"].ToString();
                        string gn = dtGirvi.Rows[j]["GirviRecordNo"].ToString();
                        string girviMetal = _objKhatwaniWithGirviBal.GetGirviItemMetalByGirviNo(gn);
                        string ReceiptNo = dtGirvi.Rows[j]["receipt_no"].ToString();


                        DataTable dtGirviReleaseDetails = _objKhatwaniWithGirviBal.getAllReleaseGirvidataByGirviNo(dtGirvi.Rows[j]["GirviRecordNo"].ToString());
                        string interest_amt = dtGirviReleaseDetails.Rows[0]["Interest_Amount"].ToString();
                        string daterelease = dtGirviReleaseDetails.Rows[0]["dateOfRelease"].ToString();
                        string sum_amtjama_interest = dtGirviReleaseDetails.Rows[0]["IntersetPaid"].ToString();


                        //if (j == 0)
                        //{
                        dgv_girvidetails.Rows.Add(SrNo, name, address, khno, girviMetal, datenaave, amountnaave, daterelease, amountnaave, interest_amt, sum_amtjama_interest, "", "", "", "", ReceiptNo);
                        //}
                        //else
                        //{
                        //    dgv_girvidetails.Rows.Add("", "", "",girviMetal, datenaave, amountnaave, daterelease, amountnaave, interest_amt, sum_amtjama_interest, "", "", "", "");
                        //}
                        SrNo++;

                    }

                }
            }
            double sumekunjama = _objCommon.sumGridViewColumn(dgv_girvidetails, "ekunjama");
            double Summuddalnaave = _objCommon.sumGridViewColumn(dgv_girvidetails, "muddalnaave");
            double sumeekunbaki = _objCommon.sumGridViewColumn(dgv_girvidetails, "ekunbaki");

            double summuddaljama = _objCommon.sumGridViewColumn(dgv_girvidetails, "muddaljama");
            double Sumvyajjama = _objCommon.sumGridViewColumn(dgv_girvidetails, "vyajjama");
            double summuddalbaki = _objCommon.sumGridViewColumn(dgv_girvidetails, "muddalbaki");

            double sumvyajbaki = _objCommon.sumGridViewColumn(dgv_girvidetails, "vyajbaki");


            dgv_girvidetails.Rows.Add("", "", "", "", "", "Total", Summuddalnaave, "", summuddaljama, Sumvyajjama, sumekunjama, summuddalbaki, sumvyajbaki, sumeekunbaki);




        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {

            DataTable data = val.DataGridView2DataTable(dgv_girvidetails, "table");
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataAllKhatawaniGirviAddedDetails);
            if (rbt_OtherTrue.Checked == true)
            {
                _obj(data, dtp_EndDate.Text, true);
            }
            else
            {
                _obj(data, dtp_EndDate.Text, false);

            }
            _objfrm_ReportViewer.Show();

        }

        private void Frm_allkhatawaniGirviAddedDetails_Load(object sender, EventArgs e)
        {
            setDateAsFinancialYear();
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
        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {

            int sizetext = 12;
            grp_Date.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            lbl_startDate.Text = "शुरवात तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            this.Text = "खातावनीसे जुडी गिरवी पुरी नही छुटी हुई ";
            bttn_Print.Text = "प्रिंट रिपोर्ट";
            bttn_View.Text = "रिकोर्ड बघा";
            bttn_Close.Text = "बंद";
            dgv_girvidetails.Columns["SrNo"].HeaderText = "नं.";
            dgv_girvidetails.Columns["name"].HeaderText = "नाम";
            dgv_girvidetails.Columns["address"].HeaderText = "पत्ता";
            dgv_girvidetails.Columns["khno"].HeaderText = "खा नं. ";
            dgv_girvidetails.Columns["metal"].HeaderText = "मेटल";
            dgv_girvidetails.Columns["datenaave"].HeaderText = "तारीख";
            dgv_girvidetails.Columns["muddalnaave"].HeaderText = "मुद्दल";
            dgv_girvidetails.Columns["datejama"].HeaderText = "तारीख ";
            dgv_girvidetails.Columns["muddaljama"].HeaderText = "मुद्दल";
            dgv_girvidetails.Columns["vyajjama"].HeaderText = "व्याज";
            dgv_girvidetails.Columns["ekunjama"].HeaderText = "एकूण";
            dgv_girvidetails.Columns["muddalbaki"].HeaderText = "मुद्दल";
            dgv_girvidetails.Columns["vyajbaki"].HeaderText = "व्याज";
            dgv_girvidetails.Columns["ekunbaki"].HeaderText = "एकूण";
            dgv_girvidetails.Columns["vyajbaki"].HeaderText = "व्याज";
            dgv_girvidetails.Columns["ekunbaki"].HeaderText = "एकूण";
            dgv_girvidetails.Columns["shera"].HeaderText = "सेरा";
            dgv_girvidetails.Columns["ReceiptNo"].HeaderText = "पावती क्र.";
            lbl_startDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Date.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            lbl_startDate.Text = "शुरवात तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            this.Text = "खातावनीशी संबंधित गाहणी सोडवलेली,नसोडवलेली ";
            bttn_Print.Text = "प्रिंट रिपोर्ट";
            bttn_View.Text = "रिकोर्ड बघा";
            bttn_Close.Text = "बंद";
            dgv_girvidetails.Columns["SrNo"].HeaderText = "नं.";
            dgv_girvidetails.Columns["name"].HeaderText = "नाम";
            dgv_girvidetails.Columns["address"].HeaderText = "पत्ता";
            dgv_girvidetails.Columns["khno"].HeaderText = "खा नं. ";
            dgv_girvidetails.Columns["metal"].HeaderText = "मेटल";
            dgv_girvidetails.Columns["datenaave"].HeaderText = "तारीख";
            dgv_girvidetails.Columns["muddalnaave"].HeaderText = "मुद्दल";
            dgv_girvidetails.Columns["datejama"].HeaderText = "तारीख ";
            dgv_girvidetails.Columns["muddaljama"].HeaderText = "मुद्दल";
            dgv_girvidetails.Columns["vyajjama"].HeaderText = "व्याज";
            dgv_girvidetails.Columns["ekunjama"].HeaderText = "एकूण";
            dgv_girvidetails.Columns["muddalbaki"].HeaderText = "मुद्दल";
            dgv_girvidetails.Columns["vyajbaki"].HeaderText = "व्याज";
            dgv_girvidetails.Columns["ekunbaki"].HeaderText = "एकूण";
            dgv_girvidetails.Columns["vyajbaki"].HeaderText = "व्याज";
            dgv_girvidetails.Columns["ekunbaki"].HeaderText = "एकूण";
            dgv_girvidetails.Columns["shera"].HeaderText = "सेरा";
            dgv_girvidetails.Columns["ReceiptNo"].HeaderText = "पावती क्र.";
            lbl_startDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Date.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            lbl_startDate.Text = "शुरवात तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            this.Text = "खातावनीशी संबंधित गाहणी सोडवलेली,नसोडवलेली ";
            bttn_Print.Text = "प्रिंट रिपोर्ट";
            bttn_View.Text = "रिकोर्ड बघा";
            bttn_Close.Text = "बंद";
            dgv_girvidetails.Columns["SrNo"].HeaderText = "नं.";
            dgv_girvidetails.Columns["name"].HeaderText = "नाम";
            dgv_girvidetails.Columns["address"].HeaderText = "पत्ता";
            dgv_girvidetails.Columns["khno"].HeaderText = "खा नं. ";
            dgv_girvidetails.Columns["metal"].HeaderText = "मेटल";
            dgv_girvidetails.Columns["datenaave"].HeaderText = "तारीख";
            dgv_girvidetails.Columns["muddalnaave"].HeaderText = "मुद्दल";
            dgv_girvidetails.Columns["datejama"].HeaderText = "तारीख ";
            dgv_girvidetails.Columns["muddaljama"].HeaderText = "मुद्दल";
            dgv_girvidetails.Columns["vyajjama"].HeaderText = "व्याज";
            dgv_girvidetails.Columns["ekunjama"].HeaderText = "एकूण";
            dgv_girvidetails.Columns["muddalbaki"].HeaderText = "मुद्दल";
            dgv_girvidetails.Columns["vyajbaki"].HeaderText = "व्याज";
            dgv_girvidetails.Columns["ekunbaki"].HeaderText = "एकूण";
            dgv_girvidetails.Columns["vyajbaki"].HeaderText = "व्याज";
            dgv_girvidetails.Columns["ekunbaki"].HeaderText = "एकूण";
            dgv_girvidetails.Columns["shera"].HeaderText = "सेरा";
            dgv_girvidetails.Columns["ReceiptNo"].HeaderText = "पावती क्र.";
            lbl_startDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
