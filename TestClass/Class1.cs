using System;
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
        }
    }
}
