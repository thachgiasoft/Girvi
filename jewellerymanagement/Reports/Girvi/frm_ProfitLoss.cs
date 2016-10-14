using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Common;
using System.Drawing.Text;

namespace JewelleryManagement.Reports.Girvi
{
    public partial class frm_ProfitLoss : Form
    {
        string loanamt, int_rate, no_of_days, interest_amt;
        double sumloan_int = 0;
        double current_sum = 0;
        clsGirviCommon _objGirviCommon = new clsGirviCommon();
        clsCommon _objCommon = new clsCommon();


        public frm_ProfitLoss()
        {
            InitializeComponent();
        }

        private void frm_ProfitLoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ProfitLoss_Load(object sender, EventArgs e)
        {
            SetFont();
            MasterClear();
        }
        public void ShivajiFont()
        {
            if (rbt_OtherTrue.Checked == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(Application.StartupPath + "\\Shivaji02.ttf");
                // dtp_Date.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //dtp_StartDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //dtp_EndDate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_khatawaniNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_Srno.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_DateOfDeposite.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_InterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_Loanamount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_DepositDays.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_InterestAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_InterestPaid.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_TotalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_PayAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_ReceiptNo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_FinalWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_FinalWtInPercent.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_FineWt.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_Quantity.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_ActualRate.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_TotalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_FinalAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_InterestInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_EstimateInPer.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //txt_LoanAmount.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //dtp_DateOfDeposit.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                //dtp_Duration.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                // System.ComponentModel.TypeConverter converter = 
            }
        }


        private void SetFont()
        {
            ShivajiFont();
        }

        private void MasterClear()
        {
            dgv_GirviDetail.Rows.Clear();
            FillGrid("");
        }

