using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static string NumberStats(double number)
        {
            string evenOdd ="";
            string posNega = "";
            string decInt = "";
            if (number % 2 == 0)
            {
                evenOdd = "Even";
            }else
            {
                evenOdd = "Odd";
            }

            if(number > 0)
            {
                posNega = "Positive";
            }else if(number < 0)
            {
                posNega = "Negative";
            }
            else
            {
                posNega = "Zero";
            }

            if(number % 1 > 0)
            {
                decInt = "Decimal";
            }
            else
            {
                decInt = "Integer";
            }
            return $"Stats for number: {number}\n{posNega} {decInt} {evenOdd}";
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Number:");
                if (double.TryParse(Console.ReadLine(),out double number))
                {
                    Console.WriteLine(NumberStats(number));
                }
                else
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }

                Console.WriteLine("Do you want to try again? (Y/N)");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}