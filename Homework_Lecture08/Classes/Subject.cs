using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Subject
    {
        public string NameOfSubject { get; set; }
        public int AttendingStudents { get; set; }

        public Subject() { }

        public Subject(string nameOfSubject)
        {
            NameOfSubject = nameOfSubject;
            AttendingStudents = 0;
        }

        public void PrintInfo()
        {
            Console.WriteLine(NameOfSubject);
        }
    }
}
