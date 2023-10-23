using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /// VAJAG DO WHILE U STUPID FUCK!!! :))))
            // 1. uzd
            Console.WriteLine("=== 1. uzdevums ===");


            bool exit = false;
            while (exit == false)
            {
                Console.Write("Ievadies skaitli no 1 līdz 5 vai IZIET lai beigtu darbību");
                string darbiba = Console.ReadLine();

                switch (darbiba)
                {
                    case "1":
                        Console.WriteLine("Viens");
                        break;
                    case "2":
                        Console.WriteLine("Divi");
                        break;
                    case "3":
                        Console.WriteLine("Trīs");
                        break;
                    case "4":
                        Console.WriteLine("Četri");
                        break;
                    case "5":
                        Console.WriteLine("Pieci");
                        break;
                    case "IZIET":
                        Console.WriteLine("PROGRAMMA BEIDZ DARBĪBU");
                        exit = true;
                        break;
                }
            }
            // 2. uzd
            Console.WriteLine("=== 2. uzdevums ===");

            Console.Write("Cik reizes pārbaudīt skaitļus? ");
            int reizes = int.Parse(Console.ReadLine());
            for(int i = 0; i < reizes; i++)
            {
                Console.Write("Ievadiet skaitli: ");
                int skaitlis = int.Parse(Console.ReadLine());
                if (skaitlis%3 != 0)
                {
                    Console.WriteLine("Skaitlis NEdalās ar 3 bez atlikuma!");
                }
                else
                {
                    Console.WriteLine("Skaitlis dalās ar 3 bez atlikuma!");
                }
            }

            // 3. uzd
            Console.WriteLine("=== 3. uzdevums ===");
            Console.Write("Ievadiet trīsstūra platumu: ");
            int platums = int.Parse(Console.ReadLine());
            int spaces_left = 0;
            //int spaces_right = 0;
            int asterisk = platums;
            while (asterisk > 0)
            {
                Console.Write(new string(' ', spaces_left));
                Console.Write(new string('*', asterisk));
                //Console.Write(new string(' ', spaces_right));
                Console.Write('\n');
                asterisk -= 2;
                spaces_left++;
                //spaces_right++;
            }
        }
    }
}