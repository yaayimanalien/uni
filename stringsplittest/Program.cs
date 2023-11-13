using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsplittest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "helloworlds";
            int rem = 0;

            for (int i = 0; i < test.Length / 2; i++)
            {
                Console.Write(test[i]);
                rem++;
            }

            for (int i = rem; i < test.Length; i++)
            {
                Console.Write(test[i]);
            }
        }
    }
}
