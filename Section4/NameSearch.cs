using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class NameSearch
    {
        public static void searchForName()
        {
            string[] students = { "Jim", "Joe", "Jack" };
            int[] grades = { 100, 76, 83 };

            Console.WriteLine("Enter name to search for:");
            string nameToSearchFor = Console.ReadLine();
            bool inList = false;
            int studentGrade = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == nameToSearchFor)
                {
                    inList = true;
                    studentGrade = grades[i];
                    break;
                }
            }

            if (inList == true)
            {
                Console.WriteLine("{0} is in the list and their grade is {1}", nameToSearchFor, studentGrade);
            }
            else
            {
                Console.WriteLine("{0} is not in the list", nameToSearchFor);
            }
        }
    }
}
