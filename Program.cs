using System;

namespace MyFirstProgram
{
    class Program
    {
        // exception handling
        static void Main(string[] args)
        {
            try
            {
                double x;
                double y;
                double z;

                Console.WriteLine("Enter the value of x: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value of y: ");
                y = Convert.ToInt32(Console.ReadLine());

                z = x / y;
                Console.WriteLine($"The result of {x} / {y} = " + z);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't Divide by zero Dummy!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!!!");
            }
            finally
            {
                Console.WriteLine("Thank you!");
            }
        }
        

    }
}