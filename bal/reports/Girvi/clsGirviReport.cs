using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Reports.Girvi
{
    public class clsGirviReport
    {
        SQLHelper _objSQLHelper = new SQLHelper();
        public DataTable getGirviDataReleased(string StartDate, string EndDate)
        {
            string querry = "SELECT Date_of_deposit, GirviRecordNo, Amount,  interset_rate,withdraw_release_date,Status,khatawani_No FROM GirviMaster WHERE ((CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime, '" + StartDate + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <= CONVERT(DateTime, '" + EndDate + "', 103))) AND  Status='" + "Release" + "'";
            DataTable dt = _objSQLHelper.GetDataTable(querry);
            return dt;
        }

        public DataTable getKhatavaniData(string khatawani_No)
        {
            string querry = "SELECT FullName,Contact_No From Customer_Master Where(khatawani_No = '" + khatawani_No + "')";
            DataTable dt = _objSQLHelper.GetDataTable(querry);
            return dt;
        }

        public DataTable getForwordGirviData(string start,string end)
        {
            string str = "SELECT GirviRecordNo, Date_of_deposit, Forwarded_to, Amount, Date_of_Forward,forwardamount,khatawani_No,ForwardCno,Interest  FROM GirviMaster WHERE (Forwarded_to IS NOT NULL) AND ((CONVERT(DateTime, Date_of_Forward, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, Date_of_Forward, 103) <=  CONVERT(DateTime, '" + end + "' , 103)))";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;

        }

        public DataTable getForwordGirviDataDatewise(string start, string end)
        {
            string str = "SELECT GirviRecordNo, Date_of_deposit, Forwarded_to, Amount, Date_of_Forward FROM  GirviMaster WHERE (Forwarded_to IS NOT NULL) AND ((CONVERT(DateTime, Date_of_Forward, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, Date_of_Forward, 103) <=  CONVERT(DateTime, '" + end + "' , 103)))";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;

        }

      

        public DataTable getAllGirviDatewiseUnrelease(string startdate, string enddate)
        {
            string cmd = "SELECT khatawani_No,GirviRecordNo, Amount,Date_of_deposit FROM GirviMaster WHERE (CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103)) and Status = 'unchange'";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

     
        public DataTable getAllGirviRelease(string startdate, string enddate)
        {
            string cmd = "SELECT Khatawani_no,Girvino,AmountDeposit,Interest_Amount,dateOfRelease FROM GirviReleasemaster WHERE  (CONVERT(DateTime, dateOfRelease, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, dateOfRelease, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getInterestPayTableDetail(string StartDate, string EndDate, string GirviNo)
        {
            string str = "SELECT        SrNo, Girvi_No, Date, Amount FROM tbl_newinterestpay WHERE    (CONVERT(DateTime, Date , 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, Date , 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103) And Girvi_No='" + GirviNo + "' )";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getInterestPayTableDetailByGirviNo(string GirviNo)
        {
            string str = "SELECT        SrNo, Girvi_No, Date, Amount FROM tbl_newinterestpay WHERE (Girvi_No='" + GirviNo + "' )";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getGirviData(String startdate, String enddate)
        {
            string querry = "SELECT Date_of_deposit, GirviRecordNo, Amount,  interset_rate, duration, Status,khatawani_No,receipt_no FROM GirviMaster WHERE (CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime, '" + startdate + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <= CONVERT(DateTime, '" + enddate + "', 103))";
            DataTable dt = _objSQLHelper.GetDataTable(querry);
            return dt;
        }

        public DataTable fillGirviData(string str)
        {
            string str1 = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt,reduce_wt, net_wt,wt_in_percent, fine_wt,Total_Quantity,current_rate,amount,txt_pavtino FROM GirviItemMaster WHERE (GirviNo = '" + str + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }
   
        public int DeleteInterestPayTableDetailByGirviNo(string GirviNo)
        {
            string str = "Delete FROM tbl_newinterestpay WHERE (SrNo='" + GirviNo + "' )";
           return  _objSQLHelper.ExecuteSql(str);
          
        }

    }
}
