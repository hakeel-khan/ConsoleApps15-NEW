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
        public string [] Students { get; set; }

        public int [] Marks { get; set; }

        public int [] GradeProfile { get; set; }

        public double [] Mean { get; set; }

        public int [] Minimum { get; set; }

        public int[] Maximum { get; set; }

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
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }
    }


}
