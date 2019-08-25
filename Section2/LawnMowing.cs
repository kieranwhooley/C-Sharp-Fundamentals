using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class LawnMowing
    {
        public static void runExercise2()
        {
            //Get area of lawn
            Console.WriteLine("Enter width of garden lawn:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of garden lawn:");
            double length = double.Parse(Console.ReadLine());
            double areaOfLawn = width * length;

            //Check cost by area and print out
            if (areaOfLawn < 400)
            {
                Console.WriteLine("Lawn size: {0}\nCost per week: ${1}\nTotal cost for 20 week season: ${2}", areaOfLawn, "$25", (25 * 20));
            }
            else if (areaOfLawn >= 400 && areaOfLawn < 600)
            {
                Console.WriteLine("Lawn size: {0}\nCost per week: ${1}\nTotal cost for 20 week season: ${2}", areaOfLawn, "$35", (35 * 20));
            }
            else if (areaOfLawn >= 600)
            {
                Console.WriteLine("Lawn size: {0}\nCost per week: ${1}\nTotal cost for 20 week season: ${2}", areaOfLawn, "$50", (50 * 20));
            }
        }
    }
}
