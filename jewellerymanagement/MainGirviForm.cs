using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Girvi;
using JewelleryManagement;
using BAL;
using JewelleryManagement.Girvi;
using BAL.Common;
using JewelleryManagement.Common;
using JewelleryManagement.Reports.Girvi;
using System.Globalization;
using Microsoft.Win32;
using JwelleryManagement;
using JewelleryManagement.Common.Sql;

namespace JewelleryManagement
{
    public partial class MainGirviForm : Form
    {
        string openingbal;

        public MainGirviForm()
        {
            this.BackgroundImage = Properties.Resources._742687_jewelry_wallpaper;
            // this.statusStrip= Properties.Settings.
            InitializeComponent();
            //Timer tmr = new Timer();
            //tmr.Interval = 3000;
            //tmr.Tick += new EventHandler(changeImage);
            //tmr.Start();
        }
        cls_Bhandval _objBhandval = new cls_Bhandval();
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        LoginBAL _objLoginBAl = new LoginBAL();
        clsGirviCommon _objCommon = new clsGirviCommon();

        int x = 0;
        string texto = "Marque";
        int tam = 15;
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.designmainpage);
            b1.Add(Properties.Resources._742828_jewelry_wallpaper);
            b1.Add(Properties.Resources._742853_jewelry_wallpaper);
            b1.Add(Properties.Resources._742618_jewelry_wallpaper);
            b1.Add(Properties.Resources._743239_jewelry_wallpaper);
            int index = DateTime.Now.Second % 5;
            this.BackgroundImage = b1[index];
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

        private void girviAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GirviAdd _objfrm_GirviAdd = new frm_GirviAdd();

            if (rbt_English.Checked == true)
            {
                _objfrm_GirviAdd.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objfrm_GirviAdd.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objfrm_GirviAdd.rbt_Marathi.Checked = true;

            }
            else if (rbt_Other.Checked == true)
            {
                _objfrm_GirviAdd.rbt_OtherTrue.Checked = true;
            }
            if (rbt_Visible.Checked == true)
            {
                _objfrm_GirviAdd.rbt_Visible.Checked = true;
            }
            else if (rbt_InVisible.Checked == true)
            {
                _objfrm_GirviAdd.rbt_InVisible.Checked = true;
            }
            if (rbt_RecieptTrue.Checked == true)
            {
                _objfrm_GirviAdd.rbt_RecieptTrue.Checked = true;
            }
            else if (rbt_RecieptFalse.Checked == true)
            {
                _objfrm_GirviAdd.rbt_RecieptFalse.Checked = true;
            }
            DataTable dt = _objCommon.getPavtiNoAutoIncriment();

            if(dt.Rows[0][0].ToString() == "1")
            {
                _objfrm_GirviAdd.rbt_PavtiNoYes.Checked = true;
            }
            else 
            {
                _objfrm_GirviAdd.rbt_pavtinoNo.Checked = true;
            }

            if (rbt_no_1.Checked == true)
            {
                _objfrm_GirviAdd.rbt_no1.Checked = true;
            }
            else if (rbt_no_2.Checked == true)
            {
                _objfrm_GirviAdd.rbt_no2.Checked = true;
            }


            if (rdb_hide.Checked == true)
            {
                _objfrm_GirviAdd.rbt_hide.Checked = true;
            }
            else if (rdb_Unhide.Checked == true)
            {
                _objfrm_GirviAdd.rbt_unhide.Checked = true;
            }


