using System;

namespace _2.Task2_Bank
{
    public class Customer : Account, ICompanyCustomer, IIndividualCustomer
    {
        public Customer()
        {
        }

        public Customer(decimal balance, double interestRate)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public double InterestAmountForCompanyCustomer(int mount)
        {
            return mount * InterestRate;
        }

        public double InterestAmountForIndividuaCustomer(int mount)
        {
            return mount * InterestRate;
        }
    }
}
