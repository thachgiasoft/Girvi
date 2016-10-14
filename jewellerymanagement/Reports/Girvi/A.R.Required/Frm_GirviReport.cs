using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Reports.Girvi;
using BAL;

namespace JewelleryManagement.Reports.Girvi.A.R.Required
{
    public partial class Frm_GirviReport : Form
    {
        public Frm_GirviReport()
        {
            InitializeComponent();
        }
        KhatawaniWithGirviBAL _objKhatwaniWithGirviBal = new KhatawaniWithGirviBAL();
        Validation val = new Validation();
        public delegate void SendData(DataTable dtData, bool Other);
        private void bttn_View_Click(object sender, EventArgs e)
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
                        // string no_of_days = ((Convert.ToDateTime(dtp_InterestDate.Text) - Convert.ToDateTime(datenaave)).TotalDays).ToString();

                        //  string intrest_amt = interest(amountnaave, interest_rate, no_of_days);
                        // double sum_amtnaave_interest = Convert.ToDouble(amountnaave) + Convert.ToDouble(intrest_amt);
                        //double sum_Amtnaave = Convert.ToDouble(amountnaave) + Convert.ToDouble(intrest_amt);

                        string gn = dtGirvi.Rows[j]["GirviRecordNo"].ToString();
                        DataTable girviMetal = _objKhatwaniWithGirviBal.GetGirviItem(gn);
                        string Metal = girviMetal.Rows[0]["metal_type"].ToString().Trim() + "  " + girviMetal.Rows[0]["item_type"].ToString().Trim();
                        string qty = girviMetal.Rows[0]["Total_Quantity"].ToString();
                        string wt = girviMetal.Rows[0]["gross_wt"].ToString();
                        string net = girviMetal.Rows[0]["net_wt"].ToString();


                        //if (j == 0)
                        //{
                        dgv_girvidetails.Rows.Add(SrNo, khno, ReceiptNo, datenaave, amountnaave, name, address, Metal, qty, wt, net, "", "");
                        //}
                        //else
                        //{
                        //    dgv_girvidetails.Rows.Add("", "", "", girviMetal, datenaave, amountnaave, "", "", "", "", amountnaave, intrest_amt, sum_amtnaave_interest.ToString(), "");

