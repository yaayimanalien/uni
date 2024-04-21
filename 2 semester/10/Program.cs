using System;

namespace _10
{
    class Calculator
    {
        public void Kapinat(ref double x)
        {
            x = Math.Pow(x, -(1.0 / x));
        }

        public void Reizinasa(ref double x, ref double y)
        {
            x = x * y;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            
            double x;
            Console.Write("X: ");
            string _input_x = Console.ReadLine();
            
            if (double.TryParse(_input_x, out x))
            {
                
            }
            else
            {
                Console.WriteLine("Ievadītā vērtība nav skaitlis. Lūdzu mēģiniet vēlreiz.");
                return;
            }

            double y;
            Console.Write("Y: ");
            string _input_y = Console.ReadLine();
            
            if (double.TryParse(_input_y, out y))
            {
                
            }
            else
            {
                Console.WriteLine("Ievadītā vērtība nav skaitlis. Lūdzu mēģiniet vēlreiz.");
                return;
            }

            calc.Kapinat(ref x);
            Console.WriteLine($"Kapinājums: {x}");
            
            calc.Reizinasa(ref x, ref y);
            Console.WriteLine($"Reizinājums: {x}");
        }
    }
}