using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public Role Role { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}, Role: {Role}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public void SetSalary(double number)
        {
            Salary = number;
        }

    }

    public enum Role
    {
        Sales,
        Manager,
        Other
    }
}
