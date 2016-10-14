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
using System.Drawing.Text;
using BAL;
using BAL.Common;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_ForwordGirvi : Form
    {
        clsGirviReport _objGirviReport = new clsGirviReport();
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        public delegate void SendData(DataTable dtData,string startdate,string enddate,bool other);
        Validation val = new Validation();
        clsGirviCommon _objCommon = new clsGirviCommon();

        public frm_ForwordGirvi()
        {
            InitializeComponent();
        }

        private void frm_ForwordGirvi_KeyDown(object sender, KeyEventArgs e)
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

        private void frm_ForwordGirvi_Load(object sender, EventArgs e)
        {
            SetFont();
            MasterClear();
        }
        public void ShivajiFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
                //dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //dtp_StartDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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
        }

        private void SetFont()
        {
            ShivajiFont();
        }

        private void MasterClear()
        {
            FillGrid();
        }

        private void FillGrid()
        {
            dgv_GirviDetail.Rows.Clear();
            DataTable dt = _objGirviReport.getForwordGirviData(dtp_StartDate.Text,dtp_EndDate.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataTable dt1 = _objGirviAdd.getKhatawaniByKhatawaniNo(dt.Rows[i]["khatawani_No"].ToString());
                if (dt.Rows[i]["Forwarded_to"].ToString() != "")
                {
                    
                    string j = ((Convert.ToDateTime(dtp_Date.Text) - Convert.ToDateTime(dt.Rows[i]["Date_of_Forward"].ToString())).TotalDays).ToString();
                    string vyaj = _objCommon.InterestFoorward(dt.Rows[i]["forwardamount"].ToString(), dt.Rows[i]["Interest"].ToString(), j);
                    string Amount = (Convert.ToDecimal(dt.Rows[i]["forwardamount"]) + Convert.ToDecimal(vyaj)).ToString();
                    dgv_GirviDetail.Rows.Add(dt.Rows[i]["GirviRecordNo"].ToString(), dt.Rows[i]["Date_of_deposit"].ToString(), dt1.Rows[0]["FullName"].ToString(), dt1.Rows[0]["Contact_No"].ToString(), dt1.Rows[0]["Address"].ToString(), dt.Rows[i]["Date_of_Forward"].ToString(), dt.Rows[i]["Forwarded_to"].ToString(), dt.Rows[i]["ForwardCno"].ToString(), dt.Rows[i]["forwardamount"].ToString(), dt.Rows[i]["Interest"].ToString(), j, vyaj, Amount);
                }
            }
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "तारीख";
            this.Text = "फॉरवर्ड रिपोर्ट";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_StartDate.Text = "सुरवात तारीख";
            bttn_Close.Text = "बंद";
            bttn_ForwordReport.Text = "फॉरवर्ड रिपोर्ट";

            dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "ठेव तारीख";
            dgv_GirviDetail.Columns["GirviNo"].HeaderText = "गाहनी क्र.";
            dgv_GirviDetail.Columns["KhatawaniName"].HeaderText = "खतावणी नाव";
            dgv_GirviDetail.Columns["ContactNo"].HeaderText = "संपर्क क्र.";
            dgv_GirviDetail.Columns["Address"].HeaderText = "पत्ता";
            dgv_GirviDetail.Columns["DateOfForword"].HeaderText = "फॉरवर्ड तारीख";
            dgv_GirviDetail.Columns["ForwordTo"].HeaderText = "फॉरवर्ड To";
            dgv_GirviDetail.Columns["forwardamount"].HeaderText = "फॉरवर्ड रक्कम";
            dgv_GirviDetail.Columns["ForwordContactNo"].HeaderText = "फॉरवर्ड संपर्क क्र.";
            dgv_GirviDetail.Columns["Interest"].HeaderText = "व्याज";
            dgv_GirviDetail.Columns["Days"].HeaderText = "दिवस";
            dgv_GirviDetail.Columns["TotalAmount"].HeaderText = "पूर्ण रक्कम";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "तारीख";
            this.Text = "फॉरवर्ड रिपोर्ट";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            lbl_StartDate.Text = "शुरवात तारीख";
            bttn_Close.Text = "बंद";
            bttn_ForwordReport.Text = "फॉरवर्ड रिपोर्ट";

            dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "रखनेकी तारीख";
            dgv_GirviDetail.Columns["GirviNo"].HeaderText = "गिरवी क्र.";
            dgv_GirviDetail.Columns["KhatawaniName"].HeaderText = "खतावणी नाम";
            dgv_GirviDetail.Columns["ContactNo"].HeaderText = "संपर्क क्र.";
            dgv_GirviDetail.Columns["Address"].HeaderText = "पत्ता";
            dgv_GirviDetail.Columns["DateOfForword"].HeaderText = "फॉरवर्ड तारीख";
            dgv_GirviDetail.Columns["ForwordTo"].HeaderText = "फॉरवर्ड To";
            dgv_GirviDetail.Columns["forwardamount"].HeaderText = "फॉरवर्ड रक्कम";
            dgv_GirviDetail.Columns["ForwordContactNo"].HeaderText = "फॉरवर्ड संपर्क क्र.";
            dgv_GirviDetail.Columns["Interest"].HeaderText = "व्याज";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void bttn_ForwordReport_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_Dates.Text = "तारीख";
            this.Text = "फॉरवर्ड रिपोर्ट";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_StartDate.Text = "सुरवात तारीख";
            bttn_Close.Text = "बंद";
            bttn_ForwordReport.Text = "फॉरवर्ड रिपोर्ट";

            dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "ठेव तारीख";
            dgv_GirviDetail.Columns["GirviNo"].HeaderText = "गाहनी क्र.";
            dgv_GirviDetail.Columns["KhatawaniName"].HeaderText = "खतावणी नाव";
            dgv_GirviDetail.Columns["ContactNo"].HeaderText = "संपर्क क्र.";
            dgv_GirviDetail.Columns["Address"].HeaderText = "पत्ता";
            dgv_GirviDetail.Columns["DateOfForword"].HeaderText = "फॉरवर्ड तारीख";
            dgv_GirviDetail.Columns["ForwordTo"].HeaderText = "फॉरवर्ड To";
            dgv_GirviDetail.Columns["forwardamount"].HeaderText = "फॉरवर्ड रक्कम";
            dgv_GirviDetail.Columns["ForwordContactNo"].HeaderText = "फॉरवर्ड संपर्क क्र.";
            dgv_GirviDetail.Columns["Interest"].HeaderText = "व्याज";
            lbl_StartDate.Font = new Font("Arial", sizetext);
            lbl_EndDate.Font = new Font("Arial", sizetext);
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            DataTable data = val.DataGridView2DataTable(dgv_GirviDetail, "table");
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataForwardGirvi);
            if (rbt_OtherTrue.Checked == true)
            {
                _obj(data, dtp_StartDate.Text, dtp_EndDate.Text,true);
            }
            else
            {
                _obj(data, dtp_StartDate.Text, dtp_EndDate.Text,false);

            }
            _objfrm_ReportViewer.Show();
        }

        private void dtp_StartDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_EndDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void pnl_LanguageOther_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
