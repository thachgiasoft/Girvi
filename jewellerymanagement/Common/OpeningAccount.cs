using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;
using BAL;


namespace JewelleryManagement.Common
{
    public partial class OpeningAccount : Form
    {

        Validation val = new Validation();
        Cls_BalanceSheet _objBalanceSheet = new Cls_BalanceSheet();
        ClsFinancialYear _onjFinancialYear = new ClsFinancialYear();
        Simplevalidations _objSimplevalidations = new Simplevalidations();
         int currentMouseOverRow { get; set; }
        public OpeningAccount()
        {
            InitializeComponent();
        }

        private void OpeningAccount_Load(object sender, EventArgs e)
        {
            fillgroupaccount();
            fillgrid();
            txt_name.Focus();
        }
        private void fillgroupaccount()
        {
            cmb_AccountGroup.DataSource = _objBalanceSheet.getgroups();
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check())
                {
                    int finalcialYearId = _onjFinancialYear.getSelectedFinancialYearId();

                    string transaction_type;

                    if (rdcredit.Checked == true)
                    {
                        transaction_type = rdcredit.Text;
                    }
                    else
                    {
                        transaction_type = rdDebit.Text;
                    }
                    //_objga.insertAccountLedger(txt_name.Text, dtAccGroup.Rows[0]["srno"].ToString(),txt_OpeningBal.Text, transaction_type);
                    _objBalanceSheet.insertAccountLedger(txt_name.Text, cmb_AccountGroup.SelectedValue.ToString(), txt_OpeningBal.Text, transaction_type, txt_Nar.Text, txt_NOB.Text, txt_ChequeId.Text, dateTimePicker_addDate.Text, finalcialYearId);

                    MessageBox.Show("Saved Successfully");
                    fillgrid();
                    clearall();
                }
                else
                {
                    MessageBox.Show("Add Each Detail");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillgrid()
        {
            DataTable dtAllAccount = _objBalanceSheet.getallAccountLedgerDetails();
            dgv_AccountLedger.DataSource = dtAllAccount;
        }

        private void clearall()
        {
            txt_OpeningBal.Text = "";
            txt_name.Text = "";

            fillgroupaccount();
            btn_update.Enabled = false;
        }
        private bool check()
        {
            if (txt_name.Text != "")
            {
                if (rdcredit.Checked == true || rdDebit.Checked == true)
                {
                    if (cmb_AccountGroup.Text != "")
                    {
                        if (txt_OpeningBal.Text != "")
                        {
                            return true;
                        }
                        else { return false; }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void cmb_under_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_OpeningBal.Text);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_amount_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void lbl_under_Click(object sender, EventArgs e)
        {

        }

        private void dgv_AccountLedger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txt_name.Text = dgv_AccountLedger.Rows[dgv_AccountLedger.CurrentRow.Index].Cells["Name"].Value.ToString();
                cmb_AccountGroup.Text = dgv_AccountLedger.Rows[dgv_AccountLedger.CurrentRow.Index].Cells["Account Group"].Value.ToString();
                txt_OpeningBal.Text = dgv_AccountLedger.Rows[dgv_AccountLedger.CurrentRow.Index].Cells["Opening Balance"].Value.ToString();
                dateTimePicker_addDate.Text = dgv_AccountLedger.Rows[dgv_AccountLedger.CurrentRow.Index].Cells["Date"].Value.ToString();
                if (dgv_AccountLedger.Rows[dgv_AccountLedger.CurrentRow.Index].Cells["Credit/Debit"].Value.ToString() == "Credit")
                {
                    rdcredit.Checked = true;
                }
                if (dgv_AccountLedger.Rows[dgv_AccountLedger.CurrentRow.Index].Cells[4].Value.ToString() == "Debit")
                {
                    rdDebit.Checked = true;
                }
                btn_update.Enabled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string transaction_type;
            if (rdcredit.Checked == true)
            {
                transaction_type = rdcredit.Text;
            }
            else
            {
                transaction_type = rdDebit.Text;
            }
            _objBalanceSheet.updateLedger(dgv_AccountLedger.Rows[dgv_AccountLedger.CurrentRow.Index].Cells[0].Value.ToString(), txt_name.Text, cmb_AccountGroup.SelectedValue.ToString(), txt_OpeningBal.Text, transaction_type, txt_Nar.Text, txt_NOB.Text, txt_ChequeId.Text,dateTimePicker_addDate.Text);
            MessageBox.Show("Update Successfully");
            clearall();
            fillgrid();
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_AccountGroup.Select();
            }
        }

        private void txt_OpeningBal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Nar.Select();
            }
        }

        private void txt_Nar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_NOB.Select();
            }
        }

        private void txt_NOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ChequeId.Select();
            }
        }

        private void OpeningAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txt_Nar_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void txt_NOB_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void txt_ChequeId_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void dgv_AccountLedger_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dgv_AccountLedger_MouseClick(object sender, MouseEventArgs e)
        {
             if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Account Detail"));
                m.MenuItems[0].Click += new EventHandler(frm_AccountDetail);
               currentMouseOverRow = dgv_AccountLedger.HitTest(e.X, e.Y).RowIndex;



                m.Show(dgv_AccountLedger, new Point(e.X, e.Y));


            }
        }
        void frm_AccountDetail(object sender, EventArgs e)
        {
            string girvi_no = Convert.ToString(dgv_AccountLedger.Rows[currentMouseOverRow].Cells[0].Value);
            frm_AccountDetail _objInterestPay = new frm_AccountDetail(dgv_AccountLedger.Rows[currentMouseOverRow].Cells["id"].Value.ToString());
            _objInterestPay.ShowDialog();
            
        }

        }


    }

