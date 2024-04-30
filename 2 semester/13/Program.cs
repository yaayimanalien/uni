using System;
using System.Security.Authentication.ExtendedProtection;

namespace _13
{
    class Prece
    {
        private string Nosaukums;
        public double Iepirksanas_cena;

        void Izvadt()
        {
            Console.WriteLine($"Nosaukums: {Nosaukums}");
            Console.WriteLine($"Iepirksanas cena: {Iepirksanas_cena}");
        }
    }

    class Partikas_Prece : Prece
    {
        private DateTime Deriguma_termins; // (YYYY, MM, DD)
        private bool Ir_alergisks;
        private string Mervieniba;

        private double Pardosanas_cena
        {
            get { return Iepirksanas_cena * 1.3; }
        }

        public void Registret()
        {
            Console.Write("Deriguma termins (YYYY MM DD): ");
            Deriguma_termins = DateTime.Parse(Console.ReadLine());
            Console.Write("Vai prece ir alergiska (true/false): ");
            Ir_alergisks = bool.Parse(Console.ReadLine());
            Console.Write("Mervieniba: ");
            Mervieniba = Console.ReadLine();
        }

        public void Izvadit()
        {
            Console.WriteLine($"Deriguma termins: {Deriguma_termins}");
            Console.WriteLine($"Prece ir alergiska: {Ir_alergisks}");
            Console.WriteLine($"Mervieniba: {Mervieniba}");
            Console.WriteLine($"Pardosanas cena: {Pardosanas_cena}");
        }
    }


    class Saimniecibas_Prece : Prece
    {
        private string Materials;
        private bool Ir_bistama;
        double Pardosanas_cena
        {
            get { return Iepirksanas_cena * 1.5; }
        }

        public void Registret()
        {
            Console.Write("Materials: ");
            Materials = Console.ReadLine();
            Console.Write("Prece ir bistama (true/false): ");
            Ir_bistama = bool.Parse(Console.ReadLine());
        }

        public void Izvadit()
        {
            Console.WriteLine($"Materials: {Materials}");
            Console.WriteLine($"Prece ir bistama: {Ir_bistama}");
            Console.WriteLine($"Pardosanas cena: {Pardosanas_cena}");
        }
    }

    class Veikals
    {
        private string Nosaukums;
        private int Partikas_precu_skaits;
        private int Saimniecibas_precu_skaits;
        private Partikas_Prece[] PartikasPreces;
        private Saimniecibas_Prece[] SaimniecibasPreces;

        public void Registret()
        {
            Console.Write("Veikala nosaukums: ");
            Nosaukums = Console.ReadLine();
            Console.Write("Partikas precu skaits: ");
            Partikas_precu_skaits = int.Parse(Console.ReadLine());
            Console.Write("Saimniecibas precu skaits: ");
            Saimniecibas_precu_skaits = int.Parse(Console.ReadLine());
            PartikasPreces = new Partikas_Prece[Partikas_precu_skaits];
            SaimniecibasPreces = new Saimniecibas_Prece[Saimniecibas_precu_skaits];

            Console.WriteLine("Partikas preces:");
            foreach (Partikas_Prece prece in PartikasPreces)
            {
                prece.Registret();
            }

            Console.WriteLine("Saimniecibas preces:");
            foreach (Saimniecibas_Prece prece in SaimniecibasPreces)
            {
                prece.Registret();
            }
        }
        
        public void Izvadit()
        {
            Console.WriteLine($"Veikala nosaukums: {Nosaukums}");
            Console.WriteLine($"Partikas precu skaits: {Partikas_precu_skaits}");
            Console.WriteLine($"Saimniecibas precu skaits: {Saimniecibas_precu_skaits}");
            
            Console.WriteLine("Partikas preces:");
            foreach (Partikas_Prece prece in PartikasPreces)
            {
                prece.Izvadit();
            }

            Console.WriteLine("Saimniecibas preces:");
            foreach (Saimniecibas_Prece prece in SaimniecibasPreces)
            {
                prece.Izvadit();
            }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Partikas_Prece partikasPrece = new Partikas_Prece();
            // partikasPrece.Registret();

            Veikals baka = new Veikals();
            baka.Registret();
            baka.Izvadit();
        }
    }
}