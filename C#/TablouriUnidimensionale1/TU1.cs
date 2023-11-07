using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablouriUnidimensionale1
{
    internal class TU1
    {
        static void Main(string[] args)
        {
            string[] a = null;  // declaram o referinta spre uin viitor tablou
            a = new string[]
            {
                "Nicu",
                "Ana",
                "Sergiu",
                "Eren"
            };

            // Parcurgeri
            for (int i = 0; i < a.Length; i++)
            {
                //Console.Write(a[i] + " ");
                //Console.Write($"{a[i]} ");
                Console.Write("{0} ", a[i]);
            }

            Console.WriteLine();

            foreach (string s in a)
                Console.Write(s + " ");

            Console.ReadKey();
        }
    }
}
