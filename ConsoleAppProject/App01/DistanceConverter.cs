using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will allow the user to input a distance as a unit (fromUnit) and
    /// it will calculate and output the distance (toUnit).
    /// </summary>
    /// <author>
    /// Hakeel version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;

        }

        /// <summary>
        /// Here this method will change the Distance from Miles to Feet.
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from distance unit : ");
            toUnit = SelectUnit(" Please select the to distance unit : ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Enter the number of {fromUnit} : " );

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            Calculation();
        }

        private void Calculation()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Here the user can input any distance
        /// </summary>

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Here when the programmed is running it will output the Distance
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }

        /// <summary>
        /// Here it will output the heading and the prompt
        /// </summary>
        /// <param name="prompt"></param>
        private void OutputHeading()
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("\n------------Distance Converter------------");
            Console.WriteLine("\n------------By Hakeel Khan----------------");
            Console.WriteLine("\n------------------------------------------");
        }

    }
}
