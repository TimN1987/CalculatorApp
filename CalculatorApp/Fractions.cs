using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Fraction : Form
    {
        double firstInteger;
        double firstNumerator;
        double firstDenominator;
        string? operation;
        bool noInput;
        bool integerInput;
        bool numeratorInput;
        bool methodEnd;


        public void Reset()
        {
            noInput = true;
            integerInput = false;
            numeratorInput = false;
        }

        public Fraction()
        {
            InitializeComponent();
            Reset();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "1";
                }
                else
                {
                    FInt.Text = FInt.Text + "1";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "1";
                }
                else
                {
                    FNum.Text = FNum.Text + "1";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "1";
                }
                else
                {
                    FDen.Text = FDen.Text + "1";
                }
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "2";
                }
                else
                {
                    FInt.Text = FInt.Text + "2";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "2";
                }
                else
                {
                    FNum.Text = FNum.Text + "2";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "2";
                }
                else
                {
                    FDen.Text = FDen.Text + "2";
                }
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "3";
                }
                else
                {
                    FInt.Text = FInt.Text + "3";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "3";
                }
                else
                {
                    FNum.Text = FNum.Text + "3";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "3";
                }
                else
                {
                    FDen.Text = FDen.Text + "3";
                }
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "4";
                }
                else
                {
                    FInt.Text = FInt.Text + "4";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "4";
                }
                else
                {
                    FNum.Text = FNum.Text + "4";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "4";
                }
                else
                {
                    FDen.Text = FDen.Text + "4";
                }
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "5";
                }
                else
                {
                    FInt.Text = FInt.Text + "5";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "5";
                }
                else
                {
                    FNum.Text = FNum.Text + "5";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "5";
                }
                else
                {
                    FDen.Text = FDen.Text + "5";
                }
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "6";
                }
                else
                {
                    FInt.Text = FInt.Text + "6";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "6";
                }
                else
                {
                    FNum.Text = FNum.Text + "6";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "6";
                }
                else
                {
                    FDen.Text = FDen.Text + "6";
                }
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "7";
                }
                else
                {
                    FInt.Text = FInt.Text + "7";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "7";
                }
                else
                {
                    FNum.Text = FNum.Text + "7";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "7";
                }
                else
                {
                    FDen.Text = FDen.Text + "7";
                }
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "8";
                }
                else
                {
                    FInt.Text = FInt.Text + "8";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "8";
                }
                else
                {
                    FNum.Text = FNum.Text + "8";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "8";
                }
                else
                {
                    FDen.Text = FDen.Text + "8";
                }
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "9";
                }
                else
                {
                    FInt.Text = FInt.Text + "9";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "9";
                }
                else
                {
                    FNum.Text = FNum.Text + "9";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "9";
                }
                else
                {
                    FDen.Text = FDen.Text + "9";
                }
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                if (FInt.Text == "0")
                {
                    FInt.Text = "0";
                }
                else
                {
                    FInt.Text = FInt.Text + "0";
                }
            }
            if (integerInput)
            {
                if (FNum.Text == "0")
                {
                    FNum.Text = "0";
                }
                else
                {
                    FNum.Text = FNum.Text + "0";
                }
            }
            if (numeratorInput)
            {
                if (FDen.Text == "0")
                {
                    FDen.Text = "0";
                }
                else
                {
                    FDen.Text = FDen.Text + "0";
                }
            }
        }

        private void bce_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                FInt.Text = "0";
            }
            if (integerInput)
            {
                FNum.Text = "0";
            }
            if (numeratorInput)
            {
                FDen.Text = "0";
            }
        }

        private void bac_Click(object sender, EventArgs e)
        {
            firstInteger = 0;
            firstNumerator = 0;
            firstDenominator = 0;

            FInt.Text = "0";
            FNum.Text = "0";
            FDen.Text = "0";

            Reset();
        }

        private void bnext_Click(object sender, EventArgs e)
        {
            if (noInput)
            {
                noInput = false;
                integerInput = true;
            }
            else
            {
                integerInput = false;
                numeratorInput = true;
            }
        }

        private void badd_Click(object sender, EventArgs e)
        {
            if (FDen.Text == "0" && FNum.Text != "0")
            {
                FInt.Text = "ERROR";
                FNum.Text = "Cannot have";
                FDen.Text = "denominator = 0";
            }
            
            firstInteger = Convert.ToDouble(FInt.Text);
            firstNumerator = Convert.ToDouble(FInt.Text);
            firstDenominator = Convert.ToDouble(FDen.Text);

            operation = "+";

            Reset();
            FInt.Text = "0";
            FNum.Text = "0";
            FDen.Text = "0";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            firstInteger = Convert.ToDouble(FInt.Text);
            firstNumerator = Convert.ToDouble(FInt.Text);
            firstDenominator = Convert.ToDouble(FDen.Text);

            operation = "-";

            Reset();
            FInt.Text = "0";
            FNum.Text = "0";
            FDen.Text = "0";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            firstInteger = Convert.ToDouble(FInt.Text);
            firstNumerator = Convert.ToDouble(FInt.Text);
            firstDenominator = Convert.ToDouble(FDen.Text);

            operation = "*";

            Reset();
            FInt.Text = "0";
            FNum.Text = "0";
            FDen.Text = "0";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            firstInteger = Convert.ToDouble(FInt.Text);
            firstNumerator = Convert.ToDouble(FInt.Text);
            firstDenominator = Convert.ToDouble(FDen.Text);

            operation = "/";

            Reset();
            FInt.Text = "0";
            FNum.Text = "0";
            FDen.Text = "0";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            double secondInteger = Convert.ToDouble(FInt.Text);
            double secondNumerator = Convert.ToDouble(FNum.Text);
            double secondDenominator = Convert.ToDouble(FDen.Text);

            Reset();

            if (FDen.Text == "0" && FNum.Text != "0")
            {
                FInt.Text = "ERROR";
                FNum.Text = "Attempted to";
                FDen.Text = "divide by 0";
            }
            
            if (operation == "+")
            {
                double[] answer = FractionTools.Add(firstInteger, firstNumerator, firstDenominator, secondInteger, secondNumerator, secondDenominator);

                FInt.Text = Convert.ToString(answer[0]);
                FNum.Text = Convert.ToString(answer[1]);
                FDen.Text = Convert.ToString(answer[2]);

                methodEnd = true;
            }

            if (operation == "-")
            {
                double[] answer = FractionTools.Subtract(firstInteger, firstNumerator, firstDenominator, secondInteger, secondNumerator, secondDenominator);

                FInt.Text = Convert.ToString(answer[0]);
                FNum.Text = Convert.ToString(answer[1]);
                FDen.Text = Convert.ToString(answer[2]);

                methodEnd = true;
            }
        }
    }
}
