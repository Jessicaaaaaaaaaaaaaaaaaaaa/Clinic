using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100;

            for (int j = 1; j <= length; j++)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }

                else if (j % 3 == 0)
                {
                    Console.Write("Fizz");
                }

                else if (j % 5 == 0)
                {
                    Console.Write("Buzz");
                }

                else
                {
                    Console.Write(j);
                }

                if (j == 100)
                {
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(", ");
                }

                if (j % 15 == 0)
                {
                    Console.Write("\n");
                }
            }

        }
    }
}