            if (rbt_PrintTrue.Checked == true)
            {
                _objfrm_GirviAdd.rbt_PrintTrue.Checked = true;
            }
            else if (rbt_PrintFalse.Checked == true)
            {
                _objfrm_GirviAdd.rbt_PrintFalse.Checked = true;
            }
            if (!CheckForm(_objfrm_GirviAdd))
            {
                _objfrm_GirviAdd.MdiParent = this;
                _objfrm_GirviAdd.AutoScroll = true;
                _objfrm_GirviAdd.Show();
                _objfrm_GirviAdd.BringToFront();
            }
            else { _objfrm_GirviAdd.BringToFront(); }
        }

        private bool CheckForm(Form form)
        {
            foreach (Form f in Application.OpenForms)
                if (form.Name == f.Name)
                    return true;

            return false;
        }
        void _objMaster_Click(object sender, EventHandler e)
        {
            openingbal = _objGirviCommon.getOpeningBalance();
        }

        void _objMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            openingbal = _objGirviCommon.getOpeningBalance();
        }



        private void rbt_English_CheckedChanged(object sender, EventArgs e)
        {
            ConvertToEnglish();
            //rbt_Other.Checked = false;
        }

        private void ConvertToEnglish()
        {
            customerCopyToolStripMenuItem.Text = "Customer Copy";
            accountingToolStripMenuItem.Text = "Acccounting";
            interestRecordToolStripMenuItem.Text = "Khatawani";
            exitToolStripMenuItem.Text = "Exit ";
            settingToolStripMenuItem.Text = "Setting";
            fileMenu.Text = "Report";
            girviToolStripMenuItem1.Text = "Mortgage";
            girviAddToolStripMenuItem.Text = "Add Mortgage";
            releaseGirviToolStripMenuItem2.Text = "Release Mortgage";
            deleteGirviToolStripMenuItem.Text = " Delete/Update Mortgage";

            // interestRecordToolStripMenuItem.Text = "Interest Record";
            rokadToolStripMenuItem.Text = "Rokad";
            rokadAllToolStripMenuItem.Text = "Rokad All";
            cashBookToolStripMenuItem.Text = "Cash Book";
            bhandvalToolStripMenuItem.Text = "Bhandwal";
            cashInHandToolStripMenuItem.Text = "Cash In Hand";
            aRRequiredToolStripMenuItem.Text = "A. R ";
            allGirviReletedToKhatawaniToolStripMenuItem.Text = "All Mortgage Report";
            allReleasedGirviRToolStripMenuItem.Text = "All Released Mortgage Report ";
            allUnReleaseGirviReleatedToKhatawaniToolStripMenuItem.Text = "All Unreleased Mortgage Report";

            allGirviReletedToKhatawaniUnReleasedToolStripMenuItem.Text = "All Mortgage customer information";
            girviReportToolStripMenuItem.Text = "Girvi Registration ";

            totalInterestToolStripMenuItem.Text = "Total Interest";

            forwordReportToolStripMenuItem.Text = "Forword Report";
            interestPaidToolStripMenuItem.Text = "Interest Paid";
            girviProfitLossToolStripMenuItem.Text = "Mortgage Profit Loss";
            girviByAddressToolStripMenuItem.Text = "Mortgage By Address";
            duplicateBillToolStripMenuItem.Text = "Duplicate Bill";
            girviAddToolStripMenuItem1.Text = "Add Mortgage";
            releasedGirviToolStripMenuItem.Text = "Release Mortgage";
            masterToolStripMenuItem.Text = "Accounting";
            yearToolStripMenuItem1.Text = "Year";
            addressToolStripMenuItem.Text = "Address";
            tahsilToolStripMenuItem.Text = "Tahsil";
            goldSilverRateToolStripMenuItem.Text = "Gold / Silver Rate";
            casteMasterToolStripMenuItem1.Text = "Caste Master";
            nOTICEToolStripMenuItem.Text = "Notice";
            vinaTaranReportToolStripMenuItem.Text = "Vina Taran Report";
            vayajReportToolStripMenuItem.Text = "Vayaj Report";
            customeRDataPrintToolStripMenuItem.Text = " Customer Report Print";

        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            ConvertToMarathi();
            //rbt_Other.Checked = false;
        }
        private void ConvertToMarathi()
        {
            exitToolStripMenuItem.Text = "बंद ";
            settingToolStripMenuItem.Text = "सेटिंग ";
            fileMenu.Text = "रिपोर्ट";
            girviToolStripMenuItem1.Text = "गाहणी";
            girviAddToolStripMenuItem.Text = "गाहणी ठेवा";
            releaseGirviToolStripMenuItem2.Text = "गाहणी सोडवा";
            deleteGirviToolStripMenuItem.Text = "डिलीट/अपडेट गाहणी ";

            interestRecordToolStripMenuItem.Text = "खतावणी";
            rokadToolStripMenuItem.Text = "रोकड";
            rokadAllToolStripMenuItem.Text = "रोकड तरीखेनुसार";
            cashBookToolStripMenuItem.Text = "कॅश बुक";
            bhandvalToolStripMenuItem.Text = "भांडवल";
            cashInHandToolStripMenuItem.Text = "खात्यामधील जमा रक्कम";
            aRRequiredToolStripMenuItem.Text = "ए. आर";
            allGirviReletedToKhatawaniToolStripMenuItem.Text = "संपूर्ण गाहणी रिपोर्ट";
            allReleasedGirviRToolStripMenuItem.Text = "गाहणी सोडवलेली रिपोर्ट";
            allUnReleaseGirviReleatedToKhatawaniToolStripMenuItem.Text = "गाहणी नसोडवलेली रिपोर्ट";
            allGirviReletedToKhatawaniUnReleasedToolStripMenuItem.Text = "गाहणी माहिती ग्राहकाची रिपोर्ट";
            girviReportToolStripMenuItem.Text = "गाहणी रिपोर्ट ";
            totalInterestToolStripMenuItem.Text = "संपूर्ण व्याज";

            forwordReportToolStripMenuItem.Text = "फोरवोर्ड रिपोर्ट";
            interestPaidToolStripMenuItem.Text = "व्याज पेड";
            girviProfitLossToolStripMenuItem.Text = "गाहणी फायदा/नुकसान";
            girviByAddressToolStripMenuItem.Text = "गाहणी रिपोर्ट'पत्तानुसार'";
            duplicateBillToolStripMenuItem.Text = "डुप्लिकेट 'बिल'";
            girviAddToolStripMenuItem1.Text = "गाहणी ठेवा";
            releasedGirviToolStripMenuItem.Text = "गाहणी सोडवा";
            masterToolStripMenuItem.Text = "मास्टर ";
            yearToolStripMenuItem1.Text = "वर्ष मास्टर";
            addressToolStripMenuItem.Text = "पत्ता मास्टर";
            tahsilToolStripMenuItem.Text = "तहसील मास्टर";
            goldSilverRateToolStripMenuItem.Text = "सोना / चांदी चा दर";
            casteMasterToolStripMenuItem1.Text = "जात मास्टर";
            accountingToolStripMenuItem.Text = "अकाउंटिंग";
            nOTICEToolStripMenuItem.Text = "नोटिस";
            customerCopyToolStripMenuItem.Text = "ग्राहक कॉपी";
            balanceSheetMonthlyToolStripMenuItem.Text = "ब्यालेंस शीट महिने प्रमाणे";
            formNo12ToolStripMenuItem.Text = "फॉर्म नं.12";
            vaarshikVivranPatraToolStripMenuItem.Text = "वार्षिक विवरण पत्र";
            officeCopyToolStripMenuItem.Text = "ऑफिस कॉपी";
            tahsilReportToolStripMenuItem.Text = "गाहणी रिपोर्ट'तहसील प्रमाणे'";
            sixMonthReportToolStripMenuItem.Text = " सहा महिन्यांची रिकॉर्ड";
            vinaTaranReportToolStripMenuItem.Text = "विना तारण रिपोर्ट";
            viewPhotosToolStripMenuItem.Text = "फोटो बघा";
            allKhatwaniWisePrintoutToolStripMenuItem.Text = "सर्वं खातावनी तारखे प्रमाणे प्रिंट";
            openingAccountToolStripMenuItem1.Text = " खात्याची रक्कम ";

            creditCashToolStripMenuItem.Text = "क्रेडिट रोख";
            debitCashToolStripMenuItem.Text = "डेबिट रोख";
            trailBalanceToolStripMenuItem.Text = "trail शिल्लक";
            creditDebitReportToolStripMenuItem.Text = "क्रेडिट/डेबिट रिकॉर्ड ";
            balanceSheetToolStripMenuItem1.Text = "balance sheet";
            vayajReportToolStripMenuItem.Text = "व्याज रिपोर्ट ";
            customeRDataPrintToolStripMenuItem.Text = " ग्राहक रिपोर्ट प्रिंट";



        }

        private void rbt_Hindii_CheckedChanged(object sender, EventArgs e)
        {
            ConvertToHindi();
            //rbt_Other.Checked = false;
        }

        private void ConvertToHindi()
        {
            exitToolStripMenuItem.Text = "बंद ";
            settingToolStripMenuItem.Text = "सेटिंग ";
            fileMenu.Text = "रिपोर्ट";
            girviToolStripMenuItem1.Text = "गिरवी";
            girviAddToolStripMenuItem.Text = "गिरवी रखिये";
            releaseGirviToolStripMenuItem2.Text = "गिरवी छुडाइये ";
            deleteGirviToolStripMenuItem.Text = "डिलीट/अपडेट गिरवी";

            interestRecordToolStripMenuItem.Text = "खतावणी";
            rokadToolStripMenuItem.Text = "रोकड रक्कम";
            rokadAllToolStripMenuItem.Text = "रोकड रक्कम (तरीखेनुसार)";
            cashBookToolStripMenuItem.Text = "कॅश बुक";
            bhandvalToolStripMenuItem.Text = "भांडवल";
            cashInHandToolStripMenuItem.Text = " रोकड रक्कम जमा ";
            aRRequiredToolStripMenuItem.Text = "ए.आर.";
            allGirviReletedToKhatawaniToolStripMenuItem.Text = "पुरी गिरवी रिपोर्ट";
            allReleasedGirviRToolStripMenuItem.Text = "गिरवी छुटी हुई रिपोर्ट";
            allUnReleaseGirviReleatedToKhatawaniToolStripMenuItem.Text = "गिरवी नही छुटी हुई रिपोर्ट";
            allGirviReletedToKhatawaniUnReleasedToolStripMenuItem.Text = "गिरवी माहिती ग्राहकाची रिपोर्ट";
            girviReportToolStripMenuItem.Text = "गिरवी रिपोर्ट ";

            totalInterestToolStripMenuItem.Text = "पुरा ब्याज";
            forwordReportToolStripMenuItem.Text = "फोरवोर्ड रिपोर्ट";
            interestPaidToolStripMenuItem.Text = "ब्याज पेड";
            girviProfitLossToolStripMenuItem.Text = "गिरवी फायदा/नुकसान";
            girviByAddressToolStripMenuItem.Text = "गिरवी यादी'पत्तानुसार";
            duplicateBillToolStripMenuItem.Text = "डूप्लीकेट बिल";
            girviAddToolStripMenuItem1.Text = "गिरवी रखिये";
            releasedGirviToolStripMenuItem.Text = "गिरवी छुडाइये";
            masterToolStripMenuItem.Text = "मास्टर ";
            yearToolStripMenuItem1.Text = "साल मास्टर";
            addressToolStripMenuItem.Text = "पत्ता मास्टर";
            tahsilToolStripMenuItem.Text = "तहसील मास्टर";
            goldSilverRateToolStripMenuItem.Text = "सोना / चांदी भाव";
            casteMasterToolStripMenuItem1.Text = "जात मास्टर";
            accountingToolStripMenuItem.Text = "अकाउंटिंग";
            nOTICEToolStripMenuItem.Text = "नोटिस";
            customerCopyToolStripMenuItem.Text = "ग्राहक कॉपी";
            sixMonthReportToolStripMenuItem.Text = " छह महीनेका रिकॉर्ड";
            vinaTaranReportToolStripMenuItem.Text = "विना तारण रिपोर्ट";
            vayajReportToolStripMenuItem.Text = "व्याज रिपोर्ट ";
            customeRDataPrintToolStripMenuItem.Text = " ग्राहक रिपोर्ट प्रिंट";
        }

        private void frm_Girvi_Load(object sender, EventArgs e)
        {
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
                menuStrip.Visible = false;
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
            lbl_Owner.Text = _objGirviCommon.getCompanyData();
        }

        private void relieseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ReleaseGirvi _objReleaseGirvi = new frm_ReleaseGirvi();

            if (rbt_English.Checked == true)
            {
                _objReleaseGirvi.rbt_English.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objReleaseGirvi.rbt_OtherTrue.Checked = true;
            }

            else if (rbt_Hindii.Checked == true)
            {
                _objReleaseGirvi.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objReleaseGirvi.rbt_Marathi.Checked = true;
            }
           

            if (rbt_PrintTrue.Checked ==true)
            {
                _objReleaseGirvi.rbt_PrintTrue.Checked = true;
            }
            else if (rbt_PrintFalse.Checked == true)
            {
                _objReleaseGirvi.rbt_PrintFalse.Checked = true;
            }
            



            if (rbt_no_1.Checked == true)
            {
                _objReleaseGirvi.rbt_no1.Checked = true;
            }
            else if (rbt_no_2.Checked == true)
            {
                _objReleaseGirvi.rbt_no2.Checked = true;
            }




            DataTable dt = _objCommon.getPavtiNoAutoIncriment();
            if (dt.Rows[0][0].ToString() == "1")
            {
                _objReleaseGirvi.rbt_PavtiNoYes.Checked = true;
            }
            else 
            {
                _objReleaseGirvi.rbt_pavtinoNo.Checked = true;
            }
            if (!CheckForm(_objReleaseGirvi))
            {

                _objReleaseGirvi.MdiParent = this;

                _objReleaseGirvi.AutoScroll = true;

                _objReleaseGirvi.Show();

            }
            else
            {
                _objReleaseGirvi.BringToFront();
            }


        }

        private void deleteGirviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Password pa = new frm_Password();

            if (pa.ShowDialog() == DialogResult.OK)
            {
                frm_DeleteGirvi _objDeleteGirvi = new frm_DeleteGirvi();
                // _objIntersetTaking.FormClosed += new FormClosedEventHandler(_objMaster_FormClosed);
                if (rbt_English.Checked == true)
                {
                    _objDeleteGirvi.rbt_English.Checked = true;
                }
                if (rbt_Other.Checked == true)
                {
                    _objDeleteGirvi.rbt_OtherTrue.Checked = true;
                }
                else if (rbt_Hindii.Checked == true)
                {
                    _objDeleteGirvi.rbt_Hindi.Checked = true;
                }
                else if (rbt_Marathi.Checked == true)
                {
                    _objDeleteGirvi.rbt_Marathi.Checked = true;
                }


                if (!CheckForm(_objDeleteGirvi))
                {

                    _objDeleteGirvi.MdiParent = this;

                    _objDeleteGirvi.AutoScroll = true;

                    _objDeleteGirvi.Show();

                }
                else { _objDeleteGirvi.BringToFront(); }
            }
        }



        private void addGoldSilverRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddGoldSilverRate _objAddGoldSilverRate = new frm_AddGoldSilverRate();

            if (!CheckForm(_objAddGoldSilverRate))
            {

                _objAddGoldSilverRate.MdiParent = this;

                _objAddGoldSilverRate.AutoScroll = true;

                _objAddGoldSilverRate.Show();

            }
            else { _objAddGoldSilverRate.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objAddGoldSilverRate.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objAddGoldSilverRate.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objAddGoldSilverRate.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objAddGoldSilverRate.rbt_OtherTrue.Checked = true;
            }

        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddYear _objYear = new frm_AddYear();
            if (!CheckForm(_objYear))
            {

                _objYear.MdiParent = this;

                _objYear.AutoScroll = true;

                _objYear.Show();

            }
            else { _objYear.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objYear.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objYear.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objYear.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objYear.rbt_OtherTrue.Checked = true;
            }

        }

        private void openingAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.OpeningAccount _objOpeningAccount = new Common.OpeningAccount();
            if (!CheckForm(_objOpeningAccount))
            {
                _objOpeningAccount.MdiParent = this;

                _objOpeningAccount.AutoScroll = true;

                _objOpeningAccount.Show();

            }
            else { _objOpeningAccount.BringToFront(); }

        }



        private void adressMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddressMaster _obj_AddressMaster = new frm_AddressMaster();
            if (!CheckForm(_obj_AddressMaster))
            {
                _obj_AddressMaster.MdiParent = this;

                _obj_AddressMaster.AutoScroll = true;

                _obj_AddressMaster.Show();

            }
            else { _obj_AddressMaster.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _obj_AddressMaster.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _obj_AddressMaster.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _obj_AddressMaster.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _obj_AddressMaster.rbt_OtherTrue.Checked = true;
            }
        }

        private void tahsilMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TahsilMaster _objTahsilMaster = new frm_TahsilMaster();
            if (!CheckForm(_objTahsilMaster))
            {
                _objTahsilMaster.MdiParent = this;

                _objTahsilMaster.AutoScroll = true;

                _objTahsilMaster.Show();

            }
            else { _objTahsilMaster.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objTahsilMaster.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objTahsilMaster.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objTahsilMaster.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objTahsilMaster.rbt_OtherTrue.Checked = true;
            }
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.Frm_TrialBalance _objTrialBalance = new Common.Frm_TrialBalance();

            if (!CheckForm(_objTrialBalance))
            {

                _objTrialBalance.MdiParent = this;

                _objTrialBalance.AutoScroll = true;

                _objTrialBalance.Show();

            }
            else { _objTrialBalance.BringToFront(); }
            //if (rbt_English.Checked == true)
            //{
            //    _objTrialBalance.rbt_English.Checked = true;
            //}
            //else if (rbt_Hindii.Checked == true)
            //{
            //    _objTrialBalance.rbt_Hindi.Checked = true;
            //}
            //else if (rbt_Marathi.Checked == true)
            //{
            //    _objTrialBalance.rbt_Marathi.Checked = true;
            //}
            //else if (rbt_Other.Checked == true)
            //{
            //    _objTrialBalance.rbt_OtherTrue.Checked = true;
            //}
        }

        private void interestRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Girvi.frm_InterestRecord _objInterestRecord = new Reports.Girvi.frm_InterestRecord();
            // _objIntersetRecordMastercs.FormClosed += new FormClosedEventHandler(_objMaster_FormClosed);
            if (rbt_English.Checked == true)
            {
                _objInterestRecord.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objInterestRecord.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objInterestRecord.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objInterestRecord.rbt_OtherTrue.Checked = true;
            }

            if (!CheckForm(_objInterestRecord))
            {

                _objInterestRecord.MdiParent = this;

                _objInterestRecord.AutoScroll = true;

                _objInterestRecord.Show();

            }
            else { _objInterestRecord.BringToFront(); }

        }

        private void rokadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Girvi.frm_Rokad _objRokad = new Reports.Girvi.frm_Rokad();

            if (rbt_English.Checked == true)
            {
                _objRokad.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objRokad.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objRokad.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objRokad.rbt_OtherTrue.Checked = true;

            }

            if (!CheckForm(_objRokad))
            {

                _objRokad.MdiParent = this;

                _objRokad.AutoScroll = true;

                _objRokad.Show();

            }
            else { _objRokad.BringToFront(); }
        }

        private void rokadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RokadAll _objRokadAll = new frm_RokadAll();

            if (rbt_English.Checked == true)
            {
                _objRokadAll.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objRokadAll.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objRokadAll.rbt_Marathi.Checked = true;

            }
            else if (rbt_Other.Checked == true)
            {
                _objRokadAll.rbt_OtherTrue.Checked = true;

            }

            if (!CheckForm(_objRokadAll))
            {

                _objRokadAll.MdiParent = this;

                _objRokadAll.AutoScroll = true;

                _objRokadAll.Show();

            }
            else { _objRokadAll.BringToFront(); }

        }

        private void cashBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Girvi.frm_CashBook _objCashBook = new Reports.Girvi.frm_CashBook();
            if (!CheckForm(_objCashBook))
            {

                _objCashBook.MdiParent = this;

                _objCashBook.AutoScroll = true;

                _objCashBook.Show();
                if (rbt_English.Checked == true)
                {
                    _objCashBook.rbt_English.Checked = true;
                }
                else if (rbt_Hindii.Checked == true)
                {
                    _objCashBook.rbt_Hindi.Checked = true;
                }
                else if (rbt_Marathi.Checked == true)
                {
                    _objCashBook.rbt_Marathi.Checked = true;

                }
                else if (rbt_Other.Checked == true)
                {
                    _objCashBook.rbt_OtherTrue.Checked = true;

                }

            }
            else { _objCashBook.BringToFront(); }
        }

        private void bhandvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Girvi.frm_Bhandwal _objBhandval = new Reports.Girvi.frm_Bhandwal();
            if (rbt_English.Checked == true)
            {
                _objBhandval.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objBhandval.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objBhandval.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objBhandval.rbt_OtherTrue.Checked = true;
            }
            if (!CheckForm(_objBhandval))
            {
                _objBhandval.MdiParent = this;

                _objBhandval.AutoScroll = true;

                _objBhandval.Show();
            }
            else { _objBhandval.BringToFront(); }
        }

        private void cashInHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Girvi.frm_CashInHand _objCashInHand = new Reports.Girvi.frm_CashInHand();
            if (rbt_English.Checked == true)
            {
                _objCashInHand.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objCashInHand.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objCashInHand.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objCashInHand.rbt_OtherTrue.Checked = true;
            }

            if (!CheckForm(_objCashInHand))
            {
                _objCashInHand.MdiParent = this;

                _objCashInHand.AutoScroll = true;

                _objCashInHand.Show();
            }
            else { _objCashInHand.BringToFront(); }
        }

        private void allGirviReletedToKhatawaniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.Girvi.ARRequired.Frm_allkhatawaniGirviDetails _objAllGirviReletedKhatawani = new Report.Girvi.ARRequired.Frm_allkhatawaniGirviDetails();

            if (!CheckForm(_objAllGirviReletedKhatawani))
            {

                _objAllGirviReletedKhatawani.MdiParent = this;

                _objAllGirviReletedKhatawani.AutoScroll = true;

                _objAllGirviReletedKhatawani.Show();
                if (rbt_English.Checked == true)
                {
                    _objAllGirviReletedKhatawani.rbt_English.Checked = true;
                }
                else if (rbt_Hindii.Checked == true)
                {
                    _objAllGirviReletedKhatawani.rbt_Hindi.Checked = true;
                }
                else if (rbt_Marathi.Checked == true)
                {
                    _objAllGirviReletedKhatawani.rbt_Marathi.Checked = true;
                }
                else if (rbt_Other.Checked == true)
                {
                    _objAllGirviReletedKhatawani.rbt_OtherTrue.Checked = true;
                }

            }
            else { _objAllGirviReletedKhatawani.BringToFront(); }
            //if (rbt_English.Checked == true)
            //{
            //    _objAllGirviReletedKhatawani.rbt_English.Checked = true;
            //}
            //else if (rbt_Hindii.Checked == true)
            //{
            //    _objAllGirviReletedKhatawani.rbt_Hindi.Checked = true;
            //}
            //else if (rbt_Marathi.Checked == true)
            //{
            //    _objAllGirviReletedKhatawani.rbt_Marathi.Checked = true;
            //}
        }

        private void allReleasedGirviRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.Girvi.ARRequired.Frm_allkhatawaniReleasedGirviDetails _objAllReleasedGirviReleatedToKhatawani = new Report.Girvi.ARRequired.Frm_allkhatawaniReleasedGirviDetails();
            if (!CheckForm(_objAllReleasedGirviReleatedToKhatawani))
            {
                _objAllReleasedGirviReleatedToKhatawani.MdiParent = this;
                _objAllReleasedGirviReleatedToKhatawani.AutoScroll = true;
                _objAllReleasedGirviReleatedToKhatawani.Show();
            }
            else { _objAllReleasedGirviReleatedToKhatawani.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objAllReleasedGirviReleatedToKhatawani.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objAllReleasedGirviReleatedToKhatawani.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objAllReleasedGirviReleatedToKhatawani.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objAllReleasedGirviReleatedToKhatawani.rbt_OtherTrue.Checked = true;
            }
        }

        private void allUnReleaseGirviReleatedToKhatawaniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.Girvi.ARRequired.Frm_allkhatawaniUnReleasedGirviDetails _objAllUnreleaseGirviReleatedToKhatawani = new Report.Girvi.ARRequired.Frm_allkhatawaniUnReleasedGirviDetails();
            if (!CheckForm(_objAllUnreleaseGirviReleatedToKhatawani))
            {

                _objAllUnreleaseGirviReleatedToKhatawani.MdiParent = this;

                _objAllUnreleaseGirviReleatedToKhatawani.AutoScroll = true;

                _objAllUnreleaseGirviReleatedToKhatawani.Show();

            }
            else { _objAllUnreleaseGirviReleatedToKhatawani.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objAllUnreleaseGirviReleatedToKhatawani.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objAllUnreleaseGirviReleatedToKhatawani.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objAllUnreleaseGirviReleatedToKhatawani.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objAllUnreleaseGirviReleatedToKhatawani.rbt_OtherTrue.Checked = true;
            }
        }

        private void allGirviReletedToKhatawaniUnReleasedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.Girvi.ARRequired.Frm_allkhatawaniGirviAddedDetails _objAllGirviReletedToKhatawaniUnreleased = new Report.Girvi.ARRequired.Frm_allkhatawaniGirviAddedDetails();
            if (!CheckForm(_objAllGirviReletedToKhatawaniUnreleased))
            {

                _objAllGirviReletedToKhatawaniUnreleased.MdiParent = this;

                _objAllGirviReletedToKhatawaniUnreleased.AutoScroll = true;

                _objAllGirviReletedToKhatawaniUnreleased.Show();

            }
            else { _objAllGirviReletedToKhatawaniUnreleased.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objAllGirviReletedToKhatawaniUnreleased.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objAllGirviReletedToKhatawaniUnreleased.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objAllGirviReletedToKhatawaniUnreleased.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objAllGirviReletedToKhatawaniUnreleased.rbt_OtherTrue.Checked = true;
            }

        }

        private void totalInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Girvi.frm_TotalInterest _objInterestRecord = new Reports.Girvi.frm_TotalInterest();
            //if (rbt_English.Checked == true)
            //{
            //    _objInterestRecord.rbt_English.Checked = true;
            //}
            //else if (rbt_Marathi.Checked == true)
            //{
            //    _objInterestRecord.rbt_Marathi.Checked = true;
            //}
            //else if (rbt_Hindii.Checked == true)
            //{
            //    _objInterestRecord.rbt_Hindi.Checked = true;
            //}
            //else if (rbt_Other.Checked == true)
            //{
            //    _objInterestRecord.rbt_OtherTrue.Checked = true;
            //}
            if (!CheckForm(_objInterestRecord))
            {
                _objInterestRecord.MdiParent = this;

                _objInterestRecord.AutoScroll = true;

                _objInterestRecord.Show();
            }
            else { _objInterestRecord.BringToFront(); }
        }



        private void forwordReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Girvi.frm_ForwordGirvi _objForwordReport = new Reports.Girvi.frm_ForwordGirvi();
            if (!CheckForm(_objForwordReport))
            {

                _objForwordReport.MdiParent = this;

                _objForwordReport.AutoScroll = true;

                _objForwordReport.Show();
                if (rbt_English.Checked == true)
                {
                    _objForwordReport.rbt_English.Checked = true;
                }
                else if (rbt_Hindii.Checked == true)
                {
                    _objForwordReport.rbt_Hindi.Checked = true;
                }
                else if (rbt_Marathi.Checked == true)
                {
                    _objForwordReport.rbt_Marathi.Checked = true;
                }
                else if (rbt_Other.Checked == true)
                {
                    _objForwordReport.rbt_OtherTrue.Checked = true;
                }

            }
            else { _objForwordReport.BringToFront(); }
        }

        private void interestPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Reports.Girvi.frm_InterestPaid _objInterestPaid = new Reports.Girvi.frm_InterestPaid();
            if (!CheckForm(_objInterestPaid))
            {

                _objInterestPaid.MdiParent = this;

                _objInterestPaid.AutoScroll = true;

                _objInterestPaid.Show();

            }
            else { _objInterestPaid.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objInterestPaid.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objInterestPaid.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objInterestPaid.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objInterestPaid.rbt_OtherTrue.Checked = true;
            }
        }


        private void girviProfitLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Girvi.frm_ProfitLoss _objProfitLoss = new Reports.Girvi.frm_ProfitLoss();
            if (!CheckForm(_objProfitLoss))
            {
                _objProfitLoss.MdiParent = this;

                _objProfitLoss.AutoScroll = true;

                _objProfitLoss.Show();

            }
            else { _objProfitLoss.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objProfitLoss.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objProfitLoss.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objProfitLoss.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objProfitLoss.rbt_OtherTrue.Checked = true;
            }
        }

        private void girviByAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Reports.Girvi.Frm_CustomerDetailsByVillageName _objGirviByAddress = new Reports.Girvi.Frm_CustomerDetailsByVillageName();



            if (!CheckForm(_objGirviByAddress))
            {
                _objGirviByAddress.MdiParent = this;

                _objGirviByAddress.AutoScroll = true;

                _objGirviByAddress.Show();
            }
            else
            {
                _objGirviByAddress.BringToFront();
            }

            if (rbt_English.Checked == true)
            {
                _objGirviByAddress.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objGirviByAddress.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objGirviByAddress.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objGirviByAddress.rbt_OtherTrue.Checked = true;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
            Application.Exit();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Common.Frm_BalanceSheetForm _objRokadAllUnrelease = new JewelleryManagement.Common.Frm_BalanceSheetForm();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
        }

        public bool rbt { get; set; }

        private void girviAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Girvi.FrmDuplicateGirviAddPrint _objRokadAllUnrelease = new JewelleryManagement.Girvi.FrmDuplicateGirviAddPrint();
            if (!CheckForm(_objRokadAllUnrelease))
            {
                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();
            }
            else { _objRokadAllUnrelease.BringToFront(); }

            if (rbt_English.Checked == true)
            {
                _objRokadAllUnrelease.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objRokadAllUnrelease.rbt_OtherTrue.Checked = true;
            }
        }

        private void casteMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Girvi.Frm_CasteMaster _objRokadAllUnrelease = new JewelleryManagement.Girvi.Frm_CasteMaster();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            bttn_login.Visible = false;
            pnl_language.Visible = false;
            bttn_facebook.Visible = false;
            bttn_google.Visible = false;
            bttnz_twiter.Visible = false;
            Login childform = new Login();
            childform.ShowDialog();
            if (childform.result == true)
            {
                menuStrip.Visible = true;

                pnl_language.Visible = true;
                bttnz_twiter.Visible = true;
                bttn_facebook.Visible = true;
                bttn_google.Visible = true;
                this.BackgroundImage = null;
                //bttn_login.Visible = true;
                pnl_language.Visible = true;

            }
            else
            {
                bttn_login.Visible = true;
            }
        }

        private void rbt_Other_CheckedChanged(object sender, EventArgs e)
        {
            ConvertToMarathi();
            //rbt_Marathi.Checked = true;
        }


        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddressMaster _obj_AddressMaster = new frm_AddressMaster();
            if (!CheckForm(_obj_AddressMaster))
            {
                _obj_AddressMaster.MdiParent = this;

                _obj_AddressMaster.AutoScroll = true;

                _obj_AddressMaster.Show();

            }
            else { _obj_AddressMaster.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _obj_AddressMaster.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _obj_AddressMaster.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _obj_AddressMaster.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _obj_AddressMaster.rbt_OtherTrue.Checked = true;
            }
        }

        private void yearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_AddYear _objYear = new frm_AddYear();
            if (!CheckForm(_objYear))
            {

                _objYear.MdiParent = this;

                _objYear.AutoScroll = true;

                _objYear.Show();

            }
            else { _objYear.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objYear.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objYear.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objYear.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objYear.rbt_OtherTrue.Checked = true;
            }

        }

        private void goldSilverRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddGoldSilverRate _objAddGoldSilverRate = new frm_AddGoldSilverRate();

            if (!CheckForm(_objAddGoldSilverRate))
            {

                _objAddGoldSilverRate.MdiParent = this;

                _objAddGoldSilverRate.AutoScroll = true;

                _objAddGoldSilverRate.Show();

            }
            else { _objAddGoldSilverRate.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objAddGoldSilverRate.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objAddGoldSilverRate.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objAddGoldSilverRate.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objAddGoldSilverRate.rbt_OtherTrue.Checked = true;
            }
        }

        private void tahsilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TahsilMaster _objTahsilMaster = new frm_TahsilMaster();
            if (!CheckForm(_objTahsilMaster))
            {
                _objTahsilMaster.MdiParent = this;

                _objTahsilMaster.AutoScroll = true;

                _objTahsilMaster.Show();

            }
            else { _objTahsilMaster.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objTahsilMaster.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objTahsilMaster.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objTahsilMaster.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objTahsilMaster.rbt_OtherTrue.Checked = true;
            }
        }



        private void casteMasterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Girvi.Frm_CasteMaster _objRokadAllUnrelease = new JewelleryManagement.Girvi.Frm_CasteMaster();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
        }

        private void openingAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common.OpeningAccount _objOpeningAccount = new Common.OpeningAccount();
            if (!CheckForm(_objOpeningAccount))
            {
                _objOpeningAccount.MdiParent = this;

                _objOpeningAccount.AutoScroll = true;

                _objOpeningAccount.Show();

            }
            else { _objOpeningAccount.BringToFront(); }
        }

        private void trailBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.Frm_TrialBalance _objTrialBalance = new Common.Frm_TrialBalance();

            if (!CheckForm(_objTrialBalance))
            {
                _objTrialBalance.MdiParent = this;

                _objTrialBalance.AutoScroll = true;

                _objTrialBalance.Show();

            }
            else { _objTrialBalance.BringToFront(); }
        }



        private void balanceSheetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Common.Frm_BalanceSheet _objRokadAllUnrelease = new JewelleryManagement.Common.Frm_BalanceSheet();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
        }



        private void MainGirviForm_Deactivate(object sender, EventArgs e)
        {
            SendKeys.Send("^(2)");
        }

        private void customerCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            JewelleryManagement.Reports.Girvi.Frm_Notice _objRokadAllUnrelease = new JewelleryManagement.Reports.Girvi.Frm_Notice();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objRokadAllUnrelease.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objRokadAllUnrelease.rbt_OtherTrue.Checked = true;
            }
        }

        private void balanceSheetMonthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BalansheetMonthly _objRokadAllUnrelease = new Frm_BalansheetMonthly();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }

            if (rbt_English.Checked == true)
            {
                _objRokadAllUnrelease.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objRokadAllUnrelease.rbt_OtherTrue.Checked = true;
            }
        }

        private void creditCashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.Credit_Debit.frm_CreditForm _objRokadAllUnrelease = new Common.Credit_Debit.frm_CreditForm();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
        }

        private void debitCashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.Credit_Debit.frm_DebitForm _objRokadAllUnrelease = new Common.Credit_Debit.frm_DebitForm();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
        }

        private void formNo12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Form12Report _objRokadAllUnrelease = new Frm_Form12Report();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objRokadAllUnrelease.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objRokadAllUnrelease.rbt_OtherTrue.Checked = true;
            }
        }


        private void releasedGirviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DuplicateGirviRelease _objDuprelease = new frm_DuplicateGirviRelease();
            if (!CheckForm(_objDuprelease))
            {

                _objDuprelease.MdiParent = this;

                _objDuprelease.AutoScroll = true;

                _objDuprelease.Show();


            }
            else { _objDuprelease.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objDuprelease.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objDuprelease.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objDuprelease.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objDuprelease.rbt_OtherTrue.Checked = true;
            }
        }


        private void allKhatwaniWisePrintoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_KhatawaniList _objKhatawaniList = new frm_KhatawaniList();
            if (!CheckForm(_objKhatawaniList))
            {
                _objKhatawaniList.MdiParent = this;

                _objKhatawaniList.AutoScroll = true;

                _objKhatawaniList.Show();
            }
            else { _objKhatawaniList.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objKhatawaniList.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objKhatawaniList.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objKhatawaniList.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objKhatawaniList.rbt_PrintTrue.Checked = true;
            }
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _objGirviCommon.setreceipt("1");

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

        private void sQLConvertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dbbackup _objfrm_dbbackup = new frm_dbbackup();
            if (!CheckForm(_objfrm_dbbackup))
            {
                _objfrm_dbbackup.MdiParent = this;

                _objfrm_dbbackup.AutoScroll = true;

                _objfrm_dbbackup.Show();
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_DatabaseBackup _objfrm_dbbackup = new Frm_DatabaseBackup();
            _objfrm_dbbackup.Show();

        }


        private void trueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _objGirviCommon.setprint("1");

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

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _objGirviCommon.setreceipt("0");

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

        private void falseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _objGirviCommon.setprint("0");

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

        private void vaarshikVivranPatraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Form14Report _objRokadAllUnrelease = new Frm_Form14Report();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objRokadAllUnrelease.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objRokadAllUnrelease.rbt_OtherTrue.Checked = true;
            }
        }

        private void officeCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_BabhulgaonOfficeCopy _objRokadAllUnrelease = new Frm_BabhulgaonOfficeCopy();
            if (!CheckForm(_objRokadAllUnrelease))
            {

                _objRokadAllUnrelease.MdiParent = this;

                _objRokadAllUnrelease.AutoScroll = true;

                _objRokadAllUnrelease.Show();

            }
            else { _objRokadAllUnrelease.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objRokadAllUnrelease.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objRokadAllUnrelease.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objRokadAllUnrelease.rbt_OtherTrue.Checked = true;
            }
        }

        private void compulsaryYesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _objGirviCommon.setPavtiNo("1");

            DataTable dt2 = _objGirviCommon.getPavtiNo();

            if (dt2.Rows[0][0].ToString() == "1")
            {
                rbt_PavtiNoYes.Checked = true;
                rbt_pavtinoNo.Checked = false;
            }
            else
            {
                rbt_PavtiNoYes.Checked = true;
                rbt_pavtinoNo.Checked = false;
            }

        }

        private void compulsaryNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _objGirviCommon.setPavtiNo("0");

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


        private void creditDebitReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.frm_CreditDebitRecord _objfrm_dbbackup = new Reports.frm_CreditDebitRecord();
            if (!CheckForm(_objfrm_dbbackup))
            {
                _objfrm_dbbackup.MdiParent = this;

                _objfrm_dbbackup.AutoScroll = true;

                _objfrm_dbbackup.Show();
            }

        }

        private void tahsilReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Reports.Girvi.Frm_CustomerDetailsByTahsilName _objGirviByAddress = new Reports.Girvi.Frm_CustomerDetailsByTahsilName();

            if (rbt_English.Checked == true)
            {
                _objGirviByAddress.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objGirviByAddress.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objGirviByAddress.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objGirviByAddress.rbt_OtherTrue.Checked = true;
            }

            if (!CheckForm(_objGirviByAddress))
            {
                _objGirviByAddress.MdiParent = this;

                _objGirviByAddress.AutoScroll = true;

                _objGirviByAddress.Show();
            }
            else
            {
                _objGirviByAddress.BringToFront();
            }

        }



        private void eMICalculetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Girvi.frm_EmiCalculetor _objEmi = new JewelleryManagement.Girvi.frm_EmiCalculetor();
            if (!CheckForm(_objEmi))
            {
                _objEmi.MdiParent = this;

                _objEmi.AutoScroll = true;

                _objEmi.Show();
            }
            else
            {
                _objEmi.BringToFront();
            }
            if (rbt_English.Checked == true)
            {
                _objEmi.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objEmi.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objEmi.rbt_Marathi.Checked = true;
            }
        }

        private void viewPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Report.Girvi.Frm_ViewPhotos _objGirviByAddress = new JewelleryManagement.Report.Girvi.Frm_ViewPhotos();

            if (rbt_English.Checked == true)
            {
                _objGirviByAddress.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objGirviByAddress.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objGirviByAddress.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objGirviByAddress.rbt_OtherTrue.Checked = true;
            }

            if (!CheckForm(_objGirviByAddress))
            {
                _objGirviByAddress.MdiParent = this;

                _objGirviByAddress.AutoScroll = true;

                _objGirviByAddress.Show();
            }
            else
            {
                _objGirviByAddress.BringToFront();
            }

        }

        private void no1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // _objGirviCommon.setaccounttype("1");

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
        }

        private void no2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  _objGirviCommon.setaccounttype("0");

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
        }


        private void dataBaseUpdationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.DataBaseForms.UpdateDataBase _objdatabase = new JewelleryManagement.DataBaseForms.UpdateDataBase();
            _objdatabase.ShowDialog();
        }

        private void updateDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Common.Frm_DeveloperLogin _ObjDeveloperLogin = new JewelleryManagement.Common.Frm_DeveloperLogin();
            _ObjDeveloperLogin.ShowDialog();
            if (_ObjDeveloperLogin.Developer_login_Result == true)
            {
                JewelleryManagement.Common.frm_UpdateQuery _objUpdateDataBase = new JewelleryManagement.Common.frm_UpdateQuery();

                _objUpdateDataBase.ShowDialog();
                _objUpdateDataBase.MdiParent = this;
                _objUpdateDataBase.Show();
            }
            else
            {
                MessageBox.Show("Access failed");
                _ObjDeveloperLogin.ShowDialog();
            }


        }

        private void sixMonthReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Reports.Girvi.Frm_SixMonthsReport _objSixMonthReport = new JewelleryManagement.Reports.Girvi.Frm_SixMonthsReport();
            // _objSixMonthReport.ShowDialog();


            if (!CheckForm(_objSixMonthReport))
            {

                _objSixMonthReport.MdiParent = this;

                _objSixMonthReport.AutoScroll = true;

                _objSixMonthReport.Show();


            }
            else { _objSixMonthReport.BringToFront(); }


            if (rbt_English.Checked == true)
            {
                _objSixMonthReport.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objSixMonthReport.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objSixMonthReport.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objSixMonthReport.rbt_OtherTrue.Checked = true;
            }

        }



        private void yesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // _objGirviCommon.sethidefeild("1");

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

        private void noToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _objGirviCommon.sethidefeild("0");

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

        private void girviReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Reports.Girvi.A.R.Required.Frm_GirviReport _objgirvireport = new JewelleryManagement.Reports.Girvi.A.R.Required.Frm_GirviReport();

            if (!CheckForm(_objgirvireport))
            {

                _objgirvireport.MdiParent = this;

                _objgirvireport.AutoScroll = true;

                _objgirvireport.Show();


            }
            else { _objgirvireport.BringToFront(); }


            if (rbt_English.Checked == true)
            {
                _objgirvireport.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objgirvireport.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objgirvireport.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objgirvireport.rbt_OtherTrue.Checked = true;
            }
        }

        private void deleteAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Common.Frm_DeveloperLogin _ObjDeveloperLogin = new JewelleryManagement.Common.Frm_DeveloperLogin();
            _ObjDeveloperLogin.ShowDialog();
            if (_ObjDeveloperLogin.Developer_login_Result == true)
            {
                JewelleryManagement.DataBaseForms.Frm_DeleteAllTableData _objdeletedata = new JewelleryManagement.DataBaseForms.Frm_DeleteAllTableData();
                _objdeletedata.ShowDialog();
                _objdeletedata.MdiParent = this;
                _objdeletedata.Show();
            }
            else
            {
                MessageBox.Show("Access failed");
                _ObjDeveloperLogin.ShowDialog();
            }


        }

        private void profitLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProfitLoss _objform = new Frm_ProfitLoss();
            if (!CheckForm(_objform))
            {

                _objform.MdiParent = this;

                _objform.AutoScroll = true;

                _objform.Show();


            }
            else { _objform.BringToFront(); }

        }

        private void vinaTaranReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Reports.Girvi.VinaTarakReport _objVinaTarakeport = new JewelleryManagement.Reports.Girvi.VinaTarakReport();
            _objVinaTarakeport.MdiParent = this;
            _objVinaTarakeport.Show();
        }



        private void vayajReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Reports.VayajReport _ObjVayaj = new JewelleryManagement.Reports.VayajReport();
            _ObjVayaj.MdiParent = this;
            _ObjVayaj.Show();
        }

        private void customeRDataPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_customerprintablelist _objcustomerprintable = new Frm_customerprintablelist();
            //  _objcustomerprintable.MdiParent = this;
            // _objcustomerprintable.Show();
            if (!CheckForm(_objcustomerprintable))
            {

                _objcustomerprintable.MdiParent = this;

                _objcustomerprintable.AutoScroll = true;

                _objcustomerprintable.Show();


            }
            else { _objcustomerprintable.BringToFront(); }
            if (rbt_English.Checked == true)
            {
                _objcustomerprintable.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objcustomerprintable.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objcustomerprintable.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objcustomerprintable.rbt_OtherTrue.Checked = true;
            }
        }

        private void updateDataBaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Common.Frm_DeveloperLogin _ObjDeveloperLogin = new JewelleryManagement.Common.Frm_DeveloperLogin();
            _ObjDeveloperLogin.ShowDialog();
            if (_ObjDeveloperLogin.Developer_login_Result == true)
            {
                JewelleryManagement.Common.frm_UpdateQuery _objUpdateDataBase = new JewelleryManagement.Common.frm_UpdateQuery();

                // _objUpdateDataBase.ShowDialog();
                _objUpdateDataBase.MdiParent = this;
                _objUpdateDataBase.Show();
            }
            else
            {
                MessageBox.Show("Access failed");
                _ObjDeveloperLogin.ShowDialog();
            }

        }

        private void deleteAllDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Common.Frm_DeveloperLogin _ObjDeveloperLogin = new JewelleryManagement.Common.Frm_DeveloperLogin();
            _ObjDeveloperLogin.ShowDialog();
            if (_ObjDeveloperLogin.Developer_login_Result == true)
            {
                JewelleryManagement.DataBaseForms.Frm_DeleteAllTableData _objdeletedata = new JewelleryManagement.DataBaseForms.Frm_DeleteAllTableData();
                // _objdeletedata.ShowDialog();
                _objdeletedata.MdiParent = this;
                _objdeletedata.Show();
            }
            else
            {
                MessageBox.Show("Access failed");
                _ObjDeveloperLogin.ShowDialog();
            }

        }

        private void creditDebitOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Common.Frm_DeveloperLogin _ObjDeveloperLogin = new JewelleryManagement.Common.Frm_DeveloperLogin();
            _ObjDeveloperLogin.ShowDialog();
            if (_ObjDeveloperLogin.Developer_login_Result == true)
            {
                JewelleryManagement.Common.CreditDebitUpdateQuery _objCreditDebit = new JewelleryManagement.Common.CreditDebitUpdateQuery();
                // _objdeletedata.ShowDialog();
                _objCreditDebit.MdiParent = this;
                _objCreditDebit.Show();
            }
            else
            {
                MessageBox.Show("Access failed");
                _ObjDeveloperLogin.ShowDialog();
            }

        }

        private void crystalReportUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Common.Frm_DeveloperLogin _ObjDeveloperLogin = new JewelleryManagement.Common.Frm_DeveloperLogin();
            _ObjDeveloperLogin.ShowDialog();
            if (_ObjDeveloperLogin.Developer_login_Result == true)
            {
                JewelleryManagement.Common.CrystalReportUpdates _objCrystalReport = new JewelleryManagement.Common.CrystalReportUpdates();
                // _objdeletedata.ShowDialog();
                _objCrystalReport.MdiParent = this;
                _objCrystalReport.Show();
            }
            else
            {
                MessageBox.Show("Access failed");
                _ObjDeveloperLogin.ShowDialog();
            }
        }

        private void settingValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Common.Frm_DeveloperLogin _ObjDeveloperLogin = new JewelleryManagement.Common.Frm_DeveloperLogin();
            _ObjDeveloperLogin.ShowDialog();
            if (_ObjDeveloperLogin.Developer_login_Result == true)
            {
                JewelleryManagement.Common.SettingValue _objSettingValues = new JewelleryManagement.Common.SettingValue();
                // _objdeletedata.ShowDialog();
                _objSettingValues.MdiParent = this;
                _objSettingValues.Show();
            }
            else
            {
                MessageBox.Show("Access failed");
                _ObjDeveloperLogin.ShowDialog();
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutUstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://appsthentic.com/about-us/");
        }

        private void bttnz_twiter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/appsthentic");
        }

        private void bttn_facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/appsthentic");
        }

        private void recieptCompalsuriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JewelleryManagement.Frm_All_Settings _ObjAllSettings = new JewelleryManagement.Frm_All_Settings();
            _ObjAllSettings.ShowDialog();

        }

        private void MonthWiseNoticevayajReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MonthsWiseNoticeReport _objMonthsWiseNoticeReport = new Frm_MonthsWiseNoticeReport();

            if (!CheckForm(_objMonthsWiseNoticeReport))
            {

                _objMonthsWiseNoticeReport.MdiParent = this;

                _objMonthsWiseNoticeReport.AutoScroll = true;

                _objMonthsWiseNoticeReport.Show();


            }
            else { _objMonthsWiseNoticeReport.BringToFront(); }


            if (rbt_English.Checked == true)
            {
                _objMonthsWiseNoticeReport.rbt_English.Checked = true;
            }
            else if (rbt_Hindii.Checked == true)
            {
                _objMonthsWiseNoticeReport.rbt_Hindi.Checked = true;
            }
            else if (rbt_Marathi.Checked == true)
            {
                _objMonthsWiseNoticeReport.rbt_Marathi.Checked = true;
            }
            else if (rbt_Other.Checked == true)
            {
                _objMonthsWiseNoticeReport.rbt_OtherTrue.Checked = true;
            }
        }

        private void nOTICEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}






