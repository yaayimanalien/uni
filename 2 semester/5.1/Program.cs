using System;

namespace _5._1
{
    internal class Program
    {
        public class Prece
        {
            public string nosaukums;
            public double cena;

            public void Reģistrēt()
            {
                Console.Write("Ieavdi nosaukumu: ");
                nosaukums = Console.ReadLine();
                Console.Write("Ievadiet cenu: ");
                cena = int.Parse(Console.ReadLine());
            }

            public void Izvadīt()
            {
                Console.WriteLine($"Nosaukums: {nosaukums}");
                Console.WriteLine($"Cena: {cena}");
            }
        }

        public class Grozs
        {
            public int skaits;
            public Prece[] preces;

            public void Reģistrēt()
            {
                
            }

            public void Kopsumma()
            {
                
            }

            public void Izvadīt()
            {
                
            }
        }

        public class Persona
        {
            public string vards;
            public string parole;
            public Grozs grozs;
            public double lidzekli;

            public void Reģistrēt()
            {
                
            }

            public void PietiekLidzeklu()
            {
                
            }

            public void Izvadīt()
            {
                
            }
        }
        
        public static void Main(string[] args)
        {
            Persona persona = new Persona();
        }
    }
}