using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using System.Drawing.Text;
using BAL.Girvi;
namespace JewelleryManagement.Girvi
{
    public partial class frm_TahsilMaster : Form
    {
        public frm_TahsilMaster()
        {
            InitializeComponent();
        }
        Simplevalidations _Objsimplevalidation = new Simplevalidations();
        clsTahsil _objTahsil = new clsTahsil();
        Validation _objValidation = new Validation();
        private void frm_TahsilMaster_Load(object sender, EventArgs e)
        {
                SetFont();
                txt_TahsilDetail.Focus();
                MasterClear();
            
        }
        public void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
           // dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_TahsilDetail.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_TahsilDetail.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_Interest.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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
            txt_TahsilDetail.ResetText();
            fillgrid();
          
           // dgv_TahsilMaster.Rows.Clear();

        }

        private void txt_Tahsil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Save.Focus();
            }
        }

        private void txt_Tahsil_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Objsimplevalidation.ValidationCharOnly(e);
        }

        private void frm_TahsilMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

            }
        }

        private void txt_TahsilDetail_Leave(object sender, EventArgs e)
        {
            txt_TahsilDetail.Focus();
        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "तहसील मास्टर";
            grp_TahsilDetail.Text = "तहसील माहित्ती ";
            lbl_Name.Text = "नाव";
            lbl_Date.Text = "तारीख";
            bttn_Delete.Text = "डिलीट";
            bttn_Save.Text = "सेव्ह";
            bttn_Close.Text = "बंद";

            dgv_TahsilMaster.Columns["SrNo"].HeaderText = "क्रमांक";
            dgv_TahsilMaster.Columns["Tahsil"].HeaderText = "पत्ता";

        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "तहसील मास्टर";
            grp_TahsilDetail.Text = "तहसील माहित्ती ";
            lbl_Name.Text = "नाव";
            lbl_Date.Text = "तारीख";
            bttn_Delete.Text = "डिलीट";
            bttn_Save.Text = "सेव्ह";
            bttn_Close.Text = "बंद";

            dgv_TahsilMaster.Columns["SrNo"].HeaderText = "क्रमांक";
            dgv_TahsilMaster.Columns["Tahsil"].HeaderText = "पत्ता";

        }

        private void txt_TahsilDetail_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "तहसील मास्टर";
            grp_TahsilDetail.Text = "तहसील माहित्ती ";
            lbl_Name.Text = "नाव";
            lbl_Date.Text = "तारीख";
            bttn_Delete.Text = "डिलीट";
            bttn_Save.Text = "सेव्ह";
            bttn_Close.Text = "बंद";

            dgv_TahsilMaster.Columns["SrNo"].HeaderText = "क्रमांक";
            dgv_TahsilMaster.Columns["Tahsil"].HeaderText = "पत्ता";
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            if (txt_TahsilDetail.Text != "")
            {
                DialogResult dr = MessageBox.Show("Do you want To Save", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    _objTahsil.addTahsil(txt_TahsilDetail.Text);
                }
                fillgrid();
                txt_TahsilDetail.Text = "";
                MessageBox.Show("Tahsil Saved");
                txt_TahsilDetail.Select();
            }
        }

        private void fillgrid()
        {
            dgv_TahsilMaster.Rows.Clear();
            DataTable dttahsil = _objTahsil.getTahsil();
            for (int i = 0; i < dttahsil.Rows.Count; i++)
            {
                dgv_TahsilMaster.Rows.Add();
                int gcount = Convert.ToInt32(this.dgv_TahsilMaster.Rows.Count);
                gcount = gcount - 1;

                dgv_TahsilMaster.Rows[gcount].Cells["SrNo"].Value = i + 1;
                dgv_TahsilMaster.Rows[gcount].Cells["Tahsil"].Value = dttahsil.Rows[i]["Tahsil"].ToString();

            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            if (check())
            {
                _objTahsil.updateTahsil(txt_TahsilDetail.Text, txt_srno.Text);
              
            }
        }

        private bool check()
        {
            if (_objValidation.IsNotEmpty(txt_TahsilDetail.Text))
            {
                { return true; }

            }
            else { return false; }
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            _objTahsil.deleteTahsil(dgv_TahsilMaster.CurrentRow.Cells["Srno"].Value.ToString());
        }

        private void dgv_TahsilMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {

                    int ind = dgv_TahsilMaster.CurrentCell.RowIndex;
                    if (dgv_TahsilMaster.Rows[ind].Cells[0].Value != null)
                    {
                        txt_TahsilDetail.Text = Convert.ToString(dgv_TahsilMaster.Rows[ind].Cells["Tahsil"].Value);
                    }
                    bttn_Save.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
