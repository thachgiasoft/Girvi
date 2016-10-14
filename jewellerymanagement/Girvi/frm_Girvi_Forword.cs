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
using BAL.Girvi;

namespace JewelleryManagement.Girvi
{
    public partial class frm_GirviForword : Form
    {
        public frm_GirviForword()
        {
            InitializeComponent();
        }

        Simplevalidations _objSimplevalidations = new Simplevalidations();
       cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
       
        private void bttn_Forword_Click(object sender, EventArgs e)
        {
            try
            {
                _objGirviAdd.addforworddetail(txt_GirviNo.Text, txt_Name.Text, dtp_Date.Text, txt_AmountNo.Text, txt_ContactNo.Text, txt_bankinterest.Text);
                MessageBox.Show("Data Forwarded");
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txt_GirviNo.ResetText();
            txt_Name.ResetText();
            dtp_Date.ResetText();
            txt_AmountNo.ResetText();
            txt_ContactNo.ResetText();
        }

        private void txt_GirviNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Name.Focus();
            }
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_Date.Focus();
            }
        }

        private void dtp_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_AmountNo.Focus();
            }
        }

        private void txt_AmountNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ContactNo.Focus();
            }

        }

        private void txt_GirviNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

       
        private void txt_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_GirviForword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txt_ContactNo_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }

        private void txt_Name_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Date_Click(object sender, EventArgs e)
        {

        }

        private void frm_GirviForword_Load(object sender, EventArgs e)
        {
            txt_bankinterest.Text = "11";
        }

      
      

    }
}