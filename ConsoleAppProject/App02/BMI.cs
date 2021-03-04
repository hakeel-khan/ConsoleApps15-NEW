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
        private double weightImperial;
        private double heightImperial;
        private double imperialBMI;
        private double metricBMI;




        public void OutputHeading()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("------Body Mass Index Calculator------");
            Console.WriteLine("-----------By Hakeel Khan-------------");
            Console.WriteLine("--------------------------------------");

        }

        public void BMICalculation()
        {
            OutputHeading();
            SelectUnit();
            if (unitType == "1")
            {
                InputWeightInImperialUnit();
                InputHeightInImperialUnit();

                ImperialCalculation();
                BMIResults(imperialBMI);
            }
            else if (unitType == "2")
            {
                InputWeightInMetricUnit();
                InputHeightInMetricUnit();

                MetricCalculation();
                BMIResults(metricBMI);
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
            double newPounds = stones * 14;
            weightImperial = pounds + newPounds;

            double newInches = feet * 12;
            heightImperial = inches + newInches;

            imperialBMI = (weightImperial * 703) / (heightImperial * heightImperial);
        }

        private void MetricCalculation()
        {
            metricBMI = kg / (metres * metres);
        }

        private void BMIResults(double BMI)
        {
            if (BMI < 18.5)
            {
                Console.WriteLine(" Your BMI result is "+ BMI);
                Console.WriteLine();
                Console.WriteLine(" You are underweight! ");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine(" Your BMI result is "+ BMI);
                Console.WriteLine();
                Console.WriteLine(" You are normal! ");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are overweight! ");
            }
            else if (BMI >= 30 && BMI <= 34.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are obese class 1! ");
            }
            else if (BMI >= 35 && BMI <= 39.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are obese class 2! ");
            }
            else if (BMI >= 40 )
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are obese class 3! ");
            }
        }

        private void PrintBAME()
        {
            Console.WriteLine("If you are Black, Asian or other ethnic groups,\n\r" +
                "you have a higher risk.\n\r\n\r" +
                "Adults 23 or more are at increased risk\n\r" +
                "Adults 27.5 or more are at high risk\n\r\n\r");
        }

    }
}
