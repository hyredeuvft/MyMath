using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest3
    {
        //Минимальное число в массиве-----------------------------------------------------------------
        [TestMethod]
        public void arr12345total1()
        {
            //Aarange
            double[] arr = { 1, 2, 3, 4, 5 };
            double total = 1;

            //Act
            double res = MyMath.Algebra.Min(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arr12345total5()
        {
            //Aarange
            double[] arr = { 1, 2, 3, 4, 5 };
            double total = 5;

            //Act
            double res = MyMath.Algebra.Min(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arrminus12345totalminus5()
        {
            //Aarange
            double[] arr = { -1, -2, -3, -4, -5 };
            double total = -5;

            //Act
            double res = MyMath.Algebra.Min(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arr123450totalminus5()
        {
            //Aarange
            double[] arr = { 1, -2, 3, -4, -5, 0 };
            double total = -5;

            //Act
            double res = MyMath.Algebra.Min(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arr123450totalminus501()
        {
            //Aarange
            double[] arr = { 1.12, -2.167, 3.009, -4, -5.1, 0.016 };
            double total = -5.1;

            //Act
            double res = MyMath.Algebra.Min(arr);

            //Assert
            Assert.AreEqual(total, res);
        }
    }
}
