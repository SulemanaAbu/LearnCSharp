using System;

namespace MyFirstProgram
{
    class Program
    {
        // C# methods
        static void Main(string[] args)
        {
            String name = "Sulemana Abubakar Saddique";
            int age = 20;
            String residence = "Ashaley Botwe";
            
            myBirthInfo(name,age,residence);
            Console.WriteLine();
            singHappyBirthday(name, age);
            

        }

        static void myBirthInfo(String name, int age, String residence)
        {
            Console.WriteLine("My name is "+name);
            Console.WriteLine("I am "+age+ " years old");
            Console.WriteLine("I stay at "+residence);
            
        }

        static void singHappyBirthday(String name, int age)
        {
            Console.WriteLine("Happy Birthday to you");
            Console.WriteLine("Happy Birthday to you");
            Console.WriteLine("Happy Birthday dear "+name);
            Console.WriteLine("You are "+age+" years old now");
        }
    }
}