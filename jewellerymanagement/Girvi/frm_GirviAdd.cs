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
using JewelleryManagement.CrystalReport;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;


namespace JewelleryManagement.Girvi
{
    public partial class frm_GirviAdd : Form
    {
        string ProfilePhoto;
       // string filkepath;
        string fileName;
        string ImagesSave;
        internal System.Windows.Forms.ComboBox ComboBox1;
        private string[] animals;
        byte[] big;
        public static int durationDate { get; set; }
        public frm_GirviAdd()
        {
            InitializeComponent();

            this.ComboBox1 = new ComboBox();
            this.ComboBox1.DrawMode =
                System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox1.Location = new System.Drawing.Point(10, 20);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(100, 120);
            this.ComboBox1.DropDownWidth = 250;
            this.ComboBox1.TabIndex = 0;
            this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            animals = new string[] { "Elephant", "c r o c o d i l e", "lion" };
            ComboBox1.DataSource = animals;
            this.Controls.Add(this.ComboBox1);

            // Hook up the MeasureItem and DrawItem events
            this.ComboBox1.DrawItem +=
                new DrawItemEventHandler(ComboBox1_DrawItem);
            this.ComboBox1.MeasureItem +=
                new MeasureItemEventHandler(ComboBox1_MeasureItem);
        }
        public delegate void SendData(string BillNO, string AccNo, string otherFont, string PrinterName);

        Simplevalidations _objSimplevalidations = new Simplevalidations();
        clsCommon _objCommon = new clsCommon();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsAddress _objAdress = new clsAddress();
        ClsFinancialYear _objFinancialYear = new ClsFinancialYear();
        cls_GirviAdd _objGirviAdd = new cls_GirviAdd();
        Cls_CastMaster _objCaste = new Cls_CastMaster();
        Validation _objValidation = new Validation();
        cls_Bhandval _objBhandval = new cls_Bhandval();
        cls_GirviRelease _objGirviRelease = new cls_GirviRelease();
        string AccNo, Occupation, CustName;
        public string ProfilePic, Document1, Documennt2, Document3, KhatawanoNo;


        private void ComboBox1_MeasureItem(object sender,
    System.Windows.Forms.MeasureItemEventArgs e)
        {

            switch (e.Index)
            {
                case 0:
                    e.ItemHeight = 45;
                    break;
                case 1:
                    e.ItemHeight = 20;
                    break;
                case 2:
                    e.ItemHeight = 35;
                    break;
            }
            e.ItemWidth = 260;

        }

        private void ComboBox1_DrawItem(object sender,
    System.Windows.Forms.DrawItemEventArgs e)
        {

            float size = 0;
            System.Drawing.Font myFont;
            FontFamily family = null;

            System.Drawing.Color animalColor = new System.Drawing.Color();
            switch (e.Index)
            {
                case 0:
                    size = 30;
                    animalColor = System.Drawing.Color.Gray;
                    family = FontFamily.GenericSansSerif;
                    break;
                case 1:
                    size = 10;
                    animalColor = System.Drawing.Color.LawnGreen;
                    family = FontFamily.GenericMonospace;
                    break;
                case 2:
                    size = 15;
                    animalColor = System.Drawing.Color.Tan;
                    family = FontFamily.GenericSansSerif;
                    break;
            }

            // Draw the background of the item.
            e.DrawBackground();

            // Create a square filled with the animals color. Vary the size
            // of the rectangle based on the length of the animals name.
            Rectangle rectangle = new Rectangle(2, e.Bounds.Top + 2,
                    e.Bounds.Height, e.Bounds.Height - 4);
            e.Graphics.FillRectangle(new SolidBrush(animalColor), rectangle);

            // Draw each string in the array, using a different size, color,
            // and font for each item.
            myFont = new Font(family, size, FontStyle.Bold);
            e.Graphics.DrawString(animals[e.Index], myFont, System.Drawing.Brushes.Black, new RectangleF(e.Bounds.X + rectangle.Width, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

            // Draw the focus rectangle if the mouse hovers over an item.
            e.DrawFocusRectangle();
        }

        DataTable dt;
        private void CalculationItemInfo()
        {
            DataTable dtItemInfo = _objCommon.CalculationForItemInfoGroupGirvi(txt_GrossWt.Text, txt_ReduceWt.Text, txt_FinalWtInPercent.Text, txt_CurrentPrice.Text, "0", "0");
            txt_FinalWt.Text = dtItemInfo.Rows[0]["FinalWt"].ToString();
            txt_FineWt.Text = dtItemInfo.Rows[0]["FineWt"].ToString();
            txt_TotalAmount.Text = Math.Round(Convert.ToDouble(dtItemInfo.Rows[0]["TotalFineAmount"].ToString())).ToString();
        }


        private bool checkblanks()
        {
            int checkblanks = 0;

            if (Cmb_MetalType.Text == "")
            {
                checkblanks = 1;
                lbl_MetalType.ForeColor = Color.Red;
            }
            if (Cmb_ItemType.Text == "")
            {
                checkblanks = 1;
                lbl_ItemType.ForeColor = Color.Red;
            }
            if (txt_GrossWt.Text == "")
            {
                checkblanks = 1;
                lbl_GrossWt.ForeColor = Color.Red;
            }
            if (txt_ReduceWt.Text == "")
            
            {
                checkblanks = 1;
                lbl_ReduceWt.ForeColor = Color.Red;
            }
            if (txt_FinalWt.Text == "")
            {
                checkblanks = 1;
                lbl_FinalWt.ForeColor = Color.Red;
            }
            if (txt_FinalWtInPercent.Text == "")
            {
                checkblanks = 1;
                lbl_FinalWtInPercent.ForeColor = Color.Red;
            }
            if (txt_FineWt.Text == "")
            {
                checkblanks = 1;
                lbl_FineWt.ForeColor = Color.Red;
            }
            if (txt_Quantity.Text == "")
            {
                checkblanks = 1;
                lbl_Quantity.ForeColor = Color.Red;
            }
            if (txt_CurrentPrice.Text == "")
            {
                checkblanks = 1;
                lbl_CurrentPrice.ForeColor = Color.Red;
            }
            if (txt_TotalAmount.Text == "")
            {
                checkblanks = 1;
                lbl_TotalAmount.ForeColor = Color.Red;
            }

            if (checkblanks == 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }



        private void masterclear()
        {
            griddesign();
            filltextbox();
            clearall();
            HideFn();

        }

        private void griddesign()
        {
            dgv_ItemDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 132, 153);
            dgv_ItemDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_ItemDetail.EnableHeadersVisualStyles = false;
            dgv_ItemDetail.RowsDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold);
            dgv_ItemDetail.RowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgv_ItemDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(70, 132, 153);
            dgv_ItemDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_ItemDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_GirviDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 132, 153);
            dgv_GirviDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_GirviDetail.EnableHeadersVisualStyles = false;
            dgv_GirviDetail.RowsDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold);
            dgv_GirviDetail.RowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgv_GirviDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(70, 132, 153);
            dgv_GirviDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_GirviDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void filltextbox()
        {
            //cmb_FullName.DataSource = _objGirviAdd.getFName();
            cmb_Address.DataSource = _objAdress.getAddress();
            cmb_Address.DataSource = _objGirviAdd.getAddress();
            cmb_Post.DataSource = _objGirviAdd.getCity();
            Cmb_Tahsil.DataSource = _objGirviAdd.getTahsil();
            cmb_District.DataSource = _objGirviAdd.getDistrict();
            cmb_PoliceStation.DataSource = _objGirviAdd.getPoliceStation();
            Cmb_ItemType.DataSource = _objGirviAdd.getItemtype();
            cmb_Cast.DataSource = _objCaste.getAllCaste();

            if (rbt_PavtiNoYes.Checked == true)
            {
                string receipt_no = _objGirviAdd.getReceiptNo("GRT-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "%");
                txt_ReceiptNo.Text = "GRT-" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["startyear"].ToString().Substring(8) + "/" + _objFinancialYear.getSelectedFinancialYear().Rows[0]["endyear"].ToString().Substring(8) + "-" + receipt_no;
                txt_ReceiptNo.Enabled = false;
            }

            AutoCompleteStringCollection khatawanino = new AutoCompleteStringCollection();

            DataTable dt_Khatawani = null;


            dt_Khatawani = _objGirviAdd.getKhatawani();


            for (int i = 0; i < dt_Khatawani.Rows.Count; i++)
            {
                khatawanino.Add(Convert.ToString(dt_Khatawani.Rows[i][0]));
            }

            txt_KhatawaniNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_KhatawaniNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_KhatawaniNo.AutoCompleteCustomSource = khatawanino;
            cmb_FullName.SelectedIndex = -1;
            cmb_Address.SelectedIndex = -1;
            cmb_Post.SelectedIndex = -1;
            Cmb_ItemType.SelectedIndex = -1;
            cmb_Cast.SelectedIndex = -1;
        }

        private void clearall()
        {
           
           
            cmb_FullName.ResetText();
            CustName = "";
            txt_MobileNo.ResetText();
            rbt_Krushi.Checked = false;
            rbt_Krushiuttar.Checked = false;
            if (rbt_pavtinoNo.Checked == true)
            {
                txt_ReceiptNo.ResetText();
                txt_ReceiptNo.Enabled = true;
            }
            //ProfilePhoto = "";
            //Documennt2 = "";
            //Document1 = "";
            //Document3 = "";

            dtp_DateOfDeposit.ResetText();
            txt_GrossWt.ResetText();
            txt_ReduceWt.Text = "0";
            txt_FinalWt.ResetText();
            txt_FinalWtInPercent.Text = "100";
            txt_FineWt.ResetText();
            txt_CurrentPrice.ResetText();
            // dtp_Duration.ResetText();
            txt_FinalAmount.ResetText();
            txt_TotalAmount.ResetText();
            txt_EstimateInPer.Text = "75";
            DataTable dtinterest = _objCommon.getRates();
            txt_InterestInPer.Text = dtinterest.Rows[0]["interest"].ToString();
            txt_LoanAmount.ResetText();
            lbl_Data.Text = "व्याज दर प्रती वर्षाप्रमाने टाका";
            cmb_Address.SelectedIndex = -1;
            cmb_Post.SelectedIndex = -1;
            cmb_Cast.SelectedIndex = -1;
            cmb_LoanReason.SelectedIndex = -1;
            cmb_LoanType.Text = "तारण";
            Cmb_MetalType.SelectedIndex = -1;
            Cmb_ItemType.ResetText();
            dgv_ItemDetail.Rows.Clear();
            dgv_GirviDetail.Rows.Clear();
            txt_KhatawaniNo.Text = _objGirviAdd.get_KhatawaniNo();
            txt_InvoiceNo.Text = _objGirviAdd.get_InvoiceNo();
            txt_Quantity.Text = "1";
            cmb_Address.ResetText();
            cmb_Post.ResetText();
            Cmb_MetalType.Text = "सोना";
            cmb_FullName.Select();
            PerAmount.Text = "0";
            pcbx_Photo.ImageLocation="";
            cmb_PoliceStation.ResetText();
            Cmb_Tahsil.ResetText();
            cmb_District.ResetText();
            txt_Narration.ResetText();


        }

        public void setdate()
        {
            DataTable dt = new DataTable();
            dt = _objGirviCommon.getduration();
            // dtp_Duration.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //dtp_DateOfDeposit.Text = DateTime.Now.ToString("dd/MM/yyyy");
            durationDate = (Convert.ToInt32(dt.Rows[0]["Duration"].ToString()));
            dtp_Duration.Value = dtp_DateOfDeposit.Value.AddMonths(durationDate);
        }

        private void clearallwithoutname()
        {
           // lbl_OpeningBalance.Text = _objGirviCommon.getOpeningBalance();
            //cmb_FullName.ResetText();
            txt_MobileNo.ResetText();
            rbt_Krushi.Checked = false;
            rbt_Krushiuttar.Checked = false;
            if (rbt_pavtinoNo.Checked == true)
            {
                txt_ReceiptNo.ResetText();
                txt_ReceiptNo.Enabled = true;

            }

            //dtp_DateOfDeposit.ResetText();
            txt_GrossWt.ResetText();
            ProfilePhoto = "";
            Documennt2 = "";
            Document1 = "";
            Document3 = "";
            txt_ReduceWt.Text = "0";
            txt_FinalWt.ResetText();
            txt_FinalWtInPercent.Text = "100";
            txt_FineWt.ResetText();
            txt_CurrentPrice.ResetText();
          //  dtp_Duration.ResetText();
            txt_FinalAmount.ResetText();
            txt_TotalAmount.ResetText();
            txt_EstimateInPer.Text = "75";
            DataTable dtinterest = _objCommon.getRates();
            txt_InterestInPer.Text = dtinterest.Rows[0]["interest"].ToString();
            txt_LoanAmount.ResetText();
            lbl_Data.Text = "व्याज दर प्रती वर्षाप्रमाने टाका";
            cmb_Address.SelectedIndex = -1;
            cmb_Post.SelectedIndex = -1;
            cmb_Cast.SelectedIndex = -1;
            cmb_LoanReason.SelectedIndex = -1;
            cmb_LoanType.Text = "तारण";
            Cmb_MetalType.SelectedIndex = -1;
            Cmb_ItemType.ResetText();
            dgv_ItemDetail.Rows.Clear();
            dgv_GirviDetail.Rows.Clear();
            txt_KhatawaniNo.Text = _objGirviAdd.get_KhatawaniNo();
            txt_InvoiceNo.Text = _objGirviAdd.get_InvoiceNo();
            txt_Quantity.Text = "1";
            cmb_Address.ResetText();
            cmb_Post.ResetText();

        }

        #region keydown




        private void cmb_Cast_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (txt_ReceiptNo.Text == "")
            {

                if (e.KeyCode == Keys.Enter)
                {
                    txt_ReceiptNo.Focus();
                }
                if (e.KeyCode == Keys.Left && e.Alt)
                {
                    rbt_Krushiuttar.Focus();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtp_DateOfDeposit.Focus();
                }
                if (e.KeyCode == Keys.Left && e.Alt)
                {
                    rbt_Krushiuttar.Focus();
                }
            }

        }

