using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //var oldColor = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"Hello World in {Console.ForegroundColor}!");
            //Thread.Sleep(2000);
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"Hello World in {Console.ForegroundColor}!");
            //Thread.Sleep(2000);
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Hello World in {Console.ForegroundColor}!");
            //Console.ForegroundColor = oldColor;
            //Console.ReadLine();
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Christmas Tree in {Console.ForegroundColor}!");
            Thread.Sleep(2000);
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.ReadLine();
        }
    }
}
