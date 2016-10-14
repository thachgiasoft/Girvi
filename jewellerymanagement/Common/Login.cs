using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using System.Threading;
using BAL.Common;
namespace JewelleryManagement.Common
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public delegate void SendData(string Result);
     
        public bool result { get; set; }
       LoginBAL _objLoginBAl = new LoginBAL();
       Validation _objValidation = new Validation();
        private void bttn_login_Click(object sender, EventArgs e)
        {
            
            
            txt_pass.Focus();
           
           

        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           // this.Icon = new Icon(Application.StartupPath + "\\diamond.ico");
            txt_user.Select();
            Boolean CheckDate;
            //KeyGen oKeyGen = new KeyGen();
            //try
            //{
            //    CheckDate = oKeyGen.authontic();
            //    if (CheckDate == false)
            //    {
            //        System.Windows.Forms.MessageBox.Show("Limit Expire! Contact Person Appsthentic .Rohit No-7776801113");
            //        Application.Exit();
            //    }
            //}
            //catch (Exception ex)

            //{ }

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_login_Click(sender ,e);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
            if (e.KeyCode == Keys.Enter)
            {
                txt_pass.Select();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                bttn_ok.Focus();
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login y = new Login();
            if (_objValidation.IsNotEmpty(txt_user.Text) && _objValidation.IsNotEmpty(txt_pass.Text))
            {
                if (_objLoginBAl.login(txt_user.Text, txt_pass.Text))
                {

                 
                    result = true;

                    this.Close();
                  
                }

                else
                {
                    MessageBox.Show("Incorrect ID or Password", "JMS Says ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_user.Text = "";
                    txt_pass.Text = "";
                    txt_user.Focus();


                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct ID or Password", "JMS Says ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_ok.Focus();
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       



        
    }
}
