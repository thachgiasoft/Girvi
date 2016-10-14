using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.DataBaseForms;

namespace JewelleryManagement.DataBaseForms
{
    public partial class UpdateDataBase : Form
    {
        Cls_SettingDatabase _objSettingData = new Cls_SettingDatabase();

        public UpdateDataBase()
        {
            InitializeComponent();
        }

        private void UpdateDataBase_Load(object sender, EventArgs e)
        {
            cmb_TableName.DataSource = _objSettingData.getAllDatabaseTables(cmb_TableName.Text);
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            if (chb_nullvalue.Checked == false && txt_defaultvalue.Text == "")
            {
            _objSettingData.UpdateTableColumns(cmb_TableName.Text, txt_columname.Text, cmb_DATATYPEVALUE.Text);
            }
            else
            {
                _objSettingData.UpdateTableColumns(cmb_TableName.Text, txt_columname.Text, cmb_DATATYPEVALUE.Text, "NOT NULL",txt_defaultvalue.Text);
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            cmb_TableName.ResetText();
            txt_columname.ResetText();
            cmb_DATATYPEVALUE.ResetText();
            chb_nullvalue.Checked = false;
            txt_defaultvalue.ResetText();



        }
    }
}
