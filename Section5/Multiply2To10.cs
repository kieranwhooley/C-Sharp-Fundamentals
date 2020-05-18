using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            bool keepAsking = true;
            
            while (keepAsking)
            {
                Console.WriteLine("Please enter a number:");
                bool validInput = int.TryParse(Console.ReadLine(), out int number);
                if (validInput)
                {
                    Console.Clear();
                    Multiply2To10(number);
                    keepAsking = false;
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter an integer");
                }
            }
            Console.ReadLine();
        }

        public static void Multiply2To10(int number)
        {
            for (int i = 2; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }
    }
}

