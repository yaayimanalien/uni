using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apvienojums = "YourMainString";
            string rinda = Console.ReadLine();

            int reizes = 0;

            for (int i = 0; i <= apvienojums.Length - rinda.Length; i++)
            {
                string buffer = "";
                for (int j = i; j < rinda.Length + i; j++)
                {
                    buffer += apvienojums[j];
                }
                if (buffer == rinda)
                {
                    reizes++;
                }
            }

            Console.WriteLine(reizes);

        }
    }
}
