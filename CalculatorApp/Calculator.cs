namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        double firstNumber;
        string operation;
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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
            if (screen.Text.Length == 19)
            {
                screen.Text = screen.Text;
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

        private void badd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(screen.Text);
            screen.Text = "0";
            operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(screen.Text);
            screen.Text = "0";
            operation = "-";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(screen.Text);
            screen.Text = "0";
            operation = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(screen.Text);
            screen.Text = "0";
            operation = "/";
        }

        private void bc_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        private void bac_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            firstNumber = 0;
            operation = " ";
        }

        private void bdp_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + ".";
        }

        private void bpn_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "0";
            }
            else if (screen.Text[0] == '-')
            {
                string s = "";
                for (int i = 1; i < screen.Text.Length; i++)
                {
                    s = s + screen.Text[i];
                }
                screen.Text = s;
            }
            else
            {
                screen.Text = "-" + screen.Text;
            }
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;
            string rStr;

            secondNumber = Convert.ToDouble(screen.Text);

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                rStr = Convert.ToString(result);
                if (rStr.Length <= 20)
                { 
                    screen.Text = rStr;
                }
                else
                {
                    screen.Text = "ERROR";
                }
                firstNumber = result;
            }

            if (operation == "-")
            {
                result = firstNumber - secondNumber;
                rStr = Convert.ToString(result);
                if (rStr.Length <= 20)
                {
                    screen.Text = rStr;
                }
                else
                {
                    screen.Text = "ERROR";
                }
                firstNumber = result;
            }

            if (operation == "*")
            {
                result = firstNumber * secondNumber;
                rStr = Convert.ToString(result);
                if (rStr.Length <= 20)
                {
                    screen.Text = rStr;
                }
                else
                {
                    screen.Text = "ERROR";
                }
                firstNumber = result;
            }

            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    screen.Text = "You cannot divide by 0";
                }
                else
                {
                    result = firstNumber / secondNumber;
                    rStr = Convert.ToString(result);

                    if (rStr.Length <= 20)
                    {
                        screen.Text = rStr;
                    }
                    else
                    {
                        screen.Text = "ERROR";
                    }
                    firstNumber = result;
                }
            }
        }

        private void bsci_Click(object sender, EventArgs e)
        {
            Scientific sciCalc = new Scientific();
            sciCalc.Show();
        }

        private void bprime_Click(object sender, EventArgs e)
        {
            Prime primeCalc = new Prime();
            primeCalc.Show();
        }

        private void bfrac_Click(object sender, EventArgs e)
        {
            Fraction fracCalc = new Fraction();
            fracCalc.Show();
        }

        private void bquad_Click(object sender, EventArgs e)
        {
            Quadratic quadCalc = new Quadratic();
            quadCalc.Show();
        }
    }
}
