using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace JewelleryManagement.CrystalReport
{
    public partial class PrinterSetting : Form
    {
        public PrinterSetting()
        {
            InitializeComponent();
        }

        public string PrinterName { get; set; }

        private void PrinterSetting_Load(object sender, EventArgs e)
        {
            try
            {
                if (PrinterSettings.InstalledPrinters.Count <= 0)
                {
                    MessageBox.Show("Printer not found!");
                    return;
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
            //Get all available printers and add them to the combo box
            try
            {
                foreach (String printer in PrinterSettings.InstalledPrinters)
                {
                    cmbPrintlist.Items.Add(printer.ToString());
                }
                cmbPrintlist.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
            	
            }
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PrinterName = cmbPrintlist.SelectedItem.ToString();
        }
    }
}
