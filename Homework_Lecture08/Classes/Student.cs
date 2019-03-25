using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student : User
    {
        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject,int> Grades { get; set; }

        public Student() { }

        public Student(string firstName,string lastName,string username,string password):base(firstName,lastName,username,password)
        {
            Role = Role.Student;
            CurrentSubject = new Subject();
            Grades = new Dictionary<Subject, int>();
        }


        public void ChooseActionStudent(List<Subject> subjects)
        {
            Console.WriteLine("Choose Action:");
            Console.WriteLine("1. Enrol to a Subject");
            Console.WriteLine("2. Show Grades");
            int actionInput = int.Parse(Console.ReadLine());

            if (actionInput == 1)
            {
                foreach (Subject subject in subjects)
                {
                    subject.PrintInfo();
                }
                Console.WriteLine("Enter name of the Subject");
                string input = Console.ReadLine();
                EnrolToSubject(input, subjects);
                foreach (Subject subject in subjects)
                {
                    Console.WriteLine($"Subject: \"{subject.NameOfSubject}\" Attending Students: ({subject.AttendingStudents})");
                }
                Console.WriteLine($"{FirstName} {LastName} current subject is: \"{CurrentSubject.NameOfSubject}\"");
            }
            else if (actionInput == 2)
            {
                ShowGrades();
            }
            else
            {
                throw new Exception("Please enter 1 or 2.");
            }
        }

        public void EnrolToSubject(string nameOfSub, List<Subject> subjects)
        {
            bool flag = false;
            Subject currentlyListening = new Subject();

            if (CurrentSubject.NameOfSubject == nameOfSub)
            {
                throw new Exception($"You are already listening to subject {CurrentSubject.NameOfSubject}");
            }
            else
            {
                foreach (Subject subject in subjects)
                {
                    if (subject.NameOfSubject == CurrentSubject.NameOfSubject)
                    {
                        currentlyListening = subject;
                    }
                }
            }

            foreach (Subject subject in subjects)
            {
                if (subject.NameOfSubject == nameOfSub)
                {
                    currentlyListening.AttendingStudents--;
                    subject.AttendingStudents++;
                    CurrentSubject = subject;
                    flag = true;
                    Console.WriteLine($"You have successfuly enroled to {subject.NameOfSubject}");
                }
            }
            if (!flag)
            {
                throw new Exception("Not such a subject!");
            }
        }

        public void ShowGrades()
        {
            Console.WriteLine($"Grades of Student: {FirstName} {LastName}");
            foreach (var item in Grades)
            {
                Console.WriteLine($"{item.Key.NameOfSubject} : {item.Value}");
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role} - {Username}");
        }
    }
}
