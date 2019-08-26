using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class GuessRandomNumber
    {
        public static void runExercise3()
        {
            Random random = new Random();
            int randomNumber = random.Next(10);
            //Console.WriteLine(randomNumber);
            int guess;
            int numberOfGuesses = 0;

            do
            {
                Console.Write("Guess a number between 1 and 10: ");
                guess = int.Parse(Console.ReadLine());

                if (guess == randomNumber)
                {
                    Console.WriteLine("Correct! The number was: {0}", randomNumber);
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Guess is too low!");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Guess is too high!");
                }
                numberOfGuesses++;
            } while (guess != randomNumber);

            Console.WriteLine("It took you {0} attempts to get it!", numberOfGuesses);
        }
    }
}
