using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. uzd.

            Console.WriteLine("=== Pirmais uzdevums ===");

            Console.Write("Ievadiet tainstura garumu: ");
            int garums = int.Parse(Console.ReadLine());
            int a = 1;
            


            while (a<=garums)
            {
                string zvaigzne = new string('*', a);
                Console.WriteLine(zvaigzne);
                a++;
            }

            // 2. uzd.

            Console.WriteLine("=== Otrais uzdevums ===");

            string parole = "Reinis";

            while(true)
            {
                Console.Write("Ievadiet paroli: ");
                string guess = Console.ReadLine();
                if (guess == parole)
                {
                    Console.WriteLine("Parole ir ievadīta pareizi!");
                    break;
                }
                else
                {
                    Console.WriteLine("Parole ir ievadīta neparizi!");
                }
            }

            // 3. uxd.

            Console.WriteLine("=== Trešais uzdevums ===");

            
            Console.Write("Ievadiet skaitli R: ");
            int R = int.Parse(Console.ReadLine());
            Console.Write("Ievadiet pirmo skaitli: ");
            int pirmais_sk = int.Parse(Console.ReadLine());
            int i = 0;

            while (i<=R)
            {
                if (i==R)
                {
                    Console.WriteLine($"Reiz[{i}] = {pirmais_sk}");
                    break;
                }

                Console.Write($"Reiz[{i}] = {pirmais_sk}*");
                int otrais_sk = int.Parse(Console.ReadLine());
                pirmais_sk = pirmais_sk * otrais_sk;
                i++;
            }
        }
    }
}
