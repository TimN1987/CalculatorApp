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
    public partial class Quadratic : Form
    {
        bool squareCheck;
        bool xCheck;
        int a;
        int b;
        int c;

        public void EndQuad()
        {
            if (squareCheck == true && xCheck == true)
            {
                string? temp = Screen.Text.Substring(Screen.Text.IndexOf("+") + 1);
                c = Convert.ToInt32(temp.Substring(temp.IndexOf("+") + 2));
            }
        }

        public void Reset()
        {
            a = 0;
            b = 0;
            c = 0;
            squareCheck = false;
            xCheck = false;
        }

        public Quadratic()
        {
            InitializeComponent();
            Reset();

            if (!squareCheck && !xCheck) { bx2.Enabled = true; bx.Enabled = false; bequal.Enabled = false; bfac.Enabled = false; bcs.Enabled = false; }

            if (squareCheck && !xCheck) { bx2.Enabled = false; bx.Enabled = true; bequal.Enabled = false; bfac.Enabled = false; bcs.Enabled = false; }

            if (squareCheck && xCheck) { bx2.Enabled = false; bx.Enabled = false; bequal.Enabled = true; bfac.Enabled = true; bcs.Enabled = true; }
        }

        private void bce_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
        }

        private void bac_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            a = 0;
            b = 0;
            c = 0;
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "0";
            }
            if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "0";
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "1";
            }
            else if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "2";
            }
            else if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "3";
            }
            else if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "4";
            }
            else if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "5";
            }
            else if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "6";
            }
            else if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "7";
            }
            else if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "8";
            }
            else if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "9";
            }
            else if (Screen.Text != "0")
            {
                Screen.Text = Screen.Text + "9";
            }
        }

        private void bx_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = Screen.Text;
            }
            if (Screen.Text != "0" && squareCheck == true)
            {
                string? bS = Screen.Text.Substring(Screen.Text.IndexOf("+") + 2);

                b = Convert.ToInt32(bS);

                Screen.Text = Screen.Text + "x + ";
            }
            xCheck = true;
            bx.Enabled = false;
            bequal.Enabled = true;
            bfac.Enabled = true;
            bcs.Enabled = true;
        }

        private void bx2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(Screen.Text);

            Screen.Text = Screen.Text + "x2 + ";

            squareCheck = true;
            bx2.Enabled = false;
            bx.Enabled = true;
        }

        private void bfac_Click(object sender, EventArgs e)
        {
            EndQuad();

            double qF = Math.Sqrt(b * b - 4 * a * c) / (2 * a);

            double fac1 = qF - (b / (2 * a));

            double fac2 = 0 - (b / (2 * a)) - qF;

            if (fac1 <= 0 && fac2 > 0)
            {
                Screen.Text = $"(x + {Math.Abs(fac1)})(x - {fac2})";
            }
            else if (fac1 <= 0 && fac2 <= 0)
            {
                Screen.Text = $"(x + {Math.Abs(fac1)})(x + {Math.Abs(fac2)})";
            }
            else if (fac1 > 0 && fac2 <= 0)
            {
                Screen.Text = $"(x - {fac1})(x + {Math.Abs(fac2)})";
            }
            else
            {
                Screen.Text = $"(x - {fac1})(x - {fac2}";
            }
            Reset();
        }
    }
}
