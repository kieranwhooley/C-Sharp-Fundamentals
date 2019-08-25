using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class HoursMinutes
    {
        public static void runExercise3()
        {
            Console.WriteLine("Enter number of minutes: ");
            int minutesEntered = int.Parse(Console.ReadLine());
            int hours = minutesEntered / 60;
            int minutesLeft = minutesEntered % 60;
            Console.WriteLine("Minutes entered: {0} \nThis is {1} hours and {2} minutes", minutesEntered, hours, minutesLeft);
        }
    }
}
