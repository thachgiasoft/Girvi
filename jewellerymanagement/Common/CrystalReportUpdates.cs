using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;

namespace JewelleryManagement.Common
{
    public partial class CrystalReportUpdates : Form
    {
        SQLHelper _objSqlHelper = new SQLHelper();
        public CrystalReportUpdates()
        {
            InitializeComponent();
        }

        private void bttn_crystalreport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrystalReportUpdates_Load(object sender, EventArgs e)
        {
            string Date = DateTime.UtcNow.ToString();


            string GirviAdd = "GirviAdd";
            string query = "UPDATE tbl_GirviCrystalReports SET GirviAdd='Crt_WardhaGirviAdd.rpt' where (id = '1')";
            dgv_CrystalReport.Rows.Add(false, GirviAdd, query, Date);

            string GirviRelease = "GirviRelease";
            string query1 = "UPDATE tbl_GirviCrystalReports SET GirviRelease='Crt_WardhaRelease.rpt' where (id = '1')";
            dgv_CrystalReport.Rows.Add(false, GirviRelease, query1, Date);

            string Khatawani = "Khatawani";
            string query2 = "UPDATE tbl_GirviCrystalReports SET Khatawani='crt_SagarInterestRecord.rpt' where (id = '1')";
            dgv_CrystalReport.Rows.Add(false, Khatawani, query2, Date);

            string Rokad = "Rokad";
            string query3 = "UPDATE tbl_GirviCrystalReports SET Rokad='crt_SagarRokadMultiPrint.rpt' where (id = '1')";
            dgv_CrystalReport.Rows.Add(false, Rokad, query3, Date);

            string RokadAll = "RokadAll";
            string query4 = "UPDATE tbl_GirviCrystalReports SET RokadAll='crt_SagarRokadAll.rpt' where (id = '1')";
            dgv_CrystalReport.Rows.Add(false, RokadAll, query4, Date);

            string Notice = "Notice";
            string query5 = "UPDATE tbl_GirviCrystalReports SET Notice='Crt_Nikhare_Notice.rpt' where (id = '1')";
            dgv_CrystalReport.Rows.Add(false, Notice, query5, Date);

            string Bhandval = "Bhandval";
            string query6 = "UPDATE tbl_GirviCrystalReports SET Bhandval='crt_Bhandval.rpt' where (id = '1')";
            dgv_CrystalReport.Rows.Add(false, Bhandval, query6, Date);
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            DialogResult drReportPrint = MessageBox.Show("Do You Want To Execute", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (drReportPrint == DialogResult.Yes)
            {
                for (int i = 0; i < dgv_CrystalReport.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgv_CrystalReport.Rows[i].Cells["Select"].Value.ToString()) == true)
                    {
                        try
                        {
                            string query = dgv_CrystalReport.Rows[i].Cells["Query"].Value.ToString();
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
                for (int i = 0; i < dgv_CrystalReport.Rows.Count; i++)
                {
                    dgv_CrystalReport.Rows[i].Cells[0].Value = true;

                }
            }
            else
            {
                for (int i = 0; i < dgv_CrystalReport.Rows.Count; i++)
                {
                    dgv_CrystalReport.Rows[i].Cells[0].Value = false;
                }
            }
        }

       
    }
}
