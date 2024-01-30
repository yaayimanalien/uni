using System;

namespace _1._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 2. uzd
            Console.WriteLine("=== 2. uzdevums ===");

            string word = "amogus";
            bool loopStop = false;
            int tries = 0;
            string letter = "";
            bool[] guessedLetters = new bool[word.Length];

            while (loopStop == false)
            {
                // tries++;
                int correctLetters = 0;
                string displayWord = "";

                
                if (!string.IsNullOrEmpty(letter))
                {
                    bool wrongGuess = true;  

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (letter == char.ToString(word[i]))
                        {
                            guessedLetters[i] = true;
                            wrongGuess = false;  
                        }
                    }

                    if (wrongGuess)
                    {
                        Console.WriteLine("wrong!");
                    }
                }

                for (int i = 0; i < word.Length; i++)
                {
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
                    if (guessedLetters[i])
                    {
                        correctLetters++;
                    }
                }

                if (correctLetters == guessedLetters.Length)
                {
                    Console.WriteLine($"Vārds uzminēts pareizi ar mēģinājumu skaitu {tries}");
                    loopStop = true;
                    break;
                }

                Console.Write("\nIevadi burtu: ");
                letter = Console.ReadLine();
                tries++;
            }
        }
    }
}
