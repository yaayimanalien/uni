using System;

namespace _10._2
{
    public class MansMath
    {
        public static double Min(params double[] x)
        {
            double min = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                }
            }
            return min;
        }

        public static double Max(params double[] x)
        {
            double max = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
            }
            return max;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] s = {5, 6, 7, 8};
            Console.WriteLine(MansMath.Min(s));
            Console.WriteLine(MansMath.Max(s));
        }
    }
}