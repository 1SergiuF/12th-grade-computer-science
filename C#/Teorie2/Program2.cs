using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teorie2
{
    internal class Program2
    {
        private static StreamReader sr = null;
        private static StreamWriter sw = null;
        private static List<User> users = new List<User>();

        public static void ReadUsers()
        {
            string[] s = null;
            string line = string.Empty;

            try
            {
                sr = new StreamReader("users.txt");
                char[] sep = { ' ', ',' };
                while ((line = sr.ReadLine()) != null)
                {
                    s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    int id = int.Parse(s[0]);
                    string name = s[1];
                    string password = s[2];
                    string email = s[3];
                    int age = int.Parse(s[4]);

                    users.Add(new User(id, name, password, email, age));
                }

                sr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void WriteAllUsers()
        {
            try
            {
                sw = new StreamWriter("users.out");

                // Varianta 1
                //for (int i = 0; i < users.Count; ++i)
                //    sw.WriteLine(users[i]);

                // Varianta 2
                //foreach (var user in users)
                //    sw.WriteLine(user);

                // Varianta 3
                users.ForEach(user => { sw.WriteLine(user); });
                sw.Close();
            }
            catch(Exception ex) { Console.WriteLine("exceptie !"); }
        }

        static void Main(string[] args)
        {
            ReadUsers();
            WriteAllUsers();
        }
    }
}
