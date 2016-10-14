using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;
using BAL.Reports.Girvi;
using BAL;
using System.Drawing.Text;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_Bhandwal : Form
    {
        DataTable dtBhandwal = new DataTable();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsCommon _objCommon = new clsCommon();
        Validation val = new Validation();
        public delegate void SendData(DataTable dtData, string EndDate, bool Other);

        public frm_Bhandwal()
        {
            InitializeComponent();
        }

        private void frm_Bhandwal_KeyDown(object sender, KeyEventArgs e)
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

        private void frm_Bhandwal_Load(object sender, EventArgs e)
        {
            SetFont();
            dgv_Bhandwal.Rows.Clear();
        }
        public void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
            //dateTimePicker1.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_StartDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_khatawaniNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_Srno.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_DateOfDeposite.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_InterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_Loanamount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_DepositDays.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_InterestAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_InterestPaid.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_TotalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_PayAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_FinalWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_FinalWtInPercent.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_FineWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_Quantity.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_ActualRate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_TotalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_FinalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_InterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_EstimateInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //txt_LoanAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_DateOfDeposit.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_Duration.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            // System.ComponentModel.TypeConverter converter = 
        }


        private void SetFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                ShivajiFont();
            } 
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            lbl_Date.Text = "तारीख";
            this.Text = "भांडवल";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_dates.Text = "तारीख";
            bttn_Close.Text = "बंद";
            bttn_PrintReport.Text = "प्रिंट रिपोर्ट";
            bttn_Opening.Text = "ओपेनिंग";
            bttn_ViewRecord.Text = "रिकॉर्ड बघा";

            dgv_Bhandwal.Columns["Date"].HeaderText = "तारीख";
            dgv_Bhandwal.Columns["Rokadpan"].HeaderText = "रोकड पान";
            dgv_Bhandwal.Columns["GirviAdded"].HeaderText = "नावे";
            dgv_Bhandwal.Columns["GirviRelease"].HeaderText = "जमा";
            dgv_Bhandwal.Columns["Opening"].HeaderText = "ओपेनिंग रक्कम";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
            lbl_Date.Font=new Font("Arial", sizetext);

            
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            lbl_Date.Text = "तारीख";
            this.Text = "भांडवल";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            lbl_StartDate.Text = "शुरवात तारीख";
            lbl_dates.Text = "तारीख";
            bttn_Close.Text = "बंद";
            bttn_PrintReport.Text = "प्रिंट रिपोर्ट";
            bttn_Opening.Text = "ओपेनिंग";
            bttn_ViewRecord.Text = "रिकॉर्ड देखिये";

            dgv_Bhandwal.Columns["Date"].HeaderText = "तारीख";
            dgv_Bhandwal.Columns["Rokadpan"].HeaderText = "रोकड पान";
            dgv_Bhandwal.Columns["GirviAdded"].HeaderText = "जमा";
            dgv_Bhandwal.Columns["GirviRelease"].HeaderText = "नावे";
            dgv_Bhandwal.Columns["Opening"].HeaderText = "ओपेनिंग रक्कम";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
            lbl_Date.Font = new Font("Arial", sizetext);
        }

        private void bttn_ViewRecord_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Bhandwal.Rows.Clear();
                int count = 0;
                if (dgv_Bhandwal.Rows.Count == 0)
                {
                    dtBhandwal = _objGirviCommon.getOpeningBhandwal();

                    if (dtBhandwal.Rows.Count == 0)
                    {
                        count = 0;

                    }
                    else
                    {
                        dgv_Bhandwal.Rows.Add(dtBhandwal.Rows[0]["Date"].ToString(), "", "", "", dtBhandwal.Rows[0]["Bhandval"].ToString());
                        count = 1;

                    }

                }
                if (count == 1)
                {
                   
                    int j = 0;
                    for (int i = 0; i <= (Convert.ToDateTime(dtp_date.Text) - Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString())).TotalDays; i++)
                    {
                        double dtBhandwalnew = _objGirviCommon.getAddgirviondate(Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtBhandwalnew1 = _objGirviCommon.getAddreleaseondate(Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        // string opening = ((Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["opening"].Value.ToString()) - Convert.ToDouble(dtBhandwalnew)) + Convert.ToDouble(dtBhandwalnew1)).ToString();
                        double previousvalue = Convert.ToDouble(dgv_Bhandwal.Rows[(i + 1) - 1].Cells["opening"].Value.ToString());
                    
                        string paan = _objGirviCommon.getPageNumber(Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString()).AddDays(j).ToShortDateString());
                       
                        dgv_Bhandwal.Rows.Add(Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString()).AddDays(j).ToShortDateString(), paan, dtBhandwalnew, dtBhandwalnew1, (previousvalue + Convert.ToDouble(dtBhandwalnew) - Convert.ToDouble(dtBhandwalnew1)).ToString());

                        //}
                        j++;
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("Opening Bhandwal is not entered");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttn_PrintReport_Click(object sender, EventArgs e)
        {
           
            DataTable data = val.DataGridView2DataTable(dgv_Bhandwal, "table");

            int start = 0, end = 0;
            for (int i = 0; i < dgv_Bhandwal.Rows.Count; i++)
            {
                if (data.Rows[i]["Date"].ToString() == dtp_StartDate.Text)
                {
                    start = i;
                }
                if (data.Rows[i]["Date"].ToString() == dtp_EndDate.Text)
                {
                    end = i;
                }
            }

            DataTable dataNew = val.DataGridView2DataTable(dgv_Bhandwal, "table");
            dataNew.Rows.Clear();

            int j = 0;
            for (int i = start - 1; i < data.Rows.Count; i++)
            {
                dataNew.Rows.Add();
                dataNew.Rows[j]["Date"] = data.Rows[i]["Date"].ToString();
                dataNew.Rows[j]["RokadPan"] = data.Rows[i]["RokadPan"].ToString();
                dataNew.Rows[j]["GirviAdded"] = data.Rows[i]["GirviAdded"].ToString();
                dataNew.Rows[j]["GirviRelease"] = data.Rows[i]["GirviRelease"].ToString();
                dataNew.Rows[j]["Opening"] = data.Rows[i]["Opening"].ToString();
                j++;
            }
            dataNew.Rows[0]["Date"] = "";
            dataNew.Rows[0]["RokadPan"] = "";
            dataNew.Rows[0]["GirviAdded"] = "";
            dataNew.Rows[0]["GirviRelease"] = "";

            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataBhandval);
            if (rbt_OtherTrue.Checked == true)
            {
                _obj(dataNew, dtp_EndDate.Text,true);
            }
            else
            {
                _obj(dataNew, dtp_EndDate.Text,false);

            }
            _objfrm_ReportViewer.Show();
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            lbl_Date.Text = "तारीख";
            this.Text = "भांडवल";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_dates.Text = "तारीख";
            bttn_Close.Text = "बंद";
            bttn_PrintReport.Text = "प्रिंट रिपोर्ट";
            bttn_Opening.Text = "ओपेनिंग";
            bttn_ViewRecord.Text = "रिकॉर्ड बघा";

            dgv_Bhandwal.Columns["Date"].HeaderText = "तारीख";
            dgv_Bhandwal.Columns["Rokadpan"].HeaderText = "रोकड पान";
            dgv_Bhandwal.Columns["GirviAdded"].HeaderText = "जमा";
            dgv_Bhandwal.Columns["GirviRelease"].HeaderText = "नावे";
            dgv_Bhandwal.Columns["Opening"].HeaderText = "ओपेनिंग रक्कम";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
            lbl_Date.Font = new Font("Arial", sizetext);
        }

        private void dtp_date_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_StartDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_EndDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void bttn_Opening_Click(object sender, EventArgs e)
        {
            Common.Opening_Value _obj = new Common.Opening_Value();
            _obj.ShowDialog();
        }

        private void lbl_StartDate_Click(object sender, EventArgs e)
        {

        }

        private void lbl_EndDate_Click(object sender, EventArgs e)
        {

        }

        private void dtp_StartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_EndDate_ValueChanged(object sender, EventArgs e)
        {

        }

       
    
    }
}
