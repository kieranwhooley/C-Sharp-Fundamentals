using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            bool keepAsking = true;
            
            while(keepAsking)
            {
                Console.WriteLine("Please enter an integer:");
                bool validInput = int.TryParse(Console.ReadLine(), out int enteredInteger);

                if (validInput)
                {
                    Console.WriteLine("{0} squared is: {1}", enteredInteger, Square(enteredInteger));
                    Console.WriteLine("{0} cubed is:   {1}", enteredInteger, Cubed(enteredInteger));
                    Console.Read();
                    keepAsking = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }
        }

        public static int Square(int number)
        {
            int squared = number * number;
            return squared;
        }

        private static int Cubed(int number)
        {
            int cubed = Square(number) * number;
            return cubed;
        }
    }
}

