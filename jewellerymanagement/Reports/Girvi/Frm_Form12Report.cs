using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Girvi;
using BAL;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class Frm_Form12Report : Form
    {
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        Validation _objValidation = new Validation();

        public delegate void SendData(string KhatawaniNo, bool otherfont);

        public Frm_Form12Report()
        {
            InitializeComponent();
        }

        private void Frm_Notice_Load(object sender, EventArgs e)
        {
           // filltextbox();

            cmb_FullName.ResetText();
            cmb_FullName.Select();
        }

        private void filltextbox()
        {
            cmb_FullName.DataSource = _objGirviAdd.getFName();
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataForm12LaadKaranja);//ReceiveDataForm12
            _obj(txt_KhatawaniNo.Text, false);
            _objfrm_ReportViewer.Show();
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

            else
            {
                // cmb_FullName.DroppedDown = true;
            }
        }

        private void fillCustomerInfo()
        {
            if (_objValidation.IsNotEmpty(cmb_FullName.Text))
            {
                DataTable dtKhatawani = _objGirviAdd.getKhatawaniByName(cmb_FullName.Text);
                if (dtKhatawani.Rows.Count == 1)
                {
                    txt_KhatawaniNo.Text = Convert.ToString((dtKhatawani.Rows[0]["khatawani_No"]));
                    cmb_FullName.Text = Convert.ToString((dtKhatawani.Rows[0]["FullName"]));
                    txt_KhatawaniNo.ReadOnly = true;
                }
                else
                {
                }
            }
        }

        private void cmb_FullName_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
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

        private void Frm_Form12Report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txt_KhatawaniNo_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
