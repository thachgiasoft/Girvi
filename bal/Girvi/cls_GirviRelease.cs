using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Girvi
{
 
   public class cls_GirviRelease
    {
       SQLHelper _objSQLHelper = new SQLHelper();


       public DataTable getNameandKhatawani()
       {
           string Str =  "SELECT FullName,khatawani_No FROM  Customer_Master";
           DataTable dt = _objSQLHelper.GetDataTable(Str);
           return dt;
       }

       public DataTable getGirviReceiptNo()
       {
          string str="SELECT  receipt_no FROM   GirviMaster";
          DataTable dt = _objSQLHelper.GetDataTable(str);
           return dt;
       }

       public DataTable getGirviKhatawaniNo()
       {
           string str = "SELECT  khatawani_No FROM   GirviMaster";
           DataTable dt = _objSQLHelper.GetDataTable(str);
           return dt;
       }
       public string getkhatawani_NobyReceiptNo(string receiptno)
       {
           string str = "SELECT  khatawani_No FROM   GirviMaster where receipt_no='"+receiptno+"'";
           string khatawani_No = _objSQLHelper.ExecuteScalar(str);

           return khatawani_No;
       }

    

       public DataTable getKhatawani( string KhatawaniName)
       {
           string str = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo  FROM   Customer_Master WHERE (FullName = N'" + KhatawaniName + "')";
         DataTable  dt = _objSQLHelper.GetDataTable(str);

           return dt;
       }

       public DataTable getKhatawaniNo(string KhatawaniNo)
       {
           string str = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo  FROM   Customer_Master WHERE (khatawani_No = '" + KhatawaniNo + "')";
           DataTable dt = _objSQLHelper.GetDataTable(str);

           return dt;
       }

       public DataTable getGirviDataFromKhatawani(string khatawani_No)
       {
           string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Status,forwardstatus,Forwarded_to,receipt_no,narration,forwardamount,Date_of_Forward, Interest FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "') AND  (Status = '" + "unchange" + "')";
          
           DataTable dt = _objSQLHelper.GetDataTable(str);
           return dt;
       }

       public DataTable getReleaseDataFromKhatawani(string khatawani_No)
       {
           string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Status,withdraw_release_date,narration FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "') AND (Status = '" + "Release" + "')";

           DataTable dt = _objSQLHelper.GetDataTable(str);
           return dt;
       }

       public DataTable getGirviData(string GirviNo)
       {
           string str = "SELECT GirviNo, metal_type, metal_type, item_type, item_type, gross_wt, net_wt, Total_Quantity,reduce_wt,wt_in_percent,current_rate,fine_wt,amount FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";

           DataTable dt = _objSQLHelper.GetDataTable(str);
           return dt;
       }

       public DataTable getinterestPaid(string GirviNo)
       {
           string str = "select Amount from tbl_newinterestpay where Girvi_No='" + GirviNo + "'";
           DataTable dt = _objSQLHelper.GetDataTable(str);
           return dt;
       }

       public DataTable getGirviItemdata(string GirviNo)
       {
           string Str = "SELECT GirviNo, metal_type, metal_type, item_type, item_type, gross_wt, net_wt, Total_Quantity,reduce_wt,wt_in_percent,current_rate,fine_wt,amount FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
           DataTable dt = _objSQLHelper.GetDataTable(Str);
           return dt;
       }

       public void SetGirvitoRelease(string KhNo, string GirviNo, string status, string DOR)
       {

           string update = "UPDATE  GirviMaster SET Status='" + "Release" + "', Release = '" + status + "',withdraw_release_date='" + DOR + "' WHERE    (khatawani_No = '" + KhNo + "') AND (GirviRecordNo = '" + GirviNo + "')";
            _objSQLHelper.ExecuteSql(update);
           
       }

       public void SetReleasemaster(string khatawaniNo, string Srno, string TotalAmount, string DepositDays, string InterestInPer, string InterestPaid, string DateOfRelease, string InterestAmount, string ReceiptNo, int financialYearId, string Narration)
        {
            string str = "INSERT INTO GirviReleasemaster (Khatawani_no, Girvino, AmountDeposit, TotalDays, intersetRate, IntersetPaid, dateOfRelease,Interest_Amount,pavtino,financialYearId,Narration) VALUES ('" + khatawaniNo + "', '" + Srno + "', '" + TotalAmount + "', '" + DepositDays + "', '" + InterestInPer + "', '" + InterestPaid + "', '" + DateOfRelease + "','" + InterestAmount + "','" + ReceiptNo + "','" + financialYearId + "',N'" + Narration + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public string UnreleaseGirvi(string k_n, string g_n, string d_o_r)
        {
            string s = "";
            string update = "UPDATE  GirviMaster SET Release = '" + "unreleased" + "', Status='" + "unchange" + "',withdraw_release_date='" + "" + "' WHERE    (khatawani_No = '" + k_n + "') AND (GirviRecordNo = '" + g_n + "')";
            string delete ="DELETE FROM GirviReleasemaster WHERE (Khatawani_no = '" + k_n + "') AND (Girvino = '" + g_n + "')";
            string intersetpaid = "SELECT   IntersetPaid FROM  GirviReleasemaster WHERE  (Khatawani_no = '" + k_n + "') AND (Girvino = '" + g_n + "')";

            int x = _objSQLHelper.ExecuteSql(update);
            if (x > 0)
            {
                s = Convert.ToString(_objSQLHelper.ExecuteScalar(intersetpaid));
                //SqlCommand insertRollBackAmount = new SqlCommand("INSERT INTO intersetGivenMaster (khatawaniNo, DateOfGiveAmount, AmountGiven) VALUES   ('" + k_n + "', '" + d_o_r + "', '" + s + "')");
                //int y = _objSQLHelper.nonquerry(insertRollBackAmount);
                int z = _objSQLHelper.ExecuteSql(delete);
            }
            return s;
        }

        public DataTable getReleaseGirvidata(string p)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Status,withdraw_release_date FROM GirviMaster WHERE (khatawani_No = '" + p + "') AND (Status = '" + "Release" + "')";
       
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public string getActualInterestRate(string p)
        {
            string str = "SELECT Actual_InterestRate FROM GirviMaster WHERE (GirviRecordNo = '" + p + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt.Rows[0]["Actual_InterestRate"].ToString();
        }

        public DataTable getGirviDataForNewAdd(string KhNo, string GnNo)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,purpose_of_loan,Actual_InterestRate,comment,receipt_no,reason,loantype FROM GirviMaster WHERE (khatawani_No = '" + KhNo + "') AND ( GirviRecordNo = '" + GnNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public void updateGirviMasterData(string GirviRecordNo, string updated_girvi_no,string dateofRelease)
        {
            string str = "UPDATE GirviMaster SET updated_girvi_no='" + updated_girvi_no + "',withdraw_release_date='"+dateofRelease+"' , Status ='" + "Release" + "' WHERE  (GirviRecordNo =" + GirviRecordNo + " )";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getKhatawaniByNameRelease(string cmb_FullName)
        {
            string cmd = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (FullName = N'" + cmb_FullName + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getReleaseGirviDetailsByKhatawaniAll(string txt_KhatawaniNo)
        {
            string str = "SELECT Khatawani_no, SrNo,Girvino, Item_Detials, AmountDeposit, TotalDays, intersetRate, IntersetPaid, dateOfRelease, Interest_Amount, pavtino, Narration, Girvino FROM GirviReleasemaster    WHERE  (Khatawani_no = '" + txt_KhatawaniNo + "') ";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getNameandKhatawaniRelease()
        {
            string Str = "SELECT        Customer_Master.FullName, Customer_Master.khatawani_No FROM   GirviReleasemaster INNER JOIN   Customer_Master ON GirviReleasemaster.Khatawani_no = Customer_Master.khatawani_No";
            DataTable dt = _objSQLHelper.GetDataTable(Str);
            return dt;
        }

        public DataTable getNarrationByGirvi(string Girvino)
        {
            string str = "select Narration,Girvino FROM GirviReleasemaster where (Girvino = '" + Girvino + "')  ";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
    }
}
