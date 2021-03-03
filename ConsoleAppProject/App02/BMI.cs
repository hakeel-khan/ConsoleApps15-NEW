using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Here in this App it will be a Body Mass Index calculator which will calculate the users height and weight and health risks.
    /// </summary>
    /// <author>
    /// Student Hakeel Khan version 0.1
    /// </author>
    public class BMI
    {

        private string unitType;
        private double feet;
        private double inches;
        private double stones;
        private double pounds;
        private double kg;
        private double metres;

        public void OutputHeading()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("------Body Mass Index Calculator------");
            Console.WriteLine("-----------By Hakeel Khan-------------");
            Console.WriteLine("--------------------------------------");

        }

        private string BMICalculation()
        {
            OutputHeading();
            SelectUnit();
            if (unitType == "1")
            {
                InputWeightInImperialUnit();
                InputHeightInImperialUnit();
            }
            else if (unitType == "2")
            {
                InputWeightInMetricUnit();
                InputHeightInMetricUnit();
            }


        }

        private void InputWeightInMetricUnit()
        {
            Console.WriteLine(" Please enter your weight to the nearest KG");
            Console.WriteLine();

            Console.Write(" Enter your weight in KG > ");
            kg = Convert.ToDouble(Console.ReadLine());

        }

        private void InputHeightInMetricUnit()
        {
            Console.WriteLine(" Please enter your height to the nearest Metres");
            Console.WriteLine();

            Console.Write(" Enter your height in Metres > ");
            metres = Convert.ToDouble(Console.ReadLine());
        }

        private void InputHeightInImperialUnit()
        {
            Console.WriteLine(" Please enter your height to the nearest feet and inches");
            Console.WriteLine();

            Console.Write(" Enter your height in feet > ");
            feet = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter your height in inches > ");
            inches = Convert.ToDouble(Console.ReadLine());
        }

        private void InputWeightInImperialUnit()
        {
            Console.WriteLine(" Please enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Console.Write(" Enter your weight in stones > ");
            stones = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter your weight in pounds > ");
            pounds = Convert.ToDouble(Console.ReadLine());
        }

        private void SelectUnit()
        {
            Console.WriteLine(" Please choose which unit you would like?");
            Console.WriteLine(" 1. Imperial unit ");
            Console.WriteLine(" 2. Metric unit ");
            Console.Write(" Please input your choice > ");
            unitType = Console.ReadLine();
        }

        private void ImperialCalculation()
        {
            Console.WriteLine(" Please enter your height in foot and inches > ");
            Console.Write(" Please enter your height in feet ");
        }

        private void MetricCalculation()
        {

        }

    }
}
