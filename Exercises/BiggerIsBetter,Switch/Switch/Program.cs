using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To buy new car press 1");
            Console.WriteLine("To buy new plane press 2");
            Console.WriteLine("To buy new bike press 3");
            Console.Write("Enter number: ");
            var numInput = Console.ReadLine();
            bool parseResult = int.TryParse(numInput, out int value);

            if (!parseResult)
            {
                Console.WriteLine($"You entered '{numInput}' which is not a valid integer");
                return;
            }

            switch (value)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine($"You entered wrong value {value}.");
                    break;
            }
        }
    }
}
