﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TestClass
{
    public class Class1    {
        [TestFixture]
        public class TriangleTest1
        {
            [Test]
            public void ValidEquilateralTriangle_Input50and50and50_OutputValidEquilateralTriangle() 
            {
                //Arrange
                int firstSide = 50;
                int secondSide = 50;
                int thirdSide = 50;

                string expected = "Equilateral triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide,secondSide,thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
                
            }
            [Test]
            public void ValidIsoscelesTriangle_Input40and50and50_OutputValidIsoscelesTriangle()
            {
                //Arrange
                int firstSide = 40;
                int secondSide = 50;
                int thirdSide = 50;

                string expected = "Isosceles triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void ValidIsoscelesTriangle_Input50and40and50_OutputValidIsoscelesTriangle()
            {
                //Arrange
                int firstSide = 50;
                int secondSide = 40;
                int thirdSide = 50;

                string expected = "Isosceles triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void ValidIsoscelesTriangle_Input50and50and40_OutputValidIsoscelesTriangle()
            {
                //Arrange
                int firstSide = 50;
                int secondSide = 50;
                int thirdSide = 40;

                string expected = "Isosceles triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void ValidScaleneTriangle_Input30and40and50_OutputValidScaleneTriangle()
            {
                //Arrange
                int firstSide = 30;
                int secondSide = 40;
                int thirdSide = 50;

                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void ValidScaleneTriangle_Input30and50and40_OutputValidScaleneTriangle()
            {
                //Arrange
                int firstSide = 30;
                int secondSide = 50;
                int thirdSide = 40;

                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void ValidScaleneTriangle_Input40and30and50_OutputValidScaleneTriangle()
            {
                //Arrange
                int firstSide = 40;
                int secondSide = 30;
                int thirdSide = 50;

                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void ValidScaleneTriangle_Input40and50and30_OutputValidScaleneTriangle()
            {
                //Arrange
                int firstSide = 40;
                int secondSide = 50;
                int thirdSide = 30;

                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void ValidScaleneTriangle_Input50and40and30_OutputValidScaleneTriangle()
            {
                //Arrange
                int firstSide = 50;
                int secondSide = 40;
                int thirdSide = 30;

                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void ValidScaleneTriangle_Input50and30and40_OutputValidScaleneTriangle()
            {
                //Arrange
                int firstSide = 50;
                int secondSide = 30;
                int thirdSide = 40;

                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void AnalyzeTriangle_Input0and40and50_OutputInvalidTriangleOneSideZero()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 40;
                int thirdSide = 50;

                string expected = "Invalid Triangle - a zero has been detected";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void AnalyzeTriangle_Input0and0and50_OutputInvalidTriangleTwoSideZero()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 50;

                string expected = "Invalid Triangle - a zero has been detected";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void AnalyzeTriangle_Input0and0and0_OutputInvalidTriangleThreeSideZero()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 0;

                string expected = "Invalid Triangle - a zero has been detected";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void AnalyzeTriangle_Input3and4and50_OutputInvalidTriangleSumofOneAndSecondSidesLessThanThirdSide()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 50;

                string expected = "INVALID!!";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void AnalyzeTriangle_Input3and50and4_OutputInvalidTriangleSumofOneAndThirdSidesLessThanSecondSide()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 50;
                int thirdSide = 4;

                string expected = "INVALID!!";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }
            [Test]
            public void AnalyzeTriangle_Input50and3and4_OutputInvalidTriangleSumofSecondAndThirdSidesLessThanFirstSide()
            {
                //Arrange
                int firstSide = 50;
                int secondSide = 3;
                int thirdSide = 4;

                string expected = "INVALID!!";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));

            }

        }
    }
}
