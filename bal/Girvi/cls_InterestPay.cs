using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAL
{
    public class cls_InterestPay
    {

        public void GetInterest(string GirviNo, string dtp_Date,string AmountPaid)
        {
            string str = "INSERT INTO tbl_newinterestpay (Girvi_No, Date, Amount)VALUES        ('" + GirviNo + "','" + dtp_Date + "','" + AmountPaid + "')";
            SQLHelper sh = new SQLHelper();
            sh.ExecuteSql(str);
        }
    }
}
