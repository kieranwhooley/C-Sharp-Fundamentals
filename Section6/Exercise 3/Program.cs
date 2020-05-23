using System;

namespace Section6
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job("Washing", 5, 10);
            Job job2 = new Job("Painting", 10, 20);
            Job job3 = job1 + job2;

            Console.WriteLine("\nJob 1 Details:\n" +
                "-------------------\n" +
                "Job Title: {0}\n" +
                "Hours Worked: {1}\n" +
                "Hourly Rate: {2}\n" +
                "Total Fee: {3}", job1.JobDescription, job1.JobHours, job1.JobPerHourRate, job1.JobTotalFee);

            Console.WriteLine("\nJob 2 Details:\n" +
                "-------------------\n" +
                "Job Title: {0}\n" +
                "Hours Worked: {1}\n" +
                "Hourly Rate: {2}\n" +
                "Total Fee: {3}", job2.JobDescription, job2.JobHours, job2.JobPerHourRate, job2.JobTotalFee);

            Console.WriteLine("\nJob 3 Details:\n" +
                "-------------------\n" +
                "Job Title: {0}\n" +
                "Hours Worked: {1}\n" +
                "Hourly Rate: {2}\n" +
                "Total Fee: {3}", job3.JobDescription, job3.JobHours, job3.JobPerHourRate, job3.JobTotalFee);

            job2.JobHours = 20;
            Job job4 = job1 + job2;
            Console.WriteLine("\nJob 3 Details:\n" +
                "-------------------\n" +
                "Job Title: {0}\n" +
                "Hours Worked: {1}\n" +
                "Hourly Rate: {2}\n" +
                "Total Fee: {3}", job4.JobDescription, job4.JobHours, job4.JobPerHourRate, job4.JobTotalFee);
            Console.Read();
        }
    }
}
