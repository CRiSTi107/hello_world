using System;
using System.Collections.Generic;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User(10, "CRiSTi107", "toor");
            User user3 = new User(12, "Dobri01", "negro69");

            List<User> users = new List<User>();

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

            foreach(User user in users)
            {
                System.Console.WriteLine(user.ToString());
            }

        }
    }
}
