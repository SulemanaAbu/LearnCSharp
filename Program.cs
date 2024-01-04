using System;

namespace MyFirstProgram
{
    class Program
    {
        // Objects
        static void Main(string[] args)
        {
            Car car1 = new Car("Chevrolet", "Corvette", 2022);
            Car car2 = new Car("Toyota", "Camry", 2020);
            
            car1.Stop();
            car2.Move();
        }
        
    }
}