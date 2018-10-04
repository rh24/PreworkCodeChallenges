using System;

namespace LeapYearCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap Year Calculator!");
            Console.WriteLine(IsLeapYear(1996));
            Console.ReadLine();
        }

        static bool IsLeapYear(int num)
        {
            Console.WriteLine("The input: " + num);
            bool result = false;

            if (num % 4 == 0 && num % 100 != 0)
            {
                result = true;
            }
            else
            {
                if (num % 400 == 0)
                {
                    result = true;
                }
            }

            Console.WriteLine("The answer: " + result);
            return result;
        }
    }
}
