using System;
using System.Collections.Generic;

/* Write a class GSMTest to test the GSM class:Create an array of few instances of the GSM class.Display the information about the GSMs in the array.Display the information about the static property IPhone4S.
 */

namespace DefinePfoneHierarchy
{
    public static class MobilePhoneTest
    {
        public static void DisplayInformation()
        {
            MobilePhone[] arr = { 
                                new MobilePhone("C6", "Nokia"),
                                new MobilePhone("TG", "Samsung", 500, "Someone",  new Display(5, 256000), new Battery("s56", 20, 22)),
                                new MobilePhone("S", "SONY", 200, "Me",  new Display(5, 1000000), new Battery("rtry", 10, 30))
                            };

            foreach (var phone in arr)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine("\n{0}", MobilePhone.Iphone);
        }
    }
}
