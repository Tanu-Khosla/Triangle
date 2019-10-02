using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;
using NUnit.Framework;

namespace TestAssignment
{
    class TestTriangle
    {
        [Test]
        public void Analyze_input_first_6_second_6_third_5_expectedOutput_isosceles()
        {
            //Arrange
            int a = 6;
            int b = 6;
            int c = 5;
            String r = "This is an isosceles triangle";
            //Act
            String actualOutput = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual(r, actualOutput);
        }
        [Test]
        public void Analyze_input_first_6_second_4_third_4_expectedOutput_isosceles()
        {
            //Arrange
            int a = 6;
            int b = 4;
            int c = 4;
            String r = "This is an isosceles triangle";
            //Act
            String actualOutput = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual(r, actualOutput);
        }
        [Test]
        public void Analyze_input_first_4_second_6_third_6_expectedOutput_isosceles()
        {
            //Arrange
            int a = 4;
            int b = 6;
            int c = 6;
            String r = "This is an isosceles triangle";
            //Act
            String actualOutput = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual(r, actualOutput);
        }
        [Test]
        public void Analyze_input_first_8_second_9_third_10_expectedOutput_scalene()
        {
            //Arrange
            int a = 8;
            int b = 9;
            int c = 10;
            String r = "This is a scalene triangle";
            //Act
            String actualOutput = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual(r, actualOutput);
        }
        [Test]
        public void Analyze_input_first_4_second_7_third_9_expectedOutput_scalene()
        {
            //Arrange
            int a = 4;
            int b = 7;
            int c = 9;
            string r = "This is a scalene triangle";
            //Act
            String actualOutput = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual(r, actualOutput);
        }
        [Test]
        public void Analyze_input_first_20_second_30_third_32_expectedOutput_scalene()
        {
            //Arrange
            int a = 20;
            int b = 30;
            int c = 32;
            String r = "This is a scalene triangle";
            //Act
            String actualOutput = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual(r, actualOutput);
        }
        [Test]
        public void Analyze_input_first_2_second_2_third_2_expectedOutput_equilateral()
        {
            //Arrange
            int a = 2;
            int b = 2;
            int c = 2;
            String r = "This is an equilateral triangle";
            //Act
            String actualOutput = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual(r, actualOutput);
        }
        [Test]
        public void Analyze_input_first_3_second_3_third_3_expectedOutput_equilateral()
        {
            //Arrange
            int a = 3;
            int b = 3;
            int c = 3;
            String r = "This is an equilateral triangle";
            //Act
            String actualOutput = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual(r, actualOutput);
        }
    }
}
