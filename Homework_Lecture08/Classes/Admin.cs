using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Admin : User
    {

        public Admin() { }

        public Admin(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password)
        {
            Role = Role.Admin;
        }

        public void ChooseActionAdmin(List<User> users, List<Subject> subjects)
        {
            Console.WriteLine("Choose Action");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Remove User");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                AddUser(users,subjects);
            }
            else if (input == 2)
            {
                RemoveUser(users);
            }
            else
            {
                throw new Exception("Please enter 1 or 2!");
            }
        }

        public void AddUser(List<User> lista,List<Subject> subjects)
        {
            Console.WriteLine($"Hello {FirstName} {LastName}!");
            Console.WriteLine("What role do you want to add?");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Trainer");
            Console.WriteLine("3. Student");
            int add = int.Parse(Console.ReadLine());

            if (add == 1)
            {
                Admin user = CreateAdmin();
                lista.Add(user);
                Console.WriteLine("You have successfuly added an Admin!");
            }
            else if (add == 2)
            {
                Trainer user = CreateTrainer();
                lista.Add(user);
                Console.WriteLine("You have successfuly added a Trainer!");
            }
            else if (add == 3)
            {
                Student user = CreateStudent(subjects);
                lista.Add(user);
                Console.WriteLine("You have successfuly added a Student!");
            }
            else
            {
                throw new Exception("Please enter 1,2 or 3");
            }
            foreach (User user in lista)
            {
                user.PrintInfo();
            }
        }

        public void RemoveUser(List<User> lista)
        {
            Console.WriteLine($"Hello {FirstName} {LastName}!");
            Console.WriteLine("Which user do you want to remove?");
            User selectedUser = null;

            foreach (User user in lista)
            {
                if (user.FirstName == FirstName)
                {
                    continue;
                }
                user.PrintInfo();
            }

            Console.WriteLine("Enter First Name of User:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of User:");
            string lName = Console.ReadLine();

            if (fName == FirstName && lName == LastName)
            {
                throw new Exception("You cannot remove yourself!");
            }
            else
            {
                foreach (User user in lista)
                {
                    if (user.FirstName == fName)
                    {
                        if (user.LastName == lName)
                        {
                            selectedUser = user;
                        }
                    }
                }
            }

            if (selectedUser == null)
            {
                throw new Exception("There is not such a user!");
            }
            else
            {
                Console.WriteLine($"You have deleted {selectedUser.FirstName} {selectedUser.LastName}!");
                lista.Remove(selectedUser);
                foreach (User user in lista)
                {
                    user.PrintInfo();
                }
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role} - {Username}");
        }
    }
}
