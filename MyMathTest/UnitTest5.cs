using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest5
    {
        //Площадь треугольника-----------------------------------------------------------------
        [TestMethod]
        public void side5high14total35()
        {
            //Aarange
            double side = 5;
            double high = 14;
            double total = 35;

            //Act
            double res = MyMath.Geometry.SquareTriangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void side5high14total5()
        {
            //Aarange
            double side = 5;
            double high = 14;
            double total = 5;

            //Act
            double res = MyMath.Geometry.SquareTriangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void side16high3total24()
        {
            //Aarange
            int side = 16;
            int high = 3;
            double total = 24;

            //Act
            double res = MyMath.Geometry.SquareTriangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void sideminus123high123total0()
        {
            //Aarange
            int side = -123;
            int high = 123;
            double total = 0;

            //Act
            double res = MyMath.Geometry.SquareTriangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void side5122high1409total3608449()
        {
            //Aarange
            double side = 5.12;
            double high = 14.09;
            double total = 36.0704;

            //Act
            double res = MyMath.Geometry.SquareTriangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }
    }
}
