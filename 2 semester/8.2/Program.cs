using System;

namespace _9._2
{
    struct structTest
    {
        public int x;

        public void method()
        {
            Console.WriteLine("hello :)");
        }
    }

    class classTest
    {
        public int x;

        public void method()
        {
            Console.WriteLine("hello :)");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            classTest[] classTests = new classTest[5];
            for (int i = 0; i < classTests.Length; i++)
            {
                if (classTests[i] != null)
                {
                    classTests[i] = new classTest();
                    classTests[i].method();
                }
            }
            
            structTest[] structTests = new structTest[5];
            for (int i = 0; i < structTests.Length; i++)
            {
                if (structTests[i] != null)
                {
                    structTests[i] = new structTest();
                    structTests[i].method();
                }
            }
            
            classTest[] test = new classTest[5];
            for (int i = 0; i < test.Length; i++)
            {
                // if (test[i].x == 0)
                // {
                //     Console.Write($"Klases vērtība {i} ir ");
                //     test[i] = new classTest();
                //     test[i].method();
                // }
            }
            
            structTest[] structTest = new structTest[5];
            for (int i = 0; i < structTest.Length; i++)
            {
                // if (structTest[i].x != null)
                // {
                //     Console.Write($"Struktūras vērtība {i} ir ");
                //     structTest[i] = new structTest();
                //     structTest[i].method();
                }
                if (true)
                {
                    
                }
            }
        }
    }
}