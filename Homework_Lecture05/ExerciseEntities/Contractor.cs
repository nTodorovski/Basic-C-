using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEntities
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName,string lastName, double workHours,int payPerHour,Manager responsible)
        {
            FirstName = firstName;
            LastName = lastName;
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
            Salary = 800;
            Role = Role.Contractor;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Salary: {2} Role: {3}, Working under Manager: {4} {5}", FirstName, LastName, GetSalary(), Role, Responsible.FirstName, Responsible.LastName);
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return WorkHours * PayPerHour; ;
        }

        public Manager CurrentPosition()
        {
            return Responsible;
        }
    }
}
