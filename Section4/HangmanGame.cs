using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HangmanGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            //make an array of words
            string[] wordList = { "keyboard", "elephant", "kettle", "sycamore", "credenza", "moustache", "connection", "language" };
            
            //pick one of the words at random
            Random rand = new Random();
            int chosenWordPostion = rand.Next(7);
            string chosenRandomWord = wordList[chosenWordPostion];

            //Console.WriteLine(chosenRandomWord);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Hangman!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("(You can have up to 5 incorrect guesses)");

            //split that word into an array of characters
            char[] individualLetters = chosenRandomWord.ToCharArray();
            
            //make an array the same length as that with only * characters
            int lengthOfRandomWord = chosenRandomWord.Length;
            char[] maskedLetters = new char[chosenRandomWord.Length];
            for (int i = 0; i < lengthOfRandomWord; i++)
            {
                maskedLetters[i] = '*';
            }
            //use a boolean to track if the word has been found
            bool keepGuessing = true;

            //limit the number of incorrect guesses allowed
            int numberOfGuesses = 0;

            //keep looping until the word is found or the guesses run out
            while (keepGuessing && numberOfGuesses < 6)
            {
                Console.WriteLine("Number of letters in the hidden word: {0}", lengthOfRandomWord);
                
                //print out the * array
                //if a letter is guessed correctly it will be printed in the array on the next iteration
                for (int i = 0; i < maskedLetters.Length; i++)
                {
                    Console.Write("{0} ", maskedLetters[i]);
                }
                Console.WriteLine();

                //enter a guess
                Console.WriteLine("Please enter a guess for a letter in the hidden word:");
                string userGuess = Console.ReadLine();
                bool validInput = char.TryParse(userGuess, out char guessedLetter);

                //check the input is a valid single letter
                if (!validInput)
                {
                    Console.WriteLine("Please enter a single letter per guess");
                    Console.ReadLine();
                    Console.Clear();
                } 
                //if input is valid check if the letter is in the word
                else
                {
                    for (int i = 0; i < individualLetters.Length; i++)
                    {
                        if (guessedLetter.Equals(individualLetters[i]))
                        {
                            maskedLetters[i] = individualLetters[i];
                            //check if all the * have been guessed successfully
                            if (!maskedLetters.Contains('*'))
                            {
                                keepGuessing = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Correct! The word was {0}!", chosenRandomWord);
                                Console.Read();
                            }
                        }
                    }
                    Console.Clear();

                    //output a message if the letter entered is not in the word
                    if (!individualLetters.Contains(guessedLetter))
                    {
                        Console.WriteLine("'{0}' is not in the word, please guess again!", guessedLetter);
                        numberOfGuesses++;
                        //if incorrect guesses run out output a message
                        if (numberOfGuesses > 5)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have run out of guesses! The word was '{0}'!", chosenRandomWord);
                            Console.Read();
                        }
                    }
                }
            }
        }
    }     
}
