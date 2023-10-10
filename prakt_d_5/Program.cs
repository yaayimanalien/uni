using System;


namespace prakt_d_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.uzd
            Console.WriteLine("=== 1. uzdevums ===\n");

            Console.Write("Ievadiet skaitli: ");

            int skaitlis = int.Parse(Console.ReadLine());

            int rezultats = 1;

            for (int i = 1; i <= skaitlis; i++)
            {
                Console.WriteLine($"{rezultats} * {i} = {rezultats * i}");
                rezultats *= i;
            }

            // 2.uzd
            Console.WriteLine("\n=== 2. uzdevums ===\n");

            Console.Write("Ievadiet noguldījuma summu: ");
            double noguldijuma_summa = double.Parse(Console.ReadLine());

            Console.Write("Ievadiet noguldījuma ilgumu (gadu skaitu): ");
            int noguldijuma_ilgums = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet gada % likmi: ");
            double gada_likme = double.Parse(Console.ReadLine());

            for (int i = 1; i <= noguldijuma_ilgums; i++) {
                double r = noguldijuma_summa * (gada_likme + 1);
                Console.WriteLine($"Summa pēc {i}. gada ir {r}");
                noguldijuma_summa = r;
            }

            // 3.uzd
            Console.WriteLine("\n=== 3. uzdevums ===\n");

            string dashes = new string('-', 82);
            for (int i = 0; i <= 10; i++)
            {
                if (i == 0)
                {
                    Console.Write("y/x\t|");
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write($"{j}\t");
                    }
                    Console.Write($"\n{dashes}\n");
                }

                else
                {
                    Console.Write($"{i}\t|");
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write($"{j * i} \t");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}