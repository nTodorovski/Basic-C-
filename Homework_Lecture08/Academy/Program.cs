using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Program
    {
        static void LogInAdmin(List<User> lista, ref Admin currentUser)
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
                        Console.WriteLine($"Current Subject Teaching: {currentUser.CurrentSubject.NameOfSubject}");
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

        static bool DoYouWantToConitnue()
        {
            Console.WriteLine("Do you want to do another action? (Y/N)");
            char yesNo = char.Parse(Console.ReadLine());
            if (Char.ToLower(yesNo) != 'n' && Char.ToLower(yesNo) != 'y')
            {
                throw new Exception("Please enter Yes or No!");
            }

            if (Char.ToLower(yesNo) == 'n')
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static int EnterRole()
        {
            Console.WriteLine("Enter Role:");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Trainer");
            Console.WriteLine("3. Student");

            int roleInput = int.Parse(Console.ReadLine());

            if (roleInput != 1 && roleInput != 2 && roleInput != 3)
            {
                throw new Exception("Please enter 1,2 or 3!");
            }
            else
            {
                return roleInput;
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
            student1.Grades = new Dictionary<Subject, int>()
            {
                {cSharp,5 },
                {cSharpAdvanced,7},
                {javaScript,9 },
                {javaScriptAdvanced,7 },
                {html,8 },
                {css,4 }
            };
            Student student2 = new Student("Majk", "Nikolovski", "majki", "6654");
            student2.Grades = new Dictionary<Subject, int>()
            {
                {cSharp,7 },
                {cSharpAdvanced,8 },
                {javaScript,7 },
                {javaScriptAdvanced,5 },
                {html,3 },
                {css,2 }
            };
            Student student3 = new Student("Koki", "Perevski", "koki1", "7786");
            student3.Grades = new Dictionary<Subject, int>()
            {
                {cSharp,9 },
                {cSharpAdvanced,9 },
                {javaScript,4 },
                {javaScriptAdvanced,6 },
                {html,8 },
                {css,8 }
            };
            Student student4 = new Student("Goce", "Delchev", "goceKomita", "1903");
            student4.Grades = new Dictionary<Subject, int>()
            {
                {cSharp,4 },
                {cSharpAdvanced,4 },
                {javaScript,9 },
                {javaScriptAdvanced,9 },
                {html,8 },
                {css,9 }
            };
            Trainer trainer1 = new Trainer("Mitko", "Mitkovski", "mite", "23356");
            Trainer trainer2 = new Trainer("Dejan", "Lovren", "deki", "5577");
            List<User> users = new List<User>() { admin1, admin2, student1, student2, student3, student4, trainer1, trainer2 };
            try
            {
                int roleInput = EnterRole();

                if (roleInput == 1)
                {
                    Admin adminUser = null;
                    LogInAdmin(users, ref adminUser);
                    adminUser.ChooseActionAdmin(users,subjects);
                    while (true)
                    {
                        bool yesNo = DoYouWantToConitnue();
                        if (!yesNo)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            adminUser.ChooseActionAdmin(users, subjects);
                        }
                    }
                }
                else if (roleInput == 2)
                {
                    Trainer trainerUser = null;
                    LogInTrainer(users, ref trainerUser);
                    trainerUser.ChooseActionTrainer(users, subjects);
                    while (true)
                    {
                        bool yesNo = DoYouWantToConitnue();
                        if (!yesNo)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            trainerUser.ChooseActionTrainer(users, subjects);
                        }
                    }
                }
                else if (roleInput == 3)
                {
                    Student studentUser = null;
                    LogInStudent(users, ref studentUser);
                    studentUser.ChooseActionStudent(subjects);
                    while (true)
                    {
                        bool yesNo = DoYouWantToConitnue();
                        if (!yesNo)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            studentUser.ChooseActionStudent(subjects);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a correct format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
