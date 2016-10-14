using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAL;
using System.Data;

namespace BAL.Reports.Girvi
{
    public class clsKhatawaniGirviRecord
    {
        SQLHelper _objSQLHelper = new SQLHelper();
        public string getDateofrelease(int girvi_no)
        {
            string str = "SELECT      dateOfRelease FROM GirviReleasemaster WHERE        (Girvino = '" + girvi_no + "')";
            return _objSQLHelper.ExecuteScalar(str);
        }

        public string getgirviitem(string p)
        {
            string cmd="SELECT metal_type,item_type,gross_wt,net_wt,wt_in_percent,fine_wt, Total_Quantity FROM GirviItemMaster WHERE (GirviNo = '" + p + "')";
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

        public string getreleaseinterest(int girvi_no)
        {
            string str = "SELECT      Interest_Amount FROM GirviReleasemaster WHERE        (Girvino = '" + girvi_no + "')";
            string interest = _objSQLHelper.ExecuteScalar(str);
            if (interest == "")
            {
                return interest = "0";
            }
            else
            {
                return interest;
            }

        }

        public DataTable getgirvivaluesByFinancialYear(string Khatawani_no,string start,string end)
        {
            string cmd = "SELECT dateOfRelease, Girvino,AmountDeposit,Interest_Amount,IntersetPaid,pavtino  FROM  Girvireleasemaster WHERE   (Khatawani_no = '" + Khatawani_no + "') and (CONVERT(DateTime, dateOfRelease, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, dateOfRelease, 103) <=  CONVERT(DateTime, '" + end + "' , 103))";
            DataTable dt2 = _objSQLHelper.GetDataTable(cmd);
            return dt2;

        }

        public DataTable getgirvivalues(string Khatawani_no)
        {
            string cmd = "SELECT dateOfRelease, Girvino,AmountDeposit,Interest_Amount,IntersetPaid,pavtino  FROM  Girvireleasemaster WHERE   (Khatawani_no = '" + Khatawani_no + "') ";
            DataTable dt2 = _objSQLHelper.GetDataTable(cmd);
            return dt2;

        }
    }
}
