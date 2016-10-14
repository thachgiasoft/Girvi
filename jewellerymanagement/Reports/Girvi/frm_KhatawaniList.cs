using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;
using JewelleryManagement.CrystalReport;
using BAL.Girvi;
using BAL.Reports.Girvi;
using BAL;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_KhatawaniList : Form
    {
        PrinterSetting oPrintersetting = new PrinterSetting();
        clsCommon _objCommon = new clsCommon();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        Validation val = new Validation();
        KhatawaniWithGirviBAL _objKhatwaniWithGirviBal = new KhatawaniWithGirviBAL();
        clsKhatawaniGirviRecord _objKhatawaniGiviRecord = new clsKhatawaniGirviRecord();
        public delegate void SendDataMulti(DataTable dtData, string KhNo, string TotalAmountNaaveSum, string TotalAmountJamaSum, string PrinterName, bool other);
        public delegate void SendData(string KhatawaniNo, bool otherfont,string PrinterName);
        public delegate void SendDataKhatawani(DataTable dtKhatawani, bool other);
     

        public frm_KhatawaniList()
        {
            InitializeComponent();
        }

        private void frm_KhatawaniList_KeyDown(object sender, KeyEventArgs e)
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

        private void frm_KhatawaniList_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void fillgrid()
        {
            try
            {
                dgv_KhatawaniDetail.Rows.Clear();
                DataTable dtkhatawani = _objKhatwaniWithGirviBal.getkhatawanidetail();
                for (int i = 0; i < dtkhatawani.Rows.Count; i++)
                {
                    //if (_objGirviAdd.getGirviDetailsByKhatawani(dtkhatawani.Rows[i]["khatawani_No"].ToString()).Rows.Count>0)
                    dgv_KhatawaniDetail.Rows.Add(false,dtkhatawani.Rows[i]["khatawani_No"].ToString(), dtkhatawani.Rows[i]["FullName"].ToString(), dtkhatawani.Rows[i]["Contact_No"].ToString(), dtkhatawani.Rows[i]["Address"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool girviExistofKhatawani(string kh_no)
        {
            throw new NotImplementedException();
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Date.Text = "तारीख";
            bttn_PrintKhatawaniList.Text = "प्रिंट खतावणी वही";

            dgv_KhatawaniDetail.Columns["KhatawaniNo"].HeaderText = "खतावणी नं.";
            dgv_KhatawaniDetail.Columns["Name"].HeaderText = "नाव";
            dgv_KhatawaniDetail.Columns["PhoneNo"].HeaderText = "संपर्क क्र.";
            dgv_KhatawaniDetail.Columns["Address"].HeaderText = "पत्ता";
          
        }

       
        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Date.Text = "तारीख";
            bttn_PrintKhatawaniList.Text = "प्रिंट खतावणी वही";

            dgv_KhatawaniDetail.Columns["KhatawaniNo"].HeaderText = "खतावणी नं.";
            dgv_KhatawaniDetail.Columns["Name"].HeaderText = "नाम";
            dgv_KhatawaniDetail.Columns["PhoneNo"].HeaderText = "संपर्क क्र.";
            dgv_KhatawaniDetail.Columns["Address"].HeaderText = "पत्ता";
            dgv_KhatawaniDetail.Columns["DateOfDeposit"].HeaderText = "गिरवी तारीख";
            dgv_KhatawaniDetail.Columns["AmountBalance"].HeaderText = "रक्कम बाकी";
            dgv_KhatawaniDetail.Columns["Cast"].HeaderText = "जात";
        }

      

        public void khatawaniBook()
        {

            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();

            if (oPrintersetting.ShowDialog() == DialogResult.OK)
            {



                for (int j = 0; j < dgv_KhatawaniDetail.Rows.Count; j++)
                {
                    if (Convert.ToBoolean(dgv_KhatawaniDetail.Rows[j].Cells["chk"].Value) == true)
                    {
                        double totalloanamountsum = 0;
                        DataTable girvi_data = _objGirviAdd.getGirviDetailsByKhatawaniInterest(dgv_KhatawaniDetail.Rows[j].Cells["KhatawaniNo"].Value.ToString());
                        DataTable dtGirviDetailsKhatwani = new DataTable();
                        dtGirviDetailsKhatwani.Columns.Add("RecieptNoNave");
                        dtGirviDetailsKhatwani.Columns.Add("AmountPaidNave");
                        dtGirviDetailsKhatwani.Columns.Add("DateOfDepositNave");

                        dtGirviDetailsKhatwani.Columns.Add("PageNoNave");
                        dtGirviDetailsKhatwani.Columns.Add("DiscriptionNave");
                        for (int i = 0; i < girvi_data.Rows.Count; i++)
                        {

                            int girvi_no = Convert.ToInt32(girvi_data.Rows[i]["GirviRecordNo"]);
                            string pagenumber = _objGirviCommon.getPageNumber(girvi_data.Rows[i]["Date_of_deposit"].ToString());
                            string Dateofrelease = _objKhatawaniGiviRecord.getDateofrelease(girvi_no);
                            string str = _objKhatawaniGiviRecord.getgirviitem(girvi_no.ToString()) + " व्याज: दि." + girvi_data.Rows[i]["Date_of_deposit"] + "ते दि." + Dateofrelease;

                            string interest = _objKhatawaniGiviRecord.getreleaseinterest(girvi_no);

                            dtGirviDetailsKhatwani.Rows.Add(girvi_data.Rows[i]["receipt_no"].ToString(), girvi_data.Rows[i]["Amount"].ToString() + "\n " + interest, girvi_data.Rows[i]["Date_of_deposit"].ToString(), pagenumber, str.Trim());

                            totalloanamountsum = totalloanamountsum + (Convert.ToDouble(girvi_data.Rows[i]["Amount"].ToString()));//lalit remove interest


                        }


                        double totalpaidsum = 0;
                        DataTable dtGirviReleaseKhatwani = new DataTable();
                        DataTable dtGirvirelease = _objKhatawaniGiviRecord.getgirvivaluesByFinancialYear(dgv_KhatawaniDetail.Rows[j].Cells["KhatawaniNo"].Value.ToString(), dtFiancialYear.Rows[0]["startyear"].ToString(), dtFiancialYear.Rows[0]["endyear"].ToString());
                        dtGirviReleaseKhatwani.Columns.Add("RecieptNoJama");
                        dtGirviReleaseKhatwani.Columns.Add("AmountPaidJama");

                        dtGirviReleaseKhatwani.Columns.Add("DateJama");
                        dtGirviReleaseKhatwani.Columns.Add("PageNoJama");

                        dtGirviReleaseKhatwani.Columns.Add("DiscriptionJama");
                        if (dtGirvirelease.Rows.Count > 0)
                        {

                            for (int i = 0; i < dtGirvirelease.Rows.Count; i++)
                            {
                                string str;

                                if (rbt_Marathi.Checked == true)
                                {
                                    str = dtGirvirelease.Rows[i]["AmountDeposit"].ToString() + " दि. " + dtGirvirelease.Rows[i]["dateOfRelease"].ToString() + " चे मुद्दल, " + dtGirvirelease.Rows[i]["Interest_Amount"].ToString() + " व्याज बद्दल";
                                }
                                else
                                {
                                    str = dtGirvirelease.Rows[i]["AmountDeposit"].ToString() + " दि." + dtGirvirelease.Rows[i]["dateOfRelease"].ToString() + " चे मुद्दल, " + dtGirvirelease.Rows[i]["Interest_Amount"].ToString() + " व्याज बद्दल";
                                }
                                string pagenumber = _objGirviCommon.getPageNumber(dtGirvirelease.Rows[i]["dateOfRelease"].ToString());
                                dtGirviReleaseKhatwani.Rows.Add(dtGirvirelease.Rows[i]["pavtino"].ToString(), dtGirvirelease.Rows[i]["AmountDeposit"].ToString(), dtGirvirelease.Rows[i]["dateOfRelease"].ToString(), pagenumber, str);
                                totalpaidsum = totalpaidsum + (Convert.ToDouble(dtGirvirelease.Rows[i]["AmountDeposit"].ToString()));
                            }
                        }
                        totalpaidsum.ToString();

                        DataTable dtMerge = _objCommon.mergeTwoDataGrid(dtGirviDetailsKhatwani, dtGirviReleaseKhatwani);

                        CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                        SendDataMulti _obj = new SendDataMulti(_objfrm_ReportViewer.ReceiveDataInterestRecordMultiPrint);
                        if (rbt_PrintTrue.Checked == true)
                        {

                            _obj(dtMerge, dgv_KhatawaniDetail.Rows[j].Cells["KhatawaniNo"].Value.ToString(), totalloanamountsum.ToString(), totalpaidsum.ToString(), oPrintersetting.PrinterName, true);
                        }
                        else
                        {
                            _obj(dtMerge, dgv_KhatawaniDetail.Rows[j].Cells["KhatawaniNo"].Value.ToString(), totalloanamountsum.ToString(), totalpaidsum.ToString(), oPrintersetting.PrinterName, false);

                        }
                    }

                }
            }
        }
        private void frm_CustomSellect_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_KhatawaniDetail.Rows.Count; i++)
            {
                dgv_KhatawaniDetail.Rows[i].Cells["chk"].Value = false;
            }
        }

        private void rbt_SellectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_KhatawaniDetail.Rows.Count; i++)
            {
                dgv_KhatawaniDetail.Rows[i].Cells["chk"].Value = true;
            }
        }

        private void bttn_PrintKhatawaniList_Click(object sender, EventArgs e)
        {
         
            if (rdo_AllKhatawani.Checked == true)
            {
                khatawaniBook();
            }
            if (rdo_Form12.Checked == true)
            {
               Form12();
            }
            if (rbt_form14.Checked == true)
            {
                Form14();
            }
            if (rdo_Notice.Checked == true)
            {
                Notice();
            }
            if (rbt_khatawaniIndex.Checked == true)
            {
                KhatawaniIndex();
            }
            
        }

        private void KhatawaniIndex()
        {
            DataTable dtKhatawani = _objCommon.DataGridView2DataTableSelected(dgv_KhatawaniDetail, "table");
           
                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                    SendDataKhatawani _obj = new SendDataKhatawani(_objfrm_ReportViewer.ReceiveKhatawaniList);
                    if (rbt_OtherTrue.Checked == true)
                    {
                        _obj(dtKhatawani, true);
                    }
                    else
                    {
                        _obj(dtKhatawani, false);

                    }
                    _objfrm_ReportViewer.Show();
            
           
          




            //DataTable dtKhatawani = _objCommon.DataGridView2DataTable(dgv_KhatawaniDetail, "table");
            //if (oPrintersetting.ShowDialog() == DialogResult.OK)
            //{
            //    for (int j = 0; j < dgv_KhatawaniDetail.Rows.Count; j++)
            //    {

               
            //        if (Convert.ToBoolean(dgv_KhatawaniDetail.Rows[j].Cells["chk"].Value) == true)
            //        {

            //            if (_objGirviAdd.getGirviDetailsByKhatawani(dgv_KhatawaniDetail.Rows[j].Cells["KhatawaniNo"].Value.ToString()).Rows.Count > 0)
            //            {
            //                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            //                SendDataKhatawani _obj = new SendDataKhatawani  (_objfrm_ReportViewer.ReceiveKhatawaniList);
            //                _obj(dtKhatawani, true);
            //            }
            //        }
            //    }
            //}

        }

        private void Notice()
        {
            if (oPrintersetting.ShowDialog() == DialogResult.OK)
            {



                for (int j = 0; j < dgv_KhatawaniDetail.Rows.Count; j++)
                {
                    if (Convert.ToBoolean(dgv_KhatawaniDetail.Rows[j].Cells["chk"].Value) == true)
                    {
                        CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                        SendData _objReceiveDataNotice = new SendData(_objfrm_ReportViewer.ReceiveDataNoticeMulti);
                        _objReceiveDataNotice(dgv_KhatawaniDetail.Rows[j].Cells["KhatawaniNo"].Value.ToString(), false, oPrintersetting.PrinterName);
                      
                    }
                }
            }
        }

        private void Form12()
        {
            if (oPrintersetting.ShowDialog  () == DialogResult.OK)
            {

              

                for (int j = 0; j < dgv_KhatawaniDetail.Rows.Count; j++)
                {
                   
                 
                    if (Convert.ToBoolean(dgv_KhatawaniDetail.Rows[j].Cells["chk"].Value) == true)
                    {

                        if (_objGirviAdd.getGirviDetailsByKhatawani(dgv_KhatawaniDetail.Rows[j].Cells["KhatawaniNo"].Value.ToString()).Rows.Count > 0)
                        {
                            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                            SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataForm12Multi);
                            _obj(dgv_KhatawaniDetail.Rows[j].Cells["KhatawaniNo"].Value.ToString(), false, oPrintersetting.PrinterName);
                        }
                    }
                }
            }
        }

        private void Form14()
        {
            if (oPrintersetting.ShowDialog() == DialogResult.OK)
            {



                for (int j = 0; j < dgv_KhatawaniDetail.Rows.Count; j++)
                {
                    if (Convert.ToBoolean(dgv_KhatawaniDetail.Rows[j].Cells["chk"].Value) == true)
                    {
                        CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                        SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataForm14Multi);
                        _obj(dgv_KhatawaniDetail.Rows[j].Cells["KhatawaniNo"].Value.ToString(), false, oPrintersetting.PrinterName);
                    }
                }
            }
        }

        private void rbt_khatawaniIndex_CheckedChanged(object sender, EventArgs e)
        {

        }

    

       

      
    }
}
