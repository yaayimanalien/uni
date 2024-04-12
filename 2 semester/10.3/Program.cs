using System;

namespace _10._3
{
    internal class Program
    {
        static int ParaSkaitluSumma(int[] mas, out int paraSkaitluSkaits)
        {
            int summa = 0;
            paraSkaitluSkaits = 0;
            
            for (int i = 0; i < mas.Length; i++)
            {
                summa += mas[i];
                if (mas[i] %2 == 0)
                {
                    paraSkaitluSkaits++;
                }
            }

            return summa;
        }
        
        public static void Main(string[] args)
        {
            int[] skaitli = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int skaits;
            int summa = ParaSkaitluSumma(skaitli, out skaits);
            Console.WriteLine($"Skaitļu summa: {summa}\tPāra skaitļu skaits: {skaits}");
        }
    }
}