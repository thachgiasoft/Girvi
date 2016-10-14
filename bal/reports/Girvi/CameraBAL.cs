using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;


namespace BAL.Reports.Girvi
{
    
    public class CameraBAL
    {
        SQLHelper _objSQLHelper = new SQLHelper();


        public DataTable getkhatavaniphotos(string p)
        {
            string querry = "SELECT photo, doc1, doc2, doc3 FROM Customer_Master WHERE(khatawani_No = '"+p+"')";
            DataTable dt = _objSQLHelper.GetDataTable(querry);
            return dt;
        }

        public DataTable retrunfirstname()
        {
          
            string querry = "SELECT FullName FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(querry);
            return dt;
        }

        public DataTable retrunKhatawani()
        {
         

             string querry = "SELECT khatawani_No FROM  Customer_Master";
            DataTable dt = _objSQLHelper.GetDataTable(querry);
            return dt;
        }

        public string getkhatawanino_fromName(string p)
        {
            string querry = "SELECT khatawani_No FROM  Customer_Master WHERE (FullName = N'" + p + "')";
            DataTable dt = _objSQLHelper.GetDataTable(querry);
            return dt.Rows[0]["khatawani_No"].ToString();
        }

        public string getname(string p)
        {
            string querry = "SELECT FullName FROM  Customer_Master WHERE (khatawani_No = N'" + p + "')";
            DataTable dt = _objSQLHelper.GetDataTable(querry);
            return dt.Rows[0]["khatawani_No"].ToString();
        }

        public void getphotos(string p)
        {
            string querry = "SELECT photo, doc1, doc2, doc3 FROM Customer_Master WHERE(khatawani_No = '" + p + "')";
            DataTable dt = _objSQLHelper.GetDataTable(querry);
           //SqlCommand cmd = new SqlCommand("SELECT photo, doc1, doc2, doc3 FROM Customer_Master WHERE(khatawani_No = '" + p + "')");
           // DataTable dt = _objSQLHelper.reader(cmd);
            //return dt;
            //throw new NotImplementedException();
        }
    }
}
