using System;

namespace _11._3
{
    class Konstruktors
    {
        public Konstruktors()
        {
            Console.WriteLine("Default Konstruktors");
        }

        public Konstruktors(int x)
        {
            Console.WriteLine($"int tipa parametrs {x}");
        }

        public Konstruktors(double x)
        {
            Console.WriteLine($"double tipa parametrs {x}");
        }

        public Konstruktors(string x)
        {
            Console.WriteLine($"string tipa parametrs {x}");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Konstruktors defaultKonstruktors = new Konstruktors();
            Konstruktors intKonstruktors = new Konstruktors(5);
            Konstruktors doubleKonstruktors = new Konstruktors(5.0);
            Konstruktors stringKonstruktors = new Konstruktors("5");
        }
    }
}

