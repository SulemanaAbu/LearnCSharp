using System;

namespace MyFirstProgram
{
    class Program
    {
        // Getters and Sstters
        static void Main(string[] args)
        {
            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);
        }

    }
}