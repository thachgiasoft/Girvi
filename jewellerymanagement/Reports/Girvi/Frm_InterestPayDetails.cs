using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Reports.Girvi;
using BAL.Common;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class Frm_InterestPayDetails : Form
    {
        clsGirviReport _objGirviReport = new clsGirviReport();
        clsCommon _objCommon = new clsCommon();

        public Frm_InterestPayDetails()
        {
            InitializeComponent();
        }

        public Frm_InterestPayDetails(string GirviNo)
        {
            InitializeComponent();
            txt_InvoiceNo.Text = GirviNo;
        }

        private void Frm_InterestPayDetails_Load(object sender, EventArgs e)
        {

        }

        private void Frm_InterestPayDetails_Load_1(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
           
            DataTable dt = _objGirviReport.getInterestPayTableDetailByGirviNo(txt_InvoiceNo.Text);
            for (int q = 0; q < dt.Rows.Count; q++)
            {
                dgv_InterestPay.Rows.Add(dt.Rows[q]["SrNo"].ToString(),dt.Rows[q]["Date"].ToString(), dt.Rows[q]["Amount"].ToString());
            }
            double sumInterestPaid = _objCommon.sumGridViewColumn(dgv_InterestPay, "Amount");
            dgv_InterestPay.Rows.Add("Total= ", sumInterestPaid);

        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_InterestPay.Rows.Count >0)
            {
                _objGirviReport.DeleteInterestPayTableDetailByGirviNo(dgv_InterestPay.CurrentRow.Cells["SrNo"].Value.ToString());
                MessageBox.Show("Delete Successfully");
                dgv_InterestPay.Rows.Clear();
                FillGrid();
            }
            else 
            {
                MessageBox.Show("There Is No Data In This Girvi");
            }
        }
    }
}
