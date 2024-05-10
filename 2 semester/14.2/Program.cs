using System;
using System.IO;

namespace _14._2
{
    class coco
    {
        public static double? divide(double x, double y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Dalit ar nulli nav iespejams!!!");
                return null;
            }
        }

        public static int? stringToInt(string n)
        {
            try
            {
                return int.Parse(n);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Konvertesana neizdevas!");
                return null;
            }
        }

        public static void PrintFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Fails neeksiste!");
            }
        }

        public static void PrintValue(string[] arr, int i)
        {
            try
            {
                Console.WriteLine(arr[i]);
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.WriteLine("index ir out of range!!!");
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            coco.stringToInt(Console.ReadLine());
            coco.PrintFile(@"C:\Bakingsoda");
            string[] arr = new string[1];
            coco.PrintValue(arr, 9);
        }
    }
}