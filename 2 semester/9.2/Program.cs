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
            // classTest[] test = new classTest[5];
            // for (int i = 0; i < test.Length; i++)
            // {
            //     if (test[i] != null)
            //     {
            //         test[i] = new classTest();
            //         test[i].method();
            //     }
            // }
            //
            // structTest[] structs = new structTest[5];
            // for (int i = 0; i < structs.Length; i++)
            // {
            //     if (structs[i] != null)
            //     {
            //         test[i] = new classTest();
            //         structs[i].method();
            //     }
            // }
            
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
                // }
                if (true)
                {
                    where 
                }
            }
        }
    }
}