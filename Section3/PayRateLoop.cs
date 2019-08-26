using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class PayRateLoop
    {
        public static void runExercise1()
        {
            double payRate;

            do
            {
                Console.WriteLine("Enter a valid hourly pay rate");
                payRate = double.Parse(Console.ReadLine());
            } while (payRate < 5.65 || payRate > 49.99);

            Console.WriteLine("Hourly pay rate entered: ${0}", payRate);
        }
    }
}
