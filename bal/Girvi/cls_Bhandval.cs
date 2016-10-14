using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BAL;
namespace BAL.Girvi
{


    public class cls_Bhandval
    {
         SQLHelper _objSQLHelper = new SQLHelper();

        public DataTable addAmount(string Date, string Name, string Amount, string under, string nature, string narration, string nameofbank, string chequeno, string accno,string status,string nameid)
        {
            string str1 = "INSERT INTO OtherAmountAdd (Date, Name, Amount,under, nature, narration, nameofbank, chequeno, accno,Status,Nameid) VALUES('" + Date + "', N'" + Name + "', '" + Amount + "', N'" + under + "', N'" + nature + "', N'" + narration + "', N'" + nameofbank + "','" + chequeno + "', '" + accno + "','" + status + "','" + nameid + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }
        public DataTable updateAmountAddData(string Date, string Name, string Amount, string under, string nature, string narration, string nameofbank, string chequeno, string accno, string Id)
        {
            string str1 = "UPDATE OtherAmountAdd SET Date ='" + Date + "', Name =N'" + Name + "', Amount ='" + Amount + "', under ='" + under + "', nature ='" + nature + "', narration ='" + narration + "', nameofbank ='" + nameofbank + "', chequeno ='" + chequeno + "', accno ='" + accno + "' WHERE (Id = '" + Id + "')";
            DataTable dt1 = _objSQLHelper.GetDataTable(str1);
            return dt1;
        }

        public DataTable getgirvidata(string khatawani_No, string GirviRecordNo)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "') AND ( GirviRecordNo = '" + GirviRecordNo + "')";
            //throw new NotImplementedException();
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public void updategirvimasterdata(string GirviRecordNo, string updated_girvi_no)
        {
            string str = "UPDATE GirviMaster SET updated_girvi_no='" + updated_girvi_no + "', Status ='" + "Release" + "' WHERE  (GirviRecordNo =" + GirviRecordNo + " )";
            _objSQLHelper.ExecuteSql(str); 
        }

        public void insertGirvimasterData(string girvi_no, string khatawani_no, string rate, string deposite_date, string loan_amount, string duration, string up_g_n)
        {
            string str = "INSERT INTO GirviMaster (GirviRecordNo, khatawani_No, interset_rate, Date_of_deposit, Amount, duration,updated_girvi_no,withdraw_release_date) VALUES ('" + girvi_no + "', '" + khatawani_no + "', '" + rate + "', '" + deposite_date + "', '" + loan_amount + "', '" + duration + "','" + up_g_n + "','" + deposite_date + "')";
            _objSQLHelper.ExecuteSql(str);
            //throw new NotImplementedException();
        }



        public string get_girvi_no()
        {
            string cmd = "SELECT max(Girvi_no) FROM  Girvi_no_table";
            string GirviNo = Convert.ToString(_objSQLHelper.ExecuteScalar(cmd));
            //string GirviNo = "SELECT Girvi_no FROM  Girvi_no_table where Girvi_no>0";

            int Girvi_No = Convert.ToInt32(GirviNo) + 1;

            return Girvi_No.ToString();
        }

        public void updateGirvinumber(string gn)
        {
            string str = "INSERT INTO Girvi_no_table(Girvi_no) VALUES('" + gn + "')";
            _objSQLHelper.ExecuteSql(str); 
        }

        public void insertGirvidata(string GirviNo, string metal_type_no, string metal_type, string item_type_no, string item_type, string gross_wt, string nt_wt, string Total_Quantityy)
        {
            string str = "INSERT INTO GirviItemMaster (GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt, net_wt, Total_Quantity) VALUES ('" + GirviNo + "', '" + metal_type_no + "', N'" + metal_type + "', '" + item_type_no + "', N'" + item_type + "', '" + gross_wt + "', '" + nt_wt + "', '" + Total_Quantityy + "')";
            //  string str="INSERT INTO GirviItemMaster (GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt, nt_wt, Total_Quantityy) VALUES ('e', 'd', N'd', 'd', N'd', 'd', 'd', 'd')"
            _objSQLHelper.ExecuteSql(str); 
        }
        public DataTable fillgirvidata(string GirviNo)
        {
            string str1 = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt, net_wt, Total_Quantity FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            //throw new NotImplementedException();
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
            //throw new NotImplementedException();
        }

