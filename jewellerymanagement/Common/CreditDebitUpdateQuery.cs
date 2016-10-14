using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;

namespace JewelleryManagement.Common
{
    public partial class CreditDebitUpdateQuery : Form
    {

        SQLHelper _objSqlHelper = new SQLHelper();

        public CreditDebitUpdateQuery()
        {
            InitializeComponent();
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreditDebitUpdateQuery_Load(object sender, EventArgs e)
        {
            string Date = DateTime.UtcNow.ToString();

            string renameCreditt = "Rename Credit";
            string queryrename1 = "Update CreditDebitDetails set Type='Credit' where Type='Dr'";
            dgv_CreaditDebit.Rows.Add(false, renameCreditt, queryrename1, Date);

            string renameDebitt = "Rename Debit";
            string queryrename2 = "Update CreditDebitDetails set Type='Debit' where Type='Cr'";
            dgv_CreaditDebit.Rows.Add(false, renameDebitt, queryrename2, Date);


            string renameCredit = "Rename Credit";
            string query15 = "Update CreditDebitDetails set Type='Cr' where Type='Credit'";
            dgv_CreaditDebit.Rows.Add(false, renameCredit, query15, Date);

            string renameDebit = "Rename Debit";
            string query16 = "Update CreditDebitDetails set Type='Dr' where Type='Debit'";
            dgv_CreaditDebit.Rows.Add(false, renameDebit, query16, Date);

            string renameCreditColumn = "Rename Credit Column";
            string query17 = "EXEC sp_rename 'CreditDebitDetails.Credit', 'Debitt', 'COLUMN'";
            dgv_CreaditDebit.Rows.Add(false, renameCreditColumn, query17, Date);

            string renameDebitColumn = "Rename Debit Column";
            string query18 = "EXEC sp_rename 'CreditDebitDetails.Debit', 'Creditt', 'COLUMN'";
            dgv_CreaditDebit.Rows.Add(false, renameDebitColumn, query18, Date);

            string renameCreditColumnFinal = "Rename Credit Column";
            string query19 = "EXEC sp_rename 'CreditDebitDetails.Creditt', 'Credit', 'COLUMN'";
            dgv_CreaditDebit.Rows.Add(false, renameCreditColumnFinal, query19, Date);

            string renameDebitColumnFinal = "Rename Debit Column";
            string query20 = "EXEC sp_rename 'CreditDebitDetails.Debitt', 'Debit', 'COLUMN'";
            dgv_CreaditDebit.Rows.Add(false, renameDebitColumnFinal, query20, Date);

        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            DialogResult drReportPrint = MessageBox.Show("Do You Want To Execute", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (drReportPrint == DialogResult.Yes)
            {
                for (int i = 0; i < dgv_CreaditDebit.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgv_CreaditDebit.Rows[i].Cells["Select"].Value.ToString()) == true)
                    {
                        try
                        {
                            string query = dgv_CreaditDebit.Rows[i].Cells["Query"].Value.ToString();
                            _objSqlHelper.ExecuteSql(query);
                        }
                        catch
                        {
                        }

                    }

                }
                MessageBox.Show("Data Updated");
            }
            else
            {
                this.Close();
            }
           
        }

        private void chk_selectall_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_selectall.Checked == true)
            {
                for (int i = 0; i < dgv_CreaditDebit.Rows.Count; i++)
                {
                    dgv_CreaditDebit.Rows[i].Cells[0].Value = true;

                }
            }
            else
            {
                for (int i = 0; i < dgv_CreaditDebit.Rows.Count; i++)
                {
                    dgv_CreaditDebit.Rows[i].Cells[0].Value = false;
                }
            }
        }
    }
}
