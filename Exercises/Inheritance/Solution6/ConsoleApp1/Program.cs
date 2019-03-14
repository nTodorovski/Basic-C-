using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee manager = new Employee() { FirstName = "Trajko",LastName="Trajkovic",Role = Role.Manager};
            //manager.SetSalary(1300);
            //manager.PrintInfo();
            //Console.WriteLine($"Salary:{manager.GetSalary()}");
            //Console.ReadLine();

            SalesPerson prodavac = new SalesPerson("Dragisha", "Miletich");
            Console.WriteLine($"Salary with SuccessRevenue under 2000: {prodavac.GetSalary()}");
            prodavac.AddSuccessRevenue(3000);
            Console.WriteLine($"Salary with SalesRevenue: {prodavac.GetSalary()}");
            Console.ReadLine();
        }
    }
}
