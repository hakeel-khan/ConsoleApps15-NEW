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
        private double miles;

        private double feet;

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
        /// <summary>
        /// In this method it will calculate the feet
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }
        /// <summary>
        /// Here when the programmed is running it will output the feet
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is" + feet + "Feet!");
        }

    }
}
