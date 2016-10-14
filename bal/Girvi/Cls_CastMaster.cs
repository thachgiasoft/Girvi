using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Girvi
{
    public class Cls_CastMaster
    {
        SQLHelper _objSQLHelper = new SQLHelper();
        public void addCaste(string Caste)
        {
            string str = "INSERT INTO CasteMaster (Caste) VALUES (N'" + Caste + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void updateCaste(string Caste,string id)
        {
            string str = "UPDATE CasteMaster SET Caste='"+Caste+"' WHERE (Id='" + id + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteCaste(string id)
        {
            string str = "DELETE FROM CasteMaster  WHERE (Id='" + id + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getAllCaste()
        {
            string str = "SELECT * FROM CasteMaster";
            return  _objSQLHelper.GetDataTable(str);
        }
    }
}
