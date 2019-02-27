using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {

        static double AverageNumber(double num1, double num2, double num3, double num4)
        {
            double result = (num1 + num2 + num3 + num4) / 4;
            return result;
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

            Console.Write("Enter the Third number: ");
            var thirdInput = Console.ReadLine();
            bool thirdResult = double.TryParse(thirdInput, out double third);

            if (!thirdResult)
            {
                Console.WriteLine($"You entered '{thirdInput}' which is not a valid number");
                return;
            }

            Console.Write("Enter the Fourth number: ");
            var fourthInput = Console.ReadLine();
            bool fourthResult = double.TryParse(fourthInput, out double fourth);

            if (!fourthResult)
            {
                Console.WriteLine($"You entered '{fourthInput}' which is not a valid number");
                return;
            }

            double finalResult = AverageNumber(first, second, third, fourth);
            Console.WriteLine($"The average of {first}, {second}, {third} and {fourth} is: {finalResult}.");
            Console.ReadLine();
        }
    }
}
