using System;

namespace MyFirstProgram
{
    class Program
    {
        // Objects
        static void Main(string[] args)
        {
            Human human = new Human("Rick", 23);
          
            human.eat();
            human.speak();
        }
        
    }
}