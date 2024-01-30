using System;

namespace csh.prakt.d_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Pirmais uzdevums

            int A = 5;
            int B = 4;

            Console.WriteLine("Skaitlis A = " + A);
            Console.WriteLine("Skaitlis B = " + B);

            Console.WriteLine("Operācijas reizināšana darbība: " + (A) + " * " + (B) + " = " + (A * B)); 
            Console.WriteLine("Operācijas atņemt darbība: " + (A) + " - " + (B) + " = " + (A - B)); 
            Console.WriteLine("Operācijas summa darbība: " + (A) + " + " + (B) + " = " + (A + B)); 
            Console.WriteLine("Operācijas dalīt darbība: " + (A) + " / " + (B) + " = " +  + ((double)A / B));

            // Otrais uzdevums

            double R = 2.4;
            double pi = 3.1415926;

            Console.WriteLine("Rādiuss R = " + R);
            Console.WriteLine("Riņķa Līnijas Garums = " + (2*pi*R));
            Console.WriteLine("Riņķa Laukums = " + (pi * R * R));
            Console.WriteLine("Lodes Laukums = " + (4 * pi * (R * R)));
            Console.WriteLine("Lodes Tilpums = " + (4 * pi * (R * R * R)) / 3);


        }
    }
}
