using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. uzd
            Console.WriteLine("=== 1. uzdevums ===");

            Console.Write("Ievadiet rindu skaitu: ");
            int skaits = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet kolonnu skaitu: ");
            int kolonnas = int.Parse(Console.ReadLine());

            int[,] arr1 = new int[skaits, kolonnas];

            Random random = new Random();

            double evenCount = 0;
            double totalCount = skaits * kolonnas;

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    int r = random.Next(1, 100);
                    arr1[i, j] = r;
                    Console.Write($"{arr1[i, j]}\t");
                    if (r%2==0)
                    {
                        evenCount++;
                    }
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            Console.WriteLine(evenCount);
            Console.WriteLine(totalCount);

            double percentage = evenCount / totalCount * 100;

            Console.WriteLine($"{Math.Round(percentage)}% no masīva elementiem ir pāra skaitļi!");

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i,j] % 2 == 0)
                    {
                        arr1[i, j]++;
                    }
                    Console.Write($"{arr1[i, j]}\t");
                }
                Console.Write("\n");
            }



            // 2. uzd
            Console.WriteLine("=== 2. uzdevums ===");

            Console.Write("Ievadiet rindu skaitu: ");
            skaits = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet kolonnu skaitu: ");
            kolonnas = int.Parse(Console.ReadLine());

            int[,] arr2 = new int[skaits, kolonnas];

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    int r = random.Next(1, 100);
                    arr2[i, j] = r;
                    Console.Write($"{arr2[i, j]}\t");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nKatrs otrais elements = 0\n");

            bool isSecond = false;

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (isSecond == true)
                    {
                        arr2[i, j] = 0;
                        isSecond = false;
                    }
                    else
                    {
                        isSecond = true;
                    }
                    Console.Write($"{arr2[i, j]}\t");
                }
                Console.Write("\n");
            }

        }
    }
}
