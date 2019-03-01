using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            var firstInput = Console.ReadLine();
            bool parseResult = int.TryParse(firstInput, out int first);
            if (!parseResult)
            {
                Console.WriteLine("not a valid number");
                return;
            }
            else
            {
                for (int i = 1; i <= first; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("FizzBuzz ");
                        Thread.Sleep(100);
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("Buzz ");
                        Thread.Sleep(100);
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("Fizz ");
                        Thread.Sleep(100);
                    }
                    else
                    {
                        Console.Write($"{i} ");
                        Thread.Sleep(100);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
