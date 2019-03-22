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
                if(user == user1)
                {
                    continue;
                }
                user.PrintInfo();
            }

            Console.WriteLine("Enter First Name of User:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of User:");
            string lName = Console.ReadLine();

            if(fName == user1.FirstName && lName == user1.LastName)
            {
                throw new Exception("You cannot remvoe yourself!");
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

        static void LogInAdmin(List<User> lista,  ref Admin currentUser)
        {
            bool flag = false;
            bool flag1 = false;
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            foreach (Admin user in lista.Where(x => x.Role == Role.Admin))
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

        static void LogInTrainer(List<User> lista, ref Trainer currentUser)
        {
            bool flag = false;
            bool flag1 = false;
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            foreach (Trainer user in lista.Where(x => x.Role == Role.Trainer))
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

        static void LogInStudent(List<User> lista, ref Student currentUser)
        {
            bool flag = false;
            bool flag1 = false;
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            foreach (Student user in lista.Where(x => x.Role == Role.Student))
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

        static void EnrolToSubject(ref Student currentUser,string nameOfSub,List<Subject> subjects)
        {
            bool flag = false;
            foreach (Subject subject in subjects)
            {
                if(subject.NameOfSubject == nameOfSub)
                {
                    subject.AttendingStudents++;
                    currentUser.CurrentSubject = subject;
                    flag = true;
                    Console.WriteLine($"You have successfuly enroled to {subject.NameOfSubject}");
                }
            }
            if (!flag)
            {
                throw new Exception("Not such a subject!");
            }
        }

        static void ShowGrades(ref Student currentUser)
        {
            Console.WriteLine($"Grades of Student: {currentUser.FirstName} {currentUser.LastName}");
            foreach (var item in currentUser.Grades)
            {
                Console.WriteLine($"{item.Key.NameOfSubject} : {item.Value}");
            }
        }

        static void Main(string[] args)
        {
            Subject cSharp = new Subject("C#");
            Subject cSharpAdvanced = new Subject("C# Advanced");
            Subject javaScript = new Subject("JavaScript");
            Subject javaScriptAdvanced = new Subject("JavaScript Advanced");
            Subject html = new Subject("HTML");
            Subject css = new Subject("CSS");

            List<Subject> subjects = new List<Subject>() { cSharp, cSharpAdvanced, javaScript, javaScriptAdvanced, html, css };


            Admin admin1 = new Admin("Pero", "Perovski", "peroKamikaza", "1234");
            Admin admin2 = new Admin("Risto", "Ristovski", "riki", "1123");
            Student student1 = new Student("Miki", "Perovski", "miki", "3342");
            student1.Grades = new Dictionary<Subject, double>()
            {
                {cSharp,5 },
                {cSharpAdvanced,7.8},
                {javaScript,9.4 },
                {javaScriptAdvanced,7.5 },
                {html,8.3 },
                {css,4.3 }
            };
            Student student2 = new Student("Majk", "Nikolovski", "majki", "6654");
            student2.Grades = new Dictionary<Subject, double>()
            {
                {cSharp,7 },
                {cSharpAdvanced,8.7},
                {javaScript,7.4 },
                {javaScriptAdvanced,5.6 },
                {html,3.8 },
                {css,2.8 }
            };
            Student student3 = new Student("Koki", "Perevski", "koki1", "7786");
            student3.Grades = new Dictionary<Subject, double>()
            {
                {cSharp,9 },
                {cSharpAdvanced,9.2},
                {javaScript,4.7 },
                {javaScriptAdvanced,6.6 },
                {html,8.6 },
                {css,8.2 }
            };
            Student student4 = new Student("Goce", "Delchev", "goceKomita", "1903");
            student4.Grades = new Dictionary<Subject, double>()
            {
                {cSharp,4 },
                {cSharpAdvanced,4.2},
                {javaScript,9.1 },
                {javaScriptAdvanced,9.8 },
                {html,8.4 },
                {css,9.6 }
            };
            Trainer trainer1 = new Trainer("Mitko", "Mitkovski", "mite", "23356");
            Trainer trainer2 = new Trainer("Dejan", "Lovren", "deki", "5577");
            List<User> users = new List<User>() { admin1, admin2, student1, student2, student3, student4, trainer1, trainer2 };

            try
            {
                Console.WriteLine("Enter Role:");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Trainer");
                Console.WriteLine("3. Student");

                int roleInput = int.Parse(Console.ReadLine());

                if (roleInput == 1)
                {
                    Admin adminUser = null;
                    LogInAdmin(users, ref adminUser);
                    Console.WriteLine("Choose Action");
                    Console.WriteLine("1. Add User");
                    Console.WriteLine("2. Remove User");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        AddUser(users, adminUser);
                    }
                    else if (input == 2)
                    {
                        RemoveUser(users, adminUser);
                    }
                    else
                    {
                        throw new Exception("Please enter 1 or 2!");
                    }
                }
                else if (roleInput == 2)
                {
                    Trainer trainerUser = null;
                    LogInTrainer(users, ref trainerUser);
                    Console.WriteLine("Choose action:");
                    Console.WriteLine("1. Show all students");
                    Console.WriteLine("2. Show all subjects");
                    int input = int.Parse(Console.ReadLine());

                    if(input == 1)
                    {
                        foreach (User user in users)
                        {
                            if(user.Role == Role.Student)
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
                            if(user.FirstName == fNameInput)
                            {
                                if(user.LastName == lNameInput)
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
                    else if(input == 2)
                    {
                        foreach (var subject in subjects)
                        {
                            Console.WriteLine($"Subject: \"{subject.NameOfSubject}\" Attending Students: ({subject.AttendingStudents})");
                        }
                    }
                    else
                    {
                        throw new Exception("Please enter 1 or 2!");
                    }
                }
                else if (roleInput == 3)
                {
                    Student studentUser = null;
                    LogInStudent(users, ref studentUser);
                    Console.WriteLine("Choose Action:");
                    Console.WriteLine("1. Enrol to a Subject");
                    Console.WriteLine("2. Show Grades");
                    int actionInput = int.Parse(Console.ReadLine());

                    if(actionInput == 1)
                    {
                        foreach (Subject subject in subjects)
                        {
                            subject.PrintInfo();
                        }
                        Console.WriteLine("Enter name of the Subject");
                        string input = Console.ReadLine();
                        EnrolToSubject(ref studentUser, input, subjects);
                        foreach (Subject subject in subjects)
                        {
                                Console.WriteLine($"Subject: \"{subject.NameOfSubject}\" Attending Students: ({subject.AttendingStudents})");
                        }
                        Console.WriteLine($"{studentUser.FirstName} {studentUser.LastName} current subject is: \"{studentUser.CurrentSubject.NameOfSubject}\"");
                    }
                    else if(actionInput == 2)
                    {
                        ShowGrades(ref studentUser);
                    }
                    else
                    {
                        throw new Exception("Please enter 1 or 2.");
                    }
                }
                else
                {
                    throw new Exception("Please enter 1,2 or 3!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a correct format and you broke it!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
