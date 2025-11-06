using Prime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Prime : Form
    {
        int firstNumber;
        int secondNumber;
        bool methodEnd = false;

        private void Reset()
        {
            bprimecheck.Enabled = true;
            bprimecount.Enabled = true;
            bprimehigh.Enabled = true;
            bprimefactors.Enabled = true;
            bcoprime.Enabled = false;
            bcf.Enabled = false;
            baddnum.Enabled = true;
        }

        private void SecondNumberButtons()
        {
            bprimecheck.Enabled = false;
            bprimecount.Enabled = false;
            bprimehigh.Enabled = false;
            bprimefactors.Enabled = false;
            bcoprime.Enabled = true;
            bcf.Enabled = true;
            baddnum.Enabled = false;
        }
        
        public Prime()
        {
            InitializeComponent();
            Reset();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "1";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "1";
            }
            else
            {
                screen.Text = screen.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "2";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "2";
            }
            else
            {
                screen.Text = screen.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "3";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "3";
            }
            else
            {
                screen.Text = screen.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "4";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "4";
            }
            else
            {
                screen.Text = screen.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "5";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "5";
            }
            else
            {
                screen.Text = screen.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "6";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "6";
            }
            else
            {
                screen.Text = screen.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "7";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "7";
            }
            else
            {
                screen.Text = screen.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "8";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "8";
            }
            else
            {
                screen.Text = screen.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "9";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "9";
            }
            else
            {
                screen.Text = screen.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 30)
            {
                screen.Text = screen.Text;
            }
            else if (methodEnd == true)
            {
                methodEnd = false;
                screen.Text = "0";
            }
            else if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "0";
            }
            else
            {
                screen.Text = screen.Text + "0";
            }
        }

        private void bce_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        private void bac_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            firstNumber = 0;
            methodEnd = false;
            Reset();
        }

        private void bprimecheck_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(screen.Text);
            bool check = PrimeTools.Check(firstNumber);
            screen.Text = Convert.ToString(check);
            methodEnd = true;
        }

        private void bprimecount_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(screen.Text);
            List<int> pn = PrimeTools.Finder(firstNumber);
            int total = pn.Count();
            screen.Text = Convert.ToString(total);
            methodEnd = true;
        }

        private void bprimehigh_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(screen.Text);
            List<int> pn = PrimeTools.Finder(firstNumber);
            var last = pn.Last();
            screen.Text = Convert.ToString(last);
            methodEnd = true;
        }

        private void bprimefactors_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(screen.Text);
            List<int> pf = PrimeTools.Factors(firstNumber);

            string ans = "";

            if (pf.Count() == 0) { ans = "No prime factors."; }

            if (pf.Count() == 1) { ans = Convert.ToString(pf[0]); }

            if (pf.Count() > 1)
            {
                for (int i = 0; i < pf.Count() - 1; i++)
                {
                    ans = ans + Convert.ToString(pf[i]) + ", ";
                }
                ans = ans + Convert.ToString(pf.Last());
            }

            screen.Text = ans;
            methodEnd = true;
        }

        private void baddnum_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(screen.Text);
            screen.Text = "0";
            SecondNumberButtons();
        }

        private void bcf_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToInt32(screen.Text);
            List<int> cf = PrimeTools.FactorsCommon(firstNumber, secondNumber);

            string ans = "";

            if (cf.Count == 0) { screen.Text = "Numbers are co-prime."; }

            if (cf.Count == 1) { screen.Text = "" + cf[0]; }

            if (cf.Count >= 2)
            {
                for (int i = 0; i < cf.Count - 1; i++)
                {
                    ans = ans + Convert.ToString(cf[i]) + ", ";
                }

                ans = ans + Convert.ToString(cf.Last());

                screen.Text = ans;

            }
            methodEnd = true;
            Reset();

        }

        private void bcoprime_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToInt32(screen.Text);
            List<int> cf = PrimeTools.FactorsCommon(firstNumber, secondNumber);

            bool check = false;

            if (cf.Count == 0) { check = true; }

            screen.Text = Convert.ToString(check);
            methodEnd = true;
            Reset();
        }
    }
}
