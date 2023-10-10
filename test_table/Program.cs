using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dashes = new string('-', 82);
            for (int i = 0; i <=10; i++)
            {
                if (i == 0)
                {
                    Console.Write("y/x\t|");
                    for (int j = 1; j <=10; j++)
                    {
                        Console.Write($"{j}\t");
                    }
                    Console.Write($"\n{dashes}\n");
                }

                else
                {
                    Console.Write($"{i}\t|");
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write($"{j * i} \t");
                    }
                    Console.Write("\n");
                }
                
            }
        }
    }
}
