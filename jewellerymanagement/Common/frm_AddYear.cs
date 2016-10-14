using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using BAL.Common;

namespace JewelleryManagement.Common
{
    public partial class frm_AddYear : Form
    {
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
        public frm_AddYear()
        {
            InitializeComponent();
        }

        private void frm_AddYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AddYear_Load(object sender, EventArgs e)
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
            }

            //dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_StartYear.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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
            Clear();
            FillGrid();
        }

        private void FillGrid()
        {
            dgv_YearsDetail.Rows.Clear();
            DataTable dtyear = _objFinancialYear.getFinancialYear();
            for (int i = 0; i < dtyear.Rows.Count; i++)
            {
                dgv_YearsDetail.Rows.Add();
                dgv_YearsDetail.Rows[i].Cells["StartYear"].Value = dtyear.Rows[i]["startyear"].ToString();
                dgv_YearsDetail.Rows[i].Cells["EndYear"].Value = dtyear.Rows[i]["endyear"].ToString();
                dgv_YearsDetail.Rows[i].Cells["id"].Value = dtyear.Rows[i]["id"].ToString();

                if (Convert.ToBoolean(dtyear.Rows[i]["isSelected"].ToString()) == true)
                {
                    dgv_YearsDetail.Rows[i].Cells["SelectedYear"].Value = true;
                }
                else
                {
                    dgv_YearsDetail.Rows[i].Cells["SelectedYear"].Value = false;
                }
            }
        }

        private void Clear()
        {
           dgv_YearsDetail.Rows.Clear();
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "साल";
            grp_Years.Text = "वर्ष";
            lbl_Date.Text = "तारीख";
            dgv_YearsDetail.Columns["StartYear"].HeaderText = "शुरुवात साल";
            dgv_YearsDetail.Columns["EndYear"].HeaderText = "अंतिम साल";
            dgv_YearsDetail.Columns["SelectedYear"].HeaderText = "चुनाहुआ साल";
            bttn_CloseForm.Text = "बंद";
            lbl_StartYear.Text = "शुरुवात साल";
            lbl_EndYear.Text = "अंतिम साल";
            bttn_SaveAddress.Text = "सेव्ह";
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = " वर्ष";
            grp_Years.Text = "वर्ष";
            lbl_Date.Text = "तारीख";
            dgv_YearsDetail.Columns["StartYear"].HeaderText = "सुरवात वर्षे";
            dgv_YearsDetail.Columns["EndYear"].HeaderText = "शेवट वर्षे";
            dgv_YearsDetail.Columns["SelectedYear"].HeaderText = "निवडक वर्षे";
            bttn_CloseForm.Text = "बंद";
            lbl_StartYear.Text = "सुरवात वर्षे";
            lbl_EndYear.Text = "शेवट वर्षे";
            bttn_SaveAddress.Text = "सेव्ह";
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {

            this.Text = " वर्ष";
            grp_Years.Text = "वर्ष";
            lbl_Date.Text = "तारीख";
            dgv_YearsDetail.Columns["StartYear"].HeaderText = "सुरवात वर्षे";
            dgv_YearsDetail.Columns["EndYear"].HeaderText = "शेवट वर्षे";
            dgv_YearsDetail.Columns["SelectedYear"].HeaderText = "निवडक वर्षे";
            bttn_CloseForm.Text = "बंद";
            lbl_StartYear.Text = "सुरवात वर्षे";
            lbl_EndYear.Text = "शेवट वर्षे";
            bttn_SaveAddress.Text = "सेव्ह";
        }

        private void bttn_SaveAddress_Click(object sender, EventArgs e)
        {
            try
            {
                _objFinancialYear.addFinancialYear(dtp_StartYear.Text, dtp_EndYear.Text);
                MessageBox.Show("Year Added");
                MasterClear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int currentMouseOverRow;

        private void dgv_YearsDetail_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Select"));
                m.MenuItems.Add(new MenuItem("Delete"));
                m.MenuItems[0].Click += new System.EventHandler(this.menuItemForward_Click);
                m.MenuItems[1].Click += new System.EventHandler(this.menuItemDelete_Click);
                currentMouseOverRow = dgv_YearsDetail.HitTest(e.X, e.Y).RowIndex;
                m.Show(dgv_YearsDetail, new Point(e.X, e.Y));

            }
        }

        private void menuItemForward_Click(object sender, System.EventArgs e)
        {
            try
            {
                _objFinancialYear.updateSelectedFinancialYear(dgv_YearsDetail.Rows[currentMouseOverRow].Cells["id"].Value.ToString());
                MasterClear();
                MessageBox.Show("Year Selected");
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Invalid Operation");
            }

        }
        private void menuItemDelete_Click(object sender, System.EventArgs e)
        {
            try
            {
                _objFinancialYear.DeleteFinancialYear(dgv_YearsDetail.Rows[currentMouseOverRow].Cells["id"].Value.ToString());
                MasterClear();
                MessageBox.Show("Year Deleted");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Invalid Operation");
            }

        }

        private void dtp_StartYear_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_EndYear_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            _objFinancialYear.updateFinancialYear(lbl_id.Text, dtp_StartYear.Text, dtp_EndYear.Text);
            MasterClear();
            MessageBox.Show("Year Updated");
        }

        private void dgv_YearsDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtp_StartYear.Text = dgv_YearsDetail.Rows[e.RowIndex].Cells["StartYear"].Value.ToString();
            dtp_EndYear.Text = dgv_YearsDetail.Rows[e.RowIndex].Cells["EndYear"].Value.ToString();
            lbl_id.Text = dgv_YearsDetail.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }

    }
}
