using System;

//  A company has name,adress, phone number, fax number, web  site and manager. The manager has first name, last name, age and a phone number. 
// Write a program that reads the inforation about a company and its manager and prints them on the console.

class InformationAboutCompany
{
    static void Main()
    {
        Console.Write("Company name is: ");
        string name = Console.ReadLine();

        Console.Write("Adress: ");
        string adress = Console.ReadLine();

        Console.Write("Phone number: ");
        int phoneNumber = int.Parse(Console.ReadLine());

        Console.Write("Fax nnumber: ");
        int faxNumber = int.Parse(Console.ReadLine());

        Console.Write("Web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager: ");
        string menager = Console.ReadLine();

        Console.WriteLine("Inforation about manager: ");

        Console.Write("First and last name: ");
        object firstAndLastName = Console.ReadLine();

        Console.WriteLine("Age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Phone number: ");
        int phoneNumberManager = int.Parse(Console.ReadLine());
    }
}

