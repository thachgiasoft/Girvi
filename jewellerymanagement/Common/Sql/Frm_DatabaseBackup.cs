using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using BAL;

namespace JewelleryManagement.Common.Sql
{
    public partial class Frm_DatabaseBackup : Form
    {

        SQLHelper _objSqlHelper = new SQLHelper();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Frm_DatabaseBackup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_DatabaseName.Text= clsVariable.ConnectionDatabase;
            //serverName(".\\SQLEXPRESS");          
        }
        public void blank(string str)
        {
            if (str == "backup")
            {
                SaveFileDialog1.FileName = ComboBoxDatabaseName.Text;
                SaveFileDialog1.ShowDialog();
                string s = null;
                s = SaveFileDialog1.FileName;
            
                string stru = "Backup database " + clsVariable.ConnectionDatabase + " to disk='" + s + "'";
                _objSqlHelper.ExecuteSql(stru);
 
                MessageBox.Show("Your Database Backup is done");
            }
        }

   

        private void cmbbackup_Click_1(object sender, EventArgs e)
        {
            blank("backup");
        }
    }
}
