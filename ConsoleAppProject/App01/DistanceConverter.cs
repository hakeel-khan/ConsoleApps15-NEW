using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            InputMiles();
            CalculateMetres();
            OutputMetres();
        }

        /// <summary>
        /// Here we will use the Run method to call it in the program class which will allow it to run
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Here the user will input the Miles
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        /// <summary>
        /// In this method it will calculate the feet
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }
        /// <summary>
        /// Here when the programmed is running it will output the feet
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " Feet! ");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles! ");
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres! ");
        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("\n-------------------Distance Converter---------------------");
            Console.WriteLine("\n-------------------By Hakeel Khan---------------------");
            Console.WriteLine("\n----------------------------------------");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

    }
}
