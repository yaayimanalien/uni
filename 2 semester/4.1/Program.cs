using System;

namespace _4._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.write("Ievadiet masiva garumu: ");
            int arrLen = int.Parse(Console.ReadLine());

        }
        
        public static int[] InitArray (int arrLen)
        {
            string[] arr = new string[arrLen];
            Random rand = new Random();

            foreach (string i in arr)
            {
                char[i] = GetRandomString(rand.Next(2, 10), rand);
            }
        }

        public static char[] GetRandomString(int x, Random rand)
        {
            char[] arr = new char[x];
            foreach (char i in arr)
            {
                arr[i] = (char)rand.Next(40, 80);
            }

            return arr;
        }
    }
}