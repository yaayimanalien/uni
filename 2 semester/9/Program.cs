using System;

namespace _9
{
    public struct Darbinieks
    {
        public int id;
        public string vards;
        public string uzvards;
        public int bernu_sk;
        public string amats;
        public bool slodze;

        public void Registret()
        {
            Console.Write("Id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Vards: ");
            vards = Console.ReadLine();
            Console.Write("Uzvards: ");
            uzvards = Console.ReadLine();
            Console.Write("Bernu skaits: ");
            bernu_sk = int.Parse(Console.ReadLine());
            Console.Write("Amats: ");
            amats = Console.ReadLine();
            Console.Write("Slodze: ");
            slodze = bool.Parse(Console.ReadLine());
        }

        public void Izvadit()
        {
            // Console.WriteLine($"Id: {id}");
            // Console.WriteLine($"Vards: {vards}");
            // Console.WriteLine($"Uzvards: {uzvards}");
            // Console.WriteLine($"Bernu skaits: {bernu_sk}");
            // Console.WriteLine($"Amats: {amats}");
            // Console.WriteLine($"Slodze: {slodze}");

            
            Console.WriteLine($"{id}\t{vards}\t{uzvards}\t{bernu_sk}\t\t{amats}\t{slodze}");
        }

    }
    internal class Program
    {
        public static void IevaditPecId(int id_meklet, Darbinieks[] darbinieki)
        {
            for (int i = 0; i < darbinieki.Length; i++)
            {
                if (darbinieki[i].id == id_meklet)
                {
                    Console.WriteLine("Id\tVards\tUzvards\tBernu skaits\tAmats\tSlodze");
                    darbinieki[i].Izvadit();
                }
            }
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Ievadi darbinineku skaitu: ");
            int skaits = int.Parse(Console.ReadLine());
            Darbinieks[] darbinieki = new Darbinieks[skaits];
            
            while (true)
            {
                Console.WriteLine("Lūdzu izvēlēties metodi:");
                Console.WriteLine("1 - Ievadīt darbinieku");
                Console.WriteLine("2 - Izvadīt uz ekrāna");
                Console.WriteLine("3 - Izvadīt konkrētu darbinieku");
                Console.Write("Jūsu izvēle: ");
                string izvele = Console.ReadLine();
            
                switch(izvele)
                {
                    case "1":
                        for (int i = 0; i < darbinieki.Length; i++)
                        {
                            Console.WriteLine($"Ludzu ievadiet {i+1} darbinieka datus:");
                            darbinieki[i].Registret();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Id\tVards\tUzvards\tBernu skaits\tAmats\tSlodze");
                        for (int i = 0; i < darbinieki.Length; i++)
                        {
                            darbinieki[i].Izvadit();
                        }
                        break;
                    case "3":
                        Console.Write("Ievadi darbinieka id: ");
                        int id_meklet = int.Parse(Console.ReadLine());
                        IevaditPecId(id_meklet, darbinieki);
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}