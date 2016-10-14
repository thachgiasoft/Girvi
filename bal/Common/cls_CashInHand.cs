using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Common
{
    public class cls_CashInHand
    {
        SQLHelper _objSqlhelper = new SQLHelper();
        clsCommon _objCommon = new clsCommon();
        public DataTable getOpeningBalance()
        {
            string str = "SELECT OpeningValue, Date FROM Opening_Value";
            DataTable dt1 = _objSqlhelper.GetDataTable(str);

            return dt1;
        }

        public double getSaleSum(string Date)
        {
            string str= "SELECT AmountGiven FROM SalesBPayMaster WHERE (Date='" + Date + "' )";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return _objCommon.sumDataTableColumn(dt, "AmountGiven");
        }

        public double getPurchaseSum(string Date)
        {
            string str = "SELECT Amount FROM SupplierPayMaster WHERE (date='" + Date + "' )";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return _objCommon.sumDataTableColumn(dt, "Amount");
        }

        public double getVyapariSum(string Date)
        {
            string str = "SELECT AmountGiven FROM vyapriPayMaster WHERE (Date='" + Date + "' )";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return _objCommon.sumDataTableColumn(dt, "AmountGiven");
        }

        public double getModSum(string Date)
        {
            string str = "SELECT Total_Amount FROM Mod_Entries WHERE (Date='" + Date + "' ) AND (Status='Stocked')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return _objCommon.sumDataTableColumn(dt, "Total_Amount");
        }

        public double getDebitSum(string Date)
        {
            string str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE    (CONVERT(DateTime, CreditDebitDetails.date, 103) = CONVERT(DateTime, '" + Date + "', 103) And  CreditDebitDetails.Type='Dr' And AccountNature.Under = N'Cash-In-Hand')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return _objCommon.sumDataTableColumn(dt, "debit");
        }

        public double getCreditSum(string Date)
        {
            string str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (CONVERT(DateTime, CreditDebitDetails.date, 103) = CONVERT(DateTime, '" + Date + "', 103) And  CreditDebitDetails.Type='Cr' And AccountNature.Under = N'Cash-In-Hand' )";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return _objCommon.sumDataTableColumn(dt, "credit");
        }


        ///girvi///
         public double getAddgirviondate(string Date_of_deposite)
        {
            double sum=0;
            string cmd = "SELECT Amount,Date_of_deposit FROM GirviMaster WHERE (Date_of_deposit='" + Date_of_deposite + "' )";
            DataTable dt = _objSqlhelper.GetDataTable(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][0].ToString());
            }
                return sum;
        }

        public double getAddreleaseondate(string dateOfRelease)
        {
            double sum = 0;
            string cmd = "SELECT AmountDeposit,dateOfRelease FROM GirviReleasemaster WHERE (dateOfRelease='" + dateOfRelease + "')";
            DataTable dt = _objSqlhelper.GetDataTable(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][0].ToString());
            }
            return sum;
        }

        public double getInterestTotal(string dateOfRelease)
        {
            double sum = 0;
            string cmd = "SELECT Interest_Amount,dateOfRelease FROM GirviReleasemaster WHERE (dateOfRelease='" + dateOfRelease + "')";
            DataTable dt = _objSqlhelper.GetDataTable(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][0].ToString());
            }
            return sum;
        }

    }
}
