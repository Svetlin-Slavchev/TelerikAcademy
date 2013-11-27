using System;

namespace _2.Task2_Bank
{
    public class LoanAccount : Account, IDeposit, ICompanyCustomer, IIndividualCustomer
    {
        public LoanAccount(IIndividualCustomer customer, decimal balance, double interestRate)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public LoanAccount(ICompanyCustomer customer, decimal balance, double interestRate)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        // Loan and mortgage accounts can only deposit money.
        public decimal DepositMonney(decimal balance, double money)
        {
            return balance += (decimal)money;
        }

        // Loan accounts have no interest for the first 3 months if are held by individuals
        public double InterestAmountForIndividuaCustomer(int mount)
        {
            if (mount < 0)
            {
                throw new ArgumentException("Mount must be 0 or bigger!");
            }
            else
            {
                return (mount - 3) * InterestRate;
            } 
        }

        // and for the first 2 months if are held by a company.
        public double InterestAmountForCompanyCustomer(int mount)
        {
            if (mount < 0)
            {
                throw new ArgumentException("Mount must be 0 or bigger!");
            }
            else
            {
                return (mount - 2) * InterestRate;
            }
        }
    }
}
