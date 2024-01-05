using System;

namespace MyFirstProgram
{
    class Program
    {
        // Abstract classes
        static void Main(string[] args)
        {
            Car[] garage = new Car[3];
            
            Car car1 = new Car("Ferrari");
            Car car2 = new Car("Tate");
            Car car3 = new Car("Tesla");

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
            

        }
        
    }
}