using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JewelleryManagement.DataBaseForms
{
    public partial class Frm_DeveloperLogin : Form
    {
        public bool Developer_login_Result { get; set; }
        public Frm_DeveloperLogin()
        {
            InitializeComponent();
            Developer_login_Result = false;
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Lalit@apps")
            {
                Developer_login_Result = true;
                this.Close();
            }
            else
            {
                Developer_login_Result = false;
                this.Close();
            }
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            Developer_login_Result = false;
            this.Close();
        }

        private void Frm_DeveloperLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
