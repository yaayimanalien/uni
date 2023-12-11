using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool breakLoop = false;
            while (breakLoop == false)
            {
                Console.WriteLine("0 - iziet\n1 - Budžeta pamatsummas ievadīšana\n2 - budžeta noguldīšana\n3 - budžeta pamatsummas palielināšana\n5 - budžeta samazinājums\n\nIzvēlies darbību: ");
                string decision = Console.ReadLine();
                switch (decision)
                {
                    case "0":
                        breakLoop = true;
                        break;
                }
            }
        }

        static void procenti()
        {
            // iepriekš kkad tika darīts
        }

        static void pluss()
        {

        }

        static void minuss()
        {

        }
    }
}
