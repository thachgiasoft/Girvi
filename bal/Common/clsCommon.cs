using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BAL.Common
{
    public class clsCommon
    {
        SQLHelper _objSqlhelper = new SQLHelper();



        public string getprintcounttheva()
        {
            string str = "SELECT  Print_count_theva  FROM  setting_value";
            return _objSqlhelper.ExecuteScalar(str);
        }
        public string getprintcountsodwa()
        {
            string str = "SELECT  Print_count_sodva  FROM  setting_value";
            return _objSqlhelper.ExecuteScalar(str);
        }

        public DataTable getmetaltype()
        {
            string str = "SELECT  MetalId, MetalName FROM  MetalMaster";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable getsubmetaltype()
        {
            string str = "SELECT SubMetalId, MetalId, SubMetalName FROM SubMetalMaster ";
            DataTable dt1 = _objSqlhelper.GetDataTable(str);
            return dt1;
        }

        public string getMetalNameHindi(string MetalId)
        {
            string str = "SELECT  MetalHindi FROM    MetalMaster WHERE   (MetalId = '" + MetalId + "')";

            return Convert.ToString(_objSqlhelper.ExecuteScalar(str));

        }

        public object getSubMetalHindi(string SubMetalId)
        {
            string str = "SELECT    SubMetalHindi  FROM    SubMetalMaster WHERE  (SubMetalId = '" + SubMetalId + "')";
            return Convert.ToString(_objSqlhelper.ExecuteScalar(str));
        }

        public DataTable getRates()
        {
            string str = "SELECT SrNo, Gold, Silver,interest FROM  Rates";
            DataTable dt1 = _objSqlhelper.GetDataTable(str);
            return dt1;
        }

        public DataTable getBarCodeItemDetails(string itemcode)
        {
            string str = "SELECT ItemCode, Metaltype, itemtype, specify, wt, reducewt, finalwt, finalwtinpercent, currentprice, finewt, fineamount, makingcharges, quantity, netprice, comment, Date, CheckTrue, MetalId, SubMetalType, FromWhere, Barcode FROM ItemMaster WHERE (ItemCode = '" + itemcode + "') AND (Barcode = 'false')";
            return _objSqlhelper.GetDataTable(str);
        }

        public string getGold()
        {
            decimal stockgold = 0;
            decimal goldGiven = 0;

            string gold_wt = "SELECT  finalwt   FROM  ItemMaster WHERE LTRIM(RTRIM(Metaltype))=N'सोना' and (status='PurchaseBill')";
            string Gold_given = "SELECT FinalWt, MetalID, CustmerType FROM BillItemMaster WHERE (LTRIM(RTRIM(MetalID)) = N'सोना') AND ((CustmerType = 'Customer') OR (CustmerType = 'Vyapari'))";// AND ( (LTRIM(RTRIM(Item_id)) != N'बार') OR (LTRIM(RTRIM(Item_id)) != N'कॅडबरी') OR  (LTRIM(RTRIM(Item_id)) != N'रवा') OR (LTRIM(RTRIM(Item_id)) != N'बिस्किट्स')  OR (LTRIM(RTRIM(Item_id)) != N'चौसा') OR (LTRIM(RTRIM(Item_id)) != N'पेटी')) )";

            DataTable dt = _objSqlhelper.GetDataTable(gold_wt);
            DataTable dt1 = _objSqlhelper.GetDataTable(Gold_given);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                stockgold = stockgold + Convert.ToDecimal(dt.Rows[i]["finalwt"]);
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {

                goldGiven = goldGiven + Convert.ToDecimal(dt1.Rows[i]["FinalWt"]);

            }

            decimal bgold = (stockgold - goldGiven);
            return Convert.ToString(bgold);
        }

        public string getSilver()
        {
            decimal stockgold = 0;
            decimal goldGiven = 0;

            string gold_wt = "SELECT  finalwt   FROM  ItemMaster WHERE LTRIM(RTRIM(Metaltype))=N'चांदी' and (barcodecheck='false')";
            string Gold_given = "SELECT FinalWt, MetalID, CustmerType FROM BillItemMaster WHERE (LTRIM(RTRIM(MetalID)) = N'चांदी') AND ((CustmerType = 'Customer') OR (CustmerType = 'Vyapari'))";// AND ( (LTRIM(RTRIM(Item_id)) != N'बार') OR (LTRIM(RTRIM(Item_id)) != N'कॅडबरी') OR  (LTRIM(RTRIM(Item_id)) != N'रवा') OR (LTRIM(RTRIM(Item_id)) != N'बिस्किट्स')  OR (LTRIM(RTRIM(Item_id)) != N'चौसा') OR (LTRIM(RTRIM(Item_id)) != N'पेटी')) )";
            DataTable dt = _objSqlhelper.GetDataTable(gold_wt);
            DataTable dt1 = _objSqlhelper.GetDataTable(Gold_given);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                stockgold = stockgold + Convert.ToDecimal(dt.Rows[i]["finalwt"]);
            }
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                goldGiven = goldGiven + Convert.ToDecimal(dt1.Rows[i]["FinalWt"]);
            }
            decimal bgold = (stockgold - goldGiven);
            return Convert.ToString(bgold);
        }

        public string getFineGold()
        {
            decimal stockgold = 0;
            decimal goldGiven = 0;

            decimal vyaparipay = 0;
            decimal supplierpay = 0;


            string gold_wt = "SELECT  Wt   FROM FineStockItems  WHERE LTRIM(RTRIM(Metal_Type))=N'सोना'";
            string Gold_given = "SELECT FineWt, MetalID, CustmerType FROM BillItemMaster WHERE (LTRIM(RTRIM(MetalID)) = N'सोना') AND ((CustmerType = 'CustomerFine') OR (CustmerType = 'VyapariFine'))";// AND ( (LTRIM(RTRIM(Item_id)) != N'बार') OR (LTRIM(RTRIM(Item_id)) != N'कॅडबरी') OR  (LTRIM(RTRIM(Item_id)) != N'रवा') OR (LTRIM(RTRIM(Item_id)) != N'बिस्किट्स')  OR (LTRIM(RTRIM(Item_id)) != N'चौसा') OR (LTRIM(RTRIM(Item_id)) != N'पेटी')) )";

            string payVyapari = "SELECT GoldGiven FROM vyapriPayMaster";
            string paySupplier = "SELECT        Gold, Silver FROM            SupplierPayMaster";


            DataTable dt = _objSqlhelper.GetDataTable(gold_wt);
            DataTable dt1 = _objSqlhelper.GetDataTable(Gold_given);
            DataTable dt2 = _objSqlhelper.GetDataTable(payVyapari);
            DataTable dt4 = _objSqlhelper.GetDataTable(paySupplier);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Wt"].ToString() != "")
                    stockgold = stockgold + Convert.ToDecimal(dt.Rows[i]["Wt"]);
            }
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (dt1.Rows[i]["FineWt"].ToString() != "")

                    goldGiven = goldGiven + Convert.ToDecimal(dt1.Rows[i]["FineWt"]);
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i]["GoldGiven"].ToString() != "")
                {

                    vyaparipay = vyaparipay + Convert.ToDecimal(dt2.Rows[i]["GoldGiven"]);

                }

            }
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                if (dt4.Rows[i]["Gold"].ToString() != "")
                {
                    supplierpay = supplierpay + Convert.ToDecimal(dt4.Rows[i]["Gold"]);
                }
            }
            decimal bgold = (stockgold - goldGiven + vyaparipay - supplierpay);
            return Convert.ToString(bgold);
        }

        public string getFineSilver()
        {
            decimal stockgold = 0;
            decimal goldGiven = 0;
            decimal vyaparipay = 0;
            decimal supplierpay = 0;

            string gold_wt = "SELECT  Wt   FROM  FineStockItems WHERE LTRIM(RTRIM(Metal_Type))=N'चांदी'";
            string Gold_given = "SELECT FineWt, MetalID, CustmerType FROM BillItemMaster WHERE (LTRIM(RTRIM(MetalID)) = N'चांदी') AND ((CustmerType = 'CustomerFine') OR (CustmerType = 'VyapariFine'))";// AND ( (LTRIM(RTRIM(Item_id)) != N'बार') OR (LTRIM(RTRIM(Item_id)) != N'कॅडबरी') OR  (LTRIM(RTRIM(Item_id)) != N'रवा') OR (LTRIM(RTRIM(Item_id)) != N'बिस्किट्स')  OR (LTRIM(RTRIM(Item_id)) != N'चौसा') OR (LTRIM(RTRIM(Item_id)) != N'पेटी')) )";
            string payVyapari = "SELECT SilverGiven FROM vyapriPayMaster";
            string paySupplier = "SELECT        Gold, Silver FROM            SupplierPayMaster";



            DataTable dt = _objSqlhelper.GetDataTable(gold_wt);
            DataTable dt1 = _objSqlhelper.GetDataTable(Gold_given);
            DataTable dt2 = _objSqlhelper.GetDataTable(payVyapari);
            DataTable dt4 = _objSqlhelper.GetDataTable(paySupplier);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                stockgold = stockgold + Convert.ToDecimal(dt.Rows[i]["Wt"]);
            }
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                goldGiven = goldGiven + Convert.ToDecimal(dt1.Rows[i]["FineWt"]);
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                vyaparipay = vyaparipay + Convert.ToDecimal(dt2.Rows[i]["SilverGiven"]);

            }
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                supplierpay = supplierpay + Convert.ToDecimal(dt4.Rows[i]["Silver"]);
            }

            decimal bgold = (stockgold - goldGiven - supplierpay + vyaparipay);
            return Convert.ToString(bgold);
        }

        public string getModGold()
        {
            decimal ModGold = 0;

            string strGold = "SELECT        Final_WT, Status FROM            Mod_Entries WHERE  MID='1' and      (Status = N'MOD')";
            DataTable dt = _objSqlhelper.GetDataTable(strGold);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ModGold = ModGold + Convert.ToDecimal(dt.Rows[i]["Final_WT"]);

            }
            return ModGold.ToString();
        }

        public string getModSilver()
        {
            decimal ModSilver = 0;

            string strSilver = "SELECT        Final_WT, Status FROM  Mod_Entries WHERE  MID='2' and      (Status = N'MOD')";
            DataTable dt1 = _objSqlhelper.GetDataTable(strSilver);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                ModSilver = ModSilver + Convert.ToDecimal(dt1.Rows[i]["Final_WT"]);
            }
            return ModSilver.ToString();
        }

        public DataTable CalculationForItemInfoGroup(string wt, string reducewt, string finalwtper, string currentprice, string makingprgm, string making_Charges)
        {

            if (wt == "")
            {
                wt = "0";
            }
            if (reducewt == "")
            {
                reducewt = "0";
            }
            if (finalwtper == "")
            {
                finalwtper = "0";
            }
            if (currentprice == "")
            {
                currentprice = "0";
            }
            if (makingprgm == "")
            {
                makingprgm = "0";
            }

            double final_wt = 0, fine_wt = 0, total_fine_amt = 0, making_charges = 0, net_price = 0;

            if ((makingprgm == "" || makingprgm == "0") && (making_Charges != ""))
            {
                making_charges = 0 + Convert.ToDouble(making_Charges);
            }
            else
            {
                making_charges = Convert.ToDouble(wt) * Convert.ToDouble(makingprgm);

            }

            final_wt = Convert.ToDouble(wt) - Convert.ToDouble(reducewt);
            fine_wt = (final_wt * Convert.ToDouble(finalwtper)) / 100;
            total_fine_amt = Convert.ToDouble(currentprice) * fine_wt;
            net_price = making_charges + total_fine_amt;

            DataTable dt = new DataTable();
            dt.Columns.Add("FinalWt");
            dt.Columns.Add("FineWt");
            dt.Columns.Add("TotalFineAmount");
            dt.Columns.Add("MakingCharges");
            dt.Columns.Add("NetPrice");

            dt.Rows.Add(final_wt, fine_wt, total_fine_amt, making_charges, net_price);
            return dt;


        }


        public string get_mod_number()
        {
            string accno = _objSqlhelper.gmGetMstID("M", "0");
            return accno;
        }

        public void addModDetails(string MetalType, string ItemType, string Weight, string ReduceWeight, string FinalWeight, string FineWeight, string FinalWeightInPercentage, string CurrentPrice, string TotalAmount, string date, string time, string status, string Form_Identity, string IDs, string Acc_No, string mod_no, string Mid, string sid, string making, string quan, string finalamt)
        {
            string str = "INSERT INTO Mod_Entries(Metal_Type,Item_Type,W_T,Reduce_W_T,Final_WT,Fine_Weight,Final_Weight_In_Percentage,Current_Price,Total_Amount,Date,Time,Status,Form_Identity,IDs,Acc_No,Mod_ID,MID,SID,Making_Charges,Quantity,Final_Amount) VALUES(N'" + MetalType + "',N'" + ItemType + "','" + Weight + "','" + ReduceWeight + "','" + FinalWeight + "','" + FineWeight + "','" + FinalWeightInPercentage + "','" + CurrentPrice + "','" + TotalAmount + "','" + date + "','" + time + "','" + status + "','" + Form_Identity + "','" + IDs + "','" + Acc_No + "','" + mod_no + "','" + Mid + "','" + sid + "','" + making + "','" + quan + "','" + finalamt + "')";
            int x = _objSqlhelper.ExecuteSql(str);
        }



        public DataTable getItems()
        {
            string str = "SELECT Distinct itemId FROM BillItemMaster Where CustmerType='Supplier'";
            return _objSqlhelper.GetDataTable(str);

        }

        public string getItemWt(string metal, string item)
        {
            int qty = 0;
            string str = "SELECT InitialWt FROM BillItemMaster WHERE (MetalID=N'" + metal + "') AND (itemId=N'" + item + "') AND (CustmerType='Supplier')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                qty += Convert.ToInt32(dt.Rows[i]["InitialWt"].ToString());
            }
            return qty.ToString();
        }

        public DataTable getItemsInDetail(string metal, string item)
        {
            string str = "SELECT  MetalID, itemId, InitialWt, ReduceWt, FinalWt, FinalWtInPercent, FineWT, CurrentPrice, TotalFineAmount, MakingCharges, Quantity, NetPrice FROM BillItemMaster Where (MetalID=N'" + metal + "') AND (itemId=N'" + item + "') AND (CustmerType='Supplier')";
            return _objSqlhelper.GetDataTable(str);
        }



        public string getItemGoldWt(string itemName)
        {
            int qty = 0;
            string str = "SELECT InitialWt FROM BillItemMaster WHERE (MetalID=N'सोना') AND (itemId=N'" + itemName + "') AND (CustmerType='Supplier')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                qty += Convert.ToInt32(dt.Rows[i]["InitialWt"].ToString());
            }
            return qty.ToString();
        }

        public string getItemSilverWt(string itemName)
        {
            int qty = 0;
            string str = "SELECT InitialWt FROM BillItemMaster WHERE (MetalID=N'चांदी') AND (itemId=N'" + itemName + "') AND (CustmerType='Supplier')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                qty += Convert.ToInt32(dt.Rows[i]["InitialWt"].ToString());
            }
            return qty.ToString();
        }

        public DataTable getItemInfoFromItemNo(string ItemCode)
        {
            string str = "SELECT  ItemCode, Barcode, Metaltype, itemtype, specify, wt, reducewt, finalwt, finalwtinpercent, finewt, currentprice, fineamount, makingcharges, quantity, netprice,  comment, Date, CheckTrue,MetalID,SubMetalType FROM            ItemMaster WHERE        (ItemCode = '" + ItemCode + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt;
        }







        public DataTable CalculationForItemInfoGroupGirvi(string GrossWt, string ReduceWt, string FinalWtPercent, string CurrentPrice, string makingprgm, string making_Charges)
        {

            if (GrossWt == "")
            {
                GrossWt = "0";
            }
            if (ReduceWt == "")
            {
                ReduceWt = "0";
            }
            if (FinalWtPercent == "")
            {
                FinalWtPercent = "0";
            }
            if (CurrentPrice == "")
            {
                CurrentPrice = "0";
            }
            if (makingprgm == "")
            {
                makingprgm = "0";
            }

            double final_wt = 0, fine_wt = 0, total_fine_amt = 0, making_charges = 0, net_price = 0;

            if ((makingprgm == "" || makingprgm == "0") && (making_Charges != ""))
            {
                making_charges = 0 + Convert.ToDouble(making_Charges);
            }
            else
            {
                making_charges = Convert.ToDouble(GrossWt) * Convert.ToDouble(makingprgm);

            }

            final_wt = Convert.ToDouble(GrossWt) - Convert.ToDouble(ReduceWt);
            fine_wt = (final_wt * Convert.ToDouble(FinalWtPercent)) / 100;
            total_fine_amt = Convert.ToDouble(CurrentPrice) * fine_wt;
            net_price = making_charges + total_fine_amt;

            DataTable dt = new DataTable();
            dt.Columns.Add("FinalWt");
            dt.Columns.Add("FineWt");
            dt.Columns.Add("TotalFineAmount");
            dt.Columns.Add("MakingCharges");
            dt.Columns.Add("NetPrice");

            dt.Rows.Add(final_wt, fine_wt, total_fine_amt, making_charges, net_price);
            return dt;


        }
        public double sumGridViewColumn(DataGridView dtGrid, string columnName)
        {
            int columnIndex = 0;
            double sum = 0;

            for (int i = 0; i < dtGrid.Columns.Count; i++)
            {
                if (dtGrid.Columns[i].Name == columnName)
                    columnIndex = i;
            }
            if (columnIndex != 0)
            {
                for (int i = 0; i < dtGrid.Rows.Count; i++)
                {
                    try
                    {
                        sum += Convert.ToDouble(dtGrid.Rows[i].Cells[columnIndex].Value.ToString());
                    }
                    catch
                    {
                    }
                }
            }
            return sum;
        }

        public double sumDataTableColumn(DataTable dtGrid, string columnName)
        {
            int columnIndex = 0;
            double sum = 0;

            for (int i = 0; i < dtGrid.Columns.Count; i++)
            {
                if (dtGrid.Columns[i].ColumnName == columnName)
                    columnIndex = i;
            }
            if (columnIndex != 0)
            {
                for (int i = 0; i < dtGrid.Rows.Count; i++)
                {
                    try
                    {
                        sum += Convert.ToDouble(dtGrid.Rows[i][columnIndex].ToString());
                    }
                    catch
                    {
                    }
                }
            }

            return sum;
        }



        public DataTable DataGridView2DataTable(DataGridView dgv, String tblName, int minRow = 0)
        {

            DataTable dt = new DataTable(tblName);

            // Header columns
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                DataColumn dc = new DataColumn(column.Name.ToString());
                dt.Columns.Add(dc);
            }

            // Data cells
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                }
                dt.Rows.Add(dr);
            }

            // Related to the bug arround min size when using ExcelLibrary for export
            for (int i = dgv.Rows.Count; i < minRow; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dr[j] = "  ";
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }


        public DataTable DataGridView2DataTableSelected(DataGridView dgv, String tblName, int minRow = 0)
        {

            DataTable dt = new DataTable(tblName);

            // Header columns
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                DataColumn dc = new DataColumn(column.Name.ToString());
                dt.Columns.Add(dc);
            }

            // Data cells
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                }
                if (Convert.ToBoolean(dgv.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    dt.Rows.Add(dr);
                }
            }

            // Related to the bug arround min size when using ExcelLibrary for export
            for (int i = dgv.Rows.Count; i < minRow; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dr[j] = "  ";
                }
                if (Convert.ToBoolean(dgv.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    dt.Rows.Add(dr);
                }
            }
            return dt;

        }

        public DataTable mergeTwoDataGrid(DataTable FirstDatatable, DataTable SecondDatatable)
        {
            DataTable dtmerge = new DataTable();
            int max, min;
            string datagrid;
            if (FirstDatatable.Rows.Count > SecondDatatable.Rows.Count)
            {
                max = FirstDatatable.Rows.Count;
                min = SecondDatatable.Rows.Count;
                datagrid = "data";

            }
            else
            {
                max = SecondDatatable.Rows.Count;
                min = FirstDatatable.Rows.Count;
                datagrid = "data1";
            }

            int grid1columnCount = FirstDatatable.Columns.Count;
            int grid2columnCount = SecondDatatable.Columns.Count;

            for (int i = 0; i < grid1columnCount; i++)
            {
                dtmerge.Columns.Add(FirstDatatable.Columns[i].ColumnName);
            }
            for (int i = 0; i < grid2columnCount; i++)
            {
                dtmerge.Columns.Add(SecondDatatable.Columns[i].ColumnName);
            }

            int columnMergeCount = dtmerge.Columns.Count;

            for (int i = 0; i < min; i++)
            {
                dtmerge.Rows.Add();
                int j;
                for (j = 0; j < grid1columnCount; j++)
                {
                    dtmerge.Rows[i][j] = FirstDatatable.Rows[i][j].ToString();
                }
                int l=0;
                for (int k = j; k < grid2columnCount+j; k++)
                {
                    dtmerge.Rows[i][k] = SecondDatatable.Rows[i][l].ToString();
                    l++;
                }
              
            }
            //if (min != 0)
            //{
                for (int i = min; i < max; i++)
                {
                    if (datagrid == "data")
                    {
                        dtmerge.Rows.Add();
                        int j;
                        for (j = 0; j < grid1columnCount; j++)
                        {
                            dtmerge.Rows[i][j] = FirstDatatable.Rows[i][j].ToString();
                        }
                        for (int k = j; k < grid2columnCount + j; k++)
                        {
                            dtmerge.Rows[i][k] = "";
                        }
                    }
                    if (datagrid == "data1")
                    {
                        dtmerge.Rows.Add();
                        int j;
                        for (j = 0; j < grid1columnCount; j++)
                        {
                            dtmerge.Rows[i][j] = "";
                        }
                        int l = 0;
                        for (int k = j; k < grid2columnCount + j; k++)
                        {
                            dtmerge.Rows[i][k] = SecondDatatable.Rows[i][l].ToString();
                            l++;
                        }
                    }
                }
            //}

            return dtmerge;
        }


        public string getMetalIdFromMarathiName(string MetalMarathi)
        {
            string str = "SELECT MetalId FROM MetalMaster WHERE (MetalMarathi = N'" + MetalMarathi + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt.Rows[0]["MetalId"].ToString();

        }

        public string getMetalNameMarathi(string MetalId)
        {
            string str = "SELECT  MetalMarathi FROM    MetalMaster WHERE   (MetalId = '" + MetalId + "')";

            string str1 = Convert.ToString(_objSqlhelper.ExecuteScalar(str));
            return str1;

        }

        public string getSubMetalIdFromName(string SubMetalHindi)
        {
            string str = "SELECT SubMetalId FROM SubMetalMaster WHERE (SubMetalHindi = N'" + SubMetalHindi + "')";
            DataTable dt = _objSqlhelper.GetDataTable(str);
            return dt.Rows[0]["SubMetalId"].ToString();
        }


        public void addUpdateName(string Name)
        {
            string str = "INSERT INTO setting_value (Address) VALUES        (N'" + Name + "')";
            _objSqlhelper.ExecuteSql(str);
        }


       
    }

}