using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Sales;
            Salary = 500;
        }

        public void AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue = number;
        }

        public override double GetSalary()
        {
            if(SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }else if(SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }else if(SuccessSaleRevenue > 5000)
            {
                return Salary + 1500;
            }
            else
            {
                return Salary;
            }
        }
    }
}
