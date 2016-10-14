using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAL;
using System.Data;

namespace BAL.Reports.Girvi
{
    public class clsKhatawaniList
    {
        SQLHelper _objSQLHelper = new SQLHelper();

        public DataTable getKhtawaniDetails()
        {
            string str1 = "SELECT khatawani_No,FullName,Contact_No,Address,Balance,Opening_date,cast  FROM Customer_Master ";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }
    }
}
