/*
Programmer: Felipe SG
Date: 12/01/2021
Program: 3exercise5
Objective: 
Write an expression that calculates the area of a trapezoid by given
sides a, b and height h.
 */

using System;

namespace _3exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double sideA, sideB, heightH, area;

            Console.WriteLine("Welcome \n");
            Console.WriteLine("Please inform the First side of the trapezoid: ");
            sideA = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Please inform the Second side of the trapezoid: ");
            sideB = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Please inform the Hight of the trapezoid: ");
            heightH = Convert.ToUInt32(Console.ReadLine());

            // Calculate the area
            area = ((sideA + sideB) / 2) * heightH;
            // Print the result
            Console.WriteLine("The area of the trapezoid is: {0}", area);
        }
    }
}
