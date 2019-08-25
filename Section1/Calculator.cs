using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class Calculator
    {
        public static void runExercise1()
        {
            Console.WriteLine("Please type in first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type in second number");
            int number2 = int.Parse(Console.ReadLine());
            int total = number1 + number2;
            Console.WriteLine("The numbers you entered were {0} and {1} which add up to: {2}", number1, number2, total);
        }
    }

}
