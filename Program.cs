using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accept user input
            Console.WriteLine("What is your name? ");
            String name = (Console.ReadLine());
            Console.WriteLine("Hello " + name);

            Console.WriteLine("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age " + age);
            

        }
    }
}    