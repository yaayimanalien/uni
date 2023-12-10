using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            bool loopStop = false;

            while (loopStop == false)
            {
                Console.Write("1 - atņemšana\n2 - saskaitīšana\n3 - reizināšana\n4 - dalīšana\n0 - iziet\n");
                int decision = int.Parse(Console.ReadLine());

                switch (decision)
                {
                    case 0:
                        loopStop = true;
                        break;
                    case 1:
                        sub(random.Next(1, 10), random.Next(1, 10));
                        break;
                    case 2:
                        sum(random.Next(1, 10), random.Next(1, 10));
                        break;
                    case 3:
                        mult(random.Next(1, 10), random.Next(1, 10));
                        break;
                    case 4:
                        div(random.Next(1, 10), random.Next(1, 10));
                        break;
                }

            }
        }

        static void sub(int sk1, int sk2)
        {
            Console.Write("Cik piemērus rēķināsiet: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{sk1} - {sk2} = ");
                int input = int.Parse(Console.ReadLine());
                if (sk1-sk2==input)
                {
                    Console.WriteLine("Rezultāts ievadīts pareizi");
                }
                else
                {
                    Console.WriteLine("Rezultāts ievadīts nepareizi");
                }
            }

        }

        static void sum(int sk1, int sk2)
        {
            Console.Write("Cik piemērus rēķināsiet: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{sk1} - {sk2} = ");
                int input = int.Parse(Console.ReadLine());
                if (sk1 - sk2 == input)
                {
                    Console.WriteLine("Rezultāts ievadīts pareizi");
                }
                else
                {
                    Console.WriteLine("Rezultāts ievadīts nepareizi");
                }
            }
        }


        static void div(int sk1, int sk2)
        {
            Console.Write("Cik piemērus rēķināsiet: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{sk1} / {sk2} = ");
                int input = int.Parse(Console.ReadLine());
                if (sk1 / sk2 == input)
                {
                    Console.WriteLine("Rezultāts ievadīts pareizi");
                }
                else
                {
                    Console.WriteLine("Rezultāts ievadīts nepareizi");
                }
            }
        }

        static void mult(int sk1, int sk2)
        {
            Console.Write("Cik piemērus rēķināsiet: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{sk1} * {sk2} = ");
                int input = int.Parse(Console.ReadLine());
                if (sk1 * sk2 == input)
                {
                    Console.WriteLine("Rezultāts ievadīts pareizi");
                }
                else
                {
                    Console.WriteLine("Rezultāts ievadīts nepareizi");
                }
            }
        }
    }
}
