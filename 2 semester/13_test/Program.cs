using System;

namespace StoreManagement
{
    class Prece
    {
        public string Nosaukums { get; set; }
        public double Iepirksanas_cena { get; set; }

        public void Izvadit()
        {
            Console.WriteLine($"Nosaukums: {Nosaukums}");
            Console.WriteLine($"Iepirksanas cena: {Iepirksanas_cena}");
        }
    }

    class PartikasPrece : Prece
    {
        public DateTime Deriguma_termins { get; set; }
        public bool Ir_alergisks { get; set; }
        private string Mervieniba { get; set; }
        public double Pardosanas_cena
        {
            get { return Iepirksanas_cena * 1.3; }
        }

        public void Registret()
        {
            Console.Write("Nosaukums: ");
            Nosaukums = Console.ReadLine();
            Console.Write("Iepirksanas cena: ");
            Iepirksanas_cena = int.Parse(Console.ReadLine());
            Console.Write("Deriguma termins (YYYY MM DD): ");
            Deriguma_termins = DateTime.Parse(Console.ReadLine());
            Console.Write("Vai prece ir alergiska (true/false): ");
            Ir_alergisks = bool.Parse(Console.ReadLine());
            Console.Write("Mervieniba: ");
            Mervieniba = Console.ReadLine();
        }

        public new void Izvadit()
        {
            // base.Izvadit();
            // Console.WriteLine($"Deriguma termins: {Deriguma_termins}");
            // Console.WriteLine($"Prece ir alergiska: {Ir_alergisks}");
            // Console.WriteLine($"Mervieniba: {Mervieniba}");
            // Console.WriteLine($"Pardosanas cena: {Pardosanas_cena}");
            Console.WriteLine($"{Nosaukums}\t\t\t{Iepirksanas_cena}\t\t\t\t{Deriguma_termins}\t\t{Ir_alergisks}\t\t\t\t{Mervieniba}\t\t\t{Pardosanas_cena}");
        }
    }

    class Saimniecibas_Prece : Prece
    {
        public string Materials;
        public bool Ir_bistama;
        public double Pardosanas_cena
        {
            get { return Iepirksanas_cena * 1.5; }
        }
        
        public void Registret()
        {
            Console.Write("Nosaukums: ");
            Nosaukums = Console.ReadLine();
            Console.Write("Iepirksanas cena: ");
            Iepirksanas_cena = int.Parse(Console.ReadLine());
            Console.Write("Materials: ");
            Materials = Console.ReadLine();
            Console.Write("Prece ir bistama (true/false): ");
            Ir_bistama = bool.Parse(Console.ReadLine());
        }
        
        public void Izvadit()
        {
            //base.Izvadit();
            // Console.WriteLine($"Nosaukums: {Nosaukums}");
            // Console.WriteLine($"Iepirksanas cena: {Iepirksanas_cena}");
            // Console.WriteLine($"Materials: {Materials}");
            // Console.WriteLine($"Prece ir bistama: {Ir_bistama}");
            // Console.WriteLine($"Pardosanas cena: {Pardosanas_cena}");
            Console.WriteLine($"{Nosaukums}\t\t\t{Iepirksanas_cena}\t\t\t\t{Materials}\t\t\t{Ir_bistama}\t\t\t{Pardosanas_cena}");
        }
    }

    class Veikals
    {
        public string Nosaukums { get; set; }
        public PartikasPrece[] PartikasPreces { get; set; }
        public Saimniecibas_Prece[] SaimniecibasPreces { get; set; }

