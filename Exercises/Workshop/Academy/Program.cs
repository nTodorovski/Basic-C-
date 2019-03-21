using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Program
    {
        static User EnterInfo(Role role)
        {
            Console.WriteLine("Enter First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();
            User user = new User();
            if (role == Role.Admin)
            {
                user = new Admin(fName, lName, userName, passWord);
            }
            else if (role == Role.Student)
            {
                user = new Student(fName, lName, userName, passWord);
            }
            else if (role == Role.Trainer)
            {
                user = new Trainer(fName, lName, userName, passWord);
            }
            return user;
        }
        static void AddUser(List<User> lista, User user1)
        {
            Console.WriteLine($"Hello {user1.FirstName} {user1.LastName}!");
            Console.WriteLine("What role do you want to add?");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Trainer");
            Console.WriteLine("3. Student");
            int add = int.Parse(Console.ReadLine());

            if (add == 1)
            {
                User user = EnterInfo(Role.Admin);
                lista.Add(user);
                Console.WriteLine("You have successfuly added an Admin!");
            }
            else if (add == 2)
            {
                User user = EnterInfo(Role.Trainer);
                lista.Add(user);
                Console.WriteLine("You have successfuly added an Trainer!");
            }
            else if (add == 3)
            {
                User user = EnterInfo(Role.Student);
                lista.Add(user);
                Console.WriteLine("You have successfuly added an Student!");
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
        static void RemoveUser(List<User> lista, User user1)
        {
            Console.WriteLine($"Hello {user1.FirstName} {user1.LastName}!");
            Console.WriteLine("Which user do you want to remove?");
            User selectedUser = null;

            foreach (User user in lista)
            {
                user.PrintInfo();
            }

            Console.WriteLine("Enter First Name of User:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of User:");
            string lName = Console.ReadLine();

            foreach (User user in lista)
            {
                if (user == user1)
                {
                    continue;
                }
                if (user.FirstName == fName)
                {
                    if (user.LastName == lName)
                    {
                        selectedUser = user;
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
        static void LogIn(List<User> lista,  ref User currentUser)
        {
            bool flag = false;
            bool flag1 = false;
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            foreach (User user in lista)
            {
                if (user.Username == username)
                {
                    flag = true;
                    Console.WriteLine("Enter Password:");
                    string password = Console.ReadLine();
                    if (user.GetPassword() == password)
                    {
                        flag1 = true;
                        currentUser = user;
                        Console.WriteLine($"Welcome {currentUser.FirstName} {currentUser.LastName}!");
                    }
                }
            }

            if (flag == false)
            {
                throw new Exception("Wrong username!");
            }
            else if (flag1 == false)
            {
                throw new Exception("Wrong password");
            }
        }
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new Admin("Pero","Perovski","peroKamikaza","1234"),
                new Admin("Risto","Ristovski","riki","1123"),
                new Student("Miki","Perovski","miki","3342"),
                new Student("Majk","Nikolovski","majki","6654"),
                new Student("Koki","Perevski","koki1","7786"),
                new Student("Goce","Delchev","goceKomita","1903"),
                new Trainer("Mitko","Mitkovski","mite","23356"),
                new Trainer("Dejan","Lovren","deki","5577")
            };

            List<Subject> subjects = new List<Subject>()
            {
                new Subject("C#"),
                new Subject("C# Advanced"),
                new Subject("JavaScript"),
                new Subject("JavaScript Advanced"),
                new Subject("HTML"),
                new Subject("CSS")
            };

            try
            {
                Console.WriteLine("Enter Role:");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Trainer");
                Console.WriteLine("3. Student");

                int roleInput = int.Parse(Console.ReadLine());

                User currentUser = null;
                if (roleInput == 1)
                {
                    LogIn(users, ref currentUser);
                    Console.WriteLine("Choose Action");
                    Console.WriteLine("1. Add User");
                    Console.WriteLine("2. Remove User");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        AddUser(users, currentUser);
                    }
                    else if (input == 2)
                    {
                        RemoveUser(users, currentUser);
                    }
                }
                else if (roleInput == 2)
                {
                    LogIn(users, ref currentUser);

                }
                else if (roleInput == 3)
                {
                    LogIn(users, ref currentUser);
                }
                else
                {
                    throw new Exception("Please enter 1,2 or 3.");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
