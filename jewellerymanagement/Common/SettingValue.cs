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

namespace JewelleryManagement.Common
{
    public partial class SettingValue : Form
    {
        SQLHelper _objSqlHelper = new SQLHelper();
        clsCommon _objcommon = new clsCommon();

        public SettingValue()
        {
            InitializeComponent();
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingValue_Load(object sender, EventArgs e)
        {
            string Date = DateTime.UtcNow.ToString();
            string value = "";

            string language = "language";
            string query = "UPDATE setting_value SET language='0' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, language, query, Date, value);

            string visibility = "visibility";
            string query1 = "UPDATE setting_value SET visibility='1' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, visibility, query1, Date, value);

            string fund_month = "fund_month";
            string query2 = "UPDATE setting_value SET fund_month='1' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, fund_month, query2, Date, value);

            string interest = "interest";
            string query3 = "UPDATE setting_value SET interest='1' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, interest, query3, Date, value);

            string receipt = "receipt";
            string query4 = "UPDATE setting_value SET receipt='0' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, receipt, query4, Date, value);

            string Searchtype = "Searchtype";
            string query5 = "UPDATE setting_value SET Searchtype='1' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, Searchtype, query5, Date, value);

            string printt = "printt";
            string query6 = "UPDATE setting_value SET printt='0' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, printt, query6, Date, value);

            string PavtiNoAutoIncrement = "PavtiNoAutoIncrement";
            string query7 = "UPDATE setting_value SET PavtiNoAutoIncrement='1' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, PavtiNoAutoIncrement, query7, Date, value);

            string AccountType = "AccountType";
            string query8 = "UPDATE setting_value SET AccountType='1' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, AccountType, query8, Date, value);

            //string HideDataFeild = "HideDataFeild";
            //string query9 = "UPDATE setting_value SET HideDataFeild='1' where (ID = '1')";
            //dgv_SettingValue.Rows.Add(false, HideDataFeild, query9, Date);

            string Print_count_theva = "Print_count_theva";
            string query10 = "UPDATE setting_value SET Print_count_theva='1' where (ID = '1')";
            dgv_SettingValue.Rows.Add(false, Print_count_theva, query10, Date, value);

            //string Duration = "Duration";
            //string query11 = "UPDATE setting_value SET Duration='1' where (ID = '1')";
            //dgv_SettingValue.Rows.Add(false, Duration, query11, Date);

            //string Print_count_sodva = "Print_count_sodva";
            //string query12 = "UPDATE setting_value SET Print_count_sodva='1' where (ID = '1')";
            //dgv_SettingValue.Rows.Add(false, Print_count_sodva, query12, Date);
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            DialogResult drReportPrint = MessageBox.Show("Do You Want To Execute", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (drReportPrint == DialogResult.Yes)
            {
                for (int i = 0; i < dgv_SettingValue.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgv_SettingValue.Rows[i].Cells["Select"].Value.ToString()) == true)
                    {
                        try
                        {
                            string query = dgv_SettingValue.Rows[i].Cells["Query"].Value.ToString();
                            _objSqlHelper.ExecuteSql(query);
                        }
                        catch
                        {
                        }

                    }

                }
                MessageBox.Show("Data Updated");
            }
            else
            {
                this.Close();
            }
        }

        private void chk_selectall_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_selectall.Checked == true)
            {
                for (int i = 0; i < dgv_SettingValue.Rows.Count; i++)
                {
                    dgv_SettingValue.Rows[i].Cells[0].Value = true;

                }
            }
            else
            {
                for (int i = 0; i < dgv_SettingValue.Rows.Count; i++)
                {
                    dgv_SettingValue.Rows[i].Cells[0].Value = false;
                }
            }
        }

      

       

      
    }
}
