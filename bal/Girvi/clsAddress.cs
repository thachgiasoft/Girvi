using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Girvi
{
    public class clsAddress
    {
        SQLHelper _objSQLHelper = new SQLHelper();
        public void addAddress(string address)
        {
            string str = "INSERT INTO AddressMaster (Address) VALUES        (N'" + address + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public DataTable getAddress()
        {
            string str = "SELECT DISTINCT  Address FROM  AddressMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            return dt;
        }

        public void updateAddress(string Address, string SrNo)
        {
            string str1 = "UPDATE AddressMaster SET Address = N'" + Address + "' WHERE (srno = '" + SrNo + "')";

            _objSQLHelper.ExecuteSql(str1);
        }
    }
}
