using System;

namespace MyFirstProgram
{
    class Program
    {
        // ToString Method
        static void Main(string[] args)
        {
            Bicycle bike = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = { bike, boat };
            
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
        
    }
}