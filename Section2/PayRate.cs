using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class PayRate
    {
        public static void runExercise1()
        {

            Console.Write("Enter hourly pay rate: ");
            double rate = double.Parse(Console.ReadLine());
            if (rate < 7.50 || rate > 49)
            {
                Console.WriteLine("Error: Invalid pay rate entered");
            }
            else
            {
                Console.WriteLine("Rate entered {0} is okay", rate);
            }

        }
    }
}
