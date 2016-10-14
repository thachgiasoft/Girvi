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

namespace JewelleryManagement.Common
{
    public partial class frm_AccountDetail : Form
    {
        public string ledgerid { get; set; }
        public frm_AccountDetail(string Id)
        {
            InitializeComponent();
            ledgerid = Id;

        }
        Cls_BalanceSheet _objCreditDebit = new Cls_BalanceSheet();
        clsCommon _objCommon = new clsCommon();

        private void frm_AccountDetail_Load(object sender, EventArgs e)
        {
            dgv_Credit.Rows.Clear();
            dgv_Debit.Rows.Clear();
            getallCreditDebitDetail();

        }

        private void getallCreditDebitDetail()
        {
            DataTable dt = _objCreditDebit.getAllCreditDebitDetails(ledgerid);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["credit"].ToString() != "0")
                {
                    dgv_Credit.Rows.Add(dt.Rows[i]["date"].ToString(), dt.Rows[i]["credit"].ToString());
                }
                if (dt.Rows[i]["debit"].ToString() != "0")
                {
                    dgv_Debit.Rows.Add(dt.Rows[i]["date"].ToString(), dt.Rows[i]["debit"].ToString());
                }
            }
            dgv_Credit.Rows.Add("Total=",_objCommon.sumGridViewColumn(dgv_Credit,"CrAmount"));
            dgv_Debit.Rows.Add("Total=",_objCommon.sumGridViewColumn(dgv_Debit,"DrAmount"));
            double balance = Convert.ToDouble(dgv_Debit.Rows[dgv_Debit.Rows.Count - 1].Cells["DrAmount"].Value) - Convert.ToDouble(dgv_Credit.Rows[dgv_Credit.Rows.Count - 1].Cells["CrAmount"].Value);
            lbl_Total.Text = balance.ToString();
        }


        private void frm_AccountDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
