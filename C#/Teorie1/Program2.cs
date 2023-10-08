using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int a = int.Parse(s1);
            int b = int.Parse(s2);

            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.ReadKey();
        }
    }
}
