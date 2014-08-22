using System;

// A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
// bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
// Declare the variables needed to keep the information for a single bank account using the appropriate data types
// and descriptive names.

class BankAcount
{
    static void Main(string[] args)
    {
        string HolderName = "FirstSecondThirtName";
        decimal balance = 0;
        string BankName = "Example";
        string IBAN = "0000000000000";
        string BICCode = "Example";
        long CCard1 = 01001010001001;
        long CCard2 = 00200101201001;
        long CCard3 = 00200100021200;
        Console.WriteLine("{0},  {1},  {2},  {3},  {4},  {5},  {6},  {7}", HolderName, balance, BankName, 
            IBAN, BICCode, CCard1, CCard2, CCard3);
    }
}
