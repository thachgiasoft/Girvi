using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BAL.Girvi;
using BAL.Common;
using System.Drawing.Text;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class Frm_CustomerDetailsByVillageName : Form
    {

        //BLL.MortageUpdateBAL _objMortageUpdateBA = new MortageUpdateBAL();
        Validation val = new Validation();
        cls_GirviUpdate _objGirvi = new cls_GirviUpdate();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        public delegate void SendData(DataTable dtData, bool other);


        public Frm_CustomerDetailsByVillageName()
        {
            InitializeComponent();
        }



        private void Frm_CustomerDetailsByVillageName_Load(object sender, EventArgs e)
        {
            try
            {
                SetFont();

                cmb_VillageName.DataSource = _objGirvi.retrunCustomerAddress();
                cmb_VillageName.SelectedIndex = -1;
                dtp_StartDate.Focus();
            }
            catch { }
        }
        public void ShivajiFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
                // dtp_StartDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                // dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //dtp_InterestDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                cmb_VillageName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_PaidAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_LoanAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_InvoiceNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //cmb_LoanReason.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //cmb_LoanType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //Cmb_MetalType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //Cmb_ItemType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_GrossWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_ReduceWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
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
                lst_FullName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            }
        }


        private void SetFont()
        {
            ShivajiFont();
        }



        private void cmb_VillageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fillGirviData();
        }

        private void fillGirviData()
        {
            try
            {
                dataGridView_GirviDetails.Rows.Clear();
                DataTable dtCustomer = _objGirviCommon.getKhatawaniByAddress(cmb_VillageName.Text);
                DataTable dtGirvi = null;
                int SrNo = 1;
                for (int i = 0; i < dtCustomer.Rows.Count; i++)
                {
                    dtGirvi = _objGirviCommon.getGirviDataByKhatawani(dtCustomer.Rows[i]["khatawani_No"].ToString());
                    for (int j = 0; j < dtGirvi.Rows.Count; j++)
                    {
                        if (dtGirvi.Rows[j]["Status"].ToString() == "Release")
                        {
                            string desc_item = "";
                            double itemamount = 0;
                            double grosswttotal = 0;
                            double amount =  Convert.ToDouble(dtGirvi.Rows[j]["Amount"].ToString());
                            string interest_Amount = _objGirviCommon.getInterestAmount(dtGirvi.Rows[j]["GirviRecordNo"].ToString());
                            double total = amount + Convert.ToDouble(interest_Amount);
                            DataTable dt_girviitem = _objGirvi.getallgirviitems(dtGirvi.Rows[j]["GirviRecordNo"].ToString());
                            for (int k = 0; k < dt_girviitem.Rows.Count; k++)
                            {
                                desc_item = desc_item + dt_girviitem.Rows[k]["metal_type"].ToString() + " " + dt_girviitem.Rows[k]["item_type"].ToString() + " \n";
                                itemamount = itemamount + Convert.ToDouble(dt_girviitem.Rows[k]["amount"].ToString());
                                grosswttotal = grosswttotal + Convert.ToDouble(dt_girviitem.Rows[k]["gross_wt"].ToString());
                            }
                            //dataGridView_GirviDetails.Rows.Add(SrNo, dtGirvi.Rows[j]["FullName"].ToString(), dtGirvi.Rows[j]["Contact_No"].ToString(), dtGirvi.Rows[j]["Address"].ToString(), dtGirvi.Rows[j]["Date_of_deposit"].ToString(), dtGirvi.Rows[j]["GirviRecordNo"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), dtGirvi.Rows[j]["Amount"].ToString(), dtGirvi.Rows[j]["interset_rate"].ToString(), interest_Amount, total, dtGirvi.Rows[j]["duration"].ToString(), dtGirvi.Rows[j]["Status"].ToString(), dtGirvi.Rows[j]["forwardstatus"].ToString(), dtGirvi.Rows[j]["Forwarded_to"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), desc_item, grosswttotal, itemamount, itemamount, dtGirvi.Rows[j]["withdraw_release_date"].ToString());
                            dataGridView_GirviDetails.Rows.Add(SrNo, dtGirvi.Rows[j]["FullName"].ToString(), dtGirvi.Rows[j]["Contact_No"].ToString(), dtGirvi.Rows[j]["Address"].ToString(), dtGirvi.Rows[j]["Date_of_deposit"].ToString(), dtGirvi.Rows[j]["GirviRecordNo"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), Math.Round(Convert.ToDouble(dtGirvi.Rows[j]["Amount"].ToString())), dtGirvi.Rows[j]["interset_rate"].ToString(), Math.Round(Convert.ToDouble(interest_Amount)), Math.Round(Convert.ToDouble(total)), dtGirvi.Rows[j]["duration"].ToString(), dtGirvi.Rows[j]["Status"].ToString(), dtGirvi.Rows[j]["forwardstatus"].ToString(), dtGirvi.Rows[j]["Forwarded_to"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), desc_item, grosswttotal, Math.Round(Convert.ToDouble(itemamount)), Math.Round(Convert.ToDouble(total)), dtGirvi.Rows[j]["withdraw_release_date"].ToString(), "    ---", "    ---", "    ---");
                           
                            SrNo++;
                        }
                        else
                        {
                            string desc_item = "";
                            double itemamount = 0;
                            double grosswttotal = 0;
                            double amount = Convert.ToDouble(dtGirvi.Rows[j]["Amount"].ToString());
                            double interest_rate = Convert.ToDouble(dtGirvi.Rows[j]["interset_rate"].ToString());
                            double no_of_days = (DateTime.Today - Convert.ToDateTime(dtGirvi.Rows[j]["Date_of_deposit"].ToString())).TotalDays;
                            double interest_amount = interest(amount, interest_rate, no_of_days);
                            double total = amount + interest_amount;
                            DataTable dt_girviitem = _objGirvi.getallgirviitems(dtGirvi.Rows[j]["GirviRecordNo"].ToString());
                            for (int k = 0; k < dt_girviitem.Rows.Count; k++)
                            {
                                desc_item = desc_item + dt_girviitem.Rows[k]["metal_type"].ToString() + " " + dt_girviitem.Rows[k]["item_type"].ToString() + " \n";
                                itemamount = itemamount + Convert.ToDouble(dt_girviitem.Rows[k]["amount"].ToString());
                                grosswttotal = grosswttotal + Convert.ToDouble(dt_girviitem.Rows[k]["gross_wt"].ToString());
                            }
                            //dataGridView_GirviDetails.Rows.Add(SrNo, dtGirvi.Rows[j]["FullName"].ToString(), dtGirvi.Rows[j]["Contact_No"].ToString(), dtGirvi.Rows[j]["Address"].ToString(), dtGirvi.Rows[j]["Date_of_deposit"].ToString(), dtGirvi.Rows[j]["GirviRecordNo"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), dtGirvi.Rows[j]["Amount"].ToString(), dtGirvi.Rows[j]["interset_rate"].ToString(), interest_amount, total, dtGirvi.Rows[j]["duration"].ToString(), dtGirvi.Rows[j]["Status"].ToString(), dtGirvi.Rows[j]["forwardstatus"].ToString(), dtGirvi.Rows[j]["Forwarded_to"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), desc_item, grosswttotal, itemamount);
                            dataGridView_GirviDetails.Rows.Add(SrNo, dtGirvi.Rows[j]["FullName"].ToString(), dtGirvi.Rows[j]["Contact_No"].ToString(), dtGirvi.Rows[j]["Address"].ToString(), dtGirvi.Rows[j]["Date_of_deposit"].ToString(), dtGirvi.Rows[j]["GirviRecordNo"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(),Math.Round(Convert.ToDouble(dtGirvi.Rows[j]["Amount"].ToString())), dtGirvi.Rows[j]["interset_rate"].ToString(),Math.Round(Convert.ToDouble( interest_amount)),Math.Round(Convert.ToDouble( total)), dtGirvi.Rows[j]["duration"].ToString(), dtGirvi.Rows[j]["Status"].ToString(), dtGirvi.Rows[j]["forwardstatus"].ToString(), dtGirvi.Rows[j]["Forwarded_to"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), desc_item, grosswttotal,Math.Round(Convert.ToDouble( itemamount)), "---", "---",Math.Round(Convert.ToDouble( dtGirvi.Rows[j]["Amount"].ToString())),Math.Round(Convert.ToDouble(interest_amount)),Math.Round(Convert.ToDouble( total)));
                            
                            SrNo++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private double interest(double amt, double interest_rate, double no_of_days)
        {
            double intAmount = (((amt * interest_rate) / 100) / 30) * no_of_days;
            return Convert.ToDouble(Math.Round(intAmount));
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_CustomerDetailsByVillageName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    this.Close();
            //}
        }

        private void cmb_VillageName_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
            //SendKeys.Send("^(1)");

        }

        private void bttn_print_Click(object sender, EventArgs e)
        {
            DataTable data = val.DataGridView2DataTable(dataGridView_GirviDetails, "table");
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataGirviByAddress);
            if (rbt_OtherTrue.Checked == true)
            {

                _obj(data, true);
            }
            else
            {
                _obj(data, false);

            }
            _objfrm_ReportViewer.Show();
        }

        private void bttn_view_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_GirviDetails.Rows.Clear();
                DataTable dtCustomer = _objGirviCommon.getKhatawaniByAddress(cmb_VillageName.Text);
                DataTable dtGirvi = null;
                int SrNo = 1;
                for (int i = 0; i < dtCustomer.Rows.Count; i++)
                {
                    dtGirvi = _objGirviCommon.getGirviDataByKhatawani(dtCustomer.Rows[i]["khatawani_No"].ToString(), dtp_StartDate.Text, dtp_EndDate.Text);
                    for (int j = 0; j < dtGirvi.Rows.Count; j++)
                    {
                        if (dtGirvi.Rows[j]["Status"].ToString() == "Release")
                        {
                            string desc_item = "";
                            double itemamount = 0;
                            double grosswttotal = 0;
                            double amount = Convert.ToDouble(dtGirvi.Rows[j]["Amount"].ToString());
                            string interest_Amount = _objGirviCommon.getInterestAmount(dtGirvi.Rows[j]["GirviRecordNo"].ToString());
                            double total = amount + Convert.ToDouble(interest_Amount);
                            DataTable dt_girviitem = _objGirvi.getallgirviitems(dtGirvi.Rows[j]["GirviRecordNo"].ToString());
                            for (int k = 0; k < dt_girviitem.Rows.Count; k++)
                            {
                                desc_item = desc_item + dt_girviitem.Rows[k]["metal_type"].ToString() + " " + dt_girviitem.Rows[k]["item_type"].ToString() + " \n";
                                itemamount = itemamount + Convert.ToDouble(dt_girviitem.Rows[k]["amount"].ToString());
                                grosswttotal = grosswttotal + Convert.ToDouble(dt_girviitem.Rows[k]["gross_wt"].ToString());
                            }

                          //  dataGridView_GirviDetails.Rows.Add(SrNo, dtGirvi.Rows[j]["FullName"].ToString(), dtGirvi.Rows[j]["Contact_No"].ToString(), dtGirvi.Rows[j]["Address"].ToString(), dtGirvi.Rows[j]["Date_of_deposit"].ToString(), dtGirvi.Rows[j]["GirviRecordNo"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), dtGirvi.Rows[j]["Amount"].ToString(), dtGirvi.Rows[j]["interset_rate"].ToString(), interest_Amount, total, dtGirvi.Rows[j]["duration"].ToString(), dtGirvi.Rows[j]["Status"].ToString(), dtGirvi.Rows[j]["forwardstatus"].ToString(), dtGirvi.Rows[j]["Forwarded_to"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), desc_item, grosswttotal, itemamount, itemamount, dtGirvi.Rows[j]["withdraw_release_date"].ToString(), "    ---", "    ---", "    ---");
                            dataGridView_GirviDetails.Rows.Add(SrNo, dtGirvi.Rows[j]["FullName"].ToString(), dtGirvi.Rows[j]["Contact_No"].ToString(), dtGirvi.Rows[j]["Address"].ToString(), dtGirvi.Rows[j]["Date_of_deposit"].ToString(), dtGirvi.Rows[j]["GirviRecordNo"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), Math.Round(Convert.ToDouble(dtGirvi.Rows[j]["Amount"].ToString())), dtGirvi.Rows[j]["interset_rate"].ToString(), Math.Round(Convert.ToDouble(interest_Amount)), Math.Round(Convert.ToDouble(total)), dtGirvi.Rows[j]["duration"].ToString(), dtGirvi.Rows[j]["Status"].ToString(), dtGirvi.Rows[j]["forwardstatus"].ToString(), dtGirvi.Rows[j]["Forwarded_to"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), desc_item, grosswttotal, Math.Round(Convert.ToDouble(itemamount)), Math.Round(Convert.ToDouble(total)), dtGirvi.Rows[j]["withdraw_release_date"].ToString(), "    ---", "    ---", "    ---");

                            SrNo++;
                        }
                        else
                        {
                            string desc_item = "";
                            double itemamount = 0;
                            double grosswttotal = 0;
                            double amount = Convert.ToDouble(dtGirvi.Rows[j]["Amount"].ToString());
                            double interest_rate = Convert.ToDouble(dtGirvi.Rows[j]["interset_rate"].ToString());
                            double no_of_days = (Convert.ToDateTime(dtp_InterestDate.Text) - Convert.ToDateTime(dtGirvi.Rows[j]["Date_of_deposit"].ToString())).TotalDays;
                            double interest_amount = interest(amount, interest_rate, no_of_days);
                            double total = amount + interest_amount;
                            DataTable dt_girviitem = _objGirvi.getallgirviitems(dtGirvi.Rows[j]["GirviRecordNo"].ToString());
                            for (int k = 0; k < dt_girviitem.Rows.Count; k++)
                            {
                                desc_item = desc_item + dt_girviitem.Rows[k]["metal_type"].ToString() + " " + dt_girviitem.Rows[k]["item_type"].ToString() + " \n";
                                itemamount = itemamount + Convert.ToDouble(dt_girviitem.Rows[k]["amount"].ToString());
                                grosswttotal = grosswttotal + Convert.ToDouble(dt_girviitem.Rows[k]["gross_wt"].ToString());
                            }
                         //   dataGridView_GirviDetails.Rows.Add(SrNo, dtGirvi.Rows[j]["FullName"].ToString(), dtGirvi.Rows[j]["Contact_No"].ToString(), dtGirvi.Rows[j]["Address"].ToString(), dtGirvi.Rows[j]["Date_of_deposit"].ToString(), dtGirvi.Rows[j]["GirviRecordNo"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), dtGirvi.Rows[j]["Amount"].ToString(), dtGirvi.Rows[j]["interset_rate"].ToString(), interest_amount, total, dtGirvi.Rows[j]["duration"].ToString(), dtGirvi.Rows[j]["Status"].ToString(), dtGirvi.Rows[j]["forwardstatus"].ToString(), dtGirvi.Rows[j]["Forwarded_to"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), desc_item, grosswttotal, itemamount, "---", "---", dtGirvi.Rows[j]["Amount"].ToString(), interest_amount, total);
                         //   dataGridView_GirviDetails.Rows.Add(SrNo, dtGirvi.Rows[j]["FullName"].ToString(), dtGirvi.Rows[j]["Contact_No"].ToString(), dtGirvi.Rows[j]["Address"].ToString(), dtGirvi.Rows[j]["Date_of_deposit"].ToString(), dtGirvi.Rows[j]["GirviRecordNo"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), dtGirvi.Rows[j]["Amount"].ToString(), dtGirvi.Rows[j]["interset_rate"].ToString(), interest_amount, total, dtGirvi.Rows[j]["duration"].ToString(), dtGirvi.Rows[j]["Status"].ToString(), dtGirvi.Rows[j]["forwardstatus"].ToString(), dtGirvi.Rows[j]["Forwarded_to"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), desc_item, grosswttotal, itemamount, "---", "---", dtGirvi.Rows[j]["Amount"].ToString(), interest_amount, total);
                            dataGridView_GirviDetails.Rows.Add(SrNo, dtGirvi.Rows[j]["FullName"].ToString(), dtGirvi.Rows[j]["Contact_No"].ToString(), dtGirvi.Rows[j]["Address"].ToString(), dtGirvi.Rows[j]["Date_of_deposit"].ToString(), dtGirvi.Rows[j]["GirviRecordNo"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), Math.Round(Convert.ToDouble(dtGirvi.Rows[j]["Amount"].ToString())), dtGirvi.Rows[j]["interset_rate"].ToString(), Math.Round(Convert.ToDouble(interest_amount)), Math.Round(Convert.ToDouble(total)), dtGirvi.Rows[j]["duration"].ToString(), dtGirvi.Rows[j]["Status"].ToString(), dtGirvi.Rows[j]["forwardstatus"].ToString(), dtGirvi.Rows[j]["Forwarded_to"].ToString(), dtGirvi.Rows[j]["receipt_no"].ToString(), desc_item, grosswttotal, Math.Round(Convert.ToDouble(itemamount)), "---", "---", Math.Round(Convert.ToDouble(dtGirvi.Rows[j]["Amount"].ToString())), Math.Round(Convert.ToDouble(interest_amount)), Math.Round(Convert.ToDouble(total)));
                           
                            SrNo++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           // fillGirviData();
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            //lbl_Date.Text = "तारीख";
            this.Text = "गिरवी गाव अनुसार";
            lbl_StartingDate.Text = "शुरवात तारीख";
            lbl_EndingDate.Text = "अंतिम तारीख";
            lbl_InterestDate.Text = "व्याज तारीख ";
            lbl_VillageName.Text = "गावाचे नाव";
            dataGridView_GirviDetails.Columns["SrNo"].HeaderText = "नं";
            dataGridView_GirviDetails.Columns["FullName"].HeaderText = "पूर्ण नाव";
            dataGridView_GirviDetails.Columns["ContactNo"].HeaderText = "मोबाइल नं";
            dataGridView_GirviDetails.Columns["Address"].HeaderText = "पत्ता";
            dataGridView_GirviDetails.Columns["DateOfDeposit"].HeaderText = "व्याज तारीख";
            dataGridView_GirviDetails.Columns["GirviNo"].HeaderText = "गिरवी नं";
            dataGridView_GirviDetails.Columns["ReceiptNo"].HeaderText = "रिसीप्त तारीख";
            dataGridView_GirviDetails.Columns["Amount"].HeaderText = "एकून";
            dataGridView_GirviDetails.Columns["Column12"].HeaderText = "व्याज दर";
            dataGridView_GirviDetails.Columns["InterestAmount"].HeaderText = "व्याज मूल्य ";
            dataGridView_GirviDetails.Columns["ekun"].HeaderText = "एकून";
            dataGridView_GirviDetails.Columns["Column13"].HeaderText = "कालावधी";
            dataGridView_GirviDetails.Columns["Column14"].HeaderText = "स्थीती";
            dataGridView_GirviDetails.Columns["Forward"].HeaderText = "फोरवर्ड";
            dataGridView_GirviDetails.Columns["Column20"].HeaderText = "फोरवर्ड टू";
            dataGridView_GirviDetails.Columns["receipt_no"].HeaderText = "रिसीप्त नं";
            dataGridView_GirviDetails.Columns["itemdes"].HeaderText = "माहिती";
            dataGridView_GirviDetails.Columns["itemwt"].HeaderText = "वजन";
            dataGridView_GirviDetails.Columns["itemamt"].HeaderText = "वस्तू मूल्य";
            lbl_StartingDate.Font = new Font("Arial", sizetext);
            lbl_EndingDate.Font = new Font("Arial", sizetext);
            lbl_InterestDate.Font = new Font("Arial", sizetext);
            lbl_VillageName.Font = new Font("Arial", sizetext);
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            //lbl_Date.Text = "तारीख";
            this.Text = "गिरवी माहिती गाव प्रमाणे";
            lbl_StartingDate.Text = "शुरवात तारीख";
            lbl_EndingDate.Text = "अंतिम तारीख";
            lbl_InterestDate.Text = "व्याज तारीख ";
            lbl_VillageName.Text = "गावाचे नाव";
            dataGridView_GirviDetails.Columns["SrNo"].HeaderText = "नं";
            dataGridView_GirviDetails.Columns["FullName"].HeaderText = "पूर्ण नाव";
            dataGridView_GirviDetails.Columns["ContactNo"].HeaderText = "मोबाइल नं";
            dataGridView_GirviDetails.Columns["Address"].HeaderText = "पत्ता";
            dataGridView_GirviDetails.Columns["DateOfDeposit"].HeaderText = "व्याज तारीख";
            dataGridView_GirviDetails.Columns["GirviNo"].HeaderText = "गिरवी नं";
            dataGridView_GirviDetails.Columns["ReceiptNo"].HeaderText = "रिसीप्त तारीख";
            dataGridView_GirviDetails.Columns["Amount"].HeaderText = "एकून";
            dataGridView_GirviDetails.Columns["Column12"].HeaderText = "व्याज दर";
            dataGridView_GirviDetails.Columns["InterestAmount"].HeaderText = "व्याज मूल्य";
            dataGridView_GirviDetails.Columns["ekun"].HeaderText = "एकून";
            dataGridView_GirviDetails.Columns["Column13"].HeaderText = "कालावधी";
            dataGridView_GirviDetails.Columns["Column14"].HeaderText = "स्थीती";
            dataGridView_GirviDetails.Columns["Forward"].HeaderText = "फोरवर्ड ट";
            dataGridView_GirviDetails.Columns["Column20"].HeaderText = "फोरवर्ड टू";
            dataGridView_GirviDetails.Columns["receipt_no"].HeaderText = "रिसीप्त नं";
            dataGridView_GirviDetails.Columns["itemdes"].HeaderText = "माहिती";
            dataGridView_GirviDetails.Columns["itemwt"].HeaderText = "वजन";
            dataGridView_GirviDetails.Columns["itemamt"].HeaderText = "वस्तू मूल्य";
            lbl_StartingDate.Font = new Font("Arial", sizetext);
            lbl_EndingDate.Font = new Font("Arial", sizetext);
            lbl_InterestDate.Font = new Font("Arial", sizetext);
            lbl_VillageName.Font = new Font("Arial", sizetext);
        }



        private void dataGridView_GirviDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            //lbl_Date.Text = "तारीख";
            this.Text = "गिरवी माहिती गाव प्रमाणे";
            lbl_StartingDate.Text = "शुरवात तारीख";
            lbl_EndingDate.Text = "अंतिम तारीख";
            lbl_InterestDate.Text = "व्याज तारीख ";
            lbl_VillageName.Text = "गावाचे नाव";
            dataGridView_GirviDetails.Columns["SrNo"].HeaderText = "नं";
            dataGridView_GirviDetails.Columns["FullName"].HeaderText = "पूर्ण नाव";
            dataGridView_GirviDetails.Columns["ContactNo"].HeaderText = "मोबाइल नं";
            dataGridView_GirviDetails.Columns["Address"].HeaderText = "पत्ता";
            dataGridView_GirviDetails.Columns["DateOfDeposit"].HeaderText = "व्याज तारीख";
            dataGridView_GirviDetails.Columns["GirviNo"].HeaderText = "गिरवी नं";
            dataGridView_GirviDetails.Columns["ReceiptNo"].HeaderText = "रिसीप्त तारीख";
            dataGridView_GirviDetails.Columns["Amount"].HeaderText = "एकून";
            dataGridView_GirviDetails.Columns["Column12"].HeaderText = "व्याज दर";
            dataGridView_GirviDetails.Columns["InterestAmount"].HeaderText = "व्याज मूल्य";
            dataGridView_GirviDetails.Columns["ekun"].HeaderText = "एकून";
            dataGridView_GirviDetails.Columns["Column13"].HeaderText = "कालावधी";
            dataGridView_GirviDetails.Columns["Column14"].HeaderText = "स्थीती";
            dataGridView_GirviDetails.Columns["Forward"].HeaderText = "फोरवर्ड ट";
            dataGridView_GirviDetails.Columns["Column20"].HeaderText = "फोरवर्ड टू";
            dataGridView_GirviDetails.Columns["receipt_no"].HeaderText = "रिसीप्त नं";
            dataGridView_GirviDetails.Columns["itemdes"].HeaderText = "माहिती";
            dataGridView_GirviDetails.Columns["itemwt"].HeaderText = "वजन";
            dataGridView_GirviDetails.Columns["itemamt"].HeaderText = "वस्तू मूल्य";
            lbl_StartingDate.Font = new Font("Arial", sizetext);
            lbl_EndingDate.Font = new Font("Arial", sizetext);
            lbl_InterestDate.Font = new Font("Arial", sizetext);
            lbl_VillageName.Font = new Font("Arial", sizetext);
        }

        private void dtp_StartDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void dtp_EndDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void dtp_InterestDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void dtp_InterestDate_Enter_1(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void cmb_VillageName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //     if (lst_FullName.Items.Count > 0)
            //    {

            //        lst_FullName.Focus();
            //    }
            //}
            if (e.KeyCode == Keys.Enter)
            {


                fillGirviData();


                lst_FullName.Visible = false;

            }
            //fillGirviData();
        }



        private void cmb_VillageName_TextChanged(object sender, EventArgs e)
        {
            if (cmb_VillageName.Text != "")
            {

                if (lst_FullName.Items.Count > 0)
                {
                    lst_FullName.Visible = true;
                }
                cmb_VillageName.DataSource = _objGirvi.retrunCustomerAddress();
                lst_FullName.DisplayMember = "FullName";
                lst_FullName.ValueMember = "FullName";
            }
        }

        private void cmb_VillageName_TextChanged_1(object sender, EventArgs e)
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

        private void lst_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    cmb_VillageName.Text = lst_FullName.SelectedValue.ToString();
            //    //cmb_FullName.Focus();

            //    fillGirviData();
            //    lst_FullName.Visible = false;
            //}
        }



    }
}





