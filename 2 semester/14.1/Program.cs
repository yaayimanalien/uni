using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Xml;

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
        public Program()
        {
        }

        public void FillArray(StudijuKurss[] kurss)
        {
            for (int i = 0; i < kurss.Length; i++)
            {
                kurss[i].ReadData();
            }
        }

        public void PrintArray(StudijuKurss[] kurss)
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
                    string line = $"{k.Nosaukums},{k.Kreditpunkti},{k.EKreditPunkti},{k.IrObligats}";
                    writer.WriteLine(line);
                }
            }
        }

        // public static StudijuKurss[] ReadArrayFromFile()
        // {
        //     string PATH = @".\file.txt";
        //     string[] lines = File.ReadAllLines(PATH);
        //     StudijuKurss[] kurssArray = new StudijuKurss[lines.Length - 1]; // Assuming the header is skipped
        //
        //     for (int i = 1; i < lines.Length; i++) // Start from 1 to skip the header
        //     {
        //         string[] parts = lines[i].Split(',');
        //         string nosaukums = parts[0];
        //         int kreditpunkti = int.Parse(parts[1]);
        //         bool irObligats = bool.Parse(parts[3]);
        //
        //         StudijuKurss kurss = new StudijuKurss();
        //         kurss.Nosaukums = nosaukums;
        //         kurss.Kreditpunkti = kreditpunkti;
        //         kurss.IrObligats = irObligats;
        //         kurssArray[i - 1] = kurss;
        //     }
        //
        //     return kurssArray;
        // }

        public static StudijuKurss[] ReadArrayFromFile()
        {
            string PATH = @".\file.txt";

            StudijuKurss[] kurss = new StudijuKurss[2];

            using (StreamReader reader = new StreamReader(PATH))
            {
                string line;
                // while ((line = reader.ReadLine()) != null)
                // {
                //     string[] props = line.Split(',');
                //     foreach (string prop in props)
                //     {
                //         Console.WriteLine(prop);
                //     }
                //     // string nosaukums = parts[0];
                //     // int kreditpunkti = int.Parse(parts[1]);
                //     // int eKreditPunkti = int.Parse(parts[2]);
                //     // bool irObligats = bool.Parse(parts[3]);
                //
                //     StudijuKurss kurs = new StudijuKurss();
                //     // todo: add props to kurss i cba rn
                //     // list.Add(kurs);
                //     Console.WriteLine("END OF CYCLE");
                // }

                for (int i = -1; (line = reader.ReadLine()) != null; i++)
                {
                    string[] props = line.Split(',');

                    if (i!=-1)
                    {
                        Console.WriteLine($"CYCLE {i}");
                        // foreach (string prop in props)
                        // {
                        //     Console.WriteLine(prop);
                        // }

                        kurss[i] = new StudijuKurss();
                        kurss[i].Nosaukums = props[i];
                    }
                }
            }

            return kurss;
        }

        
        public static void Main(string[] args)
        {
            StudijuKurss[] kurss = new StudijuKurss[2];
            for (int i = 0; i < kurss.Length; i++)
            {
                kurss[i] = new StudijuKurss();
                kurss[i].ReadData();
            }

            //kurss[0].PrintData();

            StudijuKurss[] jaunsKurss = new StudijuKurss[2];
            PrintArrayToFile(kurss);
            StudijuKurss[] meow = ReadArrayFromFile();
            foreach (var h in meow)
            {
                Console.WriteLine("START OF CYCLE");
                Console.WriteLine($"nosaukums: {h.Nosaukums}");
                Console.WriteLine($"kred: {h.Kreditpunkti}");
                Console.WriteLine($"ekred: {h.EKreditPunkti}");
                Console.WriteLine($"obl: {h.IrObligats}");
            }
        }
    }
}