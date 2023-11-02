using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet simbolu rindu");

            for (int i = 0; i < 10; i++)
            {
                char s = Console.ReadKey().KeyChar;
                byte[] ASCIIValues = Encoding.ASCII.GetBytes(new char[] { s });


                foreach (byte b in ASCIIValues)
                {
                    Console.WriteLine($"={b}\n");
                }

            }
            
        }
    }
}
