using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class SumIntegers
    {
        public static void runExercise2()
        {
            Console.WriteLine("Enter a number to add all values up to together:");
            int number = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < number +1; i++)
            {
                total += i;
            }
            Console.WriteLine("Number entered was: {0}\nAdding all number up to this together is: {1}", number, total);
        }
    }
}
