using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[6];

            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine($"Enter number {i+1}:");
                bool result = int.TryParse(Console.ReadLine(), out int number);
                if (result)
                {
                    integerArray[i] = number;
                }
                else
                {
                    Console.WriteLine("Not a valid number.Enter again.");
                    i--;
                    continue;
                }
            }

            Console.WriteLine("------------------------");

            int sum = 0;

            foreach (int number in integerArray)
            {
                Console.Write($"{number} ");
                Thread.Sleep(100);
                if(number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine($"The sum is {sum}.");
            Console.ReadLine();
        }
    }
}