        private void FillGrid(string Actual_InterestRate)
        {
            dgv_GirviDetail.Rows.Clear();
            dgv_itemDetails.Rows.Clear();
            DataTable dt = null;
            if (Actual_InterestRate != "Actual_InterestRate")
            {
                dt = _objGirviCommon.getAllGirviData();
            }
            else
            {
                dt = _objGirviCommon.getAllGirviDataWithActualInterestRate();

            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                DataTable dt2 = _objGirviCommon.getCustName(dt.Rows[i][5].ToString());//by A


                dgv_GirviDetail.Rows.Add(dt.Rows[i][0].ToString(), dt2.Rows[0][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());

                string str = Convert.ToString(dgv_GirviDetail.Rows[i].Cells[0].Value);

                loanamt = dgv_GirviDetail.Rows[i].Cells[2].Value.ToString();//1
                if (dgv_GirviDetail.Rows[i].Cells[4].Value.ToString() != "")
                {
                    int_rate = dgv_GirviDetail.Rows[i].Cells[4].Value.ToString();//4
                }
                else
                {
                    int_rate = dt.Rows[i]["interset_rate"].ToString();//4

                }
               
                no_of_days = ((/*Convert.ToDateTime(dateTimePicker_currentDate.Text) - */DateTime.Today - Convert.ToDateTime(dgv_GirviDetail.Rows[i].Cells[3].Value.ToString())).TotalDays).ToString();
                interest_amt = interest(Convert.ToDouble(loanamt)).ToString();
                sumloan_int = (Convert.ToDouble(loanamt) + Convert.ToDouble(interest_amt));
                //actual girvi calc
                DataTable dt1 = _objGirviCommon.fillGirvidData(str);
                string gold_rate, silver_rate;
                string New_gold_amount, New_silverAmount, new_amt;


                double previoussumamt = 0, currentsumamt = 0, current_sum_individual = 0;
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    string sumcomman = "0";
                    string strnew = Convert.ToString(dt1.Rows[j][2].ToString());
                    DataTable dtnew = _objGirviCommon.loadRate();
                    if (strnew.Trim() == "सोना")
                    {
                        gold_rate = dtnew.Rows[0][0].ToString();
                        if (dt1.Rows[j][9].ToString() != "" && gold_rate != "")
                        {
                            New_gold_amount = (Convert.ToDouble(dt1.Rows[j][9].ToString()) * Convert.ToDouble(gold_rate)).ToString();
                            sumcomman = New_gold_amount;
                            dgv_itemDetails.Rows.Add(dt1.Rows[j][0].ToString(), dt1.Rows[j][1].ToString(), dt1.Rows[j][2].ToString().Trim(), dt1.Rows[j][3].ToString(), dt1.Rows[j][4].ToString().Trim(), dt1.Rows[j][5].ToString(), dt1.Rows[j][6].ToString(), dt1.Rows[j][7].ToString(), dt1.Rows[j][8].ToString(), dt1.Rows[j][9].ToString(), dt1.Rows[j][10].ToString(), dt1.Rows[j][11].ToString(), dt1.Rows[j][12].ToString(), gold_rate, New_gold_amount);
                            // current_sum_individual = current_sum_individual + Convert.ToDouble(old_dataGridView.Rows[j].Cells[14].Value.ToString());
                        }
                    }
                    if (strnew.Trim() == "चांदी")
                    {
                        silver_rate = dtnew.Rows[0][1].ToString();
                        if (dt1.Rows[j][9].ToString() != "" && silver_rate != "")
                        {
                            New_silverAmount = (Convert.ToDouble(dt1.Rows[j][9].ToString()) * Convert.ToDouble(silver_rate)).ToString();
                            sumcomman = New_silverAmount;
                            dgv_itemDetails.Rows.Add(dt1.Rows[j][0].ToString(), dt1.Rows[j][1].ToString(), dt1.Rows[j][2].ToString().Trim(), dt1.Rows[j][3].ToString(), dt1.Rows[j][4].ToString().Trim(), dt1.Rows[j][5].ToString(), dt1.Rows[j][6].ToString(), dt1.Rows[j][7].ToString(), dt1.Rows[j][8].ToString(), dt1.Rows[j][9].ToString(), dt1.Rows[j][10].ToString(), dt1.Rows[j][11].ToString(), dt1.Rows[j][12].ToString(), silver_rate, New_silverAmount);
                            //  current_sum_individual = current_sum_individual + Convert.ToDouble(old_dataGridView.Rows[j].Cells[14].Value.ToString());
                        }

                    }
                    //current_sum_individual = 0;
                    //for (int k = 0; k < old_dataGridView.Rows.Count; k++)
                    //{
                    current_sum_individual = current_sum_individual + Convert.ToDouble(sumcomman);

                    //}


                    //previoussumamt = previoussumamt + Convert.ToDouble(old_dataGridView.Rows[j].Cells[12].Value.ToString());
                }

                //current_sum_individual = current_sum_individual + Convert.ToDouble(old_dataGridView.Rows[j].Cells[14].Value.ToString());

                dgv_GirviDetail.Rows[i].Cells[6].Value = sumloan_int;
                dgv_GirviDetail.Rows[i].Cells[7].Value = current_sum_individual;
                dgv_GirviDetail.Rows[i].Cells[8].Value = (current_sum_individual - sumloan_int).ToString();
                if (Convert.ToDouble(dgv_GirviDetail.Rows[i].Cells[8].Value.ToString()) < Convert.ToDouble(0))
                {
                    dgv_GirviDetail.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgv_GirviDetail.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }


            for (int i = 0; i < dgv_itemDetails.Rows.Count; i++)
            {
                current_sum = current_sum + Convert.ToDouble(dgv_itemDetails.Rows[i].Cells[14].Value.ToString());

            }
            
            string currentSum = current_sum.ToString();
            string currentLoan = sumloan_int.ToString();

            lbl_Profit.Text = _objCommon.sumGridViewColumn(dgv_GirviDetail, "ProfitValue").ToString();
            if (Convert.ToDouble(lbl_Profit.Text) < Convert.ToDouble(0))
            {
                lbl_Profit.ForeColor = Color.Red;
            }
        }

        private object interest(double amt)
        {
            double rate = Convert.ToDouble(Convert.ToDouble(int_rate));
            double dys = Convert.ToDouble(Convert.ToDouble(no_of_days));
            double intAmount = (((amt * rate) / 100) / 30) * dys;
            return Convert.ToDouble(Math.Round(intAmount));
            throw new NotImplementedException();
        }

        private void rbt_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "गिरवी फायदा नुकसान ";
            bttn_Close.Text = "बंद";
            lbl_Date.Text = "तारीख";
            lbl_CurrentProfit.Text = "चालू फायदा";

             dgv_GirviDetail.Columns["GirviNo"].HeaderText = "गिरवी नं." ;
             dgv_GirviDetail.Columns["Name"].HeaderText = "नाम" ;
             dgv_GirviDetail.Columns["Amount"].HeaderText = "रक्कम" ;
             dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "रखनेकी तारीख";
             dgv_GirviDetail.Columns["InterestRate"].HeaderText = "ब्याज दर" ;
             dgv_GirviDetail.Columns["LastDateOfRelease"].HeaderText = "छुडानेकी अंतिम तारीख" ;
            dgv_GirviDetail.Columns["CurrentLoanAmount"].HeaderText = "चालू कर्ज रक्कम" ;
            dgv_GirviDetail.Columns["CurrentGirviAmount"].HeaderText = "चालू गिरवी रक्कम" ;
            dgv_GirviDetail.Columns["ProfitValue"].HeaderText = "फायदा" ;



        }

