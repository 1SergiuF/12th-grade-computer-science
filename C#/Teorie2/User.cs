using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie2
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public User()
        {
            Id = 0;
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Age = 0;
        }

        public User(int id, string name, string email, string password, int age)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Id}. {Name} {Password} {Email} {Age}";
        }
    }
}
