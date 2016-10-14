using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Girvi;
using BAL.Common;

namespace JewelleryManagement.Girvi
{
    public partial class Frm_ReleaseWithNewAdd : Form
    {
        cls_GirviRelease _objGirviRelease = new cls_GirviRelease();
        clsGirviCommon _objCommon = new clsGirviCommon();
        string loanamt, int_rate, no_of_days, KhNo, GnNo, DateOfDeposite, Actual_int_rate, interset_rate, purpose_of_loan, comment, receipt_no, reason, loantype;
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        ClsFinancialYear _onjFinancialYear = new ClsFinancialYear();

        public Frm_ReleaseWithNewAdd()
        {
            InitializeComponent();
        }
        public Frm_ReleaseWithNewAdd(string KhatawaniNo, string GirviNo)
        {
            InitializeComponent();
            txt_khatawaniNo.Text = KhatawaniNo;
            txt_Srno.Text = GirviNo;
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ReleaseWithNewAdd_Load(object sender, EventArgs e)
        {
            MasterClear();
        }

        private void MasterClear()
        {
            FillGrid();
            FillTextBoxes();
        }

        private void FillTextBoxes()
        {
            DataTable dt = _objGirviRelease.getGirviDataForNewAdd(txt_khatawaniNo.Text, txt_Srno.Text);
            purpose_of_loan = dt.Rows[0]["purpose_of_loan"].ToString();
            comment = dt.Rows[0]["comment"].ToString();
            receipt_no = dt.Rows[0]["receipt_no"].ToString();
            reason = dt.Rows[0]["reason"].ToString();
            loantype = dt.Rows[0]["loantype"].ToString();
            loanamt = dt.Rows[0]["Amount"].ToString();
            int_rate = dt.Rows[0][3].ToString();
            Actual_int_rate = dt.Rows[0]["Actual_InterestRate"].ToString();
            DateOfDeposite = dt.Rows[0][2].ToString();
            no_of_days = ((Convert.ToDateTime(dtp_DateOfRelease.Text) - Convert.ToDateTime(dt.Rows[0][2].ToString())).TotalDays).ToString();
            txt_DepositDays.Text = no_of_days;
            //txt_InterestAmount.Text = (Convert.ToDouble(loanamt) + Convert.ToDouble(interset())).ToString();
            dtp_Duration.Value = dtp_DateOfRelease.Value.AddMonths(6);
            txt_Loanamount.Text = loanamt;
            txt_InterestAmount.Text = _objCommon.Interest(txt_Loanamount.Text, dt.Rows[0]["interset_rate"].ToString(), no_of_days);

        }

        private void FillGrid()
        {
            DataTable dt = _objGirviRelease.getGirviData(txt_Srno.Text);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_ItemDetail.Rows.Add(dt.Rows[i]["GirviNo"].ToString(), dt.Rows[i]["metal_type"].ToString(), dt.Rows[i]["metal_type"].ToString(), dt.Rows[i]["item_type"].ToString(), dt.Rows[i]["item_type"].ToString(), dt.Rows[i]["gross_wt"].ToString(), dt.Rows[i]["reduce_wt"].ToString(), dt.Rows[i]["net_wt"].ToString(), dt.Rows[i]["Total_Quantity"].ToString(), dt.Rows[i]["wt_in_percent"].ToString(), dt.Rows[i]["fine_wt"].ToString(), dt.Rows[i]["current_rate"].ToString(), dt.Rows[i]["amount"].ToString());
            }


        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_DateOfRelease_ValueChanged(object sender, EventArgs e)
        {
            dtp_DateOfRelease.Text = dtp_DateOfRelease.Value.ToShortDateString().ToString();
            if (dtp_DateOfRelease.Text != "")// && //.Text != "")
            {
                txt_DepositDays.Text = ((Convert.ToDateTime(dtp_DateOfRelease.Text) - Convert.ToDateTime(DateOfDeposite)).TotalDays).ToString();
                txt_InterestAmount.Text = _objCommon.Interest(txt_Loanamount.Text, int_rate, txt_DepositDays.Text).ToString();
                txt_TotalAmount.Text = (Convert.ToDouble(txt_InterestAmount.Text) + Convert.ToDouble(txt_Loanamount.Text)).ToString();
            }
        }

        private void txt_InterestAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_TotalAmount.Text = (Convert.ToDouble(txt_InterestAmount.Text) + Convert.ToDouble(txt_Loanamount.Text)).ToString();
            }
            catch { }
        }
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();


