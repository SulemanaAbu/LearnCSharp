using System;

namespace MyFirstProgram
{
    class Program
    {
        // ToString Method
        static void Main(string[] args)
        {
            Car car = new Car("Chevrolet", "Corvette", 2022,"Blue");
            Car car1 = new Car("Chevrolet", "Camaro", 2022,"Blue");
            Console.WriteLine(car);
            Console.WriteLine(car1);
        }
        
    }
}