using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BAL.Common;
using BAL.Girvi;
using System.Drawing.Text;
namespace JewelleryManagement.Girvi
{
    public partial class frm_DeleteGirvi : Form
    {
        public frm_DeleteGirvi()
        {
            InitializeComponent();
        }
        Simplevalidations _objSimplevalidations = new Simplevalidations();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        DataTable dt;
        private void frm_DeleteGirvi_Load(object sender, EventArgs e)
        {

            SetFont();
            cmb_FullName.Select();
            MasterClear();
            //try
            //{
            //fillComboBox();
            fillgrid();

            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show(ex.Message);
            //}

            AutoCompleteStringCollection InvoiceNo = new AutoCompleteStringCollection();
            foreach (DataRow dtrow in _objGirviAdd.getGirviMasterDetails().Rows)
                InvoiceNo.Add(dtrow["GirviRecordNo"].ToString());
            txt_InvoiceNo.AutoCompleteCustomSource = InvoiceNo;


            AutoCompleteStringCollection ReceiptNo = new AutoCompleteStringCollection();
            foreach (DataRow dtrow in _objGirviAdd.getGirviMasterDetails().Rows)
                ReceiptNo.Add(dtrow["receipt_no"].ToString());
            txt_ReceiptNo.AutoCompleteCustomSource = ReceiptNo;
        }

