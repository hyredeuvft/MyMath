using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest4
    {
        //Среднее арифметическое число в массиве-----------------------------------------------------------------
        [TestMethod]
        public void arr12345total3()
        {
            //Aarange
            double[] arr = { 1, 2, 3, 4, 5 };
            double total = 3;

            //Act
            double res = MyMath.Algebra.Avg(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arr12345total1()
        {
            //Aarange
            double[] arr = { 1, 2, 3, 4, 5 };
            double total = 1;

            //Act
            double res = MyMath.Algebra.Avg(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arrminus12345totalminus3()
        {
            //Aarange
            double[] arr = { -1, -2, -3, -4, -5 };
            double total = -3;

            //Act
            double res = MyMath.Algebra.Avg(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arr123450totalminus05()
        {
            //Aarange
            double[] arr = { 1, -2, 3, -4, 5, 0 };
            double total = 0.5;

            //Act
            double res = MyMath.Algebra.Avg(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arr123450totalminus1187()
        {
            //Aarange
            double[] arr = { 1.12, -2.167, 3.009, -4, -5.1, 0.016 };
            double total = -1.187;

            //Act
            double res = MyMath.Algebra.Avg(arr);

            //Assert
            Assert.AreEqual(total, res);
        }
    }
}
