using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string str = Console.ReadLine();
            int n = int.Parse(str);
            Dictionary<int, char> keyValuePairs = new Dictionary<int, char>();

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                keyValuePairs.Add(i + 1, chars[rand.Next(chars.Length)]);
            }

            foreach (var kv in keyValuePairs)
                Console.WriteLine($"{kv.Key}. {kv.Value}");

            Console.ReadKey();
        }
    }
}
