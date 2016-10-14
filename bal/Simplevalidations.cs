using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;





namespace BAL

{
    public class Simplevalidations
    {
        public void ValidationDigitOnly(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || e.KeyChar.ToString() == "\b"||e.KeyChar.ToString()=="-")
            {
                if (e.KeyChar.ToString() != ".")
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }


                //e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        public void ValidationDigitWithPoint(KeyPressEventArgs e, string txt)
        {// it change
            if (char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == "\b" || e.KeyChar.ToString() == "." || e.KeyChar.ToString() == "-")
            {
                int count = (txt.Length - txt.Replace(".", "").Length) / 1;
                if (count < 1)
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar.ToString() != ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        public void ValidationCharNoSpace(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar.ToString() == "\b" || e.KeyChar.ToString() == "(" || e.KeyChar.ToString() == ")" || e.KeyChar.ToString() == "!" || e.KeyChar.ToString() == "@" || e.KeyChar.ToString() == "#" || e.KeyChar.ToString() == "%" || e.KeyChar.ToString() == "&" || e.KeyChar.ToString() == "*" || e.KeyChar.ToString() == "."||char.IsDigit(e.KeyChar) )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void ValidationCharOnly(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar.ToString() == "\b" || e.KeyChar.ToString() == " " || e.KeyChar.ToString() == "(" || e.KeyChar.ToString() == ")" || e.KeyChar.ToString() == "!" || e.KeyChar.ToString() == "@" || e.KeyChar.ToString() == "#" || e.KeyChar.ToString() == "%" || e.KeyChar.ToString() == "&" || e.KeyChar.ToString() == "*" || e.KeyChar.ToString() == "." || !char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

            public void ValidationCharDigitOnly(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar.ToString() == "\b" || e.KeyChar.ToString() == " " || e.KeyChar.ToString() == "(" || e.KeyChar.ToString() == ")" || e.KeyChar.ToString() == "!" || e.KeyChar.ToString() == "@" || e.KeyChar.ToString() == "#" || e.KeyChar.ToString() == "%" || e.KeyChar.ToString() == "&" || e.KeyChar.ToString() == "*" || e.KeyChar.ToString() == "." || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }









        }
        public string Gettingdecimals(string value)
        {
            try
            {
                if (value != "")
                {
                    double s = Convert.ToDouble(value);
                    String s2 = string.Format("{0:#,##0.000}", s);
                    return s2;
                }
                else { return value; }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return ex.Message;
            }
        }
        public string roundup(string value)
        {
            if (value != "")
            {

                double number = Convert.ToDouble(value);
                number = Math.Round(number);

                return Convert.ToString(number);
            }
            return value;

        }
    }
    
}
