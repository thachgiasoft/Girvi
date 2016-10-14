using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using BAL;
using System.Net;
using JewelleryManagement.Common.Sql;
using JMS.SQL;

namespace JewelleryManagement.Common
{
    public partial class frm_dbbackup : Form
    {
        #region Constructor
        public frm_dbbackup()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler

        string ftpServerIP;
        string ftpUserID;
        string ftpPassword;

        private void btnBrowseSQLitePath_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog(this);
            if (res == DialogResult.Cancel)
                return;
           
            string fpath = saveFileDialog1.FileName;
            txtSQLitePath.Text = fpath;
            pbrProgress.Value = 0;
            lblMessage.Text = string.Empty;
        }

        private void cboDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
            pbrProgress.Value = 0;
            lblMessage.Text = string.Empty;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
            	string constr;
            	if (cbxIntegrated.Checked) {
            		constr = GetSqlServerConnectionString(txtSqlAddress.Text, "master");
            	} else {
            		constr = GetSqlServerConnectionString(txtSqlAddress.Text, "master", txtUserDB.Text, txtPassDB.Text);
            	}
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();

                    // Get the names of all DBs in the database server.
                    SqlCommand query = new SqlCommand(@"select distinct [name] from sysdatabases", conn);
                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        cboDatabases.Items.Clear();
                        while (reader.Read())
                            cboDatabases.Items.Add((string)reader[0]);
                        if (cboDatabases.Items.Count > 0)
                            cboDatabases.SelectedIndex = 0;
                    } // using
                } // using

                cboDatabases.Enabled = true;

                pbrProgress.Value = 0;
                lblMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    ex.Message,
                    "Failed To Connect",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } // catch
        }

        private void txtSQLitePath_TextChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                ftpServerIP = "107.161.176.50";
                ftpUserID = "ashlesha";
                ftpPassword = "a1234567890";
                UpdateSensitivity();

            }
            catch (System.Exception ex)
            {
            	
            }
         
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "SQL Server To SQLite DB Converter (" + version + ")";
         //   btnStart_Click(this, new EventArgs());
           // this.Hide();
        }

		private void txtSqlAddress_TextChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SqlServerToSQLite.CancelConversion();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SqlServerToSQLite.IsActive)
            {
                SqlServerToSQLite.CancelConversion();
                _shouldExit = true;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void cbxEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
        }

        private void ChkIntegratedCheckedChanged(object sender, EventArgs e)
        {
            if (cbxIntegrated.Checked)
            {
                lblPassword.Visible = false;
                lblUser.Visible = false;
                txtPassDB.Visible = false;
                txtUserDB.Visible = false;
            }
            else
            {
                lblPassword.Visible = true;
                lblUser.Visible   = true;
                txtPassDB.Visible = true;
                txtUserDB.Visible = true;
            }
        }

        private void Upload(string filename)
        {
            ftpServerIP = "107.161.176.50";
            ftpUserID = "SachinJwellers";
            ftpPassword = "123@pps";

            FileInfo fileInf = new FileInfo(filename);
            string uri = "ftp://" + ftpServerIP + "/" + fileInf.Name;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + fileInf.Name));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

            // By default KeepAlive is true, where the control connection is not closed
            // after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }


                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
                MessageBox.Show("File Uploaded Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload Error");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        	string sqlConnString;
            //if (cbxIntegrated.Checked) {
            //    sqlConnString = GetSqlServerConnectionString(txtSqlAddress.Text, (string)cboDatabases.SelectedItem);
            //} else {
            //    sqlConnString =GetSqlServerConnectionString(txtSqlAddress.Text, (string)cboDatabases.SelectedItem, txtUserDB.Text, txtPassDB.Text);
            //}


  

            sqlConnString = clsVariable.ConnectionString;
            bool createViews = cbxCreateViews.Checked;


            //string sqlitePath = "c:\\temp\\JewelleryDB.db";//txtSQLitePath.Text.Trim();
            //this.Cursor = Cursors.WaitCursor;
            string dpath = "C:\\MoblieBackUp";

            if (!Directory.Exists(dpath))
                Directory.CreateDirectory(dpath);

            string sqlitePath = "C:\\MoblieBackUp\\JewelleryDB.db";//txtSQLitePath.Text.Trim();
            

            this.Cursor = Cursors.WaitCursor;
            SqlConversionHandler handler = new SqlConversionHandler(delegate(bool done,
                bool success, int percent, string msg) {
                    Invoke(new MethodInvoker(delegate() {
                        UpdateSensitivity();
                        lblMessage.Text = msg;
                        pbrProgress.Value = percent;

                        if (done)
                        {
                            btnStart.Enabled = true;
                            this.Cursor = Cursors.Default;
                            UpdateSensitivity();

                            if (success)
                            {
                                //MessageBox.Show(this,
                                //    msg,
                                //    "Conversion Finished",
                                //    MessageBoxButtons.OK,
                                //    MessageBoxIcon.Information);
                                pbrProgress.Value = 0;
                                lblMessage.Text = string.Empty;
                               // Upload("c:\\temp\\JewelleryDB.db");
                                Upload("c:\\MoblieBackUp\\JewelleryDB.db");
                                this.Close();
                            }
                            else
                            {
                                if (!_shouldExit)
                                {
                                    MessageBox.Show(this,
                                        msg,
                                        "Conversion Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    pbrProgress.Value = 0;
                                    lblMessage.Text = string.Empty;
                                }
                                else
                                    Application.Exit();
                            }
                        }
                    }));
            });
            SqlTableSelectionHandler selectionHandler = new SqlTableSelectionHandler(delegate(List<TableSchema> schema)
            {
                List<TableSchema> updated = null;
                Invoke(new MethodInvoker(delegate
                {
                    // Allow the user to select which tables to include by showing him the 
                    // table selection dialog.
                    TableSelectionDialog dlg = new TableSelectionDialog();
                    DialogResult res = dlg.ShowTables(schema, this);
                    if (res == DialogResult.OK)
                        updated = dlg.IncludedTables;
                }));
                return updated;
            });

            FailedViewDefinitionHandler viewFailureHandler = new FailedViewDefinitionHandler(delegate(ViewSchema vs)
            {
                string updated = null;
                Invoke(new MethodInvoker(delegate
                {
                    ViewFailureDialog dlg = new JewelleryManagement.Common.Sql.ViewFailureDialog();
                    dlg.View = vs;
                    DialogResult res = dlg.ShowDialog(this);
                    if (res == DialogResult.OK)
                        updated = dlg.ViewSQL;
                    else
                        updated = null;
                }));

                return updated;
            });

            string password = txtPassword.Text.Trim();
            if (!cbxEncrypt.Checked)
                password = null;
            SqlServerToSQLite.ConvertSqlServerToSQLiteDatabase(sqlConnString, sqlitePath, password, handler, 
                selectionHandler, viewFailureHandler, cbxTriggers.Checked, createViews);
        }

        #endregion

        #region Private Methods

        private void UpdateSensitivity()
        {
            if (txtSQLitePath.Text.Trim().Length > 0 && cboDatabases.Enabled &&
                (!cbxEncrypt.Checked || txtPassword.Text.Trim().Length > 0))
                btnStart.Enabled = true && !SqlServerToSQLite.IsActive;
            else
                //btnStart.Enabled = false;

            btnSet.Enabled = txtSqlAddress.Text.Trim().Length > 0 && !SqlServerToSQLite.IsActive;
            btnCancel.Visible = SqlServerToSQLite.IsActive;
            txtSqlAddress.Enabled = !SqlServerToSQLite.IsActive;
            txtSQLitePath.Enabled = !SqlServerToSQLite.IsActive;
            btnBrowseSQLitePath.Enabled = !SqlServerToSQLite.IsActive;
            cbxEncrypt.Enabled = !SqlServerToSQLite.IsActive;
            cboDatabases.Enabled = cboDatabases.Items.Count > 0 && !SqlServerToSQLite.IsActive;
            txtPassword.Enabled = cbxEncrypt.Checked && cbxEncrypt.Enabled;
            cbxIntegrated.Enabled = !SqlServerToSQLite.IsActive;
            cbxCreateViews.Enabled = !SqlServerToSQLite.IsActive;
            cbxTriggers.Enabled = !SqlServerToSQLite.IsActive;
            txtPassDB.Enabled = !SqlServerToSQLite.IsActive;
            txtUserDB.Enabled = !SqlServerToSQLite.IsActive;
        }

        private static string GetSqlServerConnectionString(string address, string db)
        {
            string res = @"Data Source=" + address.Trim() +
                    ";Initial Catalog="+db.Trim()+";Integrated Security=SSPI;";
            return res;
        }
        private static string GetSqlServerConnectionString(string address, string db, string user, string pass)
        {
            string res = @"Data Source=" + address.Trim() +
            	";Initial Catalog="+db.Trim()+";User ID=" + user.Trim() + ";Password=" + pass.Trim();
            return res;
        }
        #endregion

        #region Private Variables
        private bool _shouldExit = false;
        #endregion        

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Upload_Click(object sender, EventArgs e)
        {
            Upload("c:\\MoblieBackUp\\JewelleryDB.db");
           
           
        }

    }
}