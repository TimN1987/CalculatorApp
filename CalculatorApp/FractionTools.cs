using Prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public static class FractionTools
    {

        public static double[] Simplify(double int1, double num1, double den1)
        {
            double[] answer = new double[3];

            if (den1 == 0)
            {
                if (num1 == 0)
                {
                    answer[0] = int1;
                    answer[1] = 0;
                    answer[2] = 0;
                    return answer;
                }
                else
                {
                    answer[0] = 0;
                    answer[1] = 0;
                    answer[2] = 0;
                    return answer;
                }
            }

            List<int> primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };

            foreach (int p in primes)
            {
                while (num1 % p == 0 && den1 % p == 0)
                {
                    num1 = num1 / p;
                    den1 = den1 / p;
                }
            }
            while (num1 >= den1)
            {
                num1 -= den1;
                int1++;
            }

            if (num1 == 0) { den1 = 0; }

            answer[0] = int1;
            answer[1] = num1;
            answer[2] = den1;
            return answer;
        }

        public static double[] Add(double int1, double num1, double den1, double int2, double num2, double den2)
        {
            double[] answer = new double[3];

            if (den1 == 0 && num1 != 0)
            {
                answer[0] = 0;
                answer[1] = 0;
                answer[2] = 0;
                return answer;
            }
            else if (den2 == 0 && num2 != 0)
            {
                answer[0] = 0;
                answer[1] = 0;
                answer[2] = 0;
                return answer;
            }
            else if (den1 == 0)
            {
                answer[0] = int1 + int2;
                answer[1] = num2;
                answer[2] = den2;
                return answer;
            }
            else if (den2 == 0)
            {
                answer[0] = int1 + int2;
                answer[1] = num1;
                answer[2] = num2;
                return answer;
            }
            else
            {
                double aInt = int1 + int2;

                double aDen = den1 * den2;

                double aNum = (num1 * den2) + (num2 * den1);

                while (aDen != 0 && aNum >= aDen)
                {
                    aNum -= aDen;

                    aInt++;
                }

                List<int> primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };

                foreach (int p in primes)
                {
                    while (aNum % p == 0 && aDen % p == 0)
                    {
                        aNum /= p;
                        aDen /= p;
                    }
                }

                if (aNum == 0) { aDen = 0; }

                answer[0] = aInt;
                answer[1] = aNum;
                answer[2] = aDen;
                return answer;
            }


        }

        public static double[] Subtract(double int1, double num1, double den1, double int2, double num2, double den2)
        {
            double[] answer = new double[3];
            double aInt;
            double aNum;
            double aDen;
            List<int> primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };

            if (den1 == 0 && num1 != 0)
            {
                answer[0] = 0;
                answer[1] = 0;
                answer[2] = 0;
                return answer;
            }
            else if (den2 == 0 && num2 != 0)
            {
                answer[0] = 0;
                answer[1] = 0;
                answer[2] = 0;
                return answer;
            }
            else if (den2 == 0 && num2 == 0)
            {
                if (int1 >= int2)
                {
                    aInt = int1 - int2;
                    answer[0] = aInt;
                    answer[1] = num1;
                    answer[2] = den1;
                    return answer;
                }
                else
                {
                    aNum = (num1 + den1 * int1) - (int2 * den1);
                    aDen = den1;

                    return Simplify(0, aNum, aDen);
                }
            }
            else if (den1 == 0 && num1 == 0)
            {
                aNum = (int1 * den2) - (num2 + int2 * den2);
                aDen = den2;

                return Simplify(0, aNum, aDen);
            }
            else
            {
                aDen = den1 * den2;
                aNum = (num1 * den2 + int1 * aDen) - (num2 * den1 + int2 * aDen);

                return Simplify(0, aNum, aDen);
            }
        }

    }
}
