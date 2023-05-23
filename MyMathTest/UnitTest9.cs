using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest9
    {
        //Площадь круга-----------------------------------------------------------------
        [TestMethod]
        public void radius5total628()
        {
            //Aarange
            double radius = 1;
            double total = 6.28;

            //Act
            double res = MyMath.Geometry.SquareCircle(radius);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void radius0total5()
        {
            //Aarange
            double radius = 0;
            double total = 5;

            //Act
            double res = MyMath.Geometry.SquareCircle(radius);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void radius23total14444()
        {
            //Aarange
            int radius = 23;
            double total = 144.44;

            //Act
            double res = MyMath.Geometry.SquareCircle(radius);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void radiusminus5total75645()
        {
            //Aarange
            int radius = -5;
            double total = 0;

            //Act
            double res = MyMath.Geometry.SquareCircle(radius);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void radius1298total81012()
        {
            //Aarange
            double radius = 12.9;
            double total = 81.012;

            //Act
            double res = MyMath.Geometry.SquareCircle(radius);

            //Assert
            Assert.AreEqual(total, res);
        }
    }
}
