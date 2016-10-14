using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BAL.Girvi;
using System.Drawing.Text;
namespace JewelleryManagement.Girvi
{
    public partial class frm_AddressMaster : Form
    {
        public frm_AddressMaster()
        {
            InitializeComponent();
        }
        Simplevalidations _Objsimplevalidation = new Simplevalidations();
        Validation _objValidation = new Validation();
        clsAddress _objAdress = new clsAddress();

        private void frm_AddressMaster_Load(object sender, EventArgs e)
        {
            SetFont();
            MasterClear();
            txt_Address.Select();
        }
        public void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
            // dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_Address.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_EndYear.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //cmb_City.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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

            ShivajiFont();

        }

        private void MasterClear()
        {
            fillgrid();
            txt_Address.Text = "";
            Clear();
        }

        private void Clear()
        {
            txt_Address.ResetText();
            //dgv_AddressMaster.Rows.Clear();
            txt_Address.Focus();
        }

        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_SaveAddress.Select();
            }
        }

        private void txt_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            //_Objsimplevalidation.ValidationCharOnly(e);

        }

        private void frm_AddressMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void lbl_CloseAddress_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = " पत्ता";
            lbl_Address.Text = "पत्ता";
            lbl_Date.Text = "तारीख";
            bttn_Delete.Text = "डिलीट";
            bttn_ResetItemDetail.Text = "रिसेट";
            bttn_Update.Text = "अपडेट";
            bttn_SaveAddress.Text = "सेव्ह";
            bttn_CloseAddress.Text = "बंद";

            dgv_AddressMaster.Columns["SrNo"].HeaderText = "क्रमांक";
            dgv_AddressMaster.Columns["Address"].HeaderText = "पत्ता";

        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = " पत्ता";
            lbl_Address.Text = "पत्ता";
            lbl_Date.Text = "तारीख";
            bttn_Delete.Text = "डिलीट";
            bttn_ResetItemDetail.Text = "रिसेट";
            bttn_Update.Text = "अपडेट";
            bttn_SaveAddress.Text = "सेव्ह";
            bttn_CloseAddress.Text = "बंद";

            dgv_AddressMaster.Columns["SrNo"].HeaderText = "क्रमांक";
            dgv_AddressMaster.Columns["Address"].HeaderText = "पत्ता";

        }



        private void txt_Address_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void bttn_SaveAddress_Click(object sender, EventArgs e)
        {
            if (txt_Address.Text != "")
            {
                DialogResult dr = MessageBox.Show("Do you want To Save", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    _objAdress.addAddress(txt_Address.Text);
                }
                fillgrid();
                txt_Address.Text = "";
                MessageBox.Show("Address Saved");
                txt_Address.Select();
            }
        }

        private void fillgrid()
        {
            dgv_AddressMaster.Rows.Clear();
            DataTable dtaddress = _objAdress.getAddress();
            for (int i = 0; i < dtaddress.Rows.Count; i++)
            {
                dgv_AddressMaster.Rows.Add();
                int gcount = Convert.ToInt32(this.dgv_AddressMaster.Rows.Count);
                gcount = gcount - 1;

                dgv_AddressMaster.Rows[gcount].Cells["SrNo"].Value = i + 1;
                dgv_AddressMaster.Rows[gcount].Cells["Address"].Value = dtaddress.Rows[i]["Address"].ToString();

            }
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = " पत्ता";
            grp_AddressDetail.Text = "पत्ता माहित्ती";
            lbl_Address.Text = "पत्ता";
            lbl_Date.Text = "तारीख";
            bttn_Delete.Text = "डिलीट";
            bttn_ResetItemDetail.Text = "रिसेट";
            bttn_Update.Text = "अपडेट";
            bttn_SaveAddress.Text = "सेव्ह";
            bttn_CloseAddress.Text = "बंद";

            dgv_AddressMaster.Columns["SrNo"].HeaderText = "क्रमांक";
            dgv_AddressMaster.Columns["Address"].HeaderText = "पत्ता";

        }

        private void bttn_SaveAddress_Leave(object sender, EventArgs e)
        {
            txt_Address.Select();
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
             if (check())
            {

               // _objAdress.updateAddress(SrNo,Address);
             }
        }

        private bool check()
        {
             if (_objValidation.IsNotEmpty(txt_Address.Text))
            {
                { return true; }

            }
             else { return false; }
        }

        private void dgv_AddressMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {

                    int ind = dgv_AddressMaster.CurrentCell.RowIndex;
                    if (dgv_AddressMaster.Rows[ind].Cells[0].Value != null)
                    {
                        txt_Address.Text = Convert.ToString(dgv_AddressMaster.Rows[ind].Cells["Address"].Value);
                    }
                    bttn_SaveAddress.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {

        }

    }
}