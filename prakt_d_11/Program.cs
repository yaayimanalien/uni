using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1. uzd
            Console.WriteLine("=== 1. uzdevums ===");

            string[] masivs1 = new string[10];

            for (int i = 0; i < masivs1.Length; i++)
            {
                Console.Write($"Ieavdiet {i + 1} masīva vērtību: ");
                masivs1[i] = Console.ReadLine();
            }

            for (int i = 0; i < masivs1.Length; i++)
            {
                Console.WriteLine($"Masīva {i} vērtība ir: {masivs1[i]}");
            }

            Console.Write("Apvienotais masīvs: ");
            for (int i = 0; i < masivs1.Length; i++)
            {
                Console.Write(masivs1[i]);
            }

            // 2. uzd
            Console.WriteLine("\n=== 2. uzdevums ===");

            Console.Write("Ievadiet pirmā masīva izmēru: ");
            int lenght1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet otrā masīva izmēru: ");
            int lenght2 = int.Parse(Console.ReadLine());

            string[] masivs21 = new string[lenght1];
            string[] masivs22 = new string[lenght2];

            for (int i = 0; i < masivs21.Length; i++)
            {
                Console.Write($"Ieavdiet 1. masīva {i + 1} vērtību: ");
                masivs21[i] = Console.ReadLine();
            }

            for (int i = 0; i < masivs22.Length; i++)
            {
                Console.Write($"Ieavdiet 2. masīva {i + 1} vērtību: ");
                masivs22[i] = Console.ReadLine();
            }

            for (int i = 0; i < masivs21.Length; i++)
            {
                Console.WriteLine($"1. masīva {i} vērtība ir: {masivs21[i]}");
            }

            for (int i = 0; i < masivs22.Length; i++)
            {
                Console.WriteLine($"2. masīva {i} vērtība ir: {masivs22[i]}");
            }


            Console.Write("1. un 2. masīva apvienotā simbolu virkne: ");

            int min = Math.Min(lenght1, lenght2);

            for (int i = 0; i < min; i++)
            {
                Console.Write(masivs21[i]);
                Console.Write(masivs22[i]);
            }

            for (int i = min; i < lenght1; i++)
            {
                Console.Write(masivs21[i]);
            }

            for (int i = min; i < lenght2; i++)
            {
                Console.Write(masivs22[i]);
            }

            //// 3. uzd
            Console.WriteLine("\n=== 3. uzdevums ===");

            Console.Write("Ievadiet pirmā masīva izmēru: ");
            int lenght31 = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet otrā masīva izmēru: ");
            int lenght32 = int.Parse(Console.ReadLine());

            string[] masivs31 = new string[lenght31];
            string[] masivs32 = new string[lenght32];

            for (int i = 0; i < masivs31.Length; i++)
            {
                Console.Write($"Ievadiet 1. masīva {i + 1} vērtību: ");
                masivs31[i] = Console.ReadLine();
            }

            for (int i = 0; i < masivs32.Length; i++)
            {
                Console.Write($"Ievadiet 2. masīva {i + 1} vērtību: ");
                masivs32[i] = Console.ReadLine();
            }

            string string31 = string.Empty;
            string string32 = string.Empty;

            for (int i = 0; i < masivs31.Length; i++)
            {
                Console.WriteLine($"1. masīva {i} vērtība ir: {masivs31[i]}");
                string31 += masivs31[i];
            }

            for (int i = 0; i < masivs32.Length; i++)
            {
                Console.WriteLine($"2. masīva {i} vērtība ir: {masivs32[i]}");
                string32 += masivs32[i];
            }



            int rem = 0;
            string apvienojums = "";

            for (int i = 0; i < string31.Length / 2; i++)
            {
                apvienojums += string31[i];
                rem++;
            }

            apvienojums += string32;

            for (int i = rem; i < string31.Length; i++)
            {
                apvienojums += string31[i];
            }
            Console.WriteLine($"Rindu apvienojums: {apvienojums}");

            // 4. uzd
            Console.WriteLine("=== 4. uzdevums ===");

            Random random = new Random();

            Console.Write("Ievadiet pirmā masīva izmēru: ");
            int lenght41 = int.Parse(Console.ReadLine());
            Console.Write("Ievadiet otrā masīva izmēru: ");
            int lenght42 = int.Parse(Console.ReadLine());

            string[] masivs41 = new string[lenght41];
            string[] masivs42 = new string[lenght42];

            for (int i = 0; i < masivs41.Length; i++)
            {
                masivs41[i] = Convert.ToString(random.Next(10, 100));
            }

            for (int i = 0; i < masivs42.Length; i++)
            {
                masivs42[i] = Convert.ToString(random.Next(10, 100));
            }

            int min4 = Math.Min(lenght41, lenght42);

            Console.Write("pirmais\totrais\n");

            for (int i = 0; i < min4; i++)
            {
                if(masivs41.Length < masivs42.Length)
                {
                    Console.Write($"{masivs41[i]}\t{masivs42[i]}");
                }
                else
                {
                    Console.Write($"{masivs42[i]}\t{masivs41[i]}");
                }
                Console.Write("\n");
            }

            if (masivs41.Length < masivs42.Length)
            {
                for (int i = min4; i < masivs42.Length; i++)
                {
                    Console.Write($"\t{masivs42[i]}\n");
                }
            }
            else
            {
                for (int i = min4; i < masivs41.Length; i++)
                {
                    Console.Write($"\t{masivs41[i]}\n");
                }
            }

            //int minskaitlis = 0;
            //int maxskaitlis = 0;

            //for (int i = 0;i < masivs41.Length; i++)
            //{

            //}

            //Console.Write("Mazākais skaitlis ir ");

            Console.WriteLine($"mas 1 [0] = {int.Parse(masivs41[0])}");
            Console.WriteLine($"mas 2 [0] = {int.Parse(masivs42[0])}");

            int min1 = 100;
            int max1 = 10;
            int min2 = 100;
            int max2 = 10;

            for (int i = 0; i < masivs41.Length; i++)
            {
                int current = int.Parse(masivs41[i]);

                if (current <= min1)
                {
                    min1 = current;
                }

                if (current >= max1)
                {
                    max1 = current;
                }
            }

            for (int i = 0; i < masivs42.Length; i++)
            {
                int current = int.Parse(masivs42[i]);

                if (current <= min2)
                {
                    min2 = current;
                }

                if (current >= max2)
                {
                    max2 = current;
                }
            }

            Console.WriteLine($"\n1. mas max = {max1}");
            Console.WriteLine($"1. mas min = {min1}");
            Console.WriteLine($"2. mas max = {max2}");
            Console.WriteLine($"2. mas min = {min2}");
        }
    }
}
