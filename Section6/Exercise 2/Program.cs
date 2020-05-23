using System;

namespace Section6
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxpayer[] taxpayers = new Taxpayer[5];

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Please enter a value for Taxpayer {0} SSN", i);
                int inputSSN = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a value for Taxpayer {0} Yearly Gross Income", i);
                double inputIncome = double.Parse(Console.ReadLine());
                taxpayers[i - 1] = new Taxpayer(inputSSN, inputIncome);
            }
            Console.Clear();
            for (int i = 0; i < taxpayers.Length; i++)
            {
                Console.WriteLine("Taxpayer {0} Information:\n" + 
                    "SSN: {1}\n" +
                    "Yearly Gross Income: {2}\n" +
                    "Yearly Tax Owed: {3}\n" +
                    "******************************\n", i + 1, taxpayers[i].SocialSecurityNumber, taxpayers[i].YearlyGrossIncome, taxpayers[i].YearlyTaxOwed);
            }
            Console.Read();
        }
    }
}
