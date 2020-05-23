using System;
using System.Collections.Generic;
using System.Text;

namespace Section6
{
    class Taxpayer
    {
        private int socialSecurityNumber;
        private double yearlyGrossIncome;
        private double yearlyTaxOwed;

        public Taxpayer(int socialSecurityNumber, double yearlyGrossIncome)
        {
            this.socialSecurityNumber = socialSecurityNumber;
            this.yearlyGrossIncome = yearlyGrossIncome;
            CalculateTaxOwed();
        }

        private void CalculateTaxOwed()
        {
            if (yearlyGrossIncome < 30000)
            {
                this.yearlyTaxOwed = ((yearlyGrossIncome / 100) * 15);
            } else
            {
                this.yearlyTaxOwed = ((yearlyGrossIncome / 100) * 28);
            }
        }

        public int SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }

            set
            {
                socialSecurityNumber = value;
            }
        }

        public double YearlyGrossIncome
        {
            get
            {
                return yearlyGrossIncome;
            }

            set
            {
               yearlyGrossIncome = value;
               CalculateTaxOwed();
            }
        }

        public double YearlyTaxOwed
        {
            get
            {
                return yearlyTaxOwed;
            }
        }

    }
}