                        //}\
                        SrNo++;
                    }
                    else
                    {
                        string name = dtkhatawniDetails.Rows[0]["FullName"].ToString();
                        string address = dtkhatawniDetails.Rows[0]["Address"].ToString();
                        string khno = dtkhatawniDetails.Rows[0]["khatawani_No"].ToString();

                        string datenaave = dtGirvi.Rows[j]["Date_of_deposit"].ToString();
                        string amountnaave = dtGirvi.Rows[j]["Amount"].ToString();
                        string girvino = dtGirvi.Rows[j]["receipt_no"].ToString();
                        string gn = dtGirvi.Rows[j]["GirviRecordNo"].ToString();
                        DataTable girviMetal = _objKhatwaniWithGirviBal.GetGirviItem(gn);
                        string Metal = girviMetal.Rows[0]["metal_type"].ToString().Trim() + "  " + girviMetal.Rows[0]["item_type"].ToString().Trim();
                        string qty = girviMetal.Rows[0]["Total_Quantity"].ToString();
                        string wt = girviMetal.Rows[0]["gross_wt"].ToString();
                        string net = girviMetal.Rows[0]["net_wt"].ToString();
                        


                        DataTable dtGirviReleaseDetails = _objKhatwaniWithGirviBal.getAllReleaseGirvidataByGirviNo(dtGirvi.Rows[j]["GirviRecordNo"].ToString());
                        string interest_amt = dtGirviReleaseDetails.Rows[0]["Interest_Amount"].ToString();
                        string daterelease = dtGirviReleaseDetails.Rows[0]["dateOfRelease"].ToString();
                        string sum_amtjama_interest = dtGirviReleaseDetails.Rows[0]["IntersetPaid"].ToString();
                        string ReceiptNo = dtGirviReleaseDetails.Rows[0]["pavtino"].ToString();

                        //if (j == 0),
                        //{
                        dgv_girvidetails.Rows.Add(SrNo, khno, girvino, datenaave, amountnaave, name, address, Metal, qty, wt, net, daterelease, ReceiptNo);
                        //}
                        //else
                        //{
                        //    dgv_girvidetails.Rows.Add("", "", "",girviMetal, datenaave, amountnaave, daterelease, amountnaave, interest_amt, sum_amtjama_interest, "", "", "", "");
                        //}

                        SrNo++;
                    }
                }
            }
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {

            bttn_View.Text = "रिकॉर्ड बघा";
            this.Text = "गाहनी रिपोर्ट";
            lbl_Date.Text = "तारीख";
            lbl_EndingDate.Text = "शेवट तारीख";
            lbl_startDate.Text = "सुरवात तारीख";
            bttn_Close.Text = "बंद";
            bttn_Print.Text = "प्रिंट";

            dgv_girvidetails.Columns["SrNo"].HeaderText = "क्र.";
            dgv_girvidetails.Columns["khno"].HeaderText = "खतावणी क्र.";
            dgv_girvidetails.Columns["GahanNo"].HeaderText = "गाहनी क्र.";
            dgv_girvidetails.Columns["datenaave"].HeaderText = "तारीख";
            dgv_girvidetails.Columns["muddalnaave"].HeaderText = "रक्कम";
            dgv_girvidetails.Columns["Name"].HeaderText = "नाव";
            dgv_girvidetails.Columns["Address"].HeaderText = "पत्ता";
            dgv_girvidetails.Columns["MetalDiscription"].HeaderText = "वस्तूचे वर्णन";
            dgv_girvidetails.Columns["Qty"].HeaderText = "प्रमाण";
            dgv_girvidetails.Columns["Wt"].HeaderText = "वजन";
            dgv_girvidetails.Columns["NetWt"].HeaderText = "नेट वजन";
            dgv_girvidetails.Columns["ReleaseDate"].HeaderText = "सोडवण्याची तारीख";
            dgv_girvidetails.Columns["RecieptNo"].HeaderText = "पावती क्र. ";
            
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            bttn_View.Text = "रिकॉर्ड बघा";
            this.Text = "गाहनी रिपोर्ट";
            lbl_Date.Text = "तारीख";
            lbl_EndingDate.Text = "अंतिम तारीख";
            lbl_startDate.Text = "शुरवात तारीख";
            bttn_Close.Text = "बंद";
            bttn_Print.Text = "प्रिंट";

            dgv_girvidetails.Columns["SrNo"].HeaderText = "क्र.";
            dgv_girvidetails.Columns["khno"].HeaderText = "खतावणी क्र.";
            dgv_girvidetails.Columns["GahanNo"].HeaderText = "गिरवी क्र.";
            dgv_girvidetails.Columns["datenaave"].HeaderText = "तारीख";
            dgv_girvidetails.Columns["muddalnaave"].HeaderText = "रक्कम";
            dgv_girvidetails.Columns["Name"].HeaderText = "नाम";
            dgv_girvidetails.Columns["Address"].HeaderText = "पत्ता";
            dgv_girvidetails.Columns["MetalDiscription"].HeaderText = "वस्तूचे वर्णन";
            dgv_girvidetails.Columns["Qty"].HeaderText = "प्रमाण";
            dgv_girvidetails.Columns["Wt"].HeaderText = "वजन";
            dgv_girvidetails.Columns["NetWt"].HeaderText = "नेट वजन";
            dgv_girvidetails.Columns["ReleaseDate"].HeaderText = "सोडवण्याची तारीख";
            dgv_girvidetails.Columns["RecieptNo"].HeaderText = "पावती क्र. ";

        }

        private void rbt_English_CheckedChanged(object sender, EventArgs e)
        {
            bttn_View.Text = "View";
            this.Text = "Girvi Report";
            lbl_Date.Text = "Date";
            lbl_EndingDate.Text = "End Date";
            lbl_startDate.Text = "Start Date";
            bttn_Close.Text = "Close";
            bttn_Print.Text = "Print";

            dgv_girvidetails.Columns["SrNo"].HeaderText = "SrNo";
            dgv_girvidetails.Columns["khno"].HeaderText = "Khatawani No";
            dgv_girvidetails.Columns["GahanNo"].HeaderText = "Gahani No";
            dgv_girvidetails.Columns["datenaave"].HeaderText = "Date";
            dgv_girvidetails.Columns["muddalnaave"].HeaderText = "Amount";
            dgv_girvidetails.Columns["Name"].HeaderText = "Name";
            dgv_girvidetails.Columns["Address"].HeaderText = "Address";
            dgv_girvidetails.Columns["MetalDiscription"].HeaderText = "Metal Discription";
            dgv_girvidetails.Columns["Qty"].HeaderText = "Quentity";
            dgv_girvidetails.Columns["Wt"].HeaderText = "Weight";
            dgv_girvidetails.Columns["NetWt"].HeaderText = "Net Weight";
            dgv_girvidetails.Columns["ReleaseDate"].HeaderText = "Release Date";
            dgv_girvidetails.Columns["RecieptNo"].HeaderText = "Reciept No ";
        }

        private void Frm_GirviReport_Load(object sender, EventArgs e)
        {

        }

        private void Frm_GirviReport_KeyDown(object sender, KeyEventArgs e)
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

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            DataTable data = val.DataGridView2DataTable(dgv_girvidetails, "table");
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveGirviReportData);
            _obj(data, false);
            _objfrm_ReportViewer.ShowDialog();
        }

      
    }
}

