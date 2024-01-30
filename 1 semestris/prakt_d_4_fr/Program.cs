using System;


namespace prakt_d_4_fr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. uzd.

            Console.WriteLine("Ievadiet skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());

            if (skaitlis % 2 != 0) {
                Console.WriteLine($"{skaitlis} - nepāra skaitlis");
            }

            else
            {
                Console.WriteLine($"{skaitlis} - pāra skaitlis");
            }

            // 2. uzd.

            Console.WriteLine("Ievadiet x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ievadiet y: ");
            double y = double.Parse(Console.ReadLine());

            if (x != 0 && y != 0)
            {
                Console.WriteLine($"Rezultāts = {x / y}");
            }

            else
            {
                Console.WriteLine("Dalīšana ar 0");
            }

            // 3. uzd.

            string vards = "Hello";
            Console.WriteLine("Ievadiet vārdu: ");
            string input = Console.ReadLine();

            if (input.Length != 5)
            {
                Console.WriteLine("Jābūt 5 simboliem");
            }

            else if (input != vards)
            {
                Console.WriteLine("Parole ievadīta nepareizi");
            }

            else
            {
                Console.WriteLine("Parole ievadīta pareizi");
            }

            // 4. uzd.

            Console.WriteLine("1 - Kvadrāta perimetra formulā\n2 - Kvadrāta laukuma formula\n3 - Kvadrāta diagonāles formula\n");
            Console.WriteLine("Ievadiet malu a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Izvēties darbību: ");
            int decision = int.Parse(Console.ReadLine());
            switch (decision)
            {
                case 1:
                    Console.WriteLine($"Kvadrāta perimetrs: {a * 4}");
                    break;
                case 2:
                    Console.WriteLine($"Kvadrāta laukums: {a * 2}");
                    break;
                case 3:
                    Console.WriteLine($"Kvadrāta diagonāle: {Math.Sqrt(a) * 2}");
                    break;
                default:
                    Console.WriteLine("Tādas darbības nav!");
                    break;
            }
        }
    }
}
