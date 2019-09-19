using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CSharp_Project
{
    class Students
    {
        public static void runExercise2()
        {
            Console.WriteLine("Enter number of students to grade: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            string[] studentNames = new string[numberOfStudents];
            int[] studentGrades = new int[numberOfStudents];

            for(int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Enter name of student {0}: ", i + 1);
                studentNames[i] = Console.ReadLine();
                Console.WriteLine("Enter grade of student {0}: ", i + 1);
                studentGrades[i] = int.Parse(Console.ReadLine());
            }

            int[] sortedGrades = new int[numberOfStudents];
            studentGrades.CopyTo(sortedGrades, 0);
            Array.Sort(sortedGrades);
            Array.Reverse(sortedGrades);

            int highestGrade = sortedGrades[0];
            Console.WriteLine("The highest grade was {0}", highestGrade);
            int indexOfHighest = Array.IndexOf(studentGrades, highestGrade);
            Console.WriteLine("This was achieved by {0}", studentNames[indexOfHighest]);

            double total = 0;
            double average = 0;
            foreach (int grade in studentGrades)
            {
                total += grade;
                average = total / numberOfStudents;
            }
            Console.WriteLine("The average grade in the class is {0}", average);
        }
    }
}
