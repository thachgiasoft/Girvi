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
    public partial class frm_UpdateQuery : Form
    {
        SQLHelper _objSqlHelper = new SQLHelper();

        public frm_UpdateQuery()
        {
            InitializeComponent();
        }

        private void frm_UpdateQuery_Load(object sender, EventArgs e)
        {
            string Date = DateTime.UtcNow.ToString();

            string AccountType ="AccountType";
            string query = "ALTER TABLE setting_value  ADD AccountType  varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, AccountType, query, Date);

            string Interest = "Interest ";
            string query2 = "ALTER TABLE GirviMaster   ADD Interest  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Interest, query2, Date);

            string PoliceStation = "PoliceStation ";
            string query3 = "ALTER TABLE Customer_Master   ADD PoliceStation  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, PoliceStation, query3, Date);

            string Tahsil = "Tahsil";
            string query4 = "ALTER TABLE Customer_Master   ADD Tahsil  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Tahsil, query4, Date);

            string District = "District";
            string query5 = "ALTER TABLE Customer_Master   ADD District	nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, District, query5, Date);

            string PrintCountTheva = "PrintCountTheva";
            string query6 = "ALTER TABLE setting_value  ADD Print_count_theva  varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, PrintCountTheva, query6, Date);

            string Duration = "Duration";
            string query7 = "ALTER TABLE setting_value  ADD Duration  varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Duration, query7, Date);

            string PrintCountSodva = "PrintCountSodva";
            string query8 = "ALTER TABLE setting_value  ADD Print_count_sodva  varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, PrintCountSodva, query8, Date);

            string HideDataFeild = "HideData";
            string query9 = "ALTER TABLE setting_value  ADD HideDataFeild  varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, HideDataFeild, query9, Date);

            string District1 = "District";
            string query10 = "ALTER TABLE CompanyMaster  ADD District  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, District1, query10, Date);

            string Tahsil1 = "Tahsil";
            string query11 = "ALTER TABLE CompanyMaster  ADD Tahsil  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Tahsil1, query11, Date);

            string PinCode = "PinCode";
            string query12 = "ALTER TABLE CompanyMaster  ADD PinCode int";
            dgv_UpdateQuery.Rows.Add(false, PinCode, query12, Date);

            string State = "State";
            string query13 = "ALTER TABLE CompanyMaster  ADD State nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, State, query13, Date);

            string Khatawani = "Khatawani";
            string query14 = "ALTER TABLE tbl_GirviCrystalReports  ADD Khatawani varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Khatawani, query14, Date);

            string Rokad = "Rokad";
            string query21 = "ALTER TABLE tbl_GirviCrystalReports  ADD Rokad varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Rokad, query21, Date);

            string RokadAll = "RokadAll";
            string query22 = "ALTER TABLE tbl_GirviCrystalReports  ADD RokadAll varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, RokadAll, query22, Date);

            string Notice = "Notice";
            string query23 = "ALTER TABLE tbl_GirviCrystalReports  ADD Notice varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Notice, query23, Date);

            string Bhandval = "Bhandval";
            string query24 = "ALTER TABLE tbl_GirviCrystalReports  ADD Bhandval varchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Bhandval, query24, Date);

            string Post = "Post";
            string query25 = "ALTER TABLE CompanyMaster  ADD Post  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Post, query25, Date);

            string Narration = "narration";
            string query26 = "ALTER TABLE GirviMaster  ADD narration  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Narration, query26, Date);

            string Narration1 = "narration";
            string query27 = "ALTER TABLE GirviItemMaster  ADD narration  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Narration1, query27, Date);

            string Narration2 = "financialYearId And Narration";
            string query28 = "ALTER TABLE GirviReleasemaster  ADD [financialYearId] [int] NOT NULL CONSTRAINT [DF_GirviReleasemaster_financialYearId_1]  DEFAULT ((1)),Narration  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, Narration2, query28, Date);

            string TahsilMaster = "TahsilMaster";
            string query29 = "CREATE TABLE [dbo].[TahsilMaster]([srno] [int] IDENTITY(1,1) NOT NULL,[Tahsil] [nvarchar](max) NULL) ON [PRIMARY];";
            dgv_UpdateQuery.Rows.Add(false, TahsilMaster, query29, Date);

            string vadhiv = "vadhiv";
            string query30 = "ALTER TABLE GirviMaster  ADD vadhiv  nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, vadhiv, query30, Date);

            string duration = " duration";
            string query31 = "ALTER TABLE setting_value  ADD duration nvarchar(MAX)";
            dgv_UpdateQuery.Rows.Add(false, duration, query31, Date);

            string NSN = "No of Send Notice";
            string query32 = "ALTER TABLE GirviMaster  ADD [NSN] [int] NOT NULL CONSTRAINT [DF_GirviMaster_NSN]  DEFAULT ((0)), [DateTime] [datetime] NOT NULL CONSTRAINT [DF_GirviMaster_DateTime]  DEFAULT (getdate())";
            dgv_UpdateQuery.Rows.Add(false, NSN, query32, Date);
            
        }


        private void btn_Execute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_UpdateQuery.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_UpdateQuery.Rows[i].Cells["Select"].Value.ToString()) == true)
                {
                    try
                    {
                        string query = dgv_UpdateQuery.Rows[i].Cells["Query"].Value.ToString();
                        _objSqlHelper.ExecuteSql(query);
                    }
                    catch
                    {
                    }

                }
               
            }

            MessageBox.Show("Done");
        }

        private void chk_selectall_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_selectall.Checked == true)
            {
                for (int i=0; i < dgv_UpdateQuery.Rows.Count; i++)
                {
                    dgv_UpdateQuery.Rows[i].Cells[0].Value = true;
                      
                }
            }
            else
            {
                for (int i=0; i < dgv_UpdateQuery.Rows.Count; i++)
                {
                    dgv_UpdateQuery.Rows[i].Cells[0].Value = false;
                }
            }
        }
    }
}
