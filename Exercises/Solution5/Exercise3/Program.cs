using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = { new User("Bob", 1234123412341234, "1234"), new User("Mike", 4321432143214321, "4321"), new User("David", 1357135713571357, "1357") };

            while (true)
            {
                User selectedUser = null;
                Console.WriteLine("Do you want to Log In or Register? \n1) Log In \n2) Register");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input == 1) //LOG IN
                    {
                        bool cardFound = false;
                        Console.WriteLine("Enter Card Number:");
                        string cardInput = string.Join("", Console.ReadLine().Split('-'));
                        bool result = long.TryParse(cardInput, out long cardNumber);

                        if (!result)
                        {
                            Console.WriteLine("Not valid number");
                            continue;
                        }

                        foreach (User user in users)
                        {
                            if (user.CardNumber == cardNumber)
                            {
                                Console.WriteLine("Card found.");
                                cardFound = true;
                                int counter = 0;
                                while (counter < 3)
                                {
                                    Console.WriteLine("Enter PIN:");
                                    string pin = Console.ReadLine();
                                    if (user.GetPin() == pin)
                                    {
                                        Console.WriteLine("Correct PIN.");
                                        selectedUser = user;
                                        Console.WriteLine($"Hello {user.Name}");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Pin incorrect.");
                                        Console.WriteLine($"You have {2 - counter} more chances.");
                                        counter++;
                                        if (counter == 3)
                                        {
                                            Console.WriteLine("Goodbye.");
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        if (!cardFound)
                        {
                            Console.WriteLine("Card not found.");
                            continue;
                        }
                        while (true) // ACTIONS
                        {
                            Console.WriteLine("What do you want to do?: \n1. Check Balance \n2. Cash Withdrawal \n3. Cash Deposit");
                            if (int.TryParse(Console.ReadLine(), out int number))
                            {
                                if (number == 1) // CHECK BALANCE
                                {
                                    Console.WriteLine($"Balance: {selectedUser.GetBalance()}");
                                }
                                else if (number == 2) // CASH WITHDRAWAL
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("How much cash do you want to withdraw?");
                                        if (int.TryParse(Console.ReadLine(), out int cash))
                                        {
                                            if (cash > selectedUser.GetBalance())
                                            {
                                                Console.WriteLine("Not enough money.");
                                                break;
                                            }
                                            else
                                            {
                                                selectedUser.SetBalance(selectedUser.GetBalance() - cash);
                                                Console.WriteLine($"Withdrawed {cash}$ from your balance.");
                                                Console.WriteLine($"Balance: {selectedUser.GetBalance()}");
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Not a valid input.");
                                            continue;
                                        }
                                    }
                                }
                                else if (number == 3) // CASH DEPOSIT
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("How much cash do you want to deposit?");
                                        if (int.TryParse(Console.ReadLine(), out int cashDeposit))
                                        {
                                            selectedUser.SetBalance(selectedUser.GetBalance() + cashDeposit);
                                            Console.WriteLine($"Added {cashDeposit}$ from your balance.");
                                            Console.WriteLine($"Balance: {selectedUser.GetBalance()}");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Not a valid input.");
                                            continue;
                                        }
                                    }
                                }
                            }
                            // NEW ACTION
                            Console.WriteLine("Do you want to do another action? (Y/N)");
                            if (Console.ReadLine().ToLower() == "n")
                            {
                                return;
                            }
                        }
                    }
                    else if (input == 2) //REGISTER
                    {
                        Console.WriteLine("Enter Name");
                        string name1 = Console.ReadLine();

                        Console.WriteLine("Enter Card Number");
                        string cardInput1 = string.Join("", Console.ReadLine().Split('-'));
                        bool result = long.TryParse(cardInput1, out long cardNumber1);

                        Console.WriteLine("Enter Pin");
                        string pin1 = Console.ReadLine();

                        Console.WriteLine("Do you want to deposit money? (Y/N)");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            while (true)
                            {
                                Console.WriteLine("Enter money:");
                                if (int.TryParse(Console.ReadLine(), out int balance1))
                                {
                                    Array.Resize(ref users, users.Length + 1);
                                    users[users.Length - 1] = new User(name1, cardNumber1, pin1, balance1);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Not a valid input.");
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            Array.Resize(ref users, users.Length + 1);
                            users[users.Length - 1] = new User(name1, cardNumber1, pin1);
                        }
                    }
                }
                else // NOT VALID INPUT FOR LOG IN OR REGISTER
                {
                    Console.WriteLine("Not a valid input.");
                    continue;
                }
            }
        }
    }
}