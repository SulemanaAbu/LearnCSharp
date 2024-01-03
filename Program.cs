using System;

namespace MyFirstProgram
{
    class Program
    {
        //Finding the hyputenuse of a triange
        static void Main(string[] args)
        {
            Console.WriteLine("A program to find the hypotenuse of a triangle");
            Console.WriteLine();
            
            Console.WriteLine("Enter side A: ");
            double a =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Side A is "+a);
            
            Console.WriteLine("Enter side B: ");
            double b =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Side A is "+b);
            
            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("The hypotenuse of the triangle is "+c);
        }
    }
}