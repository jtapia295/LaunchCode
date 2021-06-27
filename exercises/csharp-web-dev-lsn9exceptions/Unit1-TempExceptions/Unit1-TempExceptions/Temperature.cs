using System;
namespace Unit1_TempExceptions
{
    public class Temperature
    {
        public static double absoluteZero = -459.67;

        public Temperature(double fahrenheit)
        {
            if (fahrenheit < absoluteZero)
            {
                throw new ArgumentOutOfRangeException("Value is below absolute zero.");
            }
            else
            {
                Console.WriteLine("You entered " + fahrenheit + " degrees F.");
            }
        }
    }
}