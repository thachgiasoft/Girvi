using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JewelleryManagement.Common;
using BAL.Girvi;
using BAL.Common;
using System.Globalization;
using Microsoft.Win32;

namespace JewelleryManagement
{
    public partial class JewelleryManagementSystem : Form
    {
        private int childFormNumber = 0;
       
     
   

        public JewelleryManagementSystem()
        {
          
            this.BackgroundImage = Properties.Resources.jwelri;
           // this.statusStrip= Properties.Settings.
            InitializeComponent();
            Timer tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Tick += new EventHandler(changeImage);
            tmr.Start();

        }

        cls_Bhandval _objBhandval = new cls_Bhandval();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        LoginBAL _objLoginBAl = new LoginBAL();

        int x = 0;
        string texto = "Marque";
        int tam = 15;
     

       
    
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.designmainpage);
            b1.Add(Properties.Resources.jewelry_pic2);
            b1.Add(Properties.Resources.Cufflinks_model);
            b1.Add(Properties.Resources.boutique_jewelry_design);
            b1.Add(Properties.Resources.a9d61cd67abf0f8267956d7c382a94ef);
            int index = DateTime.Now.Second % 5;
            this.BackgroundImage = b1[index];
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

     

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        //private int imageNumber = 1;

        //private void loadNextImage()
        //{
        //    if (imageNumber == 7)
        //    {
        //        imageNumber = 1;
        //        imageNumber = 2;
        //    }

        //    imgPicture.ImageLocation = string.Format(@"D:\jewelry-pic2.jpg", imageNumber);
        //    imgPicture.ImageLocation = string.Format(@"D:\jwelri.jpg", imageNumber);
        //    imageNumber++;
        //}

        private void tmrNextImage_Tick(object sender, EventArgs e)
        {
           // this.Refresh();
     
            lblMarque.Left += 5;
            if (lblMarque.Left >= this.Width)
                lblMarque.Left = lblMarque.Width * 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void JewelleryManagementSystem_Load(object sender, EventArgs e)
        {
           // label1.Text = "<marquee>your Marquee Text Goes Here</marquee>";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://appsthentic.com/about-us/");
        }

        private void bttn_facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/appsthentic");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/appsthentic");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://plus.google.com/+appsthenticinc");
        }

        private void JewelleryManagementSystem_Load_1(object sender, EventArgs e)
        {
            _objGirviCommon.setaccounttype("1");

            DataTable dt2 = _objGirviCommon.getAccountType();
            if (dt2.Rows[0][0].ToString() == "1")
            {
                rbt_no_1.Checked = true;
                rbt_no_2.Checked = false;


            }
            else
            {
                rbt_no_1.Checked = false;
                rbt_no_2.Checked = true;
            }

            /////
            DataTable dtcompanydetails = _objLoginBAl.getcompanydetails();
            if (dtcompanydetails.Rows.Count == 0)
            {
                frm_Registrationform _ObjReg = new frm_Registrationform();

                _ObjReg.MdiParent = this;

                _ObjReg.AutoScroll = true;

                _ObjReg.Show();

            }
            else
            {
                setSystemDatePattern();

                string language = _objGirviCommon.setlanguage();
                if (language == "1")
                {
                    rbt_Marathi.Checked = true;
                }
                else if (language == "2")
                {
                    rbt_English.Checked = true;
                }
                else
                {
                    rbt_Marathi.Checked = true;
                }

                getOwnerName();
                menuStrip1.Visible = false;
                pnl_language.Visible = false;
                bttn_login_Click(this, new EventArgs());
                setCompulsaryItems();
            }
        }

        private void setCompulsaryItems()
        {
            setReceiptComulsary();
            setPrintCompulsary();
            setReceiptAutoIncrementCompulsary();
            setHideData();
        }
        public void setHideData()
        {
            DataTable dt2 = _objGirviCommon.getHideDataFeild();
            if (dt2.Rows[0][0].ToString() == "1")
            {
                rdb_hide.Checked = true;
                rdb_Unhide.Checked = false;
            }
            else
            {
                rdb_hide.Checked = false;
                rdb_Unhide.Checked = true;
            }
        }


        public void setReceiptComulsary()
        {
            DataTable dt2 = _objGirviCommon.getreceipt();
            if (dt2.Rows[0][0].ToString() == "1")
            {
                rbt_RecieptTrue.Checked = true;
                rbt_RecieptFalse.Checked = false;
            }
            else
            {
                rbt_RecieptTrue.Checked = false;
                rbt_RecieptFalse.Checked = true;
            }
        }

        public void setPrintCompulsary()
        {
            DataTable dt2 = _objGirviCommon.getprintt();
            if (dt2.Rows[0][0].ToString() == "1")
            {
                rbt_PrintTrue.Checked = true;
                rbt_PrintFalse.Checked = false;
            }
            else
            {
                rbt_RecieptTrue.Checked = false;
                rbt_RecieptFalse.Checked = true;
            }
        }

        public void setReceiptAutoIncrementCompulsary()
        {
            DataTable dt2 = _objGirviCommon.getPavtiNo();

            if (dt2.Rows[0][0].ToString() == "1")
            {
                rbt_PavtiNoYes.Checked = true;
                rbt_pavtinoNo.Checked = false;
            }
            else
            {
                rbt_PavtiNoYes.Checked = false;
                rbt_pavtinoNo.Checked = true;
            }
        }


       
        private void setSystemDatePattern()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            DateTimeFormatInfo dtfi = ci.DateTimeFormat;

            string[] SystemDateTimePatterns = new string[250];
            int o = 0;
            foreach (string name in dtfi.GetAllDateTimePatterns('d'))
            {
                SystemDateTimePatterns[o] = name;
                o++;
            }

            string[] myDateTimeFormat = { "dd/MM/yyyy", "dd/MM/yyyy" };

            if (myDateTimeFormat[0].Equals(SystemDateTimePatterns[0]) || myDateTimeFormat[1].Equals(SystemDateTimePatterns[0]))
            {


            }
            else
            {
                RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
                rkey.SetValue("sShortDate", "dd/MM/yyyy");
                rkey.SetValue("sLongDate", "dd/MM/yyyy");
                Application.Restart();
                //MessageBox.Show("Your System DateTime Format is: " + SystemDateTimePatterns[0] + "\n" + "Required DateTime Format: dd/MM/yyyy");
                //Application.Exit();
            }
        }

        private void getOwnerName()
        {
            //lbl_Owner.Text = _objGirviCommon.getCompanyData();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            bttn_login.Visible = false;
            pnl_language.Visible = false;
            Login childform = new Login();
            childform.ShowDialog();
            if (childform.result == true)
            {
                menuStrip1.Visible = true;
                pnl_language.Visible = true;
                this.BackgroundImage = null;
            }
            else
            {
                bttn_login.Visible = true;
            }
        }

    

    
    }
}
