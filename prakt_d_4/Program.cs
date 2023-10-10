using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. uzd.

            Console.Write("Ievadi x: ");
            int x = int.Parse(Console.ReadLine());
            int beigas = x + 5;
            for (int i = x+1; i <= beigas; i++)
            {
                Console.WriteLine("Inkramentēšanas rezultāts: " + i);
            }

            Console.Write("\n");

            Console.Write("Ievadi x: ");
            int x1 = int.Parse(Console.ReadLine());
            int beigas1 = x - 5;
            for (int i = x1 - 1; i >= beigas1; i--)
            {
                Console.WriteLine("Inkramentēšanas rezultāts: " + i);
            }

            Console.Write("\n");

            // 2. uzd.

            Console.Write("Ievadiet vārdu: ");
            string vards = Console.ReadLine();
            Console.Write("Ieavdiet uzvārdu: ");
            string uzvards = Console.ReadLine();

            string pilnsVards = vards + " " + uzvards;

            Console.WriteLine("Sveiki " + pilnsVards + "!");

            Console.WriteLine();

            // 3. uzd.

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("************\t************\t************\t\r\n************\t************\t**\t  **\r\n**\t  **\t\t  **\t**\t  **");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("**\t  **\t\t  **\t**\t  **\r\n************\t\t  **\t**********\r\n************\t\t  **\t**********");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("**    ****\t**\t  **\t**\t  **\r\n**\t****\t****\t  **\t**\t  **\r\n**\t  **\t************\t************");
        }
    }
}
