using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0 and 255: ");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Enter another number between 0 and 255: ");
            string secondNumber = Console.ReadLine();

            try
            {
                int num1 = int.Parse(firstNumber);
                int num2 = int.Parse(secondNumber);

                if (!(num1 >= 0 && num1 <= 255) || !(num2 >= 0 && num2 <= 255))
                {
                    throw new ArgumentOutOfRangeException();
                }

                else
                {
                    int res = num1 / num2;
                    Console.WriteLine(num1 + " divided by " + num2 + " is " + res);
                }

            }

            catch (FormatException e)
            {
                Console.WriteLine("\nFormat Exception: " + e.Message);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("\nDivide by Zero Exception: " + e.Message);
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("\nArgument out of Range Exception: " + e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()} says {e.Message}");
            }

            Console.WriteLine("\nHave a nice day!");
        }
    }
}
