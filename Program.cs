using System;

namespace Operators_Exercise
{
    class Program
    {
       
        static void Main(string[] args)
        {
         
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine("{0}/{1} is {2} remainder {3}", a, b, quotient, remainder);

            Console.WriteLine("What is the radius of your circle?");
            var r = double.Parse(Console.ReadLine());

            double answer = AreaOfCircle(r);




            Console.WriteLine("The area of a circle with radius {0} is {1} ", r, answer);
        }

        private static double AreaOfCircle(double radius) => Math.PI * radius * radius; 

      
    }

}
