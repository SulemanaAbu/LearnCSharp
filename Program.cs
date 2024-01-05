using System;

namespace MyFirstProgram
{
    class Program
    {
        // Overloading Constructors
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("Brown bread", "Tomato", "Cattle", "Pepperoni");
            Pizza pizza2 = new Pizza("Butter", "Egg", "Goat");
            Pizza pizza3 = new Pizza("Butter", "Egg");
            Pizza pizza4 = new Pizza("Butter");

            Console.WriteLine(pizza1.bread);
        }
        
    }
}