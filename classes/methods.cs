using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the Parse Method
            // If the string you use as an argument doesn't have an integer counterpart, the Parse Method will throw an exception.
            // You need to catch that exception for this approach to work properly.

            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Conversion failed.");
            }

            // Using the TryParse Method with the Out Mofifier
            // TryParse returns a bool, which represents whether the parsing was posible or not. To get the number in case the bool is true,
            // you'd need to define a number variable to be used inside the method, said variable will be forced to return the resulting
            // number value of the successful parcing. Otherwise, this method returns false. No need to catch exceptions.

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                System.Console.WriteLine(number);
            else
                System.Console.WriteLine("Conversion failed.");
        }
    }
}