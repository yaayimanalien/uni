using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reinis_Jānis_Barons_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. uzd

            Console.Write("Ievadi skaitu: ");
            int n = int.Parse(Console.ReadLine());
            int evenNumSum = 0;
            int evenNumCount = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ievadiet veselu skaitli: ");
                int skaitlis = int.Parse(Console.ReadLine());
                if (skaitlis%2==0 ) {
                    evenNumCount++;
                    evenNumSum = evenNumSum + skaitlis;
                }
            }
            Console.WriteLine($"Tika ievadīti {evenNumCount} pāra skaitļi, kuru kopīgā summa ir {evenNumSum}");

            // 2. uzd

            Console.Write("Ievadi pirmā datora cenu: ");
            int pc1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otrā datora cenu: ");
            int pc2 = int.Parse(Console.ReadLine());
            bool exit = false;
            int cheapest = 0;
            int most_expensive = 0;

            if (pc1 > pc2)
            {
                most_expensive = 1;
            }
            else
            {
                most_expensive = 2;
            }
            if (most_expensive == 1)
            {
                cheapest = 2;
            }
            else
            {
                cheapest = 1;
            }

            do
            {
                Console.Clear();
                Console.Write("1 - Kopā\n2 - Lētākais dators\n3 - Dārgākais dators\n4 - Vidējā cena\n5 - Iziet no programmas\n");
                int decision = int.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Abu datoru kopsumma ir {pc1 + pc2}\nNospiediet jebkuru taustiņu, lai tiktu uz galveno izvēltni.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"Lētākais dators ir {cheapest}. dators\nNospiediet jebkuru taustiņu, lai tiktu uz galveno izvēltni.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Dārgākais dators ir {most_expensive}. dators\nNospiediet jebkuru taustiņu, lai tiktu uz galveno izvēltni.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"Datoru vidējā cena ir {(pc1 + pc2) / 2}\nNospiediet jebkuru taustiņu, lai tiktu uz galveno izvēltni.");
                        Console.ReadKey();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Kļūda - izvēlētā opcija neeksistē.\nNospiediet jebkuru taustiņu, lai tiktu uz galveno izvēltni.");
                        Console.ReadKey();
                        break;
                }
            }
            while (exit == false);
        }
    }
}
