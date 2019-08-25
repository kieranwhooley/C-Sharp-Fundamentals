using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class RandomNumber
    {
        public static void runExercise3()
        {
            Random random = new Random();
            int randomNumber = random.Next(10);
            Console.WriteLine(randomNumber);

            Console.WriteLine("I am thinking of a number between 1 and 10. See if you can guess what it is!\nEnter guess: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == randomNumber)
            {
                Console.WriteLine("You guessed correctly! It was {0}!", randomNumber);
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Your guess was too low!");
            }
            else
            {
                Console.WriteLine("Your guess was too high!");
            }

        }
    }
}
