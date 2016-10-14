using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Girvi;
using BAL.Reports.Girvi;
using System.Drawing.Text;
using BAL.Common;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_InterestPaid : Form
    {
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        clsGirviReport _objGirviReport = new clsGirviReport();
        clsCommon _objCommon = new clsCommon();
        
        double sum = 0;

        public frm_InterestPaid()
        {
            InitializeComponent();
        }

        private void frm_InterestPaid_Load(object sender, EventArgs e)
        {
            setDateAsFinancialYear();
            SetFont();
            cmb_FullName.DataSource = _objGirviAdd.getFName();
            dgv_InterestPaid.Rows.Clear();
            cmb_FullName.Focus();

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
        public void ShivajiFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
                // dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                cmb_FullName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                // dtp_StartDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                // dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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

        private void frm_InterestPaid_KeyDown(object sender, KeyEventArgs e)
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

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "व्याज पेड";
            grp_Name.Text = "नाव";
            grp_Dates.Text = "दिनांक";
         
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_Name.Text = "नाव";
            bttn_Close.Text = "बंद";
            bttn_Show.Text = "बघा";

            dgv_InterestPaid.Columns["SrNo"].HeaderText = " नं.";
            dgv_InterestPaid.Columns["GirviNo"].HeaderText = "गाहनी नं.";
            dgv_InterestPaid.Columns["Date"].HeaderText = "तारीख";
            dgv_InterestPaid.Columns["Amount"].HeaderText = "रक्कम";

        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "ब्याज पेड";
            grp_Name.Text = "नाव";
            grp_Dates.Text = "दिनांक";
            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "अंतिम तारीख";
            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_Name.Text = "नाम";
            bttn_Close.Text = "बंद";
            bttn_Show.Text = "देखिये";

            dgv_InterestPaid.Columns["SrNo"].HeaderText = "नं.";
            dgv_InterestPaid.Columns["GirviNo"].HeaderText = "गिरवी नं.";
            dgv_InterestPaid.Columns["Date"].HeaderText = "तारीख";
            dgv_InterestPaid.Columns["Amount"].HeaderText = "रक्कम";
        }

        private void bttn_Show_Click(object sender, EventArgs e)
        {
            dgv_InterestPaid.Rows.Clear();
            DataTable dtp = null;
            DataTable dtz = _objGirviAdd.getKhatawaniByName(cmb_FullName.Text);
            dtp = _objGirviAdd.getGirviDetailsByKhatawani(dtz.Rows[0]["khatawani_No"].ToString());

            int q = 0;
            for (int i = 0; i < dtp.Rows.Count; i++)
            {

                DataTable dt = _objGirviReport.getInterestPayTableDetail(dtp_StartDate.Text, dtp_EndDate.Text, dtp.Rows[i]["GirviRecordNo"].ToString());
                for (q = 0; q < dt.Rows.Count; q++)
                {
                    dgv_InterestPaid.Rows.Add(dt.Rows[q][0].ToString(), dt.Rows[q][1].ToString(), dt.Rows[q][2].ToString(), dt.Rows[q][3].ToString());
                    //sum = sum + Convert.ToDouble(dgv_InterestPaid.Rows[q].Cells[3].Value.ToString());
                }
            }
            sum = _objCommon.sumGridViewColumn(dgv_InterestPaid, "Amount");
            dgv_InterestPaid.Rows.Add("", "", "Total", sum.ToString());
            dgv_InterestPaid.Rows[q].DefaultCellStyle.BackColor = Color.Red;
            dgv_InterestPaid.Rows[q].DefaultCellStyle.ForeColor = Color.White;
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
          
            this.Text = "व्याज पेड";
            grp_Name.Text = "नाव";
            grp_Dates.Text = "दिनांक";

            lbl_Date.Text = "तारीख";
            lbl_EndDate.Text = "शेवट तारीख";
            lbl_StartDate.Text = "सुरवात तारीख";
            lbl_Name.Text = "नाव";
            bttn_Close.Text = "बंद";
            bttn_Show.Text = "बघा";

            dgv_InterestPaid.Columns["SrNo"].HeaderText = " नं.";
            dgv_InterestPaid.Columns["GirviNo"].HeaderText = "गाहनी नं.";
            dgv_InterestPaid.Columns["Date"].HeaderText = "तारीख";
            dgv_InterestPaid.Columns["Amount"].HeaderText = "रक्कम";

        }

        private void dtp_StartDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_EndDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void cmb_FullName_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
        }

       
    }
}
