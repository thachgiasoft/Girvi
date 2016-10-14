using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Summary description for KeyGen
/// </summary>
public class KeyGen
{
	public KeyGen()
	{
		//
		// TODO: Add constructor logic here
		//
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
        pat = Application.StartupPath + "\\WinNTService.txt";
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
                System.TimeSpan datediff = dbl-de;
                int nor = datediff.Days;

                if (nor >= 15)
                {
                    System.Windows.Forms.MessageBox.Show("Limit Expire! Please Inform your contact person");
                    File.Delete(pat);
                    filecr(System.Convert.ToString(DateTime.Now));
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
                filecr(DateTime.Now.AddDays(15).ToShortDateString());
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
