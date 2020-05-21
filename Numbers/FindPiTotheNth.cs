/*
 * Find PI to the Nth Digit - 
 * Enter a number and have the program generate PI up to that many decimal places. 
 * Keep a limit to how far the program will go.
 */

using System;


namespace Numbers
{
    class FindPiTotheNth
    {
        static void Main(string[] args)
        {
            //using Archimedes method
            double pi = 0;              //where to store calculated value of pi
            double PolySides = 6;   //start by cutting circle with 6 triangles
            double Sidelen = 1;     //start with 6 equilateral triangles of side = 1
            double Dia = 2;         //Diameter of cricle or any polygon shape always 2
            double NewSidelen;      //Calculates sidelen for next iteration
            double Perim;           //Perimeter of polygon
            double RadiusA;         //First part of radius calculation (middle to edge op polygon)
            double RadiusB;         //Second part of radius calculation (egde of polygon to edge of circle)

            while (PolySides < 402653184)  // minimum size to have precision up to 16 digits
            {
                RadiusA = Math.Sqrt(1 - Math.Pow(Sidelen / 2,2));
                RadiusB = 1 - RadiusA;
                NewSidelen = Math.Sqrt(Math.Pow(RadiusB, 2) + Math.Pow(Sidelen / 2, 2));
                Perim = PolySides * Sidelen;
                pi = Perim / Dia;
                //Console.WriteLine("PolySides = " + PolySides + "\nSidelen = " + Sidelen + "\nRadiusA = " + RadiusA + "\nRadiusB = " + RadiusB + "\nPerim = " + Perim + "\nPi approx = " + pi + "\n");
                //Console.ReadLine();
                PolySides = PolySides * 2;
                Sidelen = NewSidelen;
            }



            String PiString = pi.ToString();
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
