using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Reports.Girvi
{
    public class KhatawaniWithGirviBAL
    {
        SQLHelper _objSQLHelper = new SQLHelper();

        public DataTable getallgirvidata(string khno, string start, string end)
        {
            string str = "SELECT GirviRecordNo, khatawani_No, Amount, Date_of_deposit, interset_rate, duration, Status, withdraw_release_date,receipt_no FROM GirviMaster Where (khatawani_No = '" + khno + "') and (CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <=  CONVERT(DateTime, '" + end + "' , 103)) order by Date_of_deposit ASC"; //OR  ((CONVERT(DateTime, withdraw_release_date, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, withdraw_release_date, 103) <=  CONVERT(DateTime, '" + end + "' , 103)))) ";

            //string str = "SELECT GirviRecordNo, khatawani_No, Amount, Date_of_deposit, interset_rate, duration, Status, withdraw_release_date FROM GirviMaster Where (khatawani_No = '" + khno + "') and ((CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <=  CONVERT(DateTime, '" + end + "' , 103)))";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public DataTable getallReleasegirvidata(string khno, string start, string end)
        {
            string str = "SELECT GirviRecordNo, khatawani_No, Amount, Date_of_deposit, interset_rate, duration, Status, withdraw_release_date,receipt_no FROM GirviMaster Where (khatawani_No = '" + khno + "') and (CONVERT(DateTime, withdraw_release_date, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, withdraw_release_date, 103) <=  CONVERT(DateTime, '" + end + "' , 103)) order by Date_of_deposit ASC"; //OR  ((CONVERT(DateTime, withdraw_release_date, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, withdraw_release_date, 103) <=  CONVERT(DateTime, '" + end + "' , 103)))) ";

            //string str = "SELECT GirviRecordNo, khatawani_No, Amount, Date_of_deposit, interset_rate, duration, Status, withdraw_release_date FROM GirviMaster Where (khatawani_No = '" + khno + "') and ((CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <=  CONVERT(DateTime, '" + end + "' , 103)))";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getallgirviAddeddata(string khno, string start, string end)
        {
            string str = "SELECT GirviRecordNo, khatawani_No, Amount, Date_of_deposit, interset_rate, duration, Status, withdraw_release_date FROM GirviMaster Where (khatawani_No = '" + khno + "') and ((CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <=  CONVERT(DateTime, '" + end + "' , 103)))";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        //    public DataTable getKhatawaniByAddress(string adress)
        // {
        //  string str = "SELECT     Distinct   khatawani_No, FullName, Contact_No, Address FROM            Customer_Master WHERE        (Address = N'" + adress + "')";
        //return _objSQLHelper.GetDataTable(str);
        // }

        public DataTable getallkhatawaniNoinGirvi()
        {

            string str = "SELECT Distinct khatawani_No from GirviMaster";
            //  string str = "SELECT GirviMaster.khatawani_No,Customer_Master.FullName,Customer_Master.Contact_No,Customer_Master.adress ";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public DataTable getallkhatawaniNoinGirviByAddress(string adress)
        {

            string str = " SELECT  Customer_Master.khatawani_No, Customer_Master.FullName, Customer_Master.Address, GirviMaster.Netwt, GirviMaster.Amount, GirviMaster.Date_of_deposit, GirviMaster.GrossWt, GirviMaster.interset_rate, GirviMaster.Status, GirviMaster.withdraw_release_date   FROM  Customer_Master INNER JOIN  GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No where(Address=N'" + adress + "')";
            //  string str = "SELECT GirviMaster.khatawani_No,Customer_Master.FullName,Customer_Master.Contact_No,Customer_Master.adress ";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public DataTable getkhatawanidetail(string khno)
        {
            string str = "SELECT FullName, Address, Contact_No, khatawani_No FROM  Customer_Master WHERE  (khatawani_No = '" + khno + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public string GetGirviItemMetalByGirviNo(string gn)
        {
            string str1 = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt,reduce_wt, net_wt,wt_in_percent, fine_wt,Total_Quantity,current_rate,amount FROM GirviItemMaster WHERE (GirviNo = '" + gn + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt.Rows[0]["metal_type"].ToString().Trim() ;
        }
        //वैशाली//
        public DataTable GetGirviItemMetalWt(string gn, string grosswt)
        {
            string str1 = "SELECT GirviNo, gross_wt,amount FROM GirviItemMaster WHERE (GirviNo = '" + gn + "') and (gross_wt='" + grosswt + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable GetGirviItemMetalAmount(string gn)
        {
            string str1 = "SELECT gross_wt,amount FROM GirviItemMaster WHERE (GirviNo = '" + gn + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        //*******//

        public DataTable getAllReleaseGirvidataByGirviNo(string gn, string start, string end)
        {
            string str = "SELECT Khatawani_no, Girvino, AmountDeposit, intersetRate, IntersetPaid, dateOfRelease, Interest_Amount FROM GirviReleasemaster WHERE (Girvino = '" + gn + "') AND ((CONVERT(DateTime, dateOfRelease, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, dateOfRelease, 103) <=  CONVERT(DateTime, '" + end + "' , 103))) ";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public DataTable getAllReleaseGirvidataByGirviNo(string gn)
        {
            string str = "SELECT Khatawani_no, Girvino, AmountDeposit, intersetRate, IntersetPaid, dateOfRelease,pavtino, Interest_Amount FROM GirviReleasemaster WHERE (Girvino = '" + gn + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }


        public DataTable getkhatawanidetail()
        {
            string str = "SELECT     khatawani_No, FullName, Contact_No, Address, occupation, cast, Address2 FROM         Customer_Master Order by case IsNumeric(khatawani_No) when 1 then replicate('0',100-Len(khatawani_No))+khatawani_No else khatawani_No end";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public DataTable getExpiredGirviDetails()
        {

            // string str = "SELECT  Customer_Master.FullName, Customer_Master.Address,Customer_Master.Contact_No,GirviMaster.Amount,GirviMaster.interset_rate, GirviMaster.Date_of_deposit, GirviMaster.khatawani_No, GirviMaster.duration, GirviMaster.GirviRecordNo FROM  Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No WHERE     (CONVERT(DateTime, GirviMaster.duration, 103) <= CONVERT(DateTime, '" + duration + "', 103) and status='unchange')";          
            string str = "SELECT  Customer_Master.FullName, Customer_Master.Address,Customer_Master.Contact_No,GirviMaster.Amount,GirviMaster.interset_rate, GirviMaster.Date_of_deposit, GirviMaster.khatawani_No, GirviMaster.duration, GirviMaster.GirviRecordNo,Customer_Master.PageNo, GirviMaster.NSN FROM  Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No WHERE (status='unchange')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        //public DataTable getCustomerDetail(string KhatawaniNo)
        //{
        //    string str = "SELECT khatawani_No ,FullName, Contact_No, Address, Balance, Opening_date,DateTime FROM Customer_Master WHERE (khatawani_No = '" + KhatawaniNo + "')";
        //    DataTable dt = _objSQLHelper.GetDataTable(str);
        //    return dt;
        //}

        public DataTable GetGirviItemM()
        {
            string str = "SELECT Distinct GirviNo from GirviItemMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable GetGirviItem(string gn)
        {
            string str1 = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt,reduce_wt, net_wt,wt_in_percent, fine_wt,Total_Quantity,current_rate,amount FROM GirviItemMaster WHERE (GirviNo = '" + gn + "')";
            return _objSQLHelper.GetDataTable(str1);
            //return dt.Rows[0]["metal_type"].ToString().Trim()+"  " + dt.Rows[0]["item_type"].ToString().Trim();
        }


        public DataTable GetGirviItemDetailByGirviNo()
        {
            string str1 = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt,reduce_wt, net_wt,wt_in_percent, fine_wt,Total_Quantity,current_rate,amount FROM GirviItemMaster ";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }
    }
}
