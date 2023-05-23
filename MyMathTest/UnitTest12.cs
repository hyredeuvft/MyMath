using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest12
    {
        //Тангенс-----------------------------------------------------------------
        [TestMethod]
        public void cathetus12hypotenuse12total1()
        {
            //Aarange
            double firstcathetus = 12;
            double secondcathetus = 12;
            double total = 1;

            //Act
            double res = MyMath.Trigonometry.Tg(firstcathetus, secondcathetus);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void cathetus12hypotenuse12total30()
        {
            //Aarange
            double firstcathetus = 12;
            double secondcathetus = 12;
            double total = 30;

            //Act
            double res = MyMath.Trigonometry.Tg(firstcathetus, secondcathetus);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void cathetusminus12hypotenuse12total0()
        {
            //Aarange
            double firstcathetus = -12;
            double secondcathetus = 12;
            double total = 0;

            //Act
            double res = MyMath.Trigonometry.Tg(firstcathetus, secondcathetus);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void cathetus25hypotenuse2total125()
        {
            //Aarange
            double firstcathetus = 25;
            double secondcathetus = 2;
            double total = 12.5;

            //Act
            double res = MyMath.Trigonometry.Tg(firstcathetus, secondcathetus);

            //Assert
            Assert.AreEqual(total, res);
        }

        [TestMethod]
        public void cathetus129hypotenuse12total1075()
        {
            //Aarange
            double firstcathetus = 12.9;
            double secondcathetus = 1.2;
            double total = 10.75;

            //Act
            double res = MyMath.Trigonometry.Tg(firstcathetus, secondcathetus);

            //Assert
            Assert.AreEqual(total, res);
        }
    }
}
