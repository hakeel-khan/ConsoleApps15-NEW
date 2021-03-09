﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
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
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("1. Distance Converter");
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine();

            Console.WriteLine("Please choose which app you would like to choose from > ");
            string choice = Console.ReadLine();

            if(choice == "1")
            {
                converter.ConvertDistance();
            }
            else if (choice == "2")
            {
                calculator.BMICalculation();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }


            //Console.WriteLine("Please choose from the following >");
            //Console.WriteLine();

            //DistanceConverter converter = new DistanceConverter();
            //converter.ConvertDistance();

            ///BMI calculator = new BMI();
            ///calculator.BMICalculation();
        }
    }
}
