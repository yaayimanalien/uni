using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1stream
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // @path
            string path = "C:\\Users\\winter\\Desktop\\NEW TODO.txt";
            // StreamWriter stream = new StreamWriter(path);
            // stream.WriteLine("j");
            // stream.Close();
            StreamReader reader = new StreamReader(path);
            // reader.ReadLine();
            // reader.Close();
            List<string> lines = new List<string>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            foreach (string uwu in lines)
            {
                Console.WriteLine(uwu);
            }
        }
    }
}