using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentGrades
    {
        //Constants (Grade Boundaries)
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //Properties

        public string [] Students { get; set; }

        public int [] Marks { get; set; }

        public Grades [] Grades { get; set; }

        public double [] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        //Attributes

        public StudentGrades()
        {
            Students = new string[]
            {
                "Amar", "Hassan", "Aqib",
                "Adel", "Afzaal", "Rubel",
                "Amir", "Yusef", "Abdul",
                "Zain" };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// 
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }

            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }

            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }

            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }

            else if (mark >= LowestGradeA && mark < HighestMark)
            {
                return Grades.A;
            }

            else
            {
                return LowestMark;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateMean()
        {
            double total = 0;

            Maximum = Marks[0];
            Minimum = Marks[0];

            foreach (int mark in Marks)
            {
                if(mark > Maximum)
                {
                    Maximum = mark;
                }
                else if (mark < Minimum)
                {
                    Minimum = mark;
                }

                total += mark; 
            }
            Mean = total / Marks.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateStats()
        {

        }

        public void CalculateGradeProfile()
        {
            GradeProfile = new double[5];

            foreach (var grade in Grades)
            {

                    if (student.Grade == Grades.F)
                        GradeProfile[0]++;
                    else if (student.Grade == Grades.D)
                        GradeProfile[1]++;
                    else if (student.Grade == Grades.C)
                        GradeProfile[2]++;
                    else if (student.Grade == Grades.B)
                        GradeProfile[3]++;
                    else if (student.Grade == Grades.A)
                        GradeProfile[4]++;

            }

            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfiles[i] = GradeProfiles[i] * (100 / Students.Length);
            }
        }

        public void CalculateGrades()
        {

        }
    }


}
