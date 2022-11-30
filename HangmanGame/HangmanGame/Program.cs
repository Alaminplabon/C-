using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;

namespace HangmanGame
{
    internal class Program
    {

        private static void printHangman(int worng)
        {
            if(worng == 0)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if(worng == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (worng == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (worng == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (worng == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("     |");
                Console.WriteLine("   ===");

            }
            else if (worng == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("/ \\   |");
                Console.WriteLine("   ===");
            }
            else if (worng == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("/ \\   |");
                Console.WriteLine("   ===");
            }

        }

        private static int printword(List<char>guessedLetters,string randomWord)
        {
            int count = 0;
            int rightLetters=0;
            Console.Write("\r\n");
            foreach(char c in randomWord)
            {
                if(guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters++;
                }
                else
                {
                    Console.Write(" ");
                }
                count++;
            }
            return rightLetters;
        }
        private static void printlines(string randomWord)
        {
            Console.Write("\r");
            foreach(char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("\u0305 ");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hangman");
            Console.WriteLine("--------------------------------");

            Random random = new Random();
            List<string>wordDictionary=new List<string> { "ulab","aiub","nsu","iubat","uiu","aib"};
            int index= random.Next(wordDictionary.Count);
            String randomWord = wordDictionary[index];

            foreach(char x in randomWord)
            {
                Console.Write("- ");
            }
            int lengthofWordToGuess = randomWord.Length;
            int amountoftimewrong = 0;
            List<char>currentLetterGuessed = new List<char>();
            int currectLetter = 0;
            while(amountoftimewrong !=6 && currectLetter != lengthofWordToGuess)
            {
                Console.Write("\n Letter Guessed : ");
                foreach(char letter in currentLetterGuessed)
                {
                    Console.Write(letter + " ");
                }
                Console.Write("\nGuess a Letter : ");
                Char letterGuessed = Console.ReadLine()[0];
                if(currentLetterGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\nYou have already guessed this letter. ");
                    printHangman(amountoftimewrong);
                    currectLetter = printword(currentLetterGuessed,randomWord);
                    printlines(randomWord);
                }
                else
                {
                    bool right = false;
                    for(int i = 0; i < randomWord.Length; i++)
                    {
                        if(letterGuessed==randomWord[i])
                        {
                            right = true;
                        }
                        if(right)
                        {
                            printHangman(amountoftimewrong);
                            currentLetterGuessed.Add(letterGuessed);
                            currectLetter=printword(currentLetterGuessed,randomWord);
                            Console.Write("\r\n");
                            printlines(randomWord);
                        }
                        else
                        {
                            amountoftimewrong++;
                            currentLetterGuessed.Add(letterGuessed);
                            printHangman(amountoftimewrong);
                            currectLetter = printword(currentLetterGuessed, randomWord);
                            Console.Write("\r\n");
                            printlines(randomWord);

                        }
                    }
                }
                Console.WriteLine("\r\nThe game is over");
            }

        }
    }
}
