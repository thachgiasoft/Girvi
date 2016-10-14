using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BAL.Common
{
    public class ClsFinancialYear
    {
        SQLHelper _objSqlhelper = new SQLHelper();

        public void addFinancialYear(string start, string end)
        {
            string str = "INSERT INTO FinancialYearMaster(startyear,endyear) Values('"+start+"','"+end+"')";
            int x = _objSqlhelper.ExecuteSql(str);
        }

        public int getSelectedFinancialYearId()
        {
            int id = 1;
            string str = "SELECT * From FinancialYearMaster WHERE (isSelected='"+true+"')";
            DataTable dt= _objSqlhelper.GetDataTable(str);
            if (dt.Rows.Count > 0)
            {
                id = Convert.ToInt32(dt.Rows[0]["id"].ToString());
            }
            return id;
        }

        public DataTable getFinancialYear()
        {
            string str = "SELECT * From FinancialYearMaster";
            return _objSqlhelper.GetDataTable(str);
        }
        public DataTable   getSelectedFinancialYear()
        {
            string str = "SELECT * From FinancialYearMaster WHERE (isSelected='" + true + "')";
            return _objSqlhelper.GetDataTable(str);
        }

        public void updateSelectedFinancialYear(string id)
        {
            DataTable dt = getFinancialYear();
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                string strUpdateAll = "UPDATE FinancialYearMaster SET isSelected='" + false + "' WHERE (id='" + dt.Rows[i]["id"].ToString() + "')";
                _objSqlhelper.ExecuteSql(strUpdateAll);
            }

            string str = "UPDATE FinancialYearMaster SET isSelected='"+true+"' WHERE (id='"+id+"')";
             _objSqlhelper.ExecuteSql(str);
        }

        public void updateFinancialYear(string Id,string startyear,string endyear)
        {
            string str = "UPDATE FinancialYearMaster SET startyear='" + startyear + "', endyear='" + endyear + "' WHERE (id='" + Id + "')";
            _objSqlhelper.ExecuteSql(str);
        }
        public void DeleteFinancialYear(string ID)
        {
            string str1 = "DELETE FROM FinancialYearMaster WHERE (id = '" + ID + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str1);
        }

       

    }
}
