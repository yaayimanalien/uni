﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. uzd.

            int a = 34; 
            int b = 56; 
            Console.WriteLine("a= " + a); 
            Console.Write("b= {0}\n", b);

            Console.Write("Ievadiet a ");
            a = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Ievadiet b ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a= {0}\tb= {1}", a, b); 

            int saskaitisana = a + b;

            Console.WriteLine("a+b=" + saskaitisana);

            int atnemsana = a - b;
            Console.WriteLine("a-b= " + atnemsana);

            int reziniasana = a * b;
            Console.WriteLine("a*b= " + reziniasana);


            float dalisana1;
            dalisana1 = a / b; 

            Console.WriteLine("a/b= " + dalisana1);
            dalisana1 = a % b;
            dalisana1 = (float)a / b; 
            Console.WriteLine("a/b= " + dalisana1);

            int kvadratskaitlis = a * a + b * b;
            Console.WriteLine("a^2+b^2= " + kvadratskaitlis);



            // 2. uzd.

            Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10");
            Console.WriteLine("__________________________________________________________________________________");
            Console.WriteLine("1 |\t" + 1 * 1 + "\t" + 1 * 2 + "\t" + 1 * 3 + "\t" + 1 * 4 + "\t" + 1 * 5 + "\t" + 1 * 6 + "\t" + 1 * 7 + "\t" + 1 * 8 + "\t" + 1 * 9 + "\t" + 1 * 10 + "\t");
            Console.WriteLine("2 |\t" + 2 * 1 + "\t" + 2 * 2 + "\t" + 2 * 3 + "\t" + 2 * 4 + "\t" + 2 * 5 + "\t" + 2 * 6 + "\t" + 2 * 7 + "\t" + 2 * 8 + "\t" + 2 * 9 + "\t" + 2 * 10 + "\t");
            Console.WriteLine("3 |\t" + 3 * 1 + "\t" + 3 * 2 + "\t" + 3 * 3 + "\t" + 3 * 4 + "\t" + 3 * 5 + "\t" + 3 * 6 + "\t" + 3 * 7 + "\t" + 3 * 8 + "\t" + 3 * 9 + "\t" + 3 * 10 + "\t");
            Console.WriteLine("4 |\t" + 4 * 1 + "\t" + 4 * 2 + "\t" + 4 * 3 + "\t" + 4 * 4 + "\t" + 4 * 5 + "\t" + 4 * 6 + "\t" + 4 * 7 + "\t" + 4 * 8 + "\t" + 4 * 9 + "\t" + 4 * 10 + "\t");
            Console.WriteLine("5 |\t" + 5 * 1 + "\t" + 5 * 2 + "\t" + 5 * 3 + "\t" + 5 * 4 + "\t" + 5 * 5 + "\t" + 5 * 6 + "\t" + 5 * 7 + "\t" + 5 * 8 + "\t" + 5 * 9 + "\t" + 5 * 10 + "\t");
            Console.WriteLine("6 |\t" + 6 * 1 + "\t" + 6 * 2 + "\t" + 6 * 3 + "\t" + 6 * 4 + "\t" + 6 * 5 + "\t" + 6 * 6 + "\t" + 6 * 7 + "\t" + 6 * 8 + "\t" + 6 * 9 + "\t" + 6 * 10 + "\t");
            Console.WriteLine("7 |\t" + 7 * 1 + "\t" + 7 * 2 + "\t" + 7 * 3 + "\t" + 7 * 4 + "\t" + 7 * 5 + "\t" + 7 * 6 + "\t" + 7 * 7 + "\t" + 7 * 8 + "\t" + 7 * 9 + "\t" + 7 * 10 + "\t");
            Console.WriteLine("8 |\t" + 8 * 1 + "\t" + 8 * 2 + "\t" + 8 * 3 + "\t" + 8 * 4 + "\t" + 8 * 5 + "\t" + 8 * 6 + "\t" + 8 * 7 + "\t" + 8 * 8 + "\t" + 8 * 9 + "\t" + 8 * 10 + "\t");
            Console.WriteLine("9 |\t" + 9 * 1 + "\t" +  9* 2 + "\t" + 9 * 3 + "\t" + 9 * 4 + "\t" + 9 * 5 + "\t" + 9 * 6 + "\t" + 9 * 7 + "\t" + 9 * 8 + "\t" + 9 * 9 + "\t" + 9 * 10 + "\t");
            Console.WriteLine("10 |\t" + 10 * 1 + "\t" + 10 * 2 + "\t" + 10 * 3 + "\t" + 10 * 4 + "\t" + 10 * 5 + "\t" + 10 * 6 + "\t" + 10 * 7 + "\t" + 10 * 8 + "\t" + 10 * 9 + "\t" + 10 * 10 + "\t");

        }
    }
}
