using System;
using System.Xml;

namespace _7
{
    public class Skolēns
        {
            public string vārds;
            public string uzvārds;
            public string pers_kods;

            public void Reģistrēt()
            {
                Console.Write("Vārds: ");
                vārds = Console.ReadLine();
                Console.Write("Uzvārds: ");
                uzvārds = Console.ReadLine();
                Console.Write("Personas kods: ");
                pers_kods = Console.ReadLine();
            }

            public void Izvadīt()
            {
                Console.WriteLine($"Vārds: {vārds}");
                Console.WriteLine($"Uzvārds: {uzvārds}");
                Console.WriteLine($"Personas kods: {pers_kods}");
                Console.WriteLine($"Vecums: {AprēķinātVecumu()}");
            }
            
            public int AprēķinātVecumu()
            {
                int datums = int.Parse(pers_kods.Substring(0, 2)); // Extracting first two characters for the day
                int mēnesis = int.Parse(pers_kods.Substring(2, 2)); // Extracting two characters for the month
                int gads = int.Parse(pers_kods.Substring(4, 2)); // Extracting two characters for the year

                // Assuming the year is in the format YY, and adding 2000 to get the full year
                int pilnsGads = 2000 + gads;

                DateTime šodiena = DateTime.Today;

                int vecums = šodiena.Year - pilnsGads;

                // Adjusting age based on birth month and day
                if (šodiena.Month < mēnesis || (šodiena.Month == mēnesis && šodiena.Day < datums))
                {
                    vecums--;
                }

                return vecums;
            }

        }

        public class Skolotājs
        {
            public string vārds;
            public string uzvārds;
            public double alga;

            public void Reģistrēt()
            {
                Console.Write("Vārds: ");
                vārds = Console.ReadLine();
                Console.Write("Uzvārds: ");
                uzvārds = Console.ReadLine();
                Console.Write("Alga: ");
                alga = int.Parse(Console.ReadLine());
            }

            public void Izvadīt()
            {
                Console.WriteLine($"Vārds: {vārds}");
                Console.WriteLine($"Uzvārds: {uzvārds}");
                Console.WriteLine($"Alga: {AlgaPēcNodokļiem()}");
            }

            public double AlgaPēcNodokļiem()
            {
                return alga * (1 - 0.2 - 0.15);
            }
        }

        public class Klase
        {
            public string nosaukums;
            public int skolēnuSkaits;
            public Skolēns[] skolēni;
            public Skolotājs klasesAudzinātājs;

            public void Reģistrēt()
            {
                Console.Write("Nosaukums: ");
                nosaukums = Console.ReadLine();
                Console.Write("Skolēnu skaits: ");
                skolēnuSkaits = int.Parse(Console.ReadLine());
                skolēni = new Skolēns[skolēnuSkaits];
                
                for (int i = 0; i < skolēni.Length; i++)
                {
                    skolēni[i] = new Skolēns();
                    skolēni[i].Reģistrēt();
                }

                klasesAudzinātājs = new Skolotājs();
                klasesAudzinātājs.Reģistrēt();
            }

            public void Izvadīt()
            {
                Console.WriteLine($"Nosaukums: {nosaukums}");
                Console.WriteLine($"Skolēnu skaits: {skolēnuSkaits}");
                foreach (var skolēns in skolēni)
                {
                    skolēns.Izvadīt();
                }
                klasesAudzinātājs.Izvadīt();
            }

            public Skolēns VecākaisSkolēns()
            {
                int j = 0;
                for (int i = 0; i < skolēni.Length; i++)
                {
                    if (skolēni[i].AprēķinātVecumu() > skolēni[j].AprēķinātVecumu())
                    {
                        j = i;
                    }
                }
                
                return skolēni[j];
            }

            public void MeklētSkolēnu(string ko_meklēt)
            {
                for (int i = 0; i < skolēni.Length; i++)
                {
                    if (skolēni[i].vārds == ko_meklēt || skolēni[i].uzvārds == ko_meklēt)
                    {
                        skolēni[i].Izvadīt();
                    }
                    else
                    {
                        Console.WriteLine("Šāds skolēns netika atrasts.");
                    }
                }
            }
        }
        
    internal class Program
    {
        public static void Main(string[] args)
        {
            Klase klase = new Klase();
            klase.Reģistrēt();
            klase.Izvadīt();
        }

        public Klase meklētKlasei(Klase[] klases, string nosaukums)
        {
            int j = 0;
            for (int i = 0; i < klases.Length; i++)
            {
                if (klases[i].nosaukums == nosaukums)
                {
                    j = i;
                }
            }

            return klases[j];
    }
    }
}