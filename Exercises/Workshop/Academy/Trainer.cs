using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    public class Trainer : User
    {
        public Role Role { get; set; }

        public Trainer(string firstName,string lastName,string username,string password) : base(firstName,lastName,username,password)
        {
            Role = Role.Trainer;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role}");
        }
    }
}
