using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Collections;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;
using BAL;



namespace JwelleryManagement
{
    public partial class frmBackupandRestore : Form
    {

      

        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        //OdbcDataReader dr;
        //string display = "";

        private static Server srvr;
        //private string DBpath = Application.StartupPath;//"D:\\Anj\\DBBackup\\";//Application.StartupPath;
        private string DBpath = "";

        public frmBackupandRestore()
        {
            InitializeComponent();
        }

      

        private void frmBackupandRestore_Load(object sender, EventArgs e)
        {

            //this.Top = 60;
            //this.Left = 5;

            //txtPath.Text = Application.StartupPath.ToString();
            txtPath.Text = GetBackupDirecory();
            DBpath = txtPath.Text;
           
            this.Cursor = Cursors.Default;
            cmbDataBase.Enabled = false;
            try
            {
                chk_Insec.Checked = true;

                // If there are any servers
                // cmbServer.Items.Add("(local)");
                //if (dtServers.Rows.Count > 0)
                //{
                //    // Loop through each server in the DataTable
                //    foreach (DataRow drServer in dtServers.Rows)
                //    {
                //        cmbServer.Items.Add(drServer["Name"]);
                //        cmbServer.Text = Convert.ToString(drServer["Name"]);
                //    }
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: There are no available servers.\nOr there is an error while loading server name", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;

            //txtServer.Focus();

            //btn_backup.Focus();

            AutoBAckup();
            this.Close();
          
        }
        public string GetBackupDirecory()
        {
            string path = "";
            string FolderName = "";
            DateTimePicker dtpdate = new DateTimePicker();
            try
            {
                FolderName = dtpdate.Value.ToString("dd-MM-yyyy hh-mm-ss tt");
              
                path = "D:\\Backup\\" + FolderName;
             
            }
            catch
            { }
            
            return(path);
        }
        private void chk_Insec_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Insec.CheckState == CheckState.Checked)
            {
                txt_username.Enabled = false;
                txt_username.Text = string.Empty;

                txt_password.Enabled = false;
                txt_password.Text = string.Empty;
            }
            if (chk_Insec.CheckState == CheckState.Unchecked)
            {
                txt_username.Enabled = true;
                txt_password.Enabled = true;
            }
        }

