using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {


        static double RealCalculator(int num1, int num2, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    double number1 = Convert.ToDouble(num1);
                    double number2 = Convert.ToDouble(num2);
                    result = number1 / number2;
                    break;
            }

            return result;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            var firstInput = Console.ReadLine();
            bool firstResult = int.TryParse(firstInput, out int first);

            if (!firstResult)
            {
                Console.WriteLine($"You entered '{firstInput}' which is not a valid number");
                return;
            }

            Console.Write("Enter the Second number: ");
            var secondInput = Console.ReadLine();
            bool secondResult = int.TryParse(secondInput, out int second);

            if (!secondResult)
            {
                Console.WriteLine($"You entered '{secondInput}' which is not a valid number");
                return;
            }

            Console.Write("Enter the Operation ( +, - , * , / ): ");
            string thirdInput = Console.ReadLine();
            if(thirdInput != "+" && thirdInput != "-" && thirdInput != "*" && thirdInput != "/")
            {
                Console.WriteLine("You entered wrong operation.");
                return;
            }
            else
            {
                string third = thirdInput;
                double finalResult = RealCalculator(first, second, third);
                Console.WriteLine(finalResult);
                Console.ReadLine();
            }
        }
    }
}
