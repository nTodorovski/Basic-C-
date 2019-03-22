using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
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

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
