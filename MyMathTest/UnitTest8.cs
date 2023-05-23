using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest8
    {
        //Площадь ромба-----------------------------------------------------------------
        [TestMethod]
        public void firstdiagonal12seconddiagonal5total30()
        {
            //Aarange
            double firstdiagonal = 12;
            double seconddiagonal = 5;
            double total = 30;

            //Act
            double res = MyMath.Geometry.SquareRhombus(firstdiagonal, seconddiagonal);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void firstdiagonal5seconddiagonal14total5()
        {
            //Aarange
            double firstdiagonal = 5;
            double seconddiagonal = 14;
            double total = 5;

            //Act
            double res = MyMath.Geometry.SquareRhombus(firstdiagonal, seconddiagonal);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void firstdiagonal16seconddiagonal3total24()
        {
            //Aarange
            int firstdiagonal = 16;
            int seconddiagonal = 3;
            double total = 24;

            //Act
            double res = MyMath.Geometry.SquareRhombus(firstdiagonal, seconddiagonal);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void firstdiagonalminus123seconddiagonal12total0()
        {
            //Aarange
            int firstdiagonal = -123;
            int seconddiagonal = 12;
            double total = 0;

            //Act
            double res = MyMath.Geometry.SquareRhombus(firstdiagonal, seconddiagonal);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void firstdiagonal512seconddiagonal1409total3608449()
        {
            //Aarange
            double firstdiagonal = 5.12;
            double seconddiagonal = 14.09;
            double total = 36.0704;

            //Act
            double res = MyMath.Geometry.SquareRhombus(firstdiagonal, seconddiagonal);

            //Assert
            Assert.AreEqual(total, res);
        }
    }
}
