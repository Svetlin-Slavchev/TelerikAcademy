using System;

namespace _2.Task2_Bank
{
    public class DepositAccount : Account, IDeposit, IDraw, ICompanyCustomer, IIndividualCustomer
    {
        public DepositAccount()
        {
        }

        public DepositAccount(IIndividualCustomer customer, decimal balance, double interestRate)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public DepositAccount(ICompanyCustomer customer, decimal balance, double interestRate)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        // Deposit accounts are allowed to deposit and with draw money.
        public decimal DrawMoney(decimal balance, double money)
        {
            return balance -= (decimal)money;
        }

        public decimal DepositMonney(decimal balance, double money)
        {
            return balance += (decimal)money;
        }

        // Deposit accounts have no interest if their balance is positive and less than 1000.
        public double InterestAmountForCompanyCustomer(int mount)
        {
            if (mount < 0)
            {
                throw new ArgumentException("Mount must be 0 or bigger!");
            }
            if (Balance > 0 && Balance < 1000)
            {
                return 0;
            }
            else
            {
                return mount * InterestRate;
            } 
        }

        public double InterestAmountForIndividuaCustomer(int mount)
        {
            if (mount < 0)
            {
                throw new ArgumentException("Mount must be 0 or bigger!");
            }
            if (Balance > 0 && Balance < 1000)
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
