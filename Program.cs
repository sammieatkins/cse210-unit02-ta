using System;

namespace Cse210_Unit02_Ta
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the program.");
            Address address1 = new Address();
            address1.street = "123 Sesame Street";
            address1.city = "Rexburg";
            address1.state = "Idaho";

            // PhoneNumber phoneNumber3 = new PhoneNumber();
            // phoneNumber3._areaCode = 111;
            // phoneNumber3._prefix = 222;
            // phoneNumber3._suffix = 3333;
            // address1.DisplayMailingLabel();
            // address1.phoneNumber = phoneNumber3;


            Address address2 = new Address();
            address2.DisplayMailingLabel();

            PhoneNumber phoneNumber1 = new PhoneNumber();
            phoneNumber1._areaCode = 111;
            phoneNumber1._prefix = 222;
            phoneNumber1._suffix = 3333;
            phoneNumber1.DisplayNumber();
        }
    }
}
