using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEntities
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Role Role { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Salary: {2} Role: {3}", FirstName, LastName, GetSalary(), Role);
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