        public void AutoBAckup()
        {
            try
            {
                if (txtServer.Text != null)
                {
                    this.Cursor = Cursors.WaitCursor;
                    // Create a new connection to the selected server name
                
                    string output = clsVariable.ConnectionString.Split('=', ';')[1];
                    ServerConnection srvConn = new ServerConnection(output);
                    // Log in using SQL authentication instead of Windows authentication
                    srvConn.LoginSecure = false;
                    if (false)
                    {
                        // Create a new SQL Server object using the connection we created
                        srvr = new Server(srvConn);
                        // Loop through the databases list
                        //foreach (Database dbServer in srvr.Databases)
                        //{
                        //    // Add database to combobox
                        //    cmbDataBase.Items.Add(dbServer.Name);
                        //}
                    }

                    if (true)
                    {
                        // Give the login username
                        srvConn.Login = "sa";
                        // Give the login password
                        srvConn.Password = "8118";
                        // Create a new SQL Server object using the connection we created
                        srvr = new Server(srvConn);
                        // Loop through the databases list
                        //foreach (Database dbServer in srvr.Databases)
                        //{
                        //    // Add database to combobox
                        //    cmbDataBase.Items.Add(dbServer.Name);
                        //}
                    }
                }
                else
                {
                    // A server was not selected, show an error message
                    MessageBox.Show("ERROR: Contact Administrator!!", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: An error ocurred while loading the avaiable DataBasees", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }

            DBpath = txtPath.Text;
            if (cmbDataBase.SelectedIndex.ToString().Equals(""))
            {
                MessageBox.Show("Please choose Database", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (srvr != null)
            {
                try
                {
                    if (!Directory.Exists(DBpath))
                    {
                        Directory.CreateDirectory(DBpath);
                    }

                    btn_backup.Enabled = false;
                    btn_restore.Enabled = false;
                    db_change.Enabled = false;
                    // server_change.Enabled = false;

                    //Use this line if you have already created a bakup file.
                    File.Delete(DBpath + "\\" + cmbDataBase.Text + ".bak");
                    this.Cursor = Cursors.WaitCursor;
                    // If the user has chosen a path where to save the backup file
                    // Create a new backup operation
                    Backup bkpDatabase = new Backup();
                    // Set the backup type to a database backup
                    bkpDatabase.Action = BackupActionType.Database;
                    // Set the database that we want to perform a backup on
                    bkpDatabase.Database = cmbDataBase.Text;
                    // Set the backup device to a file
                    BackupDeviceItem bkpDevice = new BackupDeviceItem(DBpath + "\\" + cmbDataBase.Text + ".bak", DeviceType.File);
                    // Add the backup device to the backup
                    bkpDatabase.Devices.Add(bkpDevice);
                    // Perform the backup
                    bkpDatabase.SqlBackup(srvr);
                    MessageBox.Show("Bakup of Database " + cmbDataBase.Text + " successfully created", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR: An error ocurred while backing up DataBase" + x, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;

                    btn_backup.Enabled = true;
                    btn_restore.Enabled = true;
                    db_change.Enabled = true;
                    // server_change.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ERROR: A connection to a SQL server was not established.", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            AutoBAckup();
         
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServer.Text != null)
                {
                    this.Cursor = Cursors.WaitCursor;
                    // Create a new connection to the selected server name
                    ServerConnection srvConn = new ServerConnection(txtServer.Text.ToString());
                    // Log in using SQL authentication instead of Windows authentication
                    srvConn.LoginSecure = true;
                    if (chk_Insec.CheckState == CheckState.Checked)
                    {
                        // Create a new SQL Server object using the connection we created
                        srvr = new Server(srvConn);
                        // Loop through the databases list
                        //foreach (Database dbServer in srvr.Databases)
                        //{
                        //    // Add database to combobox
                        //    cmbDataBase.Items.Add(dbServer.Name);
                        //}
                    }

                    if (chk_Insec.CheckState == CheckState.Unchecked)
                    {
                        // Give the login username
                        srvConn.Login = txt_username.Text;
                        // Give the login password
                        srvConn.Password = txt_password.Text;
                        // Create a new SQL Server object using the connection we created
                        srvr = new Server(srvConn);
                        // Loop through the databases list
                        //foreach (Database dbServer in srvr.Databases)
                        //{
                        //    // Add database to combobox
                        //    cmbDataBase.Items.Add(dbServer.Name);
                        //}
                    }
                }
                else
                {
                    // A server was not selected, show an error message
                    MessageBox.Show("ERROR: Contact Administrator!!", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: An error ocurred while loading the avaiable DataBasees", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
            DBpath = txtPath.Text;
            //DBpath = Application .StartupPath .ToString ();
            if (cmbDataBase.Text =="")
            {
                MessageBox.Show("Please choose Database", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // If there was a SQL connection created
            if (srvr != null)
            {
                try
                {
                    //srvr.KillAllProcesses(cmbDataBase.SelectedItem.ToString());
                    //srvr.DetachDatabase(cmbDataBase.SelectedItem.ToString(), true);
                    btn_backup.Enabled = false;
                    btn_restore.Enabled = false;
                    db_change.Enabled = false;
                    //server_change.Enabled = false;

                    this.Cursor = Cursors.WaitCursor;
                    // If the user has chosen the file from which he wants the database to be restored
                    // Create a new database restore operation
                    Restore rstDatabase = new Restore();
                    // Set the restore type to a database restore
                    rstDatabase.Action = RestoreActionType.Database;
                    // Set the database that we want to perform the restore on
                    rstDatabase.Database = cmbDataBase.Text ;
                    
                    // Set the backup device from which we want to restore, to a file
                    BackupDeviceItem bkpDevice = new BackupDeviceItem(DBpath +"\\"+ cmbDataBase.Text + ".bak", DeviceType.File);
                    // Add the backup device to the restore type
                    rstDatabase.Devices.Add(bkpDevice);
                    // If the database already exists, replace it
                    rstDatabase.ReplaceDatabase = true;
                    //rstDatabase.NoRecovery = true;
                    //rstDatabase.SqlRestoreAsync(srvr);
                    // Perform the restore
                    rstDatabase.SqlRestore(srvr);
                    MessageBox.Show("Database " + cmbDataBase.Text + " succefully restored", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("ERROR: An error ocurred while restoring the database", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;

                    btn_backup.Enabled = true;
                    btn_restore.Enabled = true;
                    db_change.Enabled = true;
                    //  server_change.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ERROR: A connection to a SQL server was not established.", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Arrow;
            }
        }

      

        private void db_change_Click(object sender, EventArgs e)
        {
            cmbDataBase.Enabled = true;
        }

        private void cmbDataBase_Click(object sender, EventArgs e)
        {
            cmbDataBase.Items.Clear();
            try
            {
                if (txtServer.Text != null)
                {
                    this.Cursor = Cursors.WaitCursor;
                    // Create a new connection to the selected server name
                    ServerConnection srvConn = new ServerConnection(txtServer.Text.ToString());
                    // Log in using SQL authentication instead of Windows authentication
                    srvConn.LoginSecure = true;
                    if (chk_Insec.CheckState == CheckState.Checked)
                    {
                        // Create a new SQL Server object using the connection we created
                        srvr = new Server(srvConn);
                        // Loop through the databases list
                        foreach (Database dbServer in srvr.Databases)
                        {
                            // Add database to combobox
                            cmbDataBase.Items.Add(dbServer.Name);
                        }
                    }

                    if (chk_Insec.CheckState == CheckState.Unchecked)
                    {
                        // Give the login username
                        srvConn.Login = txt_username.Text;
                        // Give the login password
                        srvConn.Password = txt_password.Text;
                        // Create a new SQL Server object using the connection we created
                        srvr = new Server(srvConn);
                        // Loop through the databases list
                        foreach (Database dbServer in srvr.Databases)
                        {
                            // Add database to combobox
                            cmbDataBase.Items.Add(dbServer.Name);
                        }
                    }
                }
                else
                {
                    // A server was not selected, show an error message
                    MessageBox.Show("ERROR: Contact Administrator!!", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: An error ocurred while loading the avaiable DataBasees", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void cmbDataBase_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbDataBase.Enabled = false;
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               chk_Insec.Focus();
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void chk_Insec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chk_Insec.Checked == true)
                {
                    db_change.Focus();
                   
                }
                else
                {
                    txt_username.Focus();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            txtPath .Text = folderDialog.SelectedPath.ToString();
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {
           // btnClose.BackColor = Color.LightYellow;
        }

        private void btn_backup_Enter(object sender, EventArgs e)
        {
            btn_backup.BackColor = Color.LightBlue;
        }

        private void btn_backup_Leave(object sender, EventArgs e)
        {
            btn_backup.BackColor = Color.Transparent;
        }

        private void btn_restore_Enter(object sender, EventArgs e)
        {
            btn_restore.BackColor = Color.LightBlue;
        }

        private void btn_restore_Leave(object sender, EventArgs e)
        {
            btn_restore.BackColor = Color.Transparent;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
