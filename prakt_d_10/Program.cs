using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. uzd
            Console.WriteLine("=== 1. uzdevums ===");

            int[] masiivs = new int[10];
            for (int i = 0; i < masiivs.Length; i++)
            {
                Console.Write($"Ievadiet {i + 1} masīva elementa vērtību: ");
                masiivs[i] = int.Parse(Console.ReadLine());
            }

            // Array.Reverse(masiivs, 0, 9);

            Console.WriteLine();

            for (int i = 0; i < masiivs.Length; i++)
            {
                Console.WriteLine($"mas[{i + 1}] = {masiivs[i]}");
            }

            Console.WriteLine();

            int kopsumma = 1;

            for (int i = 0; i < masiivs.Length; i++)
            {
                kopsumma *= masiivs[i];
                Console.WriteLine($"reiz_{i} = {kopsumma}");
            }

            Console.WriteLine($"Visa masīva kopējais reizinājums ir {kopsumma}");



            // 2. uzd
            Console.WriteLine("=== 2. uzdevums ===");

            char[] masivs2 = new char[20];

            Random random = new Random();

            for (int i = 0; i < masivs2.Length; i++)
            {
                masivs2[i] = (char)(random.Next(32, 126));
                Console.WriteLine($"mas[{i+1}] = {masivs2[i]}");
            }

            Console.Write("\nIevadiet simbolu: ");
            char simbols = char.Parse(Console.ReadLine());

            int i_simbols = 0;
            int simbols_count = 0;

            for (int i = 0; i < masivs2.Length; i++) {
                if (masivs2[i] == simbols)
                {
                    i_simbols = i;
                    simbols_count++;
                }
            }

            Console.WriteLine($"\nSimbols {simbols} atrodas masīvā {simbols_count} reizes\n");

            for(int i = 0;i < masivs2.Length;i++)
            {
                if (masivs2[i] != simbols)
                {
                    Console.WriteLine($"mas[{i + 1}] = {masivs2[i]}");
                }
            }

            // 3. uzd
            Console.WriteLine("\n=== 3. uzdevums ===\n");

            int[] masivs3 = new int[10];

            for(int i = 0; i < masivs3.Length; i++)
            {
                masivs3[i] = random.Next(1,20);
                Console.WriteLine($"mas[{i+1}] = {masivs3[i]}");
            }

            int min = 20;
            int max = 1;

            for (int i = 0; i < masivs3.Length; i++)
            {
                if (masivs3[i] > max)
                {
                    max = masivs3[i];
                }
            }

            for (int i = 0; i < masivs3.Length; i++)
            {
                if (masivs3[i] < min)
                {
                    min = masivs3[i];
                }
            }

            Console.WriteLine($"\nMax vērtība = {max}");
            Console.WriteLine($"Min vērtība = {min}");

            // 4. uzd

            Console.WriteLine("\n=== 4. uzdevums ===");

            int[] masivs4 = new int[10];

            for(int i = 0; i < masivs4.Length; i++)
            {
                masivs4[i] = random.Next(1, 20);
                Console.WriteLine($"mas[{i + 1}] = {masivs4[i]}");
            }
            
            Console.WriteLine();

            Array.Reverse(masivs4, 0, 10);

            for (int i = 0; i < masivs4.Length; i++)
            {
                Console.WriteLine($"mas[{i + 1}] = {masivs4[i]}");
            }
        }
    }
}