        private void txt_ReceiptNo_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_DateOfDeposit.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                cmb_Cast.Focus();
            }
        }

        private void dtp_DateOfDeposit_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_Duration.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_ReceiptNo.Focus();
            }

        }

        private void cmb_LoanType_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cmb_MetalType.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                dtp_DateOfDeposit.Focus();
            }
        }

        private void cmb_LoanReason_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_LoanType.Focus();

            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                cmb_LoanReason.Focus();
            }
        }

        private void Cmb_MetalType_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cmb_ItemType.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                cmb_LoanReason.Focus();
            }
        }

        private void Cmb_ItemType_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_GrossWt.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                Cmb_MetalType.Focus();
            }
        }

        private void txt_GrossWt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ReduceWt.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                Cmb_ItemType.Focus();
            }
        }

        private void txt_ReduceWt_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_FinalWt.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_GrossWt.Focus();
            }
        }

        private void txt_FinalWt_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_FinalWtInPercent.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {

                txt_ReduceWt.Focus();
            }
        }

        private void txt_FinalWtInPercent_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_FineWt.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_FinalWt.Focus();
            }
        }

        private void txt_FineWt_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Quantity.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_FinalWtInPercent.Focus();
            }
        }

        private void txt_Quantity_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CurrentPrice.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_FineWt.Focus();
            }
        }

        private void txt_CurrentPrice_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_TotalAmount.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_Quantity.Focus();
            }
        }

        private void txt_TotalAmount_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add.Focus();

            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_CurrentPrice.Focus();
            }
        }

        #endregion

        private void txt_GrossWt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculationItemInfo();
            }
            catch { }
        }

        private void txt_ReduceWt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculationItemInfo();
            }
            catch { }
        }

        private void txt_FinalWtInPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculationItemInfo();
            }
            catch { }
        }

        private void txt_CurrentPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculationItemInfo();
            }
            catch { }
            try
            {

                if (txt_CurrentPrice.Text != " ")
                {
                    txt_TotalAmount.Text = (Convert.ToDecimal(txt_CurrentPrice.Text) * Convert.ToDecimal(txt_FineWt.Text)).ToString("#,##0");
                }
                else
                {
                    txt_TotalAmount.Text = "";
                }
            }
            catch (Exception ex)
            { }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            string amount = txt_TotalAmount.Text.Replace(",", "");
            if (checkblanks())
            {
                try
                {


                    dgv_ItemDetail.Rows.Add(txt_InvoiceNo.Text, Cmb_MetalType.Text, Cmb_MetalType.SelectedValue, Cmb_ItemType.Text, txt_GrossWt.Text, txt_ReduceWt.Text, txt_FinalWt.Text, txt_FinalWtInPercent.Text, txt_FineWt.Text, txt_Quantity.Text, txt_CurrentPrice.Text, txt_TotalAmount.Text);
                    gettotalvalues();
                    // bttn_ResetItemDetail_Click(this, new EventArgs());

                    txt_EstimateInPer.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Each Data");
            }
            clearItemDetail();
        }

        private void clearItemDetail()
        {
            Cmb_MetalType.SelectedIndex = -1;
            Cmb_ItemType.SelectedIndex = -1;

            txt_GrossWt.ResetText();
            txt_ReduceWt.Text = "0";
            txt_FinalWt.ResetText();
            txt_FinalWtInPercent.Text = "100";
            txt_FineWt.ResetText();
            txt_Quantity.Text = "1";
            txt_CurrentPrice.ResetText();
            txt_TotalAmount.ResetText();
            bttn_Add.Enabled = true;
        }






        private void cmb_Cast_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void txt_ReceiptNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void cmb_LoanType_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void cmb_LoanReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void Cmb_MetalType_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void Cmb_ItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            //   _objSimplevalidations.ValidationCharOnly(e);
        }

        private void txt_GrossWt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_GrossWt.Text);
        }

        private void txt_ReduceWt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_ReduceWt.Text);
        }

        private void txt_FinalWt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_FinalWt.Text);
        }

        private void txt_FinalWtInPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_FinalWtInPercent.Text);
        }

        private void txt_FineWt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_FineWt.Text);
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void txt_CurrentPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_CurrentPrice.Text);
        }

        private void txt_TotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_TotalAmount.Text);
        }

        private void dtp_DateOfDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }


        private void txt_TotalQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_FinalAmount.Text);
        }

        private void txt_EstimateInPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_EstimateInPer.Text);
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
                        txt_InvoiceNo.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["InvoiceNo"].Value);
                        Cmb_MetalType.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["MetalType"].Value);

                        Cmb_ItemType.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["ItemType"].Value);


                        txt_GrossWt.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["GrossWt"].Value);
                        txt_ReduceWt.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["ReduceWt"].Value);

                        txt_FinalWt.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["FinalWt"].Value);
                        txt_FinalWtInPercent.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["FinalWtInPer"].Value);
                        txt_FineWt.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["FineWt"].Value);

                        txt_Quantity.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["Quantity"].Value);
                        txt_CurrentPrice.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["CurrentPrice"].Value);
                        txt_TotalAmount.Text = Convert.ToString(dgv_ItemDetail.Rows[ind].Cells["TotalAmount"].Value);
                        bttn_Update.Enabled = true;
                        bttn_Delete.Enabled = true;
                        bttn_Add.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Address.Focus();
            }
        }

        private void frm_GirviAdd_Load(object sender, EventArgs e)
        {
            setdate();
            masterclear();
            SetFont();
            cmb_FullName.Select();
         
        }
        public void HideFn()
        {
            if (rbt_hide.Checked == true)
            {
                lbl_PoliceStation.Hide();
                cmb_PoliceStation.Hide();
                lbl_Tahsil.Hide();
                Cmb_Tahsil.Hide();
                lbl_District.Hide();
                cmb_District.Hide();
            }
           
        }

        public void ShivajiFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
            txt_KhatawaniNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_FullName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_Address.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_Post.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_MobileNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //cmb_Cast.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_InvoiceNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_LoanReason.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            cmb_LoanType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            Cmb_MetalType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            Cmb_ItemType.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_GrossWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_ReduceWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_FinalWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_FinalWtInPercent.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_FineWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_Quantity.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_ActualRate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_TotalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_FinalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_InterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_EstimateInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_LoanAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            // dtp_DateOfDeposit.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            // dtp_Duration.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            txt_CurrentPrice.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lst_FullName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

        }


        private void SetFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                ShivajiFont();
            }

        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            if (check())
            {

                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["MetalType"].Value = Cmb_MetalType.Text;
                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["Itemtype"].Value = Cmb_ItemType.Text;
                //  dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["specify"].Value = "";
                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["GrossWt"].Value = txt_GrossWt.Text;
                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["ReduceWt"].Value = txt_ReduceWt.Text;
                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["FinalWt"].Value = txt_FinalWt.Text;
                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["FinalWtInPer"].Value = txt_FinalWtInPercent.Text;
                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["FineWt"].Value = txt_FineWt.Text;
                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["CurrentPrice"].Value = txt_CurrentPrice.Text;
                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["TotalAmount"].Value = txt_TotalAmount.Text;
                dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentRow.Index].Cells["Quantity"].Value = txt_Quantity.Text;

                clear();
                gettotalvalues();


            }


        }

        private void clear()
        {
            Cmb_MetalType.ResetText();
            Cmb_ItemType.ResetText();
            txt_GrossWt.ResetText();
            txt_ReduceWt.ResetText();
            txt_FinalWt.ResetText();
            txt_FinalWtInPercent.ResetText();
            txt_FineWt.ResetText();
            txt_CurrentPrice.ResetText();
            txt_TotalAmount.ResetText();
            txt_Quantity.ResetText();

        }

        private bool check()
        {
            if (_objValidation.IsNotEmpty(Cmb_ItemType.Text))
            {

                if (_objValidation.IsNotEmpty(txt_GrossWt.Text))
                {

                    if (_objValidation.IsNotEmpty(txt_ReduceWt.Text))
                    {
                        if (_objValidation.IsNotEmpty(txt_FinalWt.Text))
                        {
                            if (_objValidation.IsNotEmpty(txt_FinalWtInPercent.Text))
                            {
                                if (_objValidation.IsNotEmpty(txt_FineWt.Text))
                                {
                                    if (_objValidation.IsNotEmpty(txt_CurrentPrice.Text))
                                    {
                                        if (_objValidation.IsNotEmpty(txt_TotalAmount.Text))
                                        {

                                            if (_objValidation.IsNotEmpty(txt_Quantity.Text))
                                            {
                                                { return true; }

                                            }
                                            else { return false; }


                                        }
                                        else { return false; }

                                    }
                                    else { return false; }
                                }
                                else { return false; }
                            }
                            else { return false; }
                        }
                        else { return false; }


                    }
                    else { return false; }


                }
                else { return false; }
            }
            else
            {

                return false;


            }
        }

        private void gettotalvalues()
        {
            //decimal sumgold = 0, sumsilver = 0;
            //for (int i = 0; i < dgv_ItemDetail.Rows.Count; ++i)
            //{
            //    if (dgv_ItemDetail.Rows[i].Cells["MetalId"].Value.ToString().TrimEnd() == "सोना")
            //    {
            //        sumgold += Convert.ToDecimal(dgv_ItemDetail.Rows[i].Cells["Finalwt"].Value);

            //    }
            //    else if (dgv_ItemDetail.Rows[i].Cells["MetalId"].Value.ToString().TrimEnd() == "चांदी")
            //    {
            //        sumsilver += Convert.ToDecimal(dgv_ItemDetail.Rows[i].Cells["Finalwt"].Value);

            //    }
            //}

            //decimal sumamount = 0, sum_making = 0;
            //for (int i = 0; i < dgv_ItemDetail.Rows.Count; ++i)
            //{
            //    sumamount += Convert.ToDecimal(dgv_ItemDetail.Rows[i].Cells["TotalAmount"].Value);
            //}




            ////for (int i = 0; i < dgv_ItemDetail.Rows.Count; ++i)
            ////{
            ////    sum_making += Convert.ToDecimal(dgv_ItemDetail.Rows[i].Cells["MakingCharges"].Value);
            ////}
            //txt_TotalAmount.Text = (sumamount + sum_making).ToString();

            double sumTotalAmount = _objCommon.sumGridViewColumn(dgv_ItemDetail, "TotalAmount");

            txt_FinalAmount.Text = sumTotalAmount.ToString();
        }

        private void bttn_ResetItemDetail_Click(object sender, EventArgs e)
        {
            clearReset();
        }

        private void clearReset()
        {
            Cmb_MetalType.ResetText();
            Cmb_ItemType.ResetText();
            txt_GrossWt.ResetText();
            txt_ReduceWt.Text = "0";
            txt_FinalWt.ResetText();
            txt_FinalWtInPercent.Text = "100";
            txt_FineWt.ResetText();
            txt_Quantity.Text = "1";
            txt_CurrentPrice.ResetText();
            txt_TotalAmount.ResetText();

        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_ItemDetail.Rows.RemoveAt(dgv_ItemDetail.CurrentCell.RowIndex);
                clearall();
                gettotalvalues();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable To Delete", "Jms says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_GirviAdd_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        private void cmb_FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void cmb_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Address.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_KhatawaniNo.Focus();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bttn_Save_Leave(object sender, EventArgs e)
        {
            cmb_FullName.Focus();
        }



        private bool checkdata()
        {
            int check_data = 0;
            string msg = null;

            if (cmb_FullName.Text == "")
            {
                check_data = 1;
                lbl_FullName.ForeColor = Color.Red;
            }

            if (txt_KhatawaniNo.Text == "")
            {
                check_data = 1;
                lbl_KhatawaniNo.ForeColor = Color.Red;
            }

            if (txt_LoanAmount.Text == "")
            {
                check_data = 1;
                lbl_LoanAmount.ForeColor = Color.Red;

            }

            if (txt_FinalAmount.Text == "")
            {
                check_data = 1;
                lbl_FinalAmount.ForeColor = Color.Red;
            }

            
            if (rbt_no2.Checked == true)
            {
                if (txt_ReceiptNo.Text != "")
                {
                    if (PavtiNoExits())
                    {
                        check_data = 1;
                        lbl_ReceiptNo.ForeColor = Color.Red;
                        msg = "Pavti No Repeted";
                    }
                }
            }

            if (txt_InvoiceNo.Text != "")
            {
                if (GirviNoExits())
                {
                    check_data = 1;
                    lbl_InvoiceNo.ForeColor = Color.Red;
                    msg = "Girvi No Repeted";
                }
            }
            if (dgv_ItemDetail.Rows.Count == 0)
            {
                check_data = 1;
                msg = "Add girvi items";

            }

            if (lbl_OpeningBalance.Text == "")
            {
                check_data = 1;


                msg = "\nOpening balance not loaded";
            }
            if (txt_LoanAmount.Text != "")
            {
              lbl_OpeningBalance.Text=  _objGirviCommon.getOpeningBalance();
                if (Convert.ToDouble(lbl_OpeningBalance.Text) < Convert.ToDouble(txt_LoanAmount.Text))
                {
                    check_data = 1;
                    msg = "\nOpening Balance is Less";
                }
            }



            if (rbt_Krushi.Checked == false && rbt_Krushiuttar.Checked == false)
            {
                check_data = 1;
                lbl_Occupation.ForeColor = Color.Red;
            }
            else
            {
                if (rbt_Krushi.Checked == true)
                    Occupation = rbt_Krushi.Text;
                else
                    Occupation = rbt_Krushiuttar.Text;
            }



            if (check_data == 1)
            {
                if (msg != null)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show("Fill all required fields");
                }
                return false;
            }
            else
            {
                double LoanAmount = Convert.ToDouble(txt_LoanAmount.Text);

                if (rbt_English.Checked == true)
                {
                    DialogResult dr = MessageBox.Show("Your Girvi  loan Amount is " + txt_LoanAmount.Text + "\n Do You Want To Continue With Interest Rate '" + txt_InterestInPer.Text + "' ?", "JMS Says ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        return true;
                    }
                    else { return false; }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("तुमची गिरवी रक्कम " + txt_LoanAmount.Text + " आहे\n आणि व्याज दर '" + txt_InterestInPer.Text + "' आहे\n गिरवी कन्फर्म करायची?", "JMS Says ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        return true;
                    }
                    else { return false; }
                }
            }

        }

        private bool getdetails()
        {
            double LoanAmount = Convert.ToDouble(txt_LoanAmount.Text);

            if (rbt_English.Checked == true)
            {
                DialogResult dr = MessageBox.Show("Your Girvi  loan Amount is " + txt_LoanAmount + "\n do you want to continue with Interest rate '" + txt_InterestInPer.Text + "' ?", "JMS Says ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                DialogResult dr = MessageBox.Show("तुमची गिरवी रक्कम " + txt_LoanAmount + " आहे\n आणि व्याज दर '" + txt_InterestInPer.Text + "' आहे\n गिरवी कन्फर्म करायची?", "JMS Says ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    return true;
                }
                else { return false; }
            }

        }

        private void txt_FinalAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_InterestInPer.Focus();
            }
        }

        private void txt_EstimateInPer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_LoanAmount.Focus();
            }
        }

        private void txt_InterestInPer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                lbl_actualinper.Visible = true;

                txt_ActualRate.Visible = true;
                txt_ActualRate.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                txt_EstimateInPer.Focus();
            }

        }

        private void txt_LoanAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Save.Focus();
            }

        }

        private void rbt_English_CheckedChanged(object sender, EventArgs e)
        {
            rbt_English.ForeColor = Color.FromArgb(70, 132, 153);
            rbt_Marathi.ForeColor = Color.Black;
            rbt_Hindi.ForeColor = Color.Black;
            lbl_KhatawaniNo.Text = "Khatawani No ";
            lbl_FullName.Text = "Full Name ";
            lbl_MobileNo.Text = "Contact No";
            lbl_Address.Text = "Address";
            lbl_InvoiceNo.Text = "Invoice No";
            lbl_MetalType.Text = "Metal Type ";
            lbl_ItemType.Text = "ItemType ";
            lbl_GrossWt.Text = "Gross W.T.";
            lbl_FinalWt.Text = "Net W.T. ";
            lbl_InterestInPercent.Text = "Interest in %";
            lbl_DateOfDeposite.Text = "Date of Deposite ";
            lbl_LoanAmount.Text = "Loan Amount ";
            lbl_Duration.Text = "Duration ";
            bttn_Save.Text = "SAVE";
            bttn_Reset.Text = "RESET";
            bttn_Add.Text = "ADD";
            bttn_Update.Text = "UPDATE";
            bttn_Delete.Text = "DELETE";
            bttn_Reset.Text = "RESET";
            //bttn_camera.Text = "Upload Photo";
            //radioButton3.Text = "Show only Unreleased Girvi";
            //radioButton5.Text = "Show only Released Girvi";
            //radioButton6.Text = "Show only Updated Girvi";
            //radioButton7.Text = "Show all Girvi";

            dgv_ItemDetail.Columns["InvoiceNo"].HeaderText = "Invoice No";
            dgv_ItemDetail.Columns["MetalId"].HeaderText = "Metal Id";
            dgv_ItemDetail.Columns["MetalType"].HeaderText = "Metal Type";

            dgv_ItemDetail.Columns["ItemType"].HeaderText = "ItemType";
            dgv_ItemDetail.Columns["GrossWt"].HeaderText = "Gross W.T.";
            dgv_ItemDetail.Columns["FinalWt"].HeaderText = "Net W.T.";
            dgv_ItemDetail.Columns["Quantity"].HeaderText = "Quantity";
            dgv_ItemDetail.Columns["FinalWtInPer"].HeaderText = "Percentage";
            dgv_ItemDetail.Columns["FineWt"].HeaderText = "Fine wt";
            dgv_ItemDetail.Columns["Quantity"].HeaderText = "Quantity";
            dgv_ItemDetail.Columns["CurrentPrice"].HeaderText = "Current Rate";
            dgv_ItemDetail.Columns["TotalAmount"].HeaderText = "Amount";
            dgv_ItemDetail.Columns["MetalId"].Visible = false;

            dgv_ItemDetail.Columns["MetalType"].Visible = true;
            dgv_ItemDetail.Columns["MetalType"].Visible = true;

            dgv_GirviDetail.Columns["InvoiceNo1"].HeaderText = "Invoice No";
            dgv_GirviDetail.Columns["Amount"].HeaderText = "Loan Amount";
            dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "Date of Deposite";
            dgv_GirviDetail.Columns["InterestRate"].HeaderText = "Interest Rate";
            dgv_GirviDetail.Columns["UpdatedGirviNo"].HeaderText = "Updated Givi No";
            dgv_GirviDetail.Columns["LastDateOfRelease"].HeaderText = "Last Date of Release";
            dgv_GirviDetail.Columns["ForwardedTo"].HeaderText = "Forwarded To";
            dgv_GirviDetail.Columns["DateOfForward"].HeaderText = "Date Of forward";

            //dataGridView1.Columns[0].HeaderText = "Girvi No";
            //dataGridView1.Columns[1].HeaderText = "Loan Amount";
            //dataGridView1.Columns[2].HeaderText = "Date of Deposite";
            //dataGridView1.Columns[3].HeaderText = "Interest Rate";
            //dataGridView1.Columns[4].HeaderText = "Gross W.T.";
            //dataGridView1.Columns[5].HeaderText = "Updated Givi No";
            //dataGridView1.Columns[6].HeaderText = "Status";
            //dataGridView1.Columns[7].HeaderText = "Date of Release";

            //dataGridView2.Columns[0].HeaderText = "Girvi No";
            //dataGridView2.Columns[1].HeaderText = "Loan Amount";
            //dataGridView2.Columns[2].HeaderText = "Date of Deposite";
            //dataGridView2.Columns[3].HeaderText = "Interest Rate";
            //dataGridView2.Columns[4].HeaderText = "Gross W.T.";
            //dataGridView2.Columns[5].HeaderText = "Updated Givi No";
            //dataGridView2.Columns[6].HeaderText = "Status";
            //dataGridView1.Columns[7].HeaderText = "Date of Release";

            dgv_ItemDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);
            dgv_GirviDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);
            //    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);
            //    dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);

            //    old_dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);

        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            this.Text = "गिरवी ठेवा";
            lbl_Date.Text = "तारीख";
            grp_CustomerInfo.Text = "ग्राहकाचे नाव";
            grp_GirviDetail.Text = "गाहणी माहीती";
            grp_ItemDetails.Text = "वस्तूची माहीती";
            grp_Payment.Text = "पेमेंट";




            rbt_Marathi.ForeColor = Color.FromArgb(70, 132, 153);
            rbt_English.ForeColor = Color.Black;
            rbt_Hindi.ForeColor = Color.Black;
            lbl_KhatawaniNo.Text = "खतावानी नंबर ";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_FullName.Text = "पूर्ण नाव";
            lbl_FullName.Font = new Font("Arial", sizetext);
            lbl_MobileNo.Text = "Mobile No:";
            lbl_MobileNo.Font = new Font("Arial", sizetext);
            lbl_Address.Text = "पत्ता";
            lbl_Address.Font = new Font("Arial", sizetext);
            lbl_Post.Text = "पोस्ट";
            lbl_Post.Font = new Font("Arial", sizetext);
            lbl_ReceiptNo.Text = "पावती नं";
            lbl_ReceiptNo.Font = new Font("Arial", sizetext);
            lbl_Occupation.Text = "व्यवसाय";
            lbl_Occupation.Font = new Font("Arial", sizetext);
            lbl_Caste.Text = "जात";
            lbl_Caste.Font = new Font("Arial", sizetext);
            lbl_loanType.Text = "कर्जाचे प्रकार";
            lbl_loanType.Font = new Font("Arial", sizetext);
            lbl_InvoiceNo.Text = "क्रमांक";
            lbl_InvoiceNo.Font = new Font("Arial", sizetext);
            lbl_MetalType.Text = "मेटल प्रकार";
            lbl_MetalType.Font = new Font("Arial", sizetext);
            lbl_ItemType.Text = "आयटम प्रकार";
            lbl_ItemType.Font = new Font("Arial", sizetext);
            lbl_GrossWt.Text = "ग्रॉस वजन";
            lbl_GrossWt.Font = new Font("Arial", sizetext);
            lbl_FinalWt.Text = "नेट वजन";
            lbl_FinalWt.Font = new Font("Arial", sizetext);
            lbl_ReduceWt.Text = " घट वजन";
            lbl_ReduceWt.Font = new Font("Arial", sizetext);
            lbl_FinalWtInPercent.Text = "वजन टक्के";
            lbl_FinalWtInPercent.Font = new Font("Arial", sizetext);
            lbl_FineWt.Text = "फाईन वजन";
            lbl_FineWt.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = " रक्कम ";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_CurrentPrice.Text = "  चालू दर";
            lbl_CurrentPrice.Font = new Font("Arial", sizetext);
            lbl_LoanReason.Text = "कर्जाचे कारण";
            lbl_LoanReason.Font = new Font("Arial", sizetext);
            lbl_DateOfDeposite.Text = "ठेव तारीख";
            lbl_DateOfDeposite.Font = new Font("Arial", sizetext);
            lbl_OpeningBalance.Text = "ओपेनिंग रक्कम";
            lbl_OpeningBalance.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = "पूर्ण रक्कम";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_InterestInPercent.Text = "व्याज टक्के";
            lbl_InterestInPercent.Font = new Font("Arial", sizetext);
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_LoanAmount.Font = new Font("Arial", sizetext);
            lbl_Duration.Text = "कालावधी";
            lbl_Duration.Font = new Font("Arial", sizetext);
            lbl_EstimateInPercent.Text = "अंदाज टक्के";
            lbl_EstimateInPercent.Font = new Font("Arial", sizetext);
            lbl_InterestInPercent.Text = "व्याज टक्के";
            lbl_InterestInPercent.Font = new Font("Arial", sizetext);
            lbl_Quantity.Text = "नग";
            lbl_Quantity.Font = new Font("Arial", sizetext);
            lbl_EstimateAmt.Text = "अंदाज रक्कम";
            lbl_EstimateAmt.Font = new Font("Arial", sizetext);
            bttn_Reset.Text = "रीसेट";
            bttn_Reset.Font = new Font("Arial", sizetext);
            bttn_Save.Text = "Save";
            bttn_Save.Font = new Font("Arial", sizetext);
            bttn_Add.Text = "जोडा";
            bttn_Add.Font = new Font("Arial", sizetext);
            bttn_Update.Text = "अपडेट";
            bttn_Update.Font = new Font("Arial", sizetext);
            bttn_Delete.Text = " डिलीट";
            bttn_Delete.Font = new Font("Arial", sizetext);
            bttn_ResetItemDetail.Text = "रिसेट";
            bttn_ResetItemDetail.Font = new Font("Arial", sizetext);
            lbl_FinalAmount.Text = "एकून रक्कम";
            lbl_FinalAmount.Font = new Font("Arial", sizetext);
            lbl_MobileNo.Text = "मोबाइल नं.";
            lbl_MobileNo.Font = new Font("Arial", sizetext);
            bttn_Close.Text = "बंद";
            bttn_ResetGirviData.Text = "रिसेट";
            bttn_Save.Text = "सेव्ह";
            bttn_UploadPhoto.Text = "अपलोड फोटो";
            lbl_PoliceStation.Text = "पोलिस स्टेशन";
            lbl_PoliceStation.Font = new Font("Arial", sizetext);
            lbl_Tahsil.Text = "तहसील";
            lbl_Tahsil.Font = new Font("Arial", sizetext);
            lbl_District.Text = "जिल्हा";
            lbl_District.Font = new Font("Arial", sizetext);

            dgv_ItemDetail.Columns["InvoiceNo"].HeaderText = "गाहणी क्रमांक";
            dgv_ItemDetail.Columns["MetalType"].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns["MetalId"].HeaderText = "मेटल आइडी";
            dgv_ItemDetail.Columns["ItemType"].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns["GrossWt"].HeaderText = "ग्रॉस वजन";
            dgv_ItemDetail.Columns["ReduceWt"].HeaderText = "घट वजन";
            dgv_ItemDetail.Columns["FinalWt"].HeaderText = "नेट वजन";
            dgv_ItemDetail.Columns["FinalWtInPer"].HeaderText = "वजन टक्के";
            dgv_ItemDetail.Columns["FineWt"].HeaderText = "फाईन वजन";
            dgv_ItemDetail.Columns["Quantity"].HeaderText = "प्रमाण";
            dgv_ItemDetail.Columns["CurrentPrice"].HeaderText = "चालू दर";
            dgv_ItemDetail.Columns["TotalAmount"].HeaderText = "रक्कम";
            dgv_ItemDetail.Columns["MetalId"].Visible = false;

            dgv_ItemDetail.Columns["MetalType"].Visible = true;
            dgv_ItemDetail.Columns["ItemType"].Visible = true;

            dgv_GirviDetail.Columns["InvoiceNo1"].HeaderText = "गिरवी क्रमांक";
            dgv_GirviDetail.Columns["Amount"].HeaderText = "कर्ज रक्कम";
            dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "ठेव तारीख";
            dgv_GirviDetail.Columns["InterestRate"].HeaderText = "व्याज टक्के";
            dgv_GirviDetail.Columns["UpdatedGirviNo"].HeaderText = "अपडेटेड गिरवी क्रमांक";
            dgv_GirviDetail.Columns["LastDateOfRelease"].HeaderText = "अंतिम तारीख";
            dgv_GirviDetail.Columns["ForwardedTo"].HeaderText = "Forwarded To";
            dgv_GirviDetail.Columns["DateOfForward"].HeaderText = "Date Of forward";
            dgv_ItemDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 12, FontStyle.Bold);
            dgv_GirviDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 12, FontStyle.Bold);


        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            cmb_FullName.ResetText();
            cmb_Address.ResetText();
            cmb_Post.ResetText();
            txt_MobileNo.ResetText();
            cmb_Cast.ResetText();
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_CustomerInfo.Text = "ग्राहकाचे नाव";
            grp_GirviDetail.Text = "गाहणी माहीती";
            grp_ItemDetails.Text = "वस्तूची माहीती";
            grp_Payment.Text = "पेमेंट";

            lbl_Date.Text = "तारीख";
            this.Text = "गिरवी रखिये";
            rbt_Hindi.ForeColor = Color.FromArgb(70, 132, 153);
            rbt_English.ForeColor = Color.Black;
            rbt_Marathi.ForeColor = Color.Black;
            lbl_KhatawaniNo.Text = "खतावानी नंबर ";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_FullName.Text = "पुरा नाम";
            lbl_FullName.Font = new Font("Arial", sizetext);
            lbl_MobileNo.Text = "मोबाईल नं:";
            lbl_MobileNo.Font = new Font("Arial", sizetext);
            lbl_Address.Text = "पत्ता";
            lbl_Address.Font = new Font("Arial", sizetext);
            lbl_Post.Text = "पोस्ट";
            lbl_Post.Font = new Font("Arial", sizetext);
            lbl_ReceiptNo.Text = "पावती नं";
            lbl_ReceiptNo.Font = new Font("Arial", sizetext);
            lbl_Occupation.Text = "व्यवसाय";
            lbl_Occupation.Font = new Font("Arial", sizetext);
            lbl_Caste.Text = "जात";
            lbl_Caste.Font = new Font("Arial", sizetext);
            lbl_loanType.Text = "कर्जका प्रकार";
            lbl_loanType.Font = new Font("Arial", sizetext);
            lbl_InvoiceNo.Text = "क्रमांक";
            lbl_InvoiceNo.Font = new Font("Arial", sizetext);
            lbl_MetalType.Text = "मेटल प्रकार";
            lbl_MetalType.Font = new Font("Arial", sizetext);
            lbl_ItemType.Text = "आयटम प्रकार";
            lbl_ItemType.Font = new Font("Arial", sizetext);
            lbl_GrossWt.Text = "ग्रॉस वजन";
            lbl_GrossWt.Font = new Font("Arial", sizetext);
            lbl_FinalWt.Text = "नेट वजन";
            lbl_FinalWt.Font = new Font("Arial", sizetext);
            lbl_ReduceWt.Text = " घट वजन";
            lbl_ReduceWt.Font = new Font("Arial", sizetext);
            lbl_FinalWtInPercent.Text = "वजन प्रतिशत";
            lbl_FinalWtInPercent.Font = new Font("Arial", sizetext);
            lbl_FineWt.Text = "फाईन वजन";
            lbl_FineWt.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = " रक्कम ";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_CurrentPrice.Text = "  चालू दर";
            lbl_CurrentPrice.Font = new Font("Arial", sizetext);
            lbl_LoanReason.Text = "कर्जका कारण";
            lbl_LoanReason.Font = new Font("Arial", sizetext);
            lbl_DateOfDeposite.Text = "रखीने की तारीख";
            lbl_DateOfDeposite.Font = new Font("Arial", sizetext);
            lbl_OpeningBalance.Text = "ओपेनिंग रक्कम";
            lbl_OpeningBalance.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = "पूरी रक्कम";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_InterestInPercent.Text = "ब्याज प्रतिशत";
            lbl_InterestInPercent.Font = new Font("Arial", sizetext);
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_LoanAmount.Font = new Font("Arial", sizetext);
            lbl_Duration.Text = "कालावधी";
            lbl_Duration.Font = new Font("Arial", sizetext);
            lbl_EstimateInPercent.Text = "अंदाज प्रतिशत";
            lbl_EstimateInPercent.Font = new Font("Arial", sizetext);
            lbl_InterestInPercent.Text = "ब्याज प्रतिशत";
            lbl_InterestInPercent.Font = new Font("Arial", sizetext);
            lbl_Quantity.Text = "नग";
            lbl_Quantity.Font = new Font("Arial", sizetext);
            bttn_Reset.Text = "रीसेट";
            bttn_Reset.Font = new Font("Arial", sizetext);
            bttn_Save.Text = "Save";
            bttn_Save.Font = new Font("Arial", sizetext);
            bttn_Add.Text = "जोडो";
            bttn_Add.Font = new Font("Arial", sizetext);
            bttn_Update.Text = "अपडेट";
            bttn_Update.Font = new Font("Arial", sizetext);
            bttn_Delete.Text = " डिलीट";
            bttn_Delete.Font = new Font("Arial", sizetext);
            bttn_ResetItemDetail.Text = "रिसेट";
            bttn_ResetItemDetail.Font = new Font("Arial", sizetext);
            lbl_FinalAmount.Text = "पुरी रक्कम";
            lbl_FinalAmount.Font = new Font("Arial", sizetext);
            lbl_Data.Text = "ब्याज हर सालनुसार डालिये";
            bttn_Close.Text = "बंद";
            bttn_ResetGirviData.Text = "रिसेट";
            bttn_Save.Text = "सेव्ह";
            bttn_UploadPhoto.Text = "अपलोड फोटो";


            dgv_ItemDetail.Columns["InvoiceNo"].HeaderText = "गिरवी क्रमांक";
            dgv_ItemDetail.Columns["MetalType"].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns["MetalId"].HeaderText = "मेटल आइडी";
            dgv_ItemDetail.Columns["ItemType"].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns["GrossWt"].HeaderText = "ग्रॉस वजन";
            dgv_ItemDetail.Columns["ReduceWt"].HeaderText = "घट वजन";
            dgv_ItemDetail.Columns["FinalWt"].HeaderText = "नेट वजन";
            dgv_ItemDetail.Columns["FinalWtInPer"].HeaderText = "वजन टक्के";
            dgv_ItemDetail.Columns["FineWt"].HeaderText = "फाईन वजन";
            dgv_ItemDetail.Columns["Quantity"].HeaderText = "नग";
            dgv_ItemDetail.Columns["CurrentPrice"].HeaderText = "चालू दर";
            dgv_ItemDetail.Columns["TotalAmount"].HeaderText = "रक्कम";
            dgv_ItemDetail.Columns["MetalId"].Visible = false;

            dgv_ItemDetail.Columns["MetalType"].Visible = true;
            dgv_ItemDetail.Columns["ItemType"].Visible = true;

            dgv_GirviDetail.Columns["InvoiceNo1"].HeaderText = "गिरवी क्रमांक";
            dgv_GirviDetail.Columns["Amount"].HeaderText = "कर्ज रक्कम";
            dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "रखनेकि तारीख";
            dgv_GirviDetail.Columns["InterestRate"].HeaderText = "ब्याज प्रतिशत";
            dgv_GirviDetail.Columns["UpdatedGirviNo"].HeaderText = "अपडेटेड गिरवी क्रमांक";
            dgv_GirviDetail.Columns["LastDateOfRelease"].HeaderText = "अंतिम तारीख";
            dgv_GirviDetail.Columns["ForwardedTo"].HeaderText = "Forwarded To";
            dgv_GirviDetail.Columns["DateOfForward"].HeaderText = "Date Of forward";
            dgv_ItemDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 12, FontStyle.Bold);
            dgv_GirviDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 12, FontStyle.Bold);


        }

        private void cmb_FullName_KeyDown_1(object sender, KeyEventArgs e)
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

                    fillCustomerInfo();
                    cmb_Address.Focus();
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

        private void cmb_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (rbt_hide.Checked == true)
            {

                if (e.KeyCode == Keys.Enter)
                {
                    cmb_Post.Focus();
                }
                if (e.KeyCode == Keys.Left && e.Alt)
                {
                    cmb_FullName.Focus();

                }
            }
            else
            {


                if (e.KeyCode == Keys.Enter)
                {
                    cmb_PoliceStation.Focus();
                }
                if (e.KeyCode == Keys.Left && e.Alt)
                {
                    cmb_FullName.Focus();
                }
            }
        }

        private void cmb_City_KeyDown(object sender, KeyEventArgs e)
        {
            if (rbt_hide.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txt_MobileNo.Focus();
                }
                if (e.KeyCode == Keys.Left && e.Alt)
                {
                    cmb_Address.Focus();

                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Cmb_Tahsil.Focus();
                }
                if (e.KeyCode == Keys.Left && e.Alt)
                {
                    cmb_Address.Focus();

                }
            }
        }

        private void txt_ContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbt_Krushiuttar.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                cmb_Post.Focus();

            }
        }

        private void rbt_Krushiuttar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Cast.Focus();
            }
            if (e.KeyCode == Keys.Left && e.Alt)
            {
                txt_MobileNo.Focus();

            }
        }

        private void txt_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitOnly(e);
        }

        private void cmb_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void cmb_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            // _objSimplevalidations.ValidationCharDigitOnly(e);
        }

        private void cmb_FullName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationCharOnly(e);
        }

        private void bttn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Language

        private void cmb_FullName_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void cmb_Address_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void cmb_City_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void txt_ContactNo_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void txt_ReceiptNo_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void Cmb_ItemType_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }

        }

        private void txt_GrossWt_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void txt_ReduceWt_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void txt_FinalWt_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void txt_FinalWtInPercent_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void txt_FineWt_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void txt_Quantity_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void txt_CurrentPrice_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void txt_TotalAmount_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_FinalAmount_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }

        private void txt_EstimateInPer_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
            if ((txt_EstimateInPer.Text != "") && (txt_FinalAmount.Text != ""))
            {
                //txt_ReduceWt.Text = (Convert.ToDecimal(txt_GrossWt.Text) - Convert.ToDecimal(txt_FinalWt.Text)).ToString();
                PerAmount.Text = Math.Round(Convert.ToDouble(((Convert.ToDouble(txt_EstimateInPer.Text) * Convert.ToDouble(txt_FinalAmount.Text)) / 100).ToString())).ToString();
            }


        }

        private void txt_LoanAmount_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");

        }
       





        #endregion Language

        private bool PavtiNoExits()
        {
            DataTable dtPavtiNo = _objGirviAdd.getPavtiNo(txt_ReceiptNo.Text);
            if (dtPavtiNo.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //vaishali
        private bool GirviNoExits()
        {
            DataTable dtGirviNo = _objGirviAdd.getGirviNo(txt_InvoiceNo.Text);
            if (dtGirviNo.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        PrinterSetting oPrintersetting = new PrinterSetting();
        private void bttn_Save_Click(object sender, EventArgs e)
        {
             
            try
            
            
            {
                if (checkdata())
                {
                    int finalcialYearId = _objFinancialYear.getSelectedFinancialYearId();
                    if (!customerExist())
                    {
                        _objGirviAdd.addCustomer(txt_KhatawaniNo.Text, cmb_FullName.Text.Trim(), txt_MobileNo.Text, cmb_Address.Text, dtp_DateOfDeposit.Text, cmb_Cast.Text, Occupation, txt_ReceiptNo.Text, cmb_Post.Text, ProfilePic, Document1, Documennt2, Document3,cmb_PoliceStation.Text,Cmb_Tahsil.Text,cmb_District.Text);
                        _objGirviAdd.updateKhatawaniNumber(txt_KhatawaniNo.Text);
                    }
                    else
                    {
                        if (ProfilePic != "" || Document1 != "" || Documennt2 != "" || Document3 != "")
                        {
                           // _objGirviAdd.updateCustomer(txt_KhatawaniNo.Text, cmb_FullName.Text, txt_MobileNo.Text, cmb_Address.Text, cmb_Cast.Text, Occupation, txt_ReceiptNo.Text, cmb_Post.Text, ProfilePic, Document1, Documennt2, Document3);
                            _objGirviAdd.updateCustWithoutPhoto(txt_KhatawaniNo.Text, cmb_FullName.Text, txt_MobileNo.Text, cmb_Address.Text, cmb_Cast.Text, Occupation, txt_ReceiptNo.Text, cmb_Post.Text);
                        }
                    }
                    double intRAte = Convert.ToDouble(txt_InterestInPer.Text) / 12;
                    double actualintRAte = Convert.ToDouble(txt_ActualRate.Text) / 12;
                  
                    _objGirviAdd.addGirviMaster(txt_InvoiceNo.Text, txt_KhatawaniNo.Text, intRAte.ToString(), dtp_DateOfDeposit.Text, txt_LoanAmount.Text, dtp_Duration.Text, "", actualintRAte.ToString(), cmb_LoanReason.Text, "", txt_ReceiptNo.Text, cmb_LoanReason.Text, cmb_LoanType.Text, finalcialYearId,txt_Narration.Text);
                

                    for (int i = 0; i < dgv_ItemDetail.Rows.Count; i++)
                    {
                        string GirviNo = dgv_ItemDetail.Rows[i].Cells["InvoiceNo"].Value.ToString();
                        string metalEnglish = dgv_ItemDetail.Rows[i].Cells["MetalType"].Value.ToString();
                        string metalMarathi = dgv_ItemDetail.Rows[i].Cells["MetalType"].Value.ToString();
                        string itemMarathi = dgv_ItemDetail.Rows[i].Cells["ItemType"].Value.ToString();
                        string GrossWeight =Convert.ToDouble(dgv_ItemDetail.Rows[i].Cells["GrossWt"].Value).ToString("0.000");
                        string ReducedWeight =Convert.ToDouble(dgv_ItemDetail.Rows[i].Cells["ReduceWt"].Value).ToString("0.000");
                        string NetWeight = Convert.ToDouble(dgv_ItemDetail.Rows[i].Cells["FinalWt"].Value).ToString("0.000");
                        //string ReducedWeight = Math.Round(Convert.ToDouble(dgv_ItemDetail.Rows[i].Cells["ReduceWt"].Value.ToString()), 3).ToString();
                        //string NetWeight = Math.Round(Convert.ToDouble(dgv_ItemDetail.Rows[i].Cells["FinalWt"].Value.ToString()), 3).ToString();
                        string WtInPer = dgv_ItemDetail.Rows[i].Cells["FinalWtInPer"].Value.ToString();
                        string FineWeight = Math.Round(Convert.ToDouble(dgv_ItemDetail.Rows[i].Cells["FineWt"].Value.ToString()), 3).ToString();
                        string Quantity = dgv_ItemDetail.Rows[i].Cells["Quantity"].Value.ToString();
                        string CurrentRate = dgv_ItemDetail.Rows[i].Cells["CurrentPrice"].Value.ToString();
                        string Amount = dgv_ItemDetail.Rows[i].Cells["TotalAmount"].Value.ToString();
                        _objGirviAdd.addGirviItemMaster(GirviNo, metalEnglish, metalMarathi, itemMarathi, GrossWeight, ReducedWeight, NetWeight, WtInPer, FineWeight, Quantity, CurrentRate, Math.Round(Convert.ToDecimal(Amount), 0).ToString(),txt_Narration.Text);
                    }
                    _objGirviAdd.updateGirviNumber(txt_InvoiceNo.Text);

                    if (rbt_PrintTrue.Checked == true)
                    {
                        DialogResult drReportPrint = MessageBox.Show("Do You Want To Print", "JMS Says", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (drReportPrint == DialogResult.Yes)
                        {
                            if (rbt_OtherTrue.Checked == true)
                            {
                                if (oPrintersetting.ShowDialog() == DialogResult.OK)
                                {
                                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                                    SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataAddGirvi);
                                    _obj(txt_InvoiceNo.Text, txt_KhatawaniNo.Text, "Other", oPrintersetting.PrinterName);

                                }
                                else
                                {
                                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                                    SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataAddGirvi);
                                    _obj(txt_InvoiceNo.Text, txt_KhatawaniNo.Text, "Other", "");
                                    _objfrm_ReportViewer.Show();
                                }
                            }
                            else
                            {
                                if (oPrintersetting.ShowDialog() == DialogResult.OK)
                                {
                                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                                    SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataAddGirvi);
                                    _obj(txt_InvoiceNo.Text, txt_KhatawaniNo.Text, "All", oPrintersetting.PrinterName);

                                }
                                else
                                {
                                    CrystalReport.frm_ReportViewer _objfrm_ReportViewer = new CrystalReport.frm_ReportViewer();
                                    SendData _obj = new SendData(_objfrm_ReportViewer.ReceiveDataAddGirvi);
                                    _obj(txt_InvoiceNo.Text, txt_KhatawaniNo.Text, "All", "");
                                    _objfrm_ReportViewer.Show();
                                }
                            }
                        }
                    }
                    MessageBox.Show("गाहणी ठेवली !");
                    //MessageBox.Show("Girvi Added");
                    masterclear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool customerExist()
        {
            DataTable dtKhatawani = _objGirviAdd.getKhatawaniByName(cmb_FullName.Text);
            if (dtKhatawani.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cmb_FullName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillCustomerInfo()
        {


            if (_objValidation.IsNotEmpty(cmb_FullName.Text))
            {
                dgv_GirviDetail.Rows.Clear();
                dgv_ItemDetail.Rows.Clear();
                DataTable dtKhatawani = _objGirviAdd.getKhatawaniByName(cmb_FullName.Text);
                if (dtKhatawani.Rows.Count == 1)
                {
                     
                    txt_KhatawaniNo.Text = Convert.ToString((dtKhatawani.Rows[0]["khatawani_No"]));
                    cmb_FullName.Text = Convert.ToString((dtKhatawani.Rows[0]["FullName"]));
                    txt_MobileNo.Text = Convert.ToString((dtKhatawani.Rows[0]["Contact_No"]));
                    cmb_Address.Text = Convert.ToString((dtKhatawani.Rows[0]["Address"]));
                    
                    cmb_PoliceStation.Text = Convert.ToString((dtKhatawani.Rows[0]["PoliceStation"]));
                    Cmb_Tahsil.Text = Convert.ToString((dtKhatawani.Rows[0]["Tahsil"]));
                    cmb_District.Text = Convert.ToString((dtKhatawani.Rows[0]["District"]));
                    cmb_Cast.Text = Convert.ToString((dtKhatawani.Rows[0]["cast"]));
                    ProfilePhoto = Convert.ToString((dtKhatawani.Rows[0]["photo"]));
                    Document1 = Convert.ToString((dtKhatawani.Rows[0]["doc1"]));
                    Documennt2 = Convert.ToString((dtKhatawani.Rows[0]["doc2"]));
                    Document3 = Convert.ToString((dtKhatawani.Rows[0]["doc3"]));
                    pcbx_Photo.ImageLocation = Environment.CurrentDirectory + "\\Images\\" + Convert.ToString((dtKhatawani.Rows[0]["photo"]));
                   // byte[] MyData = new byte[0];

                  
                   // MyData = (byte[])dtKhatawani.Rows[0]["photo"];

                    //using (MemoryStream mStream = new MemoryStream(MyData))
                  //  {
                        //pcbx_Photo.Image= Image.FromStream(mStream);
                    //}
                    //pcbx_Photo.Image = Convert.ToBase64String(stream);

                    if (dtKhatawani.Rows[0]["occupation"].ToString() == "कृषीत्तर")
                    {
                        rbt_Krushiuttar.Checked = true;
                    }
                    else
                    {
                        rbt_Krushi.Checked = true;

                    }
                    cmb_Post.Text = Convert.ToString((dtKhatawani.Rows[0]["Address2"]));

                    DataTable dtGirvi = _objGirviAdd.getGirviDetailsByKhatawani(txt_KhatawaniNo.Text);
                    for (int i = 0; i < dtGirvi.Rows.Count; i++)
                    {
                        dgv_GirviDetail.Rows.Add();
                        int gcount = Convert.ToInt32(this.dgv_GirviDetail.Rows.Count);
                        gcount = gcount - 1;

                        dgv_GirviDetail.Rows[gcount].Cells["InvoiceNo1"].Value = dtGirvi.Rows[i]["GirviRecordNo"].ToString();
                        dgv_GirviDetail.Rows[gcount].Cells["Receipt"].Value = dtGirvi.Rows[i]["receipt_no"].ToString();
                        
                        dgv_GirviDetail.Rows[gcount].Cells["Amount"].Value = dtGirvi.Rows[i]["Amount"].ToString();
                        dgv_GirviDetail.Rows[gcount].Cells["DateOfDeposit"].Value = dtGirvi.Rows[i]["Date_of_deposit"].ToString();
                        dgv_GirviDetail.Rows[gcount].Cells["InterestRate"].Value = dtGirvi.Rows[i]["interset_rate"].ToString();
                        dgv_GirviDetail.Rows[gcount].Cells["LastDateOfRelease"].Value = dtGirvi.Rows[i]["duration"].ToString();
                        dgv_GirviDetail.Rows[gcount].Cells["UpdatedGirviNo"].Value = dtGirvi.Rows[i]["updated_girvi_no"].ToString();
                        dgv_GirviDetail.Rows[gcount].Cells["ForwardedTo"].Value = dtGirvi.Rows[i]["Forwarded_to"].ToString();
                        dgv_GirviDetail.Rows[gcount].Cells["DateOfForward"].Value = dtGirvi.Rows[i]["Date_of_Forward"].ToString();

                    }


                    txt_KhatawaniNo.ReadOnly = true;
                }
                else
                {
                    clearallwithoutname();
                }
            }
        }

        private void bttn_ResetGirviData_Click(object sender, EventArgs e)
        {
            masterclear();
        }

        //private void bttn_AdressAdd_Click(object sender, EventArgs e)
        //{
        //    frm_AddressMaster _obj_AddressMaster = new frm_AddressMaster();
        //    _obj_AddressMaster.Show();
        //    _obj_AddressMaster.FormClosed += new FormClosedEventHandler(_obj_AddressMaster_FormClosed);
        //    if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
        //    else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
        //    else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
        //}

        void _obj_AddressMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                cmb_Address.DataSource = _objAdress.getAddress();
                cmb_Address.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_ActualRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_EstimateInPer.Focus();
            }
        }

        private void txt_ActualRate_Leave(object sender, EventArgs e)
        {
            if (txt_ActualRate.Text == "")
            {
                txt_ActualRate.Text = txt_InterestInPer.Text;
            }
            lbl_actualinper.Visible = false;
            txt_ActualRate.Visible = false;
        }
        int currentMouseOverRow;
        private void dgv_GirviDetail_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Forward"));
                m.MenuItems[0].Click += new System.EventHandler(this.menuItemForward_Click);
                currentMouseOverRow = dgv_GirviDetail.HitTest(e.X, e.Y).RowIndex;
                m.Show(dgv_GirviDetail, new Point(e.X, e.Y));

            }
        }

        private void menuItemForward_Click(object sender, System.EventArgs e)
        {
            try
            {
                Girvi.frm_GirviForword _objIntersetTaking = new Girvi.frm_GirviForword();
                _objIntersetTaking.txt_GirviNo.Text = dgv_GirviDetail.Rows[currentMouseOverRow].Cells["InvoiceNo1"].Value.ToString();
                _objIntersetTaking.txt_GirviNo.ReadOnly = true;
                _objIntersetTaking.FormClosed += new FormClosedEventHandler(_objMaster_FormClosed);
                if (rbt_Marathi.Checked == true)
                {
                    _objIntersetTaking.rbt_Marathi.Checked = true;
                }
                else if (rbt_Hindi.Checked == true)
                {
                    _objIntersetTaking.rbt_Hindi.Checked = true;
                }
                _objIntersetTaking.ShowDialog();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("No Girvi Number Found");
            }

        }

        void _objMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgv_GirviDetail.Rows.Clear();
            dgv_ItemDetail.Rows.Clear();
            try
            {
                fillCustomerInfo();
            }
            catch
            {

            }


        }

        private void dtp_DateOfDeposit_ValueChanged(object sender, EventArgs e)
        {

            dtp_Duration.Value = dtp_DateOfDeposit.Value.AddMonths(durationDate);
        }

        private void txt_FinalWt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_ReduceWt.Text != "")
                {
                    // txtredwt.Text = "0";
                    txt_ReduceWt.Text = (Convert.ToDecimal(txt_GrossWt.Text) - Convert.ToDecimal(txt_FinalWt.Text)).ToString();
                }
                else
                {
                    txt_FinalWt.Text = "";
                }
            }
            catch
            { }
        }

        private void Cmb_MetalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtnew = _objGirviCommon.load();
            if (Cmb_MetalType.Text.Trim() == "सोना")
            {
                txt_CurrentPrice.Text = dtnew.Rows[0][0].ToString();
            }
            if (Cmb_MetalType.Text.Trim() == "चांदी")
            {
                txt_CurrentPrice.Text = dtnew.Rows[0][1].ToString();
            }
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            int sizetext = 12;
            grp_CustomerInfo.Text = "ग्राहकाचे नाव";
            grp_GirviDetail.Text = "गाहणी माहीती";
            grp_ItemDetails.Text = "वस्तूची माहीती";
            grp_Payment.Text = "पेमेंट";

            this.Text = "गिरवी ठेवा";
            lbl_Date.Text = "तारीख";


            rbt_Marathi.ForeColor = Color.FromArgb(70, 132, 153);
            rbt_English.ForeColor = Color.Black;
            rbt_Hindi.ForeColor = Color.Black;
            lbl_KhatawaniNo.Text = "खतावानी नंबर ";
            lbl_KhatawaniNo.Font = new Font("Arial", sizetext);
            lbl_FullName.Text = "पूर्ण नाव";
            lbl_FullName.Font = new Font("Arial", sizetext);
            lbl_MobileNo.Text = "Mobile No:";
            lbl_MobileNo.Font = new Font("Arial", sizetext);
            lbl_Address.Text = "पत्ता";
            lbl_Address.Font = new Font("Arial", sizetext);
            lbl_Post.Text = "पोस्ट";
            lbl_Post.Font = new Font("Arial", sizetext);
            lbl_ReceiptNo.Text = "पावती नं";
            lbl_ReceiptNo.Font = new Font("Arial", sizetext);
            lbl_Occupation.Text = "व्यवसाय";
            lbl_Occupation.Font = new Font("Arial", sizetext);
            lbl_Caste.Text = "जात";
            lbl_Caste.Font = new Font("Arial", sizetext);
            lbl_loanType.Text = "कर्जाचे प्रकार";
            lbl_loanType.Font = new Font("Arial", sizetext);
            lbl_InvoiceNo.Text = "क्रमांक";
            lbl_InvoiceNo.Font = new Font("Arial", sizetext);
            lbl_MetalType.Text = "मेटल प्रकार";
            lbl_MetalType.Font = new Font("Arial", sizetext);
            lbl_ItemType.Text = "आयटम प्रकार";
            lbl_ItemType.Font = new Font("Arial", sizetext);
            lbl_GrossWt.Text = "ग्रॉस वजन";
            lbl_GrossWt.Font = new Font("Arial", sizetext);
            lbl_FinalWt.Text = "नेट वजन";
            lbl_FinalWt.Font = new Font("Arial", sizetext);
            lbl_ReduceWt.Text = " घट वजन";
            lbl_ReduceWt.Font = new Font("Arial", sizetext);
            lbl_FinalWtInPercent.Text = "वजन टक्के";
            lbl_FinalWtInPercent.Font = new Font("Arial", sizetext);
            lbl_FineWt.Text = "फाईन वजन";
            lbl_FineWt.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = " रक्कम ";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_CurrentPrice.Text = "  चालू दर";
            lbl_CurrentPrice.Font = new Font("Arial", sizetext);
            lbl_LoanReason.Text = "कर्जाचे कारण";
            lbl_LoanReason.Font = new Font("Arial", sizetext);
            lbl_DateOfDeposite.Text = "ठेव तारीख";
            lbl_DateOfDeposite.Font = new Font("Arial", sizetext);
            lbl_OpeningBalance.Text = "ओपेनिंग रक्कम";
            lbl_OpeningBalance.Font = new Font("Arial", sizetext);
            lbl_TotalAmount.Text = "पूर्ण रक्कम";
            lbl_TotalAmount.Font = new Font("Arial", sizetext);
            lbl_InterestInPercent.Text = "व्याज टक्के";
            lbl_InterestInPercent.Font = new Font("Arial", sizetext);
            lbl_LoanAmount.Text = "कर्ज रक्कम";
            lbl_LoanAmount.Font = new Font("Arial", sizetext);
            lbl_Duration.Text = "कालावधी";
            lbl_Duration.Font = new Font("Arial", sizetext);
            lbl_EstimateInPercent.Text = "अंदाज टक्के";
            lbl_EstimateInPercent.Font = new Font("Arial", sizetext);
            lbl_InterestInPercent.Text = "व्याज टक्के";
            lbl_InterestInPercent.Font = new Font("Arial", sizetext);
            lbl_Quantity.Text = "नग";
            lbl_Quantity.Font = new Font("Arial", sizetext);
            bttn_Reset.Text = "रीसेट";
            bttn_Reset.Font = new Font("Arial", sizetext);
            bttn_Save.Text = "Save";
            bttn_Save.Font = new Font("Arial", sizetext);
            bttn_Add.Text = "जोडा";
            bttn_Add.Font = new Font("Arial", sizetext);
            bttn_Update.Text = "अपडेट";
            bttn_Update.Font = new Font("Arial", sizetext);
            bttn_Delete.Text = " डिलीट";
            bttn_Delete.Font = new Font("Arial", sizetext);
            bttn_ResetItemDetail.Text = "रिसेट";
            bttn_ResetItemDetail.Font = new Font("Arial", sizetext);
            lbl_FinalAmount.Text = "एकून रक्कम";
            lbl_FinalAmount.Font = new Font("Arial", sizetext);
            lbl_MobileNo.Text = "मोबाइल नं.";
            lbl_MobileNo.Font = new Font("Arial", sizetext);
            bttn_Close.Text = "बंद";
            bttn_ResetGirviData.Text = "रिसेट";
            bttn_Save.Text = "सेव्ह";
            bttn_UploadPhoto.Text = "अपलोड फोटो";

            dgv_ItemDetail.Columns["InvoiceNo"].HeaderText = "गाहणी क्रमांक";
            dgv_ItemDetail.Columns["MetalType"].HeaderText = "मेटल टाईप";
            dgv_ItemDetail.Columns["MetalId"].HeaderText = "मेटल आइडी";
            dgv_ItemDetail.Columns["ItemType"].HeaderText = "आयटम टाईप";
            dgv_ItemDetail.Columns["GrossWt"].HeaderText = "ग्रॉस वजन";
            dgv_ItemDetail.Columns["ReduceWt"].HeaderText = "घट वजन";
            dgv_ItemDetail.Columns["FinalWt"].HeaderText = "नेट वजन";
            dgv_ItemDetail.Columns["FinalWtInPer"].HeaderText = "वजन टक्के";
            dgv_ItemDetail.Columns["FineWt"].HeaderText = "फाईन वजन";
            dgv_ItemDetail.Columns["Quantity"].HeaderText = "प्रमाण";
            dgv_ItemDetail.Columns["CurrentPrice"].HeaderText = "चालू दर";
            dgv_ItemDetail.Columns["TotalAmount"].HeaderText = "रक्कम";
            dgv_ItemDetail.Columns["MetalId"].Visible = false;

            dgv_ItemDetail.Columns["MetalType"].Visible = true;
            dgv_ItemDetail.Columns["ItemType"].Visible = true;

            dgv_GirviDetail.Columns["InvoiceNo1"].HeaderText = "गिरवी क्रमांक";
            dgv_GirviDetail.Columns["Amount"].HeaderText = "कर्ज रक्कम";
            dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "ठेव तारीख";
            dgv_GirviDetail.Columns["InterestRate"].HeaderText = "व्याज टक्के";
            dgv_GirviDetail.Columns["UpdatedGirviNo"].HeaderText = "अपडेटेड गिरवी क्रमांक";
            dgv_GirviDetail.Columns["LastDateOfRelease"].HeaderText = "अंतिम तारीख";
            dgv_GirviDetail.Columns["ForwardedTo"].HeaderText = "फोरवर्ड ";
            dgv_GirviDetail.Columns["DateOfForward"].HeaderText = "फोरवर्ड करण्याची तारीख";
            dgv_ItemDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 12, FontStyle.Bold);
            dgv_GirviDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 12, FontStyle.Bold);

        }

        private void rbt_PrintTrue_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void txt_InterestInPer_TextChanged(object sender, EventArgs e)
        {
            if (txt_ActualRate.Text == "" || txt_ActualRate.Text == "0")
            {
                txt_ActualRate.Text = txt_InterestInPer.Text;
            }
        }

        private void cmb_FullName_TextChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    if (cmb_FullName.Text != "")
            //    {
            //        //cmb_FullName.Items.Clear();
            //        CustName = cmb_FullName.Text;
            //        cmb_FullName.Items.Clear();
            //        cmb_FullName.DataSource = _objGirviAdd.getFName(cmb_FullName.Text);
            //        //cmb_FullName.SelectedIndex = -1;
            //        cmb_FullName.DroppedDown = true;
            //    }
            //}
            //catch { }
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

        private void dgv_ItemDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtp_Duration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_LoanReason.Focus();
            }
        }

        private void dtp_DateOfDeposit_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void dtp_Duration_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void txt_LoanAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimplevalidations.ValidationDigitWithPoint(e, txt_LoanAmount.Text);
        }

        private void lst_FullName_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void lst_FullName_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void lst_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_FullName.Text = lst_FullName.SelectedValue.ToString();
                //cmb_FullName.Focus();

                fillCustomerInfo();
                cmb_Address.Focus();
                lst_FullName.Visible = false;

            }

        }

        private void txt_GrossWt_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_GrossWt_Validated(object sender, EventArgs e)
        {
            txt_GrossWt.Text = _objSimplevalidations.Gettingdecimals(txt_GrossWt.Text);
        }

        private void txt_ReduceWt_Validated(object sender, EventArgs e)
        {
            txt_ReduceWt.Text = _objSimplevalidations.Gettingdecimals(txt_ReduceWt.Text);
        }

        private void txt_FinalWt_Validated(object sender, EventArgs e)
        {
            txt_FinalWt.Text = _objSimplevalidations.Gettingdecimals(txt_FinalWt.Text);
        }

        private void cmb_Cast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_ContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ContactNo_Leave(object sender, EventArgs e)
        {

            //if (txt_MobileNo.Text != "")
            //{
            //    if (txt_MobileNo.Text.Length == 10)
            //    {

            //    }
            //    else
            //    {
            //        MessageBox.Show("Enter 10 Digit Only");
            //        txt_MobileNo.Focus();
            //    }
            //}
        }

        private void txt_ContactNo_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void lst_FullName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_EstimateInPer_TextChanged(object sender, EventArgs e)
        {
            if ((txt_EstimateInPer.Text != "") && (txt_FinalAmount.Text != ""))
            {
                //txt_ReduceWt.Text = (Convert.ToDecimal(txt_GrossWt.Text) - Convert.ToDecimal(txt_FinalWt.Text)).ToString();
                PerAmount.Text = Math.Round(Convert.ToDouble(((Convert.ToDouble(txt_EstimateInPer.Text) * Convert.ToDouble(txt_FinalAmount.Text)) / 100).ToString())).ToString();
            }
        }

        private void pnl_dgv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grp_Payment_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_GirviDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_GirviDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_ItemDetail.Rows.Clear();
            //  string j = dgv_ItemDetail.Rows[dgv_ItemDetail.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DataTable dtGirviItemData = _objGirviRelease.getGirviItemdata(dgv_GirviDetail.Rows[dgv_GirviDetail.CurrentCell.RowIndex].Cells[0].Value.ToString());

            for (int i = 0; i < dtGirviItemData.Rows.Count; i++)
            {
                dgv_ItemDetail.Rows.Add(dtGirviItemData.Rows[i]["GirviNo"].ToString(), dtGirviItemData.Rows[i]["metal_type"].ToString(), dtGirviItemData.Rows[i]["item_type"].ToString(), dtGirviItemData.Rows[i]["item_type"].ToString(), dtGirviItemData.Rows[i]["gross_wt"].ToString(), dtGirviItemData.Rows[i]["reduce_wt"].ToString(), dtGirviItemData.Rows[i]["net_wt"].ToString(), dtGirviItemData.Rows[i]["Total_Quantity"].ToString(), dtGirviItemData.Rows[i]["wt_in_percent"].ToString(), dtGirviItemData.Rows[i]["fine_wt"].ToString(), dtGirviItemData.Rows[i]["current_rate"].ToString(), dtGirviItemData.Rows[i]["amount"].ToString());
            }
        }
        ImageFormat format = ImageFormat.Png;
        private void bttn_UploadPhoto_Click(object sender, EventArgs e)
        {
            CameraCapture _capture = new CameraCapture(txt_KhatawaniNo.Text);
            _capture.ShowDialog();
            ProfilePic = _capture.ProfilePic;
            Document1 = _capture.Document1;
            Documennt2 = _capture.Documennt2;
            Document3 = _capture.Document3;
            KhatawanoNo = _capture.KhatawanoNo;

        
            }

        private void txt_KhatawaniNo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProfilePic != "" || Document1 != "" || Documennt2 != "" || Document3 != "")
            {
                _objGirviAdd.updateCustomer(txt_KhatawaniNo.Text, cmb_FullName.Text, txt_MobileNo.Text, cmb_Address.Text, cmb_Cast.Text, Occupation, txt_ReceiptNo.Text, cmb_Post.Text, ProfilePic, Document1, Documennt2, Document3);
            //   _objGirviAdd.updateCustWithoutPhoto(txt_KhatawaniNo.Text, cmb_FullName.Text, txt_MobileNo.Text, cmb_Address.Text, cmb_Cast.Text, Occupation, txt_ReceiptNo.Text, cmb_Post.Text);
            }
        }

        private void cmb_PoliceStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Post.Focus();
            }

        }

        private void Cmb_Tahsil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_District.Focus();
            }
        }

        private void cmb_District_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_MobileNo.Focus();
            }
        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbt_no1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HideFn();
        }

        private void lbl_OpeningBalance_Click(object sender, EventArgs e)
        {

        }

        private void bttn_ViewOpeningBalance_Click(object sender, EventArgs e)
        {
            lbl_OpeningBalance.Text = _objGirviCommon.getOpeningBalance();
        }

        private void txt_Narration_Enter(object sender, EventArgs e)
        {
            if (rbt_Marathi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_Hindi.Checked == true) { SendKeys.Send("^(1)"); }
            else if (rbt_English.Checked == true) { SendKeys.Send("^(2)"); }
        }

        private void grp_ItemDetails_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_District_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(1)");
        }

        private void cmb_LoanReason_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(1)");
        }

        private void cmb_LoanType_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(1)");
        }

        private void txt_InterestInPer_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

    

    }
       
    
}


























