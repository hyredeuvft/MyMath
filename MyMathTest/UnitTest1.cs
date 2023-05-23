using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest1
    {
        //Сумма чисел в массиве-----------------------------------------------------------------
        [TestMethod]
        public void arr12345total15()
        {
            //Aarange
            double[] arr = { 1, 2, 3, 4, 5 };
            double total = 15;

            //Act
            double res = MyMath.Algebra.Sum(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arr12345total17()
        {
            //Aarange
            double[] arr = { 1, 2, 3, 4, 5 };
            double total = 17;

            //Act
            double res = MyMath.Algebra.Sum(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arrminus12345total15()
        {
            //Aarange
            double[] arr = { -1, -2, -3, -4, -5 };
            double total = -15;

            //Act
            double res = MyMath.Algebra.Sum(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arr123450total7()
        {
            //Aarange
            double[] arr = { 1, -2, 3, -4, -5, 0 };
            double total = -7;

            //Act
            double res = MyMath.Algebra.Sum(arr);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void arr123450total17()
        {
            //Aarange
            double[] arr = { 1.12, -2.167, 3.009, -4, -5.1, 0.016 };
            double total = -7.122;

            //Act
            double res = MyMath.Algebra.Sum(arr);

            //Assert
            Assert.AreEqual(total, res);
        }   
    }
}
