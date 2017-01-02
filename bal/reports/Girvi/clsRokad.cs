using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAL;
using System.Data;

namespace BAL.Reports.Girvi
{
    public class clsRokad
    {
        SQLHelper _objSQLHelper = new SQLHelper();


        public DataTable getAllGirvi(string Date_of_deposit)
        {
            string cmd = "SELECT khatawani_No,GirviRecordNo, Amount,Date_of_deposit,receipt_no,interset_rate FROM GirviMaster WHERE (Date_of_deposit='" + Date_of_deposit + "')";//((Status = '" + "Release" + "') OR
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public string getGirviItem(string GirviNo)
        {
            string cmd = "SELECT metal_type,item_type,gross_wt,net_wt,wt_in_percent,fine_wt, Total_Quantity FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            string str = "", str2;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str +="(" + dt.Rows[i][0].ToString().Trim()+ ")" + " " + dt.Rows[i][1].ToString().Trim() + " दागिने वजन:" +dt.Rows[i][2].ToString().Trim()+"ग्राम";
                if (dt.Rows.Count > 1 && i != dt.Rows.Count - 1)
                {
                    str += ",";
                }
            }
            str2 = str;
            str = "";
            return str2;
        }

        public DataTable getnamefromID(string khatawani_No)
        {
            string str1 = "SELECT FullName, khatawani_No,Contact_No,Address FROM Customer_Master WHERE (khatawani_No = '" + khatawani_No + "')";

            //string dt = Convert.ToString(_objSQLHelper.ExecuteScalar(str1));
            //return dt;
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable getAllGirviRelease(string dateOfRelease)
        {
            string cmd = "SELECT Khatawani_no,Girvino,AmountDeposit,Interest_Amount,dateOfRelease,pavtino FROM GirviReleasemaster WHERE (dateOfRelease = '" + dateOfRelease + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public string getgirviitem(string p)
        {
            string cmd= "SELECT metal_type,item_type,gross_wt,net_wt,wt_in_percent,fine_wt, Total_Quantity FROM GirviItemMaster WHERE (GirviNo = '" + p + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            string str = "", str2;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str += "(" + dt.Rows[i][0].ToString().Trim() + ")" + dt.Rows[i][1].ToString() + ", ग्रॉस वजन:" + dt.Rows[i][2].ToString() + ", नेट वजन:" + dt.Rows[i][3].ToString();

                if (dt.Rows.Count > 1 && i != dt.Rows.Count - 1)
                {
                    str += ",";
                }
            }
            str2 = str;
            str = "";
            return str2;
           
        }

  public string getGirviItemForSagarPulgao(string GirviNo)
        {
            string cmd = "SELECT metal_type,item_type,gross_wt,net_wt,wt_in_percent,fine_wt, Total_Quantity FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            string str = "", str2;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str += "(" + dt.Rows[i][0].ToString().Trim() + ")" + " " + dt.Rows[i][1].ToString().Trim();
                if (dt.Rows.Count > 1 && i != dt.Rows.Count - 1)
                {
                    str += ",";
                }
            }
            str2 = str;
            str = "";
            return str2;
        }
        public DataTable getDatefromGn(string gn)
        {
            string str1 = "SELECT Date_of_deposit,receipt_no FROM GirviMaster WHERE (GirviRecordNo = '" + gn + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable getAllGirviDatewise(string startdate, string enddate)
        {
            string cmd = "SELECT khatawani_No,GirviRecordNo, Amount,Date_of_deposit,receipt_no,interset_rate FROM GirviMaster WHERE (CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <= CONVERT(DateTime, '" + enddate + "' , 103)) order by CONVERT(DateTime, Date_of_deposit, 103) ASC, receipt_no ASC";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getAllGirviReleaseDatewise(string startdate, string enddate)
        {
            string cmd = "SELECT Khatawani_no,Girvino,AmountDeposit,Interest_Amount,dateOfRelease,pavtino FROM GirviReleasemaster WHERE  (CONVERT(DateTime, dateOfRelease, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, dateOfRelease, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103)) order by CONVERT(DateTime, dateOfRelease, 103) ASC, pavtino ASC";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }
    }
}
