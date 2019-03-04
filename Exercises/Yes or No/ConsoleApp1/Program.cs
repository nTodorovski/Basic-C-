using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int index = 0;
            string[] names = new string[1];
            string yesNo = "";

            do
            {
                Console.WriteLine("Enter name:");
                var input = Console.ReadLine();
                names[index] = input;

                foreach (string name in names)
                {
                    Console.Write($"{name} ");
                    Thread.Sleep(100);
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to enter new name? Y/N");
                yesNo = Console.ReadLine();
                while (yesNo != "Y" && yesNo != "N")
                {
                    Console.WriteLine("Enter valid input");
                    yesNo = Console.ReadLine();
                }
                if (yesNo == "Y")
                {
                    counter++;
                    index++;
                    Array.Resize(ref names, counter);
                }
            } while (yesNo != "N");
            Console.ReadLine();
        }
    }
}
