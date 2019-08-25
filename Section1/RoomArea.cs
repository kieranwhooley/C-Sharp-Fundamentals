using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class RoomArea
    {
        public static void runExercise2()
        {
            const double costPerSqFt = 15;
            Console.WriteLine("Please type in width of room");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please type in length number");
            double length = double.Parse(Console.ReadLine());
            double area = width * length;
            double cost = area * costPerSqFt;
            Console.WriteLine("Area of room is: {0} \nCost is therefore: ${1} (Area * ${2} per square foot", area, cost, costPerSqFt);
        }
    }
}