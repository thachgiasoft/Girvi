using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JewelleryManagement.CrystalReport;
using BAL.Common;
using BAL.Girvi;
using BAL.Reports.Girvi;
using BAL;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class Frm_MonthsWiseNoticeReport : Form
    {
        PrinterSetting oPrintersetting = new PrinterSetting();
        clsCommon _objCommon = new clsCommon();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        Validation val = new Validation();
        KhatawaniWithGirviBAL _objKhatwaniWithGirviBal = new KhatawaniWithGirviBAL();
        clsKhatawaniGirviRecord _objKhatawaniGiviRecord = new clsKhatawaniGirviRecord();


        public delegate void SendData(DataTable dtData, bool Other);
        public delegate void SendDataNotice(string BillNO, string AccNo, string otherFont, string PrinterName);
        public delegate void SendDataMonthwise();
        double sum = 0;
        double EkunRakkam = 0;
        String KhatawaniNoDGV = "";


        public Frm_MonthsWiseNoticeReport()
        {
            InitializeComponent();
        }

        private void Frm_SixMonthsReport_Load(object sender, EventArgs e)
        {
            rbt_sixmonth.Select();
            // rbt_sixmonth.Focus();
            fillgrid();

        }
        private void fillgrid()
        {

            try
            {

                dgv_SixMonthReport.Rows.Clear();
                int i = 0;
                DataTable dtkhatawani = _objKhatwaniWithGirviBal.getExpiredGirviDetails();
                for (i = 0; i < dtkhatawani.Rows.Count; i++)
                {
                    string ExpireDate = Convert.ToDateTime(dtkhatawani.Rows[i]["Date_of_deposit"].ToString()).AddMonths(6).ToString();
                    int result = DateTime.Compare(Convert.ToDateTime(ExpireDate), Convert.ToDateTime(dtp_Date.Text));
                    if (result < 0)
                    {
                        string days = ((Convert.ToDateTime(dtp_Date.Text) - Convert.ToDateTime(dtkhatawani.Rows[i]["Date_of_deposit"].ToString())).TotalDays).ToString();
                        string vaj = _objGirviCommon.Interest(dtkhatawani.Rows[i]["Amount"].ToString(), dtkhatawani.Rows[i]["interset_rate"].ToString(), days);
                        // sum = sum + Convert.ToDouble( vaj);
                        string totalamount = (Convert.ToDecimal(dtkhatawani.Rows[i]["Amount"]) + Convert.ToDecimal(vaj)).ToString();
                        dgv_SixMonthReport.Rows.Add(false, i + 1, dtkhatawani.Rows[i]["khatawani_No"].ToString(), dtkhatawani.Rows[i]["GirviRecordNo"].ToString(), dtkhatawani.Rows[i]["FullName"].ToString(), dtkhatawani.Rows[i]["Contact_No"].ToString(), dtkhatawani.Rows[i]["Address"].ToString(), dtkhatawani.Rows[i]["Amount"].ToString(), dtkhatawani.Rows[i]["Date_of_deposit"].ToString(), dtkhatawani.Rows[i]["duration"].ToString(), dtkhatawani.Rows[i]["interset_rate"].ToString(), vaj, totalamount, dtkhatawani.Rows[i]["PageNo"].ToString(), dtkhatawani.Rows[i]["NSN"].ToString());
                    }

                }


                sum = _objCommon.sumGridViewColumn(dgv_SixMonthReport, "IntrestAmount");
                EkunRakkam = _objCommon.sumGridViewColumn(dgv_SixMonthReport, "TotalAmount");
                dgv_SixMonthReport.Rows.Add(false, "", "", "", "", "", "", "", "", "", "Total", sum.ToString(), EkunRakkam.ToString(), "", "");
                dgv_SixMonthReport.Rows[dgv_SixMonthReport.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                dgv_SixMonthReport.Rows[dgv_SixMonthReport.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ThreeMonths()
        {

            try
            {

                dgv_SixMonthReport.Rows.Clear();
                int i = 0;
                DataTable dtkhatawani = _objKhatwaniWithGirviBal.getExpiredGirviDetails();
                for (i = 0; i < dtkhatawani.Rows.Count; i++)
                {
                    string ExpireDate = Convert.ToDateTime(dtkhatawani.Rows[i]["Date_of_deposit"].ToString()).AddMonths(3).ToString();
                    int result = DateTime.Compare(Convert.ToDateTime(ExpireDate), Convert.ToDateTime(dtp_Date.Text));
                    if (result < 0)
                    {
                        string days = ((Convert.ToDateTime(dtp_Date.Text) - Convert.ToDateTime(dtkhatawani.Rows[i]["Date_of_deposit"].ToString())).TotalDays).ToString();
                        string vaj = _objGirviCommon.Interest(dtkhatawani.Rows[i]["Amount"].ToString(), dtkhatawani.Rows[i]["interset_rate"].ToString(), days);
                        // sum = sum + Convert.ToDouble( vaj);
                        string totalamount = (Convert.ToDecimal(dtkhatawani.Rows[i]["Amount"]) + Convert.ToDecimal(vaj)).ToString();
                        dgv_SixMonthReport.Rows.Add(false, i + 1, dtkhatawani.Rows[i]["khatawani_No"].ToString(), dtkhatawani.Rows[i]["GirviRecordNo"].ToString(), dtkhatawani.Rows[i]["FullName"].ToString(), dtkhatawani.Rows[i]["Contact_No"].ToString(), dtkhatawani.Rows[i]["Address"].ToString(), dtkhatawani.Rows[i]["Amount"].ToString(), dtkhatawani.Rows[i]["Date_of_deposit"].ToString(), dtkhatawani.Rows[i]["duration"].ToString(), dtkhatawani.Rows[i]["interset_rate"].ToString(), vaj, totalamount, dtkhatawani.Rows[i]["PageNo"].ToString(), dtkhatawani.Rows[i]["NSN"].ToString());
                    }

                }


                sum = _objCommon.sumGridViewColumn(dgv_SixMonthReport, "IntrestAmount");
                EkunRakkam = _objCommon.sumGridViewColumn(dgv_SixMonthReport, "TotalAmount");
                dgv_SixMonthReport.Rows.Add(false, "", "", "", "", "", "", "", "", "", "Total", sum.ToString(), EkunRakkam.ToString(), "", "");
                dgv_SixMonthReport.Rows[dgv_SixMonthReport.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                dgv_SixMonthReport.Rows[dgv_SixMonthReport.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void NineMonths()
        {

            try
            {

                dgv_SixMonthReport.Rows.Clear();
                int i = 0;
                DataTable dtkhatawani = _objKhatwaniWithGirviBal.getExpiredGirviDetails();
                for (i = 0; i < dtkhatawani.Rows.Count; i++)
                {
                    string ExpireDate = Convert.ToDateTime(dtkhatawani.Rows[i]["Date_of_deposit"].ToString()).AddMonths(9).ToString();
                    int result = DateTime.Compare(Convert.ToDateTime(ExpireDate), Convert.ToDateTime(dtp_Date.Text));
                    if (result < 0)
                    {
                        string days = ((Convert.ToDateTime(dtp_Date.Text) - Convert.ToDateTime(dtkhatawani.Rows[i]["Date_of_deposit"].ToString())).TotalDays).ToString();
                        string vaj = _objGirviCommon.Interest(dtkhatawani.Rows[i]["Amount"].ToString(), dtkhatawani.Rows[i]["interset_rate"].ToString(), days);
                        // sum = sum + Convert.ToDouble( vaj);
                        string totalamount = (Convert.ToDecimal(dtkhatawani.Rows[i]["Amount"]) + Convert.ToDecimal(vaj)).ToString();
                        dgv_SixMonthReport.Rows.Add(false, i + 1, dtkhatawani.Rows[i]["khatawani_No"].ToString(), dtkhatawani.Rows[i]["GirviRecordNo"].ToString(), dtkhatawani.Rows[i]["FullName"].ToString(), dtkhatawani.Rows[i]["Contact_No"].ToString(), dtkhatawani.Rows[i]["Address"].ToString(), dtkhatawani.Rows[i]["Amount"].ToString(), dtkhatawani.Rows[i]["Date_of_deposit"].ToString(), dtkhatawani.Rows[i]["duration"].ToString(), dtkhatawani.Rows[i]["interset_rate"].ToString(), vaj, totalamount, dtkhatawani.Rows[i]["PageNo"].ToString(), dtkhatawani.Rows[i]["NSN"].ToString());
                    }

                }


                sum = _objCommon.sumGridViewColumn(dgv_SixMonthReport, "IntrestAmount");
                EkunRakkam = _objCommon.sumGridViewColumn(dgv_SixMonthReport, "TotalAmount");
                dgv_SixMonthReport.Rows.Add(false, "", "", "", "", "", "", "", "", "", "Total", sum.ToString(), EkunRakkam.ToString(), "", "");
                dgv_SixMonthReport.Rows[dgv_SixMonthReport.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                dgv_SixMonthReport.Rows[dgv_SixMonthReport.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void twelthMonths()
        {
            try
            {

                dgv_SixMonthReport.Rows.Clear();
                int i = 0;
                DataTable dtkhatawani = _objKhatwaniWithGirviBal.getExpiredGirviDetails();
                for (i = 0; i < dtkhatawani.Rows.Count; i++)
                {
                    string ExpireDate = Convert.ToDateTime(dtkhatawani.Rows[i]["Date_of_deposit"].ToString()).AddMonths(12).ToString();
                    int result = DateTime.Compare(Convert.ToDateTime(ExpireDate), Convert.ToDateTime(dtp_Date.Text));
                    if (result < 0)
                    {
                        string days = ((Convert.ToDateTime(dtp_Date.Text) - Convert.ToDateTime(dtkhatawani.Rows[i]["Date_of_deposit"].ToString())).TotalDays).ToString();
                        string vaj = _objGirviCommon.Interest(dtkhatawani.Rows[i]["Amount"].ToString(), dtkhatawani.Rows[i]["interset_rate"].ToString(), days);
                        // sum = sum + Convert.ToDouble( vaj);
                        string totalamount = (Convert.ToDecimal(dtkhatawani.Rows[i]["Amount"]) + Convert.ToDecimal(vaj)).ToString();
                        dgv_SixMonthReport.Rows.Add(false, i + 1, dtkhatawani.Rows[i]["khatawani_No"].ToString(), dtkhatawani.Rows[i]["GirviRecordNo"].ToString(), dtkhatawani.Rows[i]["FullName"].ToString(), dtkhatawani.Rows[i]["Contact_No"].ToString(), dtkhatawani.Rows[i]["Address"].ToString(), dtkhatawani.Rows[i]["Amount"].ToString(), dtkhatawani.Rows[i]["Date_of_deposit"].ToString(), dtkhatawani.Rows[i]["duration"].ToString(), dtkhatawani.Rows[i]["interset_rate"].ToString(), vaj, totalamount, dtkhatawani.Rows[i]["PageNo"].ToString(), dtkhatawani.Rows[i]["NSN"].ToString());
                    }

                }


                sum = _objCommon.sumGridViewColumn(dgv_SixMonthReport, "IntrestAmount");
                EkunRakkam = _objCommon.sumGridViewColumn(dgv_SixMonthReport, "TotalAmount");
                dgv_SixMonthReport.Rows.Add(false, "", "", "", "", "", "", "", "", "", "Total", sum.ToString(), EkunRakkam.ToString(), "", "");
                dgv_SixMonthReport.Rows[dgv_SixMonthReport.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                dgv_SixMonthReport.Rows[dgv_SixMonthReport.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void Frm_SixMonthsReport_KeyDown(object sender, KeyEventArgs e)
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


            this.Text = "सहा महिन्यांची रिकॉर्ड";
            lbl_Date.Text = "तारीख";


            dgv_SixMonthReport.Columns["SrNo"].HeaderText = "क्र.";
            dgv_SixMonthReport.Columns["KhatawaniNo"].HeaderText = "खतावणी क्र.";
            dgv_SixMonthReport.Columns["CName"].HeaderText = "नाव.";
            dgv_SixMonthReport.Columns["ContactNo"].HeaderText = "संपर्क क्र.";

            dgv_SixMonthReport.Columns["Address"].HeaderText = "पत्ता";
            dgv_SixMonthReport.Columns["Amount"].HeaderText = "रक्कम";

            dgv_SixMonthReport.Columns["DateOfDeposit"].HeaderText = "ठेव तारीख";

            dgv_SixMonthReport.Columns["Duration"].HeaderText = "कालावधी";

            dgv_SixMonthReport.Columns["IntrestRate"].HeaderText = "व्याज दर";
            dgv_SixMonthReport.Columns["IntrestAmount"].HeaderText = "व्याज रक्कम ";
            dgv_SixMonthReport.Columns["TotalAmount"].HeaderText = "एकूण रक्कम";
            dgv_SixMonthReport.Columns["PavtiNo"].HeaderText = "पावती नं";

        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {

            this.Text = "छह महीनेका रिकॉर्ड";
            lbl_Date.Text = "तारीख";


            dgv_SixMonthReport.Columns["SrNo"].HeaderText = "क्र.";
            dgv_SixMonthReport.Columns["KhatawaniNo"].HeaderText = "खतावणी क्र.";
            dgv_SixMonthReport.Columns["CName"].HeaderText = "नाम";
            dgv_SixMonthReport.Columns["ContactNo"].HeaderText = "संपर्क क्र.";

            dgv_SixMonthReport.Columns["Address"].HeaderText = "पता";

            dgv_SixMonthReport.Columns["Amount"].HeaderText = "रक्कम";

            dgv_SixMonthReport.Columns["DateOfDeposit"].HeaderText = "जमा की तारीख";

            dgv_SixMonthReport.Columns["Duration"].HeaderText = "अवधि";

            dgv_SixMonthReport.Columns["IntrestRate"].HeaderText = "ब्याज दर";
            dgv_SixMonthReport.Columns["IntrestAmount"].HeaderText = "ब्याज रक्कम ";
            dgv_SixMonthReport.Columns["TotalAmount"].HeaderText = "एकूण रक्कम";
            dgv_SixMonthReport.Columns["PavtiNo"].HeaderText = "पावती नं";

        }

        private void rbt_English_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Six Month Report";
            lbl_Date.Text = "Date";


            dgv_SixMonthReport.Columns["SrNo"].HeaderText = "Sr No";
            dgv_SixMonthReport.Columns["KhatawaniNo"].HeaderText = "Khatawani No.";
            dgv_SixMonthReport.Columns["CName"].HeaderText = "Name";
            dgv_SixMonthReport.Columns["ContactNo"].HeaderText = "Contact No";

            dgv_SixMonthReport.Columns["Address"].HeaderText = "Address";

            dgv_SixMonthReport.Columns["Amount"].HeaderText = "Amount";

            dgv_SixMonthReport.Columns["DateOfDeposit"].HeaderText = "Date Of Deposit";

            dgv_SixMonthReport.Columns["Duration"].HeaderText = "Duration";

            dgv_SixMonthReport.Columns["IntrestRate"].HeaderText = "Intrest Rate";
            dgv_SixMonthReport.Columns["IntrestAmount"].HeaderText = "Intrest Amount ";
            dgv_SixMonthReport.Columns["TotalAmount"].HeaderText = "Total Amount";
            dgv_SixMonthReport.Columns["PavtiNo"].HeaderText = "Pavti No";
        }

        private void rbt_threemonths_CheckedChanged(object sender, EventArgs e)
        {
            ThreeMonths();
        }

        private void rbt_ninemonths_CheckedChanged(object sender, EventArgs e)
        {
            NineMonths();
        }

        private void rbt_12months_CheckedChanged(object sender, EventArgs e)
        {
            twelthMonths();
        }

        private void rbt_sixmonth_CheckedChanged(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void cmb_VillageName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fillGirviData();

                // lst_FullName.Visible = false;

            }
        }

        private void fillGirviData()
        {
            dgv_SixMonthReport.Rows.Clear();

            DataTable dtCustomer = _objGirviCommon.getKhatawaniByAddress(cmb_VillageName.Text);

        }

        private void cmb_VillageName_TextChanged(object sender, EventArgs e)
        {

            if (cmb_VillageName.Text != "")
            {

                DataTable dtCustomer = _objGirviCommon.getKhatawaniByAddress(cmb_VillageName.Text);
                if (lst_FullName.Items.Count > 0)
                {
                    lst_FullName.Visible = true;
                }
                lst_FullName.DisplayMember = "FullName";
                lst_FullName.ValueMember = "FullName";
            }
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            DataTable data = val.DataGridView2DataTable(dgv_SixMonthReport, "table");
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveSixMonth);
            _obj(data, false);
            _objfrm_ReportViewer.ShowDialog();
        }

        private void bttn_monthwiseReport_Click(object sender, EventArgs e)
        {
            if (oPrintersetting.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRow dtr in _objCommon.DataGridView2DataTableSelected(dgv_SixMonthReport, "table").Rows)
                {
                    try
                    {
                        frm_ReportViewer _objfrm_ReportViewer = new frm_ReportViewer();
                        SendDataNotice _obj = new SendDataNotice(_objfrm_ReportViewer.ReceiveDataNotice);
                        _obj(dtr["GirviRecordNo"].ToString(), dtr["KhatawaniNo"].ToString().Trim(), "Other", oPrintersetting.PrinterName);
                        _objfrm_ReportViewer.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (rbt_threemonths.Checked == true)
                { ThreeMonths(); }

                else if (rbt_sixmonth.Checked == true)
                { fillgrid(); }

                else if (rbt_ninemonths.Checked == true)
                { NineMonths(); }

                else
                { twelthMonths(); }
            }

            else
            { }

        }

        private void rbn_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_SixMonthReport.Rows.Count - 1; i++)
            {
                dgv_SixMonthReport.Rows[i].Cells["Select"].Value = true;
            }
        }

        private void rbn_CustomSelect_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_SixMonthReport.Rows.Count; i++)
            {
                dgv_SixMonthReport.Rows[i].Cells["Select"].Value = false;
            }
        }
    }
}