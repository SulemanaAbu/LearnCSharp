using System;

namespace MyFirstProgram
{
    class Program
    {
        // Arguments
        static void Main(string[] args)
        {
            
            Car car1 = new Car("Ferrari","Yellow");
            Car car2 = new Car("Tate","Blue");
            Car car3 = new Car("Tesla","Sliver");

            Car car4 = makeCopy(car1);
            
            changeColor(car1,"Blackish");
            Console.WriteLine(car1.color);
            changeModel(car2,"Andrew");
            Console.WriteLine(car2.model);
            Console.WriteLine(car4.model +" "+ car1.color);
            
            

        }
        public static void changeColor(Car car, String color)
        {
            car.color = color;
        }

        public static void changeModel(Car car, String model)
        {
            car.model = model;
        }

        public static Car makeCopy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
}