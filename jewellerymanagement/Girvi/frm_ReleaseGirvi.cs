using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using System.Data.SqlClient;
using BAL.Girvi;
using BAL.Common;
using System.Drawing.Text;
using JewelleryManagement.Reports.Girvi;
namespace JewelleryManagement.Girvi
{
    public partial class frm_ReleaseGirvi : Form
    {
        //forwardamount
        public delegate void SendData(string GirviNo, string KhatawaniNo, string otherfont);
        public frm_ReleaseGirvi()
        {
            InitializeComponent();
        }
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();

        SQLHelper _objsqlhelper = new SQLHelper();
        Simplevalidations _objSimplevalidations = new Simplevalidations();
        cls_GirviRelease _objGirviRelease = new cls_GirviRelease();
        clsGirviCommon _objCommon = new clsGirviCommon();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();

        int currentMouseOverRow { get; set; }
        int count { get; set; }
        /// <summary>
        /// Local variables
        public bool checkprintout { get; set; }
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_ReleaseGirvi_Load(object sender, EventArgs e)
        {
            SetFont();
            cmb_Name.Focus();
            fillTextBox();
            MasterClear();
        }
        public void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
            cmb_Name.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_InvoiceNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_DateOfRelease.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            // txt_DateOfRelease.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_khatawaniNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_Srno.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_DateOfDeposite.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_InterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_Loanamount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_DepositDays.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_InterestAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_InterestPaid.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_TotalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_PayAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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


