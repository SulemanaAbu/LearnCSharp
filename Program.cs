using System;

namespace MyFirstProgram
{
    class Program
    {
        // Overloading Constructors
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();

            car.make = "Ferrari";
            Console.WriteLine(car.wheels);
            
           
           car.Move();
        }
        
    }
}