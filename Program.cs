using System;

namespace MyFirstProgram
{
    class Program
    {
        // Method Overriding
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();
            
            
            dog.Speak();
            cat.Speak();




        }
        
    }
}