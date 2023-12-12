using System;


namespace prakt_d_14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            bool loopStop = false;

            while (loopStop == false)
            {
                Console.Write("1 - atņemšana\n2 - saskaitīšana\n3 - reizināšana\n4 - dalīšana\n0 - iziet\n\nJūsu izvēle: ");
                int decision = int.Parse(Console.ReadLine());

                switch (decision)
                {
                    case 0:
                        loopStop = true;
                        break;
                    case 1:
                        Console.Write("Cik piemērus rēķināsiet: ");
                        int count1 = int.Parse(Console.ReadLine());


                        for (int i = 1; i <= count1; i++)
                        {
                            int sk1 = r.Next(1, 10);
                            int sk2 = r.Next(1, 10);

                            Sub(sk1, sk2);
                        }

                        break;
                    case 2:
                        Console.Write("Cik piemērus rēķināsiet: ");
                        int count2 = int.Parse(Console.ReadLine());
                        
                        for (int i = 1; i <= count2; i++)
                        {
                            int sk1 = r.Next(1, 10);
                            int sk2 = r.Next(1, 10);

                            Sum(sk1, sk2);
                        }
                        
                        break;
                    case 3:
                        Console.Write("Cik piemērus rēķināsiet: ");
                        int count3 = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= count3; i++)
                        {
                            int sk1 = r.Next(1, 10);
                            int sk2 = r.Next(1, 10);
                            Mult(sk1, sk2);
                        }

                        break;
                    case 4:
                        Console.Write("Cik piemērus rēķināsiet: "); 
                        int count4 = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= count4; i++)
                        {
                            int sk1 = r.Next(1, 10);
                            int sk2 = r.Next(1, 10);
                            Div(sk1, sk2);
                        }
                        break;
                }

            }
        }

        static void Sub(int sk1, int sk2)
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
                    Console.WriteLine("Rezultāts ievadīts nepareizi");
                }
            
        }
        
        
        static void Div(int sk1, int sk2)
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
                    Console.WriteLine("Rezultāts ievadīts nepareizi");
                }
            
        }
    }
}