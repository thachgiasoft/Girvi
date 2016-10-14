using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BAL.Common;

namespace BAL.DataBaseForms
{
    public class Cls_SettingDatabase
    {
        SQLHelper _objSQLHelper = new SQLHelper();
        clsCommon _objCommon = new clsCommon();

        public void updateBillItemIds()
        {
            string str = "SELECT SrNo,MetalID, itemId FROM BillItemMaster";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string strupdate = "UPDATE  BillItemMaster SET MID='" + _objCommon.getMetalIdFromMarathiName(dt.Rows[i]["MetalID"].ToString()).ToString() + "' , SID='" + _objCommon.getSubMetalIdFromName(dt.Rows[i]["itemId"].ToString()).ToString() + "' WHERE (SrNo='" + dt.Rows[i]["SrNo"].ToString() + "')";
                _objSQLHelper.ExecuteSql(strupdate);
            }
        }

        public void updateFineStockItemIds()
        {
            string str = "SELECT Id,Metal_Type, ItemType FROM            FineStockItems";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string strupdate = "UPDATE FineStockItems SET MetalId='" + _objCommon.getMetalIdFromMarathiName(dt.Rows[i]["Metal_Type"].ToString()).ToString() + "' , ItemId='" + _objCommon.getSubMetalIdFromName(dt.Rows[i]["ItemType"].ToString()).ToString() + "' WHERE (Id='" + dt.Rows[i]["Id"].ToString() + "')";
                _objSQLHelper.ExecuteSql(strupdate);
            }

        }

        public void updateRefineryItemIds()
        {
            string str = "SELECT Refinery_ID,Metal_Type, Item_Type FROM            Refinery_Items";
            DataTable dt = _objSQLHelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string strupdate = "UPDATE Refinery_Items SET MID='" + _objCommon.getMetalIdFromMarathiName(dt.Rows[i]["Metal_Type"].ToString()).ToString() + "' , SID='" + _objCommon.getSubMetalIdFromName(dt.Rows[i]["Item_Type"].ToString()).ToString() + "' WHERE (Refinery_ID='" + dt.Rows[i]["Refinery_ID"].ToString() + "')";
                _objSQLHelper.ExecuteSql(strupdate);
            }
            string str1 = "SELECT RefineID,MetalType FROM RefinedMod";
            DataTable dt1 = _objSQLHelper.GetDataTable(str1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string strupdate = "UPDATE RefinedMod SET MID='" + _objCommon.getMetalIdFromMarathiName(dt1.Rows[i]["MetalType"].ToString()).ToString() + "'  WHERE (RefineID='" + dt1.Rows[i]["RefineID"].ToString() + "')";
                _objSQLHelper.ExecuteSql(strupdate);
            }
        }

        public DataTable getAllDatabaseTables(string DatabaseName)
        {
            string str = "SELECT TABLE_NAME FROM " + DatabaseName + ".INFORMATION_SCHEMA.Tables WHERE (TABLE_NAME !='AccountNature') AND (TABLE_NAME !='AccountLedger') AND (TABLE_NAME!='MetalMaster') AND (TABLE_NAME!='SubMetalMaster')  AND (TABLE_NAME!='setting_value') AND (TABLE_NAME!='tbl_CrystalReportPath') AND (TABLE_NAME!='LoginMaster') AND (TABLE_NAME!='CompanyMaster') AND (TABLE_NAME!='RegistrationMaster')  AND (TABLE_NAME!='Rates')";
            return _objSQLHelper.GetDataTable(str);

        }

        public void deleteAll(string TableName)
        {
            string str = "";
            if (TableName != "Girvi_no_table" && TableName != "khatawani")
            {
                str = "DELETE FROM " + TableName + "";
            }
            else
            {
                if (TableName == "khatawani")
                {
                    str = "DELETE FROM " + TableName + " WHERE kh_no!='0'";
                }
                else
                {
                    str = "DELETE FROM " + TableName + " WHERE Girvi_no!='0'";
                }
            }
            _objSQLHelper.ExecuteSql(str);
        }



        public void TrimInAll()
        {
            string strupdate1 = "update BillItemMaster set MetalID = LTRIM(RTRIM(MetalID)), itemId = LTRIM(RTRIM(itemId))";
            string strupdate2 = "update FineStockItems set Metal_Type = LTRIM(RTRIM(Metal_Type)), ItemType = LTRIM(RTRIM(ItemType))";
            string strupdate3 = "update MetalMaster set MetalHindi = LTRIM(RTRIM(MetalHindi)), MetalName = LTRIM(RTRIM(MetalName)),MetalMarathi = LTRIM(RTRIM(MetalMarathi))";
            string strupdate4 = "update SubMetalMaster set SubMetalName = LTRIM(RTRIM(SubMetalName)), SubMetalHindi = LTRIM(RTRIM(SubMetalHindi))";
            string strupdate5 = "update ItemMaster set Metaltype = LTRIM(RTRIM(Metaltype)), itemtype = LTRIM(RTRIM(itemtype))";

            try
            {
                _objSQLHelper.ExecuteSql(strupdate1);
            }
            catch { }
            try
            {
                _objSQLHelper.ExecuteSql(strupdate2);
            }
            catch { }
            try
            {
                _objSQLHelper.ExecuteSql(strupdate3);
            }
            catch { }
            try
            {
                _objSQLHelper.ExecuteSql(strupdate4);
            }
            catch { }
            try
            {
                _objSQLHelper.ExecuteSql(strupdate5);
            }
            catch { }
        }

        public string updateMetalName()
        {
            string exceptionMsg = "";
            string strupdate6 = "update BillItemMaster set MetalID=N'" + _objCommon.getMetalNameMarathi("1") + "' WHERE (MID='1')";
            try
            {
                _objSQLHelper.ExecuteSql(strupdate6);
            }
            catch (Exception ex) { exceptionMsg = exceptionMsg + ex.Message + " ,"; }

            string strupdate7 = "update FineStockItems set Metal_Type= N'" + _objCommon.getMetalNameMarathi("1") + "'  WHERE (MetalId='1')";
            try
            {
                _objSQLHelper.ExecuteSql(strupdate7);
            }
            catch (Exception ex) { exceptionMsg = exceptionMsg + ex.Message + " ,"; }

            string strupdate12 = "update Refinery_Items  set  Metal_Type =N'" + _objCommon.getMetalNameMarathi("1") + "'  WHERE (MID='1')";
            try
            {
                _objSQLHelper.ExecuteSql(strupdate12);
            }
            catch (Exception ex) { exceptionMsg = exceptionMsg + ex.Message + " ,"; }

            string strupdatemod12 = "update RefinedMod  set  MetalType =N'" + _objCommon.getMetalNameMarathi("1") + "'  WHERE (MID='1')";
            try
            {
                _objSQLHelper.ExecuteSql(strupdatemod12);
            }
            catch (Exception ex) { exceptionMsg = exceptionMsg + ex.Message + " ,"; }

            string strupdate5 = "update ItemMaster set MetalType=N'" + _objCommon.getMetalNameMarathi("1") + "' WHERE (MetalId='1') ";
            try
            {
                _objSQLHelper.ExecuteSql(strupdate5);
            }
            catch (Exception ex) { exceptionMsg = exceptionMsg + ex.Message + " ,"; }

            string strupdate10 = "update OrderItemMaster set  MetalID = N'" + _objCommon.getMetalNameMarathi("1") + "'  WHERE (MID='1')";
            try
            {
                _objSQLHelper.ExecuteSql(strupdate10);
            }
            catch (Exception ex) { exceptionMsg = exceptionMsg + ex.Message + " ,"; }

            string strupdate9 = "update Mod_Entries set Metal_Type= N'" + _objCommon.getMetalNameMarathi("1") + "' WHERE (MID='1')";
            try
            {
                _objSQLHelper.ExecuteSql(strupdate9);
            }
            catch (Exception ex) { exceptionMsg = exceptionMsg + ex.Message + " ,"; }
            if (exceptionMsg == "")
            {
                return "Done";
            }
            else
            {
                return exceptionMsg;
            }

        }

        public void deleteVyapariMasterByAccNo(string AccNo)
        {
            string str = "UPDATE vypariMaster SET PermanantDelete='" + true + "' WHERE        (AccNo = '" + AccNo + "') ";
            _objSQLHelper.ExecuteSql(str);

        }

        public DataTable getAllVyapariBillByAccNo(string AccNo)
        {
            string str = "SELECT        BillNo  FROM            vyapariBillMaster WHERE        (AccNo = '" + AccNo + "') AND (PermanantDelete='" + false + "')";
            return _objSQLHelper.GetDataTable(str);
        }

        public void deleteAllVyapariBillItemsByBillNo(string BillNo)
        {
            string str = "UPDATE BillItemMaster SET PermanantDelete='" + true + "' WHERE        (BillNO = '" + BillNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAllVyapariBillMasterByAccNo(string AccNo)
        {
            string str = " UPDATE vyapariBillMaster SET PermanantDelete='" + true + "' WHERE        (AccNo = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAllVyapariPayMasterByAccNo(string AccNo)
        {
            string str = "UPDATE vyapriPayMaster SET PermanantDelete='" + true + "' WHERE        (AccNo = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAllVyapariRateCutMasterByAccNo(string AccNo)
        {
            string str = " UPDATE vyparirRateCutMaster SET PermanantDelete='" + true + "' WHERE        (Accno = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        ///customer
        ///

        public void deleteCustomerMasterByAccNo(string AccNo)
        {
            string str = "UPDATE SalesBMaster SET PermanantDelete='" + true + "' WHERE        (AccNo = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);

        }
        public DataTable getAllCustomerBillByAccNo(string AccNo)
        {
            string str = "SELECT        BillNo  FROM            SalesBBillMaster WHERE        (AccNo = '" + AccNo + "') AND (PermanantDelete='" + false + "')";
            return _objSQLHelper.GetDataTable(str);
        }

        public void deleteAllCustomerBillItemsByBillNo(string BillNo)
        {
            string str = "UPDATE BillItemMaster SET PermanantDelete='" + true + "' WHERE        (BillNO = '" + BillNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAllCustomerBillMasterByAccNo(string AccNo)
        {
            string str = " UPDATE SalesBBillMaster SET PermanantDelete='" + true + "' WHERE        (AccNo = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAllCustomerPayMasterByAccNo(string AccNo)
        {
            string str = "UPDATE SalesBPayMaster SET PermanantDelete='" + true + "' WHERE (AccNo = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAllCustomerRateCutMasterByAccNo(string AccNo)
        {
            string str = " UPDATE SalesBRateCutMaster SET PermanantDelete='" + true + "' WHERE        (Accno = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }


        ///Supplier
        ///

        public void deleteSuppplierMasterByAccNo(string AccNo)
        {
            string str = "UPDATE SalesBMaster SET PermanantDelete='" + true + "' WHERE        (AccNo = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);

        }
        public DataTable getAllSuppplierBillByAccNo(string AccNo)
        {
            string str = "SELECT  BillNo  FROM  SalesBBillMaster WHERE        (AccNo = '" + AccNo + "') AND (PermanantDelete='" + false + "')";
            return _objSQLHelper.GetDataTable(str);
        }

        public void deleteAllSuppplierBillItemsByBillNo(string BillNo)
        {
            string str = "UPDATE BillItemMaster SET PermanantDelete='" + true + "' WHERE        (BillNO = '" + BillNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAllSuppplierBillMasterByAccNo(string AccNo)
        {
            string str = " UPDATE SalesBBillMaster SET PermanantDelete='" + true + "' WHERE        (AccNo = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAllSuppplierPayMasterByAccNo(string AccNo)
        {
            string str = "UPDATE SalesBPayMaster SET PermanantDelete='" + true + "' WHERE (AccNo = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void deleteAllSuppplierRateCutMasterByAccNo(string AccNo)
        {
            string str = " UPDATE SalesBRateCutMaster SET PermanantDelete='" + true + "' WHERE        (Accno = '" + AccNo + "')";
            _objSQLHelper.ExecuteSql(str);
        }

        public void addColumns()
        {

            string str = "Alter Table BillItemMaster add [PermanantDelete] [bit] NOT NULL CONSTRAINT [DF_SalesBBillMaster_PermanantDelete]  DEFAULT ((0))";
            _objSQLHelper.ExecuteSql(str);
              
        }

        public void UpdateTableColumns(string tablename, string columname, string datatype)
        {
            string str = "Alter Table " + tablename + " ADD " + columname + " " + datatype + " ";
            _objSQLHelper.ExecuteSql(str); 
        }


        public void UpdateTableColumns(string tablename, string columname, string datatype,string nullvalue, string defaultvalue )
        {
            string str = "Alter Table " + tablename + " ADD " + columname + " " + datatype + " " + nullvalue + " CONSTRAINT [DF_" + tablename + "_" + columname + "]  DEFAULT " + defaultvalue + " ";
            _objSQLHelper.ExecuteSql(str);
        }
    }
}
 