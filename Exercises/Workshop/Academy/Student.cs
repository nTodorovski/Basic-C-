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
        public Dictionary<string,int> Grades { get; set; }
        public Role Role { get; set; }

        public Student(string firstName,string lastName,string username,string password):base(firstName,lastName,username,password)
        {
            Role = Role.Student;
            CurrentSubject = new Subject();
            Grades = new Dictionary<string, int>();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role}");
        }
    }
}
