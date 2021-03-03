using ConsoleAppProject.App01;
//using ConsoleAppProject.App02;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Jordan Njie 14/1/2021
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();

            Console.WriteLine("1. Distance converter");
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine(0);

            Console.WriteLine("Select an applocation  ");
            string choice = Console.ReadLine();


            DistanceConverter converter = new DistanceConverter();
            converter.MilesToFeet();
            converter.MetresToMiles();
            converter.KilometresToMiles();
            converter.MilesToFeet2();
            converter.MetresToMiles2();
            converter.KilometresToMiles2();
            converter.MetresTofeet();
            converter.FeetToMetres();


            // BMI calculator = new BMI();
            // BMI();
            //     Console.ReadLine();

        }
    }
}