        public void UpdateGirvimasterData(string GirviRecordNo, string khatawani_No, string interset_rate, string Date_of_deposit, string Amount, string duration, string updated_girvi_no)
        {
            string str = "UPDATE GirviMaster SET GirviRecordNo = '" + GirviRecordNo + "', khatawani_No = '" + khatawani_No + "', interset_rate = '" + interset_rate + "', Date_of_deposit = '" + Date_of_deposit + "', Amount = '" + Amount + "', duration = '" + duration + "', updated_girvi_no = '" + updated_girvi_no + "' WHERE (GirviRecordNo = '" + GirviRecordNo + "')";
            _objSQLHelper.ExecuteSql(str);
           
        }

        public void UpdateGirvidata(string GirviNo, string metal_type_no, string metal_type, string item_type_no, string item_type, string gross_wt, string nt_wt, string Total_Quantityy)
        {
            string str = "UPDATE GirviItemMaster SET GirviNo = '" + GirviNo + "', metal_type_no = '" + metal_type_no + "', metal_type = N'" + metal_type + "', item_type_no = '" + item_type_no + "', item_type = N'" + item_type + "', gross_wt = '" + gross_wt + "', net_wt = '" + nt_wt + "', Total_Quantity = '" + Total_Quantityy + "' WHERE (GirviNo = '" + GirviNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteitemsfromGirviItem(string GirviNo)
        {
            string str = "DELETE FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable gettotalgirviamt(string Date_of_deposit)
        {
            string cmd1 ="SELECT OpeningValue, Date FROM Opening_Value";
            DataTable dt1 = _objSQLHelper.GetDataTable(cmd1);
            string cmd = "SELECT Amount,Date_of_deposit FROM GirviMaster WHERE ((CONVERT(DateTime, Date_of_deposit, 103) <= CONVERT(DateTime, '" + Date_of_deposit + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) > CONVERT(DateTime, '" + dt1.Rows[0][1].ToString() + "', 103)  )  AND (Status = '" + "unchange" + "'))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;

          //  SqlCommand cmd = new SqlCommand("SELECT GirviRecordNo, Amount, Date_of_deposit, Status FROM GirviMaster WHERE (khatawani_No = '" + p + "') AND ((Status = '" + "Release" + "') OR (Status = '" + "unchange" + "'))");
           
           // throw new NotImplementedException();
        }

