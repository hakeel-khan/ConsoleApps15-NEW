using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{

    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        private int[] testMarks;

        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }

        private readonly int[] StatsMarks = new int[]
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };

        [TestMethod]
        public void TestCalculateGradesMinAndMaxOfAllGrades()
        {
            converter.Marks = new int[]
            {
                0, 39, 40, 49, 50, 59, 60, 69, 70, 100
            };

            Grades[] expectedGrades = new Grades[]
            {
                //Grade F
                (Grades)0, (Grades)0,

                //Grade D
                (Grades)1, (Grades)1,

                //Grade C
                (Grades)2, (Grades)2,

                //Grade B
                (Grades)3, (Grades)3,

                //Grade A
                (Grades)4, (Grades)4,
            };

            converter.CalculateGrades();

            //Testing the items of the expected array items 
            // and the actual array items are they equal
            CollectionAssert.AreEqual(converter.Grades, expectedGrades);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            //Arrange 
            converter.Marks = testMarks;
            double expectedMean = 55.0;

            //Act
            converter.CalculateMean();

            //Assert
            Assert.AreEqual(expectedMean, converter.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            //Arrange 
            converter.Marks = StatsMarks;
            int expectedMin = 10;

            //Act
            converter.CalculateMean();

            //Assert
            Assert.AreEqual(expectedMin, converter.Minimum);
        }

        [TestMethod]
        public void TestCalculateMax()
        {
            //Arrange 
            converter.Marks = StatsMarks;
            int expectedMax = 100;

            //Act
            converter.CalculateMean();

            //Assert
            Assert.AreEqual(expectedMax, converter.Maximum);
        }

        [TestMethod]
        public void TestCalculateGradeProfiles()
        {
            converter.Grades = new Grades[]
            {
                //Grade F
                (Grades)0, (Grades)0,

                //Grade D
                (Grades)0, (Grades)1,

                //Grade C
                (Grades)2, (Grades)3,

                //Grade B
                (Grades)4, (Grades)4,

                //Grade A
                (Grades)4, (Grades)4,
            };

            double[] expectedGradeProfiles = new double[]
            {
                30, 10, 10, 10, 40
            };

            converter.CalculateGradeProfile();
            
            //Testing the items of the expected array items 
            // and the actual array items are they equal
            CollectionAssert.AreEqual(converter.GradeProfile, expectedGradeProfiles);
        }
    }
}