        private void SetFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                ShivajiFont();
            }
        }
        public void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
            //dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_KhatawaniNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_FullName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_Address.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_ContactNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_Occupation.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_Caste.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            // dtp_DateOfDeposit.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            // dtp_Duration.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_LoanAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_InterestRate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_ActualInterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_LoanType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_LoanReason.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_status.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //  dtp_ReleaseDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_ForwordNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_NameOfForword.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_ForwordDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_forwardamount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_FinalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_InterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_EstimateInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_LoanAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_DateOfDeposit.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_Duration.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            // System.ComponentModel.TypeConverter converter = 
            lst_FullName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
        }


        private void fillComboBox()
        {
            //cmb_FullName.DataSource = _objGirviAdd.getFName();
        }

        private void fillgrid()
        {
            dgv_GirviDetails.Rows.Clear();
            dt = _objGirviCommon.getGirviMasterData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_GirviDetails.Rows.Add(dt.Rows[i]["khatawani_No"].ToString(), dt.Rows[i]["FullName"].ToString(), dt.Rows[i]["Contact_No"].ToString(), dt.Rows[i]["GirviRecordNo"].ToString(), dt.Rows[i]["Amount"].ToString(), dt.Rows[i]["Date_of_deposit"].ToString(), (Convert.ToDouble(dt.Rows[i]["interset_rate"].ToString()) * 12).ToString(), dt.Rows[i]["Status"].ToString(), dt.Rows[i]["withdraw_release_date"].ToString());
            }
        }

        private void MasterClear()
        {
            Clear();
            DesignGridView();
        }

        private void Clear()
        {
            cmb_KhatawaniNo.ResetText();
            cmb_FullName.ResetText();
            cmb_Address.ResetText();
            txt_ContactNo.ResetText();
            cmb_Caste.ResetText();
            txt_ReceiptNo.ResetText();
            txt_LoanAmount.ResetText();
            txt_InterestRate.ResetText();
            txt_ActualInterestInPer.ResetText();
            cmb_LoanType.ResetText();
            cmb_LoanReason.ResetText();
            txt_status.ResetText();
            txt_ForwordNo.ResetText();
            txt_NameOfForword.ResetText();
            txt_forwardamount.ResetText();
            txt_Post.ResetText();
        }

        private void DesignGridView()
        {
            dgv_GirviDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 132, 153);
            dgv_GirviDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_GirviDetails.EnableHeadersVisualStyles = false;
            dgv_GirviDetails.RowsDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Regular);
            dgv_GirviDetails.RowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgv_GirviDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(70, 132, 153);
            dgv_GirviDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_GirviDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

                SearchData(cmb_FullName.Text);
                cmb_Address.Focus();
                lst_FullName.Visible = false;

            }
            //if (e.KeyCode == Keys.Enter)
            //{
            //    cmb_Address.Focus();
            //    SearchData(cmb_FullName.Text);

            //}
            //if (e.KeyCode == Keys.Left && e.Alt)
            //{
            //    cmb_KhatawaniNo.Focus();
            //}
        }

        private void SearchData(string name)
        {
            DataTable dt2 = null;


            dt2 = _objGirviAdd.getKhatawaniByName(name);


            if (dt2.Rows.Count > 0)
            {
                DataTable dt = _objGirviAdd.getGirviDataByKhatawanoNo(dt2.Rows[0]["khatawani_No"].ToString());
                dgv_GirviDetails.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_GirviDetails.Rows.Add(dt.Rows[i]["khatawani_No"].ToString(), dt.Rows[i]["FullName"].ToString(), dt.Rows[i]["Contact_No"].ToString(), dt.Rows[i]["GirviRecordNo"].ToString(), dt.Rows[i]["Amount"].ToString(), dt.Rows[i]["Date_of_deposit"].ToString(), dt.Rows[i]["interset_rate"].ToString(), dt.Rows[i]["Status"].ToString(), dt.Rows[i]["withdraw_release_date"].ToString(), dt.Rows[i]["narration"].ToString());
                }
            }
            ClearPrivousData();
        }

        private void ClearPrivousData()
        {
            cmb_KhatawaniNo.ResetText();
            cmb_Address.ResetText();
            txt_ContactNo.ResetText();
            cmb_Caste.ResetText();
            txt_ReceiptNo.ResetText();
            txt_LoanAmount.ResetText();
            txt_InterestRate.ResetText();
            txt_ActualInterestInPer.ResetText();
            cmb_LoanType.ResetText();
            cmb_LoanReason.ResetText();
            txt_status.ResetText();
            txt_ForwordNo.ResetText();
            txt_NameOfForword.ResetText();
            txt_forwardamount.ResetText();
        }

        private void cmb_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ContactNo.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                cmb_FullName.Focus();
            }
        }

        private void txt_ContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Occupation.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                cmb_Address.Focus();
            }
        }



        private void cmb_Caste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_DateOfDeposit.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_Occupation.Focus();
            }
        }

        private void dtp_DateOfDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_Duration.Focus();

            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                cmb_Caste.Focus();
            }
        }

        private void dtp_Duration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_LoanAmount.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                dtp_DateOfDeposit.Focus();
            }
        }

        private void txt_LoanAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_InterestRate.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                dtp_Duration.Focus();
            }
        }

        private void txt_InterestRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ActualInterestInPer.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_LoanAmount.Focus();
            }
        }

        private void txt_ActualInterestInPer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_LoanType.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_InterestRate.Focus();
            }
        }

        private void cmb_LoanType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_LoanReason.Focus();

            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_ActualInterestInPer.Focus();
            }
        }

        private void cmb_LoanReason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_status.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                cmb_LoanType.Focus();
            }
        }

        private void txt_status_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_ReleaseDate.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                cmb_LoanReason.Focus();
            }
        }

        private void dtp_ReleaseDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Delete.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_status.Focus();
            }
        }

        private void cmb_FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);

        }

        private void cmb_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharDigitOnly(e);
        }

        private void txt_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void cmb_Caste_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void txt_InvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharDigitOnly(e);
        }

        private void txt_ReceiptNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //_objSimplevalidations.ValidationDigitOnly(e);
        }

        private void txt_LoanAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void txt_InterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_InterestRate.Text);
        }

        private void txt_ActualInterestInPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_ActualInterestInPer.Text);
        }

        private void cmb_LoanType_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void cmb_LoanReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void txt_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void txt_ForwordNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void txt_NameOfForword_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void txt_forwardamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void frm_DeleteGirvi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Delete_Leave(object sender, EventArgs e)
        {
            cmb_FullName.Focus();
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "डिलीट/अपडेट गाहाणी ";
            grp_CustomerInfo.Text = "ग्राहकाची माहीती ";
            grp_GirviDetail.Text = "गाहणी माहीती";
            grp_ForwordDetail.Text = "फोरवर्ड माहीती";



            lbl_Date.Text = "तारीख";
            bttn_Delete.Text = "डिलीट";
            bttn_Close.Text = "बंद";
            lbl_KhatawaniNo.Text = "खतावणी क्रं";
            lbl_FullName.Text = "नाव";
            lbl_ContactNo.Text = "संपर्क क्रं";
            lbl_Address.Text = "पत्ता";
            lbl_InvoiceNo.Text = "गाहनी क्रं";
            lbl_DateOfDeposite.Text = "ठेव तारीख";
            lbl_LoanAmount.Text = "कर्जाची रक्कम";
            lbl_InterestRate.Text = "व्याज दर";
            lbl_Occupation.Text = "व्यवसाय";
            lbl_Caste.Text = "जात";
            lbl_ReceiptNo.Text = "पावती नं.";

            lbl_Duration.Text = "कालावधी";
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_InterestRate.Text = "कर्ज दर";
            lbl_ActualInterestInPer.Text = "व्याज टक्के";
            lbl_loanType.Text = "कर्ज प्रकार";
            lbl_LoanReason.Text = "कर्जाचे कारण";
            lbl_Status.Text = "स्थिती";
            lbl_ReleaseDate.Text = "सोडवण्याची तारीख";
            lbl_ForwordNo.Text = "फॉरवर्ड To";
            lbl_ForwordDate.Text = "फॉरवर्ड तारीख";
            lbl_forwardamount.Text = "फॉरवर्ड रक्कम";
           
            bttn_Update.Text = "अपडेट";
            lbl_Post.Text = " पोस्ट";

            dgv_GirviDetails.Columns["KhatawaniNo"].HeaderText = "खतावणी क्रं.";
            dgv_GirviDetails.Columns["InvoiceNo"].HeaderText = "गाहनी क्रं.";
            dgv_GirviDetails.Columns["Name"].HeaderText = "नाव";
            dgv_GirviDetails.Columns["ContactNo"].HeaderText = "दूरध्वनी नं";
            dgv_GirviDetails.Columns["Amount"].HeaderText = "गिरवी रक्कम";
            dgv_GirviDetails.Columns["DepositeDate"].HeaderText = "ठेवल्याची तारीख";
            dgv_GirviDetails.Columns["Interestrate"].HeaderText = "व्याज दर";
            dgv_GirviDetails.Columns["Status"].HeaderText = "स्थिती";
            dgv_GirviDetails.Columns["ReleaseDate"].HeaderText = "सोडवल्याची तारीख";
             
            dgv_GirviDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);

        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "डिलीट/अपडेट गिरवी ";
            grp_CustomerInfo.Text = "ग्राहकाची माहीती ";
            grp_GirviDetail.Text = "गाहणी माहीती";
            grp_ForwordDetail.Text = "फोरवर्ड माहीती";
            lbl_Date.Text = "तारीख";
            bttn_Delete.Text = "डिलीट";
            bttn_Close.Text = "बंद";
            lbl_KhatawaniNo.Text = "खतावणी क्रं";
            lbl_FullName.Text = "नाम";
            lbl_ContactNo.Text = "संपर्क क्रं";
            lbl_Address.Text = "पत्ता";
            lbl_InvoiceNo.Text = "गिरवी क्रं";
            lbl_DateOfDeposite.Text = "रखनेकी तारीख";
            lbl_LoanAmount.Text = "कर्जकी रक्कम";
            lbl_InterestRate.Text = "ब्याज दर";
            lbl_Occupation.Text = "व्यवसाय";
            lbl_Caste.Text = "जात";
            lbl_ReceiptNo.Text = "पावती नं.";
            lbl_Duration.Text = "कालावधी";
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_InterestRate.Text = "कर्ज दर";
            lbl_ActualInterestInPer.Text = "ब्याज प्रतिशत";
            lbl_loanType.Text = "कर्ज प्रकार";
            lbl_LoanReason.Text = "कर्जका कारण";
            lbl_Status.Text = "स्थिती";
            lbl_ReleaseDate.Text = "छुडानेकी तारीख";
            lbl_ForwordNo.Text = "फॉरवर्ड To";
            lbl_ForwordDate.Text = "फॉरवर्ड तारीख";
            lbl_forwardamount.Text = "फॉरवर्ड रक्कम";
           
            bttn_Update.Text = "अपडेट";
            lbl_Post.Text = " पोस्ट";
            dgv_GirviDetails.Columns["KhatawaniNo"].HeaderText = "खतावणी क्रं.";
            dgv_GirviDetails.Columns["InvoiceNo"].HeaderText = "गिरवी क्रं.";
            dgv_GirviDetails.Columns["Name"].HeaderText = "नाम";
            dgv_GirviDetails.Columns["ContactNo"].HeaderText = "संपर्क क्रं.";
            dgv_GirviDetails.Columns["Amount"].HeaderText = "गिरवी रक्कम";
            dgv_GirviDetails.Columns["DepositeDate"].HeaderText = "रखनेकी तारीख";
            dgv_GirviDetails.Columns["Interestrate"].HeaderText = "ब्याज दर";
            dgv_GirviDetails.Columns["Status"].HeaderText = "स्थिती";
            dgv_GirviDetails.Columns["ReleaseDate"].HeaderText = "छुडानेकी तारीख";
            dgv_GirviDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
        }

        #region Language

        private void txt_KhatavaniNo_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void cmb_FullName_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void cmb_Address_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ContactNo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_InvoiceNo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ReceiptNo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_LoanAmount_Enter(object sender, EventArgs e)
        {

        }

        private void txt_InterestRate_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ActualInterestInPer_Enter(object sender, EventArgs e)
        {

        }

        private void txt_status_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void txt_ForwordNo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_NameOfForword_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void txt_forwardamount_Enter(object sender, EventArgs e)
        {

        }
        #endregion Language

        private void dgv_GirviDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = dgv_GirviDetails.CurrentCell.RowIndex;

            DataTable dt = _objGirviCommon.getKhtawaniDetails(dgv_GirviDetails.Rows[ind].Cells["KhatawaniNo"].Value.ToString());
            if (dt.Rows.Count > 0)
            {
                cmb_KhatawaniNo.Text = dt.Rows[0]["khatawani_No"].ToString();
                cmb_FullName.Text = dt.Rows[0]["FullName"].ToString();
                cmb_Address.Text = dt.Rows[0]["Address"].ToString();
                txt_ContactNo.Text = dt.Rows[0]["Contact_No"].ToString();
                cmb_Caste.Text = dt.Rows[0]["cast"].ToString();
                txt_Occupation.Text = dt.Rows[0]["occupation"].ToString();
                txt_Post.Text = dt.Rows[0]["Address2"].ToString();
               // txt_naration.Text = dt.Rows[0][" narration"].ToString();
            }


            string srrr = dgv_GirviDetails.Rows[ind].Cells["InvoiceNo"].Value.ToString();
            DataTable dt1 = _objGirviCommon.getGirviDetails(srrr);
            if (dt1.Rows.Count > 0)
            {
                txt_InvoiceNo.Text = dt1.Rows[0]["GirviRecordNo"].ToString();
                dtp_DateOfDeposit.Text = dt1.Rows[0]["Date_of_deposit"].ToString();
                txt_LoanAmount.Text = dt1.Rows[0]["Amount"].ToString();
                txt_InterestRate.Text = (Convert.ToDouble(dt1.Rows[0]["interset_rate"]) * 12).ToString();
                txt_ReceiptNo.Text = dt1.Rows[0]["receipt_no"].ToString();
                txt_ActualInterestInPer.Text = dt1.Rows[0]["Actual_InterestRate"].ToString();
                dtp_Duration.Text = dt1.Rows[0]["duration"].ToString();
                dtp_ReleaseDate.Text = dt1.Rows[0]["withdraw_release_date"].ToString();
                cmb_LoanReason.Text = dt1.Rows[0]["reason"].ToString();
                cmb_LoanType.Text = dt1.Rows[0]["loantype"].ToString();
                txt_status.Text = dt1.Rows[0]["Status"].ToString();
                txt_vadhiv.Text = dt1.Rows[0]["vadhiv"].ToString().Replace(",","\r\n")+"\r\n";
                txt_ForwordNo.Text = dt1.Rows[0]["Forwarded_to"].ToString();
                txt_NameOfForword.Text = dt1.Rows[0]["ForwardCno"].ToString();
                txt_forwardamount.Text = dt1.Rows[0]["forwardamount"].ToString();
                dtp_ForwordDate.Text = dt1.Rows[0]["Date_of_Forward"].ToString();
                txt_naration.Text = dt1.Rows[0]["narration"].ToString();

            }

        }

        private void txt_Occupation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Caste.Focus();

            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_ContactNo.Focus();
            }

        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dgv_GirviDetails.CurrentCell.RowIndex;
                _objGirviCommon.deletefromGirviItemmaster(dgv_GirviDetails.Rows[ind].Cells["InvoiceNo"].Value.ToString());
                _objGirviCommon.deletefromGirviMaster(dgv_GirviDetails.Rows[ind].Cells["InvoiceNo"].Value.ToString());
                _objGirviCommon.deletefromGirviNo(dgv_GirviDetails.Rows[ind].Cells["InvoiceNo"].Value.ToString());
                _objGirviCommon.deletefromGirviReleaseMaster(dgv_GirviDetails.Rows[ind].Cells["InvoiceNo"].Value.ToString());
                MessageBox.Show("Girvi Deleted");
                dgv_GirviDetails.Rows.Clear();
                fillgrid();
                resetvalues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetvalues()
        {
            txt_ReceiptNo.Text = "";
            cmb_KhatawaniNo.Text = "";
            cmb_FullName.Text = "";
            cmb_Address.Text = "";
            txt_InvoiceNo.Text = "";
            txt_LoanAmount.Text = "";
            dtp_DateOfDeposit.Text = "";
            txt_ContactNo.ResetText();
            cmb_Caste.Text = "";
            txt_Occupation.Text = "";
            txt_InterestRate.Text = "";
            txt_ActualInterestInPer.Text = "";
            cmb_LoanReason.Text = "";
            cmb_LoanType.ResetText();
            txt_status.ResetText();
            dtp_ReleaseDate.ResetText();
            txt_ForwordNo.ResetText();
            txt_NameOfForword.ResetText();
            txt_forwardamount.ResetText();
            txt_naration.ResetText();
            dtp_ForwordDate.ResetText();
            dtp_Duration.ResetText();
            txt_Post.ResetText();
            txt_vadhiv.ResetText();
            fillgrid();
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            double interest = Convert.ToDouble(txt_InterestRate.Text) / 12;
            if (txt_status.Text == "unchange")
            {
                dtp_ReleaseDate.Text = "";
            }

            if (txt_forwardamount.Text == "" || txt_NameOfForword.Text == "")
            {
                _objGirviCommon.updateRecord(cmb_KhatawaniNo.Text, cmb_FullName.Text, cmb_Address.Text, txt_ContactNo.Text, cmb_Caste.Text, txt_Occupation.Text, txt_InvoiceNo.Text, txt_LoanAmount.Text, dtp_DateOfDeposit.Text, dtp_Duration.Text, interest.ToString(), dtp_ReleaseDate.Text, "", "", "", "", txt_ActualInterestInPer.Text, cmb_LoanReason.Text, cmb_LoanType.Text, txt_ReceiptNo.Text, txt_Post.Text, txt_naration.Text,txt_vadhiv.Text.Replace("\r\n",","));
            }
            else
            {
                _objGirviCommon.updateRecord(cmb_KhatawaniNo.Text, cmb_FullName.Text, cmb_Address.Text, txt_ContactNo.Text, cmb_Caste.Text, txt_Occupation.Text, txt_InvoiceNo.Text, txt_LoanAmount.Text, dtp_DateOfDeposit.Text, dtp_Duration.Text, interest.ToString(), dtp_ReleaseDate.Text, txt_NameOfForword.Text, dtp_ForwordDate.Text, txt_forwardamount.Text, txt_ForwordNo.Text, txt_ActualInterestInPer.Text, cmb_LoanReason.Text, cmb_LoanType.Text, txt_ReceiptNo.Text, txt_Post.Text, txt_naration.Text, txt_vadhiv.Text.Replace("\r\n", ","));
            }

            MessageBox.Show("Girvi Updated");
            resetvalues();
            fillgrid();
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {

            lbl_Date.Text = "तारीख";
            grp_CustomerInfo.Text = "ग्राहकाची माहीती ";
            grp_GirviDetail.Text = "गाहणी माहीती";
            grp_ForwordDetail.Text = "फोरवर्ड माहीती";
            this.Text = "डिलीट/अपडेट गाहाणी ";
            bttn_Delete.Text = "डिलीट";
            bttn_Close.Text = "बंद";
            lbl_KhatawaniNo.Text = "खतावणी क्रं";
            lbl_FullName.Text = "नाव";
            lbl_ContactNo.Text = "संपर्क क्रं";
            lbl_Address.Text = "पत्ता";
            lbl_InvoiceNo.Text = "गाहनी क्रं";
            lbl_DateOfDeposite.Text = "ठेव तारीख";
            lbl_LoanAmount.Text = "कर्जाची रक्कम";
            lbl_InterestRate.Text = "व्याज दर";
            lbl_Occupation.Text = "व्यवसाय";
            lbl_Caste.Text = "जात";
            lbl_ReceiptNo.Text = "पावती नं.";

            lbl_Duration.Text = "कालावधी";
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_InterestRate.Text = "कर्ज दर";
            lbl_ActualInterestInPer.Text = "व्याज टक्के";
            lbl_loanType.Text = "कर्ज प्रकार";
            lbl_LoanReason.Text = "कर्जाचे कारण";
            lbl_Status.Text = "स्थिती";
            lbl_ReleaseDate.Text = "सोडवण्याची तारीख";
            lbl_ForwordNo.Text = "फॉरवर्ड To";
            lbl_ForwordDate.Text = "फॉरवर्ड तारीख";
            lbl_forwardamount.Text = "फॉरवर्ड रक्कम";
            bttn_Update.Text = "अपडेट";
            lbl_Post.Text = " पोस्ट";

            dgv_GirviDetails.Columns["KhatawaniNo"].HeaderText = "खतावणी क्रं.";
            dgv_GirviDetails.Columns["InvoiceNo"].HeaderText = "गाहनी क्रं.";
            dgv_GirviDetails.Columns["Name"].HeaderText = "नाव";
            dgv_GirviDetails.Columns["ContactNo"].HeaderText = "दूरध्वनी नं";
            dgv_GirviDetails.Columns["Amount"].HeaderText = "गिरवी रक्कम";
            dgv_GirviDetails.Columns["DepositeDate"].HeaderText = "ठेवल्याची तारीख";
            dgv_GirviDetails.Columns["Interestrate"].HeaderText = "व्याज दर";
            dgv_GirviDetails.Columns["Status"].HeaderText = "स्थिती";
            dgv_GirviDetails.Columns["ReleaseDate"].HeaderText = "सोडवल्याची तारीख";

            dgv_GirviDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 13, FontStyle.Bold);
        }
        int currentMouseOverRow;

        private void dgv_GirviDetails_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Update Items"));
                m.MenuItems[0].Click += new System.EventHandler(this.menuItem1_Click);
                currentMouseOverRow = dgv_GirviDetails.HitTest(e.X, e.Y).RowIndex;



                m.Show(dgv_GirviDetails, new Point(e.X, e.Y));

            }

        }
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            try
            {
                string girvi_no = Convert.ToString(dgv_GirviDetails.Rows[currentMouseOverRow].Cells[0].Value);
                frm_UpdatedGirviItem _objUpdatedGirviItem = new frm_UpdatedGirviItem(dgv_GirviDetails.Rows[currentMouseOverRow].Cells["InvoiceNo"].Value.ToString());


                if (rbt_English.Checked == true)
                {
                    _objUpdatedGirviItem.rbt_English.Checked = true;
                }
                else if (rbt_OtherTrue.Checked == true)
                {
                    _objUpdatedGirviItem.rbt_OtherTrue.Checked = true;
                }

                else if (rbt_Hindi.Checked == true)
                {
                    _objUpdatedGirviItem.rbt_Hindi.Checked = true;
                }
                else if (rbt_Marathi.Checked == true)
                {
                    _objUpdatedGirviItem.rbt_Marathi.Checked = true;
                }




                _objUpdatedGirviItem.ShowDialog();


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("No Girvi Number Found");
            }



        }


        private void dtp_Duration_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void dtp_ForwordDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void dtp_ForwordDate_Enter_1(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void lst_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_FullName.Text = lst_FullName.SelectedValue.ToString();
                cmb_FullName.Focus();

                //fillComboBox();

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

        private void cmb_Address_Enter_1(object sender, EventArgs e)
        {

            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
        }

        private void cmb_Address_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ContactNo.Focus();
            }
        }

        private void cmb_Address_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharDigitOnly(e);
        }

        private void cmb_Address_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Address_Enter_2(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void cmb_Address_KeyPress_2(object sender, KeyPressEventArgs e)
        {
         //   _objSimplevalidations.ValidationCharDigitOnly(e);
        }

        private void cmb_Caste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_FullName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_InvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_InvoiceNo.Focus();
              
            }
            if (e.KeyCode == Keys.Enter)
            {
                SearchInvoiceNoData(txt_InvoiceNo.Text);
                txt_InvoiceNo.Focus();
              ////  txt_InvoiceNo.Visible = false;

            }
        }

        private void SearchInvoiceNoData(string InvoiceNo)
        {
            DataTable dt2 = null;


            dt2 = _objGirviAdd.getGirviByInvoiceNo(InvoiceNo);


            if (dt2.Rows.Count > 0)
            {
                DataTable dt = _objGirviAdd.getGirviDetailsByInvoiceNo(dt2.Rows[0]["GirviRecordNo"].ToString());
                dgv_GirviDetails.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_GirviDetails.Rows.Add(dt.Rows[i]["khatawani_No"].ToString(), dt.Rows[i]["FullName"].ToString(), dt.Rows[i]["Contact_No"].ToString(), dt.Rows[i]["GirviRecordNo"].ToString(), dt.Rows[i]["Amount"].ToString(), dt.Rows[i]["Date_of_deposit"].ToString(), dt.Rows[i]["interset_rate"].ToString(), dt.Rows[i]["Status"].ToString(), dt.Rows[i]["withdraw_release_date"].ToString());
                }
            }
            ClearPrivousData();
        }

        private void txt_ReceiptNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_ReceiptNo.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {
                SearchReceiptNo(txt_ReceiptNo.Text);
                txt_ReceiptNo.Focus();
                ////  txt_InvoiceNo.Visible = false;

            }
        }
        private void SearchReceiptNo(string ReceiptNo)
        {
            DataTable dt2 = null;


            dt2 = _objGirviAdd.getGirviByReceiptNo(ReceiptNo);


            if (dt2.Rows.Count > 0)
            {
                DataTable dt = _objGirviAdd.getGirviDetailsByReceiptNo(dt2.Rows[0]["receipt_no"].ToString());
                dgv_GirviDetails.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_GirviDetails.Rows.Add(dt.Rows[i]["khatawani_No"].ToString(), dt.Rows[i]["FullName"].ToString(), dt.Rows[i]["Contact_No"].ToString(), dt.Rows[i]["GirviRecordNo"].ToString(), dt.Rows[i]["Amount"].ToString(), dt.Rows[i]["Date_of_deposit"].ToString(), dt.Rows[i]["interset_rate"].ToString(), dt.Rows[i]["Status"].ToString(), dt.Rows[i]["withdraw_release_date"].ToString());
                }
            }
            ClearPrivousData();
        }

        private void cmb_FullName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_vadhiv_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
        }

       
    }
}
