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

            miles = InputDistance(" Enter the number of miles : " );
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance(" Enter the number of Feet : ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            miles = InputDistance(" Enter the number of miles : ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        /// <summary>
        /// Here the user will input the Miles
        /// </summary>
        
         private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
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
        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("\n------------Distance Converter------------");
            Console.WriteLine("\n------------By Hakeel Khan----------------");
            Console.WriteLine("\n------------------------------------------");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

    }
}
