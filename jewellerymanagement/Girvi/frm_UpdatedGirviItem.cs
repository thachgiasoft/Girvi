using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BAL.Girvi;
using BAL.Common;
namespace JewelleryManagement.Girvi
{
    public partial class frm_UpdatedGirviItem : Form
    {
        cls_GirviUpdate _objGirviUpdate = new cls_GirviUpdate();
        clsCommon _objCommon = new clsCommon();
        Simplevalidations _objSimpalValidation = new Simplevalidations();
        string GirviNo;
        public frm_UpdatedGirviItem(string girvino)
        {
            InitializeComponent();
             GirviNo = girvino;
        }

        private void frm_UpdatedGirviItem_Load(object sender, EventArgs e)
        {
            filltextbox();
            fillgrid();
            clearallfields();
        }

        private void clearallfields()
        {
            txt_GirviNo.ResetText();
            lblsrno.ResetText();
            Cmb_ItemType.ResetText();
            txt_GrossWt.ResetText();
            txt_ReduceWt.ResetText();
            txt_NetWeight.ResetText();
            txt_WtInPercent.ResetText();
            txt_FineWt.ResetText();
            txt_Quantity.Text = "1";
            txt_CurrentRate.ResetText();
            txt_Amount.ResetText();
            Cmb_MetalType.SelectedIndex = -1;

        }
       
        private void fillgrid()
        {
            dgv_ItemDetail.Rows.Clear();
            DataTable dt = _objGirviUpdate.getallgirviitems(GirviNo);
            int q = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                dgv_ItemDetail.Rows.Add(dt.Rows[q]["GirviNo"].ToString(), dt.Rows[q]["ID"].ToString(), dt.Rows[q]["metal_type"].ToString(), dt.Rows[q]["item_type"].ToString(), dt.Rows[q]["gross_wt"].ToString(), dt.Rows[q]["reduce_wt"].ToString(), dt.Rows[q]["net_wt"].ToString(), dt.Rows[q]["wt_in_percent"].ToString(), dt.Rows[q]["fine_wt"].ToString(), dt.Rows[q]["Total_Quantity"].ToString(), dt.Rows[q]["current_rate"].ToString(), dt.Rows[q]["amount"].ToString());
              
            }
           
        }
    
           
        

        private void filltextbox()
        {
            AutoCompleteStringCollection itemtype = new AutoCompleteStringCollection();
            DataTable d2 = _objGirviUpdate.returnitemtype();
            for (int i = 0; i < d2.Rows.Count; i++)
            {
                itemtype.Add(Convert.ToString(d2.Rows[i][0]));
            }

            Cmb_ItemType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cmb_ItemType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Cmb_ItemType.AutoCompleteCustomSource = itemtype;
        }

        private void dgv_ItemDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    SendKeys.Send("^(2)");
                    int ind = dgv_ItemDetail.CurrentCell.RowIndex;
                    if (dgv_ItemDetail.Rows[ind].Cells[0].Value != null)
                    {
                        txt_GirviNo.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["InvoiceNo"].Value);

