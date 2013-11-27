using System;
using System.Collections.Generic;
using System.Text;

namespace DefineClassPhone
{
    // Task 1
    // Define a class that holds information about a mobile phone device: model, manufacturer, price, owner,
    // battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
    // Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

    public class GSM
    {
        // Filds
        private string model;
        private string manufacturer;
        private int price;
        private string owner;

        private double callPrice = 0.37;
        private double allDuration;

        // Instance
        Battery battery = new Battery(BatteryType.NiCd, 5, 78);
        Display display = new Display(5, 67);

        // Task  6
        // Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        public static GSM IPhone4S = new GSM("4S", null, 350, "Gosho");

        public GSM IPHONE4S
        {
            get { return IPhone4S; }
            set { IPhone4S = value; }
        }
       
        // Properties - Task 5
        // Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        // Ensure all fields hold correct data at any given time.
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public int Price
        {
            get { return price; }
            set 
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public double PriceOfCalls
        {
            get { return callPrice; }
            set 
            {
                if (value >= 0)
                {
                    this.callPrice = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public double AlllDuration
        {
            get { return allDuration; }
            set
            {
                if (value >= 0)
                {
                    this.allDuration = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        
        // Task 9
        // Add a property CallHistory in the GSM class to hold a list of the performed calls.
        //Try to use the system class List<Call>.
        private List<Call> callHistory = new List<Call>();
         
        // Constructors - task 2
        // Define several constructors for the defined classes that take different sets of arguments
        // (the full information for the class or part of it). Assume that model and manufacturer are mandatory
        // (the others are optional). All unknown data fill with null.
        public GSM()
        {
        }

        public GSM(string model)
            : this(model, null, 0, null , null, null)
        {
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, int price)
            : this(model, manufacturer, price, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, int price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {
        }

        public GSM(string model, string manufacturer, int price, string owner, Display display)
            : this(model, manufacturer, price, owner, display, null)
        {
        }

        public GSM(string model, string manufacturer, int price, string owner, Display display, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.display = display;
            this.battery = battery;
        }

        // Metods - 4 task
        // Add a method in the GSM class for displaying all information about it. Try to override ToString().
        public override string ToString()
        {
            StringBuilder allInformation = new StringBuilder();
            allInformation.Append(model);
            allInformation.Append(manufacturer);
            allInformation.Append(price.ToString());
            allInformation.Append(owner);
            allInformation.Append(this.display);
            allInformation.Append(this.battery);

            string result = allInformation.ToString();
            return result;
        }   
    
        // Task 10
        // Add methods in the GSM class for adding and deleting calls from the calls history.
        // Add a method to clear the call history.
        public void AddCalls(DateTime dateAndTime, string dialedNumber, int duration)
        {
            Call calls = new Call(dateAndTime, dialedNumber, duration);
            callHistory.Add(calls);
        }

        public void DeleteCalls(DateTime dateAndTime, string dialedNumber, int duration)
        {
            Call calls = new Call(dateAndTime, dialedNumber, duration);
            callHistory.Remove(calls);
        }

        public void DeleteLongestDuration()
        {
            int bestMax = int.MinValue;
            for (int i = 0; i < callHistory.Count - 1; i++)
            {
                int max = Math.Max(callHistory[i].Duration, callHistory[i + 1].Duration);

                if (max > bestMax)
                {
                    bestMax = max;
                }
            }
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration == bestMax)
                {
                    callHistory.RemoveAt(i);
                }
            }
          
        }

        public void DeleteAllCalls()
        {
            callHistory.Clear();
        }

        // Task 11
        // Add a method that calculates the total price of the calls in the call history.
        // Assume the price per minute is fixed and is provided as a parameter.
        public double CallsPrice(double callPrice)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                allDuration += callHistory[i].Duration;
            }
            callPrice = callPrice * allDuration / 60;
            return callPrice;
        }

        public void DisplayHistory()
        {
            Console.WriteLine();
            Console.WriteLine("Call history:");
            foreach (var call in callHistory)
            {
                Console.WriteLine("Date: {0}, Number: {1}, Duration: {2} sec.", call.DateAndTime,
                                      call.DialedNumber, call.Duration);
            }
        }
    }
}
