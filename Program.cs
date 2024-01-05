using System;

namespace MyFirstProgram
{
    class Program
    {
        // ToString Method
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();

            rabbit.Flee();
            fish.Flee();
            fish.Chase();
            hawk.Chase();
        }

    }
}