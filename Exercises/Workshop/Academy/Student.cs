using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    public class Student : User
    {
        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject,double> Grades { get; set; }

        public Student(string firstName,string lastName,string username,string password):base(firstName,lastName,username,password)
        {
            Role = Role.Student;
            CurrentSubject = new Subject();
            Grades = new Dictionary<Subject, double>();
        }
        public Student() { }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role}");
        }
    }
}
