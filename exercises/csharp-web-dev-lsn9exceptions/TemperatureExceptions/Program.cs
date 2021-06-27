using System;

//Book example for the Unit 2 C# program

namespace TemperatureExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature insideTemp = new Temperature(73);
            Console.WriteLine(insideTemp.Fahrenheit);

            Temperature outsideTemp = new Temperature(-8200);
            Console.WriteLine(outsideTemp.Fahrenheit);
        }
    }
}
