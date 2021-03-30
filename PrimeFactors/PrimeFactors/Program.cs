using System;

namespace PrimeFactors
{
    class Program
    {
        public static string PrimeFactors(int number)
        {
            string res = string.Empty;

            for (int i = 2; i <= number; ++i) {
                while (number % i == 0)
                {
                    res += string.IsNullOrEmpty(res) ? i.ToString() : " x " + 1;
                    number = number / i;
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PrimeFactors(40));
        }
    }
}
