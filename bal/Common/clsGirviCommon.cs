using System;
using System.Data;
using System.Windows.Forms;
using BAL.Girvi;
using BAL.Common;

namespace BAL.Common
{
    public class clsGirviCommon
    {
        SQLHelper _objSQLHelper = new SQLHelper();
        clsCommon _objcommon = new clsCommon();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();


        //Prasad
       


        public double getTotalInterestBySelectectedFinancialYear(string StartDate , string EndDate)
        {
            try
            {
                double sum = 0;
                int i;
                int j = 0;
               
                for (i = 0; i <= (Convert.ToDateTime(EndDate) - Convert.ToDateTime(StartDate)).TotalDays; i++)
                {
                    double dtvyaj = getInterestTotal(Convert.ToDateTime(StartDate).AddDays(j).ToShortDateString().ToString());
                    sum = sum + dtvyaj;
                    j++;

                }

                return sum;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public double getAddgirviondate(string Date_of_deposit)
        {
            double sum = 0;
            string cmd = "SELECT Amount,Date_of_deposit FROM GirviMaster WHERE (Date_of_deposit='" + Date_of_deposit + "' )";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
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
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
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
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][0].ToString());
            }
            return sum;
        }

        public double getInterestTotal(string startdate, string enddate)
        {
            double sum = 0;
            string cmd = "SELECT Interest_Amount,dateOfRelease FROM GirviReleasemaster WHERE (CONVERT(DateTime, dateOfRelease, 103) > CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, dateOfRelease, 103) < CONVERT(DateTime,  '" + enddate + "', 103))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][0].ToString());
            }
            return sum;
        }

        public double getInterestTotalLastYear(string dateOfRelease)
        {
            double sum = 0;
            string cmd = "SELECT Interest_Amount,dateOfRelease FROM GirviReleasemaster WHERE  (CONVERT(DateTime, dateOfRelease, 103) < CONVERT(DateTime,  '" + dateOfRelease + "', 103))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][0].ToString());
            }
            return sum;
        }

        public double getexpenseTotal(string Date)
        {
            double sum = 0;
            string str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (CONVERT(DateTime, CreditDebitDetails.date, 103) = CONVERT(DateTime, '" + Date + "', 103) And  CreditDebitDetails.Type='Cr' And AccountNature.Under = N'Cash-In-Hand' )";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][3].ToString());
            }
            return sum;
        }

        public double getamountaddtotal(string Date)
        {
            double sum = 0;
            string str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE    (CONVERT(DateTime, CreditDebitDetails.date, 103) = CONVERT(DateTime, '" + Date + "', 103) And  CreditDebitDetails.Type='Dr' And AccountNature.Under = N'Cash-In-Hand')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][4].ToString());
            }
            return sum;
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

            return _objSQLHelper.GetDataTable(str);
        }

        string OpeningValue;
        public string getOpeningBalance()
        {
            DataTable openingData = new DataTable();
            try
            {
                DataTable dt1 = new DataTable();
                openingData = getOpeningLedger("Cash-In-Hand");
                double sumOpeningData = _objcommon.sumDataTableColumn(openingData, "openingBal");
                for (int i = 0; i < openingData.Rows.Count; i++)
                {

                }

                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                int count = 0;
                if (dt1.Rows.Count == 0)
                {
                    if (openingData.Rows.Count == 0)
                    {
                        count = 0;
                    }
                    else
                    {
                        dt1.Rows.Add("", openingData.Rows[0][4].ToString(), "", "", "", "", "", sumOpeningData.ToString());
                        count = 1;
                    }
                }

                if (count == 1)
                {
                    int j = 0;
                    for (int i = 0; i <= (Convert.ToDateTime(DateTime.Now.ToString()) - Convert.ToDateTime(openingData.Rows[0][4].ToString())).TotalDays; i++)
                    {
                        double dtnew = getAddgirviondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtnew1 = getAddreleaseondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtvyaj = getInterestTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtaddamt = getexpenseTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtexpense = getamountaddtotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double previousvalue = Convert.ToDouble(dt1.Rows[(i + 1) - 1].ItemArray[7].ToString());
                        dt1.Rows.Add(i, Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(i + 1).ToShortDateString(), dtnew, dtnew1, dtvyaj, dtexpense, dtaddamt, (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) + Convert.ToDouble(dtaddamt) - Convert.ToDouble(dtexpense)).ToString());
                        OpeningValue = (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) + Convert.ToDouble(dtaddamt) - Convert.ToDouble(dtexpense)).ToString();
                        j++;
                    }
                    return OpeningValue;
                }
                else
                {
                    MessageBox.Show("Opening Balance is not entered");
                    return OpeningValue;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return OpeningValue;
            }

        }
        public string getOpeningBalanceWithlastDate(string date)
        {
         
            DataTable openingData = new DataTable();
            try
            {
                DataTable dt1 = new DataTable();
                openingData = getOpeningLedger("Cash-In-Hand");
                double sumOpeningData = _objcommon.sumDataTableColumn( openingData, "openingBal");
               

                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                int count = 0;
                if (dt1.Rows.Count == 0)
                {
                    if (openingData.Rows.Count == 0)
                    {
                        count = 0;
                    }
                    else
                    {
                        dt1.Rows.Add("", openingData.Rows[0][4].ToString(), "", "", "", "", "", sumOpeningData.ToString());
                        count = 1;
                    }
                }

                if (count == 1)
                {
                    int j = 0;
                    for (int i = 0; i <= (Convert.ToDateTime(date) - Convert.ToDateTime(openingData.Rows[0][4].ToString())).TotalDays; i++)
                    {
                        double dtnew = getAddgirviondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtnew1 = getAddreleaseondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtvyaj = getInterestTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtaddamt = getexpenseTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtexpense = getamountaddtotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double previousvalue = Convert.ToDouble(dt1.Rows[(i + 1) - 1].ItemArray[7].ToString());
                        dt1.Rows.Add(i, Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(i + 1).ToShortDateString(), dtnew, dtnew1, dtvyaj, dtexpense, dtaddamt, (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) + Convert.ToDouble(dtaddamt) - Convert.ToDouble(dtexpense)).ToString());
                  //      OpeningValue = (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) - Convert.ToDouble(dtexpense) + Convert.ToDouble(dtaddamt)).ToString();
                        OpeningValue = previousvalue.ToString();
                        j++;
                    }
                    return OpeningValue;
                }
                else
                {
                    MessageBox.Show("Opening Balance is not entered");
                    return OpeningValue;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return OpeningValue;
            }

        }


        public string getCashInHand(string date)
        {

            DataTable openingData = new DataTable();
            try
            {
                DataTable dt1 = new DataTable();
                openingData = getOpeningLedger("Cash-In-Hand");
                double sumOpeningData = _objcommon.sumDataTableColumn(openingData, "openingBal");


                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                int count = 0;
                if (dt1.Rows.Count == 0)
                {
                    if (openingData.Rows.Count == 0)
                    {
                        count = 0;
                    }
                    else
                    {
                        dt1.Rows.Add("", openingData.Rows[0][4].ToString(), "", "", "", "", "", sumOpeningData.ToString());
                        count = 1;
                    }
                }

                if (count == 1)
                {
                    int j = 0;
                    for (int i = 0; i <= (Convert.ToDateTime(date) - Convert.ToDateTime(openingData.Rows[0][4].ToString())).TotalDays; i++)
                    {
                        double dtnew = getAddgirviondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtnew1 = getAddreleaseondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtvyaj = getInterestTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtaddamt = getexpenseTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtexpense = getamountaddtotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double previousvalue = Convert.ToDouble(dt1.Rows[(i + 1) - 1].ItemArray[7].ToString());
                        dt1.Rows.Add(i, Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString(), dtnew, dtnew1, dtvyaj, dtexpense, dtaddamt, (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) + Convert.ToDouble(dtaddamt) - Convert.ToDouble(dtexpense)).ToString());
                             OpeningValue = (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) - Convert.ToDouble(dtexpense) + Convert.ToDouble(dtaddamt)).ToString();
                      //  OpeningValue = previousvalue.ToString();
                        j++;
                    }
                    return OpeningValue;
                }
                else
                {
                    MessageBox.Show("Opening Balance is not entered");
                    return OpeningValue;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return OpeningValue;
            }

        }
        public string getOpeningBalanceWithEndDate(string date)
        {

            DataTable openingData = new DataTable();
            try
            {
                DataTable dt1 = new DataTable();
                openingData = getOpeningLedger("Cash-In-Hand");
                double sumOpeningData = _objcommon.sumDataTableColumn(openingData, "openingBal");
              
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                dt1.Columns.Add("");
                int count = 0;
                if (dt1.Rows.Count == 0)
                {
                    if (openingData.Rows.Count == 0)
                    {
                        count = 0;
                    }
                    else
                    {
                        dt1.Rows.Add("", openingData.Rows[0][4].ToString(), "", "", "", "", "", sumOpeningData.ToString());
                        count = 1;
                    }
                }
                
                if (count == 1)
                {
                    int j = 0;
                    for (int i = 0; i <= (Convert.ToDateTime(date) - Convert.ToDateTime(openingData.Rows[0][4].ToString())).TotalDays; i++)
                    {
                        double dtnew = getAddgirviondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtnew1 = getAddreleaseondate(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtvyaj = getInterestTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtaddamt  = getexpenseTotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtexpense = getamountaddtotal(Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(j).ToShortDateString().ToString());
                        double previousvalue = Convert.ToDouble(dt1.Rows[(i + 1) - 1].ItemArray[7].ToString());
                        dt1.Rows.Add(i, Convert.ToDateTime(openingData.Rows[0][4].ToString()).AddDays(i + 1).ToShortDateString(), dtnew, dtnew1, dtvyaj, dtexpense, dtaddamt, (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) - Convert.ToDouble(dtexpense) + Convert.ToDouble(dtaddamt)).ToString());
                             OpeningValue = (previousvalue - Convert.ToDouble(dtnew) + Convert.ToDouble(dtnew1) + Convert.ToDouble(dtvyaj) - Convert.ToDouble(dtexpense) + Convert.ToDouble(dtaddamt)).ToString();
                        //OpeningValue = previousvalue.ToString();
                        j++;
                    }
                    return OpeningValue;
                }
                else
                {
                    MessageBox.Show("Opening Balance is not entered");
                    return OpeningValue;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return OpeningValue;
            }

        }


        Simplevalidations _objSimplevalidation = new Simplevalidations();

        public string calucatedays(string dateofdeposit, string dateRelease)
        {
            string Depositedate = dateofdeposit.Substring(0, 10);
            string releaseDate = dateRelease.Substring(0, 10);
            DateTime d1 = DateTime.ParseExact(Depositedate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact(releaseDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan t = d2 - d1;
            double days = t.TotalDays;
            return Convert.ToString(days);
        }
        public string Interest(string Amount, string InterestRate, string noofdays)
        {
            decimal intAmount = 0;
            try
            {
                //if (Convert.ToInt32(noofdays) < 30)
                //{
                //    int amt = Convert.ToInt32(Amount);
                //    decimal rate = Convert.ToDecimal(Convert.ToDecimal(InterestRate));
                //    decimal dys = 31;
                //   intAmount = (((amt * rate) / 100) / 31) * dys;
                //}
                //else
                //{
                int amt = Convert.ToInt32(Amount);
                decimal rate = Convert.ToDecimal(Convert.ToDecimal(InterestRate));
                decimal dys = Convert.ToDecimal(Convert.ToInt32(noofdays));
                intAmount = (((amt * rate) / 100) /30 ) * dys;
                //}
            }
            catch { }

            return Convert.ToString(_objSimplevalidation.roundup(Convert.ToString(intAmount)));


        }

        public string InterestNo2(string Amount, string InterestRate, string noofdays)
        {
            decimal intAmount = 0;
            try
            {
                if (Convert.ToInt32(noofdays) < 30)
                {
                    int amt = Convert.ToInt32(Amount);
                    decimal rate = Convert.ToDecimal(Convert.ToDecimal(InterestRate));
                    decimal dys = 31;
                    intAmount = (((amt * rate) / 100) / 30) * dys;
                }
                if (Convert.ToInt32(noofdays) > 183)
                {
                    int amt = Convert.ToInt32(Amount);
                    decimal rate = Convert.ToDecimal(Convert.ToDecimal(3.5));

                    decimal dys = Convert.ToDecimal(Convert.ToInt32(noofdays));
                    intAmount = (((amt * rate) / 100) / 30) * dys;
                }
                else
                {
                    int amt = Convert.ToInt32(Amount);
                    decimal rate = Convert.ToDecimal(Convert.ToDecimal(InterestRate));
                    decimal dys = Convert.ToDecimal(Convert.ToInt32(noofdays));
                    intAmount = (((amt * rate) / 100) / 30) * dys;
                }


            }
            catch { }

            return Convert.ToString(_objSimplevalidation.roundup(Convert.ToString(intAmount)));


        }


        public string TotalAmount(string LoanAmount, string InterestRate, string noofdays)
        {

            decimal intersetAmount = Convert.ToDecimal(Interest(LoanAmount, InterestRate, noofdays));
            decimal amount = Convert.ToDecimal(LoanAmount);
            decimal totalamount = amount + intersetAmount;
            return Convert.ToString(_objSimplevalidation.roundup(Convert.ToString(totalamount)));
        }



        public string getPageNumber(string date)
        {
            string pagenumber;
            string year = Convert.ToDateTime(date).Year.ToString();
            int month = Convert.ToInt32(Convert.ToDateTime(date).Month);
            if (month < 4)
            {
                int backyear = Convert.ToInt32(year) - 1;
                pagenumber = (Convert.ToDateTime(date) - Convert.ToDateTime("01/04/" + backyear)).TotalDays.ToString();

            }
            else
            {
                pagenumber = (Convert.ToDateTime(date) - Convert.ToDateTime("01/04/" + year)).TotalDays.ToString();
            }

            double days = Convert.ToDouble(pagenumber) + 1;
            return days.ToString();
        }

        public DataTable getOpeningBhandwal()
        {
            string cmd1 = "SELECT Bhandval, Date FROM Opening_Bhandwal";
            DataTable dt1 = _objSQLHelper.GetDataTable(cmd1);
            return dt1;
        }

        public DataTable    getAllGirviData()
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate, duration,khatawani_No,Actual_InterestRate FROM GirviMaster where Release='unreleased' And Status='unchange'";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getAllGirviDataReleasedUnreleased()
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate, duration,khatawani_No,Actual_InterestRate FROM GirviMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getAllGirviDataWithActualInterestRate()
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, Actual_InterestRate, duration,khatawani_No,interset_rate FROM GirviMaster where Release='unreleased' And Status='unchange'";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getCustName(string KhNo)
        {
            string str = "SELECT FullName FROM Customer_Master where khatawani_No='" + KhNo + "'";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable fillGirvidData(string GirviNo)
        {
            string str1 = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt,reduce_wt, net_wt,wt_in_percent, fine_wt,Total_Quantity,current_rate,amount FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable loadRate()
        {
            string str = "SELECT Gold, Silver, Rate,interest FROM Rates WHERE (Rate = 'Rate')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getAmountFromunSecuredLoan(string date, int value)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.debit, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Unsecured Loans') AND  (CreditDebitDetails.date='" + (Convert.ToDateTime(date).AddDays(value)).ToString("dd/MM/yyyy") + "')";
            return _objSQLHelper.GetDataTable(str);
        }


        public DataTable getAmountfromCashInHandDebit(string startdate, string enddate)
        {
         // date=  (Convert.ToDateTime(date).AddDays(value)).ToString("dd/MM/yyyy");
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date, CreditDebitDetails.chequeno FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Dr') AND  (CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103)) ";
            return _objSQLHelper.GetDataTable(str);
        }
        public DataTable getAmountfromCashInHandCredit(string startdate, string enddate)
        {
            // date=  (Convert.ToDateTime(date).AddDays(value)).ToString("dd/MM/yyyy");
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.debit,CreditDebitDetails.FromAccount, CreditDebitDetails.date ,CreditDebitDetails.chequeno FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Cash-In-Hand') And (CreditDebitDetails.Type='Cr') AND  (CONVERT(DateTime, CreditDebitDetails.date, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, CreditDebitDetails.date, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103)) ";
            return _objSQLHelper.GetDataTable(str);
        }
        public DataTable getKhatawaniByAddress(string adress)
        {
            string str = "SELECT     Distinct   khatawani_No, FullName, Contact_No, Address FROM            Customer_Master WHERE        (Address = N'" + adress + "')";
            return _objSQLHelper.GetDataTable(str);
        }

      
        public DataTable getGirviDataByKhatawani(string khNo)
        {
            string str = "SELECT    Distinct    Customer_Master.FullName, Customer_Master.Contact_No, GirviMaster.GirviRecordNo,GirviMaster.Amount, GirviMaster.Date_of_deposit, GirviMaster.interset_rate, GirviMaster.duration, GirviMaster.Release, GirviMaster.Status, GirviMaster.withdraw_release_date, GirviMaster.Actual_InterestRate,  GirviMaster.purpose_of_loan, GirviMaster.comment, GirviMaster.forwardstatus, GirviMaster.forwardamount, GirviMaster.ForwardCno, GirviMaster.receipt_no,  GirviMaster.Forwarded_to,GirviMaster.Date_of_Forward, Customer_Master.Address, GirviMaster.khatawani_No, GirviMaster.GirviRecordNo,GirviMaster.Interest,Customer_Master.Address2 FROM Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No WHERE        (GirviMaster.khatawani_No = '" + khNo + "')";
            return _objSQLHelper.GetDataTable(str);
        }

        public DataTable getGirviDataByKhatawani(string khNo,string StartDate,string EndDate)
        {
            string str = "SELECT    Distinct    Customer_Master.FullName, Customer_Master.Contact_No, GirviMaster.Amount, GirviMaster.Date_of_deposit, GirviMaster.interset_rate, GirviMaster.duration, GirviMaster.Release, GirviMaster.Status, GirviMaster.withdraw_release_date, GirviMaster.Actual_InterestRate,  GirviMaster.purpose_of_loan, GirviMaster.comment, GirviMaster.forwardstatus, GirviMaster.forwardamount, GirviMaster.ForwardCno, GirviMaster.receipt_no,  GirviMaster.Forwarded_to, Customer_Master.Address, GirviMaster.khatawani_No, GirviMaster.GirviRecordNo FROM Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No WHERE (GirviMaster.khatawani_No = '" + khNo + "') AND (CONVERT(DateTime, GirviMaster.Date_of_deposit, 103) >= CONVERT(DateTime,  '" + StartDate + "', 103)) AND (CONVERT(DateTime, GirviMaster.Date_of_deposit, 103) <= CONVERT(DateTime, '" + EndDate + "' , 103)) ";
            return _objSQLHelper.GetDataTable(str);
        }

    
        public string getInterestAmount(string gn)
        {
            string str = "SELECT        intersetRate, IntersetPaid, Interest_Amount, Girvino FROM            GirviReleasemaster WHERE        (Girvino = '" + gn + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt.Rows[0]["Interest_Amount"].ToString();
        }

        public DataTable getGirviMasterData()
        {
            string str1 = "SELECT Customer_Master.khatawani_No, Customer_Master.FullName, Customer_Master.Contact_No, GirviMaster.GirviRecordNo, GirviMaster.Amount, GirviMaster.Date_of_deposit, GirviMaster.interset_rate, GirviMaster.Status, GirviMaster.withdraw_release_date FROM   Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No COLLATE Latin1_General_CI_AI = GirviMaster.khatawani_No";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable getKhtawaniDetails(string khatawani_No)
        {
            string str1 = "SELECT khatawani_No,FullName,Contact_No,Address,cast,occupation,PageNo,Address2 FROM Customer_Master WHERE (khatawani_No='" + khatawani_No + "') ";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable getGirviDetails(string GirviRecordNo)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,receipt_no,duration,withdraw_release_date,Actual_InterestRate,reason,loantype,Forwarded_to,Date_of_Forward,forwardamount,ForwardCno,Status,narration,vadhiv FROM GirviMaster WHERE ( GirviRecordNo = '" + GirviRecordNo + "')";
            //throw new NotImplementedException();
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public void deletefromGirviItemmaster(string GirviNo)
        {
            string str1 = "DELETE FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
        }

        public void deletefromGirviMaster(string GirviRecordNo)
        {
            string str1 = "DELETE FROM GirviMaster WHERE (GirviRecordNo = '" + GirviRecordNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
        }

        public void deletefromGirviNo(string GirviRecordNo)
        {
            string str1 = "DELETE FROM Girvi_no_table WHERE (Girvi_no = '" + GirviRecordNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
        }

        public void deletefromGirviReleaseMaster(string Girvino)
        {
            string str1 = "DELETE FROM GirviReleasemaster WHERE (Girvino = '" + Girvino + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
        }
        public void updateRecord(string khtno, string name, string adress, string phone, string cast, string occu, string gn, string Amount, string Date_of_deposite, string duration, string interset_rate, string withdraw_release_date, string Forwarded_to, string Date_of_Forward, string forwordamount, string forwordno, string Actual_InterestRate, string purpose_of_loan, string loantype, string receipt_no, string Address2,string narration,string vadhiv)
        {
            string str = "UPDATE GirviMaster SET  Amount = '" + Amount + "', Date_of_deposit = '" + Date_of_deposite + "', interset_rate = '" + interset_rate + "', duration = '" + duration + "', Forwarded_to = N'" + Forwarded_to + "', Date_of_Forward = '" + Date_of_Forward + "', Actual_InterestRate = '" + Actual_InterestRate + "', purpose_of_loan = '" + purpose_of_loan + "', forwardamount = '" + forwordamount + "', ForwardCno = '" + forwordno + "', receipt_no = '" + receipt_no + "', reason = N'" + purpose_of_loan + "', loantype = N'" + loantype + "',narration = N'" + narration  + "', vadhiv=N'"+vadhiv+"' WHERE (GirviRecordNo = '" + gn + "')";

            string str1 = "UPDATE Customer_Master SET khatawani_No = '" + khtno + "', FullName = N'" + name + "', Contact_No = '" + phone + "', Address = N'" + adress + "',cast=N'" + cast + "',occupation=N'" + occu + "',Address2=N'" + Address2 + "' WHERE (khatawani_No = '" + khtno + "')";
            _objSQLHelper.ExecuteSql(str);
            _objSQLHelper.ExecuteSql(str1);

        }

        public bool update(string gold, string silver, string interest)
        {
            string str = "UPDATE Rates SET Gold = '" + gold + "', Silver = '" + silver + "', interest='" + interest + "' WHERE (Rate = 'Rate')";
            int i = _objSQLHelper.ExecuteSql(str);
            if (i > 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable load()
        {
            string str = "SELECT Gold, Silver, Rate,interest FROM Rates WHERE (Rate = 'Rate')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public string getCompanyData()
        {
           
            string str = "SELECT CompanyName FROM CompanyMaster WHERE (companyid = '1')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["CompanyName"].ToString();
            }
            return "";
        }

        public void addOpeningBhandwav(string Bhandval, string Date)
        {
            string st1 = "DELETE FROM Opening_Bhandwal";
            _objSQLHelper.ExecuteSql(st1);
            string str = "INSERT INTO Opening_Bhandwal (Bhandval, Date) VALUES('" + Bhandval + "', '" + Date + "')";
            _objSQLHelper.ExecuteSql(str); 
        }

     

        public string getGirviYearStartAmountByKhatawaniNo(string kh_no)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();


            double sumGirviAmount = 0;
            int j = 0;
            DataTable girvi_data = _objGirviAdd.getGirviDetailsByKhatawaniAllUnreleased(kh_no, dtFiancialYear.Rows[0]["startyear"].ToString());
            DataTable Khatavani = _objGirviAdd.getReleaseGirviDetailsByKhatawaniForDate(kh_no, dtFiancialYear.Rows[0]["startyear"].ToString());
            for (int i = 0; i < girvi_data.Rows.Count; i++)
            {
                if (Khatavani.Rows.Count > 0)
                {
                    for (int k = 0; k < Khatavani.Rows.Count; k++)
                    {
                        if (girvi_data.Rows[i]["GirviRecordNo"].ToString() != Khatavani.Rows[k]["Girvino"].ToString())
                        {
                            sumGirviAmount = _objcommon.sumDataTableColumn(girvi_data, "Amount");

                        }
                    }
                }
                else
                {
                    sumGirviAmount = _objcommon.sumDataTableColumn(girvi_data, "Amount");
                }
            }
            return sumGirviAmount.ToString();
               
        }
   

        public DataTable getGirviYearStartAmountBefore()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Count");
            dt.Columns.Add("Amount");
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            DataTable girvi_data = _objGirviAdd.getGirviDetailsAllUnreleased(dtFiancialYear.Rows[0]["startyear"].ToString());

            dt.Rows.Add(girvi_data.Rows.Count, _objcommon.sumDataTableColumn(girvi_data, "Amount").ToString());

            return dt;
        }

        public DataTable getGirviYearStartAmountAfter(string CurrentDate)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Count");
            dt.Columns.Add("Amount");
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            DataTable girvi_data = _objGirviAdd.getGirviDetailsAllUnreleased(dtFiancialYear.Rows[0]["startyear"].ToString(), CurrentDate);

            dt.Rows.Add(girvi_data.Rows.Count, _objcommon.sumDataTableColumn(girvi_data, "Amount").ToString());

            return dt;
        }

        public DataTable getGirviAmount(string start,string End)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Count");
            dt.Columns.Add("Amount");
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            DataTable girvi_data = _objGirviAdd.getGirviDetailsAllUnreleased(start, End);

            dt.Rows.Add(girvi_data.Rows.Count, _objcommon.sumDataTableColumn(girvi_data, "Amount").ToString());

            return dt;
        }

        public string getGirviInterestYearStartAmountByKhatawaniNoforform14(string kh_no)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();


            double sumGirviAmount = 0;
            int j = 0;
            DataTable girvi_data = _objGirviAdd.getGirviDetailsByKhatawaniAllUnreleased(kh_no, dtFiancialYear.Rows[0]["startyear"].ToString());
            for (int i = 0; i < girvi_data.Rows.Count; i++)
            {
                string amountnaave = girvi_data.Rows[i]["Amount"].ToString();
                string interest_rate = girvi_data.Rows[i]["interset_rate"].ToString();
                string no_of_days = ((Convert.ToDateTime(dtFiancialYear.Rows[0]["endyear"].ToString()) - Convert.ToDateTime(girvi_data.Rows[i]["Date_of_deposit"].ToString())).TotalDays).ToString();
                double intrest_amt = Convert.ToDouble(interest(amountnaave, interest_rate, no_of_days));
                sumGirviAmount += intrest_amt;
            }


            return sumGirviAmount.ToString();
        }



        public string getGirviCurrentYearAddAmountByKhatawaniNo(string kh_no)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            double sumGirviAmount = 0;
            int j = 0;
            for (int i = 0; i <= (Convert.ToDateTime(dtFiancialYear.Rows[0]["endyear"].ToString()) - Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString())).TotalDays; i++)
            {
                DataTable girvi_data = _objGirviAdd.getGirviDetailsByKhatawaniForDate(kh_no, Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString().ToString());
                sumGirviAmount += _objcommon.sumDataTableColumn(girvi_data, "Amount");
                j++;
            }
            return sumGirviAmount.ToString();
        }

        public string getGirviCurrentYearReleaseAmountByKhatawaniNo(string kh_no)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            double sumGirviAmount = 0;
            int j = 0;
            for (int i = 0; i <= (Convert.ToDateTime(dtFiancialYear.Rows[0]["endyear"].ToString()) - Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString())).TotalDays; i++)
            {
                DataTable girvi_data = _objGirviAdd.getReleaseGirviDetailsByKhatawaniForDate(kh_no, Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString().ToString());
                sumGirviAmount += _objcommon.sumDataTableColumn(girvi_data, "AmountDeposit");

                j++;
            }
            return sumGirviAmount.ToString();
        }

        public string getGirviCurrentYearReleaseInterestAmountByKhatawaniNo(string kh_no)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            double sumGirviAmount = 0;
            int j = 0;
            for (int i = 0; i <= (Convert.ToDateTime(dtFiancialYear.Rows[0]["endyear"].ToString()) - Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString())).TotalDays; i++)
            {
                DataTable girvi_data = _objGirviAdd.getReleaseGirviDetailsByKhatawaniForDate(kh_no, Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString()).AddDays(j).ToShortDateString().ToString());
                sumGirviAmount += _objcommon.sumDataTableColumn(girvi_data, "Interest_Amount");

                j++;
            }
            return sumGirviAmount.ToString();
        }

        public string getGirviYearEndInterestByKhatawaniNo(string kh_no)
        {
            DataTable dtFiancialYear = _objFinancialYear.getSelectedFinancialYear();
            double sumGirviAmount = 0;
            int j = 0;
            //for (int i = 0; i <= (Convert.ToDateTime(dtFiancialYear.Rows[0]["endyear"].ToString()) - Convert.ToDateTime(dtFiancialYear.Rows[0]["startyear"].ToString())).TotalDays; i++)
            //{
            DataTable girvi_data = _objGirviAdd.getGirviDetailsByKhatawaniForInterest(kh_no);
            DataTable girvi_receipt = _objGirviAdd.getGirviDetailsByKhatawaniForReceiptNo(kh_no);
            for (int k = 0; k < girvi_data.Rows.Count; k++)
            {
               
                string amountnaave = girvi_data.Rows[k]["Amount"].ToString();
                string interest_rate = girvi_data.Rows[k]["interset_rate"].ToString();
                string no_of_days = ((Convert.ToDateTime(dtFiancialYear.Rows[0]["endyear"].ToString()) - Convert.ToDateTime(girvi_data.Rows[k]["Date_of_deposit"].ToString())).TotalDays).ToString();
                double intrest_amt = Convert.ToDouble(interest(amountnaave, interest_rate, no_of_days));
                sumGirviAmount += intrest_amt;
            }
            for (int k = 0; k < girvi_receipt.Rows.Count; k++)
            { string receiptno = girvi_receipt.Rows[k]["receipt_no"].ToString(); }
            j++;
            //}
            return sumGirviAmount.ToString();
        }

        public string interest(string amount, string rate_of_interest, string no_of_days)
        {  
            int amt = Convert.ToInt32(amount);
            decimal rate = Convert.ToDecimal(Convert.ToDecimal(rate_of_interest));
            decimal dys = Convert.ToDecimal(Convert.ToInt32(no_of_days));
            decimal intAmount = (((amt * rate) / 100) / 30) * dys;
            return Convert.ToString(Math.Round(intAmount));

        }

        public void updateOpeningBal(string amount, string date)
        {
            string str = "Update Opening_Value set OpeningValue='" + amount + "' , Date='" + date + "' ";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getAllDataFromGetSettingValue()
        {
            string str = "SELECT  *  FROM  setting_value";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public DataTable getPavtiNoAutoIncriment()
        {
            string str = "SELECT  PavtiNoAutoIncrement  FROM  setting_value";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public void setreceipt(string value)
        {
            string str = "UPDATE setting_value SET receipt='" + value + "'";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getreceipt()
        {
            string str = "SELECT receipt FROM setting_value";
            return _objSQLHelper.GetDataTable(str);
           
        }

        public void setprint(string value)
        {
            string str = "UPDATE setting_value SET printt='" + value + "'";
            _objSQLHelper.ExecuteSql(str);
        }
        public void setaccounttype(string value)
        {
            string str = "UPDATE setting_value SET AccountType='" + value + "'";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getprintt()
        {
            string str = "SELECT printt FROM setting_value";
            return _objSQLHelper.GetDataTable(str);
        }

        public DataTable getAccountType()
        {
            string str = "SELECT AccountType FROM setting_value";
            return _objSQLHelper.GetDataTable(str);
        }
        public DataTable getHideDataFeild()
        {
            string str = "SELECT HideDataFeild FROM setting_value";
            return _objSQLHelper.GetDataTable(str);
        }
        public void sethidefeild(string value)
        {
            string str = "UPDATE setting_value SET HideDataFeild='" + value + "'";
            _objSQLHelper.ExecuteSql(str);
        }
        public string setlanguage()
        {
            string str = "SELECT language FROM setting_value";
            return _objSQLHelper.ExecuteScalar(str);
        }

        public void setPavtiNo(string value)
        {
            string str = "UPDATE setting_value SET PavtiNoAutoIncrement='" + value + "'";
            _objSQLHelper.ExecuteSql(str);
        }


        public DataTable getPavtiNo()
        {
            string str = "SELECT PavtiNoAutoIncrement FROM setting_value";
            return _objSQLHelper.GetDataTable(str);
        }

        public DataTable getKhatawaniByTahsil(string Address2)
        {
            string str = "SELECT     Distinct   khatawani_No, FullName, Contact_No, Address2 FROM            Customer_Master WHERE        (Address2 = N'" + Address2 + "')";
            return _objSQLHelper.GetDataTable(str);
        
        }

        public DataTable getKhatawaniByAddress2(string Address2)
        {
            string str = "SELECT     Distinct   khatawani_No, FullName, Contact_No, Address2 FROM            Customer_Master WHERE        (Address2 = N'" + Address2 + "')";
            return _objSQLHelper.GetDataTable(str);
        }

        public DataTable getCustomerprintDetails(string FullName)
        {
            string str1 = "SELECT Customer_Master.khatawani_No,GirviMaster.receipt_no, Customer_Master.FullName,Customer_Master.Address,Customer_Master.Contact_No, GirviMaster.GirviRecordNo, GirviMaster.Amount, GirviItemMaster.item_type,GirviItemMaster.net_wt,   GirviMaster.Date_of_deposit  FROM         Customer_Master INNER JOIN   GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No INNER JOIN  GirviItemMaster ON GirviMaster.GirviRecordNo = GirviItemMaster.GirviNo  WHERE (FullName= N'" + FullName + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }


        public DataTable getTotalIntrestMontly()
        {
            string str1 = "SELECT Girvino,Interest_Amount from GirviReleasemaster ";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public void setDuration(string value)
        {
            string str1 = "UPDATE setting_value SET Duration='" + value + "'";
            _objSQLHelper.ExecuteSql(str1);

        }

        public DataTable getduration()
        {
            string str1 = "SELECT Duration from setting_value ";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public object InterestAmount(string Amount, string InterestRate, string noofdays)
        {
            decimal intAmount= 0;
            try
            {
                //if (Convert.ToInt32(noofdays) < 30)
                //{
                //    int amt = Convert.ToInt32(Amount);
                //    decimal rate = Convert.ToDecimal(Convert.ToDecimal(InterestRate));
                //    decimal dys = 31;
                //   intAmount = (((amt * rate) / 100) / 31) * dys;
                //}
                //else
                //{
                int amt = Convert.ToInt32(Amount);
                decimal rate = Convert.ToDecimal(Convert.ToDecimal(InterestRate));
                decimal dys = Convert.ToDecimal(Convert.ToInt32(noofdays) + 1);
                intAmount = (((amt * rate) / 100) / 30) * dys;
                //}
            }
            catch { }

            return Convert.ToString(_objSimplevalidation.roundup(Convert.ToString(intAmount)));

        }

        public string InterestFoorward(string Amount, string InterestRate, string noofdays)
        {
            decimal intAmount = 0;
            try
            {
                //if (Convert.ToInt32(noofdays) < 30)
                //{
                //    int amt = Convert.ToInt32(Amount);
                //    decimal rate = Convert.ToDecimal(Convert.ToDecimal(InterestRate));
                //    decimal dys = 31;
                //   intAmount = (((amt * rate) / 100) / 31) * dys;
                //}
                //else
                //{
                int amt = Convert.ToInt32(Amount);
                decimal rate = Convert.ToDecimal(Convert.ToDecimal(InterestRate) / 12);
                decimal dys = Convert.ToDecimal(Convert.ToInt32(noofdays));
                intAmount = (((amt * rate) / 100) / 30) * dys;
                //}
            }
            catch { }

            return Convert.ToString(_objSimplevalidation.roundup(Convert.ToString(intAmount)));
        }

        public string getBhandwalWithLastDate(string startdate)
        {
            try
            {
                DataTable dtBhandwal = new DataTable();
                string bhandwal="0";
                DataTable dtBhandwalData = new DataTable();
                dtBhandwalData.Columns.Add("Date");
                dtBhandwalData.Columns.Add();
                dtBhandwalData.Columns.Add();
                dtBhandwalData.Columns.Add();
                dtBhandwalData.Columns.Add("opening");

                int count = 0;
                if (dtBhandwalData.Rows.Count == 0)
                {
                    dtBhandwal = getOpeningBhandwal();

                    if (dtBhandwal.Rows.Count == 0)
                    {
                        count = 0;

                    }
                    else
                    {
                        dtBhandwalData.Rows.Add(dtBhandwal.Rows[0]["Date"].ToString(), "", "", "", dtBhandwal.Rows[0]["Bhandval"].ToString());
                        count = 1;

                    }

                }
                if (count == 1)
                {

                    int j = 0;
                    for (int i = 0; i <= (Convert.ToDateTime(startdate) - Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString())).TotalDays; i++)
                    {
                        double dtBhandwalnew =getAddgirviondate(Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        double dtBhandwalnew1 = getAddreleaseondate(Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString()).AddDays(j).ToShortDateString().ToString());
                        // string opening = ((Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["opening"].Value.ToString()) - Convert.ToDouble(dtBhandwalnew)) + Convert.ToDouble(dtBhandwalnew1)).ToString();
                        double previousvalue = Convert.ToDouble(dtBhandwalData.Rows[(i + 1) - 1]["opening"].ToString());

                        string paan = getPageNumber(Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString()).AddDays(j).ToShortDateString());

                        dtBhandwalData.Rows.Add(Convert.ToDateTime(dtBhandwal.Rows[0]["Date"].ToString()).AddDays(j).ToShortDateString(), paan, dtBhandwalnew, dtBhandwalnew1, (previousvalue + Convert.ToDouble(dtBhandwalnew) - Convert.ToDouble(dtBhandwalnew1)).ToString());

                    //    bhandwal = (previousvalue + Convert.ToDouble(dtBhandwalnew) - Convert.ToDouble(dtBhandwalnew1)).ToString();

                        //done by lalit for last value
                        bhandwal = (previousvalue.ToString());
                        //}
                        j++;
                    }
                }
                return bhandwal;
               
            }
            catch (Exception ex)
            {
                return Convert.ToString(0);
            }
        }
    }
}