        private void SetFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                ShivajiFont();
            }
        }





        private void fillTextBox()
        {
            AutoCompleteStringCollection ReceiptNo = new AutoCompleteStringCollection();
            AutoCompleteStringCollection khatawaniNo = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Name = new AutoCompleteStringCollection();
            DataTable dtNameAndKha, dtRecieptNo;
            //dtNameAndKha = _objGirviRelease.getNameandKhatawani();
            //for (int i = 0; i < dtNameAndKha.Rows.Count; i++)
            //{
            //    Name.Add(Convert.ToString(dtNameAndKha.Rows[i][0]));
            //    khatawaniNo.Add(Convert.ToString(dtNameAndKha.Rows[i][1]));
            //}

            if (rbt_PavtiNoYes.Checked == true)
            {
                string receipt_no = _objGirviAdd.getReceiptNoRelease("GRS-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "%");
                txt_ReceiptNo.Text = "GRS-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "-" + receipt_no;
                txt_ReceiptNo.Enabled = false;
            }


            dtRecieptNo = _objGirviRelease.getGirviReceiptNo();
            for (int i = 0; i < dtRecieptNo.Rows.Count; i++)
            {
                ReceiptNo.Add(Convert.ToString(dtRecieptNo.Rows[i][0]));

            }

            cmb_Name.DataSource = Name;
            txt_khatawaniNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_khatawaniNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_khatawaniNo.AutoCompleteCustomSource = khatawaniNo;


            txt_InvoiceNo.DataSource = ReceiptNo;
            txt_InvoiceNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_InvoiceNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_InvoiceNo.AutoCompleteCustomSource = ReceiptNo;
            txt_InvoiceNo.SelectedIndex = -1;

        }

        private void MasterClear()
        {
            cmb_Name.ResetText();
            txt_InvoiceNo.ResetText();
            txt_Srno.ResetText();
            txt_khatawaniNo.ResetText();
            txt_DateOfDeposite.ResetText();
            txt_InterestInPer.ResetText();
            txt_Loanamount.ResetText();
            txt_DepositDays.ResetText();
            txt_InterestAmount.ResetText();
            txt_InterestPaid.ResetText();
            txt_TotalAmount.ResetText();
            txt_PayAmount.ResetText();
            txt_Narration.ResetText();
            txt_vadhiv.ResetText();
            if (rbt_pavtinoNo.Checked == true)
            {
                txt_ReceiptNo.ResetText();
                txt_ReceiptNo.Enabled = true;

            }

            if (rbt_PavtiNoYes.Checked == true)
            {
                string receipt_no = _objGirviAdd.getReceiptNoRelease("GRS-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "%");
                txt_ReceiptNo.Text = "GRS-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "-" + receipt_no;
                txt_ReceiptNo.Enabled = false;
            }
            dgv_GirviRelease.Rows.Clear();
            dgv_GirviUnrelease.Rows.Clear();
            dgv_ItemDetail.Rows.Clear();
            txt_DateOfRelease.Text = dtp_DateOfRelease.Text;
            dgv_girvi_updateDetails.Rows.Clear();
            cmb_Name.Select();
            

        }

        private void txt_DateOfDeposite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_InterestInPer.Focus();
            }
        }

        private void txt_InterestInPer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                string str = _objGirviRelease.getActualInterestRate(txt_Srno.Text);
                frm_ActualPayAmount APM = new frm_ActualPayAmount(txt_Srno.Text, txt_Loanamount.Text, txt_DepositDays.Text, str);

                if (APM.ShowDialog() == DialogResult.OK)
                {


                }


            }

        }



        void txt_Loanamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_DepositDays.Focus();
            }
        }

        private void txt_DepositDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_InterestAmount.Focus();
            }
        }

        private void txt_IntersetAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_InterestPaid.Focus();
            }
        }

        private void txt_InterestPaid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_TotalAmount.Focus();
            }
        }

        private void txt_TotalAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PayAmount.Focus();
            }
        }

        private void txt_PayAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ReceiptNo.Focus();
            }
        }

        private void cmb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void txt_GirviKhatawani_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharDigitOnly(e);
        }

        private void txt_InterestInPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  _objSimplevalidations.ValidationDigitWithPoint(e, txt_InterestInPer.Text);
        }

        private void txt_Loanamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void txt_DepositDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void txt_IntersetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_InterestAmount.Text);
        }

        private void txt_InterestPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_InterestPaid.Text);
        }

        private void txt_TotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_TotalAmount.Text);
        }

        private void txt_PayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_PayAmount.Text);
        }

        private void frm_ReleaseGirvi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_ReleaseWith_Leave(object sender, EventArgs e)
        {
            cmb_Name.Focus();
        }

        private void btttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            this.Text = "गिरवी छुडाईये";
            rbt_Marathi.ForeColor = Color.MediumAquamarine;
            rbt_English.ForeColor = Color.Black;
            rbt_Hindi.ForeColor = Color.Black;
            lbl_KhatawaniNo.Text = "खतावानी नंबर";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_Name.Text = "ग्राहकका नाम";
            lbl_Name.Font = new Font("Arial", sizetext);
            lbl_GirviReceiptNo.Text = "गिरवी क्रमांक";
            lbl_GirviReceiptNo.Font = new Font("Arial", sizetext);
            lbl_DateOfDeposit.Text = "रखनेकी तारीख";
            lbl_DateOfDeposit.Font = new Font("Arial", sizetext);
            lbl_InterestInPer.Text = "ब्याज प्रतिशत";
            lbl_InterestInPer.Font = new Font("Arial", sizetext);
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_LoanAmount.Font = new Font("Arial", sizetext);
            lbl_DepositDays.Text = "पुरे दिन";
            lbl_DepositDays.Font = new Font("Arial", sizetext);
            lbl_InterestAmount.Text = "ब्याजकी रक्कम";
            lbl_InterestAmount.Font = new Font("Arial", sizetext);
            lbl_DateOfRelease.Text = "कर्ज छुडानेकी\n    तारीख";
            lbl_DateOfRelease.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = "पुरी रक्कम";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_PayAmount.Text = "जमा करनेकी\n   रक्कम";
            lbl_PayAmount.Font = new Font("Arial", sizetext);
            lbl_narration.Text = "अतिरिक्त माहिती ";
            lbl_narration.Font = new Font("Arial", sizetext);
            bttn_Release.Text = "रिलीज";
            bttn_Release.Font = new Font("Arial", sizetext);
            bttn_Reset.Text = "रिसेट";
            bttn_Reset.Font = new Font("Arial", sizetext);
            bttn_UnRelease.Text = "अनरिलीज";
            bttn_UnRelease.Font = new Font("Arial", sizetext);
            bttn_Close.Text = "बंद करो";
            //labels.Text = "गिरवी सोडवा";
            //label45.Text = "ग्राहक खतावणी नं.";
            // button1.Text = "जुनी रिलीज करून\nनवीन चढवा";

            lbl_ReceiptNo.Text = "पावती क्रं:";
            lbl_ReceiptNo.Font = new Font("Arial", sizetext);
            lbl_GirviReceiptNo.Text = "गिरवी खतावणी";
            lbl_GirviReceiptNo.Font = new Font("Arial", sizetext);
            lbl_InterestPaid.Text = "ब्याज";
            lbl_InterestPaid.Font = new Font("Arial", sizetext);

            dgv_ItemDetail.Columns[0].HeaderText = "गिरवी क्रमांक";
            dgv_ItemDetail.Columns[1].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns[2].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns[3].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns[4].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns[5].HeaderText = "ग्रॉस वजन";
            dgv_ItemDetail.Columns[6].HeaderText = "नेट वजन";
            dgv_ItemDetail.Columns[7].HeaderText = "प्रमाण";
            dgv_ItemDetail.Columns[8].HeaderText = "घट वजन";
            dgv_ItemDetail.Columns[9].HeaderText = "वजन प्रतिशत";
            dgv_ItemDetail.Columns[10].HeaderText = "चालू दर";
            dgv_ItemDetail.Columns[11].HeaderText = "फाईन वजन";
            dgv_ItemDetail.Columns[12].HeaderText = "रक्कम";

            dgv_ItemDetail.Columns[1].Visible = false;
            dgv_ItemDetail.Columns[3].Visible = false;
            dgv_ItemDetail.Columns[2].Visible = true;
            dgv_ItemDetail.Columns[4].Visible = true;

            dgv_GirviUnrelease.Columns[0].HeaderText = "पावती नं.";
            dgv_GirviUnrelease.Columns[1].HeaderText = "गिरवी क्रमांक";
            dgv_GirviUnrelease.Columns[2].HeaderText = "कर्ज रक्कम";
            dgv_GirviUnrelease.Columns[3].HeaderText = "रखनेकी तारीख";
            dgv_GirviUnrelease.Columns[4].HeaderText = "ब्याज प्रतिशत";
            dgv_GirviUnrelease.Columns[5].HeaderText = "कालावधी";
            dgv_GirviUnrelease.Columns[6].HeaderText = "स्थिती";
            dgv_GirviUnrelease.Columns[7].HeaderText = "कालावधी";
            dgv_GirviUnrelease.Columns[8].HeaderText = "फोरओर्ड";
            dgv_GirviUnrelease.Columns[9].HeaderText = "फोरओर्ड To";


            dgv_GirviRelease.Columns[0].HeaderText = "गिरवी क्रमांक";
            dgv_GirviRelease.Columns[1].HeaderText = "छुडानेकी तारीख";
            dgv_GirviRelease.Columns[2].HeaderText = "छुडानेकी रक्कम";
            dgv_GirviRelease.Columns[3].HeaderText = "रखनेकी तारीख";
            dgv_GirviRelease.Columns[4].HeaderText = "ब्याज प्रतिशत";
            dgv_GirviRelease.Columns[5].HeaderText = "कालावधी";
            dgv_GirviRelease.Columns[6].HeaderText = "स्थिती";



            dgv_ItemDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
            dgv_GirviUnrelease.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
            dgv_GirviRelease.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);

        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            this.Text = "गिरवी सोडवा";
            rbt_Marathi.ForeColor = Color.MediumAquamarine;
            rbt_English.ForeColor = Color.Black;
            rbt_Hindi.ForeColor = Color.Black;
            lbl_KhatawaniNo.Text = "खतावानी नंबर";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_Name.Text = "ग्राहकाचे नाव";
            lbl_Name.Font = new Font("Arial", sizetext);
            lbl_GirviReceiptNo.Text = "गाहनी क्रमांक";
            lbl_GirviReceiptNo.Font = new Font("Arial", sizetext);
            lbl_DateOfDeposit.Text = "ठेव तारीख";
            lbl_DateOfDeposit.Font = new Font("Arial", sizetext);
            lbl_InterestInPer.Text = "व्याज टक्के";
            lbl_InterestInPer.Font = new Font("Arial", sizetext);
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_LoanAmount.Font = new Font("Arial", sizetext);
            lbl_DepositDays.Text = "एकुण दिवस";
            lbl_DepositDays.Font = new Font("Arial", sizetext);
            lbl_InterestAmount.Text = "व्याजाची रक्कम";
            lbl_InterestAmount.Font = new Font("Arial", sizetext);
            lbl_DateOfRelease.Text = "कर्ज सोडवण्याची तारीख";
            lbl_DateOfRelease.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = "एकुण रक्कम";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_PayAmount.Text = "जमा करण्याची\n   रक्कम";
            lbl_PayAmount.Font = new Font("Arial", sizetext);
            lbl_narration.Text = "इतर माहिती ";
            lbl_narration.Font = new Font("Arial", sizetext);
            
            bttn_Release.Text = "रिलीज";
            bttn_Release.Font = new Font("Arial", sizetext);
            bttn_Reset.Text = "रिसेट";
            bttn_Reset.Font = new Font("Arial", sizetext);
            bttn_UnRelease.Text = "अनरिलीज";
            bttn_UnRelease.Font = new Font("Arial", sizetext);
            bttn_Close.Text = "बंद करा";

            lbl_ReceiptNo.Text = "पावती क्रं:";
            lbl_ReceiptNo.Font = new Font("Arial", sizetext);
            lbl_GirviReceiptNo.Text = "गाहनी पावती क्रं";
            lbl_GirviReceiptNo.Font = new Font("Arial", sizetext);
            lbl_InterestPaid.Text = "व्याज";
            lbl_InterestPaid.Font = new Font("Arial", sizetext);

            dgv_ItemDetail.Columns[0].HeaderText = "गाहनी क्रमांक";
            dgv_ItemDetail.Columns[1].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns[2].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns[3].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns[4].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns[5].HeaderText = "ग्रॉस वजन";
            dgv_ItemDetail.Columns[6].HeaderText = "नेट वजन";
            dgv_ItemDetail.Columns[7].HeaderText = "प्रमाण";
            dgv_ItemDetail.Columns[8].HeaderText = "घटलेले वजन";
            dgv_ItemDetail.Columns[9].HeaderText = "वजन टक्के";
            dgv_ItemDetail.Columns[10].HeaderText = "चालू दर";
            dgv_ItemDetail.Columns[11].HeaderText = "फाईन वजन";
            dgv_ItemDetail.Columns[12].HeaderText = "रक्कम";

            dgv_ItemDetail.Columns[1].Visible = false;
            dgv_ItemDetail.Columns[3].Visible = false;
            dgv_ItemDetail.Columns[2].Visible = true;
            dgv_ItemDetail.Columns[4].Visible = true;


            dgv_GirviUnrelease.Columns[0].HeaderText = "गाहनी क्रमांक";
            dgv_GirviUnrelease.Columns[1].HeaderText = "कर्ज रक्कम";
            dgv_GirviUnrelease.Columns[2].HeaderText = "ठेव तारीख";
            dgv_GirviUnrelease.Columns[3].HeaderText = "व्याज टक्के";
            dgv_GirviUnrelease.Columns[4].HeaderText = "कालावधी";
            dgv_GirviUnrelease.Columns[5].HeaderText = "स्थिती";
            dgv_GirviUnrelease.Columns[6].HeaderText = "कालावधी";
            dgv_GirviUnrelease.Columns[7].HeaderText = "फोरओर्ड";
            dgv_GirviUnrelease.Columns[8].HeaderText = "फोरओर्ड To";
            dgv_GirviUnrelease.Columns[9].HeaderText = "पावती नं.";

            dgv_GirviRelease.Columns[0].HeaderText = "गाहनी क्रमांक";
            dgv_GirviRelease.Columns[1].HeaderText = "सोडवल्याची तारीख";
            dgv_GirviRelease.Columns[2].HeaderText = "सोडवलेली रक्कम";
            dgv_GirviRelease.Columns[3].HeaderText = "ठेव तारीख";
            dgv_GirviRelease.Columns[4].HeaderText = "व्याज टक्के";
            dgv_GirviRelease.Columns[5].HeaderText = "कालावधी";
            dgv_GirviRelease.Columns[6].HeaderText = "स्थिती";



            dgv_ItemDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
            dgv_GirviUnrelease.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
            dgv_GirviRelease.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);

        }

        private void pnl_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Language

        private void cmb_Name_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void txt_DateOfRelease_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ReceiptNo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_PayAmount_Enter(object sender, EventArgs e)
        {

        }

        private void txt_TotalAmount_Enter(object sender, EventArgs e)
        {

        }

        private void txt_InterestPaid_Enter(object sender, EventArgs e)
        {

        }

        private void txt_InterestAmount_Enter(object sender, EventArgs e)
        {

        }

        private void txt_DepositDays_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Loanamount_Enter(object sender, EventArgs e)
        {

        }

        private void txt_InterestInPer_Enter(object sender, EventArgs e)
        {

        }

        private void txt_DateOfDeposite_Enter(object sender, EventArgs e)
        {

        }

        private void txt_khatawaniNo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_InvoiceNo_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(2)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        #endregion language

        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{

            //    SearchGirvi();

            //}



            try
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


                    SearchGirvi();

                    lst_FullName.Visible = false;

                }
                else
                {


                    //if (cmb_FullName.Text != "")
                    //{

                    //    //cmb_FullName.Items.Clear();
                    //  //CustName = cmb_FullName.Text;
                    //  //  cmb_FullName.DataSource = _objGirviAdd.getFName(CustName);
                    //    //cmb_FullName.DroppedDown = true;
                    //    //cmb_FullName.Items.Clear();

                    //    //cmb_FullName.SelectedIndex = -1;

                    //}
                }
                ClearPrevious();

            }
            catch (Exception ex)
            {

            }
        }

        private void ClearPrevious()
        {
            dtp_DateOfRelease.ResetText();
            txt_Srno.ResetText();
            txt_DateOfDeposite.ResetText();
            txt_InterestInPer.ResetText();
            txt_Loanamount.ResetText();
            txt_DepositDays.ResetText();
            txt_InterestAmount.ResetText();
            txt_InterestPaid.ResetText();
            txt_TotalAmount.ResetText();
            txt_PayAmount.ResetText();
            if (rbt_pavtinoNo.Checked == true)
            {
                txt_ReceiptNo.ResetText();
                txt_ReceiptNo.Enabled = true;

            }
        }

        private void SearchGirvi()
        {
            try
            {
                if (ValidSearch())
                {
                    DataTable dtSearch = null;

                    dtSearch = _objGirviRelease.getKhatawani(cmb_Name.Text);

                    if (dtSearch.Rows.Count > 0)
                    {
                        if (dtSearch.Rows.Count >= 1)
                        {

                            cmb_Name.Text = Convert.ToString((dtSearch.Rows[0]["FullName"]));

                            txt_khatawaniNo.Text = Convert.ToString((dtSearch.Rows[0]["khatawani_No"]));

                        }
                        FillGrid();



                    }
                    else
                    {
                        //MessageBox.Show("Record not found ", "Girvi Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetText();
                    }
                }
                else
                {
                    MessageBox.Show("Please either  Khatawani No or Name  ", "Girvi Says", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      

        private void SearchGirvibyInvoiceNo()
        {
            try
            {
                if (ValidSearchinvoice())
                {
                    DataTable dtSearch = null;

                    string khtavanino = _objGirviRelease.getkhatawani_NobyReceiptNo(txt_InvoiceNo.Text);
                    dtSearch = _objGirviRelease.getKhatawaniNo(khtavanino);

                    if (dtSearch.Rows.Count > 0)
                    {
                        if (dtSearch.Rows.Count >= 1)
                        {

                            cmb_Name.Text = Convert.ToString((dtSearch.Rows[0]["FullName"]));

                            txt_khatawaniNo.Text = Convert.ToString((dtSearch.Rows[0]["khatawani_No"]));

                        }
                        FillGrid();



                    }
                    else
                    {
                        //MessageBox.Show("Record not found ", "Girvi Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetText();
                    }
                }
                else
                {
                    MessageBox.Show("Please either  Khatawani No or Name  ", "Girvi Says", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool ValidSearchinvoice()
        {
            if (txt_InvoiceNo.Text != "")
            {
                return true;
            }
            else { return false; }
        }

        private bool ValidSearchPayAmount()
        {
            if (txt_PayAmount.Text != "")
            {
                return true;
            }
            else { return false; }
        }

        private void  FillGrid()
        {
            DataTable dtGirviUnrelease = _objGirviRelease.getGirviDataFromKhatawani(txt_khatawaniNo.Text);

            DataTable dtGirviRelease = _objGirviRelease.getReleaseDataFromKhatawani(txt_khatawaniNo.Text);
            txt_vadhiv.ResetText();


          

            dgv_GirviUnrelease.Rows.Clear();
            dgv_GirviRelease.Rows.Clear();
            dgv_ItemDetail.Rows.Clear();

            for (int i = 0; i < dtGirviUnrelease.Rows.Count; i++)
            {

                string str = dtGirviUnrelease.Rows[i]["Date_of_Forward"].ToString() + " " + dtGirviUnrelease.Rows[i]["Forwarded_to"].ToString() + " " + dtGirviUnrelease.Rows[i]["forwardamount"].ToString() + " " + dtGirviUnrelease.Rows[i]["Interest"].ToString();



                dgv_GirviUnrelease.Rows.Add(dtGirviUnrelease.Rows[i]["GirviRecordNo"].ToString(), dtGirviUnrelease.Rows[i]["receipt_no"].ToString(), dtGirviUnrelease.Rows[i]["Amount"].ToString(), dtGirviUnrelease.Rows[i]["Date_of_deposit"].ToString(), dtGirviUnrelease.Rows[i]["interset_rate"].ToString(), dtGirviUnrelease.Rows[i]["Status"].ToString(), dtGirviUnrelease.Rows[i]["duration"].ToString(), dtGirviUnrelease.Rows[i]["forwardstatus"].ToString(), str, dtGirviUnrelease.Rows[i]["narration"].ToString(), dtGirviUnrelease.Rows[i]["forwardamount"].ToString(), dtGirviUnrelease.Rows[i]["Interest"].ToString());
            }
            for (int i = 0; i < dtGirviRelease.Rows.Count; i++)
            {
                DataTable dtNarration = _objGirviRelease.getNarrationByGirvi(dtGirviRelease.Rows[i]["GirviRecordNo"].ToString());
                dgv_GirviRelease.Rows.Add(dtGirviRelease.Rows[i]["GirviRecordNo"].ToString(), dtGirviRelease.Rows[i]["withdraw_release_date"].ToString(), dtGirviRelease.Rows[i]["Amount"].ToString(), dtGirviRelease.Rows[i]["Date_of_deposit"].ToString(), dtGirviRelease.Rows[i]["interset_rate"].ToString(), dtGirviRelease.Rows[i]["duration"].ToString(), dtGirviRelease.Rows[i]["Status"].ToString(), dtNarration);
            }
        }
        private bool ValidSearch()
        {

            if (cmb_Name.Text != "" || txt_khatawaniNo.Text != "")
            {
                return true;
            }
            else { return false; }

        }

        private void dgv_GirviUnrelease_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            DataTable dtacc=_objCommon.getAccountType();
                dgv_ItemDetail.Rows.Clear();

                string GirviNo = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells[0].Value);

                DataTable dt = _objGirviRelease.getGirviData(GirviNo);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_ItemDetail.Rows.Add(dt.Rows[i]["GirviNo"].ToString(), dt.Rows[i]["metal_type"].ToString(), dt.Rows[i]["metal_type"].ToString(), dt.Rows[i]["item_type"].ToString(), dt.Rows[i]["item_type"].ToString(), dt.Rows[i]["gross_wt"].ToString(), dt.Rows[i]["reduce_wt"].ToString(), dt.Rows[i]["net_wt"].ToString(), dt.Rows[i]["Total_Quantity"].ToString(), dt.Rows[i]["wt_in_percent"].ToString(), dt.Rows[i]["fine_wt"].ToString(), dt.Rows[i]["current_rate"].ToString(), dt.Rows[i]["amount"].ToString());
                }
                if (dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells[5].Value.ToString() == "Release")
                {
                    txt_Srno.Text = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells[0].Value);
                    bttn_UnRelease.Enabled = true;
                    txt_InterestInPer.Text = "";
                    txt_Loanamount.Text = "";
                    txt_Narration.Text = "";
                    txt_DateOfDeposite.Text = "";
                    txt_DepositDays.Text = "";
                    txt_InterestAmount.Text = "";
                    txt_TotalAmount.Text = "";
                    txt_PayAmount.Text = "";
                    txt_DateOfRelease.Text = dtp_DateOfRelease.Text;

                    bttn_UnRelease.Enabled = false;

                }
                else
                {
                    bttn_UnRelease.Enabled = false;
                    bttn_Release.Enabled = true;

                    txt_Srno.Text = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["GirviNoUnrelease"].Value);
                    txt_InterestInPer.Text = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["InterestRate"].Value);
                    txt_Loanamount.Text = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["LoanAmount"].Value);

                    txt_DateOfDeposite.Text = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["DateOfDeposit"].Value);
                    txt_DepositDays.Text = ((Convert.ToDateTime(txt_DateOfRelease.Text) - Convert.ToDateTime(txt_DateOfDeposite.Text)).TotalDays).ToString();
                    txt_InvoiceNo.Text = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["RecieptNo"].Value);
                    txt_Narration.Text = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["Narration"].Value);
                    txtForwardAmount.Text = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["ForwardAmount"].Value);
                    txtForwardInterest.Text = Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["ForwardInterest"].Value);

                    if (dtacc.Rows[0]["AccountType"].ToString() == "1")
                    {
                          txt_InterestAmount.Text = _objCommon.Interest(txt_Loanamount.Text, txt_InterestInPer.Text, txt_DepositDays.Text).ToString();
                          if (Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["Forward"].Value) == "Forward")
                          {
                              txtForwardInterestAmount.Text = _objCommon.Interest(txtForwardAmount.Text, txtForwardInterest.Text, txt_DepositDays.Text).ToString();
                          }

                    }
                    else
                    {
                          txt_InterestAmount.Text = _objCommon.InterestNo2(txt_Loanamount.Text, txt_InterestInPer.Text, txt_DepositDays.Text).ToString();
                          if (Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["Forward"].Value) == "Forward")
                          {
                              txtForwardInterestAmount.Text = _objCommon.Interest(txtForwardAmount.Text, txtForwardInterest.Text, txt_DepositDays.Text).ToString();
                          }
                    }
                  
                    txt_TotalAmount.Text = (Convert.ToDouble(txt_InterestAmount.Text) + Convert.ToDouble(txt_Loanamount.Text)).ToString();

                    txt_DateOfRelease.Text = dtp_DateOfRelease.Text;
                    DataTable dtInterestgirvi = _objGirviRelease.getinterestPaid(txt_Srno.Text);

                    double InterestPaidAmount = 0;
                    for (int i = 0; i < dtInterestgirvi.Rows.Count; i++)
                    {
                        InterestPaidAmount = InterestPaidAmount + (Convert.ToDouble(dtInterestgirvi.Rows[i][0].ToString()));
                    }
                    txt_InterestPaid.ResetText();
                    txt_InterestPaid.Text = InterestPaidAmount.ToString();

                    dgv_girvi_updateDetails.Rows.Clear();
                    DataTable girvidetails = _objGirviAdd.getGirviByInvoiceNo(txt_Srno.Text);

                    txt_vadhiv.Text = girvidetails.Rows[0]["vadhiv"].ToString().Replace(",", "\r\n") + "\r\n";

                    string UpdateDetails = Convert.ToString(girvidetails.Rows[0]["updated_girvi_no"]);
                    if (UpdateDetails != "")
                    {
                        string[] updatedetailsData = UpdateDetails.Split('.');
                        for (int i = 0; i < updatedetailsData.Count(); i++)
                        {
                            string[] updateDataSeperate = updatedetailsData[i].Split(',');
                            dgv_girvi_updateDetails.Rows.Add();
                            dgv_girvi_updateDetails.Rows[dgv_girvi_updateDetails.Rows.Count - 1].Cells["UDReceiptNo"].Value = updateDataSeperate[0].ToString();

                            dgv_girvi_updateDetails.Rows[dgv_girvi_updateDetails.Rows.Count - 1].Cells["UDGirviNo"].Value = updateDataSeperate[1].ToString();

                            dgv_girvi_updateDetails.Rows[dgv_girvi_updateDetails.Rows.Count - 1].Cells["UDLoanAmount"].Value = updateDataSeperate[2].ToString();
                            dgv_girvi_updateDetails.Rows[dgv_girvi_updateDetails.Rows.Count - 1].Cells["UDDateOfDeposite"].Value = updateDataSeperate[3].ToString();
                        }
                    }
                }
                txt_PayAmount.Select();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_GirviUnrelease_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Interest Pay"));
                m.MenuItems.Add(new MenuItem("View Interest Paid"));
                m.MenuItems[0].Click += new EventHandler(Frm_InterestPay);
                m.MenuItems[1].Click += new EventHandler(Frm_ViewInterestPay);


                currentMouseOverRow = dgv_GirviUnrelease.HitTest(e.X, e.Y).RowIndex;



                m.Show(dgv_GirviUnrelease, new Point(e.X, e.Y));


            }
        }
        void Frm_InterestPay(object sender, EventArgs e)
        {
            string girvi_no = Convert.ToString(dgv_GirviUnrelease.Rows[currentMouseOverRow].Cells[0].Value);
            frm_InterestPay _objInterestPay = new frm_InterestPay(dgv_GirviUnrelease.Rows[currentMouseOverRow].Cells["GirviNoUnrelease"].Value.ToString());
            _objInterestPay.ShowDialog();
            txt_InterestPaid.Text = _objInterestPay.sumInterestPaid.ToString();
        }

        void Frm_ViewInterestPay(object sender, EventArgs e)
        {

            string girvi_no = Convert.ToString(dgv_GirviUnrelease.Rows[currentMouseOverRow].Cells[0].Value);
            Frm_InterestPayDetails _objInterestPay = new Frm_InterestPayDetails(dgv_GirviUnrelease.Rows[currentMouseOverRow].Cells["GirviNoUnrelease"].Value.ToString());
            _objInterestPay.ShowDialog();
        }

        private void dgv_GirviRelease_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_GirviRelease.Rows[dgv_GirviRelease.CurrentCell.RowIndex].Cells[6].Value.ToString() == "Release")
            {
                txt_Srno.Text = Convert.ToString(dgv_GirviRelease.Rows[dgv_GirviRelease.CurrentCell.RowIndex].Cells[0].Value);
                bttn_UnRelease.Enabled = true;
                txt_InterestInPer.Text = "";
                txt_Loanamount.Text = "";

                txt_DateOfDeposite.Text = "";
                txt_DepositDays.Text = "";
                txt_InterestAmount.Text = "";
                txt_TotalAmount.Text = "";
                txt_PayAmount.Text = "";
                txt_vadhiv.ResetText();
                txt_DateOfRelease.Text = dtp_DateOfRelease.Text;
                bttn_UnRelease.Enabled = true;

            }
            dgv_ItemDetail.Rows.Clear();
            DataTable dtGirviItemData = _objGirviRelease.getGirviItemdata(dgv_GirviRelease.Rows[dgv_GirviRelease.CurrentCell.RowIndex].Cells[0].Value.ToString());

            for (int i = 0; i < dtGirviItemData.Rows.Count; i++)
            {
                dgv_ItemDetail.Rows.Add(dtGirviItemData.Rows[i]["GirviNo"].ToString(), dtGirviItemData.Rows[i]["metal_type"].ToString(), dtGirviItemData.Rows[i]["metal_type"].ToString(), dtGirviItemData.Rows[i]["item_type"].ToString(), dtGirviItemData.Rows[i]["item_type"].ToString(), dtGirviItemData.Rows[i]["gross_wt"].ToString(), dtGirviItemData.Rows[i]["reduce_wt"].ToString(), dtGirviItemData.Rows[i]["net_wt"].ToString(), dtGirviItemData.Rows[i]["Total_Quantity"].ToString(), dtGirviItemData.Rows[i]["wt_in_percent"].ToString(), dtGirviItemData.Rows[i]["fine_wt"].ToString(), dtGirviItemData.Rows[i]["current_rate"].ToString(), dtGirviItemData.Rows[i]["amount"].ToString());
            }
        }

        private void bttn_ReleaseWith_Click(object sender, EventArgs e)
        {
            Frm_ReleaseWithNewAdd _objNewAdd = new Frm_ReleaseWithNewAdd(txt_khatawaniNo.Text, txt_Srno.Text);
            _objNewAdd.ShowDialog();
        }

        private void bttn_Release_Click(object sender, EventArgs e)
        {  
            bttn_Release.Enabled = false;
            try
            {
                int finalcialYearId = _objFinancialYear.getSelectedFinancialYearId();
                string payamount = txt_PayAmount.Text.Replace(",", "");
                string totalamount = txt_TotalAmount.Text.Replace(",", "");
                DialogResult dr = MessageBox.Show(" Are U sure To release", "suvarnapp  Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if (txt_PayAmount.Text == "")
                    {

                        txt_PayAmount.Focus();
                        MessageBox.Show("Please enter Pay Amount");


                    }
                        if (Convert.ToDouble(payamount) == Convert.ToDouble(totalamount))
                        {
                            if (getDetails())
                            {
                                bttn_Release.Enabled = false;
                                bttn_ReleaseWith.Enabled = true;
                                string status = "Released";
                                _objGirviRelease.SetGirvitoRelease(txt_khatawaniNo.Text, txt_Srno.Text, status, txt_DateOfRelease.Text);
                                _objGirviRelease.SetReleasemaster(txt_khatawaniNo.Text, txt_Srno.Text, txt_Loanamount.Text, txt_DepositDays.Text, txt_InterestInPer.Text, txt_TotalAmount.Text, txt_DateOfRelease.Text, txt_InterestAmount.Text, txt_ReceiptNo.Text, finalcialYearId, txt_Narration.Text);
                                count = 0;
                                MessageBox.Show("Girvi No: " + txt_InvoiceNo.Text + " is Released");
                                bttn_Release.Enabled = true;

                                if (rbt_PrintTrue.Checked == true)
                                {
                                    DialogResult drReportPrint = MessageBox.Show("Do You Want To Print", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (drReportPrint == DialogResult.Yes)
                                    {
                                        if (rbt_OtherTrue.Checked == true)
                                        {
                                            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                                            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataReleaseGirvi);
                                            _obj(txt_Srno.Text, txt_khatawaniNo.Text, "Other");
                                            _objfrm_ReportViewer.Show();
                                        }
                                        else
                                        {
                                            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                                            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataReleaseGirvi);
                                            _obj(txt_Srno.Text, txt_khatawaniNo.Text, "Marathi");
                                            _objfrm_ReportViewer.Show();
                                        }
                                    }
                                }
                                    MasterClear();
                                    //  bttn_ReleaseWith.Enabled = true;
                                    dgv_ItemDetail.Rows.Clear();
                                    dgv_GirviUnrelease.Rows.Clear();
                                    dgv_GirviRelease.Rows.Clear();

                                    bttn_Release.Enabled = false;

                                }
                            
                         
                            else
                            {
                                MessageBox.Show("Girvi Cant Relesed, Pay" + (Convert.ToDouble(txt_Loanamount.Text) - Convert.ToDouble(txt_InterestPaid.Text)).ToString());
                                
                            }

                        }
               
                }
                    
                    else
                    {
                        MessageBox.Show("Girvi is Not Released by user", "JMS Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           // bttn_Release.Enabled = true;

        }

        private bool getDetails()
        {
            if (rbt_English.Checked == true)
            {
                DialogResult dr = MessageBox.Show("Your Girvi Amount is " + txt_Loanamount.Text + "\n do you want to continue ?", "JMS Says ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {

                DialogResult dr = MessageBox.Show("तुमची गिरवी रक्कम " + txt_Loanamount.Text + "आहे\n  तुम्हाला सोडवायची आहे का?", "JMS Says ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    return true;
                }
                else { return false; }
            }
        }

        private void dtp_DateOfRelease_ValueChanged(object sender, EventArgs e)
        {
            DataTable dtacc = _objCommon.getAccountType(); 
            txt_DateOfRelease.Text = dtp_DateOfRelease.Value.ToShortDateString().ToString();
            if (txt_DateOfRelease.Text != "" && txt_DateOfDeposite.Text != "")
            {
                txt_DepositDays.Text = ((Convert.ToDateTime(txt_DateOfRelease.Text) - Convert.ToDateTime(txt_DateOfDeposite.Text)).TotalDays).ToString();
                if (dtacc.Rows[0]["AccountType"].ToString() == "1")
                {
                    txt_InterestAmount.Text = _objCommon.Interest(txt_Loanamount.Text, txt_InterestInPer.Text, txt_DepositDays.Text).ToString();
                    if (Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["Forward"].Value) == "Forward")
                    {
                        txtForwardInterestAmount.Text = _objCommon.Interest(txtForwardAmount.Text, txtForwardInterest.Text, txt_DepositDays.Text).ToString();
                    }
                }
                else
                {
                    txt_InterestAmount.Text = _objCommon.InterestNo2(txt_Loanamount.Text, txt_InterestInPer.Text, txt_DepositDays.Text).ToString();
                    if (Convert.ToString(dgv_GirviUnrelease.Rows[dgv_GirviUnrelease.CurrentCell.RowIndex].Cells["Forward"].Value) == "Forward")
                    {
                        txtForwardInterestAmount.Text = _objCommon.Interest(txtForwardAmount.Text, txtForwardInterest.Text, txt_DepositDays.Text).ToString();
                    }
                }
                txt_TotalAmount.Text = (Convert.ToDouble(txt_InterestAmount.Text) + Convert.ToDouble(txt_Loanamount.Text)).ToString();
            }
        }

        private void cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchGirvi();

        }

        private void bttn_UnRelease_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(" Are U sure To Unrelase", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    string str = _objGirviRelease.UnreleaseGirvi(txt_khatawaniNo.Text, txt_Srno.Text, txt_DateOfRelease.Text);
                    //dgv_GirviUnrelease.Rows.Clear();
                    //dgv_ItemDetail.Rows.Clear();
                    //dgv_GirviRelease.Rows.Clear();
                    //DataTable dtgirviKhatavani = _objGirviRelease.getGirviDataFromKhatawani(txt_khatawaniNo.Text);
                    //for (int i = 0; i < dtgirviKhatavani.Rows.Count; i++)
                    //{
                    //    dgv_GirviUnrelease.Rows.Add(dtgirviKhatavani.Rows[i][0].ToString(), dtgirviKhatavani.Rows[i][1].ToString(), dtgirviKhatavani.Rows[i][2].ToString(), dtgirviKhatavani.Rows[i][3].ToString(), dtgirviKhatavani.Rows[i][5].ToString(), dtgirviKhatavani.Rows[i][6].ToString());
                    //}
                    //DataTable dtreleaseGirvi = _objGirviRelease.getReleaseGirvidata(dtgirviKhatavani.Rows[0]["GirviRecordNo"].ToString());
                    //for (int i = 0; i < dtreleaseGirvi.Rows.Count; i++)
                    //{
                    //    dgv_GirviRelease.Rows.Add(dtreleaseGirvi.Rows[i][0].ToString(), dtreleaseGirvi.Rows[i][1].ToString(), dtreleaseGirvi.Rows[i][2].ToString(), dtreleaseGirvi.Rows[i][3].ToString(), dtreleaseGirvi.Rows[i][5].ToString(), dtreleaseGirvi.Rows[i][6].ToString());
                    //}
                    FillGrid();
                    MessageBox.Show("Girvi Unrelease done");

                }
                else
                { MessageBox.Show(" Girvi Not Unrlease by User", "JMS Says", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            MasterClear();
        }

        private void rbt_Marathi_CheckedChanged_1(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_CustomerInfo.Text = "ग्राहकाची माहीती ";
            lbl_Date.Text = "तारीख";
            this.Text = "गाहाणी सोडवा ";
            bttn_Release.Text = "रीलीस";
            bttn_UnRelease.Text = "अनरीलीस";
            bttn_ReleaseWith.Text = "रीलीस वीथ";
            bttn_Reset.Text = "रीसेट";
            bttn_Close.Text = "बंद";

            lbl_Date.Text = "तारीख";
            lbl_Date.Font = new Font("Arial", sizetext);
            lbl_DateOfDeposit.Text = "ठेव तारीख";
            lbl_DateOfDeposit.Font = new Font("Arial", sizetext);
            lbl_DateOfRelease.Text = "सोडवण्याची तारीख";
            lbl_DateOfRelease.Font = new Font("Arial", sizetext);
            lbl_DepositDays.Text = "एकून दिवस";
            lbl_DepositDays.Font = new Font("Arial", sizetext);
            lbl_GirviReceiptNo.Text = "गिरवी पावती नं.";
            lbl_GirviReceiptNo.Font = new Font("Arial", sizetext);
            lbl_InterestAmount.Text = "व्याज रक्कम";
            lbl_InterestAmount.Font = new Font("Arial", sizetext);
            lbl_InterestInPer.Text = "व्याज टक्के";
            lbl_InterestInPer.Font = new Font("Arial", sizetext);
            lbl_InterestPaid.Text = "व्याज दिले";
            lbl_InterestPaid.Font = new Font("Arial", sizetext);
            lbl_KhatawaniNo.Text = "खतावणी नं.";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_LoanAmount.Font = new Font("Arial", sizetext);
            lbl_Name.Text = "नाव";
            lbl_Name.Font = new Font("Arial", sizetext);
            lbl_PayAmount.Text = "देण्याची रक्कम";
            lbl_PayAmount.Font = new Font("Arial", sizetext);

            lbl_Percent.Font = new Font("Arial", sizetext);
            lbl_ReceiptNo.Text = "पावती नं.";
            lbl_ReceiptNo.Font = new Font("Arial", sizetext);
            lbl_Srno.Text = "अनुक्रमांक";
            lbl_Srno.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = "एकून रक्कम";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_narration.Text = "ईतर माहिती ";
            lbl_narration.Font = new Font("Arial", sizetext);

            dgv_ItemDetail.Columns["GirviNoItem"].HeaderText = "गिरवी नं.";
            dgv_ItemDetail.Columns["MetalType"].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns["ItemType1"].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns["GrossWt"].HeaderText = "ग्रॉस वजन";
            dgv_ItemDetail.Columns["ReduceWt"].HeaderText = "घट वजन";
            dgv_ItemDetail.Columns["FinalWt"].HeaderText = "नेट वजन";
            dgv_ItemDetail.Columns["WtInPercent"].HeaderText = "वजन टक्के";
            dgv_ItemDetail.Columns["FineWt"].HeaderText = "फाईन वजन";
            dgv_ItemDetail.Columns["Quantity"].HeaderText = "प्रमाण";
            dgv_ItemDetail.Columns["CurrentPrice"].HeaderText = "चालू दर";
            dgv_ItemDetail.Columns["TotalAmount"].HeaderText = "रक्कम";


            dgv_GirviRelease.Columns["GirviNo"].HeaderText = "गिरवी नं.";
            dgv_GirviRelease.Columns["ReleaseDate"].HeaderText = "सोडवण्याची तारीख";
            dgv_GirviRelease.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["DateOfDepositRelease"].HeaderText = "ठेव तारीख";
            dgv_GirviRelease.Columns["InterestRateRelease"].HeaderText = "व्याज दर";
            dgv_GirviRelease.Columns["DurationRelease"].HeaderText = "कालावधी";
            dgv_GirviRelease.Columns["StatusRelease"].HeaderText = "स्थिती";

            dgv_GirviUnrelease.Columns["RecieptNo"].HeaderText = "पावती नं.";
            dgv_GirviUnrelease.Columns["LoanAmount"].HeaderText = "कर्ज रक्कम";
            dgv_GirviUnrelease.Columns["DateOfDeposit"].HeaderText = "ठेव तारीख";
            dgv_GirviUnrelease.Columns["InterestRate"].HeaderText = "व्याज दर";
            dgv_GirviUnrelease.Columns["Status"].HeaderText = "स्थिती";
            dgv_GirviUnrelease.Columns["Duration"].HeaderText = "कालावधी";
            dgv_GirviUnrelease.Columns["Forward"].HeaderText = "फोरवर्ड";
            dgv_GirviUnrelease.Columns["ForwardedTo"].HeaderText = "फोरवर्ड To";

        }

        private void rbt_Hindi_CheckedChanged_1(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_CustomerInfo.Text = "ग्राहकाची माहीती ";
            lbl_Date.Text = "तारीख";
            this.Text = "गाहाणी छुडाईये ";
            lbl_Date.Text = "तारीख";
            lbl_Date.Font = new Font("Arial", sizetext);
            lbl_DateOfDeposit.Text = "रखनेकी तारीख";
            lbl_DateOfDeposit.Font = new Font("Arial", sizetext);
            lbl_DateOfRelease.Text = "छुडानेकी तारीख";
            lbl_DateOfRelease.Font = new Font("Arial", sizetext);
            lbl_DepositDays.Text = "पुरे दिन";
            lbl_DepositDays.Font = new Font("Arial", sizetext);
            lbl_GirviReceiptNo.Text = "गिरवी पावती नं.";
            lbl_GirviReceiptNo.Font = new Font("Arial", sizetext);
            lbl_InterestAmount.Text = "ब्याज रक्कम";
            lbl_InterestAmount.Font = new Font("Arial", sizetext);
            lbl_InterestInPer.Text = "ब्याज प्रतिशत";
            lbl_InterestInPer.Font = new Font("Arial", sizetext);
            lbl_InterestPaid.Text = "ब्याज दिया";
            lbl_InterestPaid.Font = new Font("Arial", sizetext);
            lbl_KhatawaniNo.Text = "खतावणी नं.";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_LoanAmount.Font = new Font("Arial", sizetext);
            lbl_Name.Text = "नाम";
            lbl_Name.Font = new Font("Arial", sizetext);
            lbl_PayAmount.Text = "देनेकी रक्कम";
            lbl_PayAmount.Font = new Font("Arial", sizetext);

            lbl_Percent.Font = new Font("Arial", sizetext);
            lbl_ReceiptNo.Text = "पावती नं.";
            lbl_ReceiptNo.Font = new Font("Arial", sizetext);
            lbl_Srno.Text = "अनुक्रमांक";
            lbl_Srno.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = "पुरी रक्कम";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_narration.Text = "अतिरिक्त माहिती ";
            lbl_narration.Font = new Font("Arial", sizetext);


            dgv_ItemDetail.Columns["GirviNoItem"].HeaderText = "गिरवी नं.";
            dgv_ItemDetail.Columns["MetalType"].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns["ItemType1"].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns["GrossWt"].HeaderText = "ग्रॉस वजन";
            dgv_ItemDetail.Columns["ReduceWt"].HeaderText = "घट वजन";
            dgv_ItemDetail.Columns["FinalWt"].HeaderText = "नेट वजन";
            dgv_ItemDetail.Columns["WtInPercent"].HeaderText = "वजन प्रतिशत";
            dgv_ItemDetail.Columns["FineWt"].HeaderText = "फाईन वजन";
            dgv_ItemDetail.Columns["Quantity"].HeaderText = "प्रमाण";
            dgv_ItemDetail.Columns["CurrentPrice"].HeaderText = "चालू दर";
            dgv_ItemDetail.Columns["TotalAmount"].HeaderText = "रक्कम";


            dgv_GirviRelease.Columns["GirviNo"].HeaderText = "गिरवी नं.";
            dgv_GirviRelease.Columns["ReleaseDate"].HeaderText = "छुडानेकी तारीख";
            dgv_GirviRelease.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["DateOfDepositRelease"].HeaderText = "रखनेकी तारीख";
            dgv_GirviRelease.Columns["InterestRateRelease"].HeaderText = "ब्याज दर";
            dgv_GirviRelease.Columns["DurationRelease"].HeaderText = "कालावधी";
            dgv_GirviRelease.Columns["StatusRelease"].HeaderText = "स्थिती";

            dgv_GirviUnrelease.Columns["RecieptNo"].HeaderText = "पावती नं.";
            dgv_GirviUnrelease.Columns["LoanAmount"].HeaderText = "कर्ज रक्कम";
            dgv_GirviUnrelease.Columns["DateOfDeposit"].HeaderText = "रखनेकी तारीख";
            dgv_GirviUnrelease.Columns["InterestRate"].HeaderText = "ब्याज दर";
            dgv_GirviUnrelease.Columns["Status"].HeaderText = "स्थिती";
            dgv_GirviUnrelease.Columns["Duration"].HeaderText = "कालावधी";
            dgv_GirviUnrelease.Columns["Forward"].HeaderText = "फोरवर्ड";
            dgv_GirviUnrelease.Columns["ForwardedTo"].HeaderText = "फोरवर्ड To";



        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_CustomerInfo.Text = "ग्राहकाची माहीती ";
            lbl_Date.Text = "तारीख";
            this.Text = "गाहाणी सोडवा ";
            bttn_Release.Text = "रीलीस";
            bttn_UnRelease.Text = "अनरीलीस";
            bttn_ReleaseWith.Text = "रीलीस वीथ";
            bttn_Reset.Text = "रीसेट";
            bttn_Close.Text = "बंद";

            lbl_Date.Text = "तारीख";
            lbl_Date.Font = new Font("Arial", sizetext);
            lbl_DateOfDeposit.Text = "ठेव तारीख";
            lbl_DateOfDeposit.Font = new Font("Arial", sizetext);
            lbl_DateOfRelease.Text = "सोडवण्याची तारीख";
            lbl_DateOfRelease.Font = new Font("Arial", sizetext);
            lbl_DepositDays.Text = "एकून दिवस";
            lbl_DepositDays.Font = new Font("Arial", sizetext);
            lbl_GirviReceiptNo.Text = "गिरवी पावती नं.";
            lbl_GirviReceiptNo.Font = new Font("Arial", sizetext);
            lbl_InterestAmount.Text = "व्याज रक्कम";
            lbl_InterestAmount.Font = new Font("Arial", sizetext);
            lbl_InterestInPer.Text = "व्याज टक्के";
            lbl_InterestInPer.Font = new Font("Arial", sizetext);
            lbl_InterestPaid.Text = "व्याज दिले";
            lbl_InterestPaid.Font = new Font("Arial", sizetext);
            lbl_KhatawaniNo.Text = "खतावणी नं.";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_LoanAmount.Font = new Font("Arial", sizetext);
            lbl_Name.Text = "नाव";
            lbl_Name.Font = new Font("Arial", sizetext);
            lbl_PayAmount.Text = "देण्याची रक्कम";
            lbl_PayAmount.Font = new Font("Arial", sizetext);

            lbl_Percent.Font = new Font("Arial", sizetext);
            lbl_ReceiptNo.Text = "पावती नं.";
            lbl_ReceiptNo.Font = new Font("Arial", sizetext);
            lbl_Srno.Text = "अनुक्रमांक";
            lbl_Srno.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = "एकून रक्कम";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);

            dgv_ItemDetail.Columns["GirviNoItem"].HeaderText = "गिरवी नं.";
            dgv_ItemDetail.Columns["MetalType"].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns["ItemType1"].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns["GrossWt"].HeaderText = "ग्रॉस वजन";
            dgv_ItemDetail.Columns["ReduceWt"].HeaderText = "घट वजन";
            dgv_ItemDetail.Columns["FinalWt"].HeaderText = "नेट वजन";
            dgv_ItemDetail.Columns["WtInPercent"].HeaderText = "वजन टक्के";
            dgv_ItemDetail.Columns["FineWt"].HeaderText = "फाईन वजन";
            dgv_ItemDetail.Columns["Quantity"].HeaderText = "प्रमाण";
            dgv_ItemDetail.Columns["CurrentPrice"].HeaderText = "चालू दर";
            dgv_ItemDetail.Columns["TotalAmount"].HeaderText = "रक्कम";


            dgv_GirviRelease.Columns["GirviNo"].HeaderText = "गिरवी नं.";
            dgv_GirviRelease.Columns["ReleaseDate"].HeaderText = "सोडवण्याची तारीख";
            dgv_GirviRelease.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviRelease.Columns["DateOfDepositRelease"].HeaderText = "ठेव तारीख";
            dgv_GirviRelease.Columns["InterestRateRelease"].HeaderText = "व्याज दर";
            dgv_GirviRelease.Columns["DurationRelease"].HeaderText = "कालावधी";
            dgv_GirviRelease.Columns["StatusRelease"].HeaderText = "स्थिती";

            dgv_GirviUnrelease.Columns["RecieptNo"].HeaderText = "पावती नं.";
            dgv_GirviUnrelease.Columns["LoanAmount"].HeaderText = "कर्ज रक्कम";
            dgv_GirviUnrelease.Columns["DateOfDeposit"].HeaderText = "ठेव तारीख";
            dgv_GirviUnrelease.Columns["InterestRate"].HeaderText = "व्याज दर";
            dgv_GirviUnrelease.Columns["Status"].HeaderText = "स्थिती";
            dgv_GirviUnrelease.Columns["Duration"].HeaderText = "कालावधी";
            dgv_GirviUnrelease.Columns["Forward"].HeaderText = "फोरवर्ड";
            dgv_GirviUnrelease.Columns["ForwardedTo"].HeaderText = "फोरवर्ड To";
        }

        private void dgv_GirviUnrelease_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_InterestAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_TotalAmount.Text = (Convert.ToDouble(txt_InterestAmount.Text) + Convert.ToDouble(txt_Loanamount.Text)).ToString();
            }
            catch { }
        }

        private void rbt_English_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_InvoiceNo_Enter_1(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void bttn_Reset_Click_1(object sender, EventArgs e)
        {

        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_InvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SearchGirvibyInvoiceNo();

            }

        }

        private void lst_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
                cmb_Name.Text = lst_FullName.SelectedValue.ToString();
                cmb_Name.Focus();

                fillTextBox();

                lst_FullName.Visible = false;

            }


        }

        private void cmb_Name_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Name.Text != "")
            {

                lst_FullName.DataSource = _objGirviAdd.getFName(cmb_Name.Text);
                if (lst_FullName.Items.Count > 0)
                {
                    lst_FullName.Visible = true;
                }
                lst_FullName.DisplayMember = "FullName";
                lst_FullName.ValueMember = "FullName";
            }


        }

        private void txt_TotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_InterestPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_TotalAmount.Text = ((Convert.ToDouble(txt_Loanamount.Text) + Convert.ToDouble(txt_InterestAmount.Text)) - Convert.ToDouble(txt_InterestPaid.Text)).ToString();
            }
            catch { 
            }
                  }

        private void txt_ReceiptNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Release.Focus();
            }
        }

        private void rbt_PrintTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbt_no1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
