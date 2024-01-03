using System;

namespace MyFirstProgram
{
    class Program
    {
        // Arrays in C#
        static void Main(string[] args)
        {
            String[] car = { "BMW", "Mustang", "Corvette" };
            for (int i =0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }
            
        }
    }
}