using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIAChatMessengerLike
{

public class User
{
    // Properties get and set
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    // Constructor
    public User(string name, string password, string email)
    {
        Name = name;
        Password = password;
        Email = email;
    }
   
}

}