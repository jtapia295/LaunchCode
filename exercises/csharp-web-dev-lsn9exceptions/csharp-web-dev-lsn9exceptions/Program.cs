using System;
using System.Collections.Generic;
using System.Linq;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            double divOutput = x / y;
            try
            {
                if (y == 0)
                {
                    throw new DivideByZeroException("Sorry you cant divide by zero!");
                }
                else
                {
                    divOutput = x / y;
                    Console.WriteLine(divOutput);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }

            return divOutput;
        }
        static int CheckFileExtension(string fileName)
        {
            int studentPoint = 0;
            try
            {
                if (String.IsNullOrEmpty(fileName))
                {
                    throw new ArgumentNullException("This argument doesn't contain a value");
                }
                else if (fileName.Contains(".cs"))
                {
                    studentPoint = +1;
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            return studentPoint;
        }

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            Console.WriteLine("Division exercise-----------------------------------------");
            double result = Divide(25, 0);
            Console.WriteLine($"{result}\n\n");

            // Test out your CheckFileExtension() function here!
            Console.WriteLine("File extension Exercise---------------------------------------");
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            foreach (var item in students)
            {
                Console.WriteLine($"{CheckFileExtension(item.Value)}\n");
            }



        }
    }
}
