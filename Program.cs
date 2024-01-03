using System;

namespace MyFirstProgram
{
    class Program
    {
        // C# methods overloading
        static void Main(string[] args)
        {
            double total;
            total = Multiply(2, 3);

            Console.WriteLine(total);
            
        }

        static double Multiply(double a, double b)
        {
            return  a * b;
        }
        
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        
    }
}