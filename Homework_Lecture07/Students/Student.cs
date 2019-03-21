using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public double AverageGrade { get; set; }

        public Student(string firstName, string lastName, Gender gender, double averageGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            AverageGrade = averageGrade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
