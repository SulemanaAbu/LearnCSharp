using System;

namespace MyFirstProgram
{
    class Program
    {
        // C# Static Keyword
        static void Main(string[] args)
        {
            Car car1 = new Car("Chevrolet", "Corvette", 2022);
            Car car2 = new Car("Toyota", "Camry", 2020);
            Car car3 = new Car("Ferrari", "Camry", 2020);
            Console.WriteLine(Car.numberOfcars+" cars have begun racing ");
            
            car1.Stop();
            car2.Move();
            Car.endRace();
            car3.Race();
        }
        
    }
}