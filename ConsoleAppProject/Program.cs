﻿using ConsoleAppProject.App01;
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
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();
            Console.WriteLine(GetHeading("Distance Converter"));

            DistanceConverter converter = new DistanceConverter();
            converter.Run();

        }
        private static string GetHeading(string title)
        {
            return "--------------------------------\n" 
                + "\t" + title 
                + "\n\tHakeel Khan" +
                "\n--------------------------------\n";
        }
    }
}
