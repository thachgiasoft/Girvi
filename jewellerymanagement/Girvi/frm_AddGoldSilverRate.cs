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
using System.Drawing.Text;

namespace JewelleryManagement.Girvi
{
    public partial class frm_AddGoldSilverRate : Form
    {
        public frm_AddGoldSilverRate()
        {
            InitializeComponent();
        }
        Simplevalidations _objSimplevalidations = new Simplevalidations();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();

        private void frm_AddGoldSilverRate_Load(object sender, EventArgs e)
        {
            SetFont();
            DataTable dtnew = _objGirviCommon.load();
            txt_CurrentGoldRate.Text = dtnew.Rows[0][0].ToString();
            txt_CurrentSilverRate.Text = dtnew.Rows[0][1].ToString();
            txt_Interest.Text = dtnew.Rows[0][3].ToString();
           
           
        }
        public void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
          //  dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_CurrentGoldRate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_CurrentSilverRate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_Interest.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_ContactNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //cmb_Cast.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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
            //dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            // System.ComponentModel.TypeConverter converter = 
        }

        private void SetFont()
        {
            //ShivajiFont();
        }

       

       

        private void txt_CurrentGoldRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CurrentSilverRate.Focus();
            }
        }

        private void txt_CurrentsilverRate_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_Interest.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_CurrentGoldRate.Focus();
            }
        }

        private void txt_Interest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Save.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_CurrentSilverRate.Focus();
            }
        }

        private void txt_CurrentGoldRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_CurrentGoldRate.Text);
        }

        private void txt_CurrentsilverRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e,txt_CurrentSilverRate.Text);
        }

        private void txt_Interest_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e,txt_Interest.Text);
        }

        private void frm_AddGoldSilverRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Save_Leave(object sender, EventArgs e)
        {
            txt_CurrentGoldRate.Focus();
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            this.Text = "सोना /चांदी रेट सेट किजीये ";
            lbl_CurrentGoldRate.Text = "चालू सोनेका दर";
            lbl_CurrentGoldRate.Font = new Font("Arial", sizetext);
            lbl_CurrentSilverRate.Text = "चालू चांदीका दर";
            lbl_CurrentSilverRate.Font = new Font("Arial", sizetext);
            lbl_Interest.Text = "ब्याज";
            lbl_Interest.Font = new Font("Arial", sizetext);
            bttn_Reset.Text = "रिसेट";
            bttn_Close.Text = "बंद";
            lbl_Date.Text = "तारीख";
            bttn_Save.Text = "सेव्ह";
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            this.Text = "सोना /चांदी रेट सेट करा";
            lbl_CurrentGoldRate.Text = "चालू सोण्याचा दर";
            lbl_CurrentGoldRate.Font = new Font("Arial", sizetext);
            lbl_CurrentSilverRate.Text = "चालू चांदीचा दर";
            lbl_CurrentSilverRate.Font = new Font("Arial", sizetext);
            lbl_Interest.Text = "व्याज";
            lbl_Interest.Font = new Font("Arial", sizetext);
            bttn_Reset.Text = "रिसेट";
            bttn_Close.Text = "बंद";
            lbl_Date.Text = "तारीख";
            bttn_Save.Text = "सेव्ह";
        }


        #region language

        private void txt_CurrentGoldRate_Enter(object sender, EventArgs e)
        {

        }

        private void txt_CurrentSilverRate_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Interest_Enter(object sender, EventArgs e)
        {

        }
        #endregion Language

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            if (_objGirviCommon.update(txt_CurrentGoldRate.Text, txt_CurrentSilverRate.Text, txt_Interest.Text))
            {
                MessageBox.Show("Rate Updated");
                bttn_Reset_Click(this, new EventArgs());
            }
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            txt_CurrentGoldRate.ResetText();
            txt_CurrentSilverRate.ResetText();
            txt_Interest.ResetText();
            DataTable dtnew = _objGirviCommon.load();
            txt_CurrentGoldRate.Text = dtnew.Rows[0][0].ToString();
            txt_CurrentSilverRate.Text = dtnew.Rows[0][1].ToString();
            txt_Interest.Text = dtnew.Rows[0][3].ToString();
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            this.Text = "सोना /चांदी रेट सेट करा";
            lbl_CurrentGoldRate.Text = "चालू सोण्याचा दर";
            lbl_CurrentGoldRate.Font = new Font("Arial", sizetext);
            lbl_CurrentSilverRate.Text = "चालू चांदीचा दर";
            lbl_CurrentSilverRate.Font = new Font("Arial", sizetext);
            lbl_Interest.Text = "व्याज";
            lbl_Interest.Font = new Font("Arial", sizetext);
            bttn_Reset.Text = "रिसेट";
            bttn_Close.Text = "बंद";
            lbl_Date.Text = "तारीख";
            bttn_Save.Text = "सेव्ह";
        }

        private void txt_Interest_Enter_1(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

      




    }
}
