using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class User
    {
        public string Name { get; set; }
        public long CardNumber { get; set; }
        private string Pin { get; set; }
        private int Balance { get; set; }

        public User(string name, long cardNumber, string pin, int balance = 0)
        {
            Name = name;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }

        public string GetPin()
        {
            return Pin;
        }

        public int GetBalance()
        {
            return Balance;
        }

        public void SetBalance(int number)
        {
            Balance = number;
        }
    }
}
