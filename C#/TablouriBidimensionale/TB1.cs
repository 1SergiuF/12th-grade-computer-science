using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablouriBidimensionale
{
    internal class TB1
    {
        static void Main(string[] args)
        {
            int[,] a = null;     // declar o referinta spre un tablou bidimensional

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            // cream matricea
            a = new int[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = i + 1;

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                    Console.Write($"{a[i, j] }");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
