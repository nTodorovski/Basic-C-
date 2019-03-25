using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public Role Role { get; set; }

        public User() { }

        public User(string firstName,string lastName,string username,string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }

        public string GetPassword()
        {
            return Password;
        }

        public Admin CreateAdmin()
        {
            Console.WriteLine("Enter First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();

            Admin user = new Admin(fName, lName, userName, passWord);
            return user;
        }

        public Trainer CreateTrainer()
        {
            Console.WriteLine("Enter First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();

            Trainer user = new Trainer(fName, lName, userName, passWord);
            return user;
        }

        public Student CreateStudent(List<Subject> subjects)
        {
            Console.WriteLine("Enter First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();

            Student user = new Student(fName, lName, userName, passWord);
            foreach (Subject subject in subjects)
            {
                subject.PrintInfo();
                Console.WriteLine($"Enter Grade for {subject.NameOfSubject}:  (Enter number from 1 to 10)");
                int grade = int.Parse(Console.ReadLine());
                if (grade < 1 && grade > 10)
                {
                    throw new Exception("Not a number from 1 to 10.");
                }
                else
                {
                    user.Grades.Add(subject, grade);
                }
            }
            return user;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
