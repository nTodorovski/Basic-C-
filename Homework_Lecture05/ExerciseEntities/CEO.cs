using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEntities
{
    public class CEO : Employee
    {
        public List<Employee> employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName,string lastName,int shares)
        {
            FirstName = firstName;
            LastName = lastName;
            Shares = shares;
            Salary = 1500;
        }

        public void AddSharesPrice(double number)
        {
            SharesPrice = number;
        }

        public void PrintEmployees()
        {
            foreach (var employee in employees)
            {
                employee.GetSalary();
                employee.PrintInfo();
            }
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }
    }
}
