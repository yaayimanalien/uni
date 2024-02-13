using System;
using System.Diagnostics;
using System.Linq;

namespace _3._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1. uzd
            Console.WriteLine("=== 1. uzdevums ===");
            double[] arr1 = new double[10];
            double[] arr2 = new double[10];
            Random random = new Random();

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(1, 9);
            }

            foreach (double num in arr1)
            {
                Console.Write($"{num}\t");
            }

            Console.Write("\n");
            
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = random.Next(1, 9);
            }
            
            foreach (double num in arr2)
            {
                Console.Write($"{num}\t");
            }
            
            Console.Write("\n");
            
            bool stop = false;

            while (stop == false)
            {
                Console.WriteLine("1 - Summēt\n2 - Atņemt\n3 - Reizināt\n4 - Dalīt\n5 - Vid aritm\n0 - iziet");
                Console.Write("Jūsu izvēle: ");
                int decision = int.Parse(Console.ReadLine());

                switch (decision)
                {
                    case 0:
                        stop = true;
                        break;
                    case 1:
                        Summet(arr1, arr2);
                        break;
                    case 2:
                        Atnemt(arr1, arr2);
                        break;
                    case 3:
                        Reizinat(arr1, arr2);
                        break;
                    case 4:
                        Dalit(arr1, arr2);
                        break;
                    case 5:
                        VidejaisAritmetiskais(arr1, arr2);
                        break;
                }
            }
        }

        public static void Summet(double[] double1, double[] double2)
        {
            double[] arr3 = new double[10];
            
            Console.Write("Rezultāts: ");
            for (int i = 0; i < double1.Length; i++)
            {
                arr3[i] = double1[i] + double2[i];
            }
            
            foreach (int num in arr3)
            {
                Console.Write($"{num} ");
            }
            Console.Write("\n");
        }
        
        public static void Atnemt(double[] double1, double[] double2)
        {
            double[] arr3 = new double[10];
            
            Console.Write("Rezultāts: ");
            for (int i = 0; i < double1.Length; i++)
            {
                arr3[i] = double1[i] - double2[i];
            }
            
            foreach (int num in arr3)
            {
                Console.Write($"{num} ");
            }
            
            Console.Write("\n");
        }
        
        public static void Reizinat(double[] double1, double[] double2)
        {
            double[] arr3 = new double[10];
            
            Console.Write("Rezultāts: ");
            for (int i = 0; i < double1.Length; i++)
            {
                arr3[i] = double1[i] * double2[i];
                
            }
            
            foreach (int num in arr3)
            {
                Console.Write($"{num} ");
            }
            
            Console.Write("\n");
        }
        
        public static void Dalit(double[] double1, double[] double2)
        {
            double[] arr3 = new double[10];
            
            Console.Write("Rezultāts: ");
            for (int i = 0; i < double1.Length; i++)
            {
                arr3[i] = double1[i] / double2[i];
            }
            
            foreach (double num in arr3)
            {
                Console.Write($"{num} ");
            }
            
            Console.Write("\n");
        }

        public static void VidejaisAritmetiskais(double[] double1, double[] double2)
        {
            double aritm1 = 0;
            double aritm2 = 0;
            
            for (int i = 0; i < double1.Length; i++)
            {
                aritm1 += double1[i];
                aritm2 += double2[i];
            }

            aritm1 = aritm1 / (double1.Length);
            aritm2 = aritm2 / (double2.Length);
            
            Console.WriteLine($"1. masīva vidējā aritmētiskā vērtība: {aritm1}");
            Console.WriteLine($"2. masīva vidējā aritmētiskā vērtība: {aritm2}");
            if (aritm1>aritm2)
            {
                Console.WriteLine($"1. masīva vid vērtība ir lielāka par 2. masīva vid vērtību par {aritm1-aritm2}");
            }
            if (aritm2 > aritm1)
            {
                Console.WriteLine($"2. masīva vid vērtība ir lielāka par 1. masīva vid vērtību par {aritm2-aritm1}");
            }
            // Console.WriteLine($"Abu masīvu vidējā aritmētiskā vērtība: {(aritm1 + aritm2) / (double1.Length*2)}");
        }
    }
}