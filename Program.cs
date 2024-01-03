using System;

namespace MyFirstProgram
{
    class Program
    {
        //while loop
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
           

            while (name == "")
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello "+name);
        }
    }
}