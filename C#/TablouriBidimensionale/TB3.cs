using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TablouriBidimensionale
{
    internal class TB3
    {
        static void Main(string[] args)
        {
            // Tablouri Neregulate (Jagged Arrays)
            // Matrice triunghiulara
            int[][] a = null;
            int n = int.Parse(Console.ReadLine());

            // aloc n referinte spre linii de int
            // liniile inca nu exista
            a = new int[n][];

            for (int i = 0; i < n; i++)
                a[i] = new int[i + 1];

            for (int i = 0; i < n; i++)
                for (int j = 0; j <= i; j++)
                    a[i][j] = i + j;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write($"{a[i][j]} ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
