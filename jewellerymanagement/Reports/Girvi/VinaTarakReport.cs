using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Reports.Girvi;
using BAL.Girvi;
using BAL;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class VinaTarakReport : Form
    {
        public VinaTarakReport()
        {
            InitializeComponent();
        }
        KhatawaniWithGirviBAL _objKhatwaniWithGirviBal = new KhatawaniWithGirviBAL();
        cls_GirviAdd _objgirvi = new cls_GirviAdd();
        Validation val = new Validation();
        public delegate void SendData(DataTable dtData,bool Other);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VinaTarakReport_Load(object sender, EventArgs e)
        {

        }

        private void bttn_View_Click(object sender, EventArgs e)
        {
            dgv_Vinatarakdetails.Rows.Clear();
            int i=0;
            DataTable dtGirvi = null;
       
           dtGirvi = _objgirvi.getVinaTarakDataByKhatawanoNo( dtp_StartDate.Text, dtp_EndDate.Text);
          
          
            int SrNo = 1;
            for (i = 0; i < dtGirvi.Rows.Count; i++)

            {



                if (dtGirvi.Rows[i]["loantype"].ToString() == "विनातारण")
                    {
                        dgv_Vinatarakdetails.Rows.Add();
                        dgv_Vinatarakdetails.Rows[i].Cells["LoneType"].Value = dtGirvi.Rows[i]["loantype"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["khno"].Value = dtGirvi.Rows[i]["khatawani_No"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["FullName"].Value = dtGirvi.Rows[i]["FullName"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["ContactNo"].Value = dtGirvi.Rows[i]["Contact_No"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["Address"].Value = dtGirvi.Rows[i]["Address"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["Balance"].Value = dtGirvi.Rows[i]["Balance"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["OpeningDate"].Value = dtGirvi.Rows[i]["Opening_date"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["Cast"].Value = dtGirvi.Rows[i]["cast"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["Occupation"].Value = dtGirvi.Rows[i]["occupation"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["City"].Value = dtGirvi.Rows[i]["Address2"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["DateTime"].Value = dtGirvi.Rows[i]["DateTime"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["District"].Value = dtGirvi.Rows[i]["District"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["DateOfDeposite"].Value = dtGirvi.Rows[i]["Date_of_deposit"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["IntersetRate"].Value = dtGirvi.Rows[i]["interset_rate"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["Duration"].Value = dtGirvi.Rows[i]["duration"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["Release"].Value = dtGirvi.Rows[i]["Release"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["WithdrawReleaseDate"].Value = dtGirvi.Rows[i]["withdraw_release_date"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["ActualInterest"].Value = dtGirvi.Rows[i]["Actual_InterestRate"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["Reason"].Value = dtGirvi.Rows[i]["reason"].ToString();
                        dgv_Vinatarakdetails.Rows[i].Cells["Amount"].Value = dtGirvi.Rows[i]["Amount"].ToString();
                       
                        SrNo++;
                    }
                    else
                    {
                        MessageBox.Show("DATA NOT FOUND");
                    }
               
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
         
            DataTable dataNew = val.DataGridView2DataTable(dgv_Vinatarakdetails, "table");
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReciveDataVinaTaranReport);

            if (rbt_OtherTrue.Checked == true)
            {
                _obj(dataNew, true);
            }
            else
            {
                _obj(dataNew, false);

            }
            _objfrm_ReportViewer.Show();

        }

        private void VinaTarakReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

     
    }
}
