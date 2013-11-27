using System;

namespace _2.Task2_Bank
{
    public abstract class Account : Bank
    {
        private decimal balance;
        private double interestRate;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
    }
}
