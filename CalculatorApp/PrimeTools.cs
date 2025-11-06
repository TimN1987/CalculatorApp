namespace Prime
{
    public static class PrimeTools
    {
        //create a list of all prime numbers up to the target number
        public static List<int> Finder(int target)
        {
            List<int> primeNumbers = new List<int>();

            if (target <= 1)
            {
                primeNumbers = new List<int> { };
            }

            if (target > 1)
            {
                new List<int> { 2 };


                List<int> countingNumbers = new List<int>();

                for (int i = 2; i < target; i++)
                {
                    countingNumbers.Add(i);
                }

                foreach (int c in countingNumbers)
                {
                    int r = Convert.ToInt32(Math.Sqrt(c));

                    for (int j = 2; j <= r; j++)
                    {
                        if (c % j == 0)
                        {
                            break;
                        }
                        if (j == r)
                        {
                            primeNumbers.Add(c);
                        }
                    }
                }
            }

            return primeNumbers;
        }

        public static bool Check(int num)
        {
            if (num <= 1) { return false; }

            if (num == 2 || num == 3 || num ==5) { return true; }

            if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0) { return false; }

            var limit = (int)Math.Ceiling(Math.Sqrt(num));
            int i = 6;
            while (i <= limit)
            {
                if (num % (i + 1) == 0 || num % (i + 5) == 0) { return false; }

                i += 6;
            }

            return true;
            
        }

        //create a list of all prime factors for the input number - returns empty list if no prime factors
        public static List<int> Factors(int num)
        {
            List<int> primeNumbers = Finder(num);
            List<int> primeFactors = new List<int>();

            if (Check(num))
            {
                primeFactors.Add(num);
            }

            else
            {
                foreach (int p in primeNumbers)
                {
                    while (num % p == 0)
                    {
                        primeFactors.Add(p);
                        num /= p;
                    }
                }
            }

            return primeFactors;
        }

        //returns a list of all factors that appear in either input number (prime factorisation of LCM)
        static List<int> FactorsAll(int num1, int num2)
        {
            List<int> pf1 = Factors(num1);
            List<int> pf2 = Factors(num2);

            List<int> pfa = new List<int>();

            foreach (int p in pf1)
            {
                int c = Math.Max(pf1.Count(q => q == p), pf2.Count(r => r == p));

                for (int i = 0; i < c; i++)
                {
                    pfa.Add(p);
                }
            }

            foreach (int p in pf2)
            {
                if (!pf1.Contains(p))
                {
                    pfa.Add(p);
                }
            }

            return pfa;
        }

        //returns a list of all common factors (prime factorisation of HCF)
        public static List<int> FactorsCommon(int num1, int num2)
        {
            List<int> pf1 = Factors(num1);
            List<int> pf2 = Factors(num2);

            List<int> pfc = new List<int>();

            foreach (int p in pf1)
            {
                int c = Math.Min(pf1.Count(q => q == p), pf2.Count(r => r == p));

                if (c == 0) { break; }

                for (int i = 0; i < c; i++)
                {
                    pfc.Add(p);
                }
            }

            return pfc;
        }

        //checks if two numbers are coprime - no common factors
        public static bool CoPrime(int num1, int num2)
        {
            List<int> cf = FactorsCommon(num1, num1);
            
            if (cf.Count == 0) { return true; }
            else { return false; }
        }

        //returns the lowest common multiple for two numbers
        public static int LCM(int num1, int num2)
        {
            List<int> pfa = FactorsAll(num1, num2);
            int lcm = 1;
            foreach (int p in pfa)
            {
                lcm *= p;
            }
            return lcm;
        }

        //returns the highest common factor for two numbers
        public static int HCF(int num1, int num2)
        {
            List<int> pfc = FactorsCommon(num1, num2);

            int hcf = 1;
            foreach (int p in pfc)
            {
                hcf *= p;
            }
            return hcf;
        }

        //simplifies a fraction - input the numerator and denominator, returns true if can be simplified, outputs the new numerator and denominator
        public static bool Simplify(int n, int m, out int a, out int b)
        {
            int hcf = HCF(n, m);
            if (n % hcf == 0 && m % hcf == 0)
            {
                a = n / hcf;
                b = m / hcf;
            }

            else
            {
                a = n;
                b = m;
            }

            if (hcf == 1)
            { return false; }
            else { return true; }
        }

        public static Tuple<int, int> Equivalent(int n, int m, out int r)
        {
            Random rnd = new Random();
            r = rnd.Next(2, 100);

            return new Tuple<int, int>(r * n, r * m);

        }

        public static Tuple<int, int>[] Equivalent(int n, int m)
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 30);

            Tuple<int, int>[] fractions = new Tuple<int, int>[l];

            for (int i = 0; i < l; i++)
            {
                int r = rnd.Next(2, 100);
                int b = rnd.Next(0, 1);

                if (b == 0 && n % r ==0 && m % r == 0)
                { fractions[i] = new Tuple<int, int>(n / r, m / r); }

                else
                { fractions[i] = new Tuple<int, int>(n * r, m * r); }
            }

            return fractions;
        }

        //input two fractions as num, den - returns tuple for sum (num, den)
        public static Tuple<int, int> Add(int n, int m, int a, int b)
        {
            int lcm = LCM(m, b);

            int num = ((lcm / m) * n) + ((lcm / b) * a);

            return new Tuple<int, int>(num, lcm);
        }

        //input two fractions as num, den - returns tuple for difference (num, den)
        public static Tuple<int, int> Subtract(int n, int m, int a, int b)
        {
            int lcm = LCM(m, b);

            int num = ((lcm / m) * n) - ((lcm / b) * a);

            return new Tuple<int, int>(num, lcm);
        }
    }
}