        private void rbt_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "गाहनी फायदा नुकसान ";
            bttn_Close.Text = "बंद";
            lbl_Date.Text = "तारीख";
            lbl_CurrentProfit.Text = "चालू फायदा";

            dgv_GirviDetail.Columns["GirviNo"].HeaderText = "गाहनी नं.";
            dgv_GirviDetail.Columns["Name"].HeaderText = "नाव";
            dgv_GirviDetail.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "ठेव तारीख";
            dgv_GirviDetail.Columns["InterestRate"].HeaderText = "व्याज दर";
            dgv_GirviDetail.Columns["LastDateOfRelease"].HeaderText = "सोडवण्याची अंतिम तारीख";
            dgv_GirviDetail.Columns["CurrentLoanAmount"].HeaderText = "चालू कर्ज रक्कम";
            dgv_GirviDetail.Columns["CurrentGirviAmount"].HeaderText = "चालू गाहनी रक्कम";
            dgv_GirviDetail.Columns["ProfitValue"].HeaderText = "फायदा";
        }

        private void rbt_OtherTrue_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "गाहनी फायदा नुकसान ";
            bttn_Close.Text = "बंद";
            lbl_Date.Text = "तारीख";
            lbl_CurrentProfit.Text = "चालू फायदा";

            dgv_GirviDetail.Columns["GirviNo"].HeaderText = "गाहनी नं.";
            dgv_GirviDetail.Columns["Name"].HeaderText = "नाव";
            dgv_GirviDetail.Columns["Amount"].HeaderText = "रक्कम";
            dgv_GirviDetail.Columns["DateOfDeposit"].HeaderText = "ठेव तारीख";
            dgv_GirviDetail.Columns["InterestRate"].HeaderText = "व्याज दर";
            dgv_GirviDetail.Columns["LastDateOfRelease"].HeaderText = "सोडवण्याची अंतिम तारीख";
            dgv_GirviDetail.Columns["CurrentLoanAmount"].HeaderText = "चालू कर्ज रक्कम";
            dgv_GirviDetail.Columns["CurrentGirviAmount"].HeaderText = "चालू गाहनी रक्कम";
            dgv_GirviDetail.Columns["ProfitValue"].HeaderText = "फायदा";
        }

        private void bttn_ActualRI_Click(object sender, EventArgs e)
        {
            FillGrid("Actual_InterestRate");
        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            FillGrid("");
        }

     
       
    }
}
