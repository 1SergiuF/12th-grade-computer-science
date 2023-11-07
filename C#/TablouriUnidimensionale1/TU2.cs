using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablouriUnidimensionale1
{
    internal class TU2
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };  // ok

            int n = int.Parse(Console.ReadLine());
            a = new int[n];   // alocare run-time
            for (int i = 0; i < a.Length; i++)
                a[i] = i + 1;

            Console.WriteLine();

            foreach (int x in a)
                Console.Write(x + " ");

            Console.ReadKey();
        }
    }
}
