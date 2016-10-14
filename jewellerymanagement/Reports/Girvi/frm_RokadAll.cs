using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using BAL.Reports.Girvi;
using BAL.Common;
using JewelleryManagement.CrystalReport;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_RokadAll : Form
    {
        double totalGirviAmount = 0, totalReleaseAmount = 0, totalinterestamt = 0;
        clsRokad _objRokad = new clsRokad();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsCommon _objCommon = new clsCommon();
        PrinterSetting oPrintersetting = new PrinterSetting();
        public delegate void SendData(DataTable dtData,bool other,string opening);

        public frm_RokadAll()
        {
            InitializeComponent();
        }

        private void frm_RokadAll_KeyDown(object sender, KeyEventArgs e)
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

        private void frm_RokadAll_Load(object sender, EventArgs e)
        {
            setDateAsFinancialYear();
            SetFont();
            dgv_GirviAdded.Rows.Clear();
            dgv_GirviRelease.Rows.Clear();

        }

        private void setDateAsFinancialYear()
        {
            ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            dtp_StartDate.Text = dtFiancialYear.Rows[0]["startyear"].ToString();
            dtp_EndDate.Text = dtFiancialYear.Rows[0]["endyear"].ToString();
        }
        public void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
            //dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_StartDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_DateOfRelease.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            this.Text = "रोकड रक्कम तारखनुसार";
            lbl_StartDate.Text = "शुरवात तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            bttn_View.Text = "रोकड देखो";
            bttn_Print.Text = "प्रिंट निकालो";
            lbl_GirviAdded.Text = "गिरवी ठेवा";
            lbl_GirviRelease.Text = "गिरवी सोडवा";
            bttn_Close.Text = "बंद";

            dgv_GirviAdded.Columns["DateNave"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["GirviNoNave"].HeaderText = "गिरवी क्र.";
            dgv_GirviAdded.Columns["KhatawaniPanNave"].HeaderText = "ख.पा.";
            dgv_GirviAdded.Columns["DiscriptionNave"].HeaderText = "विवरण";
            dgv_GirviAdded.Columns["AmountNave"].HeaderText = "रक्कम";

            dgv_GirviRelease.Columns["NameJama"].HeaderText = "नाव";
            //dgv_GirviRelease.Columns["GirviNoJama"].HeaderText = "गिरवी क्र.";
            dgv_GirviRelease.Columns["DiscriptionJama"].HeaderText = "विवरण";
            dgv_GirviRelease.Columns["AmountJama"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["InterestJama"].HeaderText = "ब्याज";
            dgv_GirviRelease.Columns["KhatawaniPanJama"].HeaderText = "खा.पा.";
            dgv_GirviRelease.Columns["GirviNoRelease"].HeaderText = "गिरवी क्र.";
            dgv_GirviRelease.Columns["ReceiptNo"].HeaderText = "पावती क्र.";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
            
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            this.Text = "रोकड रक्कम तारखेनुसार";
            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            bttn_View.Text = "रोकड बघा";
            bttn_Print.Text = "प्रिंट काढा";
            lbl_GirviAdded.Text = "गिरवी ठेवा";
            lbl_GirviRelease.Text = "गिरवी सोडवा";
            bttn_Close.Text = "बंद";

            dgv_GirviAdded.Columns["DateNave"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["GirviNoNave"].HeaderText = "गाहनी क्र.";
            dgv_GirviAdded.Columns["KhatawaniPanNave"].HeaderText = "ख.पा.";
            dgv_GirviAdded.Columns["DiscriptionNave"].HeaderText = "वर्णन";
            dgv_GirviAdded.Columns["AmountNave"].HeaderText = "रक्कम";
            dgv_GirviAdded.Columns["ReceiptNoNave"].HeaderText = "पावती क्र.";



            dgv_GirviRelease.Columns["NameJama"].HeaderText = "नाव";
            //dgv_GirviRelease.Columns["GirviNoJama"].HeaderText = "गाहनी क्र.";
            dgv_GirviRelease.Columns["DiscriptionJama"].HeaderText = "वर्णन";
            dgv_GirviRelease.Columns["AmountJama"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["InterestJama"].HeaderText = "व्याज";
            dgv_GirviRelease.Columns["KhatawaniPanJama"].HeaderText = "खा.पा.";
            dgv_GirviRelease.Columns["GirviNoRelease"].HeaderText = "गाहनी क्र.";
            dgv_GirviRelease.Columns["ReceiptNo"].HeaderText = "पावती क्र.";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            this.Text = "रोकड रक्कम तारखेनुसार";
            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            bttn_View.Text = "रोकड बघा";
            bttn_Print.Text = "प्रिंट काढा";
            lbl_GirviAdded.Text = "गिरवी ठेवा";
            lbl_GirviRelease.Text = "गिरवी सोडवा";
            bttn_Close.Text = "बंद";

            dgv_GirviAdded.Columns["DateNave"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["GirviNoNave"].HeaderText = "गाहनी क्र.";
            dgv_GirviAdded.Columns["KhatawaniPanNave"].HeaderText = "ख.पा.";
            dgv_GirviAdded.Columns["DiscriptionNave"].HeaderText = "वर्णन";
            dgv_GirviAdded.Columns["AmountNave"].HeaderText = "रक्कम";

            dgv_GirviRelease.Columns["NameJama"].HeaderText = "नाव";
            dgv_GirviRelease.Columns["GirviNoRelease"].HeaderText = "गाहनी क्र.";
            dgv_GirviRelease.Columns["DiscriptionJama"].HeaderText = "वर्णन";
            dgv_GirviRelease.Columns["AmountJama"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["InterestJama"].HeaderText = "व्याज";
            dgv_GirviRelease.Columns["KhatawaniPanJama"].HeaderText = "खा.पा.";
            dgv_GirviRelease.Columns["ReceiptNo"].HeaderText = "पावती क्र.";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            DataTable dtGirviDetails = _objCommon.DataGridView2DataTable(dgv_GirviAdded, "dtCustomerBill");
            DataTable dtPaydetails = _objCommon.DataGridView2DataTable(dgv_GirviRelease, "table");
            DataTable dtMerge = _objCommon.mergeTwoDataGrid(dtGirviDetails, dtPaydetails);


            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveRokadAllRecord);
            if (rbt_OtherTrue.Checked == true)
            {

                _obj(dtMerge, true, _objGirviCommon.getOpeningBalanceWithlastDate(dtp_StartDate.Text));
            }
            else
            {
                _obj(dtMerge, false, _objGirviCommon.getOpeningBalanceWithlastDate(dtp_StartDate.Text));

            }
            _objfrm_ReportViewer.Show();
        }

        private void bttn_View_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_GirviAdded.Rows.Clear();
                dgv_GirviRelease.Rows.Clear();
                totalGirviAmount = 0;
                totalinterestamt = 0;
                totalReleaseAmount = 0;
                DataTable dt = _objRokad.getAllGirviDatewise(dtp_StartDate.Text, dtp_EndDate.Text);
                if (dt.Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < dt.Rows.Count; i++)
                    {
                        int girvi_no = Convert.ToInt32(dt.Rows[i][1]);
                        string str = _objRokad.getGirviItem(girvi_no.ToString());

                        DataTable name = _objRokad.getnamefromID(dt.Rows[i][0].ToString());
                        string descriptionnew = name.Rows[0][0].ToString() + "," + name.Rows[0][3].ToString() + "\n" + str + "\n व्याज दर.सा.द.शे " + Convert.ToDecimal(dt.Rows[0]["interset_rate"]) * 12 + " प्र.  \n " + " दि." + dt.Rows[i][3].ToString();
                        string pageno = name.Rows[0]["khatawani_No"].ToString();

                        dgv_GirviAdded.Rows.Add();

                        dgv_GirviAdded.Rows[i].Cells["DateNave"].Value = dt.Rows[i]["Date_of_deposit"].ToString();
                        dgv_GirviAdded.Rows[i].Cells["GirviNoNave"].Value = dt.Rows[i]["GirviRecordNo"].ToString();
                        dgv_GirviAdded.Rows[i].Cells["DiscriptionNave"].Value = descriptionnew;
                        dgv_GirviAdded.Rows[i].Cells["AmountNave"].Value = dt.Rows[i]["Amount"].ToString();
                        dgv_GirviAdded.Rows[i].Cells["KhatawaniPanNave"].Value = dt.Rows[i]["khatawani_No"].ToString();
                        dgv_GirviAdded.Rows[i].Cells["ReceiptNoNave"].Value = dt.Rows[i]["receipt_no"].ToString();

                    
                    }
                    DataTable dtAmountfromCashInHandCredit = _objGirviCommon.getAmountfromCashInHandDebit(dtp_StartDate.Text, dtp_EndDate.Text);
                    if (dtAmountfromCashInHandCredit.Rows.Count > 0)
                    {
                        for (int k = 0; k < dtAmountfromCashInHandCredit.Rows.Count; k++)
                        {
                            dgv_GirviAdded.Rows.Add(dtAmountfromCashInHandCredit.Rows[k]["date"].ToString(), dtAmountfromCashInHandCredit.Rows[k]["debit"].ToString(), dtAmountfromCashInHandCredit.Rows[k]["FromAccount"].ToString() + " " + dtAmountfromCashInHandCredit.Rows[k]["chequeno"].ToString(), "", "");
                        }
                    }
                    totalGirviAmount = _objCommon.sumGridViewColumn(dgv_GirviAdded, "AmountNave");

                    dgv_GirviAdded.Rows.Add("Total", totalGirviAmount.ToString());
                    dgv_GirviAdded.Rows[dgv_GirviAdded.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    dgv_GirviAdded.Rows[dgv_GirviAdded.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                    dgv_GirviAdded.Sort(dgv_GirviAdded.Columns["DateNave"], ListSortDirection.Ascending);
                }
                else
                {

                }

                DataTable dt1 = _objRokad.getAllGirviReleaseDatewise(dtp_StartDate.Text,dtp_EndDate.Text);
                //
                if (dt1.Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < dt1.Rows.Count; i++)
                    {
                        int girvi_no = Convert.ToInt32(dt1.Rows[i][1]);
                        string str = _objRokad.getgirviitem(girvi_no.ToString());
                        DataTable name = _objRokad.getnamefromID(dt1.Rows[i][0].ToString());
                        DataTable girviadddate = _objRokad.getDatefromGn(dt1.Rows[i][1].ToString());

                        string descriptionnew = name.Rows[0][0].ToString() + "," + name.Rows[0][3].ToString() + "\n" + dt1.Rows[i][2].ToString() + " दि." + girviadddate.Rows[0][0].ToString() + " चे मुद्दल " + dt1.Rows[i][3].ToString() + " व्याज\n" + "दि" + girviadddate.Rows[0][0].ToString() + " ते " + dt1.Rows[i][4].ToString();
                        string pageno = name.Rows[0]["khatawani_No"].ToString();
                        double sumtotal = Convert.ToDouble(dt1.Rows[i][2].ToString()) + Convert.ToDouble(dt1.Rows[i][3].ToString());
                        dgv_GirviRelease.Rows.Add();
                       
                            dgv_GirviRelease.Rows[i].Cells["DateJama"].Value = dt1.Rows[i]["dateOfRelease"].ToString();
                            dgv_GirviRelease.Rows[i].Cells["GirviNoRelease"].Value = dt1.Rows[i]["GirviNo"].ToString();
                            dgv_GirviRelease.Rows[i].Cells["ReceiptNo"].Value = dt1.Rows[i]["pavtino"].ToString();
                            dgv_GirviRelease.Rows[i].Cells["DiscriptionJama"].Value = descriptionnew;
                            dgv_GirviRelease.Rows[i].Cells["TotalAmountJama"].Value = sumtotal.ToString();
                            dgv_GirviRelease.Rows[i].Cells["AmountJama"].Value = dt1.Rows[i]["AmountDeposit"].ToString();
                            dgv_GirviRelease.Rows[i].Cells["InterestJama"].Value = dt1.Rows[i]["Interest_Amount"].ToString();
                            dgv_GirviRelease.Rows[i].Cells["KhatawaniPanJama"].Value = dt1.Rows[i]["Khatawani_no"].ToString();
                            dgv_GirviRelease.Rows[i].Cells["ReceiptNo"].Value = dt1.Rows[i]["pavtino"].ToString();
                       
                    }
                    DataTable dtAmountfromCashInHandDebit = _objGirviCommon.getAmountfromCashInHandCredit(dtp_StartDate.Text, dtp_EndDate.Text);
                    if (dtAmountfromCashInHandDebit.Rows.Count > 0)
                    {
                        for (int k = 0; k < dtAmountfromCashInHandDebit.Rows.Count; k++)
                        {
                            dgv_GirviRelease.Rows.Add(dtAmountfromCashInHandDebit.Rows[k]["date"].ToString(), "", dtAmountfromCashInHandDebit.Rows[k]["credit"].ToString(), "", "", dtAmountfromCashInHandDebit.Rows[k]["FromAccount"].ToString()+"  "+dtAmountfromCashInHandDebit.Rows[k]["chequeno"].ToString());
                        }
                    }

                    double totalAmountJama = _objCommon.sumGridViewColumn(dgv_GirviRelease, "TotalAmountJama");
                    totalReleaseAmount = _objCommon.sumGridViewColumn(dgv_GirviRelease, "AmountJama");
                    totalinterestamt = _objCommon.sumGridViewColumn(dgv_GirviRelease, "InterestJama");
                 
                    dgv_GirviRelease.Rows.Add("Cash Total= ", "", totalAmountJama.ToString(), totalReleaseAmount.ToString(), totalinterestamt.ToString());
                    dgv_GirviRelease.Rows.Add("Closing= ", "",_objGirviCommon.getOpeningBalanceWithEndDate(dtp_EndDate.Text));

                    dgv_GirviRelease.Rows[dgv_GirviRelease.RowCount-2].DefaultCellStyle.BackColor = Color.Red;
                    dgv_GirviRelease.Rows[dgv_GirviRelease.RowCount - 2].DefaultCellStyle.ForeColor = Color.White;
                    dgv_GirviRelease.Columns["DateJama"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgv_GirviRelease.Sort(dgv_GirviRelease.Columns["DateJama"], ListSortDirection.Ascending);
                    //label5.Text = totalReleaseAmount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtp_StartDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_EndDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void rbt_PrintTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
