using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Girvi
{
   public class clsTahsil
    {
        SQLHelper _objSQLHelper = new SQLHelper();

        public void addTahsil(string tahsil)
        {
            string str = "INSERT INTO TahsilMaster (Tahsil) VALUES        (N'" + tahsil + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getTahsil()
        {
            string str = "SELECT  Tahsil FROM  TahsilMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public void updateTahsil(string Tahsil, string SrNo)
        {
            string str1 = "UPDATE TahsilMaster SET Tahsil = N'" + Tahsil + "' WHERE (srno = '" + SrNo + "')";

            _objSQLHelper.ExecuteSql(str1);
        }


        public void deleteTahsil( string SrNo)
        {
            
            string str1 = "DELETE FROM TahsilMaster  WHERE (srno = '" + SrNo + "')";

            _objSQLHelper.ExecuteSql(str1);
        }
    }
}
