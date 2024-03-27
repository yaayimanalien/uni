using System;
using System.Xml;

namespace _6
{
    internal class Program
    {
        public class Punkts
        {
            // Punkta parametri
            public int X;
            public int Y;
            public string Krāsa;

            public void Reģistret()
            {
                // Reģistrē punkta vērtības
                
                Console.Write("Ievadi X: ");
                X = int.Parse(Console.ReadLine());
                
                Console.Write("Ievadi Y: ");
                Y = int.Parse(Console.ReadLine());
                
                Console.Write("Ievadi krāsu: ");
                Krāsa = Console.ReadLine();
            }

            public void Izvadīt()
            {
                // Izvada punkta vērtības
                
                Console.WriteLine($"X: {X}");
                Console.WriteLine($"Y: {Y}");
                Console.WriteLine($"Krāsa: {Krāsa}");
            }
        }

        public class Linija
        {
            // Līnijas parametri
            
            public Punkts A;
            public Punkts B;
            public string Krāsa;

            public void Reģistrēt()
            {
                // Izveido A un B objektus punktiem un izsauc Reģistrēt(), reģistrē krāsu
                
                Console.WriteLine("Punktam A");
                A = new Punkts();
                A.Reģistret();
                
                Console.WriteLine("Punktam B");
                B = new Punkts();
                B.Reģistret();
                
                Console.Write("Līnijas krāsa: ");
                Krāsa = Console.ReadLine();
            }

            public double Garums()
            {
                // Aprēķina līnijas garumu ieliekot punktu X Y koordinātas formula un rezultātu atgriež
                
                double garums = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
                return garums;
            }

            public void Izvadīt()
            {
                // Izvada punktu vērtības ar Punkts.Izvadīt(), izvada garumu un līnijas krāsu
                
                Console.WriteLine("Punktam A");
                A.Izvadīt();
                
                Console.WriteLine("Punktam B");
                B.Izvadīt();
                
                Console.WriteLine($"Garums: {Garums()}");
                
                Console.WriteLine($"Līnijas krāsa: {Krāsa}");
            }

        }
        public static void Main(string[] args)
        {
            // Izveido ciklu līniju reģistrēšanai
            
            Console.Write("Ievadi līniju skaitu: ");
            int skaits = int.Parse(Console.ReadLine());
            Linija[] linijas = new Linija[skaits];
            
            for (int i = 0; i < skaits; i++)
            {
                // Izveido jaunu līnijas objektu, izsauc Līnija.Reģistrēt()
                
                Console.WriteLine($"Reg {i+1}");
                
                linijas[i] = new Linija();
                linijas[i].Reģistrēt();
            }

            Console.WriteLine("Reģistrētās līnijas:");

            // Cikls izsauc Līnija.Izvadīt() katrai līnijai
            
            for (int i = 0; i < skaits; i++)
            {
                Console.WriteLine($"Līnijai {i+1}");
                linijas[i].Izvadīt();
                Console.WriteLine();
            }
        }
    }
}