                        Cmb_ItemType.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["ItemType"].Value);

                    
                        Cmb_MetalType.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["MetalType"].Value);
                        txt_GrossWt.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["GrossWt"].Value);
                        txt_ReduceWt.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["ReduceWt"].Value);
                        txt_NetWeight.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["FinalWt"].Value);
                        txt_FineWt.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["FinalWt"].Value);
                        txt_WtInPercent.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["FinalWtInPer"].Value);
                        txt_FineWt.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["FineWt"].Value);

                        txt_Quantity.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["Quantity"].Value);
                        lblsrno.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["ID"].Value);
                        txt_CurrentRate.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["CurrentPrice"].Value);
                        txt_Amount.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["TotalAmount"].Value);
                        bttn_Update.Enabled = true;
                       
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            if (check())
            {

                _objGirviUpdate.updateGirviItemsDelete(lblsrno.Text,Cmb_MetalType.Text, Cmb_ItemType.Text, txt_GrossWt.Text, txt_NetWeight.Text, txt_Quantity.Text,txt_ReduceWt.Text, txt_WtInPercent.Text, txt_FineWt.Text, txt_CurrentRate.Text, txt_Amount.Text);
                MessageBox.Show("Items Updated");
                fillgrid();
                clearallfields();


            }
            else
            {
                MessageBox.Show("Please Enter Each Data");

            }
        }

        private bool check()
        {
            if (txt_Amount.Text != "" && txt_CurrentRate.Text != "" && txt_Quantity.Text != "" && txt_FineWt.Text != "" && txt_WtInPercent.Text != "" && txt_NetWeight.Text != "" && txt_ReduceWt.Text != "" && txt_GrossWt.Text != "" && txt_GirviNo.Text != "" && lblsrno.Text != "" && Cmb_MetalType.Text != "" &&  Cmb_ItemType.Text != "")
            {
                return true;

            }
            return false;
        }

        private void txt_GrossWt_TextChanged(object sender, EventArgs e)
        {
            CalculateItemInfo();
        }

        private void CalculateItemInfo()
        {
            DataTable dtItemInfo = _objCommon.CalculationForItemInfoGroupGirvi(txt_GrossWt.Text, txt_ReduceWt.Text, txt_WtInPercent.Text, txt_CurrentRate.Text, "0", "0");
            txt_NetWeight.Text = dtItemInfo.Rows[0]["FinalWt"].ToString();
            txt_FineWt.Text = dtItemInfo.Rows[0]["FineWt"].ToString();
            txt_Amount.Text = Math.Round(Convert.ToDouble(dtItemInfo.Rows[0]["TotalFineAmount"].ToString())).ToString();
        }

        private void txt_ReduceWt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateItemInfo();
            }
            catch { }
        }

        private void txt_WtInPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateItemInfo();
            }
            catch { }
        }

        private void txt_CurrentRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateItemInfo();
            }
            catch { }
            try
            {

                if (txt_CurrentRate.Text != " ")
                {
                    txt_Amount.Text = (Convert.ToDecimal(txt_CurrentRate.Text) * Convert.ToDecimal(txt_FineWt.Text)).ToString("#,##0");
                }
                else
                {
                    txt_Amount.Text = "";
                }
            }
            catch (Exception ex)
            { }
        }

        private void Cmb_MetalType_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpalValidation.ValidationCharOnly(e);
        }

        private void txt_ItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            //_objSimpalValidation.ValidationCharDigitOnly(e);
        }

        private void txt_GrossWt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpalValidation.ValidationDigitWithPoint(e, txt_GrossWt.Text);
        }

        private void txt_ReduceWt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpalValidation.ValidationDigitWithPoint(e, txt_ReduceWt.Text);
             
        }

        private void txt_NetWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpalValidation.ValidationDigitWithPoint(e, txt_NetWeight.Text);

        }

        private void txt_WtInPercent_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_WtInPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpalValidation.ValidationDigitWithPoint(e, txt_WtInPercent.Text);

        }

        private void txt_FineWt_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_FineWt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpalValidation.ValidationDigitWithPoint(e, txt_FineWt.Text);
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpalValidation.ValidationDigitWithPoint(e, txt_Quantity.Text);
        }

        private void txt_CurrentRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpalValidation.ValidationDigitWithPoint(e, txt_CurrentRate.Text);
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpalValidation.ValidationDigitWithPoint(e, txt_Amount.Text);
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int sizetext = 12;
                dgv_ItemDetail.Columns["InvoiceNo"].HeaderText = "गाहणी क्रमांक";
                dgv_ItemDetail.Columns["MetalType"].HeaderText = "मेटल टाईप";
                //dgv_ItemDetail.Columns["MetalId"].HeaderText = "मेटल आइडी";
                dgv_ItemDetail.Columns["ItemType"].HeaderText = "आयटम टाईप";
                dgv_ItemDetail.Columns["GrossWt"].HeaderText = "ग्रॉस वजन";
                dgv_ItemDetail.Columns["ReduceWt"].HeaderText = "घट वजन";
                dgv_ItemDetail.Columns["FinalWt"].HeaderText = "नेट वजन";
                dgv_ItemDetail.Columns["FinalWtInPer"].HeaderText = "वजन टक्के";
                dgv_ItemDetail.Columns["FineWt"].HeaderText = "फाईन वजन";
                dgv_ItemDetail.Columns["Quantity"].HeaderText = "प्रमाण";
                dgv_ItemDetail.Columns["CurrentPrice"].HeaderText = "चालू दर";
                dgv_ItemDetail.Columns["TotalAmount"].HeaderText = "रक्कम";

                lbl_MetalType.Text = "मेटल प्रकार";
                lbl_MetalType.Font = new Font("Arial", sizetext);
                lbl_ItemType.Text = "आयटम प्रकार";
                lbl_ItemType.Font = new Font("Arial", sizetext);
                lbl_GrossWt.Text = "ग्रॉस वजन";
                lbl_GrossWt.Font = new Font("Arial", sizetext);
                lbl_NetWt.Text = "नेट वजन";
                lbl_NetWt.Font = new Font("Arial", sizetext);
                lbl_ReduceWt.Text = " घट वजन";
                lbl_ReduceWt.Font = new Font("Arial", sizetext);
                lbl_WtInPercent.Text = "वजन टक्के";
                lbl_WtInPercent.Font = new Font("Arial", sizetext);
                lbl_FineWt.Text = "फाईन वजन";
                lbl_FineWt.Font = new Font("Arial", sizetext);
                lbl_TotalAmount.Text = " रक्कम ";
                lbl_TotalAmount.Font = new Font("Arial", sizetext);
                lbl_CurrentPrice.Text = "  चालू दर";
                lbl_CurrentPrice.Font = new Font("Arial", sizetext);
            }
            catch { }
        }

        private void dgv_ItemDetail_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void txt_GirviNo_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void frm_UpdatedGirviItem_KeyDown(object sender, KeyEventArgs e)
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

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            txt_Amount.ResetText();
            txt_CurrentRate.ResetText();
            txt_FineWt.ResetText();
            txt_GrossWt.ResetText();
            Cmb_ItemType.ResetText();
            txt_NetWeight.ResetText();
            txt_Quantity.ResetText();
            txt_ReduceWt.ResetText();
            txt_WtInPercent.ResetText();
            Cmb_MetalType.ResetText();
            


        }

        private void txt_ItemType_Enter_1(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
        }
    }
}
