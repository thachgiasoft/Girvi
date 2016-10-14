using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Common
{
    public class Cls_BalanceSheet
    {
        SQLHelper _objdb = new SQLHelper();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsCommon _objCommon = new clsCommon();

        public DataTable getgroups()
        {
            string str = "SELECT  Under, srno FROM   AccountNature";
            DataTable dt = _objdb.GetDataTable(str);
            return dt;

        }

        public DataTable getAllAccountNature()
        {
            string str = "SELECT srno, Under, Nature, Visibility, EffectTo, opening_balance FROM AccountNature";
            DataTable dt = _objdb.GetDataTable(str);
            return dt;

        }

        public string getnaturefromunder(string underid)
        {
            string str = "SELECT  Nature FROM  AccountNature WHERE  (id = '" + Convert.ToInt32(underid) + "')";
            string nature = _objdb.ExecuteScalar(str);
            return nature;
        }



        public DataTable getTotalCreditDebit(string id)
        {
            string str = "SELECT   CreditDebitDetails.date,     AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.debit, CreditDebitDetails.ledgerId FROM            AccountLedger INNER JOIN CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE        (CreditDebitDetails.ledgerId =" + id + ")";
            return _objdb.GetDataTable(str);
        }

        public DataTable gettotalDEBIT(string ID)
        {
            string STR = "SELECT        Date,Name, Expense_Amount,Status, Comment, under, nature, narration, nameofbank, chequeno, accno, id,   Nameid FROM            Daily_Expenses_Master WHERE        (Nameid = " + ID + ")";
            return _objdb.GetDataTable(STR);
        }
        public DataTable gettotalCREDITbydate(string startdate, string enddate)
        {
            string str = "SELECT        Date, Name, Amount, under, nature, narration, nameofbank, chequeno, accno, id, Status, Nameid FROM OtherAmountAdd WHERE ((CONVERT(DateTime, Date, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, Date, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103)))";
            return _objdb.GetDataTable(str);
        }

        public DataTable gettotalDEBITbydate(string startdate, string enddate)
        {
            string STR = "SELECT        Date,Name, Expense_Amount, Comment, under, nature, narration, nameofbank, chequeno, accno, id, Status, Nameid FROM            Daily_Expenses_Master WHERE       ((CONVERT(DateTime, Date, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, Date, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103)))";
            return _objdb.GetDataTable(STR);
        }
        public DataTable getgroupandnature(string id)
        {
            string str = "SELECT        count(*) FROM     OtherAmountAdd WHERE        (Status = 'OpeningBalance' and Nameid = " + id + ")";
            int i = Convert.ToInt32(_objdb.ExecuteScalar(str));
            if (i > 0)
            {
                string str1 = "SELECT        Date, Name, Amount, under, nature, narration, nameofbank, chequeno, accno, id, Status, Nameid FROM OtherAmountAdd WHERE (Nameid = " + id + " and Status='OpeningBalance')";
                return _objdb.GetDataTable(str1);
            }
            else
            {
                string STR2 = "SELECT        Date, Expense_Amount, Comment, under, nature, narration, nameofbank, chequeno, accno, id, Name, Status, Nameid FROM            Daily_Expenses_Master WHERE        (Nameid = " + id + " and Status='OpeningBalance')";
                return _objdb.GetDataTable(STR2);
            }
        }

        public void deletecredit(string id)
        {
            string str = "DELETE FROM OtherAmountAdd WHERE        (id = " + id + ")";
            _objdb.ExecuteSql(str);
        }

        public void deletedebit(string id)
        {
            string str = "DELETE FROM Daily_Expenses_Master WHERE        (id = " + id + ")";
            _objdb.ExecuteSql(str);
        }

        public DataTable getAccountGroupDetailsFromAccountName(string account_group_name)
        {
            string str = "SELECT srno, Under, Nature, Visibility, EffectTo, opening_balance FROM AccountNature WHERE (Under = N'" + account_group_name + "')";
            return _objdb.GetDataTable(str);
        }

        public void insertAccountLedger(string name, string account_groupId, string opning_bal, string transaction_type, string narration, string bank, string chequeid, string date, int financialYearId)
        {
            string str = "INSERT INTO AccountLedger (accGroupId, name, openingBal, CreditOrDebit,narration,nameofbank,chequeno,date,financialYearId) VALUES (" + account_groupId + ", N'" + name + "', " + opning_bal + ", N'" + transaction_type + "',N'" + narration + "',N'" + bank + "',N'" + chequeid + "','" + date + "','" + financialYearId + "')";
            _objdb.ExecuteSql(str);
        }

        public DataTable getallAccountLedgerDetailsDebit()
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Dr') ";
            return _objdb.GetDataTable(str);
        }
        public DataTable getallAccountLedgerDetailsCredit()
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit,CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Cr') ";
            return _objdb.GetDataTable(str);
        }
        public DataTable getallAccountLedgerDetails()
        {
            string str = "SELECT AccountLedger.ledgerId AS Id,AccountLedger.date AS Date, AccountNature.Under AS [Account Group], AccountLedger.name AS Name,  AccountLedger.openingBal AS [Opening Balance], AccountLedger.CreditOrDebit AS [Credit/Debit],  AccountLedger.narration AS Narration, AccountLedger.nameofbank AS [Bank Name], AccountLedger.chequeno AS [Cheque No], AccountLedger.accno AS [Acc No] FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno";
            return _objdb.GetDataTable(str);
        }



        public DataTable getallAccountLedgerDetailsByAccountNature(string accountnature)
        {
            string str = "SELECT AccountLedger.ledgerId AS Id, AccountNature.Under AS [Account Group], AccountLedger.name AS Name, AccountLedger.openingBal AS [Opening Balance], AccountLedger.CreditOrDebit AS [Credit/Debit],  AccountLedger.narration AS Narration, AccountLedger.nameofbank AS [Bank Name], AccountLedger.chequeno AS [Cheque No], AccountLedger.accno AS [Acc No] FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno Where AccountNature.Under=N'" + accountnature + "'";
            return _objdb.GetDataTable(str);
        }
        public DataTable getallAccountLedgerDetailsByLedgerId(string LedgerId)
        {
            string str = "SELECT AccountLedger.ledgerId AS Id, AccountNature.Under AS [Account Group], AccountLedger.name AS Name, AccountLedger.openingBal AS [Opening Balance], AccountLedger.CreditOrDebit AS [Credit/Debit],  AccountLedger.narration AS Narration, AccountLedger.nameofbank AS [Bank Name], AccountLedger.chequeno AS [Cheque No], AccountLedger.accno AS [Acc No] FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno Where AccountLedger.ledgerId=N'" + LedgerId + "'";
            return _objdb.GetDataTable(str);
        }

        public string insertCreditDebitmaster(string totalamount, string narration, string date, int financialdateid)
        {
            string str = "INSERT INTO CreditDebitMaster(totalamount, narration, date, financialyearid) OUTPUT Inserted.CreditDebitmasterid VALUES (" + totalamount + ", '" + narration + "', " + date + ", " + financialdateid + ")";
            string id = _objdb.ExecuteScalar(str);
            return id.ToString();
        }

        public void insertCreditDebitDetails(string CreditDebitmasterid, string legderid, string credit, string debit, string chequedate, string chequeno, string date, string type, string FromAccount)
        {
            string str = "INSERT INTO CreditDebitDetails (CreditDebitmasterid, ledgerId, credit, debit, chequedate, chequeno, date,Type,FromAccount)  VALUES (" + CreditDebitmasterid + ", " + legderid + ", " + credit + ", " + debit + ",'" + chequedate + "', '" + chequeno + "','" + date + "','" + type + "',N'" + FromAccount + "')";
            int id = _objdb.ExecuteSql(str);

        }

        public string insertDebitmaster(string totalamount, string narration, string date, string financialdateid)
        {
            string str = "INSERT INTO DebitMaster (totalamount, narration, date, financialyearid) VALUES (" + totalamount + ", '" + narration + "', " + date + ", " + financialdateid + "); Select Scope_Identity()";
            int id = _objdb.ExecuteSql(str);
            return id.ToString();
        }

        public void insertDebitDetails(string debitmasterid, string legderid, string credit, string debit, string chequedate, string chequeno, string date)
        {
            string str = "INSERT INTO DebitDetails  (debitmasterid, ledgerId, credit, debit, chequedate, chequeno, date) VALUES (" + debitmasterid + ", " + legderid + ", " + credit + ", " + debit + ", " + chequedate + ", " + chequeno + ", " + date + ")";
            int id = _objdb.ExecuteSql(str);

        }

        public DataTable getAllDebitDetails(string ledgerid)
        {
            string str = "SELECT debitdetailId, debitmasterid, ledgerId, credit, debit, chequedate, chequeno, date FROM DebitDetails WHERE (ledgerId = " + ledgerid + ")";
            return _objdb.GetDataTable(str);
        }

        public DataTable getAllCreditDebitDetails(string ledgerid)
        {
            string str = "SELECT CreditDebitdetailId, CreditDebitmasterid, ledgerId, credit, debit, chequedate, chequeno, date FROM CreditDebitDetails WHERE (ledgerId = " + ledgerid + ")";
            DataTable dt = _objdb.GetDataTable(str);

            return dt;
            // return _objdb.GetDataTable(str);
        }



        public DataTable getTrialBalance(string nature)
        {
            string str = null;
            if (nature == "Current Assets")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') AND (AccountNature.Under <> N'Cash-In-Hand')";
            }
            if (nature == "Current Liabilities")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND ((AccountNature.Under <> N'Capital Account')  AND (AccountNature.Under <> N'Loans'))";

            }
            if (nature == "Capital Account")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Capital Account')";
            }
            if (nature == "Loans")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Loans')";
            }
            if (nature == "Fixed Assests")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under = N'Fixed Assests')";
            }
            if (nature == "Direct Expenses" || nature == "Direct Income" || nature == "Indirect Income" || nature == "Indirect Expenses")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Under = N'" + nature + "')";
            }
            DataTable dt = _objdb.GetDataTable(str);

            return dt;
        }


        public DataTable getTrialBalanceDatewise(string nature,string StartDate,string EndDate)
        {
            string str = null;
            if (nature == "Current Assets")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') AND (AccountNature.Under <> N'Cash-In-Hand') And   ((CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103)))";
            }
            if (nature == "Current Liabilities")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND ((AccountNature.Under <> N'Capital Account')  AND (AccountNature.Under <> N'Loans')) And   ((CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103)))";

            }
            if (nature == "Capital Account")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Capital Account') And   ((CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103)))";
            }
            if (nature == "Loans")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Loans') And   ((CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103)))";
            }
            if (nature == "Fixed Assests")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under = N'Fixed Assests') And   ((CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103)))";
            }
            if (nature == "Direct Expenses" || nature == "Direct Income" || nature == "Indirect Income" || nature == "Indirect Expenses")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Under = N'" + nature + "') And   ((CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + EndDate + "' , 103)))";
            }
            DataTable dt = _objdb.GetDataTable(str);

            return dt;
        }

        public DataTable getTrialBalanceLastYear(string nature, string StartDate)
        {
            string str = null;
            if (nature == "Current Assets")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') AND (AccountNature.Under <> N'Cash-In-Hand') And   (CONVERT(DateTime, CreditDebitDetails.date, 103) < CONVERT(DateTime,  '" + StartDate + "', 103))";
            }
            if (nature == "Current Liabilities")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND ((AccountNature.Under <> N'Capital Account')  AND (AccountNature.Under <> N'Loans')) And   (CONVERT(DateTime, CreditDebitDetails.date, 103) < CONVERT(DateTime,  '" + StartDate + "', 103))";

            }
            if (nature == "Capital Account")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Capital Account') AND  (CONVERT(DateTime, CreditDebitDetails.date, 103) < CONVERT(DateTime,  '" + StartDate + "', 103))";
            }
            if (nature == "Loans")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Loans') And    (CONVERT(DateTime, CreditDebitDetails.date, 103) < CONVERT(DateTime,  '" + StartDate + "', 103))";
            }
            if (nature == "Fixed Assests")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under = N'Fixed Assests') And   (CONVERT(DateTime, CreditDebitDetails.date, 103) < CONVERT(DateTime,  '" + StartDate + "', 103))";
            }
            if (nature == "Direct Expenses" || nature == "Direct Income" || nature == "Indirect Income" || nature == "Indirect Expenses")
            {
                str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Under = N'" + nature + "') And   (CONVERT(DateTime, CreditDebitDetails.date, 103) < CONVERT(DateTime,  '" + StartDate + "', 103))";
            }
            DataTable dt = _objdb.GetDataTable(str);

            return dt;
        }

        public DataTable getOpeningLedger(string nature)
        {
            string str = null;
            if (nature == "Current Assets")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit,AccountNature.Nature ,AccountLedger.date FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') AND (AccountNature.Under <> N'Cash-In-Hand')";

            }
            if (nature == "Current Liabilities")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno WHERE (AccountNature.Nature = N'Liabilities') AND ((AccountNature.Under <> N'Capital Account') AND (AccountNature.Under <> N'Loans'))";

            }
            if (nature == "Capital Account")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Capital Account')";

            }
            if (nature == "Loans")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Loans')";

            }
            if (nature == "Fixed Assests")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under = N'Fixed Assests')";

            }

            if (nature == "Direct Expenses" || nature == "Direct Income" || nature == "Indirect Income" || nature == "Indirect Expenses")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit, AccountNature.Nature FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno WHERE (AccountNature.Under = N'" + nature + "')";

            }
            if (nature == "Cash-In-Hand")
            {
                str = "SELECT AccountLedger.accGroupId, AccountLedger.openingBal,AccountLedger.CreditOrDebit,AccountNature.Nature ,AccountLedger.date FROM AccountLedger INNER JOIN AccountNature ON AccountLedger.accGroupId = AccountNature.srno WHERE  (AccountNature.Under = N'Cash-In-Hand')";

            }

            //for balance sheet under view
            if (nature == "CurrentAssetsAll")
            {
                str = "SELECT Under from AccountNature WHERE (Nature = N'Assets') AND (Under <> N'Fixed Assests')";

            }

            if (nature == "OnlyFixedAssest")
            {
                str = "SELECT Under from AccountNature WHERE (Nature = N'Assets') AND (Under = N'Fixed Assests')";

            }
            if (nature == "onlyCurrentLiabilities")
            {
                str = "SELECT Under from AccountNature WHERE (AccountNature.Nature = N'Liabilities') AND ((AccountNature.Under <> N'Capital Account')  AND (AccountNature.Under <> N'Loans'))";

            }
            if (nature == "onlyCapitalAccount")
            {
                str = "SELECT Under from AccountNature WHERE (Nature = N'Liabilities') AND (Under = N'Capital Liabilities')";

            }
            if (nature == "onlyLoans")
            {
                str = "SELECT Under from AccountNature WHERE (Nature = N'Liabilities') AND (Under = N'Loans')";

            }

            return _objdb.GetDataTable(str);
        }

        public void updateLedger(string Ledgerid, string name, string accGroupId, string openingBal, string creditordebit, string narr, string nameofbank, string chequeno, string date)
        {
            string str = "UPDATE  AccountLedger SET date='" + date + "',  name = N'" + name + "', accGroupId=" + accGroupId + ",openingBal = " + openingBal + ", CreditOrDebit = '" + creditordebit + "', narration = N'" + narr + "', nameofbank = N'" + nameofbank + "', chequeno = N'" + chequeno + "' WHERE     (ledgerId = " + Ledgerid + ")";
            _objdb.ExecuteSql(str);
        }

        public DataTable getAsset(string under)
        {
            string str = str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature,AccountNature.Under, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') ";
            DataTable dt = _objdb.GetDataTable(str);
            return dt;
        }


        public DataTable getbalanceTrailflow(string Under, string nature)
        {
            string query = null;
            if (nature == "Current Assets")
            {
                query = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under <> N'Fixed Assests') AND (AccountNature.Under = N'" + Under + "')";
            }
            if (nature == "Fixed Assets")
            {
                query = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Assets') AND (AccountNature.Under = N'Fixed Assests') AND (AccountNature.Under = N'" + Under + "')";
            }

            if (nature == "Current Liabilities")
            {
                query = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'" + Under + "')";
            }
            if (nature == "Capital Liabilities")
            {
                query = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Capital Liabilities') AND (AccountNature.Under = N'" + Under + "')";
            }
            if (nature == "Loans")
            {
                query = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE (AccountNature.Nature = N'Liabilities') AND (AccountNature.Under = N'Loans') AND (AccountNature.Under = N'" + Under + "')";
            }
            return _objdb.GetDataTable(query);
        }

        public DataTable getBalanceCashflow(string Under)
        {
            string str = "SELECT  AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.debit,AccountLedger.ledgerId FROM   AccountLedger INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountLedger.name = N'" + Under + "')";
            return _objdb.GetDataTable(str);
        }

        public DataTable getBalanceCashflow(string Under,string EndDate)
        {

            string str = "SELECT  AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.debit,AccountLedger.ledgerId FROM   AccountLedger INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountLedger.name = N'" + Under + "') And   (CONVERT(DateTime, CreditDebitDetails.date, 103) <= CONVERT(DateTime,  '" + EndDate + "', 103))";
            return _objdb.GetDataTable(str);
        }

        public DataTable getAcountLedgerFromgroup(string under)
        {
            string str = "SELECT       AccountLedger.name FROM  AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno WHERE  (AccountNature.Under = N'" + under + "')";
            return _objdb.GetDataTable(str);
        }

        public DataTable getAcountLedgerFromNature(string under)
        {
            string str = "SELECT       AccountLedger.name, AccountNature.Nature,AccountNature.Under FROM  AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno WHERE  (AccountNature.Nature = N'" + under + "') AND (AccountNature.Under<>N'Capital Account')";
            return _objdb.GetDataTable(str);
        }

        public DataTable getAcountFromNature(string under)
        {
            string str = "SELECT       * from  AccountNature  WHERE  (Nature = N'" + under + "') AND (AccountNature.Under<>N'Capital Account')  AND (AccountNature.Under<>N'Cash-In-Hand')";
            return _objdb.GetDataTable(str);
        }

        public void deleteDebitCredit(string id)
        {
            string strDebitCredit = "DELETE FROM CreditDebitDetails WHERE     (CreditDebitmasterid = " + id + ")";
            string strMaster = "DELETE FROM CreditDebitMaster WHERE     (CreditDebitmasterid = " + id + ")";

            _objdb.ExecuteSql(strMaster);
            _objdb.ExecuteSql(strDebitCredit);

        }


        public DataTable getallDebitDetailsOnDate(string Date)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Dr') and (CreditDebitDetails.date='" + Date + "')";
            return _objdb.GetDataTable(str);
        }
        public DataTable getallCreditDetailsOnDate(string Date)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit,CreditDebitDetails.CreditDebitmasterid,CreditDebitDetails.chequeno, CreditDebitDetails.chequedate,CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Cr') and (CreditDebitDetails.date='" + Date + "')";
            return _objdb.GetDataTable(str);
        }


        public DataTable getValuesFromProfitLossTillCurrentFinancialYear()
        {
            double InterestTotal = 0;
            double sumDirectIncome = 0;
            double sumDirectExpenses = 0;
            double NetProfit = 0;
            ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();


            //for (int i = 0; i < dtFiancialYear.Rows.Count; i++)
            //{
            //    if (Convert.ToBoolean(dtFiancialYear.Rows[i]["IsSelected"].ToString()) == false)
            //    {
                    string startdate = dtFiancialYear.Rows[0]["startyear"].ToString();
                    string enddate = dtFiancialYear.Rows[0]["endyear"].ToString();
                    InterestTotal = _objGirviCommon.getTotalInterestBySelectectedFinancialYear(startdate, enddate);
                    DataTable dtDirectIncome = getTrialBalanceDatewise("Direct Income", startdate, enddate);
                    sumDirectIncome = _objCommon.sumDataTableColumn(dtDirectIncome, "credit");
                    DataTable dtDirectExpenses = getTrialBalanceDatewise("Direct Expenses", startdate, enddate);
                    sumDirectExpenses = _objCommon.sumDataTableColumn(dtDirectExpenses, "credit");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
                    NetProfit = (sumDirectIncome + InterestTotal) - sumDirectExpenses;
            DataTable dtReturn = new DataTable();
            dtReturn.Columns.Add("Income");
            dtReturn.Columns.Add("Expenses");
            dtReturn.Columns.Add("NetProfit");
            dtReturn.Rows.Add(sumDirectIncome, sumDirectExpenses, NetProfit);
            return dtReturn;
        }

        public DataTable getValuesFromProfitLossExceptCurrentFinancialYear()
        {
            double InterestTotal = 0;
            double sumDirectIncome = 0;
            double sumDirectExpenses = 0;
            double NetProfit = 0;
            ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
            DataTable dtFiancialYear = _objFinancialYear.getFinancialYear();


            for (int i = 0; i < dtFiancialYear.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtFiancialYear.Rows[i]["IsSelected"].ToString()) == false)
                {
                    string startdate = dtFiancialYear.Rows[i]["startyear"].ToString();
                    string enddate = dtFiancialYear.Rows[i]["endyear"].ToString();
                    InterestTotal = _objGirviCommon.getTotalInterestBySelectectedFinancialYear(startdate, enddate);
                    DataTable dtDirectIncome = getTrialBalanceDatewise("Direct Income", startdate, enddate);
                    sumDirectIncome = _objCommon.sumDataTableColumn(dtDirectIncome, "credit");
                    DataTable dtDirectExpenses = getTrialBalanceDatewise("Direct Expenses", startdate, enddate);
                    sumDirectExpenses = _objCommon.sumDataTableColumn(dtDirectExpenses, "credit");
                }
                else
                {
                    break;
                }
            }
            NetProfit = (sumDirectIncome + InterestTotal) - sumDirectExpenses;
            DataTable dtReturn = new DataTable();
            dtReturn.Columns.Add("Income");
            dtReturn.Columns.Add("Expenses");
            dtReturn.Columns.Add("NetProfit");
            dtReturn.Rows.Add(sumDirectIncome, sumDirectExpenses, NetProfit);
            return dtReturn;
        }
    }
}
