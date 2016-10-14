using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Girvi;

namespace JewelleryManagement.Girvi
{
    public partial class Frm_CasteMaster : Form
    {
        Cls_CastMaster _objCasteMaste = new Cls_CastMaster();
        public Frm_CasteMaster()
        {
            InitializeComponent();
        }

        private void Frm_CasteMaster_Load(object sender, EventArgs e)
        {
            MasterClear();
        }

        private void MasterClear()
        {
            txt_Caste.ResetText();
            FillGrid();
        }

        private void FillGrid()
        {
            dgv_CasteDetail.Rows.Clear();
            DataTable dtCaste = _objCasteMaste.getAllCaste();
            for (int i = 0; i < dtCaste.Rows.Count;i++ )
            {
                dgv_CasteDetail.Rows.Add();
                dgv_CasteDetail.Rows[i].Cells["Id"].Value = dtCaste.Rows[i]["Id"].ToString();
                dgv_CasteDetail.Rows[i].Cells["Caste"].Value = dtCaste.Rows[i]["Caste"].ToString();
                dgv_CasteDetail.Rows[i].Cells["SrNo"].Value = i+1;

            }
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            _objCasteMaste.addCaste(txt_Caste.Text);
            MasterClear();
        }

        private void bttn_update_Click(object sender, EventArgs e)
        {
            _objCasteMaste.updateCaste(txt_Caste.Text, dgv_CasteDetail.Rows[dgv_CasteDetail.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
            MasterClear();
        } 

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            _objCasteMaste.deleteCaste(dgv_CasteDetail.Rows[dgv_CasteDetail.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
            MasterClear();

        }

        private void dgv_CasteDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Caste.Text = dgv_CasteDetail.Rows[dgv_CasteDetail.CurrentCell.RowIndex].Cells["Caste"].Value.ToString();
        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            MasterClear();
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_CasteMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Escape)
                this.Close();
        }
    }
}
