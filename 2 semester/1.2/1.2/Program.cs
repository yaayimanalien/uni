using System;

namespace _1._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 2. uzd
            Console.WriteLine("=== 2. uzdevums ===");

            string word = "algoritms";
            bool loopStop = false;
            int tries = 0;
            string letter = "";

            bool[] guessedLetters = new bool[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                guessedLetters[i] = false;
            }
            while (loopStop == false)
            {
                tries++;
                int correctLetters = 0;
                string displayWord = "";
                
                
                for (int i = 0; i < word.Length; i++)
                {
                    if (letter == char.ToString(word[i]))
                    {
                        guessedLetters[i] = true;
                    }

                    if (guessedLetters[i])
                    {
                        displayWord += word[i];
                    }
                    else
                    {
                        displayWord += "_";
                    }
                }
                
                Console.WriteLine(displayWord);
                
                for (int i = 0; i < guessedLetters.Length; i++)
                {
                    if (guessedLetters[i] == true)
                    {
                        correctLetters++;
                    }
                }
                if (correctLetters == guessedLetters.Length)
                {
                    Console.WriteLine($"Vārds uzminēts pareizi ar mēģinājumu skaitu {tries}");
                    loopStop = true;
                }

                Console.Write("\nIevadi burtu: ");
                letter = Console.ReadLine();
            }
        }
    }
}