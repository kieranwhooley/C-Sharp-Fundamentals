using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RefOutParams
{
    class Program
    {
        public static void Main(string[] args)
        {
            //out keyword
            SubtractAndDivide(50, 10, out double subtract, out double divide);
            Console.WriteLine(subtract);
            Console.WriteLine(divide);

            //ref keyword
            int number = 75;
            IncreaseNumber(ref number);
            Console.WriteLine(number);
            
            //params keyword
            int[] myArray = { 1, 2, 3, 4, 5 };
            PrintArray(myArray);
            PrintArray(6, 7, 8, 9, 10);
            Console.Read();
        }

        public static void SubtractAndDivide(double a, double b, out double subtracted, out double divided)
        {
            subtracted = a - b;
            divided = a / b;
        }

        public static void IncreaseNumber(ref int number)
        {
            number += 5;
        }

        public static void PrintArray(params int[] anArray)
        {
            foreach (int i in anArray)
            {
                Console.WriteLine(i);
            }
        }

    }
}

