using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;
using BAL.Girvi;
using BAL.Reports.Girvi;
using System.Drawing.Text;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_CashBook : Form
    {
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsRokad _objRokad = new clsRokad();
        clsCommon _objCommon = new clsCommon();
        string OpeningData;
        string PreviousBalance;
        string AmountAdded;
        double totalGirviAmount = 0, totalReleaseAmount = 0, totalinterestamt = 0;

        public delegate void SendData(DataTable dtData, string startdate, string enddate,bool other);

        public frm_CashBook()
        {
            InitializeComponent();
        }

        private void frm_CashBook_KeyDown(object sender, KeyEventArgs e)
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

        private void frm_CashBook_Load(object sender, EventArgs e)
        {
            setDateAsFinancialYear();
            SetFont();
            dgv_GirviAdded.Rows.Clear();
            dgv_GirviRelease.Rows.Clear();
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

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            this.Text = " कैश बुक";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_GirviAdded.Text = "नावे";
            lbl_GirviRelease.Text = "जमा";
            lbl_StartDate.Text = "सुरवात तारीख";
            bttn_View.Text = "बघा";
            bttn_Close.Text = "बंद";
            bttn_Print.Text = "प्रिंट";
            lbl_GirviAdded.Text = "गिरवी ठेवा";
            lbl_GirviRelease.Text = "गिरवी सोडवा";
            

            dgv_GirviAdded.Columns["Date"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["Name"].HeaderText = "नाव";
            dgv_GirviAdded.Columns["GirviNo"].HeaderText = "गाहनी नं.";
            dgv_GirviAdded.Columns["KhatawaniPan"].HeaderText = "खा.पा.";
            dgv_GirviAdded.Columns["Amount"].HeaderText = "रक्कम";

            dgv_GirviRelease.Columns["Date1"].HeaderText = "तारीख";
            dgv_GirviRelease.Columns["Name1"].HeaderText = "नाव";
            dgv_GirviRelease.Columns["GirviNo1"].HeaderText = "गाहनी नं.";
            dgv_GirviRelease.Columns["KhatawaniPan1"].HeaderText = "खा.पा.";
            dgv_GirviRelease.Columns["Interest"].HeaderText = "व्याज";
            dgv_GirviRelease.Columns["Amount1"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["PreviousBalanceRelease"].HeaderText = "मागील बाकी";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
            
            
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = " कैश बुक";
            grp_Dates.Text = "दिनांक";
            int sizetext = 12;
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            bttn_View.Text = "बघा";
            lbl_GirviAdded.Text = "नावे";
            lbl_GirviRelease.Text = "जमा";
            lbl_StartDate.Text = "सुरवात तारीख";
            bttn_Close.Text = "बंद";
            bttn_Print.Text = "प्रिंट";
            lbl_GirviAdded.Text = "गिरवी ठेवा";
            lbl_GirviRelease.Text = "गिरवी सोडवा";
            

            dgv_GirviAdded.Columns["Date"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["Name"].HeaderText = "नाम";
            dgv_GirviAdded.Columns["GirviNo"].HeaderText = "गिरवी नं.";
            dgv_GirviAdded.Columns["KhatawaniPan"].HeaderText = "खा.पा.";
            dgv_GirviAdded.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["Date1"].HeaderText = "तारीख";
            dgv_GirviRelease.Columns["Name1"].HeaderText = "नाम";
            dgv_GirviRelease.Columns["GirviNo1"].HeaderText = "गिरवी नं.";
            dgv_GirviRelease.Columns["KhatawaniPan1"].HeaderText = "खा.पा.";
            dgv_GirviRelease.Columns["Interest"].HeaderText = "ब्याज";
            dgv_GirviRelease.Columns["Amount1"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["PreviousBalanceRelease"].HeaderText = "पिछला बाकी";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void bttn_View_Click(object sender, EventArgs e)
        {
            dgv_GirviAdded.Rows.Clear();
            dgv_GirviRelease.Rows.Clear();

            string nameCredit = null;
            string nameDebit = null;
            PreviousBalance = _objGirviCommon.getOpeningBalance();
            OpeningData = PreviousBalance;
            string totaljama = null;
            string totalnave = null;
            string totalekunjama = null;

            string closing = null;
            try
            {
                int j = 0;
                for (int v = 0; v <= (Convert.ToDateTime(dtp_EndDate.Text) - Convert.ToDateTime(dtp_StartDate.Text)).TotalDays; v++)
                {
                    int index = 0, index2 = 0;
                    double sumCredit = 0;
                    double sumDebit = 0;
                    totalGirviAmount = 0;
                    totalinterestamt = 0;
                    totalReleaseAmount = 0;


                    DataTable dtamountfromunsecuredloan =_objGirviCommon.getAmountFromunSecuredLoan(dtp_StartDate.Text, j);


                    AmountAdded = "0";

                    if (dtamountfromunsecuredloan.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtamountfromunsecuredloan.Rows.Count; i++)
                        {
                            sumCredit = sumCredit + Convert.ToDouble(dtamountfromunsecuredloan.Rows[i]["credit"].ToString());


                        }

                        nameCredit = dtamountfromunsecuredloan.Rows[0]["name"].ToString();
                    }
                    if (dtamountfromunsecuredloan.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtamountfromunsecuredloan.Rows.Count; i++)
                        {
                            sumDebit = sumDebit + Convert.ToDouble(dtamountfromunsecuredloan.Rows[i]["debit"].ToString());


                        }

                        nameDebit = dtamountfromunsecuredloan.Rows[0]["name"].ToString();
                    }




                    DataTable dt = _objRokad.getAllGirvi((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"));
                    if (dt.Rows.Count > 0)
                    {
                        int i;
                        for (i = 0; i < dt.Rows.Count; i++)
                        {
                            int girvi_no = Convert.ToInt32(dt.Rows[i][1]);
                            string str = _objRokad.getgirviitem(girvi_no.ToString());
                            DataTable name = _objRokad.getnamefromID(dt.Rows[i][0].ToString());
                            if (i == 0)
                            {
                                dgv_GirviAdded.Rows.Add((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"), name.Rows[0][0].ToString() + "\nव्याज", dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][2].ToString());
                            }
                            else
                            {
                                dgv_GirviAdded.Rows.Add("", name.Rows[0][0].ToString() + "\nव्याज", dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][2].ToString());

                            }

                            totalGirviAmount = totalGirviAmount + Convert.ToDouble(dt.Rows[i][2].ToString());
                        }

                        index = i;

                    }
                    else
                    {

                    }
                    totalnave = Convert.ToString(totalGirviAmount + sumCredit);

                    DataTable dt1 = _objRokad.getAllGirviRelease((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"));
                    if (dt1.Rows.Count > 0)
                    {
                        int i;
                        for (i = 0; i < dt1.Rows.Count; i++)
                        {
                            int girvi_no = Convert.ToInt32(dt1.Rows[i][1]);
                            string str = _objRokad.getgirviitem(girvi_no.ToString());
                            DataTable name = _objRokad.getnamefromID(dt1.Rows[i][0].ToString());
                            if (i == 0)
                            {
                                dgv_GirviRelease.Rows.Add((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"), name.Rows[0][0].ToString() + "\nव्याज", dt1.Rows[i][1].ToString(), dt1.Rows[i][0].ToString(), dt1.Rows[i][2].ToString(), dt1.Rows[i][3].ToString(), OpeningData);
                            }
                            else
                            {
                                dgv_GirviRelease.Rows.Add("", name.Rows[0][0].ToString() + "\nव्याज", dt1.Rows[i][1].ToString(), dt1.Rows[i][0].ToString(), dt1.Rows[i][2].ToString(), dt1.Rows[i][3].ToString(), "");


                            }
                            if (dt1.Rows[i][3].ToString() != null)
                            {
                                totalReleaseAmount = totalReleaseAmount + Convert.ToDouble(dt1.Rows[i][2].ToString());
                            }
                            if (dt1.Rows[i][3].ToString() != null)
                            {
                                totalinterestamt = totalinterestamt + Convert.ToDouble(dt1.Rows[i][3].ToString());
                            }

                        }

                        index2 = i;




                    }
                    int finalindex = 0;



                    totaljama = (Convert.ToDouble(totalReleaseAmount.ToString()) + Convert.ToDouble(totalinterestamt.ToString())).ToString();
                    //
                    totalekunjama = (Convert.ToDouble(OpeningData) + Convert.ToDouble(totaljama) + Convert.ToDouble(sumDebit)).ToString();

                    closing = (Convert.ToDouble(OpeningData) - Convert.ToDouble(totalnave) + Convert.ToDouble(totaljama) + Convert.ToDouble(sumDebit)).ToString();

                    if (sumCredit != 0)
                    {

                        if (dt1.Rows.Count == 0)
                        {
                            dgv_GirviAdded.Rows.Add((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"), nameCredit, "", "", sumCredit, OpeningData);
                            dgv_GirviRelease.Rows.Add();

                        }
                        else
                        {
                            dgv_GirviAdded.Rows.Add("", nameCredit, "", "", sumCredit, "");
                            dgv_GirviRelease.Rows.Add();
                        }



                    }

                    if (totalnave != "0" || closing != "0")
                    {
                        if (dt.Rows.Count == 0)
                        {
                            dgv_GirviAdded.Rows.Add((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"), "", "", "एकूण नावे\nएकूण जमा\nएकूण रक्कम", totalnave + "\n" + totalekunjama + "\n" + closing);

                        }
                        else
                        {
                            dgv_GirviAdded.Rows.Add("", "", "", "एकूण नावे\nएकूण जमा\nएकूण रक्कम", totalnave + "\n" + totalekunjama + "\n" + closing);
                        }


                    }
                    else
                    {
                        dgv_GirviAdded.Rows.Add();
                    }




                    if (sumDebit != 0)
                    {

                        if (dt1.Rows.Count == 0)
                        {
                            dgv_GirviRelease.Rows.Add((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"), nameDebit, "", "", nameDebit, OpeningData);
                            dgv_GirviAdded.Rows.Add();

                        }
                        else
                        {
                            dgv_GirviRelease.Rows.Add("", nameDebit, "", "", sumDebit, "");
                            dgv_GirviAdded.Rows.Add();
                        }
                    }

                    if (totalekunjama != "0")
                    {
                        if (dt1.Rows.Count == 0)
                        {
                            dgv_GirviRelease.Rows.Add((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"), "", "", "एकूण जमा", totalekunjama, "", OpeningData);
                            //dataGridView1.Rows.Add();
                        }
                        else
                        {
                            dgv_GirviRelease.Rows.Add("", "", "", "एकूण जमा", totalekunjama);
                            //dataGridView1.Rows.Add();
                        }
                    }

                    else
                    {
                        dgv_GirviRelease.Rows.Add();
                        dgv_GirviAdded.Rows.Add();
                    }
                    if (index > index2)
                    {
                        int i;
                        int diff = index - index2;
                        for (i = 0; i < diff; i++)
                        {
                            dgv_GirviRelease.Rows.Add();
                        }
                        finalindex = i;
                    }
                    else if (index2 > index)
                    {
                        int i;
                        int diff = index2 - index;
                        for (i = 0; i < diff; i++)
                        {
                            dgv_GirviAdded.Rows.Add();
                        }
                        finalindex = i;

                    }
                    for (int i = 0; i < 2; i++)
                    {
                        dgv_GirviAdded.Rows.Add();

                        dgv_GirviRelease.Rows.Add();
                    }
                    OpeningData = closing;
                    j++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            this.Text = " कैश बुक";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_GirviAdded.Text = "नावे";
            lbl_GirviRelease.Text = "जमा";
            lbl_StartDate.Text = "सुरवात तारीख";
            bttn_View.Text = "बघा";
            bttn_Close.Text = "बंद";
            bttn_Print.Text = "प्रिंट";
            lbl_GirviAdded.Text = "गिरवी ठेवा";
            lbl_GirviRelease.Text = "गिरवी सोडवा";
            


            dgv_GirviAdded.Columns["Date"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["Name"].HeaderText = "नाव";
            dgv_GirviAdded.Columns["GirviNo"].HeaderText = "गाहनी नं.";
            dgv_GirviAdded.Columns["KhatawaniPan"].HeaderText = "खा.पा.";
            dgv_GirviAdded.Columns["Amount"].HeaderText = "रक्कम";

            dgv_GirviRelease.Columns["Date1"].HeaderText = "तारीख";
            dgv_GirviRelease.Columns["Name1"].HeaderText = "नाव";
            dgv_GirviRelease.Columns["GirviNo1"].HeaderText = "गाहनी नं.";
            dgv_GirviRelease.Columns["KhatawaniPan1"].HeaderText = "खा.पा.";
            dgv_GirviRelease.Columns["Interest"].HeaderText = "व्याज";
            dgv_GirviRelease.Columns["Amount1"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["PreviousBalanceRelease"].HeaderText = "मागील बाकी";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void dtp_EndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_StartDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_EndDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            DataTable dtGirviDetails = _objCommon.DataGridView2DataTable(dgv_GirviAdded, "dtCustomerBill");
            DataTable dtPaydetails = _objCommon.DataGridView2DataTable(dgv_GirviRelease, "table");
            DataTable dtMerge = _objCommon.mergeTwoDataGrid(dtGirviDetails, dtPaydetails);

            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveCashbookRecord);
            if (rbt_OtherTrue.Checked == true)
            {
                _obj(dtMerge, dtp_StartDate.Text, dtp_EndDate.Text, true);
            }
            else
            {
                _obj(dtMerge, dtp_StartDate.Text, dtp_EndDate.Text, false);

            }
            _objfrm_ReportViewer.Show();
        }

    }
}
