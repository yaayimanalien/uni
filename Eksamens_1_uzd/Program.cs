using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_1_uzd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet tekstu: ");
            string teksts = Console.ReadLine();
            int wordCount = 0;
            int summa = 0;

            for (int i = 0; i < teksts.Length; i++)
            {
                if (teksts[i] == ' ')
                {
                    if (teksts[i+1] != ' ')
                    {
                        wordCount++;
                    }
                }
                if ((int)teksts[i] <= 57 && (int)teksts[i] >= 48)
                {
                    summa = summa + int.Parse(teksts[i].ToString());
                }
            }
            wordCount++;


            Console.WriteLine($"Tekstā ir {wordCount} vārdu");
            Console.WriteLine($"Tekstā sastopamo skaitļu summa ir {summa}");
        }
    }
}
