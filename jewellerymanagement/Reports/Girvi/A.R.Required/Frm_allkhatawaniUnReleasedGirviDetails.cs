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
using System.Drawing.Text;
using BAL.Common;

namespace JewelleryManagement.Report.Girvi.ARRequired
{
    public partial class Frm_allkhatawaniUnReleasedGirviDetails : Form
    {
       
        KhatawaniWithGirviBAL _objKhatwaniWithGirviBal = new KhatawaniWithGirviBAL();
        Validation val = new Validation();
        clsCommon _objCommon = new clsCommon();
        public delegate void SendData(DataTable dtData, string IntrestDate, string EndDate, string StartDate,bool other);

        public Frm_allkhatawaniUnReleasedGirviDetails()
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

        private void bttn_View_Click(object sender, EventArgs e)
        {
            dgv_girvidetails.Rows.Clear();
            DataTable dtGirvi=null;
            DataTable dtkhatawniDetails = null;
            DataTable dtkhatawani = _objKhatwaniWithGirviBal.getallkhatawaniNoinGirvi();
            int SrNo = 1;
            for (int i = 0; i < dtkhatawani.Rows.Count; i++)
            {
                string khatawani_no = dtkhatawani.Rows[i]["khatawani_No"].ToString();

                dtGirvi = _objKhatwaniWithGirviBal.getallgirvidata(khatawani_no, dtp_StartDate.Text, dtp_EndDate.Text);
                dtkhatawniDetails = _objKhatwaniWithGirviBal.getkhatawanidetail(khatawani_no);

                for(int j=0;j<dtGirvi.Rows.Count;j++)
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

                        dgv_girvidetails.Rows.Add(SrNo, name, address, khno, girviMetal, datenaave, amountnaave, "", "", "", "", amountnaave, intrest_amt, sum_amtnaave_interest.ToString(), "");
                        SrNo++;
                    }
                }
            }
            double sumamount = 0;
            double SumNaveAmount = 0;
            
