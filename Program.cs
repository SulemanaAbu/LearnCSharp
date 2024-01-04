using System;

namespace MyFirstProgram
{
    class Program
    {
        // Params keyword
        static void Main(string[] args)
        {
            double total = checkOut(2,4,3,2,7);;
            Console.WriteLine(total);
        }

        static double checkOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
        

    }
}