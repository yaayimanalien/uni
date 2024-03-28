using System;

namespace _5
{
    internal class Program
    {
        public class Prece
        {
            // Preces parametri
            
            public string nosaukums;
            public double cena;

            // Reģistrē parametru vērtības
            
            public void Reģistrēt()
            {
                Console.Write("Ievadi nosaukumu: ");
                nosaukums = Console.ReadLine();
                Console.Write("Ievadi cenu");
                cena = double.Parse(Console.ReadLine());
            }
            
            // Izvada parametru vērtības

            public void Izvadīt()
            {
                Console.WriteLine($"Nosaukums: {nosaukums}");
                Console.WriteLine($"Cena: {cena}");
            }
        }

        public class Grozs
        {
            // Groza parametri
            public int skaits;
            public Prece[] preces;
            
            public void Reģistrēt()
            {
                Console.Write("Ievadi preču skaitu grozā: ");
                skaits = int.Parse(Console.ReadLine());
                preces = new Prece[skaits];
                
                // Iziet cauri preču masīvam, katrā masīva vērtībā ievieto preces objektu,
                // izsauc Prece.Reģistrēt()
                
                for (int i = 0; i < preces.Length; i++)
                {
                    Console.WriteLine($"Prece {i+1}");
                    preces[i] = new Prece();
                    preces[i].Reģistrēt();
                }
            }

            public double Kopsumma()
            {
                double kopsumma = 0;
                
                // Iziet cauri preču masīvam un katras preces cenu pieskaita pie kopsummas
                
                foreach (var prece in preces)
                {
                    kopsumma += prece.cena;
                }

                return kopsumma;
            }

            public void Izvadīt()
            {
                // Izsauc katras preces Izvadīt() funkciju
                
                for (int i = 0; i < preces.Length; i++)
                {
                    Console.WriteLine($"Prece {i+1}");
                    preces[i].Izvadīt();
                }
                
                // Izsauc un izvada kopsummu
                Console.WriteLine($"Kopsumma: {Kopsumma()}");
            }
        }

        public class Persona
        {
            public string vārds;
            public string parole;
            public Grozs grozs;
            public double līdzekļi;
            
            public void Reģistrēt()
            {
                Console.Write($"Vārds: ");
                vārds = Console.ReadLine();
                Console.Write($"Parole: ");
                parole = Console.ReadLine();
                Console.Write("Līdzekļu daudzums: ");
                līdzekļi = double.Parse(Console.ReadLine());
                grozs = new Grozs();
                grozs.Reģistrēt();
            }

            public bool PietiekLīdzekļu()
            {
                return grozs.Kopsumma() =< līdzekļi;
            }

            public void Izvadīt()
            {
                Console.WriteLine($"Vārds: {vārds}");
                Console.WriteLine($"Parole: {parole}");
                Console.WriteLine($"Līdzekļi: {līdzekļi}");
                Console.WriteLine("Groza saturs: ");

                for (int i = 0; i < grozs.preces.Length; i++)
                {
                    Console.WriteLine($"Prece {i+1}");
                    grozs.Izvadīt();
                }
            }
        }
        public static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Reģistrēt();
            persona.Izvadīt();
            if (persona.PietiekLīdzekļu())
            {
                Console.WriteLine("Personai pietiek līdzekļu.");
            }
            else
            {
                Console.WriteLine("Personai nepietiek līdzekļu");
            }
        }
    }
}