using System.Runtime.InteropServices;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace _4._1_fr
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ievadi skaitli:");
            Console.WriteLine($"Ciparu summa ir {Sum((Console.ReadLine()))}");
        }

        public static int Sum(string sk)
        {
            int i = 1;
            int sum = 0;
            
            while (i<sk.Length)
            {
                sum = sum + sk[i];
            }
            return sum;
        }
        
    }
}