        public void Registret()
        {
            Console.Write("Veikala nosaukums: ");
            Nosaukums = Console.ReadLine();
            
            Console.Write("Partikas precu skaits: ");
            int Partikas_precu_skaits = 0; 
            Partikas_precu_skaits = int.Parse(Console.ReadLine());
            PartikasPreces = new PartikasPrece[Partikas_precu_skaits];
            
            Console.Write("Saimniecibas precu skaits: ");
            int Saimniecibas_precu_skaits = 0;
            Saimniecibas_precu_skaits = int.Parse(Console.ReadLine());
            SaimniecibasPreces = new Saimniecibas_Prece[Saimniecibas_precu_skaits];
            
            for (int i = 0; i < Partikas_precu_skaits; i++)
            {
                PartikasPreces[i] = new PartikasPrece();
                PartikasPreces[i].Registret();
            }

            for (int i = 0; i < Saimniecibas_precu_skaits; i++)
            {
                SaimniecibasPreces[i] = new Saimniecibas_Prece();
                SaimniecibasPreces[i].Registret();
            }
        }

        public void Izvadit()
        {
            Console.WriteLine($"Veikala nosaukums: {Nosaukums}");
            Console.WriteLine($"Partikas precu skaits: {PartikasPreces.Length}");

            if (PartikasPreces.Length != 0)
            {
                Console.WriteLine("\n=== PARTIKAS PRECU IZVADISANA ===\n");
                Console.WriteLine("Nosaukums\t\tIepirksanas cena\t\tDeriguma termins\t\tPrece ir alergiska\t\tMervieniba\t\tPardosanas cena");
                foreach (var partikasPrece in PartikasPreces)
                {
                    partikasPrece.Izvadit();
                }
            }
            
            if (SaimniecibasPreces.Length!=0)
            {
                Console.WriteLine("\n=== SAIMNIECIBAS PRECU IZVADISANA ===\n");
                Console.WriteLine("Nosaukums\t\tIepirksanas cena\t\tMaterials\t\tIr bistama\t\tPardosanas cena");
                foreach (var saimniecibasPrece in SaimniecibasPreces)
                {
                    saimniecibasPrece.Izvadit();
                }
            }
            else
            {
                Console.WriteLine();
            }
        }

        public void Veikala_Tips()
        {
            if (PartikasPreces.Length==0)
            {
                Console.WriteLine("\nVeikals ir saimniecibas veikals\n");
            }
            else if (SaimniecibasPreces.Length == 0)
            {
                Console.WriteLine("\nVeikals ir partikas veikals\n");
            }
            else
            {
                Console.WriteLine("\nVeikals ir lielveikals\n");
            }
        }

        public void Atlasit_arpus_termina()
        {
            if (PartikasPreces.Length != 0)
            {
                Console.WriteLine("\n=== PRECES ARPUS TERMINA ===\n");
                Console.WriteLine("Nosaukums\t\tIepirksanas cena\t\tDeriguma termins\t\tPrece ir alergiska\t\tMervieniba\t\tPardosanas cena");
                for (int i = 0; i < PartikasPreces.Length; i++)
                {
                    if (PartikasPreces[i].Deriguma_termins < DateTime.Now)
                    {
                        PartikasPreces[i].Izvadit();
                    }
                }
            }
            else
            {
                Console.WriteLine();
            }
        }

        public void Atlasit_bistamus()
        {
            if (SaimniecibasPreces.Length != 0)
            {
                Console.WriteLine("\n=== PRECES KAS IR BISTAMAS ===\n");
                Console.WriteLine("Nosaukums\t\tIepirksanas cena\t\tMaterials\t\tIr bistama\t\tPardosanas cena");
                for (int i = 0; i < SaimniecibasPreces.Length; i++)
                {
                    if (SaimniecibasPreces[i].Ir_bistama)
                    {
                        SaimniecibasPreces[i].Izvadit();
                    }
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Veikals veikals = new Veikals();
            Console.WriteLine("=== VEIKALA REGISTRESANA ===\n");
            veikals.Registret();
            Console.WriteLine("\n=== VEIKALA IZVADISANA ===\n");
            veikals.Izvadit();
            veikals.Veikala_Tips();
            veikals.Atlasit_arpus_termina();
            veikals.Atlasit_bistamus();
        }
    }
}
