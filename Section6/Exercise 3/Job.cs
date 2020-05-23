using System;
using System.Collections.Generic;
using System.Text;

namespace Section6
{
    class Job
    {
        private string jobDescription;
        private double jobHours;
        private double jobPerHourRate;
        private double jobTotalFee;

        public Job(string jobDescription, double jobHours, double jobPerHourRate)
        {
            this.jobDescription = jobDescription;
            this.jobHours = jobHours;
            this.jobPerHourRate = jobPerHourRate;
            CalculateTotalFee();
        }
        public static Job operator +(Job job1, Job job2)
        {
            string combinedJobs = job1.jobDescription + " & " + job2.jobDescription;
            double combinedHours = job1.jobHours + job2.jobHours;
            double averageHourlyRate = (job1.jobPerHourRate + job2.jobPerHourRate) / 2;
            double totalCombinedFee = job1.jobTotalFee + job2.jobTotalFee;

            Job jobCombined = new Job(combinedJobs, combinedHours, averageHourlyRate);
            return jobCombined;
        }

        private void CalculateTotalFee()
        {
            jobTotalFee = jobHours * jobPerHourRate;
        }
        public string JobDescription
        {
            get
            {
                return jobDescription;
            }
            set
            {
                jobDescription = value;
            }
        }

        public double JobHours
        {
            get
            {
                return jobHours;
            }
            set
            {
                jobHours = value;
                CalculateTotalFee();
            }
        }

        public double JobPerHourRate
        {
            get
            {
                return jobPerHourRate;
            }
            set
            {
                jobPerHourRate = value;
                CalculateTotalFee();
            }
        }

        public double JobTotalFee
        {
            get
            {
                return jobTotalFee;
            }
        }
    }
}
