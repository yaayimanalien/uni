using System;

namespace _4._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ievadiet rindu skaitu: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ievadiet min vērtību: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Ievadiet max vērtību: ");
            int max = int.Parse(Console.ReadLine());
            int[][] array = InitArray(x, min, max);
            PrintArrayForeach(array);
            PrintArrayFor(array);
            
        }

        static int[][] InitArray(int x, int min, int max)
        {
            Random random = new Random();
    
            int[][] arr = new int[x][];

            for (int i = 0; i < arr.Length; i++)
            {
                int length = random.Next(4, 10); 
                arr[i] = new int[length]; 
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(min, max);
                }
            }
    
            return arr;
        }

        
        static string LineInfo(int[] line)
        {
            int count = 0;
            double sum = 0;
            double avg = 0;

            for (int i = 0; i < line.Length; i++)
            {
                sum += line[i];
                count++;
                avg = Math.Round((sum / count), 2);
            }
            
            string info = $"Value count: {count}; Line sum: {sum}; Line average: {avg}";
            
            return info;
        }

        static void PrintArrayFor(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]}\t");
                }
                Console.Write($"{LineInfo(arr[i])}\n");
            }

            Console.WriteLine();
        }

        static void PrintArrayForeach(int[][] arr)
        {
            foreach (int[] row in arr)
            {
                foreach (int column in row)
                {
                    Console.Write($"{column}\t");
                }
                Console.Write($"{LineInfo(row)}\n");
            }
        }
    }
}