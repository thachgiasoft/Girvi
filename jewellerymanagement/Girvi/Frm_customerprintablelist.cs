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
using BAL.Girvi;
using System.Drawing.Text;
using JewelleryManagement.Reports.Girvi;

namespace JewelleryManagement.Girvi
{
    public partial class Frm_customerprintablelist : Form
    {
        public Frm_customerprintablelist()
        {
            InitializeComponent();
        }

        Simplevalidations _objSimplevalidations = new Simplevalidations();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsCommon _objCommon = new clsCommon();
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        DataTable dt;
        Validation val = new Validation();
        public delegate void SendData(DataTable dtData, bool Other);

      

        private void Frm_customerprintablelist_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void fillgrid()
        {
            dgv_GirviDetails.Rows.Clear();
            dt = _objGirviCommon.getCustomerprintDetails( cmb_FullName.Text );
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_GirviDetails.Rows.Add(dt.Rows[i]["khatawani_No"].ToString(), dt.Rows[i]["receipt_no"].ToString(), dt.Rows[i]["FullName"].ToString(), dt.Rows[i]["Address"].ToString(), dt.Rows[i]["Contact_No"].ToString(), dt.Rows[i]["GirviRecordNo"].ToString(), dt.Rows[i]["Amount"].ToString(), dt.Rows[i]["item_type"].ToString(), dt.Rows[i]["net_wt"].ToString(), dt.Rows[i]["Date_of_deposit"].ToString());
            }
        }

