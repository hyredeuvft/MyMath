using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest6
    {
        //Площадь квадрата-----------------------------------------------------------------
        [TestMethod]
        public void side5total25()
        {
            //Aarange
            double side = 5;
            double total = 25;

            //Act
            double res = MyMath.Geometry.SquareSquare(side);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void side0total5()
        {
            //Aarange
            double side = 0;
            double total = 5;

            //Act
            double res = MyMath.Geometry.SquareSquare(side);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void side23total529()
        {
            //Aarange
            int side = 23;
            double total = 529;

            //Act
            double res = MyMath.Geometry.SquareSquare(side);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void sideminus5total75645()
        {
            //Aarange
            int side = -5;
            double total = 0;

            //Act
            double res = MyMath.Geometry.SquareSquare(side);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void side1298total1684804()
        {
            //Aarange
            double side = 12.98;
            double total = 168.4804;

            //Act
            double res = MyMath.Geometry.SquareSquare(side);

            //Assert
            Assert.AreEqual(total, res);
        }
    }
}
