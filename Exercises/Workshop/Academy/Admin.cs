using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    public class Admin : User
    {
        public Role Role { get; set; }

        public Admin() { }

        public Admin(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password)
        {
            Role = Role.Admin;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role}");
        }
    }
}
