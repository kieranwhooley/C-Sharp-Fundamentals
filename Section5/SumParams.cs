using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayOfIntegers1 = { 1 };
            int[] arrayOfIntegers2 = { 1, 2, 3 };
            int[] arrayOfIntegers3 = { 1, 2, 3, 4, 5 };
            int[] arrayOfIntegers4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum1 = Sum(arrayOfIntegers1);
            int sum2 = Sum(arrayOfIntegers2);
            int sum3 = Sum(arrayOfIntegers3);
            int sum4 = Sum(arrayOfIntegers4);

            Console.WriteLine("{0}, {1}, {2}, {3}", sum1, sum2, sum3, sum4);

            Console.WriteLine(Sum(4, 5));
            Console.Read();
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}

