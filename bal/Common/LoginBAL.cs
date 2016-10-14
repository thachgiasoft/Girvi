using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient; 

namespace BAL.Common
{
    
 public class LoginBAL
    {
       
        SQLHelper _objSQLHelper = new SQLHelper();



        public bool login(string Log_Id, string Password)
        {
            //throw new NotImplementedException();
           // _objLoginDAL.pass = text;
            string cmd = "SELECT Log_Id,Password FROM LoginMaster WHERE(Log_Id = '" + Log_Id + "') AND (Password = '" + Password + "')";
            DataTable x = _objSQLHelper.GetDataTable(cmd);
            try
            {
                if ((x.Rows[0][0]).ToString() == Log_Id && (x.Rows[0][1]).ToString() == Password)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string text { get; set; }

        public void changepwd(string OldPassword, string NewPassword)
        {
            //throw new NotImplementedException();
            string str = "UPDATE LoginMaster SET  Password ='" + NewPassword + "' where Password='" + OldPassword + "'";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            
        }

        public bool loginsss(string Password)
        {
           // throw new NotImplementedException();
            string cmd = "SELECT Password FROM LoginMaster WHERE (Password = '" + Password + "')";
            DataTable x = _objSQLHelper.GetDataTable(cmd);
            try
            {
                if ((x.Rows[0][0]).ToString() == Password)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public void addCompanyDetails(string companyname, string address1, string address2, string city, string phoneno, string mobno1, string mobno2, string antargat, string licenceNo, string pincode, string tahsil, string District, string State)
        {
            string str = "INSERT INTO CompanyMaster (CompanyName,Addressline1,Addressline2,city,phoneNo,MobNo,MobNo2,Antargat,LicenceNo,PinCode,Tahsil,District,State) VALUES  (N'" + companyname + "',N'" + address1 + "',N'" + address2 + "',N'" + city + "','" + phoneno + "','" + mobno1 + "','" + mobno2 + "',N'" + antargat + "','" + licenceNo + "','" + pincode + "',N'" + tahsil + "',N'" + District + "',N'" + State + "')";
            _objSQLHelper.ExecuteSql(str);
        }
        public void addLogin(string username, string paasword)
        {
            string str = "INSERT INTO LoginMaster (Log_Id,Password) VALUES ('" + username + "','" + paasword + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getcompanydetails()
        {
            string str = "SELECT * FROM  CompanyMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }
    }
}
