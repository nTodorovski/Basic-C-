using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; } = { "Msg1", "Msg2", "Msg3" };

        public User(string username,string password)
        {
            Username = username;
            Password = password;
        }
    }
}
