using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest7
    {
        //Площадь прямоугольника-----------------------------------------------------------------
        [TestMethod]
        public void side5high12total60()
        {
            //Aarange
            double side = 5;
            double high = 12;
            double total = 60;

            //Act
            double res = MyMath.Geometry.SquareRectangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void side12high12total25()
        {
            //Aarange
            double side = 12;
            double high = 12;
            double total = 25;

            //Act
            double res = MyMath.Geometry.SquareRectangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void side76high2total152()
        {
            //Aarange
            int side = 76;
            int high = 2;
            double total = 152;

            //Act
            double res = MyMath.Geometry.SquareRectangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void sideminus5highminus12total0()
        {
            //Aarange
            int side = -5;
            int high = -12;
            double total = 0;

            //Act
            double res = MyMath.Geometry.SquareRectangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void side512high1201total614912()
        {
            //Aarange
            double side = 5.12;
            double high = 12.01;
            double total = 61.4912;

            //Act
            double res = MyMath.Geometry.SquareRectangle(side, high);

            //Assert
            Assert.AreEqual(total, res);
        }
    }
}
