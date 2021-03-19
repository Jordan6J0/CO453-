using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This application converts miles to feet, metres and kilometres and the opp.
    /// </summary>
    /// <author>
    /// Jordan Njie version 0.3 
    /// </author>
    public class DistanceConverter
    {

        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double KILOMETRES_IN_MILES = 1.60934;

        private double miles;

        private double feet;

        private double metres;

        private double Kilometres;




        /// <summary>
        /// Run
        /// </summary>

        public void MilesToFeet()
        {
            Console.WriteLine("");
            Console.WriteLine("Convert Miles to Feet");
            OutputHeading();
            miles = InputDistance("Please enter the number of miles  ");
            CalculateFeet();
            OutputFeet();
        }

        public void MetresToMiles()
        {
            Console.WriteLine("");
            Console.WriteLine("Convert Miles to Metres");
            OutputHeading();
            miles = InputDistance("Please enter the number of miles  ");
            CalculateMetres();
            OutputMetres();
        }

        public void MetresTofeet()
        {
            Console.WriteLine("");
            Console.WriteLine("Convert Metres to Feet");
            OutputHeading();
            miles = InputDistance("Please enter the number of miles  ");
            CalculateMetres3();
            OutputMetres3();
        }
        public void FeetToMetres()
        {
            Console.WriteLine("");
            Console.WriteLine("Convert Feet to Metres");
            OutputHeading();
            miles = InputDistance("Please enter the number of miles  ");
            CalculateFeet3();
            OutputFeet3();
        }

        public void KilometresToMiles()
        {
            Console.WriteLine("");
            Console.WriteLine("Convert Miles to Kilometres");
            OutputHeading();
            miles = InputDistance("Please enter the number of miles  ");
            CalculateKilometres();
            OutputKilometres();
        }
        public void MilesToFeet2()
        {
            Console.WriteLine("");
            Console.WriteLine("Convert feet to miles");
            OutputHeading();
            miles = InputDistance("Please enter the number of miles  ");
            CalculateFeet2();
            OutputFeet();
        }

        public void MetresToMiles2()
        {
            Console.WriteLine("");
            Console.WriteLine("Convert metres to miles");
            OutputHeading();
            miles = InputDistance("Please enter the number of miles  ");
            CalculateMetres2();
            OutputMetres();
        }

        public void KilometresToMiles2()
        {
            Console.WriteLine("");
            Console.WriteLine("Convert Kilometres to miles");
            OutputHeading();
            miles = InputDistance("Please enter the number of miles  ");
            CalculateKilometres2();
            OutputKilometres();
        }


        private void OutputHeading()
        {
            {
                Console.WriteLine("\n_________________________________________");
                Console.WriteLine("\t\tConvert Distances");
                Console.WriteLine("\t\tBy Jordan Njie");
                Console.WriteLine("\n_________________________________________");
                Console.WriteLine("\n_________________________________________");
                Console.WriteLine("1. Miles to feet");
                Console.WriteLine("2. Miles to metres");
                Console.WriteLine("3. Miles to kilometres");
                Console.WriteLine("4. Feet to miles");
                Console.WriteLine("5. Metres to miles");
                Console.WriteLine("6. Kilometres to miles");
                Console.WriteLine("7. Metres to feet");
                Console.WriteLine("8. Feet to metres");
                Console.WriteLine(0);

                Console.WriteLine("Select a converter  ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                  
                }

                else if (choice == "2")
                {

                }

                else if (choice == "3")
                {

                }

                else if (choice == "4")
                {

                }

                else if (choice == "5")
                {

                }

                else if (choice == "6")
                {

                }

                else if (choice == "7")
                {

                }

                else if (choice == "8")
                {

                }

            }

        }


        

        /// <summary>
        /// Input miles 
        /// </summary>
        private double InputDistance(String prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }


        /// <summary>
        /// Calculate dist
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;

        }
        private void CalculateFeet2()
        {
            feet = miles * 0.000189394;

        }

        private void CalculateFeet3()
        {
            feet = metres * 3.28084;

        }

        private void CalculateMetres()
        {
            metres = miles * 1609.34;
        }

        private void CalculateMetres2()
        {
            miles = metres * 0.000621371;
        }

        private void CalculateMetres3()
        {
            metres = feet * 0.3048;
        }

        private void CalculateKilometres()
        {
            Kilometres = miles * 1.60934;
        }

        private void CalculateKilometres2()
        {
            miles = Kilometres  * 0.621371;
        }


        /// <summary>
        /// Output dist 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is " + feet + "feet");
        }
        private void OutputMetres()
        {
            Console.WriteLine(miles + "miles is " + metres + "metres");
        }
        private void OutputKilometres()
        {
            Console.WriteLine(miles + "miles is " + Kilometres + "kilometres");
        }
        private void OutputFeet2()
        {
            Console.WriteLine(miles + "feet is " + feet + "miles");
        }
        private void OutputMetres2()
        {
            Console.WriteLine(miles + "metres is " + metres + "miles");
        }
        private void OutputKilometres2()
        {
            Console.WriteLine(miles + "kilometres is " + Kilometres + "miles");
        }

        private void OutputFeet3()
        {
            Console.WriteLine(miles + "feet is " + feet + "metres");
        }

        private void OutputMetres3()
        {
            Console.WriteLine(miles + "metres is " + metres + "feet");
        }

        public void PrintHeading()
        {
            Console.WriteLine("\n_____________________");
            Console.WriteLine("\t\tConvert Distances");
            Console.WriteLine("\t\tBy Jordan Njie");
            Console.WriteLine("\n_____________________");
        }
    }
}
