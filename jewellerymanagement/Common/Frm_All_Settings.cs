using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;
using BAL;


namespace JewelleryManagement
{
    public partial class Frm_All_Settings : Form
    {
        public Frm_All_Settings()
        {
            InitializeComponent();
        }
        SQLHelper _objSQLhelper = new SQLHelper();
        clsGirviCommon _objCommon = new clsGirviCommon();
        private void Frm_All_Settings_Load(object sender, EventArgs e)
        {
            DataTable dtSettingValue = _objCommon.getAllDataFromGetSettingValue();

            if ((Convert.ToString(dtSettingValue.Rows[0]["receipt"]) == "1"))
            {
                rbt_receiptYes.Checked = true;
                rbt_ReceiptNo.Checked = false;
            }
            else
            {
                rbt_receiptYes.Checked = false;
                rbt_ReceiptNo.Checked = true;
            }
            if ((Convert.ToString(dtSettingValue.Rows[0]["printt"]) == "1"))
            {
                rbt_PrintYes.Checked = true;
                rbt_PrintNo.Checked = false;
            }
            else
            {
                rbt_PrintYes.Checked = false;
                rbt_PrintNo.Checked = true;
            }
            if ((Convert.ToString(dtSettingValue.Rows[0]["PavtiNoAutoIncrement"]) == "1"))
            {
                rbt_PavtiYes.Checked = true;
                rbt_PavtiNo.Checked = false;
            }
            else
            {
                rbt_PavtiYes.Checked = false;
                rbt_PavtiNo.Checked = true;
            }

            if ((Convert.ToString(dtSettingValue.Rows[0]["AccountType"]) == "1"))
            {
                rbt_AccType1.Checked = true;
                rbt_AccType2.Checked = false;
            }
            else
            {
                rbt_AccType1.Checked = false;
                rbt_AccType2.Checked = true;
            }

            if ((Convert.ToString(dtSettingValue.Rows[0]["HideDataFeild"]) == "1"))
            {
                rbt_hideYes.Checked = true;
                rbt_hideNo.Checked = false;
            }
            else
            {
                rbt_hideYes.Checked = false;
                rbt_hideNo.Checked = true;
            }

                cmb_Duration.Text = Convert.ToString(dtSettingValue.Rows[0]["Duration"]);
                cmb_PrintCountTheva.Text = Convert.ToString(dtSettingValue.Rows[0]["Print_count_theva"]);
                cmb_PrintCountSodwa.Text = Convert.ToString(dtSettingValue.Rows[0]["Print_count_Sodva"]);

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (rbt_receiptYes.Checked == true)
            {
                
            }
            else
            {

            }
        }

        private void rbt_ReceiptNo_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.setreceipt("0");
        }

        private void rbt_receiptYes_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.setreceipt("1");
        }

        private void rbt_PrintYes_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.setprint("1");
        }

        private void rbt_PrintNo_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.setprint("0");
        }

        private void rbt_PavtiYes_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.setPavtiNo("1");
        }

        private void rbt_PavtiNo_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.setPavtiNo("0");
        }

        private void rbt_AccType1_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.setaccounttype("1");
        }

        private void rbt_AccType2_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.setaccounttype("0");
        }

        private void rbt_hideYes_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.sethidefeild("1");
        }

        private void rbt_hideNo_CheckedChanged(object sender, EventArgs e)
        {
            _objCommon.sethidefeild("0");
        }

        private void cmb_Duration_SelectedIndexChanged(object sender, EventArgs e)
        {
            _objCommon.setDuration(cmb_Duration.Text.ToString());
        }

        private void cmb_PrintCountTheva_SelectedIndexChanged(object sender, EventArgs e)
        {
            _objCommon.PrintCount_Theva(cmb_PrintCountTheva.Text.ToString());
        }

        private void cmb_PrintCountSodwa_SelectedIndexChanged(object sender, EventArgs e)
        {
            _objCommon.PrintCount_Sodwa(cmb_PrintCountSodwa.Text.ToString());
        }
    }
}
