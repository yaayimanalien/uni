using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masiivs = new int[10];
            for (int i = 0; i < masiivs.Length; i++)
            {
                Console.Write($"Ievadiet {i+1} masīva elementa vērtību: ");
                masiivs[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < masiivs.Length; i++)
            {
                Console.WriteLine($"mas[{i+1}] = {masiivs[i]}");
            }

            Console.WriteLine();

            int kopsumma = 1;

            for (int i = 0; i < masiivs.Length; i++)
            {
                kopsumma *= masiivs[i];
                Console.WriteLine($"reiz_{i} = {kopsumma}");
            }

            Console.WriteLine($"VIsa masīva kopējais reizinājums ir {kopsumma}");
        }
    }
}
