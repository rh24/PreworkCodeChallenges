using System;
using System.Linq;

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

            Console.WriteLine("Please input a number 1-10 and press enter until further instructions.");

            for (int i = 0; i < 5; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 10 && input > 1)
                {
                    numbers[i] = input;
                }
                else
                {
                    Console.WriteLine("Now you have to start over. Follow instructions! Give me a number between 1 and 10.");
                    ArrayMaxResult();
                }
            }
            Console.WriteLine("Your array is [{0}]", string.Join(", ", numbers));

            Console.WriteLine("Now choose a number in the array.");
            int chosenNum = int.Parse(Console.ReadLine());
            if (numbers.Contains(chosenNum))
            {
                Console.Write("You chose " + chosenNum);
            }
            else
            {
                Console.Write("That's not in the array.");
            }

            // count number of times their chosen number appears in the array
            // return chosenNum * count
            int count = numbers
                .Where(x => x == chosenNum)
                .Count();
            Console.WriteLine("That number appeared in the array " + count + "times");

            // raise to the power of count
            return (int)Math.Pow(chosenNum, count);
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
