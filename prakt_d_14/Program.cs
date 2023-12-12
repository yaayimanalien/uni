using System;


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
                        Sub(random);
                        break;
                    case 2:
                        Sum(random);
                        break;
                    case 3:
                        Mult(random);
                        break;
                    case 4:
                        Div(random);
                        break;
                }

            }
        }

        static void Sub(Random r)
        {
            Console.Write("Cik piemērus rēķināsiet: ");
            int count = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= count; i++)
            {
                int sk1 = r.Next(1, 10);
                int sk2 = r.Next(1, 10);
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
        
        static void Sum(Random r)
        {
            Console.Write("Cik piemērus rēķināsiet: ");
            int count = int.Parse(Console.ReadLine());
        
            for (int i = 1; i <= count; i++)
            {
                int sk1 = r.Next(1, 10);
                int sk2 = r.Next(1, 10);
                Console.Write($"{sk1} + {sk2} = ");
                int input = int.Parse(Console.ReadLine());
                if (sk1 + sk2 == input)
                {
                    Console.WriteLine("Rezultāts ievadīts pareizi");
                }
                else
                {
                    Console.WriteLine("Rezultāts ievadīts nepareizi");
                }
            }
        }
        
        
        static void Div(Random r)
        {
            Console.Write("Cik piemērus rēķināsiet: ");
            int count = int.Parse(Console.ReadLine());
        
            for (int i = 1; i <= count; i++)
            {
                int div1 = r.Next(1, 10);
                int div2 = r.Next(1, 10);
                int rez = div1 * div2;
                
                Console.Write($"{rez} / {div1} = ");
                int input = int.Parse(Console.ReadLine());
                if (rez / div1 == input)
                {
                    Console.WriteLine("Rezultāts ievadīts pareizi");
                }
                else
                {
                    Console.WriteLine("Rezultāts ievadīts nepareizi");
                }
            }
        }
        
        static void Mult(Random r)
        {
            Console.Write("Cik piemērus rēķināsiet: ");
            int count = int.Parse(Console.ReadLine());
        
            for (int i = 1; i <= count; i++)
            {
                int sk1 = r.Next(1, 10);
                int sk2 = r.Next(1, 10);
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