using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalc
{
    class Circle
    {


        public static double radius;
        public static double circumference(double radius)
        {
            double Circlecircumference = 2 * Math.PI * radius;
            return Math.Round(Circlecircumference, 2);
        }
        public  double area(double radius)
        {
            double Circlecircumference = Math.PI * Math.Pow(radius, 2);
            return Math.Round(Circlecircumference, 2);
        }
        public static double diameter(double radius)
        {
            double diameter = 2 * radius);
            return Math.Round(diameter, 2);
        }
        public static double gallonsUsedInCirc(double radius,double mpg)
        {
            double Circlecircumference = Math.PI * Math.Pow(radius, 2);
            double gallonsUsedInCirc = Circlecircumference / mpg;
            return Math.Round(gallonsUsedInCirc, 2);
        }
        public Circle()
        {
        
        }
         
    }
    
}

