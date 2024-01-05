using System;

namespace MyFirstProgram
{
    class Program
    {
        // Enumeration / enums
        static void Main(string[] args)
        {
            Console.WriteLine(Planet.Pluto+" is a planet");
            Console.WriteLine(Planet.Mercury+" is  planet #"+(int)Planet.Mercury);

            String name = planetRadius.Earth.ToString();
            int radius = (int)planetRadius.Earth;
            Console.WriteLine("planet: "+name);
            Console.WriteLine("radius: "+radius+" km");
            double volume = Volume(planetRadius.Earth);
            Console.WriteLine("The volume of the earth is: "+volume+" km^3");
        }

        public static double Volume(planetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }

    }
}