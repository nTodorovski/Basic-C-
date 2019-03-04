using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                string number = i.ToString();
                int number1 = i;
                int sum = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    sum = sum + (number1 % 10);
                    number1 = number1 / 10;
                }
                if(i % sum == 0)
                {
                    Console.WriteLine($"{i} is dividable with the product of his digits.");
                }
            }
            Console.ReadLine();
        }
    }
}
