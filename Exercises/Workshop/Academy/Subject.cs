using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    public class Subject
    {
        public string NameOfSubject { get; set; }
        public int AttendingStudents { get; set; }

        public Subject() { }

        public Subject(string nameOfSubject)
        {
            NameOfSubject = nameOfSubject;
        }
    }
}
