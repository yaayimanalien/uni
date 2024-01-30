using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace prakt_d_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. uzd.
            Console.WriteLine("=== 1. uzdevums ===");

            Console.WriteLine("Ievadiet simbolu rindu");
            string simboli = Console.ReadLine();
            int summa = 0;


            for (int i = 0; i < simboli.Length; i++)
            {
                int ascii = (int)simboli[i];
                Console.WriteLine($"{simboli[i]}={ascii}");
                summa += ascii;
            }
            Console.WriteLine($"Kodu summa: {summa}");

            bool whileStop = false;
            
            while(whileStop == false)
            {
                Console.WriteLine("Ievadiet simbolu: ");
                char simbols = Convert.ToChar(Console.ReadLine());
                int skaits = 0;

                if (simbols == ' ')
                {
                    break;
                }

                for (int i = 0; i < simboli.Length; i++)
                {
                    

                    if (simboli[i] == simbols)
                    {
                        skaits++;
                    }
                }

                Console.WriteLine($"Simbols ir sastopams rindā {skaits} reizes");
            }

            // 2. uzd.
            Console.WriteLine("=== 2. uzdevums ===");

            Console.Write("Ievadi 1. simbolu rindu: ");
            string simboli1 = Console.ReadLine();

            Console.Write("Ievadi 2. simbolu rindu: ");
            string simboli2 = Console.ReadLine();

            // zvaigznītes

            string simboli3 = "";

            for (int i = 0; i < simboli1.Length; i++)
            {
                if((int)simboli1[i] <= 57 && (int)simboli1[i] >= 48)
                {
                    simboli3 += "*";
                }
                else
                {
                    simboli3 += simboli1[i];
                }
            }
            Console.WriteLine(simboli3);

            // lowercase2caps

            string simboli4 = "";

            for (int i = 0; i < simboli2.Length; i++)
            {
                if ((int)simboli2[i] >= 97 && (int)simboli2[i] <= 122)
                {
                    simboli4 += (char)(simboli2[i] - 32);
                }
                else
                {
                    simboli4 += simboli2[i];
                }
            }

            Console.WriteLine(simboli4);

            // stringu lenght

            Console.WriteLine($"1. simbolu rindas garums: {simboli1.Length}");
            Console.WriteLine($"2. simbolu rindas garums: {simboli2.Length}");

            // stringu apvienošana

            int rem = 0;
            string apvienojums = "";

            for (int i = 0; i < simboli2.Length / 2; i++)
            {
                apvienojums += simboli2[i];
                rem++;
            }

            apvienojums += simboli1;

            for (int i = rem; i < simboli2.Length; i++)
            {
                apvienojums += simboli2[i];
            }
            Console.WriteLine($"Rindu apvienojums: {apvienojums}");

            Console.Write("Ievadiet 3. simbolu rindu: ");
            string rinda = Console.ReadLine();

            int reizes = 0;

            for (int i = 0; i <= apvienojums.Length - rinda.Length; i++)
            {
                string buffer = "";
                for (int j = i; j < rinda.Length + i; j++)
                {
                    buffer += apvienojums[j];
                }
                if (buffer == rinda)
                {
                    reizes++;
                }
            }

            Console.WriteLine($"3. rinda atkārtojas apvienojumā {reizes} reizes.");
        }
    }
}
