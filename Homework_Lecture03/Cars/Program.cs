using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static string RaceCars(Car one, Car two)
        {
            if (one.CalculateSpeed(one.Driver) > two.CalculateSpeed(two.Driver))
            {
                return $"Car No.1 was faster. Model: {one.Model}, Speed: {one.CalculateSpeed(one.Driver)}, Driver: {one.Driver.Name}";
            }
            else
            {
                return $"Car No.2 was faster. Model: {two.Model}, Speed: {two.CalculateSpeed(two.Driver)}, Driver: {two.Driver.Name}";
            }
        }

        static void Main(string[] args)
        {
            Driver bob = new Driver("Bob", 6);
            Driver greg = new Driver("Greg", 3);
            Driver jill = new Driver("Jill", 4);
            Driver anne = new Driver("Anne", 5);


            Car porsche = new Car("Porsche", 220);
            Car ferrari = new Car("Ferrari", 190);
            Car hyundai = new Car("Hyundai", 170);
            Car mazda = new Car("Mazda", 160);

            while (true)
            {
                Console.Clear();
                Car selectedFirstCar;
                Driver selectedFirstDriver;

                Car selectedSecondCar;
                Driver selectedSecondDriver;

                bool firstCarInput = false;
                bool firstDriverInput = false;
                bool secondCarInput = false;
                bool secondDriverInput = false;
                int firstCar = 0;
                int firstDriver = 0;
                int secondCar = 0;
                int secondDriver = 0;


                // FIRST CAR
                while (true)
                {
                    Console.WriteLine("1) Porsche\n2) Ferrari\n3) Hyundai\n4) Mazda");
                    Console.Write("Choose a car no.1: ");
                    firstCarInput = int.TryParse(Console.ReadLine(), out firstCar);
                    if (firstCarInput)
                    {
                        switch (firstCar)
                        {
                            case 1:
                                selectedFirstCar = porsche;
                                break;
                            case 2:
                                selectedFirstCar = ferrari;
                                break;
                            case 3:
                                selectedFirstCar = hyundai;
                                break;
                            case 4:
                                selectedFirstCar = mazda;
                                break;
                            default:
                                Console.WriteLine("Please enter number from 1 to 4.");
                                continue;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input.");
                    }
                }

                // FIRST DRIVER
                while (true)
                {
                    Console.WriteLine("1) Bob\n2) Greg\n3) Jill\n4) Anne");
                    Console.Write("Choose Driver 1: ");
                    firstDriverInput = int.TryParse(Console.ReadLine(), out firstDriver);

                    if (firstDriverInput)
                    {
                        switch (firstDriver)
                        {
                            case 1:
                                selectedFirstDriver = bob;
                                break;
                            case 2:
                                selectedFirstDriver = greg;
                                break;
                            case 3:
                                selectedFirstDriver = jill;
                                break;
                            case 4:
                                selectedFirstDriver = anne;
                                break;
                            default:
                                Console.WriteLine("Please enter number from 1 to 4.");
                                continue;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input.");
                    }
                }

                // IF CAR AND DRIVER ARE 1
                if (firstCar == 1 && firstDriver == 1)
                {
                    Console.WriteLine($"Model: {porsche.Model} \nSpeed: {porsche.CalculateSpeed(bob)} ");
                    Console.WriteLine("Do you want to Race Again? (Y/N)");
                    string yesNo = Console.ReadLine();
                    if (yesNo == "N")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                // SECOND CAR
                while (true)
                {
                    Console.WriteLine("1) Porsche\n2) Ferrari\n3) Hyundai\n4) Mazda");
                    Console.Write("Choose a car no.2: ");
                    secondCarInput = int.TryParse(Console.ReadLine(), out secondCar);
                    if (secondCarInput)
                    {
                        switch (secondCar)
                        {
                            case 1:
                                selectedSecondCar = porsche;
                                break;
                            case 2:
                                selectedSecondCar = ferrari;
                                break;
                            case 3:
                                selectedSecondCar = hyundai;
                                break;
                            case 4:
                                selectedSecondCar = mazda;
                                break;
                            default:
                                Console.WriteLine("Please enter number from 1 to 4.");
                                continue;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input.");
                    }
                }

                // SECOND DRIVER
                while (true)
                {
                    Console.WriteLine("1) Bob\n2) Greg\n3) Jill\n4) Anne");
                    Console.Write("Choose Driver 2: ");
                    secondDriverInput = int.TryParse(Console.ReadLine(), out secondDriver);
                    if (secondDriverInput)
                    {
                        switch (secondDriver)
                        {
                            case 1:
                                selectedSecondDriver = bob;
                                break;
                            case 2:
                                selectedSecondDriver = greg;
                                break;
                            case 3:
                                selectedSecondDriver = jill;
                                break;
                            case 4:
                                selectedSecondDriver = anne;
                                break;
                            default:
                                Console.WriteLine("Please enter number from 1 to 4.");
                                continue;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input.");
                    }
                }

                // CALCULATE SPEED
                selectedFirstCar.Driver = selectedFirstDriver;
                selectedSecondCar.Driver = selectedSecondDriver;

                Console.WriteLine(RaceCars(selectedFirstCar, selectedSecondCar));

                Console.WriteLine("Do you want to Race Again? (Y/N)");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}
