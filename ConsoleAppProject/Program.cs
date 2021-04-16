﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Hakeel Khan 01/02/2021
    /// </summary>
    public static class Program
    {   
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI calculator = new BMI();
        private static StudentGrades studentGrades = new StudentGrades();
        public static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;


            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020 - 2021!");

            string[] choices = { "Distance Converter", "BMI Calculator", "Student Marks" };
            int choiceNo = ConsoleHelper.SelectChoice(choices);

            if(choiceNo == 1)
            {
                converter.ConvertDistance();
            }
            else if (choiceNo == 2)
            {
                calculator.BMICalculation();
            }
            else if (choiceNo == 3)
            {
                studentGrades.RunStudentGrades();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

            
        }
    }
}
