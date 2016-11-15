using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClassLibrary
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var db = new UserContext())
            {
                Console.Write("Enter a name for a user: ");
                var name = Console.ReadLine();

                var user = new User {UserName = name};
                db.Users.Add(user);
                db.SaveChanges();


                // Selecting query
                var query = from b in db.Users
                    orderby b.UserName
                    select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.UserName);
                }
            }
        }
    }
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual List<Message>  Messages{get; set; }
    }

    public class Message
    {
        public int MessageID { get; set; }
        public string BodyContent { get; set; }

        public string UserName { get; set; }

        // Relationship
        // Virtual Enable lazy querying from enetity framework
        public virtual  User User { get; set; }
    }

    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }

}