        private bool ValidSearch()
        {

            if (cmb_FullName.Text != "")
            {
                return true;
            }
            else { return false; }

        }
        private void SearchGirvi()
        {
            try
            {
                if (ValidSearch())
                {
                    DataTable dtSearch = null;

                    dtSearch = _objGirviAdd.getFName(cmb_FullName.Text);

                    if (dtSearch.Rows.Count > 0)
                    {
                        if (dtSearch.Rows.Count >= 1)
                        {

                            cmb_FullName.Text = Convert.ToString((dtSearch.Rows[0]["FullName"]));

                            

                        }
                        fillgrid();



                    }
                    else
                    {
                        //MessageBox.Show("Record not found ", "Girvi Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetText();
                    }
                }
                else
                {
                    MessageBox.Show("Please either   Name  ", "Girvi Says", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btn_shift_Click(object sender, EventArgs e)
        {

            int ind = dgv_GirviDetails.CurrentCell.RowIndex;
             if (dt.Rows.Count > 0)
            {
                dgv_Girvicutomershift.Rows.Add(dgv_GirviDetails.Rows[ind].Cells[0].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[1].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[2].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[3].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[4].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[5].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[6].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[7].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[8].Value.ToString(),dgv_GirviDetails.Rows[ind].Cells[9].Value.ToString());
                
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            DataTable dataNew = val.DataGridView2DataTable(dgv_Girvicutomershift,"dt_CashInHand");
            CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
            SendData _obj = new SendData(_objfrm_ReportViewer.ReciveDataCustprint);
            _obj(dataNew, true);
            _objfrm_ReportViewer.Show();
            
        }

        private void Bttn_LeftShift_Click(object sender, EventArgs e)
        {
            int ind = dgv_Girvicutomershift.CurrentCell.RowIndex;
            if (dt.Rows.Count > 0)
            {
                dgv_GirviDetails.Rows.Add(dgv_Girvicutomershift.Rows[ind].Cells[0].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[1].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[2].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[3].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[4].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[5].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[6].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[7].Value.ToString(), dgv_GirviDetails.Rows[ind].Cells[8].Value.ToString());

            }
        }


        

        private void cmb_FullName_TextChanged(object sender, EventArgs e)
        {
            if (cmb_FullName.Text != "")
            {

                lst_FullName.DataSource = _objGirviAdd.getFName(cmb_FullName.Text);
                if (lst_FullName.Items.Count > 0)
                {
                    lst_FullName.Visible = true;
                }
                lst_FullName.DisplayMember = "FullName";
                lst_FullName.ValueMember = "FullName";
            }

        }

        private void lst_FullName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                cmb_FullName.Text = lst_FullName.SelectedValue.ToString();
                cmb_FullName.Focus();

                
                fillgrid();

                lst_FullName.Visible = false;

            }
        }

        private void cmb_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (lst_FullName.Items.Count > 0)
                    {

                        lst_FullName.Focus();
                        
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {


                    SearchGirvi();

                    lst_FullName.Visible = false;

                }
                else
                {


                    //if (cmb_FullName.Text != "")
                    //{

                    //    //cmb_FullName.Items.Clear();
                    //  //CustName = cmb_FullName.Text;
                    //  //  cmb_FullName.DataSource = _objGirviAdd.getFName(CustName);
                    //    //cmb_FullName.DroppedDown = true;
                    //    //cmb_FullName.Items.Clear();

                    //    //cmb_FullName.SelectedIndex = -1;

                    //}
                }
               

            }
            catch (Exception ex)
            {

            }
        
        }

        private void Bttn_Right_Shift_Click(object sender, EventArgs e)
        {
           
            if (this.dgv_Girvicutomershift.SelectedRows.Count > 0)
            {
                dgv_Girvicutomershift.Rows.RemoveAt(this.dgv_Girvicutomershift.SelectedRows[0].Index);
            }    
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            lbl_FullName.Text = "ग्राहकाचे नाव";
            lbl_Date.Text = "तारीख";
            this.Text = "ग्राहक प्रिंट रिपोर्ट ";
            dgv_GirviDetails.Columns["Name"].HeaderText = "नाव";
            dgv_GirviDetails.Columns["City"].HeaderText = "गाव";
            dgv_GirviDetails.Columns["GirviRecordNo"].HeaderText = "गाहणी क्रं";
            dgv_GirviDetails.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviDetails.Columns["item_type"].HeaderText = "वस्तूची महिती";
            dgv_GirviDetails.Columns["Weight"].HeaderText = "वजन";
            dgv_GirviDetails.Columns["DepositeDate"].HeaderText = "ठेवली तारीख";

            dgv_Girvicutomershift.Columns["CName"].HeaderText = "नाव";
            dgv_Girvicutomershift.Columns["CCity"].HeaderText = "गाव";
            dgv_Girvicutomershift.Columns["CWeight"].HeaderText = "वजन";
            dgv_Girvicutomershift.Columns["Gahanino"].HeaderText = "गाहणी क्रं";
            dgv_Girvicutomershift.Columns["CAmount"].HeaderText = "रक्कम";
            dgv_Girvicutomershift.Columns["ItemDetails"].HeaderText = "वस्तूची महिती";
            dgv_Girvicutomershift.Columns["CDepositedate"].HeaderText = "ठेवली तारीख";
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            lbl_FullName.Text = "ग्राहक का नाम";
            lbl_Date.Text = "तारीख";
            this.Text = "ग्राहक प्रिंट रिपोर्ट ";
            dgv_GirviDetails.Columns["Name"].HeaderText = "नाम";
            dgv_GirviDetails.Columns["City"].HeaderText = "गाव";
            dgv_GirviDetails.Columns["GirviRecordNo"].HeaderText = "गाहणी क्रं";
            dgv_GirviDetails.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviDetails.Columns["item_type"].HeaderText = "वस्तूची महिती";
            dgv_GirviDetails.Columns["Weight"].HeaderText = "वजन";
            dgv_GirviDetails.Columns["DepositeDate"].HeaderText = "रखी तारीख";

            dgv_Girvicutomershift.Columns["CName"].HeaderText = "नाव";
            dgv_Girvicutomershift.Columns["CCity"].HeaderText = "गाव";
            dgv_Girvicutomershift.Columns["CWeight"].HeaderText = "वजन";
            dgv_Girvicutomershift.Columns["Gahanino"].HeaderText = "गाहणी क्रं";
            dgv_Girvicutomershift.Columns["CAmount"].HeaderText = "रक्कम";
            dgv_Girvicutomershift.Columns["ItemDetails"].HeaderText = "वस्तूची महिती";
            dgv_Girvicutomershift.Columns["CDepositedate"].HeaderText = "रखी तारीख";
        }

        private void rbt_English_CheckedChanged(object sender, EventArgs e)
        {
            lbl_FullName.Text = "Customer Name";
            lbl_Date.Text = "Date";
            this.Text = "Customer Print Report ";
            dgv_GirviDetails.Columns["Name"].HeaderText = "Name";
            dgv_GirviDetails.Columns["City"].HeaderText = "City";
            dgv_GirviDetails.Columns["GirviRecordNo"].HeaderText = "Girvi Record No";
            dgv_GirviDetails.Columns["Amount"].HeaderText = "Amount";
            dgv_GirviDetails.Columns["item_type"].HeaderText = "Item Type";
            dgv_GirviDetails.Columns["Weight"].HeaderText = "Weight";
            dgv_GirviDetails.Columns["DepositeDate"].HeaderText = "Deposite Date";

            dgv_Girvicutomershift.Columns["CName"].HeaderText = "Name";
            dgv_Girvicutomershift.Columns["CCity"].HeaderText = "City";
            dgv_Girvicutomershift.Columns["CWeight"].HeaderText = "Weight";
            dgv_Girvicutomershift.Columns["Gahanino"].HeaderText = "Girvi Record No";
            dgv_Girvicutomershift.Columns["CAmount"].HeaderText = "Amount";
            dgv_Girvicutomershift.Columns["ItemDetails"].HeaderText = "Item Type";
            dgv_Girvicutomershift.Columns["CDepositedate"].HeaderText = "Deposite Date";
        }

        private void cmb_FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send("^(1)"); 
        }

        private void Frm_customerprintablelist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


     
      

    }
}
