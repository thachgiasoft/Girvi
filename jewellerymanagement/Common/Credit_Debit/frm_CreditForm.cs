using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BAL.Common;

namespace JewelleryManagement.Common.Credit_Debit
{
    public partial class frm_CreditForm : Form
    {
        public frm_CreditForm()
        {
            InitializeComponent();
        }
        Cls_BalanceSheet _objCredit = new Cls_BalanceSheet();
        ClsFinancialYear _onjFinancialYear = new ClsFinancialYear();
        Validation val = new Validation();
        public delegate void SendData(DataTable dt);

        private void frm_CreditForm_Load(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkall())
                {
                    string ledger = "Cash";
                    string transactiontype = "Debit";
                    string amount = txt_amount.Text;
                    string chequeno = txt_chequeNo.Text;
                    string chequedate = dtp_chequeDate.Text;
                    string currentdate = dtp_date.Text;
                    
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Enter each Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private bool checkall()
        {
            if (txt_amount.Text == "" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       

      
        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
                    int finalcialYearId = _onjFinancialYear.getSelectedFinancialYearId();
              

                    string masterid = _objCredit.insertCreditDebitmaster(txt_amount.Text, txt_narration.Text, dtp_date.Text, finalcialYearId);


                    DataTable dt = _objCredit.getallAccountLedgerDetails();
                    int ledgerid = 0;
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (dt.Rows[j]["Name"].ToString().Trim() == "Cash")
                        {
                            ledgerid = Convert.ToInt32(dt.Rows[j][0]);
                        }
                    }
                   

                    _objCredit.insertCreditDebitDetails(masterid, ledgerid.ToString(), txt_amount.Text, "0", txt_chequeNo.Text, dtp_chequeDate.Text, dtp_date.Text, "Cr", cmb_AcountLedger.Text);
                    _objCredit.insertCreditDebitDetails(masterid, cmb_AcountLedger.SelectedValue.ToString(), "0",txt_amount.Text, txt_chequeNo.Text, txt_chequeNo.Text, dtp_date.Text, "Dr", cmb_AcountLedger.Text);

                    MessageBox.Show("Data Saved Successfully");
                    clearAllFields();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void clearFields()
        {
            txt_amount.ResetText();
            txt_chequeNo.ResetText();
            dtp_chequeDate.ResetText();
        }

        private void clearAllFields()
        {

            clearFields();
            txt_narration.ResetText();
           
          
            dgv_DebitData.Rows.Clear();
            DataTable dtDebit = _objCredit.getallAccountLedgerDetailsCredit();
            for (int i = 0; i < dtDebit.Rows.Count; i++)
            {
                dgv_DebitData.Rows.Add(dtDebit.Rows[i]["CreditDebitmasterid"].ToString(), dtDebit.Rows[i]["date"].ToString(), dtDebit.Rows[i]["Credit"].ToString(), dtDebit.Rows[i]["FromAccount"].ToString(), dtDebit.Rows[i]["chequeno"].ToString(), dtDebit.Rows[i]["chequedate"].ToString());
            }
            DataTable dt = _objCredit.getallAccountLedgerDetails();
            cmb_AcountLedger.DataSource = dt;
            cmb_AcountLedger.Select();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgv_DebitData.Rows.RemoveAt(dgv_DebitData.CurrentRow.Index);
          
            clearFields();
        }

        private void frm_CreditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

     

        private void cmb_transactionType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_amount.Select();
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_chequeNo.Select();
            }
        }

        private void txt_chequeNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_chequeDate.Select();
            }
        }

      
        private void bttn_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv_DebitData.Select();
            }
        }

        private void dgv_CreditData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_narration.Select();
            }
        }

        private void txt_narration_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

      

        private void txt_CreditTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_save.Select();
            }
        }

        private void cmb_AcountLedger_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void cmb_transactionType_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void txt_amount_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void txt_chequeNo_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dtp_chequeDate_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void txt_narration_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void lblamount_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                _objCredit.deleteDebitCredit(dgv_DebitData.CurrentRow.Cells["MasterId"].Value.ToString());
                clearAllFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        

        private void dgv_DebitData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
          
            try
            {
                DataTable dt = val.DataGridView2DataTable(dgv_DebitData, "table1");
                CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDebitDetailsReport);
                _obj(dt);
                _objfrm_ReportViewer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
