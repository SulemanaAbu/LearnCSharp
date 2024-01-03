using System;

namespace MyFirstProgram
{
    class Program
    {
        //The almighty formula of quadratic expressions
        static void Main(string[] args)
        {
            Console.WriteLine("The almighty formula for quadratic expressions");

            Console.WriteLine("Enter the coefficient of x-squared (a): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The coefficient of x-squared is "+a);
            
            Console.WriteLine("Enter the coefficient of x (b): ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The coefficient of x is "+b);
            
            Console.WriteLine("Enter the constant (c): ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The constant is "+c);

            double pos = -b + Math.Sqrt((b * b) - (4 * a * c));
            double neg = -b - Math.Sqrt((b * b) - (4 * a * c));

            double X1 = pos / (2 * a);
            double X2 = neg / (2 * a);
            
            Console.WriteLine("The first result of the quadratic is "+X1);
            Console.WriteLine("The second result of the quadratic is "+X2);




        }
    }
}