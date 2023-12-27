using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_2_uzd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet masiva izmeru: ");
            double[] arr = new double[int.Parse(Console.ReadLine())];
            Console.Write("Ievadiet x: ");
            double x = int.Parse(Console.ReadLine());

            Console.WriteLine("Masivs:");
            for (int i = 1; i <= arr.Length; i++)
            {
                // Console.WriteLine($"x={x}, i={i}, pow={Math.Pow(x, i)}");
                arr[i - 1] = (Math.Pow(x, i));
                Console.Write($"{arr[i-1]} ");

                // Console.WriteLine(i);
            }
        }
    }
}
