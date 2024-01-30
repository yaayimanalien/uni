using System;

namespace _1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1. uzd
            Console.WriteLine("=== 1. uzdevums ===");
            
            bool loopStop = false;
            Random random = new Random();
            int randomInt = random.Next(1, 100);
            int count = 0;

            while (loopStop == false)
            {
                count++;
                Console.Write("Ievadi skaitli: ");
                int input = int.Parse(Console.ReadLine());
                if (input>randomInt)
                {
                    Console.WriteLine("Mazāks");
                }
                else if (input<randomInt)
                {
                    Console.WriteLine("Lielāks");
                }
                else if (input == randomInt)
                {
                    Console.WriteLine("Skaitlis ir uzminēts!");
                    Console.WriteLine($"Reizes: {count}");
                    loopStop = true;
                }
                
                
                
            }
            
            
        }
    }
}