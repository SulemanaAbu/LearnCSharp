using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           //Accept user input
           Console.WriteLine("What is your name? ");
           String name = Console.ReadLine();
           Console.WriteLine("Hello "+name);
        }
    }
}