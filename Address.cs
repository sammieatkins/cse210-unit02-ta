using System;

namespace Cse210_Unit02_Ta
{
    public class Address
    {
        public string street;
        public string city;
        public string state;

        // public PhoneNumber phoneNumber;
        public Address()
        {
            street = "Unknown Street";
            city = "Unknown City";
            state = "Unknown State";
        }

        public void DisplayMailingLabel() 
        {
            Console.WriteLine($"{street}");
            Console.WriteLine($"{city}, {state}");
            // phoneNumber.DisplayNumber();
        }
        
    }
}
