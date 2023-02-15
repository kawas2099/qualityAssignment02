using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriangleSolver;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // equilateral
        [TestMethod]
        public void AnalyzeTriangle_Equilateral_ThreeEqualSides()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;
            string output = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            //Act
            Triangle triangle = new Triangle();
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(output, actual);
        }

        // isosceles (3)

        public void AnalyzeTriangle_Isoceles_FirstSideDifferent()
        {
            //Arrange
            int firstSide = 4;
            int secondSide = 5;
            int thirdSide = 5;
            string output = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            Triangle triangle = new Triangle();
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(output, actual);
        }

        public void AnalyzeTriangle_Isoceles_SecondSideDifferent()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 5;
            string output = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            Triangle triangle = new Triangle();
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(output, actual);
        }

        public void AnalyzeTriangle_Isoceles_ThirdSideDifferent()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 4;
            string output = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            Triangle triangle = new Triangle();
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(output, actual);
        }

        //scalene

        public void AnalyzeTriangle_Scalene_AllSideDifferent()
        {
            //Arrange
            int firstSide = 4;
            int secondSide = 5;
            int thirdSide = 3;
            string output = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangle = new Triangle();
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(output, actual);
        }
        public void AnalyzeTriangle_Scalene_AllSideDifferent2()
        {
            //Arrange
            int firstSide = 40;
            int secondSide = 50;
            int thirdSide = 30;
            string output = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangle = new Triangle();
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(output, actual);
        }
        public void AnalyzeTriangle_Scalene_AllSideDifferent3()
        {
            //Arrange
            int firstSide = 12;
            int secondSide = 15;
            int thirdSide = 9;
            string output = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangle = new Triangle();
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(output, actual);
        }
        public void AnalyzeTriangle_Scalene_AllSideDifferent4()
        {
            //Arrange
            int firstSide = 22;
            int secondSide = 28;
            int thirdSide = 30;
            string output = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangle = new Triangle();
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(output, actual);
        }
        public void AnalyzeTriangle_Scalene_AllSideDifferent5()
        {
            //Arrange
            int firstSide = 8000;
            int secondSide = 10000;
            int thirdSide = 60000;
            string output = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangle = new Triangle();
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(output, actual);
        }

    }
}
