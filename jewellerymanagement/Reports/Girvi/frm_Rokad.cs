using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Reports.Girvi;
using BAL.Common;
using BAL;
using System.Drawing.Text;
using JewelleryManagement.CrystalReport;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_Rokad : Form
    {
        double totalGirviAmount = 0, totalReleaseAmount = 0, totalinterestamt = 0;
        clsRokad _objRokad = new clsRokad();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        Validation _objVal = new Validation();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();

        //public delegate void SendData(DataTable dtData);

        clsCommon _objCommon = new clsCommon();
        PrinterSetting oPrintersetting = new PrinterSetting();
        public delegate void SendData(DataTable dtData, string printername,bool other,string pageno,string opening,string CurrentOpening);

        public frm_Rokad()
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

        private void frm_Rokad_Load(object sender, EventArgs e)
        {
            setDateAsFinancialYear();
            SetFont();
            dgv_GirviRelease.Rows.Clear();
            dgv_GirviAdded.Rows.Clear();
        }


        private void setDateAsFinancialYear()
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            dtp_StartDate.Text = dtFiancialYear.Rows[0]["startyear"].ToString();
            dtp_EndDate.Text = dtFiancialYear.Rows[0]["endyear"].ToString();
        }
        public void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
            //dtp_StartDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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

            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            bttn_View.Text = "रोकड बघा";
            bttn_Print.Text = "प्रिंट काढा";
            lbl_GirviAdded.Text = "नावे";
            lbl_GirviRelease.Text = "जमा";
            bttn_Close.Text = "बंद";

            dgv_GirviAdded.Columns["Date"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["GirviNo1"].HeaderText = "गाहनी क्र.";
            dgv_GirviAdded.Columns["KhatawaniPan1"].HeaderText = "ख.पा.";
            dgv_GirviAdded.Columns["Discription1"].HeaderText = "वर्णन";
            dgv_GirviAdded.Columns["Amount1"].HeaderText = "रक्कम";

            dgv_GirviRelease.Columns["Name"].HeaderText = "नाव";
            dgv_GirviRelease.Columns["GirviNo"].HeaderText = "गाहनी क्र.";
            dgv_GirviRelease.Columns["Discription"].HeaderText = "वर्णन";
            dgv_GirviRelease.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["Interest"].HeaderText = "व्याज";
            dgv_GirviRelease.Columns["KhatawaniPan"].HeaderText = "खा.पा.";
            dgv_GirviRelease.Columns["GirviNoRelease"].HeaderText = "गाहनी क्र.";

        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {

            lbl_StartDate.Text = "शुरवात तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            bttn_View.Text = "रोकड देखो";
            bttn_Print.Text = "प्रिंट निकालो";
            lbl_GirviAdded.Text = "नावे";
            lbl_GirviRelease.Text = "जमा";
            bttn_Close.Text = "बंद";

            dgv_GirviAdded.Columns["Date"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["GirviNo1"].HeaderText = "गिरवी क्र.";
            dgv_GirviAdded.Columns["KhatawaniPan1"].HeaderText = "ख.पा.";
            dgv_GirviAdded.Columns["Discription1"].HeaderText = "विवरण";
            dgv_GirviAdded.Columns["Amount1"].HeaderText = "रक्कम";

            dgv_GirviRelease.Columns["Name"].HeaderText = "नाव";
            dgv_GirviRelease.Columns["GirviNo"].HeaderText = "गिरवी क्र.";
            dgv_GirviRelease.Columns["Discription"].HeaderText = "विवरण";
            dgv_GirviRelease.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["Interest"].HeaderText = "ब्याज";
            dgv_GirviRelease.Columns["KhatawaniPan"].HeaderText = "खा.पा.";
            dgv_GirviRelease.Columns["GirviNoRelease"].HeaderText = "गिरवी क्र.";
        }

        private void rbt_English_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttn_Print_Click(object sender, EventArgs e)
        { //DataTable dtGirviDetails = _objCommon.DataGridView2DataTable(dgv_GirviAdded, "dtCustomerBill");
            //DataTable dtPaydetails = _objCommon.DataGridView2DataTable(dgv_GirviRelease, "table");
            //DataTable dtMerge = _objCommon.mergeTwoDataGrid(dtGirviDetails, dtPaydetails);


            //CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            //SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveRokadSingleRecord);
            //_obj(dtMerge);
            //_objfrm_ReportViewer.Show();

            string pageno = "";
            DataSet ds = new DataSet();
            try
            {
                if (oPrintersetting.ShowDialog() == DialogResult.OK)
                {

                    int j = 0;
                    for (int v = 0; v <= (Convert.ToDateTime(dtp_EndDate.Text) - Convert.ToDateTime(dtp_StartDate.Text)).TotalDays; v++)
                    {
                        dgv_GirviAdded.Rows.Clear();
                        dgv_GirviRelease.Rows.Clear();
                        totalGirviAmount = 0;
                        totalinterestamt = 0;
                        totalReleaseAmount = 0;
                        DataTable dt = _objRokad.getAllGirvi((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"));
                        if (dt.Rows.Count > 0)
                        {
                            pageno = _objGirviCommon.getPageNumber(dt.Rows[0]["Date_of_deposit"].ToString());
                        }
                        if (dt.Rows.Count > 0)
                        {
                            int i;
                            for (i = 0; i < dt.Rows.Count; i++)
                            {
                                int girvi_no = Convert.ToInt32(dt.Rows[i][1]);
                                string str = _objRokad.getGirviItem(girvi_no.ToString());

                                DataTable name = _objRokad.getnamefromID(dt.Rows[i][0].ToString());
                                string descriptionnew = name.Rows[0][0].ToString().Trim() + "\n" + name.Rows[0][3].ToString() + "," + str + "\n व्याज दर.सा.द.शे " + Convert.ToDecimal(dt.Rows[0]["interset_rate"]) * 12 + "प्र \n " + " दि." + dt.Rows[i][3].ToString();

                                //sagar pulgao column
                                string girviitemforsagarpulgao = _objRokad.getGirviItemForSagarPulgao(girvi_no.ToString());
                                string descriptionforSagarPulgao = name.Rows[0][0].ToString().Trim() + "\n" + name.Rows[0][3].ToString() + "," + girviitemforsagarpulgao;
                                //

                                dgv_GirviAdded.Rows.Add();

                                dgv_GirviAdded.Rows[i].Cells["DateNave"].Value = dt.Rows[i]["Date_of_deposit"].ToString();
                                dgv_GirviAdded.Rows[i].Cells["GirviNoNave"].Value = dt.Rows[i]["receipt_no"].ToString();
                                dgv_GirviAdded.Rows[i].Cells["DiscriptionNave"].Value = descriptionnew;
                                dgv_GirviAdded.Rows[i].Cells["AmountNave"].Value = dt.Rows[i]["Amount"].ToString();
                                dgv_GirviAdded.Rows[i].Cells["KhatawaniPanNave"].Value = dt.Rows[i]["khatawani_No"].ToString();

                                //sagar pulgao column
                                dgv_GirviAdded.Rows[i].Cells["ShortDescNaave"].Value = descriptionforSagarPulgao;

                                //

                                //totalGirviAmount = totalGirviAmount + Convert.ToDouble(dgv_GirviAdded.Rows[i].Cells["amountNave"].Value.ToString());
                            }

                            //totalGirviAmount = _objCommon.sumGridViewColumn(dgv_GirviAdded, "AmountNave");
                            // label4.Text = totalGirviAmount.ToString();
                            //dgv_GirviAdded.Rows.Add("Total= " + totalGirviAmount.ToString(), "", "", "");
                            //dgv_GirviAdded.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            //dgv_GirviAdded.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                        }
                        else
                        {

                        }

                        DataTable dt1 = _objRokad.getAllGirviRelease((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy"));

                        if (dt1.Rows.Count > 0)
                        {
                            pageno = _objGirviCommon.getPageNumber(dt1.Rows[0]["dateOfRelease"].ToString());
                        }

                        if (dt1.Rows.Count > 0)
                        {
                            int i;
                            for (i = 0; i < dt1.Rows.Count; i++)
                            {
                                int girvi_no = Convert.ToInt32(dt1.Rows[i][1]);
                                string str = _objRokad.getgirviitem(girvi_no.ToString());
                                DataTable name = _objRokad.getnamefromID(dt1.Rows[i][0].ToString());
                                DataTable girviadddate = _objRokad.getDatefromGn(dt1.Rows[i]["Girvino"].ToString());
                                string descriptionnew = name.Rows[0]["FullName"].ToString() + ",\n" + name.Rows[0]["Address"].ToString() + "," + dt1.Rows[i][2].ToString() + " दि." + girviadddate.Rows[0][0].ToString() + " चे मुद्दल " + dt1.Rows[i][3].ToString() + " व्याज\n" + "दि" + girviadddate.Rows[0][0].ToString() + " ते " + dt1.Rows[i]["dateOfRelease"].ToString();
                                double sumtotal = Convert.ToDouble(dt1.Rows[i]["AmountDeposit"].ToString()) + Convert.ToDouble(dt1.Rows[i]["Interest_Amount"].ToString());
                                dgv_GirviRelease.Rows.Add();
                                dgv_GirviRelease.Rows[i].Cells["DateJama"].Value = dt1.Rows[i]["dateOfRelease"].ToString();
                                //dgv_GirviRelease.Rows[i].Cells["NameJama"].Value = "";
                                dgv_GirviRelease.Rows[i].Cells["GirviNoReleaseJama"].Value = girviadddate.Rows[0]["receipt_no"].ToString();//dt1.Rows[i]["pavtino"].ToString();//dt1.Rows[i]["Girvino"].ToString()
                                dgv_GirviRelease.Rows[i].Cells["DiscriptionJama"].Value = descriptionnew;
                                dgv_GirviRelease.Rows[i].Cells["TotalAmountJama"].Value = sumtotal.ToString();
                                dgv_GirviRelease.Rows[i].Cells["AmountJama"].Value = dt1.Rows[i]["AmountDeposit"].ToString();
                                dgv_GirviRelease.Rows[i].Cells["InterestJama"].Value = dt1.Rows[i]["Interest_Amount"].ToString();
                                dgv_GirviRelease.Rows[i].Cells["KhatawaniPanJama"].Value = dt1.Rows[i]["Khatawani_no"].ToString();


                                string descriptionSagarpulgao = name.Rows[0]["FullName"].ToString() + ",\n" + name.Rows[0]["Address"].ToString() + "," + dt1.Rows[i]["pavtino"].ToString();
                                dgv_GirviRelease.Rows[i].Cells["ShortDesc"].Value = descriptionSagarpulgao;
                                dgv_GirviRelease.Rows[i].Cells["GirviNoRelease"].Value = dt1.Rows[i]["pavtino"].ToString();

                                //try
                                //{
                                //    totalReleaseAmount = totalReleaseAmount + Convert.ToDouble(dgv_GirviRelease.Rows[i].Cells["AmountJama"].Value.ToString());
                                //}
                                //catch { }
                                //try
                                //{
                                //    totalinterestamt = totalinterestamt + Convert.ToDouble(dgv_GirviRelease.Rows[i].Cells["InterestJama"].Value.ToString());
                                //}
                                //catch { }      
                            }
                            //double totalAmountJama = _objCommon.sumGridViewColumn(dgv_GirviRelease, "TotalAmountJama");
                            //totalReleaseAmount = _objCommon.sumGridViewColumn(dgv_GirviRelease, "AmountJama");
                            //totalinterestamt = _objCommon.sumGridViewColumn(dgv_GirviRelease, "InterestJama");

                            //dgv_GirviRelease.Rows.Add("Total= ", totalAmountJama.ToString(), totalReleaseAmount.ToString(), totalinterestamt.ToString());
                            //dgv_GirviRelease.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            //dgv_GirviRelease.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                            // label5.Text = totalReleaseAmount.ToString();
                        }

                        totalGirviAmount.ToString();
                        totalReleaseAmount.ToString();
                        totalinterestamt.ToString();


                        //ds.Tables.Add(dtmerge);
                        j++;
                        DataTable dtGirviDetails = _objCommon.DataGridView2DataTable(dgv_GirviAdded, "dtCustomerBill");
                        DataTable dtPaydetails = _objCommon.DataGridView2DataTable(dgv_GirviRelease, "table");
                        DataTable dtMerge = _objCommon.mergeTwoDataGrid(dtGirviDetails, dtPaydetails);


                        CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                        SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveRokadMultiRecord);
                        if (rbt_OtherTrue.Checked == true)
                        {

                            _obj(dtMerge, oPrintersetting.PrinterName, true, _objGirviCommon.getPageNumber((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j - 1)).ToString("dd/MM/yyyy")), _objGirviCommon.getOpeningBalanceWithlastDate((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j - 1)).ToString("dd/MM/yyyy")), _objGirviCommon.getOpeningBalanceWithlastDate((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy")));
                        }
                        else
                        {
                            _obj(dtMerge, oPrintersetting.PrinterName, false, _objGirviCommon.getPageNumber((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j - 1)).ToString("dd/MM/yyyy")), _objGirviCommon.getOpeningBalanceWithlastDate((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j - 1)).ToString("dd/MM/yyyy")), _objGirviCommon.getOpeningBalanceWithlastDate((Convert.ToDateTime(dtp_StartDate.Text).AddDays(j)).ToString("dd/MM/yyyy")));

                        }
                        //  _objfrm_ReportViewer.Show();
                        //DataTable dtmerge=_objCommon.mergeTwoDataGrid(_objCommon.DataGridView2DataTable(dgv_GirviAdded,"table1"),_objCommon.DataGridView2DataTable(dgv_GirviRelease,"table2"));
                        //RokadoneNew(dtmerge, totalGirviAmount.ToString(), totalReleaseAmount.ToString(), totalinterestamt.ToString(), pageno);

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bttn_View_Click(object sender, EventArgs e)
        {
            string pageno = "";
            DataSet ds = new DataSet();
            try
            {
                dgv_GirviAdded.Rows.Clear();
                dgv_GirviRelease.Rows.Clear();
                totalGirviAmount = 0;
                totalinterestamt = 0;
                totalReleaseAmount = 0;
                DataTable dt = _objRokad.getAllGirvi((Convert.ToDateTime(dtp_StartDate.Text)).ToString("dd/MM/yyyy"));
                if (dt.Rows.Count > 0)
                {
                    pageno = _objGirviCommon.getPageNumber(dt.Rows[0]["Date_of_deposit"].ToString());
                }
                if (dt.Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < dt.Rows.Count; i++)
                    {
                        int girvi_no = Convert.ToInt32(dt.Rows[i][1]);
                        string str = _objRokad.getGirviItem(girvi_no.ToString());

                        DataTable name = _objRokad.getnamefromID(dt.Rows[i][0].ToString());
                        string descriptionnew = name.Rows[0][0].ToString().Trim() + "\n" + name.Rows[0][3].ToString() + "," + str + "\n व्याज दर.सा.द.शे " + Convert.ToDecimal(dt.Rows[0]["interset_rate"]) * 12 + "प्र \n " + " दि." + dt.Rows[i][3].ToString();

                        //sagar pulgao
                        string girviitemforsagarpulgao = _objRokad.getGirviItemForSagarPulgao(girvi_no.ToString());
                        string descriptionforSagarPulgao = name.Rows[0][0].ToString().Trim() + "\n" + name.Rows[0][3].ToString() + "," + girviitemforsagarpulgao;


                        dgv_GirviAdded.Rows.Add();

                        dgv_GirviAdded.Rows[i].Cells["DateNave"].Value = dt.Rows[i]["Date_of_deposit"].ToString();
                        dgv_GirviAdded.Rows[i].Cells["GirviNoNave"].Value = dt.Rows[i]["receipt_no"].ToString();
                        dgv_GirviAdded.Rows[i].Cells["DiscriptionNave"].Value = descriptionnew;
                        dgv_GirviAdded.Rows[i].Cells["AmountNave"].Value = dt.Rows[i]["Amount"].ToString();
                        dgv_GirviAdded.Rows[i].Cells["KhatawaniPanNave"].Value = dt.Rows[i]["khatawani_No"].ToString();

                        //sagar pulgao column
                        dgv_GirviAdded.Rows[i].Cells["ShortDescNaave"].Value = descriptionforSagarPulgao;

                        //totalGirviAmount = totalGirviAmount + Convert.ToDouble(dgv_GirviAdded.Rows[i].Cells["amountNave"].Value.ToString());
                    }

                    totalGirviAmount = _objCommon.sumGridViewColumn(dgv_GirviAdded, "AmountNave");
                    // label4.Text = totalGirviAmount.ToString();
                    dgv_GirviAdded.Rows.Add("Total= ", totalGirviAmount.ToString(), "", "", "");
                    dgv_GirviAdded.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgv_GirviAdded.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }
                else
                {

                }

                DataTable dt1 = _objRokad.getAllGirviRelease((Convert.ToDateTime(dtp_StartDate.Text)).ToString("dd/MM/yyyy"));

                if (dt1.Rows.Count > 0)
                {
                    pageno = _objGirviCommon.getPageNumber(dt1.Rows[0]["dateOfRelease"].ToString());
                }

                if (dt1.Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < dt1.Rows.Count; i++)
                    {
                        int girvi_no = Convert.ToInt32(dt1.Rows[i][1]);
                        string str = _objRokad.getgirviitem(girvi_no.ToString());
                        DataTable name = _objRokad.getnamefromID(dt1.Rows[i][0].ToString());
                        DataTable girviadddate = _objRokad.getDatefromGn(dt1.Rows[i]["Girvino"].ToString());
                        string descriptionnew = name.Rows[0]["FullName"].ToString() + ",\n" + name.Rows[0]["Address"].ToString() + "," + dt1.Rows[i][2].ToString() + " दि." + girviadddate.Rows[0][0].ToString() + " चे मुद्दल " + dt1.Rows[i][3].ToString() + " व्याज\n" + "दि" + girviadddate.Rows[0][0].ToString() + " ते " + dt1.Rows[i]["dateOfRelease"].ToString();
                        double sumtotal = Convert.ToDouble(dt1.Rows[i]["AmountDeposit"].ToString()) + Convert.ToDouble(dt1.Rows[i]["Interest_Amount"].ToString());
                        //dgv_GirviRelease.Rows.Add(dt1.Rows[i]["dateOfRelease"].ToString(), "", sumtotal.ToString(), dt1.Rows[i]["AmountDeposit"].ToString(), dt1.Rows[i]["Interest_Amount"].ToString(), descriptionnew, dt1.Rows[i]["Khatawani_no"].ToString(), girviadddate.Rows[0]["receipt_no"].ToString());
                        //totalReleaseAmount = totalReleaseAmount + Convert.ToDouble(dgv_GirviRelease.Rows[i].Cells["AmountJama"].Value.ToString());
                        //totalinterestamt = totalinterestamt + Convert.ToDouble(dgv_GirviRelease.Rows[i].Cells["InterestJama"].Value.ToString());

                        dgv_GirviRelease.Rows.Add();
                        dgv_GirviRelease.Rows[i].Cells["DateJama"].Value = dt1.Rows[i]["dateOfRelease"].ToString();
                        //dgv_GirviRelease.Rows[i].Cells["NameJama"].Value = "";
                        dgv_GirviRelease.Rows[i].Cells["GirviNoReleaseJama"].Value = girviadddate.Rows[0]["receipt_no"].ToString();//dt1.Rows[i]["Girvino"].ToString()
                        dgv_GirviRelease.Rows[i].Cells["DiscriptionJama"].Value = descriptionnew;
                        dgv_GirviRelease.Rows[i].Cells["TotalAmountJama"].Value = sumtotal.ToString();
                        dgv_GirviRelease.Rows[i].Cells["AmountJama"].Value = dt1.Rows[i]["AmountDeposit"].ToString();
                        dgv_GirviRelease.Rows[i].Cells["InterestJama"].Value = dt1.Rows[i]["Interest_Amount"].ToString();
                        dgv_GirviRelease.Rows[i].Cells["KhatawaniPanJama"].Value = dt1.Rows[i]["Khatawani_no"].ToString();
                        dgv_GirviRelease.Rows[i].Cells["GirviNoRelease"].Value = dt1.Rows[i]["pavtino"].ToString();

                        string descriptionSagarpulgao = name.Rows[0]["FullName"].ToString() + ",\n" + name.Rows[0]["Address"].ToString() + "," + dt1.Rows[i]["pavtino"].ToString();
                        dgv_GirviRelease.Rows[i].Cells["ShortDesc"].Value = descriptionSagarpulgao;
                       // dgv_GirviRelease.Rows[i].Cells["GirviNoRelease"].Value = descriptionSagarpulgao;
                        

                        //try
                        //{
                        //    totalReleaseAmount = totalReleaseAmount + Convert.ToDouble(dgv_GirviRelease.Rows[i].Cells["AmountJama"].Value.ToString());
                        //}
                        //catch { }
                        //try
                        //{
                        //    totalinterestamt = totalinterestamt + Convert.ToDouble(dgv_GirviRelease.Rows[i].Cells["InterestJama"].Value.ToString());
                        //}
                        //catch { }      
                    }
                    double totalAmountJama = _objCommon.sumGridViewColumn(dgv_GirviRelease, "TotalAmountJama");
                    totalReleaseAmount = _objCommon.sumGridViewColumn(dgv_GirviRelease, "AmountJama");
                    totalinterestamt = _objCommon.sumGridViewColumn(dgv_GirviRelease, "InterestJama");

                    dgv_GirviRelease.Rows.Add("Total= ", totalAmountJama.ToString(), totalReleaseAmount.ToString(), totalinterestamt.ToString());
                    dgv_GirviRelease.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgv_GirviRelease.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    // label5.Text = totalReleaseAmount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbt_Hindi_CheckedChanged_1(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            this.Text = "रोकड रक्कम";
            lbl_StartDate.Text = "शुरवात तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            bttn_Close.Text = "बंद";
            bttn_View.Text = "रोकड देखो";
            bttn_Print.Text = "प्रिंट निकालो"; lbl_GirviAdded.Text = "गिरवी ठेवा";
            lbl_GirviRelease.Text = "गिरवी सोडवा";
            //dgv_GirviRelease.Columns["NameJama"].HeaderText = "नाम";
            dgv_GirviRelease.Columns["TotalAmountJama"].HeaderText = "एकूण रक्कम";
            dgv_GirviRelease.Columns["AmountJama"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["InterestJama"].HeaderText = "ब्याज";
            dgv_GirviRelease.Columns["DiscriptionJama"].HeaderText = "विवरण";
            dgv_GirviRelease.Columns["KhatawaniPanJama"].HeaderText = "खतावनी";
            dgv_GirviRelease.Columns["GirviNoReleaseJama"].HeaderText = "गिरवी क्र.";

            dgv_GirviAdded.Columns["DateNave"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["AmountNave"].HeaderText = "रक्कम";
            dgv_GirviAdded.Columns["DiscriptionNave"].HeaderText = "विवरण";
            dgv_GirviAdded.Columns["KhatawaniPanNave"].HeaderText = "खतावनी";
            dgv_GirviAdded.Columns["GirviNoNave"].HeaderText = "गिरवी क्र";

            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void rbt_Marathi_CheckedChanged_1(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            this.Text = "रोकड रक्कम";
            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            bttn_Close.Text = "बंद";
            bttn_View.Text = "रोकड बघा";
            bttn_Print.Text = "प्रिंट काढा";
            lbl_GirviAdded.Text = "गिरवी ठेवा";
            lbl_GirviRelease.Text = "गिरवी सोडवा";

            //dgv_GirviRelease.Columns["T"].HeaderText = "नाम";
            dgv_GirviRelease.Columns["TotalAmountJama"].HeaderText = "एकूण रक्कम";
            dgv_GirviRelease.Columns["AmountJama"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["InterestJama"].HeaderText = "ब्याज";
            dgv_GirviRelease.Columns["DiscriptionJama"].HeaderText = "विवरण";
            dgv_GirviRelease.Columns["KhatawaniPanJama"].HeaderText = "खतावनी";
            dgv_GirviRelease.Columns["GirviNoReleaseJama"].HeaderText = "गिरवी क्र.";

            dgv_GirviAdded.Columns["DateNave"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["AmountNave"].HeaderText = "रक्कम";
            dgv_GirviAdded.Columns["DiscriptionNave"].HeaderText = "विवरण";
            dgv_GirviAdded.Columns["KhatawaniPanNave"].HeaderText = "खतावनी";
            dgv_GirviAdded.Columns["GirviNoNave"].HeaderText = "गिरवी क्र";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);

        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "दिनांक";

            lbl_Date.Text = "तारीख";
            this.Text = "रोकड रक्कम";
            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            bttn_Close.Text = "बंद";
            bttn_View.Text = "रोकड बघा";
            bttn_Print.Text = "प्रिंट काढा";
            lbl_GirviAdded.Text = "गिरवी ठेवा";
            lbl_GirviRelease.Text = "गिरवी सोडवा";

            //dgv_GirviRelease.Columns["NameJama"].HeaderText = "नाम";
            dgv_GirviRelease.Columns["TotalAmountJama"].HeaderText = "एकूण रक्कम";
            dgv_GirviRelease.Columns["AmountJama"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["InterestJama"].HeaderText = "ब्याज";
            dgv_GirviRelease.Columns["DiscriptionJama"].HeaderText = "विवरण";
            dgv_GirviRelease.Columns["KhatawaniPanJama"].HeaderText = "खतावनी";
            dgv_GirviRelease.Columns["GirviNoReleaseJama"].HeaderText = "गिरवी क्र.";

            dgv_GirviAdded.Columns["DateNave"].HeaderText = "तारीख";
            dgv_GirviAdded.Columns["AmountNave"].HeaderText = "रक्कम";
            dgv_GirviAdded.Columns["DiscriptionNave"].HeaderText = "विवरण";
            dgv_GirviAdded.Columns["KhatawaniPanNave"].HeaderText = "खतावनी";
            dgv_GirviAdded.Columns["GirviNoNave"].HeaderText = "गिरवी क्र";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
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
