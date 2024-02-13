using System;

namespace _3._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ievadi masīva rindu skaitu: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Ievadi masīva kolonnu skaitu: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr1 = new int[m, n];

            InitMas(arr1);
            PrintMas(arr1);
            Console.WriteLine($"Masīva min vērtība: {MinMas(arr1)}");
            Console.WriteLine($"Masīva max vērtība: {MaxMas(arr1)}");
            
            Console.Write("Ievadiet skaitli kuru meklēt: ");
            Console.WriteLine($"Skaitlis masīvā atkārtojas {Meklet(arr1, int.Parse(Console.ReadLine()))} reizes");
        }
        
        private static void InitMas(int[,] input)
        {
            Random random = new Random();
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    input[i, j] = random.Next(1, 9);
                }
            }
            //return input;
        }

        private static void PrintMas(int[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($"{input[i,j]} ");
                }
                Console.Write("\n");
            }
        }

        private static int MinMas(int[,] input)
        {
            int min = 10;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (min>input[i,j])
                    {
                        min = input[i, j];
                    }
                }
            }

            return min;
        }

        private static int MaxMas(int[,] input)
        {
            int max = 1;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (max < input[i,j])
                    {
                        max = input[i, j];
                    }
                }
            }

            return max;
        }

        private static int Meklet(int[,] input, int query)
        {
            int count = 0;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if(input[i,j]==query)
                    {
                        count++;
                    }
                }
            }
            
            return count;
        }
    }
}