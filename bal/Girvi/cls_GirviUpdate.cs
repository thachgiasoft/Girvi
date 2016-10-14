using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAL;
using System.Data;

namespace BAL.Girvi
{
    public class cls_GirviUpdate
    {

        SQLHelper _objSQLHelper = new SQLHelper();
        public bool checkaccount(string fname, string contactno, string address)
        {
            string cmd = "SELECT  khatawani_No, FullName, Contact_No, Address FROM   Customer_Master WHERE (FullName = '" + fname + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else { return true; }
        }
        public string getkhatwanino()
        {
            string billno = _objSQLHelper.gmGetMstID("K", "0");
            return billno;

            //SqlCommand cmd = new SqlCommand("SELECT max(kh_no) FROM  khatawani");
            //string GirviNo = Convert.ToString(_objSQLHelper.scalar(cmd));
            ////string GirviNo = "SELECT Girvi_no FROM  Girvi_no_table where Girvi_no>0";

            //int Girvi_No = Convert.ToInt32(GirviNo) + 1;

            //return Girvi_No.ToString();
        }

        public DataTable Serachgirvi(string GirviNo)
        {

            string cmd = "SELECT * FROM  GirviMaster WHERE   (GirviRecordNo = '" + GirviNo + "') AND (Release='" + false + "')";
            DataTable
        dt = _objSQLHelper.GetDataTable(cmd);

            return dt;

        }
        public DataTable fillkhatawnicomboboox()
        {
            string cmd = "SELECT  khatawani_No FROM   Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }
        public DataTable fillgirvino()
        {
            string cmd = "SELECT   GirviRecordNo FROM  GirviMaster";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }





        //public DataTable SearchCustomerrecord( string  Khatwani_no ,string name)
        //{
        //    _objMortageUpdateDAL.khatwani_No = Khatwani_no;
        //    _objMortageUpdateDAL.firstname = name;

        //     DataTable dt=null;
        //     SqlCommand cmd = new SqlCommand("SELECT khatawani_No, FullName, Contact_No, Address  FROM   Customer_Master WHERE   (khatawani_No = '" + _objMortageUpdateDAL.khatwani_No + "')OR( FullName='"+_objMortageUpdateDAL.firstname+"')");
        //    dt = _objSQLHelper.reader(cmd);

        //    return dt;
        //}
        public DataTable searchRecord(string khatawani_no)
        {
            DataTable dt = null;
            string cmd = "SELECT FullName, Contact_No, Address  FROM   Customer_Master WHERE   (khatawani_No = '" + khatawani_no + "')";
            dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }
        public void Save(string fname, string contactno, string address, string depositdetail, string date, string intersetRate, string depositAmount, string duration, string grosswt, string netwt)
        {

            string cmd = "INSERT INTO Customer_Master (FullName,  Contact_No, Address ) VALUES ('" + fname + "',  '" + contactno + "', '" + address + "')";
            string cmd1 = "SELECT khatawani_No FROM  Customer_Master WHERE   (FullName = '" + fname + "') AND  (Contact_No = '" + contactno + "') AND (Address = '" + address + "') ";
            _objSQLHelper.ExecuteSql(cmd);


        }
        public DataTable Save(string khatwaniNo, string depositdetail, string date, string intersetRate, string depositAmount, string duration, string grosswt, string netwt)
        {


            string cmd = "INSERT INTO GirviMaster (khatawani_No, Item_Details, Amount, GrossWt, Netwt, Date_of_deposit, interset_rate, duration, Release) VALUES ('" + khatwaniNo + "', '" + depositdetail + "', '" + grosswt + "', '" + netwt + "', '" + depositdetail + "', '" + intersetRate + "', '" + duration + "', '" + false + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;



        }
        public DataTable updateRecord(string khatawani_no, string fname, string contactno, string address)
        {

            string cmd = "Customer_Master SET  FullName = '" + fname + "', Contact_No = '" + contactno + "', Address = '" + address + "' WHERE (khatawani_No = '" + khatawani_no + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }
        public DataTable updateRecord(string khatwaniNo, string GirviNo, string depositdetail, string date, string intersetRate, string depositAmount, string duration, string grosswt, string netwt)
        {

            string cmd = "UPDATE  GirviMaster SET Item_Details = '" + depositdetail + "', Amount = '" + depositAmount + "', GrossWt ='" + grosswt + "', Netwt='" + netwt + "' ,Date_of_deposit = '" + depositdetail + "', interset_rate = '" + intersetRate + "',duration ='" + duration + "' WHERE  (khatawani_No = '" + khatwaniNo + "') AND (GirviRecordNo='" + GirviNo + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }





        public string selectgivino(string x, string itemdetal, string dateofdeposite, string intesetrate, string duration, string amount)
        {

            string cmd = "SELECT  GirviRecordNo FROM GirviMaster WHERE (khatawani_No = '" + x + "') AND (Item_Details = '" + itemdetal + "') AND (Amount = '" + dateofdeposite + "') AND (Date_of_deposit = '" + dateofdeposite + "') AND (interset_rate = '" + intesetrate + "') AND (duration = '" + duration + "')";
            string value = Convert.ToString(_objSQLHelper.ExecuteSql(cmd));
            return value;
        }

        public string getGirviNO(string KhatawaniNo, string Depositdetails, string date, string rate, string Amount, string duration, string grossWt, string netWt)
        {

            string cmd = "SELECT GirviRecordNo FROM  GirviMaster WHERE  (Item_Details = '" + Depositdetails + "') AND (khatawani_No = '" + KhatawaniNo + "') AND (Amount = '" + Depositdetails + "') AND (GrossWt = '" + grossWt + "') AND (Netwt = '" + netWt + "') AND (Date_of_deposit = '" + Depositdetails + "') AND  (interset_rate = '" + rate + "')";
            string value = Convert.ToString(_objSQLHelper.ExecuteSql(cmd));
            return value;

        }
        public DataTable retrunfirstname()
        {
            string cmd = "SELECT FullName FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable retrunaddress()
        {
            string str = "SELECT  Address FROM  AddressMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable retrunCustomeraddress()
        {
            string str = "SELECT distinct  Address FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable retrunKhatawani()
        {
            string cmd = "SELECT khatawani_No FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        //public void insertCustomer(string kh_no, string FullName, string Contact_No, string Address, string Opening_date, string cast, string occupation, string pageno, string address2)
        //{
        //    string str = "INSERT INTO Customer_Master(khatawani_No, FullName, Contact_No, Address,Opening_date,photo,doc1,doc2,doc3,cast,occupation,PageNo,Address2)VALUES ('" + kh_no + "', N'" + FullName + "', '" + Contact_No + "', N'" + Address + "','" + Opening_date + "','" + clsVariable.imagepath + "','" + clsVariable.doc1path + "','" + clsVariable.doc2path + "','" + clsVariable.doc3path + "',N'" + cast + "',N'" + occupation + "','" + pageno + "',N'" + address2 + "')";
        //    _objSQLHelper.ExecuteSql(str);
        //    // throw new NotImplementedException();
        //}
        public void updateCustomer(string KhatawariNo, string name, string contactNo, string address)
        {
            string str = "UPDATE Customer_Master SET  FullName = N'" + name + "', Contact_No = '" + contactNo + "', Address = N'" + address + "' WHERE (khatawani_No = '" + KhatawariNo + "')";

            _objSQLHelper.ExecuteSql(str);


        }

        public string getKhatwaniName()
        {
            throw new NotImplementedException();
        }

        public string get_girvi_no()
        {
            string cmd = "SELECT max(Girvi_no) FROM  Girvi_no_table";
            string GirviNo = Convert.ToString(_objSQLHelper.ExecuteScalar(cmd));
            //string GirviNo = "SELECT Girvi_no FROM  Girvi_no_table where Girvi_no>0";

            int Girvi_No = Convert.ToInt32(GirviNo) + 1;

            return Girvi_No.ToString();

        }
        public string get_khtawani_no()
        {
            string cmd = "SELECT max(kh_no) FROM  khatawani";
            string khno = Convert.ToString(_objSQLHelper.ExecuteScalar(cmd));
            //string GirviNo = "SELECT Girvi_no FROM  Girvi_no_table where Girvi_no>0";

            int khatawani = Convert.ToInt32(khno) + 1;

            return khatawani.ToString();

        }

        public object fillJewelleryTypeCombobox(string p)
        {

            string cmd = "SELECT SubMetalId,SubMetalName,SubMetalHindi FROM  SubMetalMaster"/* WHERE (MetalId = '" + _objFrm_salesEnteryDAL.Metalid + "')"*/;
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
            // throw new NotImplementedException();
        }

        public string getmetalname(string MetalId)
        {
            string cmd = "SELECT  MetalHindi FROM    MetalMaster WHERE   (MetalId = '" + MetalId + "')";

            string text = Convert.ToString(_objSQLHelper.ExecuteScalar(cmd));
            return text;
            throw new NotImplementedException();
        }

        public DataTable fillmetaltype()
        {
            string cmd = "SELECT * FROM  MetalMaster";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        //public void insertGirvidata(string p, string p_2, string p_3, string p_4, string p_5,string p_6)
        //{
        //    string str = "INSERT INTO GirviItemMaster(GirviNo, metal_type, item_type, gross_wt, nt_wt,Total_Quantity) VALUES ('"+p+"',N'"+p_2+"',N'"+p_3+"', '"+p_4+"', '"+p_5+"','"+p_6+"')";
        //    _objSQLHelper.ExecuteSql(str); 
        //}

        public void updateGirvinumber(string girvi_no)
        {
            string str = "INSERT INTO Girvi_no_table(Girvi_no) VALUES('" + girvi_no + "')";
            _objSQLHelper.ExecuteSql(str);
            //  throw new NotImplementedException();
        }
        public void updatekhatwanino(string kh)
        {
            string str = "INSERT INTO khatawani(kh_no) VALUES('" + kh + "')";
            _objSQLHelper.ExecuteSql(str);
            //  throw new NotImplementedException();
        }
        //public void insertGirvimasterData(string girvi_no, string khatawani_no, string rate, string deposite_date, string loan_amount, string duration, string up_g_n, string actualInt, string purpose, string cmnt, string pgno, string loanreason, string loantype)
        //{
        //    string str = "INSERT INTO GirviMaster (GirviRecordNo, khatawani_No, interset_rate, Date_of_deposit, Amount, duration,updated_girvi_no,photo,doc1,doc2,doc3,Actual_InterestRate,purpose_of_loan,comment,receipt_no,reason,loantype) VALUES ('" + girvi_no + "', '" + khatawani_no + "', '" + rate + "', '" + deposite_date + "', '" + loan_amount + "', '" + duration + "','" + up_g_n + "','" + clsVariable.imagepath + "','" + clsVariable.doc1path + "','" + clsVariable.doc2path + "','" + clsVariable.doc3path + "','" + actualInt + "',N'" + purpose + "',N'" + cmnt + "','" + pgno + "',N'" + loanreason + "',N'" + loantype + "')";
        //    _objSQLHelper.ExecuteSql(str);
        //    //throw new NotImplementedException();
        //}

        public void getallgirvidata(string p)
        {
            //throw new NotImplementedException();
        }

        public DataTable getgirvidata(string khatawani_No)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,duration,Forwarded_to,Date_of_Forward,receipt_no FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "') and (Release = '" + "Unreleased" + "') AND (Status = '" + "unchange" + "')";
            //throw new NotImplementedException();
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable fillgirvidata(string str)
        {
            string str1 = "SELECT GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt,reduce_wt, net_wt,wt_in_percent, fine_wt,Total_Quantity,current_rate,amount FROM GirviItemMaster WHERE (GirviNo = '" + str + "')";
            //throw new NotImplementedException();
            DataTable dt = _objSQLHelper.GetDataTable(str1);
            return dt;
            //throw new NotImplementedException();
        }


        public DataTable SearchCustomerrecord(string khatwani_No, string name)
        {
            string str = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo,photo,cast,occupation,Address2  FROM   Customer_Master WHERE   (khatawani_No = '" + khatwani_No + "')OR (FullName = N'" + name + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable SearchCustomerrecordnumber(string khatawani_No)
        {

            string str = "SELECT khatawani_No, FullName, Contact_No, Address  FROM   Customer_Master WHERE   (khatawani_No = '" + khatawani_No + "')O";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable SearchCustomerrecordname(string firstname)
        {

            string cmd = "SELECT khatawani_No, FullName, Contact_No, Address  FROM   Customer_Master WHERE   (FullName = '" + firstname + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }



        public string getcustomername(string FullName)
        {
            string cmd = "SELECT FullName WHERE  FullName = '" + FullName + "')";
            string value = Convert.ToString(_objSQLHelper.ExecuteScalar(cmd));
            return value;
        }

        public void updategirvi(string girvi_no, string khatawani_no, string rate, string deposite_date, string loan_amount, string duration, string updated_girvi)
        {

        }

        public void updateGirvimasterData(string GirviRecordNo, string gn)
        {
            string str = "UPDATE GirviMaster SET updated_girvi_no =" + gn + " WHERE  (GirviRecordNo =" + GirviRecordNo + " )";
            _objSQLHelper.ExecuteSql(str);
            // throw new NotImplementedException();
        }

        public DataTable viewallgirvidata(string khatawani_No)
        {
            string str = "SELECT GirviRecordNo, Amount, Date_of_deposit, interset_rate,updated_girvi_no,Status,withdraw_release_date FROM GirviMaster WHERE (khatawani_No = '" + khatawani_No + "')";
            //throw new NotImplementedException();
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable checkphotopresence(string khatawani_No)
        {
            string cmd = "SELECT photo, doc1, doc2, doc3 FROM Customer_Master WHERE(khatawani_No = '" + khatawani_No + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);

            return dt;
        }

        public void updateCustomerphoto(string khatawani_No)
        {
            //string cmd = " UPDATE Customer_Master SET photo = '" + clsVariable.imagepath + "', doc1 = '" + clsVariable.doc1path + "', doc2 = '" + clsVariable.doc2path + "', doc3 = '" + clsVariable.doc3path + "' WHERE (khatawani_No = '" + khatawani_No + "')";
            //_objSQLHelper.ExecuteSql(cmd);
            // throw new NotImplementedException();
        }

        public DataTable returnitemtype()
        {
            string cmd = "SELECT DISTINCT item_type FROM GirviItemMaster";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public void insertnewcusomer()
        {
            throw new NotImplementedException();
        }



        //public void insertGirvidata(string girvi_no, string m_typ_no, string m_typ, string item_typ_no, string item_typ, string gross_wt, string net_wt, string qua, string reduce_wt, string wt_in_per, string curr_rate, string fine_wt, string amt)
        //{
        //    string str = "INSERT INTO GirviItemMaster(GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt, net_wt, Total_Quantity,reduce_wt,wt_in_per,curr_rate,fine_wt,amount) VALUES ('" + girvi_no + "', '" + m_typ_no + "', N'" + m_typ + "', '" + item_typ_no + "', N'" + item_typ + "', '" + gross_wt + "', '" + net_wt + "', '" + qua + "','" + reduce_wt + "','" + wt_in_per + "','" + curr_rate + "','" + fine_wt + "','"+amt+"')";
        //      string str="INSERT INTO GirviItemMaster (GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt, net_wt, Total_Quantity) VALUES ('e', 'd', N'd', 'd', N'd', 'd', 'd', 'd')"
        //    _objSQLHelper.ExecuteSql(str); 
        //}



        public void insertGirvidata(string girvi_no, string m_typ_no, string m_typ, string item_typ_no, string item_typ, string gross_wt, string red_wt, string net_wt, string wt_in_per, string fine_wt, string qua, string curr_rate, string amt)
        {
            string str = "INSERT INTO GirviItemMaster(GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt,reduce_wt, net_wt, wt_in_percent,fine_wt,Total_Quantity,current_rate,amount) VALUES ('" + girvi_no + "', '" + m_typ_no + "', N'" + m_typ + "', '" + item_typ_no + "', N'" + item_typ + "', '" + gross_wt + "', '" + red_wt + "', '" + net_wt + "','" + wt_in_per + "','" + fine_wt + "','" + qua + "','" + curr_rate + "','" + amt + "')";
            //      string str="INSERT INTO GirviItemMaster (GirviNo, metal_type_no, metal_type, item_type_no, item_type, gross_wt, net_wt, Total_Quantity) VALUES ('e', 'd', N'd', 'd', N'd', 'd', 'd', 'd')"
            _objSQLHelper.ExecuteSql(str);
        }

        //public void insertusercust(string kh, string p, string p_2, string p_3, string p_4, string p_5, string p_6, string p_7, string p_8)
        //{

        //    string str = "INSERT INTO Customer_Master(khatawani_No,userKhatawani, FullName, Contact_No, Address,Opening_date,photo,doc1,doc2,doc3,cast,occupation)VALUES ('" + kh + "','" + p + "', N'" + p_2 + "', '" + p_3 + "', N'" + p_4 + "','" + p_5 + "','" + clsVariable.imagepath + "','" + clsVariable.doc1path + "','" + clsVariable.doc2path + "','" + clsVariable.doc3path + "',N'" + p_7 + "',N'" + p_8 + "')";
        //    _objSQLHelper.ExecuteSql(str);
        //}

        public DataTable getuserkhatawani(string userKhatawani)
        {
            string str = "SELECT userKhatawani FROM  Customer_Master WHERE (userKhatawani = '" + userKhatawani + "')";
            //throw new NotImplementedException();
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable retrunuserKhatawani()
        {

            string cmd = "SELECT userKhatawani FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable SearchCustomerrecorduser(string khatwani_No, string name)
        {

            string cmd = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo,photo,cast,occupation,userKhatawani  FROM   Customer_Master WHERE   (userKhatawani = '" + khatwani_No + "')OR (FullName = N'" + name + "')";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public void updatekhatawaninumber(string p)
        {
            string str = "INSERT INTO khatawani(kh_no) VALUES('" + p + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void insertkhatawani(string p)
        {
            string str = "DELETE FROM khatawani";
            _objSQLHelper.ExecuteSql(str);

            string str1 = "INSERT INTO khatawani(kh_no) VALUES(" + p + ")";
            _objSQLHelper.ExecuteSql(str1);


        }

        public DataTable searchdataontab(string khatwani_No, string firstname)
        {


            DataTable dt = null;
            string cmd = "SELECT khatawani_No, FullName, Contact_No, Address,PageNo,photo,cast,occupation  FROM   Customer_Master WHERE   (khatawani_No = '" + khatwani_No + "')OR (FullName = N'" + firstname + "')";
            dt = _objSQLHelper.GetDataTable(cmd);

            return dt;
        }

        public DataTable fname()
        {
            string cmd = "SELECT FullName FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public DataTable getForwordGirviData()
        {
            try
            {
                string str = "SELECT GirviRecordNo, Date_of_deposit, Forwarded_to, Amount, Date_of_Forward,forwardamount,khatawani_No,ForwordCno  FROM GirviMaster WHERE (Forwarded_to IS NOT NULL)";
                DataTable dt = _objSQLHelper.GetDataTable(str);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable getForwordGirviDataDatewise(string start, string end)
        {
            try
            {
                string str = "SELECT GirviRecordNo, Date_of_deposit, Forwarded_to, Amount, Date_of_Forward FROM  GirviMaster WHERE (Forwarded_to IS NOT NULL) AND ((CONVERT(DateTime, Date_of_Forward, 103) >= CONVERT(DateTime,  '" + start + "', 103)) AND (CONVERT(DateTime, Date_of_Forward, 103) <=  CONVERT(DateTime, '" + end + "' , 103)))";
                DataTable dt = _objSQLHelper.GetDataTable(str);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable getkhatawanidetl(string khno)
        {
            string str = "SELECT        FullName, Address, Contact_No, khatawani_No FROM  Customer_Master WHERE  (khatawani_No = '" + khno + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getinterest()
        {
            string cmd = "SELECT  interest from Rates";
            DataTable dt = _objSQLHelper.GetDataTable(cmd);
            return dt;
        }

        public void savenewyear(string startyear, string endyear)
        {
            string str = "INSERT INTO RegistrationMaster (StartingYear, EndingYear) VALUES        ('" + startyear + "','" + endyear + "') ";
            _objSQLHelper.ExecuteSql(str);
        }

        public string getprviousreceiptno()
        {
            string str = "SELECT        MAX(receipt_no) AS Expr1 FROM    GirviMaster";
            string preceiptno = _objSQLHelper.ExecuteScalar(str);
            return preceiptno;


        }

        public void save(string address)
        {
            string str = "INSERT INTO AddressMaster (Address) VALUES        (N'" + address + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getAddress()
        {
            string str = "select * from AddressMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public void updateGirviItems(string ID, string metal_type_eng, string metal_type_marathi, string item_type, string gross_wt, string nt_wt, string Total_Quantityy, string red_wt, string wt_in_per, string fine_wt, string curr_rate, string amount)
        {
            string str = "UPDATE GirviItemMaster SET metal_type_no = '" + metal_type_eng + "', metal_type = N'" + metal_type_marathi + "', item_type_no = '" + item_type + "', item_type = N'" + item_type + "', gross_wt = '" + gross_wt + "', net_wt = '" + nt_wt + "', Total_Quantity = '" + Total_Quantityy + "', reduce_wt = '" + red_wt + "', wt_in_percent = '" + wt_in_per + "', fine_wt = '" + fine_wt + "', current_rate = '" + curr_rate + "', amount = '" + amount + "' WHERE (ID = " + ID + ")";
            _objSQLHelper.ExecuteSql(str);
        }

        public void updateGirviMasterData(string gn, string Amount, string Date_of_deposit, string duration, string interset_rate, string withdraw_release_date, string Forwarded_to, string Date_of_Forward, string forwardamount, string forwordno, string Actual_InterestRate, string purpose_of_loan, string loantype, string comment, string receipt_no)
        {
            string str = "UPDATE GirviMaster SET  Amount = '" + Amount + "', Date_of_deposit = '" + Date_of_deposit + "', interset_rate = '" + interset_rate + "', duration = '" + duration + "', withdraw_release_date = '" + withdraw_release_date + "', Forwarded_to = N'" + Forwarded_to + "', Date_of_Forward = '" + Date_of_Forward + "', Actual_InterestRate = '" + Actual_InterestRate + "', purpose_of_loan = '" + purpose_of_loan + "', comment = '" + comment + "', forwardamount = '" + Amount + "', ForwordCno = '" + forwordno + "', receipt_no = '" + receipt_no + "', reason = N'" + purpose_of_loan + "', loantype = N'" + loantype + "' WHERE (GirviRecordNo = '" + gn + "')";
            _objSQLHelper.ExecuteSql(str);
        }




        public DataTable getallgirviitems(string girvino)
        {
            string str = "SELECT        ID, GirviNo, metal_type_no, metal_type, item_type, gross_wt, reduce_wt, net_wt, wt_in_percent, fine_wt, Total_Quantity, current_rate, amount FROM            GirviItemMaster WHERE        (GirviNo = '" + girvino + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }



        public void deleteAddressMaster(string id)
        {
            string str = "DELETE FROM AddressMaster WHERE ( srno = '" + id + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void savePostTahsil(string AdressPost)
        {
            string str = "INSERT INTO AdressPostTahsilMaster (Address) VALUES        (N'" + AdressPost + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAddressPostTehsilMaster(string id)
        {
            string str = "DELETE FROM AdressPostTahsilMaster WHERE ( srno = '" + id + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable retrunaddressPostTehsil()
        {
            string str = "SELECT  Address FROM  AdressPostTahsilMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public DataTable getAddressPostTehsil()
        {

            string str = "select * from AdressPostTahsilMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }



        public DataTable getgirvidatabyAddress(string khNo)
        {
            string str = "SELECT    Distinct    Customer_Master.FullName, Customer_Master.Contact_No, GirviMaster.Amount, GirviMaster.Date_of_deposit, GirviMaster.interset_rate, GirviMaster.duration, GirviMaster.Release, GirviMaster.Status, GirviMaster.withdraw_release_date, GirviMaster.Actual_InterestRate,  GirviMaster.purpose_of_loan, GirviMaster.comment, GirviMaster.forwardstatus, GirviMaster.forwardamount, GirviMaster.ForwordCno, GirviMaster.receipt_no,  GirviMaster.Forwarded_to, Customer_Master.Address, GirviMaster.khatawani_No, GirviMaster.GirviRecordNo FROM Customer_Master INNER JOIN GirviMaster ON Customer_Master.khatawani_No = GirviMaster.khatawani_No WHERE        (GirviMaster.khatawani_No = '" + khNo + "')";
            return _objSQLHelper.GetDataTable(str);
        }

        public DataTable getkhatawaniByAddress(string adress)
        {
            string str = "SELECT     Distinct   khatawani_No, FullName, Contact_No, Address FROM            Customer_Master WHERE        (Address = N'" + adress + "')";
            return _objSQLHelper.GetDataTable(str);
        }

        public string getinterestAmount(string gn)
        {
            string str = "SELECT        intersetRate, IntersetPaid, Interest_Amount, Girvino FROM            GirviReleasemaster WHERE        (Girvino = '" + gn + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt.Rows[0]["Interest_Amount"].ToString();
        }

        public DataTable getAddress(string add)
        {
            string str = "SELECT Address From AddressMaster WHERE (Address='" + add + "')";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public object retrunCustomerAddress()
        {
            string str = "SELECT distinct  Address FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public void updateGirviItemsDelete(String lblsrno, String MetalType, String ItemType, String GrossWt, String NetWeight, String Quantity, String ReduceWt, String WtInPercent, String FineWt, String CurrentRate, String Amount)
        {
            string str = "UPDATE GirviItemMaster SET  metal_type = N'" + MetalType + "', item_type = N'" + ItemType + "', gross_wt = '" + GrossWt + "', net_wt = '" + NetWeight + "', Total_Quantity = '" + Quantity + "', reduce_wt = '" + ReduceWt + "', wt_in_percent = '" + WtInPercent + "', fine_wt = '" + FineWt + "', current_rate = '" + CurrentRate + "', amount = '" + Amount + "' WHERE (ID = " + lblsrno + ")";
            _objSQLHelper.ExecuteSql(str);
        }

        public object retrunCustomerAddress2()
        {
            string str = "SELECT distinct  Address2 FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
    }
}

