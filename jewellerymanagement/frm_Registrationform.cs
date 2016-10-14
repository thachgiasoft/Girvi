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

namespace JewelleryManagement
{
    public partial class frm_Registrationform : Form
    {
        public frm_Registrationform()
        {
            InitializeComponent();
        }
        Validation _objValidation = new Validation();
        LoginBAL _objLoginBAl = new LoginBAL();
        public bool result { get; set; }
      

        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Password.Focus();
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_confirmpaasword.Focus();
            }
        }

        private void txt_companyid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CompanyName.Focus();
            }
        }

        private void txt_CompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Addressline1.Focus();
            }
        }

        private void txt_Addressline1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Addressline2.Focus();
            }
        }

        private void txt_Addressline2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_City.Focus();
            }
        }

        private void txt_City_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_phoneNo.Focus();
            }
        }

        private void txt_phoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_MobNo.Focus();
            }
        }

        private void txt_MobNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_MobNo2.Focus();
            }
        }

        private void txt_MobNo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Antargat.Focus();
            }
        }

        private void txt_Antargat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_LicenceNo.Focus();
            }
        }

        private void txt_LicenceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Register.Focus();
            }
        }

        private void bttn_Register_Click(object sender, EventArgs e)
        {
           

            if (_objValidation.IsNotEmpty(txt_UserName.Text) && _objValidation.IsNotEmpty(txt_Password.Text)  && _objValidation.IsNotEmpty(txt_CompanyName.Text) && _objValidation.IsNotEmpty(txt_Addressline1.Text) && _objValidation.IsNotEmpty(txt_City.Text))
            {
                if(txt_Password.Text == txt_confirmpaasword.Text)
                {
                _objLoginBAl.addLogin(txt_UserName.Text, txt_Password.Text);
                _objLoginBAl.addCompanyDetails( txt_CompanyName.Text, txt_Addressline1.Text, txt_Addressline2.Text, txt_City.Text, txt_phoneNo.Text, txt_MobNo.Text, txt_MobNo2.Text, txt_Antargat.Text, txt_LicenceNo.Text, txt_pincode.Text, txt_Tahsli.Text, txt_district.Text, txt_state.Text);
                MessageBox.Show("Registration successful");
                MasterClear();
                }
                else
                {
                    MessageBox.Show("Password not match Confirm Password", "JMS Says ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

              
            }
            else
            {
                MessageBox.Show("Please Enter all Manditory Fields", "JMS Says ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void MasterClear()
        {
            txt_UserName.ResetText();
            txt_Password.ResetText();
            txt_confirmpaasword.ResetText();
            txt_CompanyName.ResetText();
            txt_Addressline1.ResetText();
            txt_Addressline2.ResetText();
            txt_City.ResetText();
            txt_phoneNo.ResetText();
            txt_MobNo.ResetText();
            txt_MobNo2.ResetText();
            txt_Antargat.ResetText();
            txt_LicenceNo.ResetText();
            txt_pincode.ResetText();
            txt_Tahsli.ResetText();
            txt_district.ResetText();
            txt_state.ResetText();

           
        }
            

        private void frm_Ragistrationform_Load(object sender, EventArgs e)
        {
           

        }

        private void txt_confirmpaasword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CompanyName.Focus();
            }
        }

        private void txt_Antargat_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_LicenceNo.Focus();
            }
        }

        private void txt_LicenceNo_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pincode.Focus();
            }
        }

        private void txt_pincode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Tahsli.Focus();
            }
        }

        private void txt_Tahsli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_district.Focus();
            }
        }

        private void txt_district_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_state.Focus();
            }
        }

        private void txt_state_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Register.Focus();
            }
        }
    }
}
