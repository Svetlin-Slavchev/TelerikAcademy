using DefinePfoneHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Define a class that holds information about a mobile phone device: model, manufacturer, price, owner,  * battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).  * Define 3 separate classes (class GSM holding instances of the classes Battery and Display). * Define several constructors for the defined classes that take different sets of arguments
 * (the full information for the class or part of it). Assume that model and manufacturer are mandatory (the others are optional).
 * All unknown data fill with null.
*/
namespace DefinePfoneHierarchy
{
    public class MobilePhone
    {
        private string model;
        private string manifacture;
        private int? price;
        private string owner;

        Battery battery;
        Display display;
        List<Call> callList;

        // task 6
        private static MobilePhone iphone;

        public static MobilePhone Iphone
        {
            get { return new MobilePhone("iPhoneS5", "Apple"); }
        }

        public MobilePhone(string model, string manifacture)
            : this(model, manifacture, null, null, null, null)
        { }

        public MobilePhone(string model, string manifacture, int? price, string owner, Display display, Battery battery)
        {
            this.Model = model;
            this.Manifacture = manifacture;
            this.Price = price;
            this.Owner = owner;
            this.display = display;
            this.battery = battery;
            this.callList = new List<Call>();
        }

        // task 5
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manifacture
        {
            get { return manifacture; }
            set { manifacture = value; }
        }

        public int? Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        //task 9
        // Add a property CallHistory in the GSM class to hold a list of the performed calls.
        // Try to use the system class List<Call>
        public List<Call> CallList
        {
            get { return callList; }
            set { callList = value; }
        }

        // task 4 and task 10
        // Add methods in the GSM class for adding and deleting calls from the calls history.
        // Add a method to clear the call history.

        public void AddCall(Call call)
        {
            this.callList.Add(call);
        }

        public void RemoveCall(int index)
        {
            this.callList.RemoveAt(index);
        }

        public void ClearAllCalls()
        {
            this.callList.Clear();
        }

        public void ShowAllCalls()
        {
            foreach (var call in this.callList)
            {
                Console.WriteLine(call);
            }
        }

        //task 11
        // Add a method that calculates the total price of the calls in the call history. 
        // Assume the price per minute is fixed and is provided as a parameter.
        public double CalculatePriceOfAllCalls(double priceForCall)
        {
            double totalPrice = 0;
            foreach (var call in this.callList)
            {
                totalPrice += call.Duration * priceForCall;
            }

            return totalPrice;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Phone: ");
            result.AppendFormat("{0}, {1}, {2}, {3}\n{4}\n{5}", this.Model, this.Manifacture, this.Owner
                , this.Price, this.display, this.battery);

            return result.ToString();
        }
    }
}
