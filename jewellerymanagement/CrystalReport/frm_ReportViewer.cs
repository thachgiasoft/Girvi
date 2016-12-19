using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BAL.Common;
using CrystalDecisions.CrystalReports.Engine;
using JewelleryManagement.Reports.Girvi;

namespace JewelleryManagement.CrystalReport
{
    public partial class frm_ReportViewer : Form

    {
        SQLHelper _objsqlhelper = new SQLHelper();
        clsCommon _objCommon = new clsCommon();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
        Simplevalidations _objSimplevalidations = new Simplevalidations();
        frm_InterestRecord _objintrest = new frm_InterestRecord();

        //
        public frm_ReportViewer()
        {
            InitializeComponent();
        }


        public void ReceiveDataAddGirvi(string GirviNo, string AccNo, string OtherFont, string PrinterName)
        {
            string crname;

            crname = "Select GirviAdd from tbl_GirviCrystalReports";

            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            //crt_CustomerSale _objReport = new crt_CustomerSale();
            CrystalDecisions.CrystalReports.Engine.ReportDocument _objReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            _objReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["GirviAdd"].ToString());


            //CrystalReport.CrystalReport_Girvi.crt_GirviAdd _objReport = new CrystalReport.CrystalReport_Girvi.crt_GirviAdd();

            string CompanyMaster = "SELECT companyid, CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,Post,Tahsil,District,State,PinCode FROM CompanyMaster WHERE (companyid = '1')";
            string ItemsDetails = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt, net_wt, Total_Quantity,reduce_wt,wt_in_percent,current_rate,fine_wt,amount FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            string GirviMasterDetails = "SELECT GirviRecordNo, Amount as girviAmount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,loantype,reason,narration FROM GirviMaster WHERE (GirviRecordNo = '" + GirviNo + "')";
            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2,PoliceStation,Tahsil,District  FROM   Customer_Master WHERE  (khatawani_No = '" + AccNo + "')";

            DataTable dt_CompanyMaster = _objsqlhelper.GetDataTable(CompanyMaster);
            DataTable dt_CustomerMaster = _objsqlhelper.GetDataTable(CustomerInfo);
            DataTable dt_GirviItemMaster = _objsqlhelper.GetDataTable(ItemsDetails);
            for (int i = 0; i < dt_GirviItemMaster.Rows.Count; i++)
            {
                string newValue = _objSimplevalidations.Gettingdecimals(dt_GirviItemMaster.Rows[i]["gross_wt"].ToString());
                dt_GirviItemMaster.Rows[i]["gross_wt"] = newValue;
                //dt_GirviItemMaster.Rows[i]["gross_wt"] = Math.Round(Convert.ToDouble(dt_GirviItemMaster.Rows[i]["gross_wt"].ToString()), 3).ToString();
            }
            DataTable dt_GirviMaster = _objsqlhelper.GetDataTable(GirviMasterDetails);

            if (OtherFont == "Other")
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _objReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _objReport.ReportDefinition.ReportObjects[i].Name;

                    field = _objReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _objReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "reason1" && strrr != "occupation1" && strrr != "loantype1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4" && strrr != "city2" && strrr != "receiptno4" && strrr != "reason2" && strrr != "occupation2" && strrr != "loantype2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                }
            }

            _objReport.Database.Tables["dt_CompanyMaster"].SetDataSource(dt_CompanyMaster);
            _objReport.Database.Tables["dt_CustomerMaster"].SetDataSource(dt_CustomerMaster);
            _objReport.Database.Tables["dt_GirviItemMaster"].SetDataSource(dt_GirviItemMaster);
            _objReport.Database.Tables["dt_GirviMaster"].SetDataSource(dt_GirviMaster);

            string MarathiConvertedAmount = funNumToWordConvert(Decimal.Parse(dt_GirviMaster.Rows[0]["girviAmount"].ToString())) + "रुपये";

            _objReport.SetParameterValue("GirviAmountInWords", MarathiConvertedAmount);

