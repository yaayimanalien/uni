using System;
using System.Collections.Generic;
using System.IO;

namespace anothertest
{
    public class prop
    {
        public string name;
        public string value;

        public prop(string _name, string _value)
        {
            name = _name;
            value = _value;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string filepath = "";
                foreach (string s in args)
                {
                    filepath += s;
                } 
            
                string PATH = $"{filepath}";
                
                StreamReader reader = new StreamReader(PATH);
                
                bool hasStarted = false;
                List<string> props = new List<string>();
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "---")
                    {
                        if (!hasStarted)
                        {
                            hasStarted = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        props.Add(line);
                    }
                }
    
                List<prop> meow = new List<prop>();
                
                foreach (string prop in props)
                {
                    // Console.WriteLine(prop);
                    string name = " ";
                    string value = " ";
                    int columnBreak = 0; // 0 = off; 1 = column; 2 = spacebar
                    foreach (char c in prop)
                    {
                        if (columnBreak == 0)
                        {
                            if (c == ':')
                            {
                                columnBreak = 1;
                            }
                            else
                            {
                                name += c;
                            }
                        }
    
                        if (columnBreak == 1)
                        {
                            if (c==' ')
                            {
                                columnBreak = 2;
                            }
                        }
    
                        if (columnBreak==2)
                        {
                            value += c;
                        }
                    }
                    meow.Add(new prop(name, value));
                }
    
    
                Console.WriteLine("Name\t\t\t\t\tValue");
                foreach (var prop in meow)
                {
                    Console.Write($"{prop.name}\t\t\t\t\t{prop.value}\n");
                }
            }
            catch(ArgumentException)
            {
                // throw FileNotFoundException;
                Console.WriteLine("No path provided.");
                Console.WriteLine("USEAGE: anothertest.exe [path_to_entry.md]");
            }
            
            
            
        }

        public static Exception FileNotFoundException { get; set; }
    }
}