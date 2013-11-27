using System;

namespace DefineClassPhone
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            // Class GSMTest and Class GSMCallHistoryTest are murged
            // Task 7 
            // Write a class GSMTest to test the GSM class:
            //Create an array of few instances of the GSM class.
            //Display the information about the GSMs in the array.
            //Display the information about the static property IPhone4S.

            // Task 12
            //Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
            //Create an instance of the GSM class.
            //Add few calls.
            //Display the information about the calls.
            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            //Remove the longest call from the history and calculate the total price again.
            //Finally clear the call history and print it.

            try
            {
                Display displayOne = new Display(5, 65000);
                Battery batteryOne = new Battery(BatteryType.NiCd, 45, 78);
                Display displayTwo = new Display(10, 256000);
                Battery batteryTwo = new Battery(BatteryType.LiIon, 56, 90);
                Display[] displays = {displayOne, displayTwo};
                Battery[] batteries = {batteryOne, batteryTwo};

                GSM firstPhone = new GSM("4MfT", "Nokia", 450, "Mr.Ivanov", displayOne, new Battery(BatteryType.NiCd, 45, 78));
                GSM secondPhone = new GSM("T8790R", "Samsung", 250, "Mr.Petkov");

                GSM[] arr = { firstPhone, secondPhone };
                Console.WriteLine("Information about phones in this colection:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Model: {0}, manufacturer: {1}, phone price: {2}, owner: {3}, display size : {4}, display number of colours: {5}, battery type: {6}, hoursIdle: {7}, hoursTalk: {8}",
                       arr[i].Model, arr[i].Manufacturer, arr[i].Price, arr[i].Owner, displays[i].Size, displays[i].NumberOfCollors,
                     batteries[i].Model, batteries[i].HoursIdle, batteries[i].HoursTalk);
                }

                Console.WriteLine();
                Console.WriteLine("Information about IPhone");
                Console.WriteLine("Model is {0}.", GSM.IPhone4S.Model);
                Console.WriteLine("Owner is {0}.", GSM.IPhone4S.Owner);
                Console.WriteLine("Phone price is {0}.", GSM.IPhone4S.Price + " levs");

                // Phone methods testing
                GSM phone = new GSM("4MfT", "Nokia", 450, "Mr.Ivanov", new Display(5, 65000),
                    new Battery(BatteryType.NiCd, 45, 78));

                phone.AddCalls(DateTime.Now, "0888******", 35);
                phone.AddCalls(DateTime.Now.AddHours(5), "0886******", 20);
                phone.AddCalls(DateTime.Now.AddHours(6.5), "0883******", 55);

                phone.DisplayHistory();

                Console.WriteLine();
                Console.WriteLine("The price of all calls is {0} leva.", phone.CallsPrice(phone.PriceOfCalls));

                phone.DeleteLongestDuration();
                phone.DisplayHistory();

                phone.DeleteAllCalls();

                phone.DisplayHistory();
                Console.WriteLine("Call history is empty!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number! Try again!");
            }
            catch (Exception)
            {
                Console.WriteLine("There is some mistake. Try again!");
            }
        }
    }
}
