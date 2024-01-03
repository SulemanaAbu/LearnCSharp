using System;

namespace MyFirstProgram
{
    class Program
    {
        //If and else statements
        static void Main(string[] args)
        {
            Console.WriteLine("Checking grade by asking student score");

            Console.WriteLine("Enter the name of the course: ");
            String course = Console.ReadLine();
            Console.WriteLine("You are checking your grade for: "+course);

            Console.WriteLine("Enter the score obtained: ");
            int score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You obtained "+score+" in "+course);

            if (score > 100)
            {
                Console.WriteLine("Enter a valid Score!");
            }
            else if (score  >= 80)
            {
                Console.WriteLine("Congratulations! You scored an A");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Congratulations! You scored a B");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Average! You scored a C");
            }
            else if (score >= 50)
            {
                Console.WriteLine("You can do better! You scored a D");
            }
            else if (score >= 40)
            {
                Console.WriteLine("Bad! You scored an E ");
            }
            else if (score >= 0)
            {
                Console.WriteLine("Onukpa! You don fail");
            }
            else
            {
                Console.WriteLine("Bibinii ne gyimie di3!!!!!!");
            }

        }
    }
}