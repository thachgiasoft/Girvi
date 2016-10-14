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
using System.Globalization;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_TotalInterest : Form
    {
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        Validation val = new Validation();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();

        public delegate void SendData(DataTable dtData, string MonthYear,bool Other);

        public frm_TotalInterest()
        {
            InitializeComponent();
        }

        private void frm_TotalInterest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TotalInterest_Load(object sender, EventArgs e)
        {
            setDateAsFinancialYear();
            dgv_InterestDetail.Rows.Clear();

        }
         private void setDateAsFinancialYear()
        {
            try
            {
                ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
                DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
                dtp_StartDate.Text = dtFiancialYear.Rows[0]["startyear"].ToString();
                dtp_EndDate.Text = dtFiancialYear.Rows[0]["endyear"].ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bttn_View_Click(object sender, EventArgs e)
        {
            try
            {
                double sum = 0;
                int i;
                int j = 0;
                dgv_InterestDetail.Rows.Clear();
                for (i = 0; i <= (Convert.ToDateTime(dtp_EndDate.Text) - Convert.ToDateTime(dtp_StartDate.Text)).TotalDays; i++)
                {
                    double dtvyaj = _objGirviCommon.getInterestTotal(Convert.ToDateTime(dtp_StartDate.Text).AddDays(j).ToShortDateString().ToString());
                    sum = sum + dtvyaj;
                    dgv_InterestDetail.Rows.Add(Convert.ToDateTime(dtp_StartDate.Text).AddDays(j).ToShortDateString(), dtvyaj.ToString());
                    j++;

                }

                dgv_InterestDetail.Rows.Add("एकुण व्याज", sum.ToString());
                dgv_InterestDetail.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                dgv_InterestDetail.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbl_MonthYear.Text = "Custome Report";
        }

        private void dtp_StartDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_EndDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            DataTable data = val.DataGridView2DataTable(dgv_InterestDetail, "table");
             CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
             SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveTotalInterest);
            _obj(data,lbl_MonthYear.Text,false);
            _objfrm_ReportViewer.ShowDialog();
        }

        private void MonthlyIntrest()
        {
            dgv_InterestDetail.Rows.Clear();
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            DataTable openingData = new DataTable();

            try
            {
                DataTable dtCashDetails = new DataTable();
                dtCashDetails.Columns.Add();
              
                dtCashDetails.Columns.Add();

                double sumOpeningData = Convert.ToDouble(_objGirviCommon.getBhandwalWithLastDate(dtFiancialYear.Rows[0]["startyear"].ToString()));
            
                    double sumdtInterest = 0;
                 
                    int j = 0;
                    int rowGrid = 0;
                    int month = Convert.ToInt32(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).Month);
                    for (int i = 0; i <= (Convert.ToDateTime(dtFiancialYear.Rows[0]["endyear"].ToString()) - Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString())).TotalDays + 1; i++)
                    {
                        string Date = Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString();
                     
                        double dtInterest = _objGirviCommon.getInterestTotal(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString().ToString());
                  
                        int monthdate = Convert.ToInt32(Convert.ToDateTime(Date).Month);
                        if (month == 13)
                        {
                            month = 1;
                        }
                        if (month == monthdate)
                        {
                           sumdtInterest += dtInterest;                        
                        }
                        else
                        {
                          string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                          
                            dgv_InterestDetail.Rows.Add(strMonthName, sumdtInterest);

                            month++;
                         
                            sumdtInterest = 0;
                       
                            sumdtInterest = _objGirviCommon.getInterestTotal(Date);

                            rowGrid++;
                        }
                        j++;
                    }
               
            }
             
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Custome()
        {
            dgv_InterestDetail.Rows.Clear();
            try
            {
                double sum = 0;
                int i;
                int j = 0;
                dgv_InterestDetail.Rows.Clear();
                for (i = 0; i <= (Convert.ToDateTime(dtp_EndDate.Text) - Convert.ToDateTime(dtp_StartDate.Text)).TotalDays; i++)
                {
                    double dtvyaj = _objGirviCommon.getInterestTotal(Convert.ToDateTime(dtp_StartDate.Text).AddDays(j).ToShortDateString().ToString());
                    sum = sum + dtvyaj;
                    dgv_InterestDetail.Rows.Add(Convert.ToDateTime(dtp_StartDate.Text).AddDays(j).ToShortDateString(), dtvyaj.ToString());
                    j++;

                }

                dgv_InterestDetail.Rows.Add("एकुण व्याज", sum.ToString());
                dgv_InterestDetail.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                dgv_InterestDetail.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void yearly()
        {
            dgv_InterestDetail.Rows.Clear();
            DataTable dtFiancialYear = _objFinancialYear.getFinancialYear();
          
            try
            {
               
                double sum = 0;
                int i;
                int j = 0;
                int year = Convert.ToInt32(Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).Year + Convert.ToDateTime(dtFiancialYear.Rows[0]["endyear"].ToString()).Year);
                for (i = 0; i< dtFiancialYear.Rows.Count; i++)
                {
                string space = " to";
                string StartDate = (dtFiancialYear.Rows[i]["startyear"].ToString());
                string EndDate = (dtFiancialYear.Rows[i]["endyear"].ToString());
                string yera3 = StartDate + space + EndDate;

                double dtInterstTotal = _objGirviCommon.getInterestTotal(StartDate, EndDate);


                dgv_InterestDetail.Rows.Add(yera3, dtInterstTotal);
                }
              
              

                dgv_InterestDetail.Rows.Add("एकुण व्याज", sum.ToString());
                dgv_InterestDetail.Rows[dgv_InterestDetail.Rows.Count-1].DefaultCellStyle.BackColor = Color.Red;
                dgv_InterestDetail.Rows[dgv_InterestDetail.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbt_monthly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_monthly.Checked == true )
            {
                MonthlyIntrest();
            }
            if (rbt_custome.Checked == true )
            {
                Custome();
            }
            if (rbt_yearly.Checked == true )
            {
                yearly();
            }

            lbl_MonthYear.Text = "Monthly Report";
        }

        private void rbt_custome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_monthly.Checked == true)
            {
                MonthlyIntrest();
            }
            if (rbt_custome.Checked == true)
            {
                Custome();
            }
            if (rbt_yearly.Checked == true)
            {
                yearly();
            }
            lbl_MonthYear.Text = "Custome Report";
        }

        private void rbt_yearly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_monthly.Checked == true)
            {
                MonthlyIntrest();
            }
            if (rbt_custome.Checked == true)
            {
                Custome();
            }
            if (rbt_yearly.Checked == true)
            {
                yearly();
            }
            lbl_MonthYear.Text = "Yearly Report";
        }

    }
}
