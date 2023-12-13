using System;

namespace prakt_d_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool loopStop = false;
            int count1;

            while (!loopStop)
            {
                Console.Write("1 - atņemšana\n2 - saskaitīšana\n3 - reizināšana\n4 - dalīšana\n0 - iziet\n\nJūsu izvēle: ");
                int decision = int.Parse(Console.ReadLine());

                switch (decision)
                {
                    case 0:
                        loopStop = true;
                        break;
                    default:
                        Console.Write("Cik piemērus rēķināsiet: ");
                        count1 = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= count1; i++)
                        {
                            int sk1, sk2;

                            switch (decision)
                            {
                                case 1:
                                    sk1 = r.Next(1, 10);
                                    sk2 = r.Next(1, 10);
                                    Sub(sk1, sk2);
                                    break;
                                case 2:
                                    sk1 = r.Next(1, 10);
                                    sk2 = r.Next(1, 10);
                                    Sum(sk1, sk2);
                                    break;
                                case 3:
                                    sk1 = r.Next(1, 10);
                                    sk2 = r.Next(1, 10);
                                    Mult(sk1, sk2);
                                    break;
                                case 4:
                                    sk1 = r.Next(1, 10);
                                    sk2 = r.Next(1, 10);
                                    Div(sk1, sk2);
                                    break;
                            }
                        }
                        break;
                }
            }
        }


        static void Sub(int sk1, int sk2)
        {
            Console.Write($"{sk1} - {sk2} = ");
            int input = int.Parse(Console.ReadLine());
            if (sk1 - sk2 == input)
            {
                Console.WriteLine("Rezultāts ievadīts pareizi");
            }
            else
            {
                Console.WriteLine($"{sk1}-{sk2}={sk1 - sk2}");
            }
        }

        static void Sum(int sk1, int sk2)
        {
            Console.Write($"{sk1} + {sk2} = ");
            int input = int.Parse(Console.ReadLine());
            if (sk1 + sk2 == input)
            {
                Console.WriteLine("Rezultāts ievadīts pareizi");
            }
            else
            {
                Console.WriteLine($"{sk1}+{sk2}={sk1 + sk2}");
            }
        }

        static void Div(int div1, int div2)
        {
            int rez = div1 * div2;
            Console.Write($"{rez} / {div1} = ");
            int input = int.Parse(Console.ReadLine());
            if (rez / div1 == input)
            {
                Console.WriteLine("Rezultāts ievadīts pareizi");
            }
            else
            {
                Console.WriteLine($"{rez}/{div1}={div2}");
            }
        }

        static void Mult(int sk1, int sk2)
        {
            Console.Write($"{sk1} * {sk2} = ");
            int input = int.Parse(Console.ReadLine());
            if (sk1 * sk2 == input)
            {
                Console.WriteLine("Rezultāts ievadīts pareizi");
            }
            else
            {
                Console.WriteLine($"{sk1}*{sk2}={sk1 * sk2}");
            }
        }
    }
}
