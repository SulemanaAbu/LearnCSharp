using System;

namespace MyFirstProgram
{
    class Program
    {
        // Arrays in C#
        static void Main(string[] args)
        {
            String[] car = { "BMW", "Mustang", "Corvette" };
            foreach (String s in car)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}