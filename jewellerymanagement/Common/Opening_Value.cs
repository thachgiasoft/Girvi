using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;

namespace JewelleryManagement.Common
{
    public partial class Opening_Value : Form
    {
        public Opening_Value()
        {
            InitializeComponent();
        }
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
       
        private void bttn_bhandwal_Click(object sender, EventArgs e)
        {
            try
            {
                _objGirviCommon.addOpeningBhandwav(txt_openingValue.Text, dateTimePicker_Opening.Text);
                MessageBox.Show("Opening Value Added");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_openingValue_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }
    }
}
