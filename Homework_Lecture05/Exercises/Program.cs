using ExerciseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee bob = new Employee() { FirstName = "Bob", LastName = "Bobsky", Salary = 600, Role = Role.Other };
            SalesPerson bill = new SalesPerson("Bill", "Billsky", 1500);
            bill.ExtendSuccessSaleRevenue(2000);
            Manager elonMusk = new Manager("Elon", "Musk", 2500);
            Manager billGates = new Manager("Bill", "Gates", 2600);
            Contractor contractor1 = new Contractor("Trajko", "Trajkovic", 40, 9, elonMusk);
            Contractor contractor2 = new Contractor("Dragisha", "Miletich", 60, 11, billGates);



            CEO timCook = new CEO("Tim", "Cook", 560);
            timCook.employees = new List<Employee> { bob, bill, elonMusk, billGates, contractor1, contractor2 };
            Console.WriteLine("CEO");
            timCook.PrintInfo();
            timCook.AddSharesPrice(186);
            Console.WriteLine($"Salary of the CEO is: {timCook.GetSalary()}");
            Console.WriteLine("Employees");
            timCook.PrintEmployees();

            Console.ReadLine();
        }
    }
}
