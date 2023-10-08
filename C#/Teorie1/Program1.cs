using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.ReadKey();
        }
    }
}
