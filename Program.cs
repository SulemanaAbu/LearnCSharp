using System;

namespace MyFirstProgram
{
    class Program
    {
        // Objects
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human2.name = "Saddiq";
            
            human1.speak();
            human2.eat();
        }
        
    }
}