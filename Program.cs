﻿using System;

namespace MyFirstProgram
{
    class Program
    {
        // nested for loop
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows? ");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("How many columns? ");
            int columns = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What symbol?  ? ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows ; i++)
            {
                for (int j = 0; j < columns ; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }
    }
}