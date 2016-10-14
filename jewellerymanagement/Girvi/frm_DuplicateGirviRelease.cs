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
    public partial class frm_DuplicateGirviRelease : Form
    {
        public frm_DuplicateGirviRelease()
        {
            InitializeComponent();
        }
        Validation _objValidation = new Validation();
        cls_GirviRelease _objGirviRelease = new cls_GirviRelease();
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        public delegate void SendData(string BillNO, string AccNo, string otherFont);

        private void cmb_FullName_Enter(object sender, EventArgs e)
        {

            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
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

                fillCustomerInfo();
               
                lst_FullName.Visible = false;

            }

            //if (e.KeyCode == Keys.Enter)
            //{
            //    //cmb_FullName.DroppedDown = false;
            //    fillCustomerInfo();
            //    dgv_GirviDetail.Focus();

            //}
            //else
            //{
            //    //cmb_FullName.DroppedDown = true;
            //}
        }
        private void fillCustomerInfo()
        {
            if (_objValidation.IsNotEmpty(cmb_FullName.Text))
            {
                dgv_GirviDetail.Rows.Clear();

                DataTable dtKhatawani = _objGirviRelease.getKhatawaniByNameRelease(cmb_FullName.Text);
                if (dtKhatawani.Rows.Count == 1)
                {

                    txt_KhatawaniNo.Text = Convert.ToString((dtKhatawani.Rows[0]["khatawani_No"]));
                    cmb_FullName.Text = Convert.ToString((dtKhatawani.Rows[0]["FullName"]));

                    DataTable dtGirvi = _objGirviRelease.getReleaseGirviDetailsByKhatawaniAll(txt_KhatawaniNo.Text);
                    for (int i = 0; i < dtGirvi.Rows.Count; i++)
                    {
                        dgv_GirviDetail.Rows.Add();
                        int gcount = Convert.ToInt32(this.dgv_GirviDetail.Rows.Count);
                        gcount = gcount - 1;
                        dgv_GirviDetail.Rows[gcount].Cells["gn"].Value = dtGirvi.Rows[i]["Girvino"].ToString();
                        dgv_GirviDetail.Rows[gcount].Cells["AmountDeposit"].Value = dtGirvi.Rows[i]["Girvino"].ToString();
                    }
                    txt_KhatawaniNo.ReadOnly = true;
                }
                else
                {
                    //clearallwithoutname();
                }
            }

        }
        private void frm_DuplicateGirviRelease_Load(object sender, EventArgs e)
        {
            cmb_FullName.Select();
            MasterClear();
            if (rbt_OtherTrue.Checked == true)
            {
                ShivajiFont();
            }
        }

        private void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
           
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
           
            
            lst_FullName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
        }

        private void MasterClear()
        {
            //cmb_FullName.DataSource = _objGirviRelease.getNameandKhatawaniRelease();
            //  cmb_FullName.DataSource = _objGirviAdd.getFName();
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {

            if (rbt_OtherTrue.Checked == true)
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataReleaseGirvi);
                _obj(dgv_GirviDetail.Rows[dgv_GirviDetail.CurrentCell.RowIndex].Cells["gn"].Value.ToString(), txt_KhatawaniNo.Text, "Other");
                _objfrm_ReportViewer.Show();

            }
            else
            {
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataReleaseGirvi);
                _obj(dgv_GirviDetail.Rows[dgv_GirviDetail.CurrentCell.RowIndex].Cells["gn"].Value.ToString(), txt_KhatawaniNo.Text, "");
                _objfrm_ReportViewer.Show();
            }
        }

        private void lst_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_FullName.Text = lst_FullName.SelectedValue.ToString();
                //cmb_FullName.Focus();

                fillCustomerInfo();

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

        private void frm_DuplicateGirviRelease_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
