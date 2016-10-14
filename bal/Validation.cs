using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;
using System.IO;
using BAL;

namespace BAL
{
  public   class Validation
    {

      public   bool IsNotEmpty(string value)
        {
            if (value != "")
            {
                return true ;

            }
            else
            {
                return false;
            }
        }
        public string UppercaseFirst(string s)
        {
            if (s != "")
            {
                return char.ToUpper(s[0]) + s.Substring(1);

            }
            else
            {
                return s;
            }
           
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



      
      
        public void Chdate()
        {
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);

            //Set value for short Date Format HardCode
            rkey.SetValue("sShortDate", "dd/MM/yyyy");
            // Set value for Long Date Format HardCode
            rkey.SetValue("sLongDate", "dd/MM/yyyy");
           
        }
   

        
    bool bln;
    string pat;
    bool valbl = false;
    public bool authontic()
    {
        bool returnValue = false;
        string ts;
        string dtl;
        DateTime de;
        DateTime dbl;
        pat = "C:\\WINDOWS" + "\\WinNTService.txt";
        try
        {
            if (System.IO.File.Exists(pat))
            {
                FileStream fs = new FileStream(pat, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                ts = sr.ReadLine();

                de = Convert.ToDateTime(ts);
                sr.Close();
                fs.Close();
                dtl = DateTime.Now.Date.ToString();
                dbl = Convert.ToDateTime(dtl);
                System.TimeSpan datediff = dbl - de;
                int nor = datediff.Days;

                if (nor >= 15)
                {
                    System.Windows.Forms.MessageBox.Show("Limit Expire! Please Inform your contact person");
                    File.Delete(pat);
                    filecr(System.Convert.ToString(DateTime.Parse("01/01/1950")));
                    returnValue = false;

                    //End
                }
                else
                {
                    returnValue = true;
                    return true;
                }
            }
            else
            {
                filecr(DateTime.Now.ToShortDateString());
            }
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
        }


        return returnValue;
    
        }
    private void filecr(string dt)
    {
        StreamWriter TextFile = new StreamWriter(pat);
        TextFile.WriteLine(dt);
        TextFile.Close();
        Console.WriteLine("Text File created test.txt");
    }


    }
}
