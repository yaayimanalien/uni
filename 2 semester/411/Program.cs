using System;

namespace _411
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ievadiet masiva garumu: ");
            
            PrintArray(InitArray(int.Parse(Console.ReadLine())));
        }

        public static string[] InitArray(int length)
        {
            string[] arr = new string[length];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = GetRandomString(random.Next(2, 10), random);
            }

            return arr;
        }

        public static string GetRandomString(int x, Random rand)
        {
            string randstring = "";

            for (int i = 0; i < x; i++)
            {
                randstring += (char)rand.Next(33, 125);
            }
    
            return randstring;
        }


        static void PrintArray(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}