using System;

namespace _2.Task2_Bank
{
    public class MortgageAccount : Account, IDeposit, ICompanyCustomer, IIndividualCustomer
    {
        public MortgageAccount(IIndividualCustomer customer, decimal balance, double interestRate)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public MortgageAccount(ICompanyCustomer customer, decimal balance, double interestRate)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        // Loan and mortgage accounts can only deposit money.
        public decimal DepositMonney(decimal balance, double money)
        {
            return balance += (decimal)money;
        }

        // Mortgage accounts have ½ interest for the first 12 months for companies
        public double InterestAmountForCompanyCustomer(int mount)
        {
            if (mount < 0)
            {
                throw new ArgumentException("Mount must be 0 or bigger!");
            }
            else if (mount <= 12)
            {
                return (mount * InterestRate) / 2;
            }
            else
            {
                return ((mount * InterestRate) / 2) + ((mount - 12) * InterestRate);
            }
        }

        // and no interest for the first 6 months for individuals.
        public double InterestAmountForIndividuaCustomer(int mount)
        {
            if (mount < 0)
            {
                throw new ArgumentException("Mount must be 0 or bigger!");
            }
            else if (mount <= 6)
            {
                return 0;
            }
            else
            {
                return mount * InterestRate;
            } 
        }
    }
}
