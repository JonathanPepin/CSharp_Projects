/*
 * Find PI to the Nth Digit - 
 * Enter a number and have the program generate PI up to that many decimal places. 
 * Keep a limit to how far the program will go.
 */

using System;


namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            String PiString = Math.PI.ToString();
            int decimalPlaces;
                
            Console.WriteLine("Enter the number of decimal places you want to generate PI up to between 1 and " + (PiString.Length - 2).ToString());
            decimalPlaces = Convert.ToInt32(Console.ReadLine());

            if (decimalPlaces < 1 || decimalPlaces > PiString.Length - 2)
            {
                Console.WriteLine("number of decimal places inputed is not valid.");
            }
            else
            {
                Console.WriteLine(PiString.Substring(0, (decimalPlaces + 2)));
            }
        }
    }
}
