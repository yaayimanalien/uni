using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace prakt_d_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. uzd
            Console.WriteLine("=== 1. uzdevums ===");
            //Nodefinēt int tipa divdimensijas masīvu ar 10 rindām un 10 kolonnām.Aizpildīt to ar
            //gadījuma skaitļiem.Izvadīt inicializēto masīvu uz ekrāna.Atrast masīva katras rindas summu
            //un visa masīva summu un izvadīt tās uz ekrāna.

            int[,] masivs11 = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < masivs11.GetLength(0); i++)
            {
                for (int j = 0; j < masivs11.GetLength(1); j++)
                {
                    masivs11[i, j] = random.Next(1, 100);
                    Console.Write($"{masivs11[i, j]}\t");
                }
                Console.Write("\n");
            }

            Console.WriteLine();

            int sumTotal = 0;

            for (int i = 0; i < masivs11.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < masivs11.GetLength(1); j++)
                {
                    sum += masivs11[i, j];
                }
                Console.WriteLine($"{i+1} rindas skaitļu summa ir {sum}");
                sumTotal += sum;
            }
            Console.WriteLine($"Masīva skaitļu summa ir {sumTotal}");

            // 2. uzd
            Console.WriteLine("\n=== 2. uzdevums ===");
            //Nodefinēt int tipa divdimensijas masīvu ar 10 rindām un 10 kolonnām.Aizpildīt to ar
            //gadījuma skaitļiem.Izvadīt inicializēto masīvu uz ekrāna.Atrast katra masīva katras rindas
            //max un min vērtību, kā arī visa masīva max un min vērtības un izvadīt tās uz ekrāna.

            int[,] masivs21 = new int[10, 10];

            for (int i = 0; i < masivs21.GetLength(0); i++)
            {
                for (int j = 0; j < masivs21.GetLength(1); j++)
                {
                    masivs21[i, j] = random.Next(1, 100);
                    Console.Write($"{masivs21[i, j]}\t");
                }
                Console.Write("\n");
            }

            Console.WriteLine();

            int[,] minmax = new int[2, 10];


            for (int i = 0; i < masivs21.GetLength(0); i++)
            {
                for (int j = 0; j < masivs21.GetLength(1); j++)
                {
                    // min - max comparison
                    int current = masivs21[i,j];
                    int min = minmax[0, i];
                    int max = minmax[1, i];

                    if (current <= min)
                    {
                        min = current;
                    }

                    if (current >= max)
                    {
                        max = current;
                    }
                }
            }

            for (int i = 0; i < minmax.GetLength(0); i++)
            {
                for (int j = 0; j < minmax.GetLength(1); j++)
                {
                    Console.Write($"{minmax[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}

