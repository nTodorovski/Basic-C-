using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }

        public Driver()
        {

        }

        public Driver(string name,int skill)
        {
            Name = name;
            Skill = skill;
        }
    }
    
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model,int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed(Driver Driver)
        {
            int speed = Driver.Skill * Speed;
            return speed;
        }
    }

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
                    if (firstCarInput && (firstCar == 1 || firstCar == 2 || firstCar == 3 || firstCar == 4))
                    {
                        if(firstCar == 1)
                        {
                            selectedFirstCar = porsche;
                        }else if(firstCar == 2)
                        {
                            selectedFirstCar = ferrari;
                        }else if(firstCar == 3)
                        {
                            selectedFirstCar = hyundai;
                        }
                        else
                        {
                            selectedFirstCar = mazda;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input for car no.1!");
                    }
                }

                // FIRST DRIVER
                while (true)
                {
                    Console.WriteLine("1) Bob\n2) Greg\n3) Jill\n4) Anne");
                    Console.Write("Choose Driver 1: ");
                    firstDriverInput = int.TryParse(Console.ReadLine(), out firstDriver);
                    if (firstDriverInput && (firstDriver == 1 || firstDriver == 2 || firstDriver == 3 || firstDriver == 4))
                    {
                        if (firstDriver == 1)
                        {
                            selectedFirstDriver = bob;
                        }
                        else if (firstDriver == 2)
                        {
                            selectedFirstDriver = greg;
                        }
                        else if (firstDriver == 3)
                        {
                            selectedFirstDriver = jill;
                        }
                        else
                        {
                            selectedFirstDriver = anne;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input for driver 1.");
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
                    if (secondCarInput && (secondCar == 1 || secondCar == 2 || secondCar == 3 || secondCar == 4))
                    {
                        if (secondCar == 1)
                        {
                            selectedSecondCar = porsche;
                        }
                        else if (secondCar == 2)
                        {
                            selectedSecondCar = ferrari;
                        }
                        else if (secondCar == 3)
                        {
                            selectedSecondCar = hyundai;
                        }
                        else
                        {
                            selectedSecondCar = mazda;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input for car no.2!");
                    }
                }

                // SECOND DRIVER
                while (true)
                {
                    Console.WriteLine("1) Bob\n2) Greg\n3) Jill\n4) Anne");
                    Console.Write("Choose Driver 2: ");
                    secondDriverInput = int.TryParse(Console.ReadLine(), out secondDriver);
                    if (secondDriverInput && (secondDriver == 1 || secondDriver == 2 || secondDriver == 3 || secondDriver == 4))
                    {
                        if (secondDriver == 1)
                        {
                            selectedSecondDriver = bob;
                        }
                        else if (secondDriver == 2)
                        {
                            selectedSecondDriver = greg;
                        }
                        else if (secondDriver == 3)
                        {
                            selectedSecondDriver = jill;
                        }
                        else
                        {
                            selectedSecondDriver = anne;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input for driver 2.");
                    }
                }

                // CALCULATE SPEED
                selectedFirstCar.Driver = selectedFirstDriver;
                selectedSecondCar.Driver = selectedSecondDriver;

                Console.WriteLine(RaceCars(selectedFirstCar, selectedSecondCar));

                Console.WriteLine("Do you want to Race Again? (Y/N)");
                if (Console.ReadLine() == "N")
                {
                    break;
                }
            }
        }
    }
}
