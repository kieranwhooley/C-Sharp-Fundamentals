using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class Delivery
    {
        public static void runExercise1()
        {
            string[] zipcodesForDelivery = { "M5K", "Q4E", "W4J", "M4K", "S4L", "O8K", "M4F", "D4J", "R4K", "R6L" };
            Console.WriteLine("Please enter zip code:");
            string zipcode = Console.ReadLine();
            bool validZipcode = false;

            for (int i = 0; i < zipcodesForDelivery.Length; i++)
            {
                if (zipcode == zipcodesForDelivery[i])
                {
                    validZipcode = true;
                    break;
                }
            } 

            if (validZipcode)
            {
                Console.WriteLine("We ARE able to deliver to {0}", zipcode);
            } else
            {
                Console.WriteLine("We ARE NOT able to deliver to {0}", zipcode);
            }
        }
    }
}
