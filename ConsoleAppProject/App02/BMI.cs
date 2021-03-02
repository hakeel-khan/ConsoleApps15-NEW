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
            double weightInStones;
            double weightInPounds;
            double heightInFeet;
            double heightInInches;
            double weightInKg;
            double heightInMetres;


        public void OutputHeading()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("------Body Mass Index Calculator------");
            Console.WriteLine("-----------By Hakeel Khan-------------");
            Console.WriteLine("--------------------------------------");

        }


    }
}
