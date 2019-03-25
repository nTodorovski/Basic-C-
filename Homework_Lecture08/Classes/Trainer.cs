using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Trainer : User
    {

        public Trainer(string firstName,string lastName,string username,string password) : base(firstName,lastName,username,password)
        {
            Role = Role.Trainer;
        }
        public Trainer() { }

        public void ChooseActionTrainer(List<User> users, List<Subject> subjects)
        {
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Show all students");
            Console.WriteLine("2. Show all subjects");
            Console.WriteLine("3. Add grade to student");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                foreach (User user in users)
                {
                    if (user.Role == Role.Student)
                    {
                        user.PrintInfo();
                    }
                    else
                    {
                        continue;
                    }
                }

                Console.WriteLine("Enter First Name:");
                string fNameInput = Console.ReadLine();
                Console.WriteLine("Enter Last Name:");
                string lNameInput = Console.ReadLine();

                foreach (Student user in users.Where(x => x.Role == Role.Student))
                {
                    if (user.FirstName == fNameInput)
                    {
                        if (user.LastName == lNameInput)
                        {
                            Console.WriteLine($"Grades of Student: {user.FirstName} {user.LastName}");
                            foreach (var item in user.Grades)
                            {
                                Console.WriteLine($"{item.Key.NameOfSubject} : {item.Value}");
                            }
                        }
                    }
                }
            }
            else if (input == 2)
            {
                foreach (var subject in subjects)
                {
                    Console.WriteLine($"Subject: \"{subject.NameOfSubject}\" Attending Students: ({subject.AttendingStudents})");
                }
            }
            else if(input == 3)
            {
                AddGradeToStudent(users,subjects);
            }
            else
            {
                throw new Exception("Please enter 1,2 or 3!");
            }
        }

        public void AddGradeToStudent(List<User> users, List<Subject> subjects)
        {
            foreach (Student student in users.Where(x => x.Role == Role.Student))
            {
                student.PrintInfo();
            }
            Console.WriteLine("Enter First Name of student:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of student:");
            string lName = Console.ReadLine();

            foreach (Student student in users.Where(x => x.Role == Role.Student))
            {
                if(student.FirstName == fName && student.LastName == lName)
                {
                    foreach (Subject subject in subjects)
                    {
                        subject.PrintInfo();
                    }
                    Console.WriteLine("Enter name of Subject:");
                    string name = Console.ReadLine();
                    foreach (Subject subject in subjects)
                    {
                        if(subject.NameOfSubject == name)
                        {
                            Console.WriteLine("Enter grade:");
                            int grade = int.Parse(Console.ReadLine());
                            student.Grades[subject] = grade;
                            foreach (var grade1 in student.Grades)
                            {
                                Console.WriteLine($"{grade1.Key.NameOfSubject} : {grade1.Value}");
                            }
                        }
                    }
                }
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role} - {Username}");
        }
    }
}
