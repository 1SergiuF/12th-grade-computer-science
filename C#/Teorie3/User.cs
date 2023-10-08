using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie3
{
    class User
    {
        public User()
        {
            Id = 0;
            Name = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
            Age = 0;
        }

        public User(int id, string name, string password, string email, int age)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            Age = age;
        }

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; }
        public int Age { get; set; } = 0;


        public override string ToString()
        {
            return $"{Name} {Password} {Email} {Age}";
        }

    }
}
