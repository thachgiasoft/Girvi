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

namespace JewelleryManagement.Girvi
{
    public partial class frm_Password : Form
    {
        public frm_Password()
        {
            InitializeComponent();
        }
        Validation _objValidation = new Validation();
        cls_Login _objLogin = new cls_Login();

        private void bttn_Ok_Click(object sender, EventArgs e)
        {
            if (_objValidation.IsNotEmpty(txt_Password.Text))
            {
                if (_objLogin.loginsss(txt_Password.Text))
                {
                    // MessageBox.Show("Login Successfull", "JMS Says", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    this.DialogResult = DialogResult.OK;

                }

                else
                {
                    MessageBox.Show("Wrong Password", "JMS Says ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_Password.Text = "";


                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct ID or Password", "JMS Says ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            txt_Password.Text = "";
            txt_Password.Focus();
        }

        private void frm_Password_Load(object sender, EventArgs e)
        {
            txt_Password.ResetText();
            txt_Password.Select();

        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_login.Focus();
            }
        }

        private void frm_Password_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)"); 
        }
    }
}
