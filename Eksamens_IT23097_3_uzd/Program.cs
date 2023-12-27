using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_IT23097_3_uzd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10, 10];
            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        arr[i, j] = rand.Next(1, 9);
                    }
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.Write("\n");
            }
            Console.Write("\n");


            for (int i = 8; i >= 0; i--)
            {
                for (int j = 9; j >= 1; j--)
                {
                    if (i != j)
                    {
                        arr[i, j] = arr[i + 1, j] + arr[i + 1, j - 1];
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.Write("\n");
            }
        }
    }
}

    //arr[i, j] = arr[i + 1, j] + arr[i + 1, j - 1];