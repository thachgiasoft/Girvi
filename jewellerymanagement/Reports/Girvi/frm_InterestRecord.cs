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
using BAL.Girvi;
using BAL.Common;
using System.Drawing.Text;
using JewelleryManagement.CrystalReport;
namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_InterestRecord : Form
    {
        public frm_InterestRecord()
        {
            InitializeComponent();
        }
        PrinterSetting oPrintersetting = new PrinterSetting();
        Simplevalidations _objSimplevalidation = new Simplevalidations();
        clsKhatawaniGirviRecord _objKhatawaniGiviRecord = new clsKhatawaniGirviRecord();
        cls_GirviRelease _objGirviRelease = new cls_GirviRelease();
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        clsCommon _objCommon = new clsCommon();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        Validation val = new Validation();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();

        public delegate void SendDataMulti(DataTable dtData, string KhNo, string TotalAmountNaaveSum, string TotalAmountJamaSum, string PrinterName, bool other);
        public delegate void SendData(DataTable dtData, string KhNo, string TotalAmountNaaveSum, string TotalAmountJamaSum,string AccountBalance ,bool other);

        double totalloanamountsum;
        double totalpaidsum;
        private void frm_InterestRecord_Load(object sender, EventArgs e)
        {
            SetFont();
            MasterClear();
        }
        public void ShivajiFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
                // dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                cmb_FullName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                txt_KhatawaniNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                txt_AccountBalance.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                txt_PaidAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                txt_LoanAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_InvoiceNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //cmb_LoanReason.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //cmb_LoanType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //Cmb_MetalType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //Cmb_ItemType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_GrossWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_ReduceWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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
                lst_FullName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            }
        }


        private void SetFont()
        {
            ShivajiFont();
        }

        private void MasterClear()
        {
            txt_AccountBalance.ResetText();
            txt_KhatawaniNo.ResetText();
          //  txt_KhatawaniNo.DataSource = _objGirviRelease.getGirviKhatawaniNo();
            txt_LoanAmount.ResetText();
            // cmb_FullName.DataSource = _objGirviAdd.getFName();
            txt_InvoiceNo.DataSource = _objGirviRelease.getGirviReceiptNo();
            txt_PaidAmount.ResetText();
            txt_InvoiceNo.SelectedIndex = -1;
            cmb_FullName.Focus();
            //cmb_FullName.SelectedIndex = -1;
            dgv_GirviDetail.Rows.Clear();
            dgv_PaymentDetail.Rows.Clear();
            txt_AccountBalance.ResetText();
            txt_KhatawaniNo.ResetText();
            txt_PaidAmount.ResetText();
            txt_LoanAmount.ResetText();
            cmb_FullName.ResetText();
            txt_MobileNo.ResetText();
            txt_address.ResetText();
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {

                }


            }
        }

        private void FillGrids()
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            dgv_GirviDetail.Rows.Clear();
            dgv_PaymentDetail.Rows.Clear();
            if (true)//pusad
            {
                if (txt_KhatawaniNo.Text == "")
                {
                    //err_khatawanino.Visible = true;
                }
                else
                {
                    totalloanamountsum = 0;
                    DataTable girvi_data = _objGirviAdd.getGirviDetailsByKhatawaniInterest(txt_KhatawaniNo.Text);
                    int j = 0;
                    for (int i = 0; i < girvi_data.Rows.Count; i++)
                    {
                        int girvi_no = Convert.ToInt32(girvi_data.Rows[i]["GirviRecordNo"]);
                        string pagenumber = _objGirviCommon.getPageNumber(girvi_data.Rows[i]["Date_of_deposit"].ToString());
                       // string mobileno = _objGirviAdd.getCustomerMaster(girvi_data.Rows[i]["Contact_No"].ToString()).Rows[0]["Contact_No"].ToString();
                        string Dateofrelease = _objKhatawaniGiviRecord.getDateofrelease(girvi_no);
                        string str = _objKhatawaniGiviRecord.getgirviitem(girvi_no.ToString()) + " व्याज: दि." + girvi_data.Rows[i]["Date_of_deposit"] + "ते दि." + Dateofrelease;
                     

                        string interest = _objKhatawaniGiviRecord.getreleaseinterest(girvi_no);
                        int resultless = 0;
                        if (Dateofrelease != "")
                        {
                            resultless = DateTime.Compare(Convert.ToDateTime(Dateofrelease), Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()));
                        }
                        if (resultless >= 0)
                        {
                            dgv_GirviDetail.Rows.Add(girvi_data.Rows[i]["receipt_no"].ToString(), girvi_data.Rows[i]["Amount"].ToString() + "\n " + interest, girvi_data.Rows[i]["Date_of_deposit"].ToString(), pagenumber, str.Trim());
                            totalloanamountsum = totalloanamountsum + (Convert.ToDouble(girvi_data.Rows[i]["Amount"].ToString()));//lalit remove interest
                            if (girvi_data.Rows[i]["Status"].ToString() == "Release")
                            {
                                dgv_GirviDetail.Rows[j].DefaultCellStyle.BackColor = Color.Red;
                                dgv_GirviDetail.Rows[j].DefaultCellStyle.ForeColor = Color.White;
                            }
                            j++;
                        }

                    }


                    txt_LoanAmount.Text = totalloanamountsum.ToString();
                    totalpaidsum = 0;

                    DataTable paid = _objKhatawaniGiviRecord.getgirvivaluesByFinancialYear(txt_KhatawaniNo.Text, dtFiancialYear.Rows[0]["startyear"].ToString(), dtFiancialYear.Rows[0]["endyear"].ToString());
                    if (paid.Rows.Count > 0)
                    {

                        for (int i = 0; i < paid.Rows.Count; i++)
                        {
                            string str;

                            if (rbt_Marathi.Checked == true)
                            {
                                str = paid.Rows[i]["AmountDeposit"].ToString() + " दि. " + paid.Rows[i]["dateOfRelease"].ToString() + " चे मुद्दल, " + paid.Rows[i]["Interest_Amount"].ToString() + " व्याज बद्दल";
                            }
                            else
                            {
                                str = paid.Rows[i]["AmountDeposit"].ToString() + " दि." + paid.Rows[i]["dateOfRelease"].ToString() + " चे मुद्दल, " + paid.Rows[i]["Interest_Amount"].ToString() + " व्याज बद्दल";
                            }
                            string pagenumber = _objGirviCommon.getPageNumber(paid.Rows[i]["dateOfRelease"].ToString());
                            dgv_PaymentDetail.Rows.Add(paid.Rows[i]["pavtino"].ToString(), paid.Rows[i]["AmountDeposit"].ToString(), paid.Rows[i]["dateOfRelease"].ToString(), pagenumber, str);
                            totalpaidsum = totalpaidsum + (Convert.ToDouble(paid.Rows[i]["AmountDeposit"].ToString()));
                        }
                    }

                    txt_PaidAmount.Text = totalpaidsum.ToString();

                    txt_AccountBalance.Text = (Convert.ToDouble(txt_LoanAmount.Text) - Convert.ToDouble(txt_PaidAmount.Text)).ToString();
                }

                if (dgv_GirviDetail.Rows.Count > 0)
                {
                    dgv_GirviDetail.Rows[0].Selected = false;
                }
                if (dgv_PaymentDetail.Rows.Count > 0)
                {
                    dgv_PaymentDetail.Rows[0].Selected = false;
                }
            }
            else
            {

            }
        }

        private void txt_KhatawaniNo_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
               
                DataTable dtKhatawani = _objGirviRelease.getKhatawaniNo(txt_KhatawaniNo.Text);
                // DataTable dtKhatawani = _objGirviAdd.getKhatawaniByName(cmb_FullName.Text);
                if (dtKhatawani.Rows.Count > 0)
                {
                    txt_KhatawaniNo.Text = dtKhatawani.Rows[0]["khatawani_No"].ToString();
                    cmb_FullName.Text = dtKhatawani.Rows[0]["FullName"].ToString();
                    txt_address.Text = dtKhatawani.Rows[0]["Address"].ToString();
                    txt_InvoiceNo.Text = dtKhatawani.Rows[0]["PageNo"].ToString();
                    txt_MobileNo.Text = dtKhatawani.Rows[0]["Contact_No"].ToString();

                    FillGrids();
                    txt_KhatawaniNo.ReadOnly = false;
                    txt_KhatawaniNo.Focus();
                    lst_FullName.Visible = false;
                }
                else
                {
                    lst_FullName.Visible = false;
                    cmb_FullName.Text = "";
                    txt_address.Text = "";
                    txt_MobileNo.Text = "";
                }

                ////  txt_InvoiceNo.Visible = false;
            }
                       // string khtavanidetailsbyKhatawaniNo = _objGirviRelease.khtavanidetailsbyKhatawaniNo(txt_KhatawaniNo.Text);
           // DataTable dtKhatawani = _objGirviRelease.khtavanidetailsbyKhatawaniNo(txt_KhatawaniNo.Text);
        }

        private void SearchKhatawaniNoData(string khatawaniNo)
        {
            DataTable dt2 = null;


            dt2 = _objGirviAdd.getGirviByKhatawaniNo(khatawaniNo);


            if (dt2.Rows.Count > 0)
            {
                DataTable dt = _objGirviAdd.getGirviDetailsByKhatawaniNo(dt2.Rows[0]["khatawani_No"].ToString());
                DataTable dtKhatawani = _objGirviRelease.getKhatawaniNo(khatawaniNo);
                // DataTable dtKhatawani = _objGirviAdd.getKhatawaniByName(cmb_FullName.Text);
                if (dtKhatawani.Rows.Count > 0)
                {
                    txt_KhatawaniNo.Text = dtKhatawani.Rows[0]["khatawani_No"].ToString();
                    cmb_FullName.Text = dtKhatawani.Rows[0]["FullName"].ToString();
                    txt_address.Text = dtKhatawani.Rows[0]["Address"].ToString();

                    FillGrids();
                    txt_KhatawaniNo.ReadOnly = false;
                    txt_KhatawaniNo.Focus();
                    lst_FullName.Visible = false;
                }
                else
                {
                    lst_FullName.Visible = false;
                    cmb_FullName.Text = "";
                    txt_address.Text = "";
                    cmb_FullName.Text = "";
                    txt_MobileNo.Text = "";
                    txt_AccountBalance.Text = "";
                }
            }
           // ClearPrivousData();
        }

        private void ClearPrivousData()
        {
            cmb_FullName.ResetText();
            txt_KhatawaniNo.ResetText();
            txt_InvoiceNo.ResetText();
            txt_AccountBalance.ResetText();
            txt_MobileNo.ResetText();
            txt_address.ResetText();
          
        }




        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidation.ValidationCharOnly(e);
        }

        private void txt_KhatawaniNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidation.ValidationDigitOnly(e);

        }

        private void frm_InterestRecord_KeyDown(object sender, KeyEventArgs e)
        
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

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_CustomerDetail.Text = "ग्राहकाची माहीती ";
            lbl_Date.Text = "तारीख";
            this.Text = "खतावणी तपशील";
            rbt_Marathi.ForeColor = Color.MediumAquamarine;
            rbt_English.ForeColor = Color.Black;
            rbt_Hindi.ForeColor = Color.Black;
            lbl_Name.Text = "नाव";
            lbl_Name.Font = new Font("Arial", sizetext);
            lbl_KhatawaniNo.Text = "खतावणी क्रं.";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_AccountBalance.Text = "अकाउंट बलंस";
            lbl_AccountBalance.Font = new Font("Arial", sizetext);
            lbl_GirviDetail.Text = "नावे";
            lbl_GirviDetail.Font = new Font("Arial", sizetext);
            lbl_PaymentDetail.Text = "जमा";
            lbl_PaymentDetail.Font = new Font("Arial", sizetext);
            lbl_TotalLoanAmount.Text = "एकुण कर्जाची रक्कम";
            lbl_TotalPaidAmount.Text = "एकुण दिलेली रक्कम";
            bttn_AllPrintKhatawani.Text = "पूर्ण खतावणी प्रिंट";
            bttn_Close.Text = "बंद";
            bttn_Reset.Text = "रिसेट";
            bttn_Print.Text = "प्रिंट";

            dgv_GirviDetail.Columns[0].HeaderText = "रिसिप्त नं";
            dgv_GirviDetail.Columns[1].HeaderText = "रक्कम";
            dgv_GirviDetail.Columns[2].HeaderText = "जमा तारीख";
            dgv_GirviDetail.Columns[3].HeaderText = "रोकड पान";
            dgv_GirviDetail.Columns[4].HeaderText = "तपशील";

            dgv_PaymentDetail.Columns[0].HeaderText = "पावती नं";
            dgv_PaymentDetail.Columns[1].HeaderText = "रक्कम";
            dgv_PaymentDetail.Columns[2].HeaderText = "तारीख";
            dgv_PaymentDetail.Columns[3].HeaderText = "रोकड पान";
            dgv_PaymentDetail.Columns[4].HeaderText = "तपशील";

            dgv_GirviDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
            dgv_PaymentDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);

        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_CustomerDetail.Text = "ग्राहकाची माहीती ";
            lbl_Date.Text = "तारीख";
            this.Text = "खतावणी यादी";
            rbt_Hindi.ForeColor = Color.MediumAquamarine;
            rbt_English.ForeColor = Color.Black;
            rbt_Marathi.ForeColor = Color.Black;

            lbl_Name.Font = new Font("Arial", sizetext);
            lbl_KhatawaniNo.Text = "खतावणी क्रं.";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_AccountBalance.Text = "अकाउंट बलंस";
            lbl_AccountBalance.Font = new Font("Arial", sizetext);

            grp_Buttons.Text =


            lbl_Name.Text = "नाम";
            lbl_KhatawaniNo.Text = "खतावणी नं.";
            lbl_AccountBalance.Text = "अकाउंट बलंस";
            lbl_GirviDetail.Text = "नावे";
            lbl_PaymentDetail.Text = "जमा";
            lbl_TotalLoanAmount.Text = "पूर्ण कर्ज की रक्कम";
            lbl_TotalPaidAmount.Text = "पूर्ण दि गई रक्कम";

            bttn_Close.Text = "बंद";
            bttn_Reset.Text = "रिसेट";
            bttn_Print.Text = "प्रिंट";
            bttn_AllPrintKhatawani.Text = "संपूर्ण खतावणी प्रिंट";

            dgv_GirviDetail.Columns[0].HeaderText = "रिसिप्त नं";
            dgv_GirviDetail.Columns[1].HeaderText = "रक्कम";
            dgv_GirviDetail.Columns[2].HeaderText = "जमा तारीख";
            dgv_GirviDetail.Columns[3].HeaderText = "रोकड पान";
            dgv_GirviDetail.Columns[4].HeaderText = "तपशील";

            dgv_PaymentDetail.Columns[0].HeaderText = "पावती नं";
            dgv_PaymentDetail.Columns[1].HeaderText = "रक्कम";
            dgv_PaymentDetail.Columns[2].HeaderText = "तारीख";
            dgv_PaymentDetail.Columns[3].HeaderText = "रोकड पान";
            dgv_PaymentDetail.Columns[4].HeaderText = "तपशील";

            dgv_GirviDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
            dgv_PaymentDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
        }

        private void txt_Name_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void txt_KhatawaniNo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_AccountBalance_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_FullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   DataTable dtKhatawani = _objGirviAdd.getKhatawaniByName(cmb_FullName.Text);
            //    if (dtKhatawani.Rows.Count > 0)
            //    {
            //        txt_KhatawaniNo.Text = dtKhatawani.Rows[0]["khatawani_No"].ToString();
            //        FillGrids();
            //        txt_KhatawaniNo.ReadOnly = true;
            //        txt_KhatawaniNo.Focus();
            //    }
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            dgv_GirviDetail.Rows.Clear();
            dgv_PaymentDetail.Rows.Clear();
            txt_AccountBalance.ResetText();
            txt_KhatawaniNo.ResetText();
            cmb_FullName.ResetText();
            txt_PaidAmount.ResetText();
            txt_LoanAmount.ResetText();
            txt_address.ResetText();
        }



        private void bttn_Print_Click(object sender, EventArgs e)
        {
            DataTable dtGirviDetails = _objCommon.DataGridView2DataTable(dgv_GirviDetail, "dtCustomerBill");
            DataTable dtPaydetails = _objCommon.DataGridView2DataTable(dgv_PaymentDetail, "table");
            DataTable dtMerge = _objCommon.mergeTwoDataGrid(dtGirviDetails, dtPaydetails);

            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataInterestRecord);
            if (rbt_OtherTrue.Checked == true)
            {

                _obj(dtMerge, txt_KhatawaniNo.Text, totalloanamountsum.ToString(), totalpaidsum.ToString(),txt_AccountBalance.Text ,true);
            }
            else
            {
                _obj(dtMerge, txt_KhatawaniNo.Text, totalloanamountsum.ToString(), totalpaidsum.ToString(), txt_AccountBalance.Text, false);

            }
            _objfrm_ReportViewer.Show();
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_CustomerDetail.Text = "ग्राहकाची माहीती ";
            lbl_Date.Text = "तारीख";
            this.Text = "खतावणी तपशील";
            rbt_Marathi.ForeColor = Color.MediumAquamarine;
            rbt_English.ForeColor = Color.Black;
            rbt_Hindi.ForeColor = Color.Black;
            lbl_Name.Text = "नाव";
            lbl_Name.Font = new Font("Arial", sizetext);
            lbl_KhatawaniNo.Text = "खतावणी क्रं.";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_AccountBalance.Text = "अकाउंट बलंस";
            lbl_AccountBalance.Font = new Font("Arial", sizetext);
            lbl_GirviDetail.Text = "नावे";
            lbl_GirviDetail.Font = new Font("Arial", sizetext);
            lbl_PaymentDetail.Text = "जमा";
            lbl_PaymentDetail.Font = new Font("Arial", sizetext);
            lbl_TotalLoanAmount.Text = "एकुण कर्जाची रक्कम";
            lbl_TotalPaidAmount.Text = "एकुण दिलेली रक्कम";
            bttn_AllPrintKhatawani.Text = "पूर्ण खतावणी प्रिंट";
            bttn_Close.Text = "बंद";
            bttn_Reset.Text = "रिसेट";
            bttn_Print.Text = "प्रिंट";

            dgv_GirviDetail.Columns[0].HeaderText = "रिसिप्त नं";
            dgv_GirviDetail.Columns[1].HeaderText = "रक्कम";
            dgv_GirviDetail.Columns[2].HeaderText = "जमा तारीख";
            dgv_GirviDetail.Columns[3].HeaderText = "रोकड पान";
            dgv_GirviDetail.Columns[4].HeaderText = "तपशील";

            dgv_PaymentDetail.Columns[0].HeaderText = "पावती नं";
            dgv_PaymentDetail.Columns[1].HeaderText = "रक्कम";
            dgv_PaymentDetail.Columns[2].HeaderText = "तारीख";
            dgv_PaymentDetail.Columns[3].HeaderText = "रोकड पान";
            dgv_PaymentDetail.Columns[4].HeaderText = "तपशील";

            dgv_GirviDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
            dgv_PaymentDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);

        }

        private void txt_AccountBalance_Enter_1(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void bttn_AllPrintKhatawani_Click(object sender, EventArgs e)
        {
            if (oPrintersetting.ShowDialog() == DialogResult.OK)
            {

                DataTable dtKhatawani = _objGirviAdd.getAllKhatawaniDetails();
                for (int i = 0; i < dtKhatawani.Rows.Count; i++)
                {
                    txt_KhatawaniNo.Text = dtKhatawani.Rows[i]["khatawani_No"].ToString();
                    FillGrids();

                    DataTable dtGirviDetails = _objCommon.DataGridView2DataTable(dgv_GirviDetail, "dtCustomerBill");
                    DataTable dtPaydetails = _objCommon.DataGridView2DataTable(dgv_PaymentDetail, "table");
                    DataTable dtMerge = _objCommon.mergeTwoDataGrid(dtGirviDetails, dtPaydetails);

                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                    SendDataMulti _obj = new SendDataMulti(_objfrm_ReportViewer.ReceiveDataInterestRecordMultiPrint);
                    if (rbt_OtherTrue.Checked == true)
                    {

                        _obj(dtMerge, txt_KhatawaniNo.Text, totalloanamountsum.ToString(), totalpaidsum.ToString(), oPrintersetting.PrinterName, true);
                    }
                    else
                    {
                        _obj(dtMerge, txt_KhatawaniNo.Text, totalloanamountsum.ToString(), totalpaidsum.ToString(), oPrintersetting.PrinterName, false);

                    }

                    MasterClear();
                }
            }
        }

        private void cmb_FullName_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
        }

        private void dgv_GirviDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_InvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string khtavanino = _objGirviRelease.getkhatawani_NobyReceiptNo(txt_InvoiceNo.Text);
            DataTable dtKhatawani = _objGirviRelease.getKhatawaniNo(khtavanino);
            // DataTable dtKhatawani = _objGirviAdd.getKhatawaniByName(cmb_FullName.Text);
            if (dtKhatawani.Rows.Count > 0)
            {
                txt_KhatawaniNo.Text = dtKhatawani.Rows[0]["khatawani_No"].ToString();
                cmb_FullName.Text = dtKhatawani.Rows[0]["FullName"].ToString();
                txt_address.Text = dtKhatawani.Rows[0]["Address"].ToString();

                FillGrids();
                txt_KhatawaniNo.ReadOnly = false;
                txt_KhatawaniNo.Focus();
                lst_FullName.Visible = false;
            }
            else
            {
                lst_FullName.Visible = false;
                cmb_FullName.Text = "";
                txt_address.Text = "";
                txt_MobileNo.Text = "";
            }
        }

        private void lst_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_FullName.Text = lst_FullName.SelectedValue.ToString();
                //cmb_FullName.Focus();

                DataTable dtKhatawani = _objGirviAdd.getKhatawaniByName(cmb_FullName.Text);
                if (dtKhatawani.Rows.Count > 0)
                {
                    cmb_FullName.Text = dtKhatawani.Rows[0]["FullName"].ToString();
                    txt_KhatawaniNo.Text = dtKhatawani.Rows[0]["khatawani_No"].ToString();
                    txt_MobileNo.Text = dtKhatawani.Rows[0]["Contact_No"].ToString();
                    txt_address.Text = dtKhatawani.Rows[0]["Address"].ToString();
                    FillGrids();
                    txt_KhatawaniNo.ReadOnly = false;
                    txt_KhatawaniNo.Focus();
                }
                txt_KhatawaniNo.Focus();
                lst_FullName.Visible = false;
            }


        }

        private void cmb_FullName_TextChanged(object sender, EventArgs e)
        {
            if (cmb_FullName.Text != "")
            {

                lst_FullName.DataSource = _objGirviAdd.getFName(cmb_FullName.Text);
                if (lst_FullName.Items.Count > 0)
                {
                    lst_FullName.Visible = true;
                }
                lst_FullName.DisplayMember = "FullName";
                lst_FullName.ValueMember = "FullName";
            }
        }

        private void cmb_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lst_FullName.Items.Count > 0)
                {
                    lst_FullName.Focus();
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                FillGrids();
                lst_FullName.Visible = false;
            }
        }

        private void pnl_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_KhatawaniNo_TextChanged(object sender, EventArgs e)
        
        
       {
         
        }

     
    }
}