            _objReport.SetParameterValue("Interest", Convert.ToString(Math.Round(Convert.ToDecimal(dt_GirviMaster.Rows[0]["interset_rate"]) * 12, 0)));
            _objReport.SetParameterValue("GrossWt", _objSimplevalidations.Gettingdecimals(Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "gross_wt"))));
            _objReport.SetParameterValue("TotalAmount", Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "amount")));

            string Printvalue = _objCommon.getprintcounttheva();

            if (Printvalue == "3")
            {
                _objReport.PrintOptions.PrinterName = PrinterName;
                _objReport.SetParameterValue("PageNo", "C");
                _objReport.PrintToPrinter(1, true, 0, 0);

                _objReport.SetParameterValue("PageNo", "O");
                _objReport.PrintToPrinter(1, true, 0, 0);

                _objReport.SetParameterValue("PageNo", "P");
                _objReport.PrintToPrinter(1, true, 0, 0);
            }
            else if (Printvalue == "2")
            {
                _objReport.SetParameterValue("PageNo", "");
                _objReport.PrintToPrinter(1, true, 0, 0);

                _objReport.SetParameterValue("PageNo", "");
                _objReport.PrintToPrinter(1, true, 0, 0);
            }
            else
            {
                _objReport.SetParameterValue("PageNo", "");
                _objReport.PrintToPrinter(1, true, 0, 0);
            }


            crReportViewer.ReportSource = _objReport;
        }


        
        
        
        
        //Prasad


        public int MonthDifference(DateTime lValue, DateTime rValue)
        {
            return (lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year);
        }
        public void ReceiveDataNotice(string GirviNo, string AccNo, string OtherFont, string PrinterName)
        {
            string crname;

            crname = "Select Notice from tbl_GirviCrystalReports";

            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);


            CrystalDecisions.CrystalReports.Engine.ReportDocument _oVIReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            _oVIReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["Notice"].ToString());

            string strCompany = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat,Post,Tahsil,District,State,PinCode FROM CompanyMaster WHERE companyid='1'";
            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + AccNo + "')";
            string strGirviMasterDetails = "SELECT GirviRecordNo, Amount as girviAmount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,loantype,reason FROM GirviMaster where (GirviRecordNo = '" + GirviNo + "') ";
            string strGirviItemMaster = "SELECT   GirviNo, metal_type, item_type, gross_wt, net_wt, Total_Quantity, reduce_wt, wt_in_percent  FROM   GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";

            DataTable dtCompany = _objsqlhelper.GetDataTable(strCompany);
            DataTable dtCustomer = _objsqlhelper.GetDataTable(CustomerInfo);
            DataTable dtGirviMasterDetails = _objsqlhelper.GetDataTable(strGirviMasterDetails);
            DataTable dtGirviItemMaster = _objsqlhelper.GetDataTable(strGirviItemMaster);


            _oVIReport.Database.Tables[0].SetDataSource(dtCompany);
            _oVIReport.Database.Tables[1].SetDataSource(dtCustomer);
            _oVIReport.Database.Tables[2].SetDataSource(dtGirviItemMaster);
            _oVIReport.Database.Tables[3].SetDataSource(dtGirviMasterDetails);


            string MarathiConvertedAmount = funNumToWordConvert(Decimal.Parse(dtGirviMasterDetails.Rows[0]["girviAmount"].ToString()));
            _oVIReport.SetParameterValue("GirviAmountInWords", MarathiConvertedAmount);
           // _oVIReport.SetParameterValue("TotalMonths", MarathiConvertedAmount);

            var dateSpan = MonthDifference(Convert.ToDateTime(dtGirviMasterDetails.Rows[0]["duration"]),Convert.ToDateTime(dtGirviMasterDetails.Rows[0]["Date_of_deposit"]));
            _oVIReport.SetParameterValue("TotalMonths", dateSpan.ToString());
            _oVIReport.SetParameterValue("FinalNoticeDate", Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")).AddDays(15));

            for (int i = 0; i < dtGirviItemMaster.Rows.Count; i++)
            {
                string newValue = _objSimplevalidations.Gettingdecimals(dtGirviItemMaster.Rows[i]["gross_wt"].ToString());
                dtGirviItemMaster.Rows[i]["gross_wt"] = newValue;
                //dt_GirviItemMaster.Rows[i]["gross_wt"] = Math.Round(Convert.ToDouble(dt_GirviItemMaster.Rows[i]["gross_wt"].ToString()), 3).ToString();
            }
            DataTable dt_GirviMaster = _objsqlhelper.GetDataTable(strGirviMasterDetails);



            if (OtherFont == "Other")
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "reason1" && strrr != "occupation1" && strrr != "loantype1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4" && strrr != "city2" && strrr != "receiptno4" && strrr != "reason2" && strrr != "occupation2" && strrr != "loantype2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                }
            }


            crReportViewer.ReportSource = _oVIReport;

            UpdateNSNInGirviMaster(GirviNo);
        }

        internal void ReceiveDebitDetailsReport(DataTable dt)
        {
            CrystalReport.CrystalReport_Girvi.crt_CreditForm _objReport = new CrystalReport.CrystalReport_Girvi.crt_CreditForm();
            string CompanyInfo = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat,Post,Tahsil,District,State,PinCode FROM CompanyMaster WHERE companyid='1'";

            DataTable dt_CompanyInfo = _objsqlhelper.GetDataTable(CompanyInfo);
           double SumOfAmount = _objCommon.sumDataTableColumn(dt, "DebitAmount");

            _objReport.Database.Tables[0].SetDataSource(dt_CompanyInfo);
            _objReport.Database.Tables[1].SetDataSource(dt);
            _objReport.SetParameterValue("SumCredit", SumOfAmount);
            crReportViewer.ReportSource = _objReport;
        }
        internal void ReceiveCreditDetailsReport(DataTable dt)
        {
            CrystalReport.CrystalReport_Girvi.crt_DebitForm _objReport = new CrystalReport.CrystalReport_Girvi.crt_DebitForm();
            string CompanyInfo = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat,Post,Tahsil,District,State,PinCode FROM CompanyMaster WHERE companyid='1'";

            DataTable dt_CompanyInfo = _objsqlhelper.GetDataTable(CompanyInfo);
            double SumOfAmount = _objCommon.sumDataTableColumn(dt, "DebitAmount");

            _objReport.Database.Tables[0].SetDataSource(dt_CompanyInfo);
            _objReport.Database.Tables[1].SetDataSource(dt);
            _objReport.SetParameterValue("SumCredit", SumOfAmount);
            crReportViewer.ReportSource = _objReport;
        }

        public void UpdateNSNInGirviMaster(string GirviNo)
        {
            string NSNCount;
            string strCount;
            string strUpdateNSNCount;
            string strNSN = "Select NSN From GirviMaster where (GirviRecordNo = '" + GirviNo + "') ";
           
            NSNCount = _objsqlhelper.ExecuteScalar(strNSN);
            strUpdateNSNCount = Convert.ToString(Convert.ToInt32(NSNCount) + 1);
            strCount = "UPDATE GirviMaster SET NSN ='" + strUpdateNSNCount + "' where (GirviRecordNo = '" + GirviNo + "') ";
            _objsqlhelper.ExecuteSql(strCount);
        }


        public void ReceiveBabhulgaonOfficeCopy(string GirviNo, string AccNo, string OtherFont, string PrinterName)
        {

            string crname;

            crname = "Select GirviOfficeCopy from tbl_GirviCrystalReports";

            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            //crt_CustomerSale _objReport = new crt_CustomerSale();
            CrystalDecisions.CrystalReports.Engine.ReportDocument _objReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            _objReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["GirviOfficeCopy"].ToString());

            //CrystalReport.CrystalReport_Girvi.crt_GirviAdd _objReport = new CrystalReport.CrystalReport_Girvi.crt_GirviAdd();

            string CompanyMaster = "SELECT companyid, CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo FROM CompanyMaster WHERE (companyid = '1')";
            string ItemsDetails = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt, net_wt, Total_Quantity,reduce_wt,wt_in_percent,current_rate,fine_wt,amount FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            string GirviMasterDetails = "SELECT GirviRecordNo, Amount as girviAmount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,loantype,reason FROM GirviMaster WHERE (GirviRecordNo = '" + GirviNo + "')";
            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + AccNo + "')";

            DataTable dt_CompanyMaster = _objsqlhelper.GetDataTable(CompanyMaster);
            DataTable dt_CustomerMaster = _objsqlhelper.GetDataTable(CustomerInfo);
            DataTable dt_GirviItemMaster = _objsqlhelper.GetDataTable(ItemsDetails);
            DataTable dt_GirviMaster = _objsqlhelper.GetDataTable(GirviMasterDetails);

            if (OtherFont == "Other")
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _objReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _objReport.ReportDefinition.ReportObjects[i].Name;

                    field = _objReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _objReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "reason1" && strrr != "occupation1" && strrr != "loantype1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4" && strrr != "city2" && strrr != "receiptno4" && strrr != "reason2" && strrr != "occupation2" && strrr != "loantype2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                }
            }

            _objReport.Database.Tables["dt_CompanyMaster"].SetDataSource(dt_CompanyMaster);
            _objReport.Database.Tables["dt_CustomerMaster"].SetDataSource(dt_CustomerMaster);
            _objReport.Database.Tables["dt_GirviItemMaster"].SetDataSource(dt_GirviItemMaster);
            _objReport.Database.Tables["dt_GirviMaster"].SetDataSource(dt_GirviMaster);

            string MarathiConvertedAmount = funNumToWordConvert(Decimal.Parse(dt_GirviMaster.Rows[0]["girviAmount"].ToString()));

            _objReport.SetParameterValue("GirviAmountInWords", MarathiConvertedAmount);

            _objReport.SetParameterValue("Interest", Convert.ToString(Math.Round(Convert.ToDecimal(dt_GirviMaster.Rows[0]["interset_rate"]) * 12, 0)));
            _objReport.SetParameterValue("GrossWt", Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "gross_wt")));
            _objReport.SetParameterValue("TotalAmount", Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "amount")));
            _objReport.SetParameterValue("interest", Convert.ToDouble(dt_GirviMaster.Rows[0]["interset_rate"].ToString()) * 12);


            //_objReport.SetParameterValue("PageNo", "C");
            //_objReport.PrintToPrinter(1, true, 1, 99);
            //_objReport.SetParameterValue("PageNo", "O");
            //_objReport.PrintToPrinter(1, true, 1, 99);
            _objReport.SetParameterValue("PageNo", "P");
            //  _objReport.PrintToPrinter(1, true, 1, 99);
            //crReportViewer.ReportSource = _objReport;
            //  this.Close();

            _objReport.PrintOptions.PrinterName = PrinterName;
            _objReport.PrintToPrinter(1, false, 0, 0);


        }
        public void ReceiveBabhulgaonOfficeCopyMulti(string GirviNo, string AccNo, string OtherFont, string PrinterName)
        {
            string crname;
            crname = "Select GirviAdd from tbl_GirviCrystalReports";
            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            //crt_CustomerSale _objReport = new crt_CustomerSale();
            //   CrystalDecisions.CrystalReports.Engine.ReportDocument _objReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            //  _objReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["GirviAdd"].ToString());

            JewelleryManagement.bin.Debug.crt_BabulgaonOfficeCopy _objReport = new JewelleryManagement.bin.Debug.crt_BabulgaonOfficeCopy();


            string CompanyMaster = "SELECT companyid, CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo FROM CompanyMaster WHERE (companyid = '1')";
            string ItemsDetails = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt, net_wt, Total_Quantity,reduce_wt,wt_in_percent,current_rate,fine_wt,amount FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            string GirviMasterDetails = "SELECT GirviRecordNo, Amount as girviAmount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,loantype,reason FROM GirviMaster WHERE (GirviRecordNo = '" + GirviNo + "')";
            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + AccNo + "')";

            DataTable dt_CompanyMaster = _objsqlhelper.GetDataTable(CompanyMaster);
            DataTable dt_CustomerMaster = _objsqlhelper.GetDataTable(CustomerInfo);
            DataTable dt_GirviItemMaster = _objsqlhelper.GetDataTable(ItemsDetails);
            DataTable dt_GirviMaster = _objsqlhelper.GetDataTable(GirviMasterDetails);

            if (OtherFont == "Other")
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _objReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _objReport.ReportDefinition.ReportObjects[i].Name;

                    field = _objReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _objReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "reason1" && strrr != "occupation1" && strrr != "loantype1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4" && strrr != "city2" && strrr != "receiptno4" && strrr != "reason2" && strrr != "occupation2" && strrr != "loantype2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                }
            }

            _objReport.Database.Tables["dt_CompanyMaster"].SetDataSource(dt_CompanyMaster);
            _objReport.Database.Tables["dt_CustomerMaster"].SetDataSource(dt_CustomerMaster);
            _objReport.Database.Tables["dt_GirviItemMaster"].SetDataSource(dt_GirviItemMaster);
            _objReport.Database.Tables["dt_GirviMaster"].SetDataSource(dt_GirviMaster);

            string MarathiConvertedAmount = funNumToWordConvert(Decimal.Parse(dt_GirviMaster.Rows[0]["girviAmount"].ToString()));

            _objReport.SetParameterValue("GirviAmountInWords", MarathiConvertedAmount);

            _objReport.SetParameterValue("Interest", Convert.ToString(Math.Round(Convert.ToDecimal(dt_GirviMaster.Rows[0]["interset_rate"]) * 12, 0)));
            _objReport.SetParameterValue("GrossWt", Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "gross_wt")));
            _objReport.SetParameterValue("TotalAmount", Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "amount")));
            _objReport.SetParameterValue("interest", Convert.ToDouble(dt_GirviMaster.Rows[0]["interset_rate"].ToString()) * 12);


            //_objReport.SetParameterValue("PageNo", "C");
            //_objReport.PrintToPrinter(1, true, 1, 99);
            //_objReport.SetParameterValue("PageNo", "O");
            //_objReport.PrintToPrinter(1, true, 1, 99);
            //  _objReport.SetParameterValue("PageNo", "P");
            //  _objReport.PrintToPrinter(1, true, 1, 99);
            //  crReportViewer.ReportSource = _objReport;
            //  this.Close();
            _objReport.PrintOptions.PrinterName = PrinterName;
            _objReport.PrintToPrinter(1, false, 0, 0);
        }

        public void ReceiveDataReleaseGirvi(string GirviNo, string KhatawaniNo, string OtherFont)
                         {
            string crname = "Select GirviAdd,GirviRelease from tbl_GirviCrystalReports";
            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            if (dt_crname.Rows[0]["GirviRelease"] == null || dt_crname.Rows[0]["GirviRelease"].ToString() == "")
            {
                CrystalReport.CrystalReport_Girvi.Crt_GirviReliese _objReport = new CrystalReport.CrystalReport_Girvi.Crt_GirviReliese();
                string CompanyMaster = "SELECT companyid, CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,Post,Tahsil,District,State,PinCode FROM CompanyMaster WHERE (companyid = '1')";
                string ItemsDetails = "SELECT  metal_type, item_type, gross_wt, net_wt, Total_Quantity,reduce_wt FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
                // string GirviReleaseMaster = "SELECT  Girvino, AmountDeposit, dateOfRelease, intersetRate,IntersetPaid,dateOfRelease,Interest_Amount,pavtino FROM GirviReleaseMaster WHERE (GirviRecordNo = '" + GirviNo + "')";
                string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhatawaniNo + "')";
                string GirviReleaseMaster = "SELECT Girvino, AmountDeposit, TotalDays, intersetRate, IntersetPaid, dateOfRelease, Interest_Amount, pavtino,Narration FROM GirviReleasemaster WHERE (Girvino = '" + GirviNo + "')";
                string GirviMasterDetails = "SELECT GirviRecordNo, Amount as girviAmount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,loantype,reason FROM GirviMaster WHERE (GirviRecordNo = '" + GirviNo + "')";

                DataTable dt_CompanyMaster = _objsqlhelper.GetDataTable(CompanyMaster);
                DataTable dt_CustomerMaster = _objsqlhelper.GetDataTable(CustomerInfo);
                DataTable dt_GirviItemMaster = _objsqlhelper.GetDataTable(ItemsDetails);
                DataTable dt_GirviReleaseMaster = _objsqlhelper.GetDataTable(GirviReleaseMaster);
                DataTable dt_GirviMaster = _objsqlhelper.GetDataTable(GirviMasterDetails);

                for (int i = 0; i < dt_GirviItemMaster.Rows.Count; i++)
                {
                    dt_GirviItemMaster.Rows[i]["gross_wt"] = "1";
                    double d = Convert.ToDouble(dt_GirviItemMaster.Rows[i]["gross_wt"]);
                    dt_GirviItemMaster.Rows[i]["gross_wt"] = d.ToString("0.000");
                }

                _objReport.Database.Tables[0].SetDataSource(dt_CompanyMaster);
                _objReport.Database.Tables[1].SetDataSource(dt_CustomerMaster);
                _objReport.Database.Tables[2].SetDataSource(dt_GirviItemMaster);
                _objReport.Database.Tables[3].SetDataSource(dt_GirviReleaseMaster);
                _objReport.Database.Tables[4].SetDataSource(dt_GirviMaster);
                string MarathiConvertedAmount = funNumToWordConvert(Decimal.Parse(dt_GirviMaster.Rows[0]["girviAmount"].ToString()));
                _objReport.SetParameterValue("GirviAmountInWords", MarathiConvertedAmount);
                _objReport.SetParameterValue("InterestAmount", Convert.ToString(Math.Round(Convert.ToDecimal(dt_GirviReleaseMaster.Rows[0]["intersetRate"]) * 12, 0)));
                //_objReport.SetParameterValue("GrossWt", Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "gross_wt")));
                //_objReport.SetParameterValue("TotalAmount", Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "amount")));
                crReportViewer.ReportSource = _objReport;
                if (OtherFont == "Other")
                {
                    FieldObject field;
                    TextObject texto;

                    for (int i = 0; i < _objReport.ReportDefinition.ReportObjects.Count; i++)
                    {
                        string strrr = _objReport.ReportDefinition.ReportObjects[i].Name;

                        field = _objReport.ReportDefinition.ReportObjects[i] as FieldObject;
                        texto = _objReport.ReportDefinition.ReportObjects[i] as TextObject;

                        if (field != null)
                        {
                            if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addressline21" && strrr != "city1" && strrr != "metaltype1" && strrr != "itemtype1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "metaltype3" && strrr != "itemtype2")
                                field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                        }
                    }
                }
            }
            else
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument _objReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                _objReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["GirviRelease"].ToString());
                string CompanyMaster = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,Post,Tahsil,District,State,PinCode FROM CompanyMaster WHERE (companyid = '1')";
                string ItemsDetails = "SELECT  metal_type, item_type, gross_wt, net_wt, Total_Quantity,reduce_wt FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
                // string GirviReleaseMaster = "SELECT  Girvino, AmountDeposit, dateOfRelease, intersetRate,IntersetPaid,dateOfRelease,Interest_Amount,pavtino FROM GirviReleaseMaster WHERE (GirviRecordNo = '" + GirviNo + "')";
                string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhatawaniNo + "')";
                string GirviReleaseMaster = "SELECT Girvino, AmountDeposit, TotalDays, intersetRate, IntersetPaid, dateOfRelease, Interest_Amount, pavtino,Narration FROM GirviReleasemaster WHERE (Girvino = '" + GirviNo + "')";
                string GirviMasterDetails = "SELECT GirviRecordNo, Amount as girviAmount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,loantype,reason FROM GirviMaster WHERE (GirviRecordNo = '" + GirviNo + "')";

                DataTable dt_CompanyMaster = _objsqlhelper.GetDataTable(CompanyMaster);
                DataTable dt_CustomerMaster = _objsqlhelper.GetDataTable(CustomerInfo);
                DataTable dt_GirviItemMaster = _objsqlhelper.GetDataTable(ItemsDetails);
                DataTable dt_GirviReleaseMaster = _objsqlhelper.GetDataTable(GirviReleaseMaster);
                DataTable dt_GirviMaster = _objsqlhelper.GetDataTable(GirviMasterDetails);

                _objReport.Database.Tables["dt_CompanyMaster"].SetDataSource(dt_CompanyMaster);
                _objReport.Database.Tables["dt_CustomerMaster"].SetDataSource(dt_CustomerMaster);
                _objReport.Database.Tables["dt_GirviItemMaster"].SetDataSource(dt_GirviItemMaster);
                _objReport.Database.Tables["dt_GirviReleaseMaster"].SetDataSource(dt_GirviReleaseMaster);
                _objReport.Database.Tables["dt_GirviMaster"].SetDataSource(dt_GirviMaster);
                string MarathiConvertedAmount = funNumToWordConvert(Decimal.Parse(dt_GirviMaster.Rows[0]["girviAmount"].ToString()));
                _objReport.SetParameterValue("GirviAmountInWords", MarathiConvertedAmount);
                _objReport.SetParameterValue("InterestAmount", Convert.ToString(Math.Round(Convert.ToDecimal(dt_GirviReleaseMaster.Rows[0]["intersetRate"]) * 12, 0)));
                //_objReport.SetParameterValue("GrossWt", Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "gross_wt")));
                //_objReport.SetParameterValue("TotalAmount", Convert.ToString(_objCommon.sumDataTableColumn(dt_GirviItemMaster, "amount")));
                crReportViewer.ReportSource = _objReport;
                if (OtherFont == "Other")
                {
                    FieldObject field;
                    TextObject texto;

                    for (int i = 0; i < _objReport.ReportDefinition.ReportObjects.Count; i++)
                    {
                        string strrr = _objReport.ReportDefinition.ReportObjects[i].Name;

                        field = _objReport.ReportDefinition.ReportObjects[i] as FieldObject;
                        texto = _objReport.ReportDefinition.ReportObjects[i] as TextObject;

                        if (field != null)
                        {
                            if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addressline21" && strrr != "city1" && strrr != "metaltype1" && strrr != "itemtype1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "metaltype3" && strrr != "itemtype2")
                                field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                        }
                    }
                }
            }
        }

        public void ReceiveDataAllKhatawaniGirviAddedDetails(DataTable dtData, string EndDate, bool other)
        {
            CrystalReport.CrystalReport_Girvi.Crt_khatawaniwithgirviAdded _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_khatawaniwithgirviAdded();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,Post,Tahsil,District,State,PinCode FROM CompanyMaster WHERE (companyid = '1')";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dtData);
            _oVIReport.Database.Tables[1].SetDataSource(dt2);
            _oVIReport.SetParameterValue("enddate", EndDate);
            crReportViewer.ReportSource = _oVIReport;

            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")//&& strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }

                }
            }
        }

        public void ReceiveDataNotice(string KhatawaniNo, bool other)
        {

            string crname;
            crname = "Select Notice from tbl_GirviCrystalReports";
            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            CrystalDecisions.CrystalReports.Engine.ReportDocument _oVIReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            _oVIReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["Notice"].ToString());


            // CrystalReport.CrystalReport_Girvi.crt_notice _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_notice();
            string strCompany = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat FROM CompanyMaster WHERE companyid='1'";
            DataTable dtCompany = _objsqlhelper.GetDataTable(strCompany);

            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhatawaniNo + "')";
            DataTable dtCustomer = _objsqlhelper.GetDataTable(CustomerInfo);

            _oVIReport.Database.Tables[0].SetDataSource(dtCompany);
            _oVIReport.Database.Tables[1].SetDataSource(dtCustomer);

            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {

                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")//&& strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }

                }
            }
        }
        public void ReceiveDataNoticeMulti(string KhatawaniNo, bool other, string PrinterName)
        {
            CrystalReport.CrystalReport_Girvi.crt_notice _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_notice();
            string strCompany = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat FROM CompanyMaster WHERE companyid='1'";
            DataTable dtCompany = _objsqlhelper.GetDataTable(strCompany);

            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhatawaniNo + "')";
            DataTable dtCustomer = _objsqlhelper.GetDataTable(CustomerInfo);

            _oVIReport.Database.Tables[0].SetDataSource(dtCompany);
            _oVIReport.Database.Tables[1].SetDataSource(dtCustomer);
            //_oVIReport.SetParameterValue("enddate", EndDate);
            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {

                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")//&& strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }

                }
                _oVIReport.PrintOptions.PrinterName = PrinterName;
                _oVIReport.PrintToPrinter(1, false, 0, 0);
            }
            else
            {
                _oVIReport.PrintOptions.PrinterName = PrinterName;
                _oVIReport.PrintToPrinter(1, false, 0, 0);
            }
        }

        public void ReceiveDataForm12(string KhatawaniNo, bool other)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
           // CrystalReport.CrystalReport_Girvi.crt_formno12 _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_formno12();
            CrystalReport.CrystalReport_Girvi.crt_KarnajaLaadFormNo_12 _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_KarnajaLaadFormNo_12();
            string strCompany = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat FROM CompanyMaster WHERE companyid='1'";
            DataTable dtCompany = _objsqlhelper.GetDataTable(strCompany);

            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhatawaniNo + "')";
            DataTable dtCustomer = _objsqlhelper.GetDataTable(CustomerInfo);

            _oVIReport.Database.Tables["dt_CompanyMaster"].SetDataSource(dtCompany);
            _oVIReport.Database.Tables["dt_CustomerMaster"].SetDataSource(dtCustomer);

            string YearStartAmount = _objGirviCommon.getGirviYearStartAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string GirviAddAmount = _objGirviCommon.getGirviCurrentYearAddAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string GirviReleaseAmount = _objGirviCommon.getGirviCurrentYearReleaseAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string YearEndInterest = _objGirviCommon.getGirviYearEndInterestByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
         

            _oVIReport.SetParameterValue("YearStartAmount", YearStartAmount);
            _oVIReport.SetParameterValue("GirviAddAmount", GirviAddAmount);
            _oVIReport.SetParameterValue("TotalPreCurr", Convert.ToDouble(YearStartAmount) + Convert.ToDouble(GirviAddAmount));
            _oVIReport.SetParameterValue("GirviReleaseAmount", GirviReleaseAmount);
            _oVIReport.SetParameterValue("YearEndBal", GirviAddAmount);
            _oVIReport.SetParameterValue("YearEndInterest", YearEndInterest);
            _oVIReport.SetParameterValue("StartYear", dtFiancialYear.Rows[0]["startyear"].ToString());
            _oVIReport.SetParameterValue("EndYear", dtFiancialYear.Rows[0]["endyear"].ToString());
           
            //  _oVIReport.SetParameterValue("GirviInterestAmount", GirviInterestAmount);

            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")//&& strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                }
            }
        }

        public void ReceiveDataForm12LaadKaranja(string KhatawaniNo, bool other)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            // CrystalReport.CrystalReport_Girvi.crt_formno12 _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_formno12();
            CrystalReport.CrystalReport_Girvi.crt_KarnajaLaadFormNo_12 _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_KarnajaLaadFormNo_12();
            string strCompany = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat FROM CompanyMaster WHERE companyid='1'";
            DataTable dtCompany = _objsqlhelper.GetDataTable(strCompany);

            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhatawaniNo + "')";
            DataTable dtCustomer = _objsqlhelper.GetDataTable(CustomerInfo);

            _oVIReport.Database.Tables["dt_CompanyMaster"].SetDataSource(dtCompany);
            _oVIReport.Database.Tables["dt_CustomerMaster"].SetDataSource(dtCustomer);

            string YearStartAmount = _objGirviCommon.getGirviYearStartAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string YearStartInterestAmount = _objGirviCommon.getGirviInterestYearStartAmountByKhatawaniNoforform14(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());

            string GirviAddAmount = _objGirviCommon.getGirviCurrentYearAddAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string GirviReleaseAmount = _objGirviCommon.getGirviCurrentYearReleaseAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string YearEndInterest = _objGirviCommon.getGirviYearEndInterestByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());

            _oVIReport.SetParameterValue("YearStartAmount", YearStartAmount);
            _oVIReport.SetParameterValue("YearStartInterestAmount", YearStartInterestAmount);

            _oVIReport.SetParameterValue("GirviAddAmount", GirviAddAmount);
            _oVIReport.SetParameterValue("TotalPreCurr", Convert.ToDouble(YearStartAmount) + Convert.ToDouble(GirviAddAmount));
            _oVIReport.SetParameterValue("GirviReleaseAmount", GirviReleaseAmount);
            _oVIReport.SetParameterValue("GirviInterestAmount", _objGirviCommon.getGirviCurrentYearReleaseInterestAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString()));

            _oVIReport.SetParameterValue("YearEndBal", GirviAddAmount);
            _oVIReport.SetParameterValue("YearEndInterest", Convert.ToDouble(YearEndInterest) - Convert.ToDouble(YearStartInterestAmount));
            _oVIReport.SetParameterValue("StartYear", dtFiancialYear.Rows[0]["startyear"].ToString());
            _oVIReport.SetParameterValue("EndYear", dtFiancialYear.Rows[0]["endyear"].ToString());
            //  _oVIReport.SetParameterValue("GirviInterestAmount", GirviInterestAmount);

            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")//&& strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                }
            }
        }


        public void ReceiveDataForm14(string KhatawaniNo, bool other)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();

            CrystalDecisions.CrystalReports.Engine.ReportDocument _oVIReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            _oVIReport.Load(Environment.CurrentDirectory + "\\Crt_BabulgaonVaarrshikVivranPatra.rpt");


            string strCompany = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat FROM CompanyMaster WHERE companyid='1'";
            DataTable dtCompany = _objsqlhelper.GetDataTable(strCompany);

            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhatawaniNo + "')";
            DataTable dtCustomer = _objsqlhelper.GetDataTable(CustomerInfo);

            _oVIReport.Database.Tables["dt_CompanyMaster"].SetDataSource(dtCompany);
            _oVIReport.Database.Tables["dt_CustomerMaster"].SetDataSource(dtCustomer);

            string YearStartAmount = _objGirviCommon.getGirviYearStartAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string YearStartInterestAmount = _objGirviCommon.getGirviInterestYearStartAmountByKhatawaniNoforform14(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());

            string GirviAddAmount = _objGirviCommon.getGirviCurrentYearAddAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string GirviReleaseAmount = _objGirviCommon.getGirviCurrentYearReleaseAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string YearEndInterest = _objGirviCommon.getGirviYearEndInterestByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());

            _oVIReport.SetParameterValue("YearStartAmount", YearStartAmount);
            _oVIReport.SetParameterValue("YearStartInterestAmount", YearStartInterestAmount);

            _oVIReport.SetParameterValue("GirviAddAmount", GirviAddAmount);
            _oVIReport.SetParameterValue("TotalPreCurr", Convert.ToDouble(YearStartAmount) + Convert.ToDouble(GirviAddAmount));
            _oVIReport.SetParameterValue("GirviReleaseAmount", GirviReleaseAmount);
            _oVIReport.SetParameterValue("GirviInterestAmount", _objGirviCommon.getGirviCurrentYearReleaseInterestAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString()));

            _oVIReport.SetParameterValue("YearEndBal", GirviAddAmount);
            _oVIReport.SetParameterValue("YearEndInterest", Convert.ToDouble(YearEndInterest) - Convert.ToDouble(YearStartInterestAmount));
            _oVIReport.SetParameterValue("StartYear", dtFiancialYear.Rows[0]["startyear"].ToString());
            _oVIReport.SetParameterValue("EndYear", dtFiancialYear.Rows[0]["endyear"].ToString());



            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {

                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")//&& strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }

                }
            }

        }

        public void ReceiveKhatawaniList(DataTable dtKhatawani, bool other)
        {
            JewelleryManagement.CrystalReport.CrystalReport_Girvi.Crt_KhatawaniList _oVIReport = new JewelleryManagement.CrystalReport.CrystalReport_Girvi.Crt_KhatawaniList();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2 FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[1].SetDataSource(dt2);
            _oVIReport.Database.Tables[0].SetDataSource(dtKhatawani);
           
          //  _oVIReport.SetParameterValue("enddate", EndDate);
            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")// && strrr != "Addresssline21" && strrr != "city1" && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }


        public void ReceiveDataForm12Multi(string KhatawaniNo, bool other, string PrinterName)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();


            CrystalReport.CrystalReport_Girvi.crt_formno12 _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_formno12();
            string strCompany = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat FROM CompanyMaster WHERE companyid='1'";
            DataTable dtCompany = _objsqlhelper.GetDataTable(strCompany);

            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhatawaniNo + "')";
            DataTable dtCustomer = _objsqlhelper.GetDataTable(CustomerInfo);

            _oVIReport.Database.Tables["dt_CompanyMaster"].SetDataSource(dtCompany);
            _oVIReport.Database.Tables["dt_CustomerMaster"].SetDataSource(dtCustomer);

            string YearStartAmount = _objGirviCommon.getGirviYearStartAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string GirviAddAmount = _objGirviCommon.getGirviCurrentYearAddAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string GirviReleaseAmount = _objGirviCommon.getGirviCurrentYearReleaseAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string YearEndInterest = _objGirviCommon.getGirviYearEndInterestByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());

            _oVIReport.SetParameterValue("YearStartAmount", YearStartAmount);
            _oVIReport.SetParameterValue("GirviAddAmount", GirviAddAmount);
            _oVIReport.SetParameterValue("TotalPreCurr", Convert.ToDouble(YearStartAmount) + Convert.ToDouble(GirviAddAmount));
            _oVIReport.SetParameterValue("GirviReleaseAmount", GirviReleaseAmount);
            _oVIReport.SetParameterValue("YearEndBal", GirviAddAmount);
            _oVIReport.SetParameterValue("YearEndInterest", YearEndInterest);
            _oVIReport.SetParameterValue("StartYear", dtFiancialYear.Rows[0]["startyear"].ToString());
            _oVIReport.SetParameterValue("EndYear", dtFiancialYear.Rows[0]["endyear"].ToString());



            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {

                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")//&& strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    _oVIReport.PrintOptions.PrinterName = PrinterName;
                    _oVIReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            else
            {
                _oVIReport.PrintOptions.PrinterName = PrinterName;
                _oVIReport.PrintToPrinter(1, false, 0, 0);
            }
        }

        public void ReceiveDataForm14Multi(string KhatawaniNo, bool other, string PrinterName)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();

            CrystalDecisions.CrystalReports.Engine.ReportDocument _oVIReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            _oVIReport.Load(Environment.CurrentDirectory + "\\Crt_BabulgaonVaarrshikVivranPatra.rpt");


            string strCompany = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,Antargat FROM CompanyMaster WHERE companyid='1'";
            DataTable dtCompany = _objsqlhelper.GetDataTable(strCompany);

            string CustomerInfo = "SELECT khatawani_No As khatawani_NoCustomer , FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhatawaniNo + "')";
            DataTable dtCustomer = _objsqlhelper.GetDataTable(CustomerInfo);

            _oVIReport.Database.Tables["dt_CompanyMaster"].SetDataSource(dtCompany);
            _oVIReport.Database.Tables["dt_CustomerMaster"].SetDataSource(dtCustomer);

            string YearStartAmount = _objGirviCommon.getGirviYearStartAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string YearStartInterestAmount = _objGirviCommon.getGirviInterestYearStartAmountByKhatawaniNoforform14(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());

            string GirviAddAmount = _objGirviCommon.getGirviCurrentYearAddAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string GirviReleaseAmount = _objGirviCommon.getGirviCurrentYearReleaseAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());
            string YearEndInterest = _objGirviCommon.getGirviYearEndInterestByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString());

            _oVIReport.SetParameterValue("YearStartAmount", YearStartAmount);
            _oVIReport.SetParameterValue("YearStartInterestAmount", YearStartInterestAmount);

            _oVIReport.SetParameterValue("GirviAddAmount", GirviAddAmount);
            _oVIReport.SetParameterValue("TotalPreCurr", Convert.ToDouble(YearStartAmount) + Convert.ToDouble(GirviAddAmount));
            _oVIReport.SetParameterValue("GirviReleaseAmount", GirviReleaseAmount);
            _oVIReport.SetParameterValue("GirviInterestAmount", _objGirviCommon.getGirviCurrentYearReleaseInterestAmountByKhatawaniNo(dtCustomer.Rows[0]["khatawani_NoCustomer"].ToString()));

            _oVIReport.SetParameterValue("YearEndBal", GirviAddAmount);
            _oVIReport.SetParameterValue("YearEndInterest", Convert.ToDouble(YearEndInterest) - Convert.ToDouble(YearStartInterestAmount));
            _oVIReport.SetParameterValue("StartYear", dtFiancialYear.Rows[0]["startyear"].ToString());
            _oVIReport.SetParameterValue("EndYear", dtFiancialYear.Rows[0]["endyear"].ToString());



            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {

                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")//&& strrr != "Addressline21" && strrr != "city1" && strrr != "receiptno1" && strrr != "CompanyName2" && strrr != "Addressline12" && strrr != "Addressline22" && strrr != "city2" && strrr != "receiptno4")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    _oVIReport.PrintOptions.PrinterName = PrinterName;
                    _oVIReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            else
            {
                _oVIReport.PrintOptions.PrinterName = PrinterName;
                _oVIReport.PrintToPrinter(1, false, 0, 0);
            }

        }

        public void ReceiveDataAllKhatawaniGirviDetails(DataTable dtData, string EndDate, bool other)
        {
            CrystalReport.CrystalReport_Girvi.Crt_khatawaniwithgirvi _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_khatawaniwithgirvi();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,District,Tahsil,PinCode,Antargat,Antargat FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dtData);
            _oVIReport.Database.Tables[1].SetDataSource(dt2);
            _oVIReport.SetParameterValue("enddate", EndDate);
            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")// && strrr != "Addresssline21" && strrr != "city1" && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }


        public void ReceiveDataGirviByAdtess(DataTable dtData, string EndDate, bool other)
        {
            CrystalReport.CrystalReport_Girvi.Crt_GirviByAdress _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_GirviByAdress();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,PinCode,Tahsil,District,State,LicenceNo FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);
            _oVIReport.Database.Tables[1].SetDataSource(dtData);

            _oVIReport.SetParameterValue("enddate", EndDate);
            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")// && strrr != "Addresssline21" && strrr != "city1" && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }




        public void ReceiveDataAllKhatawaniReleaseGirviDetails(DataTable dtData, string EndDate, bool other)
        {
            CrystalReport.CrystalReport_Girvi.Crt_khatawaniwithReleasegirvi _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_khatawaniwithReleasegirvi();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,LicenceNo,District,Tahsil,PinCode,Antargat,Antargat FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dtData);
            _oVIReport.Database.Tables[1].SetDataSource(dt2);
            _oVIReport.SetParameterValue("enddate", EndDate);
            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")// && strrr != "Addresssline21" && strrr != "city1" && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }


        public void ReceiveDataAllKhatawaniUnReleaseGirviDetails(DataTable dtData, string EndDate, string IntrestDate, string StartDate, bool other)
        {
            CrystalReport.CrystalReport_Girvi.Crt_khatawaniwithUnReleasegirvi _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_khatawaniwithUnReleasegirvi();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,PinCode,Tahsil,District,State FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dtData);
            _oVIReport.Database.Tables[1].SetDataSource(dt2);
            _oVIReport.SetParameterValue("intrestdate", IntrestDate);
            _oVIReport.SetParameterValue("enddate", EndDate);
            _oVIReport.SetParameterValue("startdate", StartDate);
            crReportViewer.ReportSource = _oVIReport;
            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text2" && strrr != "Text3")//&& strrr != "Addresssline21" && strrr != "city1" && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }





        public void ReceiveDataInterestRecord(DataTable dtData, string KhNo, string TotalAmountNaaveSum, string TotalAmountJamaSum, string AccountBalance, bool other)
        {

            string crname;

            crname = "Select Khatawani from tbl_GirviCrystalReports";

            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            //crt_CustomerSale _objReport = new crt_CustomerSale();
            CrystalDecisions.CrystalReports.Engine.ReportDocument _oVIReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            _oVIReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["Khatawani"].ToString());




            //  CrystalReport.CrystalReport_Girvi.crt_InterestRecord _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_InterestRecord();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,PinCode,Tahsil,District,State FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);

            string str3 = "SELECT FullName, Address,Contact_No FROM Customer_Master WHERE (khatawani_No='" + KhNo + "')";
            DataTable dt3 = _objsqlhelper.GetDataTable(str3);




            _oVIReport.Database.Tables[1].SetDataSource(dtData);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);

            _oVIReport.SetParameterValue("TotalAmountNaave", TotalAmountNaaveSum);
            _oVIReport.SetParameterValue("TotalAmountJama", TotalAmountJamaSum);
            _oVIReport.SetParameterValue("Name", dt3.Rows[0]["FullName"]);
            _oVIReport.SetParameterValue("Address", dt3.Rows[0]["Address"]);
            _oVIReport.SetParameterValue("Contact_No", dt3.Rows[0]["Contact_No"]);
            _oVIReport.SetParameterValue("khatawani", KhNo);
            _oVIReport.SetParameterValue("AccountBalance", AccountBalance);


            crReportViewer.ReportSource = _oVIReport;

            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "khatawani1" && strrr != "Text2" && strrr != "CompanyName1" && strrr != "Text13")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }

        public void ReceiveDataInterestRecordMultiPrint(DataTable dtData, string KhNo, string TotalAmountNaaveSum, string TotalAmountJamaSum, string PrinterName, bool other)
        {

            //  CrystalDecisions.CrystalReports.Engine.ReportDocument _oVIReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            // _oVIReport.Load(Environment.CurrentDirectory + "\\crt_InterestRecord.rpt");

            CrystalReport.CrystalReport_Girvi.crt_InterestRecord _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_InterestRecord();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2 FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);

            string str3 = "SELECT FullName,Address FROM Customer_Master WHERE (khatawani_No='" + KhNo + "')";
            DataTable dt3 = _objsqlhelper.GetDataTable(str3);

            _oVIReport.Database.Tables[1].SetDataSource(dtData);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);

            _oVIReport.SetParameterValue("TotalAmountNaave", TotalAmountNaaveSum);
            _oVIReport.SetParameterValue("TotalAmountJama", TotalAmountJamaSum);
            _oVIReport.SetParameterValue("Name", dt3.Rows[0]["FullName"]);
            _oVIReport.SetParameterValue("Address", dt3.Rows[0]["Address"]);
            _oVIReport.SetParameterValue("khatawani", KhNo);




            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "khatawani1" && strrr != "Text2" && strrr != "CompanyName1" && strrr != "Text13")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    _oVIReport.PrintOptions.PrinterName = PrinterName;
                    _oVIReport.PrintToPrinter(1, false, 0, 0);
                }
            }
            else
            {
                _oVIReport.PrintOptions.PrinterName = PrinterName;
                _oVIReport.PrintToPrinter(1, false, 0, 0);
            }

        }


        public void ReceiveRokadAllRecord(DataTable dtData, bool other, string opening)
        {
            string crname;
            crname = "Select RokadAll from tbl_GirviCrystalReports";
            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            CrystalDecisions.CrystalReports.Engine.ReportDocument _oVIReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            _oVIReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["RokadAll"].ToString());


            //CrystalReport.CrystalReport_Girvi.crt_RokadAll _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_RokadAll();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,Post,Tahsil,District,State,PinCode FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);

            //string str3 = "SELECT FullName,Address FROM Customer_Master WHERE (khatawani_No='" + KhNo + "')";
            //DataTable dt3 = _objsqlhelper.GetDataTable(str3);

            _oVIReport.Database.Tables[1].SetDataSource(dtData);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);

            //_oVIReport.SetParameterValue("TotalAmountNaave", TotalAmountNaaveSum);
            //_oVIReport.SetParameterValue("TotalAmountJama", TotalAmountJamaSum);
            //_oVIReport.SetParameterValue("Name", dt3.Rows[0]["FullName"]);
            //_oVIReport.SetParameterValue("Address", dt3.Rows[0]["Address"]);
            _oVIReport.SetParameterValue("Opening", opening);


            crReportViewer.ReportSource = _oVIReport;

            if (other == true)
            {

                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "khatawani1" && strrr != "Text2" && strrr != "CompanyName1" && strrr != "Text13")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }


        public void ReceiveCashbookRecord(DataTable dtData, string startdate, string enddate, bool other)
        {
            CrystalReport.CrystalReport_Girvi.crt_CashBook _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_CashBook();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2 FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);

            //_oVIReport.Database.Tables[1].SetDataSource(dtData);
            _oVIReport.Database.Tables[0].SetDataSource(dtData);

            _oVIReport.SetParameterValue("startdate", startdate);
            _oVIReport.SetParameterValue("enddate", enddate);

            crReportViewer.ReportSource = _oVIReport;

            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "khatawani1" && strrr != "Text2" && strrr != "CompanyName1" && strrr != "Text13")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }

        public void ReceiveRokadMultiRecord(DataTable dtData, string PrinterName, bool other, string pageno, string opening, string CurrentOpening)
        {
            string crname;
            crname = "Select Rokad from tbl_GirviCrystalReports";
            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);



            CrystalDecisions.CrystalReports.Engine.ReportDocument _oVIReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            //_oVIReport.Load(Environment.CurrentDirectory + "\\crt_RokadMultiPrint.rpt");
            _oVIReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["Rokad"].ToString());


            //CrystalReport.CrystalReport_Girvi.crt_Rokad _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_Rokad();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,Post,Tahsil,District,State,PinCode FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);

            //string str3 = "SELECT FullName,Address FROM Customer_Master WHERE (khatawani_No='" + KhNo + "')";
            //DataTable dt3 = _objsqlhelper.GetDataTable(str3);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);

            _oVIReport.Database.Tables[1].SetDataSource(dtData);


            _oVIReport.SetParameterValue("sumAmountNave", _objCommon.sumDataTableColumn(dtData, "AmountNave"));
            _oVIReport.SetParameterValue("sumAmountJama", _objCommon.sumDataTableColumn(dtData, "AmountJama"));
            _oVIReport.SetParameterValue("sumInterestJama", _objCommon.sumDataTableColumn(dtData, "InterestJama"));
            _oVIReport.SetParameterValue("sumTotalAmountJama", _objCommon.sumDataTableColumn(dtData, "TotalAmountJama"));
            //int nave = Convert.ToInt32(_objCommon.sumDataTableColumn(dtData, "TotalAmountJama"));
            //int jama = Convert.ToInt32(_objCommon.sumDataTableColumn(dtData, "AmountJama"));
            //if (nave > jama)
            //{
            //    int JamaBal = nave - jama;
            //    _oVIReport.SetParameterValue("JamaBal", JamaBal);
            //}

            //if (jama  > nave)
            //{
            //    int NaveBal = jama -nave;
            //    _oVIReport.SetParameterValue("NaveBal", NaveBal);
            //}


            _oVIReport.SetParameterValue("opening", opening);
            _oVIReport.SetParameterValue("pageno", pageno);
            _oVIReport.SetParameterValue("CurrentOpening", CurrentOpening);

            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "khatawani1" && strrr != "Text2" && strrr != "CompanyName1" && strrr != "Text13")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
            crReportViewer.ReportSource = _oVIReport;

            _oVIReport.PrintOptions.PrinterName = PrinterName;
            _oVIReport.PrintToPrinter(1, true, 1, 99);


        }

        public void ReceiveDataBhandval(DataTable dtData, string EndDate, bool Other)
        {
            string crname;
            crname = "Select Bhandval from tbl_GirviCrystalReports";
            DataTable dt_crname = _objsqlhelper.GetDataTable(crname);
            CrystalDecisions.CrystalReports.Engine.ReportDocument _oVIReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            _oVIReport.Load(Environment.CurrentDirectory + "\\" + dt_crname.Rows[0]["Bhandval"].ToString());




            // CrystalReport.CrystalReport_Girvi.crt_Bhandval _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_Bhandval();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,Post,Tahsil,District,State,PinCode FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dtData);
            _oVIReport.Database.Tables[1].SetDataSource(dt2);
            crReportViewer.ReportSource = _oVIReport;

            if (Other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text7" && strrr != "Text4")// && strrr != "Addresssline21" && strrr != "city1" && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }


        public void ReceiveDataBalanceSheetMonthwise(DataTable dtData, bool Other)
        {
            CrystalReport.CrystalReport_Girvi.crt_balsheetmontwise _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_balsheetmontwise();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2 FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dtData);
            _oVIReport.Database.Tables[1].SetDataSource(dt2);
            crReportViewer.ReportSource = _oVIReport;

            if (Other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text7" && strrr != "Text4")// && strrr != "Addresssline21" && strrr != "city1" && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }

        public void ReceiveDataForwardGirvi(DataTable dtData, string StartDate, string EndDate, bool other)
        {
            CrystalReport.CrystalReport_Girvi.crt_ForwardGirviReport _oVIReport = new CrystalReport.CrystalReport_Girvi.crt_ForwardGirviReport();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2 FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[1].SetDataSource(dtData);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);
            _oVIReport.SetParameterValue("startdate", StartDate);
            _oVIReport.SetParameterValue("enddate", EndDate);

            crReportViewer.ReportSource = _oVIReport;

            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (field != null)
                        {
                            if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addresssline21" && strrr != "city1")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                                field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                        }
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
            crReportViewer.ReportSource = _oVIReport;

        }

        public void ReceiveCashInHand(DataTable dtData, string EndDate, bool Other)
        {
            CrystalReport.CrystalReport_Girvi.Crt_CashInHand _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_CashInHand();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2 FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dtData);
            _oVIReport.Database.Tables[1].SetDataSource(dt2);
            crReportViewer.ReportSource = _oVIReport;
            if (Other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addresssline21" && strrr != "city1")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }

        public void ReceiveTotalInterest(DataTable dtData,string MonthYear,bool Other)
                             {
            CrystalReport.CrystalReport_Girvi.Crt_TotalIntreset _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_TotalIntreset();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2 FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);
            _oVIReport.Database.Tables[1].SetDataSource(dtData);
            _oVIReport.SetParameterValue("MonthYear", MonthYear);
            crReportViewer.ReportSource = _oVIReport;
            if (Other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addresssline21" && strrr != "city1")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }

        // public void ReciveDataVinaTaranReport(DataTable dtData,string EndDate, bool Other)
        public void ReciveDataVinaTaranReport(DataTable dtData, bool Other)
        {
            CrystalReport.CrystalReport_Girvi.Crt_VinaTaranReport _objVinaTaran = new CrystalReport.CrystalReport_Girvi.Crt_VinaTaranReport();

            string CompanyMaster = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo FROM CompanyMaster Where companyid='1'";
            // string strGriviMaster = " SELECT khatawani_No ,FullName,Contact_No ,Address ,Balance,Opening_date ,cast,occupation ,Address2 ,DateTime,District FROM Customer_Master";
            // string strCustomerData = " SELECT GirviRecordNo ,khatawani_No ,duration,Release,Actual_InterestRate,reason,Amount,Date_of_deposit,interset_rate ,Status,withdraw_release_date,loantype FROM GirviMaster";

            //string strGriviMaster = " SELECT  Customer_Master.khatawani_No , Customer_Master.FullName, Customer_Master.Contact_No,Customer_Master.Address,Customer_Master.Balance,Customer_Master.Opening_date,Customer_Master.cast,Customer_Master.occupation,Customer_Master.Address2,Customer_Master.DateTime,Customer_Master.District,GirviMaster.duration,GirviMaster.Release,GirviMaster.Actual_InterestRate,GirviMaster.reason, GirviMaster.GirviRecordNo, GirviMaster.Amount, GirviMaster.Date_of_deposit,  GirviMaster.interset_rate, GirviMaster.Status, GirviMaster.withdraw_release_date,GirviMaster.loantype FROM   Customer_Master INNER JOIN  GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No where  (CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + start + "', 103)) and (CONVERT(DateTime, Date_of_deposit, 103) <=  CONVERT(DateTime, '" + end + "' , 103)) AND(GirviMaster.loantype= N'" + "विनातारण" + "')";
            DataTable dt1 = _objsqlhelper.GetDataTable(CompanyMaster);
            //DataTable dt2 = _objsqlhelper.GetDataTable(strGriviMaster);
            // DataTable dt3 = _objsqlhelper.GetDataTable(strCustomerData);

            _objVinaTaran.Database.Tables[0].SetDataSource(dtData);
            _objVinaTaran.Database.Tables[1].SetDataSource(dt1);


            //  _objVinaTaran.Database.Tables[2].SetDataSource(dt3);

            crReportViewer.ReportSource = _objVinaTaran;

            if (Other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _objVinaTaran.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _objVinaTaran.ReportDefinition.ReportObjects[i].Name;

                    field = _objVinaTaran.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _objVinaTaran.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addresssline21" && strrr != "city1")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }


        }



        public void ReceiveDataGirviByAddress(DataTable dtData, bool other)
        {
            CrystalReport.CrystalReport_Girvi.Crt_NitinTumsarGirviByAddress _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_NitinTumsarGirviByAddress();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Tahsil,District,State,PinCode FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);
            _oVIReport.Database.Tables[1].SetDataSource(dtData);
            //_oVIReport.SetParameterValue("enddate", EndDate);
            crReportViewer.ReportSource = _oVIReport;

            if (other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "Text1" && strrr != "Text4" && strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addressline21")//&& strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }
        public void ReceiveSixMonth(DataTable dtData, bool Other)
        {
            CrystalReport.CrystalReport_Girvi.SixMonthReport _oVIReport = new CrystalReport.CrystalReport_Girvi.SixMonthReport();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2 FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);
            _oVIReport.Database.Tables[1].SetDataSource(dtData);
           // _oVIReport.SetParameterValue("MonthYear", MonthYear);
            crReportViewer.ReportSource = _oVIReport;
            if (Other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addresssline21" && strrr != "city1")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }

        public void ReceiveMonthWiseReport()
        {
            DataTable BeforeYearStart = _objGirviCommon.getGirviYearStartAmountBefore();
            DataTable AfterYearStart = _objGirviCommon.getGirviYearStartAmountAfter(DateTime.Now.ToString("dd/MM/yyyy"));
            int month = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")).Month;
            int year = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")).Year;
            DataTable AfterYearToLastMonth=_objGirviCommon.getGirviYearStartAmountAfter(Convert.ToDateTime(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")).AddMonths(-1)).ToString("dd/MM/yyyy"));
            string CurrentMonthStartDate = "01/" + month + "/" + year;
            DataTable CurrentMonthStartToNow = _objGirviCommon.getGirviAmount(CurrentMonthStartDate, DateTime.Now.ToString("dd/MM/yyyy"));

            DataTable dt = new DataTable();
            dt.Columns.Add("1");
            dt.Columns.Add("2");
            dt.Columns.Add("A3");
            dt.Columns.Add("4");
            dt.Columns.Add("5");
            dt.Columns.Add("6");
            dt.Columns.Add("7");
            dt.Columns.Add("8");
            dt.Columns.Add("9");
            dt.Columns.Add("10");
            dt.Columns.Add("11");
            dt.Columns.Add("12");
            dt.Columns.Add("13");
            dt.Columns.Add("14");
            dt.Columns.Add("15");
            dt.Columns.Add("16");
            dt.Columns.Add("17");

            dt.Rows.Add();
            dt.Rows[0]["1"] = "";
            dt.Rows[0]["2"] = "";
            dt.Rows[0]["A3"] = BeforeYearStart.Rows[0]["Count"];
            dt.Rows[0]["4"] = BeforeYearStart.Rows[0]["Amount"];
            dt.Rows[0]["5"] = AfterYearStart.Rows[0]["Count"];
            dt.Rows[0]["6"] = AfterYearStart.Rows[0]["Amount"];
            dt.Rows[0]["7"] = "";
            dt.Rows[0]["8"] = "";
            dt.Rows[0]["9"] = "";
            dt.Rows[0]["10"] = AfterYearStart.Rows[0]["Count"];
            dt.Rows[0]["11"] = AfterYearStart.Rows[0]["Amount"];
            dt.Rows[0]["12"] = AfterYearToLastMonth.Rows[0]["Count"];
            dt.Rows[0]["13"] = AfterYearToLastMonth.Rows[0]["Amount"];
            dt.Rows[0]["14"] = CurrentMonthStartToNow.Rows[0]["Count"];
            dt.Rows[0]["15"] = CurrentMonthStartToNow.Rows[0]["Amount"];
            dt.Rows[0]["16"] = (Convert.ToDouble(AfterYearToLastMonth.Rows[0]["Count"].ToString()) + Convert.ToDouble(CurrentMonthStartToNow.Rows[0]["Count"].ToString())).ToString();
            dt.Rows[0]["17"] = (Convert.ToDouble(AfterYearToLastMonth.Rows[0]["Amount"].ToString()) + Convert.ToDouble(CurrentMonthStartToNow.Rows[0]["Amount"].ToString())).ToString();

            CrystalReport.CrystalReport_Girvi.Crt_KaranjaLaadMonthlyReport _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_KaranjaLaadMonthlyReport();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2 FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            string str3 = "SELECT startyear,endyear From FinancialYearMaster WHERE (isSelected='" + true + "') ";
            DataTable dt3 = _objsqlhelper.GetDataTable(str3);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);
            _oVIReport.Database.Tables[2].SetDataSource(dt);
            _oVIReport.Database.Tables[1].SetDataSource(dt3);
            crReportViewer.ReportSource = _oVIReport;
        }

        public void ReceiveGirviReportData(DataTable dtData, bool Other)
        {
            CrystalReport.CrystalReport_Girvi.Crt_KaranjaLaadGirviReport _oVIReport = new CrystalReport.CrystalReport_Girvi.Crt_KaranjaLaadGirviReport();
            string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Antargat,LicenceNo,Post,Tahsil,District,State,PinCode FROM CompanyMaster Where companyid='1'";
            DataTable dt2 = _objsqlhelper.GetDataTable(str2);
            _oVIReport.Database.Tables[0].SetDataSource(dt2);
            _oVIReport.Database.Tables[1].SetDataSource(dtData);
            // _oVIReport.SetParameterValue("MonthYear", MonthYear);
            crReportViewer.ReportSource = _oVIReport;
            if (Other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _oVIReport.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _oVIReport.ReportDefinition.ReportObjects[i].Name;

                    field = _oVIReport.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _oVIReport.ReportDefinition.ReportObjects[i] as TextObject;

                    if (field != null)
                    {
                        if (strrr != "CompanyName1" && strrr != "Addressline11" && strrr != "Addresssline21" && strrr != "city1")// && strrr != "Name2" && strrr != "Addressline12" && strrr != "Addresssline22" && strrr != "city2")
                            field.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Regular));
                    }
                    //if (texto != null)
                    //{
                    //    texto.ApplyFont(new Font("Shivaji02", 12f, FontStyle.Bold));
                    //}
                }
            }
        }


        public static string funNumToWordConvert(decimal number)
        {

            string wordNumber = string.Empty;

            string[] arrNumber = number.ToString().Split('.');

            long wholePart = long.Parse(arrNumber[0]);
            string strWholePart = funConvert(wholePart);

            if (number == wholePart)
            {
                return strWholePart;
            }
            else
            {
                wordNumber = (wholePart == 0 ? "No" : strWholePart) + (wholePart == 1 ? " Dollar and " : " पॉईंट ");


                if (arrNumber.Length > 1)
                {

                    long fractionPart = long.Parse((arrNumber[1].Length == 1 ? arrNumber[1] + "0" : arrNumber[1]));
                    string strFarctionPart = funConvert(fractionPart);

                    wordNumber += (fractionPart == 0 ? " No" : strFarctionPart) + (fractionPart == 1 ? " Cent" : "");
                }
                else
                    wordNumber += "No Cents";
            }



            return wordNumber;
        }

        public void ReciveDataCustprint(DataTable dtData, bool Other)
        {

            // CrystalReport.CrystalReport_Girvi.Crt_CustomerPrintList _objCust =  new CrystalReport.CrystalReport_Girvi.Crt_CustomerPrintList();
            CrystalReport.CrystalReport_Girvi.Crt_CustomerPrintList _objCust = new CrystalReport.CrystalReport_Girvi.Crt_CustomerPrintList();
             string str2 = "SELECT CompanyName, Addressline1, Addressline2, city, phoneNo, MobNo, MobNo2,Tahsil,District,State,PinCode FROM CompanyMaster Where companyid='1'";
             DataTable dt2 = _objsqlhelper.GetDataTable(str2);

            _objCust.Database.Tables[1].SetDataSource(dtData);
            _objCust.Database.Tables[0].SetDataSource(dt2);

            //_objCust.Database.Tables[1].SetDataSource(dt1);

            crReportViewer.ReportSource = _objCust;

            if (Other == true)
            {
                FieldObject field;
                TextObject texto;

                for (int i = 0; i < _objCust.ReportDefinition.ReportObjects.Count; i++)
                {
                    string strrr = _objCust.ReportDefinition.ReportObjects[i].Name;

                    field = _objCust.ReportDefinition.ReportObjects[i] as FieldObject;
                    texto = _objCust.ReportDefinition.ReportObjects[i] as TextObject;

                }
            }

        }

        public static string funConvert(long num)
        {
            string amt = num.ToString();

            if (amt == "0")
            {
                return "शून्य";
            }
            string amt2 = num.ToString();
            if (amt2 == "100")
            {
                return "शंभर";
            }
            int[] amountArray;
            amountArray = new int[amt.Length];
            for (int i = amountArray.Length; i >= 1; i += -1)
            {
                amountArray[i - 1] = int.Parse(amt.Substring(i - 1, 1));
            }

            int j = 0;
            int digit = 0;
            string result = "";
            string separator = "";
            string higherDigitHindiString = "";
            string codeIndex = "";

            for (int i = amountArray.Length; i >= 1; i += -1)
            {
                j = amountArray.Length - i;
                digit = amountArray[j];

                codeIndex = SouthAsianCodeArray[i - 1];

                higherDigitHindiString = HigherDigitHindiNumberArray[Int32.Parse((codeIndex.Substring(0, 1))) - 1];

                if (codeIndex == "1")
                {
                    result = result + separator + HundredHindiDigitArray[digit];


                }

                else if (codeIndex.Length == 2 & digit != 0)
                {
                    int suffixDigit = amountArray[j + 1];
                    int wholeTenthPlaceDigit = digit * 10 + suffixDigit;

                    result = result + separator + HundredHindiDigitArray[wholeTenthPlaceDigit] + " " + higherDigitHindiString;
                    i -= 1;


                }

                else if (digit != 0)
                {
                    result = result + separator + HundredHindiDigitArray[digit] + " " + higherDigitHindiString;
                }
                separator = " ";
            }

            return result;
        }

        static string[] HundredHindiDigitArray = 
            {"", "एक", "दोन ", "तीन", "चार", "पाच ", "सहा", "सात", "आठ", "नऊ", "दहा", 
            "अकरा", "बारा", "तेरा", "चौदा", "पंधरा", "सोळा", "सतरा", "अठरा", "एकोणवीस", "वीस", 
            "एकवीस", "बावीस", "तेवीस", "चोवीस", "पंचवीस", "सव्वीस", "सत्तावीस", "अठ्ठावीस", "एकोणतीस","तीस", 
            "एकतीस", "बत्तीस", "तेहेतीस", "चौतीस", "पस्तीस", "छत्तीस", "सदतीस", "अडतीस", "एकोणचाळीस", "चाळीस", 
            "एक्केचाळीस", "बेचाळीस", "त्रेचाळीस", "चव्वेचाळीस", "पंचेचाळीस", "सेहेचाळीस", "सत्तेचाळीस", "अठ्ठेचाळीस", "एकोणपन्नास", " पन्नास", 
            "एक्कावन्न", "बावन्न", "त्रेपन्न", "चोपन्न", "पंचावन्न", "छप्पन्न", "सत्तावन्न", "अठ्ठावन्न", "एकोणसाठ", "साठ", 
            "एकसष्ठ", "बासष्ठ", "त्रेसष्ठ", "चौसष्ठ", "पासष्ठ", "सहासष्ठ", "सदुसष्ठ", "अडुसष्ठ", "एकोणसत्तर", "सत्तर", 
            "एक्काहत्तर", "बाहत्तर", "त्र्याहत्तर", "चौर्‍याहत्तर", "पंच्याहत्तर", "शहात्तर ", "सत्याहत्तर ", "अठ्ठ्याहत्तर ", "एकोण ऐंशी", "ऐंशी", 
            "एक्क्य़ाऐंशी", "ब्याऐंशी", "ञ्याऐंशी", "चौऱ्याऐंशी", "पंच्याऐंशी", "शहाऐंशी", "सत्त्याऐंशी", "अठ्ठ्याऐंशी", "एकोणनव्वद", "नव्वद", 
            "एक्क्याण्णव", "ब्याण्णव", "त्र्याण्णव", "चौऱ्याण्णव", " पंच्याण्णव", "शहाण्णव", "सत्त्याण्णव", "अठ्ठ्याण्णव", " नव्व्याण्णव","शंभर"};

        static string[] HigherDigitHindiNumberArray = { "", "", "शे", "हजार", "लाख", "करोड़", "अरब", "खरब", "नील" };
        static string[] SouthAsianCodeArray = {
        "1",
        "22",
        "3",
        "4",
        "42",
        "5",
        "52",
        "6",
        "62",
        "7",
        "72",
        "8",
        "82",
        "9",
        "92"
    };


        public string OtherFont { get; set; }

        private void frm_ReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}





