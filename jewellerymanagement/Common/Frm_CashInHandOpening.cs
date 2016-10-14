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
    public partial class Frm_CashInHandOpening : Form
    {
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        public Frm_CashInHandOpening()
        {
            InitializeComponent();
        }

        private void bttn_UpdateRecord_Click(object sender, EventArgs e)
        {
            _objGirviCommon.updateOpeningBal(txt_OpeningBal.Text,dtp_Date.Text);
        }
    }
}
