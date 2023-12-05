using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_d_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 - atņemšana\n2 - saskaitīšana\n3 - reizināšana\n4 - dalīšana\n0 - iziet");
            int decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 0:
                    break;
                case 1:
                    sum();
                    break;
            }
        }

        static void sum()
        {
            Console.Write("Cik piemērus rēķināsiet: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i < count; i++)
            {
                
            }
        }

        static void sub()
        {

        }

        static void div()
        {

        }

        static void mult()
        {

        }
    }
}
