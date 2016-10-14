using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.DataBaseForms;
using BAL;

namespace JewelleryManagement.DataBaseForms
{
    public partial class Frm_DeleteAllTableData : Form
    {
        Cls_SettingDatabase _objSettingData = new Cls_SettingDatabase();

        public Frm_DeleteAllTableData()
        {
            InitializeComponent();
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_BalanceReport.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_BalanceReport.Rows[i].Cells["Select"].Value.ToString()) == true)
                {
                    _objSettingData.deleteAll(dgv_BalanceReport.Rows[i].Cells["Table_Name"].Value.ToString());
                }
            }
            MessageBox.Show("Done");
            this.Close();
        }

        private void Frm_DeleteAllTableData_Load(object sender, EventArgs e)
        {
            MasterClear();
        }

        private void MasterClear()
        {
            dgv_BalanceReport.Rows.Clear();
            DataTable dtTables = _objSettingData.getAllDatabaseTables(clsVariable.DatabaseName);
            for (int i = 0; i < dtTables.Rows.Count; i++)
            {
                dgv_BalanceReport.Rows.Add();
                dgv_BalanceReport.Rows[i].Cells["Table_Name"].Value = dtTables.Rows[i]["TABLE_NAME"].ToString();
            }
            rbn_SelectAll.Checked = true;
        }

        private void rbn_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_BalanceReport.Rows.Count; i++)
            {
                dgv_BalanceReport.Rows[i].Cells["Select"].Value = true;
            }
        }

        private void rbn_CustomSelect_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_BalanceReport.Rows.Count; i++)
            {
                dgv_BalanceReport.Rows[i].Cells["Select"].Value = false;
            }
        }
    }
}
