using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static double GetAverage(List<Student> lista)
        {
            double sum = 0;
            foreach (Student student in lista)
            {
                sum += student.AverageGrade;
            }
            return sum/lista.Count;
        }
        static void Main(string[] args)
        {
            Student student1 = new Student("Kristijan", "Spirov", Gender.Male, 9.5);

            Student student2 = new Student("Bojan", "Ilev", Gender.Male, 6.2);

            Student student3 = new Student("Ivana", "Nakeva", Gender.Female, 8.5);

            Student student4 = new Student("Antonio", "Delev", Gender.Male, 2.9);

            Student student5 = new Student("Biljana", "Arsova", Gender.Female, 7.2);

            Student student6 = new Student("Angelina", "Gerovska", Gender.Female, 4.7);

            Student student7 = new Student("Silvija", "Bashovska", Gender.Female, 7.0);

            Student student8 = new Student("Adrijan", "Gigov", Gender.Male, 9.0);

            Student student9 = new Student("Simona", "Aneva", Gender.Female, 10.0);

            Student student10 = new Student("Ilina", "Spirkovska", Gender.Female, 5.6);

            List<Student> class1 = new List<Student>() { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };

            Student student11 = new Student("Gorjan", "Kirov", Gender.Male, 8.0);

            Student student12 = new Student("Vasko", "Pecov", Gender.Male, 7.6);

            Student student13 = new Student("Ivona", "Zdravevska", Gender.Female, 9.0);

            Student student14 = new Student("Lara", "Ivevska", Gender.Female, 5.9);

            Student student15 = new Student("Boris", "Savevski", Gender.Male, 7.0);

            Student student16 = new Student("Slavko", "Topuzov", Gender.Male, 3.5);

            Student student17 = new Student("Tijana", "Ickovska", Gender.Female, 4.6);

            Student student18 = new Student("Gorjan", "Petrevski", Gender.Male, 8.4);

            Student student19 = new Student("Vedran", "Mackov", Gender.Male, 9.8);

            Student student20 = new Student("Mirka", "Andreevska", Gender.Female, 6.0);

            List<Student> class2 = new List<Student>() { student11, student12, student13, student14, student15, student16, student17, student18, student19, student20 };

            try
            {
                Console.WriteLine("Pick a class");
                Console.WriteLine("1. Class 1");
                Console.WriteLine("2. Class 2");
                int input = int.Parse(Console.ReadLine());
                List<Student> currentClass = new List<Student>();

                if (input == 1)
                {
                    currentClass = class1;
                }
                else if(input == 2)
                {
                    currentClass = class2;
                }
                else
                {
                    throw new Exception("Please enter 1 or 2.");
                }

                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Print all female students");
                Console.WriteLine("2. Print all male students");
                Console.WriteLine("3. Print all students with a first letter of a name");
                Console.WriteLine("4. Print all students with a grade higher than input");
                Console.WriteLine("5. Print the average grade of all students in the class");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        List<Student> femaleStudents = currentClass.Where(x => x.Gender == Gender.Female).ToList();
                        Console.WriteLine("Female Students:");
                        foreach (Student female in femaleStudents)
                        {
                            female.PrintInfo();
                        }
                        break;
                    case 2:
                        List<Student> maleStudents = currentClass.Where(x => x.Gender == Gender.Male).ToList();
                        Console.WriteLine("Male Students");
                        foreach (Student male in maleStudents)
                        {
                            male.PrintInfo();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please enter a letter:");
                        char letter = char.Parse(Console.ReadLine());
                        if (System.Char.IsDigit(letter))
                        {
                            throw new Exception("Please enter a letter!");
                        }
                        else
                        {
                            string letter1 = letter.ToString();

                            List<Student> firstLetter = currentClass.Where(x => x.FirstName.StartsWith(letter1)).ToList();
                            if(firstLetter.Count == 0)
                            {
                                Console.WriteLine($"There are no student names starting with {letter}.");
                            }
                            else
                            {
                                Console.WriteLine($"Student names starting with {letter}:");
                                foreach (Student student in firstLetter)
                                {
                                    student.PrintInfo();
                                }
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Please enter number from 0 to 10:");
                        double grade = double.Parse(Console.ReadLine());
                        if(grade < 0 || grade > 10)
                        {
                            throw new Exception("Not a number from 0 to 10.");
                        }
                        else
                        {
                            List<Student> gradeInput = currentClass.Where(x => x.AverageGrade > grade).ToList();
                            Console.WriteLine($"Students with grade higher than {grade}");
                            foreach (Student student in gradeInput)
                            {
                                student.PrintInfo();
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine($"Average Grade of all students:");
                        Console.WriteLine(GetAverage(currentClass));
                        break;
                    default:
                        throw new Exception("Choose a valid action!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a correct format");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
