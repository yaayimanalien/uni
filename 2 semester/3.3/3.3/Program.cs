using System;
using System.Threading;

namespace _3._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ievadi vārdu ko atskaņot morzas kodā: ");
            string input = Console.ReadLine();
            Console.WriteLine(ConvertToMorse(input));
            Play(ConvertToMorse(input));
        }

        static string ConvertToMorse(string text)
        {
            string result = "";
            
            foreach (char c in text)
            {
                switch (char.ToUpper(c))
                {
                    case 'A':
                        result += ".- ";
                        break;
                    case 'B':
                        result += "-... ";
                        break;
                    case 'C':
                        result += "-.-. ";
                        break;
                    case 'D':
                        result += "-.. ";
                        break;
                    case 'E':
                        result += ". ";
                        break;
                    case 'F':
                        result += "..-. ";
                        break;
                    case 'G':
                        result += "--. ";
                        break;
                    case 'H':
                        result += ".... ";
                        break;
                    case 'I':
                        result += ".. ";
                        break;
                    case 'J':
                        result += ".--- ";
                        break;
                    case 'K':
                        result += "-.- ";
                        break;
                    case 'L':
                        result += ".-.. ";
                        break;
                    case 'M':
                        result += "-- ";
                        break;
                    case 'N':
                        result += "-. ";
                        break;
                    case 'O':
                        result += "--- ";
                        break;
                    case 'P':
                        result += ".--. ";
                        break;
                    case 'Q':
                        result += "--.- ";
                        break;
                    case 'R':
                        result += ".-. ";
                        break;
                    case 'S':
                        result += "... ";
                        break;
                    case 'T':
                        result += "- ";
                        break;
                    case 'U':
                        result += "..- ";
                        break;
                    case 'V':
                        result += "...- ";
                        break;
                    case 'W':
                        result += ".-- ";
                        break;
                    case 'X':
                        result += "-..- ";
                        break;
                    case 'Y':
                        result += "-.-- ";
                        break;
                    case 'Z':
                        result += "--.. ";
                        break;
                    default:
                        result += c;
                        break;
                }
            }

            return result;
        }

        static void Play(string morse)
        {
            foreach (char c in morse)
            {
                if (c == '.')
                {
                    Console.Beep(1000, 100);
                }
                else if (c == '-')
                {
                    Console.Beep(1000,200);
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }
    }
}