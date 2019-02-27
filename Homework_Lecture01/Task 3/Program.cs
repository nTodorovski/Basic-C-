using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void SwapNumbers<T>(ref T first, ref T second)
        {
            var temp = first;
            first = second;
            second = temp;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            var firstInput = Console.ReadLine();
            bool firstResult = double.TryParse(firstInput, out double first);

            if (!firstResult)
            {
                Console.WriteLine($"You entered '{firstInput}' which is not a valid number");
                return;
            }

            Console.Write("Enter the Second number: ");
            var secondInput = Console.ReadLine();
            bool secondResult = double.TryParse(secondInput, out double second);

            if (!secondResult)
            {
                Console.WriteLine($"You entered '{secondInput}' which is not a valid number");
                return;
            }

            SwapNumbers(ref first, ref second);
            Console.WriteLine("---------------------------");
            Console.WriteLine("After Swapping:");
            Console.WriteLine($"First Number: {first}");
            Console.WriteLine($"Second Number: {second}");
            Console.ReadLine();
        }
    }
}
