using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Girvi
{
    public class cls_GirviAdd
    {
        SQLHelper _objSQLHelper = new SQLHelper();
        public string get_InvoiceNo()
        {
            string cmd = "SELECT max(Girvi_no) FROM  Girvi_no_table";
            string GirviNo = Convert.ToString(_objSQLHelper.ExecuteScalar(cmd));
            //string GirviNo = "SELECT Girvi_no FROM  Girvi_no_table where Girvi_no>0";

            int Girvi_No = Convert.ToInt32(GirviNo) + 1;

            return Girvi_No.ToString();

        }
        public string get_KhatawaniNo()
        {
            string cmd = "SELECT max(kh_no) FROM  khatawani";
            string khno = Convert.ToString(_objSQLHelper.ExecuteScalar(cmd));
            //string GirviNo = "SELECT Girvi_no FROM  Girvi_no_table where Girvi_no>0";

            int khatawani = Convert.ToInt32(khno) + 1;

            return khatawani.ToString();

        }
        public DataTable getFirstName()
        {
            string cmd = "SELECT FullName FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getAddressPostTehsil()
        {
            string str = "SELECT  Address FROM  AdressPostTahsilMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public DataTable getKhatawani()
        {
            string cmd = "SELECT khatawani_No FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }
        public DataTable getItemtype()
        {
            string cmd = "SELECT DISTINCT item_type FROM GirviItemMaster";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }
        public DataTable getFName()
        {
            string cmd = "SELECT FullName FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getFName(string name)
        {
            string cmd = "SELECT FullName FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            DataTable dtNew = new DataTable();
            dtNew.Columns.Add("FullName");
            int j = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["FullName"].ToString().Contains(name))
                {
                    dtNew.Rows.Add();
                    dtNew.Rows[j]["FullName"] = dt.Rows[i]["FullName"].ToString();
                    j++;
                }
            }
            return dtNew;
        }

        public DataTable getCity()
        {
            string cmd = "SELECT DISTINCT Address2 FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }
        public DataTable getPoliceStation()
        {
            string cmd = "SELECT DISTINCT PoliceStation FROM  Customer_Master ";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getTahsil()
        {
            string cmd = "SELECT DISTINCT Tahsil FROM  TahsilMaster";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getAddress()
        {
            string cmd = "SELECT DISTINCT Address FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getDistrict()
        {
            string cmd = "SELECT DISTINCT District FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }


        public void addCustomer(string kh_no, string FullName, string Contact_No, string Address, string Opening_date, string cast, string occupation, string pageno, string address2, string image, string doc1, string doc2, string doc3,string PoliceStation,string Tahsil,string District)
        {
            string str = "INSERT INTO Customer_Master(khatawani_No, FullName, Contact_No, Address,Opening_date,photo,doc1,doc2,doc3,cast,occupation,PageNo,Address2,PoliceStation,Tahsil,District)VALUES ('" + kh_no + "', N'" + FullName + "', '" + Contact_No + "', N'" + Address + "','" + Opening_date + "','" + image + "','" + doc1 + "','" + doc2 + "','" + doc3 + "',N'" + cast + "',N'" + occupation + "','" + pageno + "',N'" + address2 + "',N'" + PoliceStation + "',N'" + Tahsil + "',N'" + District + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getGirviNo(string girviNo)
        {
            string str = "SELECT GirviRecordNo FROM GirviMaster WHERE(GirviRecordNo = '" + girviNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public void addGirviMaster(string girvi_no, string khatawani_no, string rate, string deposite_date, string loan_amount, string duration, string up_g_n, string actualInt, string purpose, string cmnt, string pgno, string loanreason, string loantype, int financialYearId, string narration )
        {
            string str = "INSERT INTO GirviMaster (GirviRecordNo, khatawani_No, interset_rate, Date_of_deposit, Amount, duration,updated_girvi_no,Actual_InterestRate,purpose_of_loan,comment,receipt_no,reason,loantype,financialYearId,narration) VALUES ('" + girvi_no + "', '" + khatawani_no + "', '" + rate + "', '" + deposite_date + "', '" + loan_amount + "', '" + duration + "','" + up_g_n + "','" + actualInt + "',N'" + purpose + "',N'" + cmnt + "','" + pgno + "',N'" + loanreason + "',N'" + loantype + "','" + financialYearId + "',N'" + narration + "')";
            _objSQLHelper.ExecuteSql(str);
        }


        public void addGirviItemMaster(string girvi_no, string metalEnglish, string metalMarathi, string itemMarathi, string gross_wt, string red_wt, string net_wt, string wt_in_per, string fine_wt, string qua, string curr_rate, string amt, string Narration)
        {
            string str = "INSERT INTO GirviItemMaster(GirviNo, metal_type_no, metal_type,item_type, gross_wt,reduce_wt, net_wt, wt_in_percent,fine_wt,Total_Quantity,current_rate,amount,narration) VALUES ('" + girvi_no + "', '" + metalEnglish + "', N'" + metalMarathi + "', N'" + itemMarathi + "', '" + gross_wt + "', '" + red_wt + "', '" + net_wt + "','" + wt_in_per + "','" + fine_wt + "','" + qua + "','" + curr_rate + "','" + amt + "','" + Narration + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getKhatawaniByName(string txt_FullName)
        {
            string cmd = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2,doc1,doc2,doc3,PoliceStation,Tahsil,District  FROM   Customer_Master WHERE  (FullName = N'" + txt_FullName + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;

        }
        public DataTable getKhatawaniByNameKhatawani(string khatawani)
        {
            string cmd = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2,doc1,doc2,doc3,PoliceStation,Tahsil,District  FROM   Customer_Master WHERE  (khatawani_No = '" + khatawani + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;

        }

        public DataTable getAllKhatawaniDetails()
        {
            string cmd = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;

        }

        public DataTable getKhatawaniByKhatawaniNo(string KhNo)
        {
            string cmd = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (khatawani_No = '" + KhNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;

        }
        public DataTable getCustomerMaster(string Contact_No)
        {
            string cmd = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE  (Contact_No = '" + Contact_No + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;

        }


        public void updateGirviNumber(string GirviNo)
        {
            string str = "INSERT INTO Girvi_no_table(Girvi_no) VALUES('" + GirviNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void updateKhatawaniNumber(string KhatawaniNo)
        {
            string str = "INSERT INTO khatawani(kh_no) VALUES('" + KhatawaniNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }



        public DataTable getGirviDetailsByKhatawani(string khatawani_No)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,Status,forwardamount FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "') and (Release = '" + "Unreleased" + "') AND (Status = '" + "unchange" + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getGirviDetailsByKhatawaniAll(string khatawani_No)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,Status,NSN FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "') And (Status = '" + "unchange" + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }


        public DataTable getGirviDetailsByKhatawaniInterest(string khatawani_No)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,Status FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "') AND ((Status = '" + "Release" + "') OR (Status = '" + "unchange" + "'))";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
        public DataTable getGirviDataByKhatawanoNo(object khatwani_No)
        {
            string str1 = "SELECT  Customer_Master.khatawani_No , Customer_Master.FullName, Customer_Master.Contact_No, GirviMaster.GirviRecordNo, GirviMaster.Amount, GirviMaster.Date_of_deposit,  GirviMaster.interset_rate, GirviMaster.Status, GirviMaster.withdraw_release_date,GirviMaster. narration FROM   Customer_Master INNER JOIN  GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No where  GirviMaster.khatawani_No='" + khatwani_No + "' ";

            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }


        public void addforworddetail(string gn, string f_n, string date, string famt, string cno, string intrest)
        {
            string str1 = "UPDATE GirviMaster SET Forwarded_to = N'" + f_n + "', Date_of_Forward = '" + date + "' ,forwardstatus = 'Forward',forwardamount='" + famt + "',ForwardCno='" + cno + "', Interest='" + intrest + "' WHERE (GirviRecordNo = '" + gn + "')";

            _objSQLHelper.ExecuteSql(str1);

        }
        public DataTable getGirviDetailsByKhatawaniForDate(string khatawani_No, string Date)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,Status FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "') AND  (Status = '" + "unchange" + "') AND (Date_of_deposit='" + Date + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getGirviDetailsByKhatawaniAllUnreleased(string khatawani_No, string Date)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,Status FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "')  AND (CONVERT(DateTime,Date_of_deposit, 103) <= CONVERT(DateTime, '" + Date + "', 103))";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getGirviDetailsAllUnreleased(string Date)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,Status FROM GirviMaster WHERE  (CONVERT(DateTime,Date_of_deposit, 103) < CONVERT(DateTime, '" + Date + "', 103))";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getGirviDetailsAllUnreleased(string Date,string currentDate)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,Status FROM GirviMaster WHERE  (CONVERT(DateTime,Date_of_deposit, 103) >= CONVERT(DateTime, '" + Date + "', 103)) AND (CONVERT(DateTime,Date_of_deposit, 103) <= CONVERT(DateTime, '" + currentDate + "', 103))";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getReleaseGirviDetailsByKhatawaniForDate(string khatawani_No, string Date)
        {
            string cmd = "SELECT dateOfRelease, Girvino,AmountDeposit,Interest_Amount,IntersetPaid,pavtino  FROM  Girvireleasemaster WHERE   (Khatawani_no = '" + khatawani_No + "') AND (dateOfRelease='" + Date + "')";
            DataTable dt2 = _objSQLHelper.GetDataTable(cmd);
            return dt2;
        }

        public DataTable getReleaseGirviDetailsByKhatawaniFinacial(string khatawani_No, string Date)
        {
            string cmd = "SELECT dateOfRelease, Girvino,AmountDeposit,Interest_Amount,IntersetPaid,pavtino  FROM  Girvireleasemaster WHERE   (Khatawani_no = '" + khatawani_No + "') AND (CONVERT(DateTime,dateOfRelease, 103) <= CONVERT(DateTime, '" + Date + "', 103)";
            DataTable dt2 = _objSQLHelper.GetDataTable(cmd);
            return dt2;
        }

        public DataTable getGirviDetailsByKhatawaniForInterest(string khatawani_No)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,Status FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "') AND  (Status = '" + "unchange" + "') ";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getGirviDetailsByKhatawaniForReceiptNo(string khatawani_No)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no,Status FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "')  ";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public string getReceiptNo(string startLetters)
        {
            string str = "SELECT receipt_no FROM GirviMaster WHERE (receipt_no LIKE '" + startLetters + "')  ";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            if (dt.Rows.Count == 0)
            {
                return "1";
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["receipt_no"] = dt.Rows[i]["receipt_no"].ToString().Substring(10);
                    //string startyear = " SELECT  startyear FROM  FinancialYearMaster
                }
            }
            int temp;
            string MaxID2 = (dt.Rows.Cast<DataRow>().Max(r => int.TryParse(r["receipt_no"].ToString(), out temp) ? temp : 0) + 1).ToString();
            return MaxID2;
        }


        public string getReceiptNoRelease(string startLetters)
        {
            string str = "SELECT pavtino FROM GirviReleasemaster WHERE (pavtino LIKE '" + startLetters + "')  ";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            if (dt.Rows.Count == 0)
            {
                return "1";
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["pavtino"] = dt.Rows[i]["pavtino"].ToString().Substring(10);
                    //string startyear = " SELECT  startyear FROM  FinancialYearMaster
                }
            }
            int temp;
            string MaxID2 = (dt.Rows.Cast<DataRow>().Max(r => int.TryParse(r["pavtino"].ToString(), out temp) ? temp : 0) + 1).ToString();
            return MaxID2;
        }

        public DataTable getkhatavaniphotos(string p)
        {
            string str  = "SELECT photo, doc1, doc2, doc3 FROM Customer_Master WHERE(khatawani_No = '" + p + ")'";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }


        public void updateCustomer(string kh_no, string FullName, string Contact_No, string Address, string cast, string occupation, string pageno, string address2, string image, string doc1, string doc2, string doc3)
        {
            string str = "Update Customer_Master set  FullName = N'" + FullName + "', Contact_No ='" + Contact_No + "', Address=N'" + Address + "',photo='" + image + "',doc1='" + doc1 + "',doc2='" + doc2 + "',doc3='" + doc3 + "',cast=N'" + cast + "',occupation=N'" + occupation + "',PageNo='" + pageno + "',Address2=N'" + address2 + "' Where khatawani_No='" + kh_no + "' ";
            _objSQLHelper.ExecuteSql(str);
        }
        public void updateCustWithoutPhoto(string kh_no, string FullName, string Contact_No, string Address, string cast, string occupation, string pageno, string address2)
        {
            string str = "Update Customer_Master set  FullName = N'" + FullName + "', Contact_No ='" + Contact_No + "', Address=N'" + Address + "',cast=N'" + cast + "',occupation=N'" + occupation + "',PageNo='" + pageno + "',Address2=N'" + address2 + "' Where khatawani_No='" + kh_no + "' ";
            _objSQLHelper.ExecuteSql(str);
        }


        public DataTable getGirviByInvoiceNo(string txt_InvoiceNo)
        {
            string cmd = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,duration,Release,Status,updated_girvi_no,withdraw_release_date,photo,doc1,doc2,doc3,Forwarded_to,Date_of_Forward,Actual_InterestRate,purpose_of_loan,comment,forwardstatus,forwardamount,ForwardCno,receipt_no,reason,loantype,khatawani_No,DateTime,financialYearId,vadhiv  FROM   GirviMaster WHERE  (GirviRecordNo = '" + txt_InvoiceNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;

        }

        public DataTable getGirviByKhatawaniNo(string txt_KhatawaniNo)
        {
            string cmd = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,duration,Release,Status,updated_girvi_no,withdraw_release_date,photo,doc1,doc2,doc3,Forwarded_to,Date_of_Forward,Actual_InterestRate,purpose_of_loan,comment,forwardstatus,forwardamount,ForwardCno,receipt_no,reason,loantype,khatawani_No,DateTime,financialYearId  FROM   GirviMaster WHERE  (khatawani_No = '" + txt_KhatawaniNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;

        }





        public DataTable getGirviDetailsByInvoiceNo(object GirviRecordNo)
        {
            string str = "SELECT Customer_Master.FullName, Customer_Master.khatawani_No, Customer_Master.Contact_No, Customer_Master.Address, Customer_Master.Balance, Customer_Master.Opening_date, Customer_Master.photo,Customer_Master.doc1, Customer_Master.doc2, Customer_Master.doc3, Customer_Master.DateTime, Customer_Master.cast, Customer_Master.Address2, Customer_Master.userKhatawani,GirviMaster.DateTime AS Expr1, GirviMaster.khatawani_No AS Expr2, GirviMaster.Amount, GirviMaster.GirviRecordNo, GirviMaster.Date_of_deposit, GirviMaster.interset_rate, GirviMaster.duration,GirviMaster.Release, GirviMaster.Status, GirviMaster.updated_girvi_no, GirviMaster.withdraw_release_date, GirviMaster.Forwarded_to, GirviMaster.Date_of_Forward, GirviMaster.purpose_of_loan,GirviMaster.receipt_no, GirviMaster.loantype FROM Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No WHERE(GirviMaster.GirviRecordNo='" + GirviRecordNo + "')";

            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;              
             
        }

        public DataTable getGirviDetailsByKhatawaniNo(object khatawani_No)
        {
            string str = "SELECT Customer_Master.FullName, Customer_Master.khatawani_No, Customer_Master.Contact_No, Customer_Master.Address, Customer_Master.Balance, Customer_Master.Opening_date, Customer_Master.photo,Customer_Master.doc1, Customer_Master.doc2, Customer_Master.doc3, Customer_Master.DateTime, Customer_Master.cast, Customer_Master.Address2, Customer_Master.userKhatawani,GirviMaster.DateTime AS Expr1, GirviMaster.khatawani_No AS Expr2, GirviMaster.Amount, GirviMaster.GirviRecordNo, GirviMaster.Date_of_deposit, GirviMaster.interset_rate, GirviMaster.duration,GirviMaster.Release, GirviMaster.Status, GirviMaster.updated_girvi_no, GirviMaster.withdraw_release_date, GirviMaster.Forwarded_to, GirviMaster.Date_of_Forward, GirviMaster.purpose_of_loan,GirviMaster.receipt_no, GirviMaster.loantype FROM Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No WHERE(GirviMaster.khatawani_No='" + khatawani_No + "')";

            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;

        }

        public DataTable getGirviMasterDetails()
        {
            string str = "select * from GirviMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;   
        }

        public DataTable getGirviByReceiptNo(string txt_ReceiptNo)
        {
            string cmd = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,duration,Release,Status,updated_girvi_no,withdraw_release_date,photo,doc1,doc2,doc3,Forwarded_to,Date_of_Forward,Actual_InterestRate,purpose_of_loan,comment,forwardstatus,forwardamount,ForwardCno,receipt_no,reason,loantype,khatawani_No,DateTime,financialYearId  FROM   GirviMaster WHERE  (receipt_no = '" + txt_ReceiptNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;

        }
        public DataTable getGirviDetailsByReceiptNo(object receipt_no)
        {
            string str = "SELECT Customer_Master.FullName, Customer_Master.khatawani_No, Customer_Master.Contact_No, Customer_Master.Address, Customer_Master.Balance, Customer_Master.Opening_date, Customer_Master.photo,Customer_Master.doc1, Customer_Master.doc2, Customer_Master.doc3, Customer_Master.DateTime, Customer_Master.cast, Customer_Master.Address2, Customer_Master.userKhatawani,GirviMaster.DateTime AS Expr1, GirviMaster.khatawani_No AS Expr2, GirviMaster.Amount, GirviMaster.GirviRecordNo, GirviMaster.Date_of_deposit, GirviMaster.interset_rate, GirviMaster.duration,GirviMaster.Release, GirviMaster.Status, GirviMaster.updated_girvi_no, GirviMaster.withdraw_release_date, GirviMaster.Forwarded_to, GirviMaster.Date_of_Forward, GirviMaster.purpose_of_loan,GirviMaster.receipt_no, GirviMaster.loantype FROM Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No WHERE(GirviMaster.receipt_no='" + receipt_no + "')";

            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;

        }

        public DataTable getKhatawaniByFullName(string FullName)
        {
            string str = "SELECT     Distinct   khatawani_No, FullName, Contact_No, Address FROM    Customer_Master WHERE        (FullName = N'" + FullName + "')";
            return _objSQLHelper.GetDataTable(str);
        }

        public DataTable getPavtiNo(string receipt_no)
        {
            string str = "SELECT receipt_no FROM GirviMaster WHERE(receipt_no = '" + receipt_no + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getVinaTarakDataByKhatawanoNo(string start, string end)
        {
            string str1 = "SELECT  Customer_Master.khatawani_No , Customer_Master.FullName, Customer_Master.Contact_No,Customer_Master.Address,Customer_Master.Balance,Customer_Master.Opening_date,Customer_Master.cast,Customer_Master.occupation,Customer_Master.Address2,Customer_Master.DateTime,Customer_Master.District,GirviMaster.duration,GirviMaster.Release,GirviMaster.Actual_InterestRate,GirviMaster.reason, GirviMaster.GirviRecordNo, GirviMaster.Amount, GirviMaster.Date_of_deposit,  GirviMaster.interset_rate, GirviMaster.Status, GirviMaster.withdraw_release_date,GirviMaster.loantype FROM   Customer_Master INNER JOIN  GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No where  (CONVERT(DateTime, Date_of_deposit, 103) >= CONVERT(DateTime,  '" + start + "', 103)) and (CONVERT(DateTime, Date_of_deposit, 103) <=  CONVERT(DateTime, '" + end + "' , 103)) AND(GirviMaster.loantype= N'" + "विनातारण" + "')";

            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
        }
    }
}
