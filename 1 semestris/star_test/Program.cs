using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ieraksti iterāciju daudzumu: ");
            int garums = int.Parse(Console.ReadLine());

            int a = 1;
            while (a <= garums)
            {
                int b = 1;
                while (b <= a)
                {
                    Console.Write('*');
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}
