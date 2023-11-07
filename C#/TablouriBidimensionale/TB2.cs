using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablouriBidimensionale
{
    internal class TB2
    {
        static void Main(string[] args)
        {
            // Tablouri Neregulate (Jagged Arrays)
            int[][] a = null;

            int n = int.Parse(Console.ReadLine());

            // aloc n referinte spre linii de int
            // liniile inca nu exista

            a = new int[n][];

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                a[i] = new int[m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i][j] = i + j;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{a[i][j]} ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
