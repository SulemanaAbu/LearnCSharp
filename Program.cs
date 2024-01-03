using System;

namespace MyFirstProgram
{
    class Program
    {
        //while loop
        static void Main(string[] args)
        {
            String name = "";
           

            while (name == "")
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello "+name);
        }
    }
}