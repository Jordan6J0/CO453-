using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Jordan Njie version 0.1
    /// </author>
    namespace BMI_04._01._2021
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Please enter your weight in kilograms: ");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter your height in meters: ");
                double height = Convert.ToDouble(Console.ReadLine());

                double bmi = weight / (height * height);

                try
                {
                    if (bmi <= 18.4)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: Under Weight.");
                    }
                    else if (bmi >= 18.5 && bmi <= 24.9)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: Normal Weight.");
                    }
                    else if (bmi >= 25 && bmi <= 29.9)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: Over Weight.");
                    }
                    else if (bmi >= 30 && bmi <= 34.9)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: in Obesity Class 1.");
                    }
                    else if (bmi >= 35 && bmi <= 39.9)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: in Obesity Class 2.");
                    }
                    else if (bmi >= 40)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: in Obesity Class 3.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter reasonable values.");
                    }

                }
                catch (Exception errors)
                {
                    Console.WriteLine("There was an error: " + errors.Message);
                }

                Console.ReadLine();

            }
        }
    }
}
