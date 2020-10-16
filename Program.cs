using System;

namespace FizzBuzz4320
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                fizzBuzzCalc(i);
                Console.WriteLine(fizzBuzzCalc(i));
            }
        }

        public static string fizzBuzzCalc(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            return Convert.ToString(number);
        }
    }
}