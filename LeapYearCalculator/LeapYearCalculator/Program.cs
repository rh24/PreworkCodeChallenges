using System;

namespace LeapYearCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Leap Year Calculator!");
            Console.WriteLine(IsLeapYear(1996));
            Console.WriteLine(IsLeapYear(1997));
            Console.WriteLine(IsLeapYear(2000));
            Console.WriteLine(IsLeapYear(1900));
            
            Console.WriteLine(ArrayMaxResult());
            Console.ReadLine();
            
        }

        static int ArrayMaxResult()
        {
            int[] numbers = new int[5];

            Console.WriteLine("Please input a number and press enter until further instructions.");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your array is [{0}]", string.Join(", ", numbers));
            Console.ReadLine();
            return 0;
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
