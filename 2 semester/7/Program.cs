using System;

namespace _7
{
    public class Skolēns
        {
            // Skolēna parametri
            public string vārds;
            public string uzvārds;
            public string pers_kods;

            public void Reģistrēt()
            {
                // Reģistrē skolēna vērtības
                
                Console.Write("Skolēna vārds: ");
                vārds = Console.ReadLine();
                Console.Write("Skolēna uzvārds: ");
                uzvārds = Console.ReadLine();
                Console.Write("Skolēna personas kods: ");
                pers_kods = Console.ReadLine();
            }

            public void Izvadīt()
            {
                // Izvada skolēna vērtības
                
                Console.WriteLine($"Skolēna vārds: {vārds}");
                Console.WriteLine($"Skolēna uzvārds: {uzvārds}");
                Console.WriteLine($"Skolēna personas kods: {pers_kods}");
                Console.WriteLine($"Skolēna vecums: {AprēķinātVecumu()}");
            }
            
            public int AprēķinātVecumu()
            {
                // Sadala personas koda pirmo daļu
                
                int datums = int.Parse(pers_kods.Substring(0, 2)); 
                int mēnesis = int.Parse(pers_kods.Substring(2, 2)); 
                int gads = int.Parse(pers_kods.Substring(4, 2)); 

                
                // Izveido pašreizējā laika objektu
                DateTime šodiena = DateTime.Today;

                int pilnsGads;
                
                if (gads > šodiena.Year)
                {
                    pilnsGads = 1900 + gads;
                }
                else
                {
                    pilnsGads = 2000 + gads;
                }
                
                int vecums = šodiena.Year - pilnsGads;
                
                if (šodiena.Month < mēnesis || (šodiena.Month == mēnesis && šodiena.Day < datums))
                {
                    vecums--;
                }

                return vecums;
            }

        }

        public class Skolotājs
        {
            // skolotāja parametri
            
            public string vārds;
            public string uzvārds;
            public double alga;

            public void Reģistrēt()
            {
                // reģistrē skolotāja parametrus
                
                Console.Write("Skolotāja vārds: ");
                vārds = Console.ReadLine();
                Console.Write("Skolotāja uzvārds: ");
                uzvārds = Console.ReadLine();
                Console.Write("Skolotāja alga: ");
                alga = int.Parse(Console.ReadLine());
            }

            public void Izvadīt()
            {
                // izvada parametrus
                
                Console.WriteLine($"Skolotāja vārds: {vārds}");
                Console.WriteLine($"Skolotāja uzvārds: {uzvārds}");
                Console.WriteLine($"Skolotāja alga: {AlgaPēcNodokļiem()}");
            }

            public double AlgaPēcNodokļiem()
            {
                // pareizina algu ar nodokļu likmēm
                
                return alga * (1 - 0.2 - 0.15);
            }
        }

        public class Klase
        {
            // klases parametri
            
            public string nosaukums;
            public int skolēnuSkaits;
            public Skolēns[] skolēni;
            public Skolotājs klasesAudzinātājs;

            public void Reģistrēt()
            {
                // reģistrē parametrus
                
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
                // izvada parametrus
                
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
                // iziec cauri klases skolēniem un noskaidro vecāko
                
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
                // iziet cauri skolēniem klasē un atrod skolēnu
                
                bool irAtrasts = false; 

                for (int i = 0; i < skolēni.Length; i++)
                {
                    if (skolēni[i].vārds == ko_meklēt || skolēni[i].uzvārds == ko_meklēt)
                    {
                        irAtrasts = true; 
                        skolēni[i].Izvadīt();
                    }
                }
                
                if (!irAtrasts)
                {
                    Console.WriteLine("Šāds skolēns netika atrasts.");
                }
            }

        }
        
    internal class Program
    {
        // public static void Main(string[] args)
        // {
        //     Klase klase = new Klase();
        //     klase.Reģistrēt();
        //     klase.Izvadīt();
        // }

        
        public static Klase meklētKlasei(Klase[] klases, string nosaukums)
        {
            // iziec cauri klasēm un atrod klasi
            for (int i = 0; i < klases.Length; i++)
            {
                if (klases[i] != null)
                {
                    if (klases[i].nosaukums == nosaukums)
                    {
                        return klases[i];
                    }
                }
            }

            return null;
        }
        
        public static void Main()
        {
            Klase[] klases;                             // izveido klašu masīvu
            Console.Write("Ievadu klašu skaitu: ");
            int skaits = int.Parse(Console.ReadLine());
            klases = new Klase[skaits];
            
            bool loopStop = false;
            while (!loopStop)
            {
                Console.Clear();
                Console.WriteLine("1 - Izveidot jaunu klasi");
                Console.WriteLine("2 - Izvadīt informāciju par klasēm");
                Console.WriteLine("3 - Atrast klasi");
                Console.WriteLine("4 - Atrast skolēnu");
                Console.WriteLine("5 - Atrast klasē vecāko skolēnu");
                Console.WriteLine("0 - Iziet");
                Console.Write("\nIzvēlies darbību: ");
                string darbība = Console.ReadLine();
            
                switch(darbība)
                {
                    case "0":
                        loopStop = true;
                        break;
                    
                    case "1":
                        
                        for (int i = 0; i < klases.Length; i++)
                        {
                            if (klases[i] == null)
                            {
                                klases[i] = new Klase();
                                klases[i].Reģistrēt();
                                break;
                            }
                        }
                        break;
                    
                    case "2":
                        for (int i = 0; i < klases.Length; i++)
                        {
                            if (klases[i] != null)
                            {
                                klases[i].Izvadīt();
                            }
                        }
                        Console.ReadKey();
                        break;
                    
                    case "3":
                        Console.Write("Ieraksi klases nosaukumu: ");
                        string nosaukums = Console.ReadLine();

                        Klase atrastāKlase = meklētKlasei(klases, nosaukums);
                        if (atrastāKlase != null)
                        {
                            atrastāKlase.Izvadīt();
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Klase netika atrasta.");
                            Console.ReadKey();
                        }
                        break;
                    
                    case "4":
                        Console.WriteLine("Ievadiet skolēna vārdu vai uzvārdu: ");
                        string koMeklēt = Console.ReadLine();
                        for (int i = 0; i < klases.Length; i++)
                        {
                            if (klases[i] != null)
                            {
                                klases[i].MeklētSkolēnu(koMeklēt);
                            }
                        }

                        Console.ReadKey();
                        break;
                    
                    case "5":
                        for (int i = 0; i < klases.Length; i++)
                        {
                            if (klases[i] != null)
                            {
                                klases[i].VecākaisSkolēns().Izvadīt();
                                Console.WriteLine($"Šis skolēns atrodas {klases[i].nosaukums} klasē.");
                            }
                        }

                        Console.ReadKey();
                        break;
                }
            }
        }

        
    }
}