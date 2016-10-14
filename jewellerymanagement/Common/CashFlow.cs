using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;//.FinancialAccount;

namespace JwelleryManagement.Common
{
    public partial class CashFlow : Form
    {
        Cls_BalanceSheet _objga = new Cls_BalanceSheet();
        public string nameid { get; set; }
        public CashFlow(string id)
        {
            InitializeComponent();
            nameid = id;
        }

        private void CashFlow_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void fillgrid()
        {
            double sumDebit = 0;
            double sumCredit = 0;
            DataTable dtCreditDebit = new DataTable();
          
            dtCreditDebit = _objga.getTotalCreditDebit(nameid);
            for (int j = 0; j < dtCreditDebit.Rows.Count; j++)
            {
                sumDebit = sumDebit + Convert.ToDouble(dtCreditDebit.Rows[j]["debit"].ToString());
                sumCredit = sumCredit + Convert.ToDouble(dtCreditDebit.Rows[j]["credit"].ToString());
                dgvCr.Rows.Add(dtCreditDebit.Rows[j]["date"].ToString(), dtCreditDebit.Rows[j]["credit"].ToString());
                dgvdr.Rows.Add(dtCreditDebit.Rows[j]["date"].ToString(), dtCreditDebit.Rows[j]["debit"].ToString());
            }
            lblTotalCr.Text = sumCredit.ToString();
            lblDr.Text = sumDebit.ToString();
        }

        private void dgvCr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        int currentMouseOverRow;
        private void dgvCr_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Delete"));
                m.MenuItems[0].Click += new System.EventHandler(this.menuItem_Click);
                currentMouseOverRow = dgvCr.HitTest(e.X, e.Y).RowIndex;



                m.Show(dgvCr, new Point(e.X, e.Y));

            }
        }
        private void menuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
             
                DialogResult dr = MessageBox.Show("Do you want To Delete", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    _objga.deletecredit(dgvCr.Rows[dgvCr.Rows[currentMouseOverRow].Index].Cells["id"].Value.ToString());

                    fillgrid();
                }
               

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("No Girvi Number Found");
            }
            // Create a new OpenFileDialog and display it.



        }
        int currentMouseOverRow1;
        private void dgvdr_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Delete"));
                m.MenuItems[0].Click += new System.EventHandler(this.menuItemdr_Click);
                currentMouseOverRow1 = dgvdr.HitTest(e.X, e.Y).RowIndex;



                m.Show(dgvdr, new Point(e.X, e.Y));

            }
        }
        private void menuItemdr_Click(object sender, System.EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("Do you want To Delete", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {

                    _objga.deletedebit(dgvdr.Rows[dgvdr.Rows[currentMouseOverRow1].Index].Cells["id"].Value.ToString());

                    fillgrid();
                }


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("No Girvi Number Found");
            }
            // Create a new OpenFileDialog and display it.



        }
    }
}
