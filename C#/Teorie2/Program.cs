using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();    // lista vida

            User user1; // referinta spre un viitor obiect
            user1 = new User();
            user1.Id = 1;
            user1.Name = "Nicu";
            user1.Password = "nicu123";
            user1.Email = "nicu@gmail.com";
            user1.Age = 30;

            User user2; // referinta spre un viitor obiect
            user2 = new User(2, "Ana", "anaaa", "ana@yahoo.com", 19);

            User user3 = new User
            {
                Id = 3,
                Name = "Vasile",
                Password = "vasivasi",
                Email = "vasi@hotmail.com",
                Age = 21
            };

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

            for (int i = 0; i < users.Count; i++)
                Console.WriteLine(users[i]);

            Console.ReadKey();
        }
    }
}