        private void bttn_Update_Click(object sender, EventArgs e)
        {
           //  string receipt_no;

            if (txt_pavtiNoAdd.Text != "" && txt_pavtiNoRelease.Text != "")
            {

                int finalcialYearId = _onjFinancialYear.getSelectedFinancialYearId();
                string gn = _objGirviAdd.get_InvoiceNo();

                //receipt_no  = _objGirviAdd.getReceiptNo("GRT-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "%");
                //receipt_no = "GRT-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "-" + receipt_no;



                DataTable OldDetails = _objGirviAdd.getGirviByInvoiceNo(txt_Srno.Text);
                string olddetailsdata = OldDetails.Rows[0]["updated_girvi_no"].ToString();
                string newdetails;
                if (OldDetails.Rows[0]["updated_girvi_no"].ToString() != "")
                {
                    newdetails = OldDetails.Rows[0]["updated_girvi_no"].ToString() + "." + OldDetails.Rows[0]["receipt_no"].ToString() + "," + OldDetails.Rows[0]["GirviRecordNo"].ToString() + "," + OldDetails.Rows[0]["Amount"].ToString() + "," + OldDetails.Rows[0]["Date_of_deposit"].ToString();
                }
                else
                {
                    newdetails = OldDetails.Rows[0]["receipt_no"].ToString() + "," + OldDetails.Rows[0]["GirviRecordNo"].ToString() + "," + OldDetails.Rows[0]["Amount"].ToString() + "," + OldDetails.Rows[0]["Date_of_deposit"].ToString();

                }

                //  string receipt_norelease = _objGirviAdd.getReceiptNoRelease("GRS-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "%");
                // receipt_norelease = "GRS-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "-" + receipt_norelease;


                _objGirviRelease.updateGirviMasterData(txt_Srno.Text, gn, dtp_DateOfRelease.Text);
                _objGirviRelease.SetReleasemaster(txt_khatawaniNo.Text, txt_Srno.Text, txt_Loanamount.Text, no_of_days, int_rate, txt_TotalAmount.Text, dtp_DateOfRelease.Text, txt_InterestAmount.Text, txt_pavtiNoRelease.Text, finalcialYearId, "");

                _objGirviAdd.addGirviMaster(gn, txt_khatawaniNo.Text, int_rate, dtp_DateOfRelease.Text, txt_PayAmount.Text, dtp_Duration.Text, newdetails, Actual_int_rate, reason, "", txt_pavtiNoAdd.Text, purpose_of_loan, loantype, finalcialYearId, "");

                DataTable dt = _objGirviRelease.getGirviData(txt_Srno.Text);

                for (int i = 0; i < dgv_ItemDetail.Rows.Count; i++)
                {
                    _objGirviAdd.addGirviItemMaster(gn, dt.Rows[i]["metal_type"].ToString(), dt.Rows[i]["metal_type"].ToString(), dt.Rows[i]["item_type"].ToString(), dt.Rows[i]["gross_wt"].ToString(), dt.Rows[i]["reduce_wt"].ToString(), dt.Rows[i]["net_wt"].ToString(), dt.Rows[i]["wt_in_percent"].ToString(), dt.Rows[i]["fine_wt"].ToString(), dt.Rows[i]["Total_Quantity"].ToString(), dt.Rows[i]["current_rate"].ToString(), dt.Rows[i]["amount"].ToString(), "");
                }

                _objGirviAdd.updateGirviNumber(gn);
                MessageBox.Show("Girvi No: " + txt_Srno.Text + " Updated to " + gn);
                this.Close();
            }
        }

        private void dtp_DateOfRelease_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void dtp_Duration_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_khatawaniNo_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void txt_Srno_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void txt_Loanamount_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_Duration_Enter_1(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void Frm_ReleaseWithNewAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