            for (int j = 0; j < dgv_girvidetails.Rows.Count; j++)
            {
                if (dgv_girvidetails.Rows[j].Cells["muddalnaave"].Value.ToString() != "")
                {
                    SumNaveAmount = SumNaveAmount + Convert.ToDouble(dgv_girvidetails.Rows[j].Cells["muddalnaave"].Value);
                }
                if (dgv_girvidetails.Rows[j].Cells["ekunbaki"].Value.ToString() != "")
                {
                    sumamount = sumamount + Convert.ToDouble(dgv_girvidetails.Rows[j].Cells["ekunbaki"].Value);
                }
            }
            dgv_girvidetails.Rows.Add("", "", "", "", "", "Total", SumNaveAmount, "", "","","","","", sumamount, "" );
        }

       

        private void Frm_allkhatawaniUnReleasedGirviDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgv_girvidetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Frm_allkhatawaniUnReleasedGirviDetails_Load(object sender, EventArgs e)
        {
            setDateAsFinancialYear();
            SetFont();
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
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
            //dtp_vyapariSale.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_StartDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_InterestDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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
            if (rbt_OtherTrue.Checked == true)
            {
                ShivajiFont();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
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
                    int resultless = 0;
                    //int resultgreat = 0;
                    if (dtGirvi.Rows[j]["withdraw_release_date"].ToString() != "")
                    {
                        resultless = DateTime.Compare(Convert.ToDateTime(dtGirvi.Rows[j]["withdraw_release_date"].ToString()), Convert.ToDateTime(dtp_EndDate.Text));
                        //resultgreat = DateTime.Compare(Convert.ToDateTime(dtGirvi.Rows[j]["withdraw_release_date"].ToString()), Convert.ToDateTime(dtp_StartDate.Text));
                    }
                    if (dtGirvi.Rows[j]["status"].ToString() != "unchange" && (resultless > 0))
                    {
                        string name = dtkhatawniDetails.Rows[0]["FullName"].ToString();
                        string address = dtkhatawniDetails.Rows[0]["Address"].ToString();
                        string MobileNo = dtkhatawniDetails.Rows[0]["Contact_No"].ToString();
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
                        dgv_girvidetails.Rows.Add(SrNo, name, address,MobileNo, khno, girviMetal, datenaave, amountnaave, "", "", "", "", amountnaave, intrest_amt, sum_amtnaave_interest.ToString(), ReceiptNo,"");
                        //}
                        //else
                        //{
                        //    dgv_girvidetails.Rows.Add("", "", "", girviMetal, datenaave, amountnaave, "", "", "", "", amountnaave, intrest_amt, sum_amtnaave_interest.ToString(), "");

                        //}
                        SrNo++;
                    }
                    else if (dtGirvi.Rows[j]["status"].ToString() == "unchange")
                    {

                    //}

                    //if (dtGirvi.Rows[j]["status"].ToString() == "unchange")
                    //{
                        string name = dtkhatawniDetails.Rows[0]["FullName"].ToString();
                        string address = dtkhatawniDetails.Rows[0]["Address"].ToString();
                        string MobileNo = dtkhatawniDetails.Rows[0]["Contact_No"].ToString();
                        string khno = dtkhatawniDetails.Rows[0]["khatawani_No"].ToString();

                        string datenaave = dtGirvi.Rows[j]["Date_of_deposit"].ToString();
                        string amountnaave = dtGirvi.Rows[j]["Amount"].ToString();
                        string interest_rate = dtGirvi.Rows[j]["interset_rate"].ToString();

                        string ReceiptNo = dtGirvi.Rows[j]["receipt_no"].ToString();

                        string no_of_days = ((Convert.ToDateTime(dtp_InterestDate.Text) - Convert.ToDateTime(datenaave)).TotalDays).ToString();

                        string intrest_amt = interest(amountnaave, interest_rate, no_of_days);
                        double sum_amtnaave_interest = Convert.ToDouble(amountnaave) + Convert.ToDouble(intrest_amt);

                        string gn = dtGirvi.Rows[j]["GirviRecordNo"].ToString();
                        string girviMetal = _objKhatwaniWithGirviBal.GetGirviItemMetalByGirviNo(gn);

                        dgv_girvidetails.Rows.Add(SrNo, name, address,MobileNo, khno, girviMetal, datenaave, amountnaave, "", "", "", "", amountnaave, intrest_amt, sum_amtnaave_interest.ToString(), ReceiptNo,"");
                        SrNo++;
                    }
                }
            }
            //double sumamount = 0;
            //double SumNaveAmount = 0;

            //for (int j = 0; j < dgv_girvidetails.Rows.Count; j++)
            //{
            //    if (dgv_girvidetails.Rows[j].Cells["muddalnaave"].Value.ToString() != "")
            //    {
            //        SumNaveAmount = SumNaveAmount + Convert.ToDouble(dgv_girvidetails.Rows[j].Cells["muddalnaave"].Value);
            //    }
            //    if (dgv_girvidetails.Rows[j].Cells["ekunbaki"].Value.ToString() != "")
            //    {
            //        sumamount = sumamount + Convert.ToDouble(dgv_girvidetails.Rows[j].Cells["ekunbaki"].Value);
            //    }
            //}
            //dgv_girvidetails.Rows.Add("", "", "", "", "", "Total", SumNaveAmount, "", "", "", "", "", "", sumamount, "");

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
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataAllKhatawaniUnReleaseGirviDetails);
            if (rbt_OtherTrue.Checked == true)
            {
                _obj(data, dtp_InterestDate.Text,dtp_EndDate.Text,dtp_StartDate.Text,true);
            }
            else
            {
                _obj(data, dtp_InterestDate.Text, dtp_EndDate.Text, dtp_StartDate.Text, false);

            }
            _objfrm_ReportViewer.Show();
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Date.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            lbl_StartDate.Text = "शुरवात तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            this.Text = "खातावनीसे जुडी गिरवी नही छुटी हुई ";
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
            dgv_girvidetails.Columns["shera"].HeaderText = "शेरा";
            dgv_girvidetails.Columns["MobileNo"].HeaderText = "मोबाईल नं";
            dgv_girvidetails.Columns["ReceiptNo"].HeaderText = "पावती क्र.";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {

            int sizetext = 12;
            grp_Date.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            lbl_StartDate.Text = "शुरवात तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            this.Text = "खातावनीशी संबंधित गाहणी नसोडलेली ";
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
            dgv_girvidetails.Columns["shera"].HeaderText = "शेरा";
            dgv_girvidetails.Columns["MobileNo"].HeaderText = "मोबाईल नं";
            dgv_girvidetails.Columns["ReceiptNo"].HeaderText = "पावती क्र.";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {

            int sizetext = 12;
            grp_Date.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            lbl_StartDate.Text = "शुरवात तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            this.Text = "खातावनीशी संबंधित गाहणी नसोडलेली ";
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
            dgv_girvidetails.Columns["shera"].HeaderText = "शेरा";
            dgv_girvidetails.Columns["MobileNo"].HeaderText = "मोबाईल नं";
            dgv_girvidetails.Columns["ReceiptNo"].HeaderText = "पावती क्र.";
            lbl_StartDate.Font = new Font("Arial", sizetext);
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

        private void dtp_InterestDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        
    }
}
