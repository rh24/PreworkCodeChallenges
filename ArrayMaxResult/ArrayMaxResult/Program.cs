using System;
using System.Collections;
using System.Linq;

namespace ArrayMaxResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 2, 4, 5 };
            //Console.WriteLine("Hello World!");
            Console.Write("result: " + CalculateMax(numbers));
            Console.ReadLine();
        }
        // I don't know how to test this because I'm having issues with the Build

        static int CalculateMax(int[] args)
        {
            int[] numbers = args;
            int tempMaxCount;
            int tempMaxNum;
            Hashtable ht = new Hashtable();

            foreach (int i in numbers)
            {
                if (ht.Contains(i))
                {
                    int oldVal = (int)ht[i];
                    ht[i] = oldVal + 1;
                }
                else
                {
                    ht.Add(i, 1);
                }
            }

            int currMaxCount = (int)ht[numbers[0]];
            int currMaxNum = numbers[0];

            for (int i = 0; i < numbers.Distinct<int>().Count(); i++)
            {
                currMaxCount = (int)ht[numbers[i]];
                tempMaxCount = (int)ht[numbers[i + 1]];
                currMaxNum = numbers[i];
                tempMaxNum = numbers[i + 1];

                if (tempMaxCount > currMaxCount)
                {
                    currMaxNum = tempMaxNum;
                }
            }

            return currMaxNum * currMaxCount;
        }
    }
}
