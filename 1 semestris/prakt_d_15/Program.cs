using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool breakLoop = false;
            double nauda = 0;
            
            while (breakLoop == false)
            {
                Console.WriteLine("0 - iziet\n1 - Budžeta pamatsummas ievadīšana\n2 - budžeta noguldīšana\n3 - budžeta pamatsummas palielināšana\n4 - budžeta samazinājums\n5 - budžeta atlikums\n\nIzvēlies darbību: ");
                string decision = Console.ReadLine();
                switch (decision)
                {
                    case "0":
                        breakLoop = true;
                        break;
                    case "1":
                        Console.Write("Ievadi budžeta pamatsummu: ");
                        nauda = int.Parse(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Ievadiet procentu likmi: ");
                        double procentuLikme = double.Parse(Console.ReadLine());
                        Console.Write("Uz cik gadiem noguldīsiet naudu: ");
                        int gadi = int.Parse(Console.ReadLine());
                        nauda = procenti(nauda, procentuLikme, gadi);
                        break;
                    case "3":
                        Console.Write("Ievadiet summu, ko vēlaties pievienot budžetam: ");
                        double add = double.Parse(Console.ReadLine());
                        nauda = pluss(nauda, add);
                        break;
                    case "4":
                        Console.Write("Ievadiet summu, ko iztērējāt no budžeta: ");
                        double sub = double.Parse(Console.ReadLine());
                        nauda = minuss(nauda, sub);
                        break;
                    case "5":
                        Console.WriteLine($"Uz doto brīdi kopējā nauda pēc visām darbībām: {Math.Round(nauda)}");
                        break;
                }
            }
        }

        static double procenti(double nauda, double procenti, int gadi)
        {
            return nauda * Math.Pow(1 + procenti / 100, gadi);
        }

        static double pluss(double nauda, double pluss)
        {
            return nauda + pluss;
        }

        static double minuss(double nauda, double sub)
        {
            return nauda - sub;
        }
    }
}
