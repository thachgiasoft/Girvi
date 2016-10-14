using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Girvi
{
   public class cls_Login
    {
       
        SQLHelper _objSQLHelper = new SQLHelper();
      


        public bool login(string p, string p_2)
        {
            
            string cmd = "SELECT Log_Id,Password FROM LoginMaster WHERE(Log_Id = '" + p + "') AND (Password = '" + p_2 + "')";
            DataTable x = _objSQLHelper.GetDataTable(cmd);
            try
            {
                if ((x.Rows[0][0]).ToString() == p && (x.Rows[0][1]).ToString() == p_2)
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

        public void changepwd(string p, string p_2)
        {

            string str = "UPDATE LoginMaster SET  Password ='" + p + "' where Password='" + p_2 + "'";
            DataTable dt = _objSQLHelper.GetDataTable(str);

        }

        public bool loginsss(string p)
        {
            // throw new NotImplementedException();
            string cmd = "SELECT Password FROM LoginMaster WHERE (Password = '" + p + "')";
            DataTable x = _objSQLHelper.GetDataTable(cmd);
            try
            {
                if ((x.Rows[0][0]).ToString() == p)
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
    }
}
