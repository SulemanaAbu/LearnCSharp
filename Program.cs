using System;

namespace MyFirstProgram
{
    class Program
    {
        // C# methods
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;
            
            Console.WriteLine("Enter x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x = "+x);
            
            Console.WriteLine("Enter y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y = "+y);

            result = Multiply(x,y);
            Console.WriteLine($"The result {x} * {y} = "+result);
        }

        static double Multiply(double x ,double y)
        {
            return  x * y;
        }
        
    }
}