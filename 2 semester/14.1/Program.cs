using System;
using System.IO;

namespace _14._1
{
    class StudijuKurss
    {
        public string Nosaukums { get; set; }
        public int Kreditpunkti { get; set; }
        public double EKreditPunkti
        {
            get { return Kreditpunkti * 1.5; }
        }
        public bool IrObligats { get; set; }

        public void ReadData()
        {
            Console.Write("Kursa nosaukums: ");
            Nosaukums = Console.ReadLine();
            Console.Write("Kursa kreditpunkti: ");
            Kreditpunkti = int.Parse(Console.ReadLine());
            Console.Write("Vai kurss ir obligats (true/false): ");
            IrObligats = bool.Parse(Console.ReadLine());
        }

        public void PrintData()
        {
            Console.WriteLine($"Kursa nosaukums - {Nosaukums}");
            Console.WriteLine($"Kursa kreditpunkti - {Kreditpunkti}");
            Console.WriteLine($"Kursa e kreditpunti: {EKreditPunkti}");
            Console.WriteLine($"Kurss ir obligats - {IrObligats}");
        }
    }
    
    internal class Program
    {
        public static void FillArray(StudijuKurss[] kurss)
        {
            for (int i = 0; i < kurss.Length; i++)
            {
                kurss[i] = new StudijuKurss();
                kurss[i].ReadData();
            }
        }

        public static void PrintArray(StudijuKurss[] kurss)
        {
            for (int i = 0; i < kurss.Length; i++)
            {
                if (kurss[i]!=null)
                {
                    kurss[i].PrintData();
                }
            }
        }

        public static void PrintArrayToFile(StudijuKurss[] kurss)
        {
            // PrintArrayToFile(StudijuKurss[] kurss) – saņem kā parametru StudijuKurss tipa
            // masīvu un saglabā masīva vērtības .txt failā, kur katru īpašību atdala ar „ ; ” vai citu
            // simbolu;

            string PATH = @".\file.txt";
            using (StreamWriter writer = new StreamWriter(PATH))
            {
                writer.WriteLine("Kursa nosaukums,Kursa kredītpunkti,Kursa e kredītpunkti,Vai ir obligats");

                foreach (StudijuKurss k in kurss)
                {
                    string line = $"{k.Nosaukums},{k.Kreditpunkti},{k.IrObligats}";
                    writer.WriteLine(line);
                }
            }
        }

        public static StudijuKurss[] ReadArrayFromFile()
        {
            string PATH = @".\file.txt";
            StudijuKurss[] kurss = new StudijuKurss[2];

            using (StreamReader reader = new StreamReader(PATH))
            {
                string line;

                
                reader.ReadLine();  // izlaižam headeri
                
                for (int i = 0; (line = reader.ReadLine()) != null; i++)
                {
                    string[] props = line.Split(',');

                    kurss[i] = new StudijuKurss();
                    kurss[i].Nosaukums = props[0];
                    kurss[i].Kreditpunkti = int.Parse(props[1]);
                    kurss[i].IrObligats = bool.Parse(props[2]);
                }
            }

            return kurss;
        }


        
        public static void Main(string[] args)
        {
            StudijuKurss[] kurss = new StudijuKurss[2];
            Console.WriteLine("===FILLING ARRAY===");
            FillArray(kurss);
            
            PrintArrayToFile(kurss);
            StudijuKurss[] jaunsKurss = ReadArrayFromFile();

            Console.WriteLine("===PRINTING FROM FILE===");
            PrintArray(jaunsKurss);
        }
    }
}