        public DataTable getreleasetotal(string dateOfRelease)
        {

            string cmd1 ="SELECT OpeningValue, Date FROM Opening_Value";
            DataTable dt1 = _objSQLHelper.GetDataTable(cmd1);
           // return dt;
            string cmd = "SELECT AmountDeposit,dateOfRelease FROM GirviReleasemaster WHERE (CONVERT(DateTime, dateOfRelease, 103) <=  CONVERT(DateTime,  '" + dateOfRelease + "', 103)) AND (CONVERT(DateTime, dateOfRelease, 103) >=  CONVERT(DateTime, '" + dt1.Rows[0][1].ToString() + "' , 103))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getreleasetotal_today(string dateOfRelease)
        {
            string cmd = "SELECT AmountDeposit,dateOfRelease FROM GirviReleasemaster WHERE (CONVERT(DateTime, dateOfRelease, 103) <= CONVERT(DateTime,  '" + dateOfRelease + "', 103))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable gettotalgirviamt_previous(string Date_of_deposit)
        {
            string cmd1 = "SELECT OpeningValue, Date FROM Opening_Value";
            DataTable dt1 = _objSQLHelper.GetDataTable(cmd1);
            string cmd = "SELECT Amount,Date_of_deposit FROM GirviMaster WHERE ((CONVERT(DateTime, Date_of_deposit, 103) < CONVERT(DateTime,  '" + Date_of_deposit + "', 103)) AND (CONVERT(DateTime, dateOfRelease, 103) >=  CONVERT(DateTime, '" + dt1.Rows[0][1].ToString() + "' , 103))) AND (Status = '" + "unchange" + "'))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getAllGirvi(string Date_of_deposit)
        {
            string cmd = "SELECT khatawani_No,GirviRecordNo, Amount,Date_of_deposit,receipt_no,interset_rate FROM GirviMaster WHERE (Date_of_deposit='" + Date_of_deposit + "')";//((Status = '" + "Release" + "') OR
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getAllGirviRelease(string dateOfRelease)
        {
            string cmd = "SELECT Khatawani_no,Girvino,AmountDeposit,Interest_Amount,dateOfRelease FROM GirviReleasemaster WHERE (dateOfRelease = '" + dateOfRelease + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getnamefromID(string khatawani_No)
        {
            string str1 = "SELECT FullName, khatawani_No,Contact_No,Address FROM Customer_Master WHERE (khatawani_No = '" + khatawani_No + "')";
           
            //string dt = Convert.ToString(_objSQLHelper.ExecuteScalar(str1));
            //return dt;
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public void addOpeningValue(string OpeningValue, string Date)
        {
            string st1 = "DELETE FROM Opening_Value";
            _objSQLHelper.ExecuteSql(st1);
            string str = "INSERT INTO Opening_Value (OpeningValue, Date) VALUES('" + OpeningValue + "', '" + Date + "')";
           _objSQLHelper.ExecuteSql(str); 
        }

        public DataTable getOpeningBalance()
        {
            string cmd1 = "SELECT OpeningValue, Date FROM Opening_Value";
            DataTable dt1 = _objSQLHelper.GetDataTable(cmd1);
           
            return dt1;
        }

        public double getAddgirviondate(string Date_of_deposit)
        {
            double sum=0;
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

        public DataTable getAllVyajRelease(string startdate, string enddate)
        {

            string cmd = "SELECT Khatawani_no,Girvino,AmountDeposit,Interest_Amount,dateOfRelease FROM GirviReleasemaster WHERE (CONVERT(DateTime, dateOfRelease, 103) >= CONVERT(DateTime, '" + startdate + "', 103)) OR (CONVERT(DateTime, dateOfRelease, 103) <= CONVERT(DateTime, '" + enddate + "', 103))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public double getInterestTotal_new(string date, string none)
        {
            double sum = 0;
            string cmd = "SELECT Interest_Amount,dateOfRelease FROM GirviReleasemaster WHERE  (CONVERT(DateTime, dateOfRelease, 103) = CONVERT(DateTime, '" + date + "', 103)) ";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);//OR (CONVERT(DateTime, dateOfRelease, 103) <= CONVERT(DateTime, '" + p_2 + "', 103))
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][0].ToString());
            }
            return sum;
        }

        public DataTable getKhtawaniDetails()
        {
            string str1 = "SELECT khatawani_No,FullName,Contact_No,Address,Balance,Opening_date,cast  FROM Customer_Master ";

            //string dt = Convert.ToString(_objSQLHelper.ExecuteScalar(str1));
            //return dt;
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable getGirviMasterData()
        {
            string str1 = "SELECT Customer_Master.khatawani_No, Customer_Master.FullName, Customer_Master.Contact_No, GirviMaster.GirviRecordNo, GirviMaster.Amount, GirviMaster.Date_of_deposit, GirviMaster.interset_rate, GirviMaster.Status, GirviMaster.withdraw_release_date FROM   Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No COLLATE Latin1_General_CI_AI = GirviMaster.khatawani_No";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public void deletefromGirviItemmaster(string GirviNo)
        {
            string str1 = "DELETE FROM GirviItemMaster WHERE (GirviNo = '" + GirviNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            //return dt;
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

        public DataTable adDailyExpense(string Date, string name, string Expense_Amount,string under,string nature,string narration,string nob,string cno,string accnio,string status,string nameid)
        {

            string str1 = "INSERT INTO Daily_Expenses_Master (Date,Name, Expense_Amount, under, nature, narration, nameofbank, chequeno, accno,Status,Nameid) VALUES('" + Date + "', N'" + name + "', '" + Expense_Amount + "', N'" + under + "', N'" + nature + "', N'" + narration + "', N'" + nob + "', '" + cno + "', '" + accnio + "','" + status + "','"+nameid+"')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

      

        public DataTable getOpeningBhandwal()
        {

            string cmd1 = "SELECT Bhandval, Date FROM Opening_Bhandwal";
            DataTable dt1 = _objSQLHelper.GetDataTable(cmd1);

            return dt1;
        }

        public void addOpeningBhandwav(string Bhandval, string Date)
        {
            string st1 = "DELETE FROM Opening_Bhandwal";
            _objSQLHelper.ExecuteSql(st1);
            string str = "INSERT INTO Opening_Bhandwal (Bhandval, Date) VALUES('" + Bhandval + "', '" + Date + "')";
            _objSQLHelper.ExecuteSql(str); 
        }

    

     

      
        public DataTable getKhtawaniDetails(string khatawani_No)
        {
            string str1 = "SELECT khatawani_No,FullName,Contact_No,Address,cast,occupation,PageNo  FROM Customer_Master WHERE (khatawani_No='" + khatawani_No + "') ";

            //string dt = Convert.ToString(_objSQLHelper.ExecuteScalar(str1));
            //return dt;
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable getGirviDetails(string GirviRecordNo)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,receipt_no,duration,withdraw_release_date,Actual_InterestRate,reason,loantype,Forwarded_to,Date_of_Forward,forwardamount,ForwordCno,Status FROM GirviMaster WHERE ( GirviRecordNo = '" + GirviRecordNo + "')";
            //throw new NotImplementedException();
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        //public void updateRecord(string khtno, string name, string adress, string phone , string girvino, string date, string amount,string page,string cast,string occu,string rate,string act_rate)
        //{
        //    string str = "UPDATE GirviMaster SET GirviRecordNo = '"+girvino+"', Amount = '"+amount+"', Date_of_deposit = '"+date+"', duration='"+Convert.ToDateTime(date).AddMonths(6).ToShortDateString().ToString()+"' ,interset_rate='"+rate+"',Actual_InterestRate='"+act_rate+"',receipt_no='"+page+"' WHERE (GirviRecordNo = '"+girvino+"')";
        //    string str1 = "UPDATE Customer_Master SET khatawani_No = '" + khtno + "', FullName = N'" + name + "', Contact_No = '" + phone + "', Address = N'" + adress + "',PageNo='"+page+"',cast=N'"+cast+"',occupation=N'"+occu+"' WHERE (khatawani_No = '" + khtno + "')";
        //    _objSQLHelper.ExecuteSql(str);
        //    _objSQLHelper.ExecuteSql(str1);
           
        //}

        public void updateRecord(string khtno, string name, string adress, string phone,string cast,string occu, string gn, string Amount, string Date_of_deposit, string duration, string interset_rate, string withdraw_release_date, string Forwarded_to, string Date_of_Forward, string forwardamount, string forwordno, string Actual_InterestRate, string purpose_of_loan, string loantype, string receipt_no)
        {
            string str = "UPDATE GirviMaster SET  Amount = '" + Amount + "', Date_of_deposit = '" + Date_of_deposit + "', interset_rate = '" + interset_rate + "', duration = '" + duration + "', withdraw_release_date = '" + withdraw_release_date + "', Forwarded_to = N'" + Forwarded_to + "', Date_of_Forward = '" + Date_of_Forward + "', Actual_InterestRate = '" + Actual_InterestRate + "', purpose_of_loan = '" + purpose_of_loan + "', forwardamount = '" + forwardamount + "', ForwordCno = '" + forwordno + "', receipt_no = '" + receipt_no + "', reason = N'" + purpose_of_loan + "', loantype = N'" + loantype + "' WHERE (GirviRecordNo = '" + gn + "')";

             string str1 = "UPDATE Customer_Master SET khatawani_No = '" + khtno + "', FullName = N'" + name + "', Contact_No = '" + phone + "', Address = N'" + adress + "',cast=N'" + cast + "',occupation=N'" + occu + "' WHERE (khatawani_No = '" + khtno + "')";
            _objSQLHelper.ExecuteSql(str);
            _objSQLHelper.ExecuteSql(str1);

        }

        public void updateGirviMasterData(string gn, string Amount, string Date_of_deposit, string duration, string interset_rate, string withdraw_release_date, string Forwarded_to, string Date_of_Forward, string forwardamount, string forwordno, string Actual_InterestRate, string purpose_of_loan, string loantype, string comment, string receipt_no)
        {
            string str = "UPDATE GirviMaster SET  Amount = '" + Amount + "', Date_of_deposit = '" + Date_of_deposit + "', interset_rate = '" + interset_rate + "', duration = '" + duration + "', withdraw_release_date = '" + withdraw_release_date + "', Forwarded_to = N'" + Forwarded_to + "', Date_of_Forward = '" + Date_of_Forward + "', Actual_InterestRate = '" + Actual_InterestRate + "', purpose_of_loan = '" + purpose_of_loan + "', comment = '" + comment + "', forwardamount = '" + Amount + "', ForwordCno = '" + forwordno + "', receipt_no = '" + receipt_no + "', reason = N'" + purpose_of_loan + "', loantype = N'" + loantype + "' WHERE (GirviRecordNo = '" + gn + "')";
            _objSQLHelper.ExecuteSql(str);
        }


        //public void saveinreleasemasternew(string Khatawani_no, string Girvino, string AmountDeposit, string no_of_days, string intersetRate, string IntersetPaid, string dateOfRelease, string Interest_Amount)
        //{
        //    SqlCommand com = new SqlCommand("INSERT INTO GirviReleasemaster (Khatawani_no, Girvino, AmountDeposit, TotalDays, intersetRate, IntersetPaid, dateOfRelease,Interest_Amount) VALUES ('" + Khatawani_no + "', '" + Girvino + "', '" + AmountDeposit + "', '" + no_of_days + "', '" + intersetRate + "', '" + IntersetPaid + "', '" + dateOfRelease + "','" + Interest_Amount + "')");
        //    int x = _objSQLHelper.nonquerry(com);
        //}

        public void addTemporaryValues(string Date, string Add_Girvi, string Release_Girvi, string interest, string expense, string amountadd, string opening_value)
        {
            string str = "INSERT INTO Bhandval_Temporary_Data (Date, Add_Girvi, Release_Girvi, interest,expense,amountadd, opening_value) VALUES('" + Date + "', '" + Add_Girvi + "', '" + Release_Girvi + "', '" + interest + "', '" + expense + "', '" + amountadd + "', '" + opening_value + "')";
           int x = _objSQLHelper.ExecuteSql(str); 
        }

        public void deletefromtemporary()
        {
            string str = "DELETE FROM Bhandval_Temporary_Data";
            _objSQLHelper.ExecuteSql(str); 
        }

        public DataTable getAllGirvidatewise(string startdate,string enddate)
        {
            string cmd = "SELECT khatawani_No,GirviRecordNo, Amount,Date_of_deposit,receipt_no,interset_rate FROM GirviMaster WHERE (CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <= CONVERT(DateTime, '" + enddate + "' , 103))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getAllGirvidatewiseunrelease(string startdate, string enddate)
        {
            string cmd = "SELECT khatawani_No,GirviRecordNo, Amount,Date_of_deposit FROM GirviMaster WHERE (CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, Date_of_deposit, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103)) and Status = 'unchange'";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }
        public DataTable getAllGirviRelease(string dateOfRelease, string none)
        {
            string cmd = "SELECT Khatawani_no,Girvino,AmountDeposit,Interest_Amount FROM GirviReleasemaster WHERE (dateOfRelease = '" + dateOfRelease + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getAllGirviReleasenew(string startdate, string enddate)
        {
            string cmd = "SELECT Khatawani_no,Girvino,AmountDeposit,Interest_Amount,dateOfRelease FROM GirviReleasemaster WHERE  (CONVERT(DateTime, dateOfRelease, 103) >= CONVERT(DateTime,  '" + startdate + "', 103)) AND (CONVERT(DateTime, dateOfRelease, 103) <=  CONVERT(DateTime, '" + enddate + "' , 103))";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable addAmount(string Date, string Name, string Amount)
        {
            string str1 = "INSERT INTO OtherAmountAdd (Date, Name, Amount) VALUES('" + Date + "', N'" + Name + "', '" + Amount + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable getamount(string Date)
        {
            string str1 = "SELECT Date, Name, Amount FROM OtherAmountAdd WHERE (Date = '" + Date + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public double getexpenseTotal(string Date)
        {
            double sum = 0;
            string str = "SELECT AccountNature.srno, AccountLedger.ledgerId, AccountNature.Nature, CreditDebitDetails.credit, CreditDebitDetails.debit, AccountNature.Under FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN  CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (CONVERT(DateTime, CreditDebitDetails.date, 103) = CONVERT(DateTime, '" + Date + "', 103) And  CreditDebitDetails.Type='Cr' And AccountNature.Under = N'Cash-In-Hand' )";
          //  string cmd = "SELECT Expense_Amount,Date FROM Daily_Expenses_Master WHERE (Date='" + Date + "' and Status='Debit')";
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
           // string cmd = "SELECT Amount,Date FROM OtherAmountAdd WHERE (Date='" + Date + "') and Status='Credit'";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][4].ToString());
            }
            return sum;
        }

        public DataTable retrunfirstname()
        {
            string cmd = "SELECT id, Name FROM OpeningAccount ";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        //public double getexpensesalary_New(string p)
        //{
        //    //double sum = 0;
        //    //SqlCommand cmd = new SqlCommand("SELECT Expense_Type, Expense_Amount FROM OtherAmountAdd WHERE (Date='" + p + "')");
        //    //DataTable dt = _objSQLHelper.reader(cmd);
        //    //for (int i = 0; i < dt.Rows.Count; i++)
        //    //{
        //    //    sum = sum + Convert.ToDouble(dt.Rows[i][1].ToString());
        //    //}
        //    //return sum;
        //}

        public double getexpensesall_new(string Date)
        {
            double sum = 0;
            string cmd = "SELECT Name, Amount FROM OtherAmountAdd WHERE (Date='" + Date + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dt.Rows[i][1].ToString());
            }
            return sum;
        }

        public DataTable updateDailyExpense(string Date, string Expense_Type, string Expense_Amount, string DateToCompare, string Expense_TypeToCompare, string Expense_AmountToCompare)
        {
            string str1 = "UPDATE Daily_Expenses_Master SET Date ='" + Date + "', Expense_Type =N'" + Expense_Type + "', Expense_Amount ='" + Expense_Amount + "' WHERE (Date = '" + DateToCompare + "') AND (Expense_Type = N'" + Expense_TypeToCompare + "') AND (Expense_Amount = '" + Expense_AmountToCompare + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable deleteDailyExpense(string Date, string Expense_Type, string Expense_Amount)
        {
            string str1 = "DELETE FROM Daily_Expenses_Master WHERE (Date = '" + Date + "') AND (Expense_Type = N'" + Expense_Type + "') AND (Expense_Amount = '" + Expense_Amount + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public DataTable getallgividetails()
        {
            string cmd = "SELECT khatawani_No,GirviRecordNo, Amount,Date_of_deposit,duration FROM GirviMaster WHERE (Status = '" + "unchange" + "') ORDER BY GirviRecordNo DESC";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public void addforworddetail(string gn, string f_n, string date,string famt,string cno)
        {
            string str1 = "UPDATE GirviMaster SET Forwarded_to = N'" + f_n + "', Date_of_Forward = '" + date + "' ,forwardstatus = 'Forward',forwardamount='" + famt + "',ForwordCno='"+cno+"' WHERE (GirviRecordNo = '" + gn + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            //return dt;
        }

        public DataTable retrungn()
        {
            string str1 = "SELECT DISTINCT GirviRecordNo FROM GirviMaster WHERE (Status = '" + "unchange" + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }
        public DataTable deleteAmount(string Date, string Name, string Amount)
        {
            string str1 = "DELETE FROM OtherAmountAdd WHERE (Date = '" + Date + "') AND (Name = N'" + Name + "') AND (Amount = '" + Amount + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }
        public DataTable updateAmountAdd(string Date, string Name, string Amount, string DateToCompare, string NameToCompare, string AmountToCompare)
        {

            string str1 = "UPDATE OtherAmountAdd SET Date ='" + Date + "',Name =N'" + Name + "', Amount ='" + Amount + "' WHERE (Date = '" + DateToCompare + "') AND (Name = N'" + NameToCompare + "') AND (Amount = '" + AmountToCompare + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;

        }

        public DataTable getDatefromGn(string gn)
        {
            string str1 = "SELECT Date_of_deposit,receipt_no FROM GirviMaster WHERE (GirviRecordNo = '" + gn + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }

        public bool insertOpeningAccount(string name)
        {
            string query="SELECT        COUNT(*) FROM       OpeningAccount where       (Name = N'"+name+"')";
      int i=   Convert.ToInt32(   _objSQLHelper.ExecuteScalar(query));
          
            if (i > 0)
            {

                return false;

            }

            else
            {
                string str = "INSERT INTO OpeningAccount (Name) VALUES(N'" + name + "')";
             _objSQLHelper.ExecuteSql(str);
                return true;
            }
        }

        public string getAcccountid(string p)
        {
            string str = "SELECT        id FROM   OpeningAccount WHERE     (Name = N'"+p+"')";
           string id= _objSQLHelper.ExecuteScalar(str);
           return id;
        }

        public DataTable getamountfromunsecuredloan(string date,int value)
        {
            string str = "SELECT  AccountNature.Under, AccountLedger.name, CreditDebitDetails.credit, CreditDebitDetails.debit, CreditDebitDetails.date FROM AccountLedger INNER JOIN  AccountNature ON AccountLedger.accGroupId = AccountNature.srno INNER JOIN   CreditDebitDetails ON AccountLedger.ledgerId = CreditDebitDetails.ledgerId WHERE  (AccountNature.Under = N'Unsecured Loans') AND  (CreditDebitDetails.date='" + (Convert.ToDateTime(date).AddDays(value)).ToString("dd/MM/yyyy") + "')";
          return    _objSQLHelper.GetDataTable(str);
        }

        public DataTable getGirviDataByKhatawanoNo(object khatwani_No)
        {
            string str1 = "SELECT  Customer_Master.khatawani_No , Customer_Master.FullName, Customer_Master.Contact_No, GirviMaster.GirviRecordNo, GirviMaster.Amount, GirviMaster.Date_of_deposit,  GirviMaster.interset_rate, GirviMaster.Status, GirviMaster.withdraw_release_date FROM   Customer_Master INNER JOIN  GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No where  GirviMaster.khatawani_No='" + khatwani_No + "' ";

            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }
    }
    }

