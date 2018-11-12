using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module_6;

namespace UnitTestForModule6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //[TestCase(10, ExpectedResult = "314.159265358979")]
        public void TestAreaCircle_10()
        {
            double test;            
            Circle tmp = new Circle(10);

            test = tmp.Area();

            Assert.AreEqual(test, 314.159265358979);

        }

        [TestMethod]
        //[TestCase(10,5 ExpectedResult = "50")]
        public void TestAreaRec_5_10()
        {
            double test;
            Rectangle tmp = new Rectangle(5,10);

            test = tmp.Area();

            Assert.AreEqual(test, 50);

        }

        [TestMethod]
        //[TestCase(5 ExpectedResult = "25")]
        public void TestAreaSquare_5()
        {
            double test;
            Square tmp = new Square(5);

            test = tmp.Area();

            Assert.AreEqual(test, 25);

        }

        [TestMethod]
        //[TestCase(10,10,5 ExpectedResult = "50")]
        public void TestAreaTriAngle_10_5_10()
        {
            double test;
            Triangle tmp = new Triangle(10, 5, 10);

            test = tmp.Area();

            Assert.AreEqual(test, 24.206145913796);

        }


        [TestMethod]
        //[TestCase(10, ExpectedResult = "62.83185")]
        public void TestPerCircle_10()
        {
             double test;
             Circle tmp = new Circle(10);

             test = tmp.Perimeter();

             Assert.AreEqual(test, 62.83185);

        }

            [TestMethod]
            //[TestCase(10,5 ExpectedResult = "30")]
            public void TestPerRec_5_10()
            {
                double test;
                Rectangle tmp = new Rectangle(5, 10);

                test = tmp.Area();

                Assert.AreEqual(test, 30);

            }

            [TestMethod]
            //[TestCase(5 ExpectedResult = "20")]
            public void TestPerSquare_5()
            {
                double test;
                Square tmp = new Square(5);

                test = tmp.Area();

                Assert.AreEqual(test, 20);

            }

        [TestMethod]
        //[TestCase(10,10,5 ExpectedResult = "25")]
        public void TestPerTriAngle_10_5_10()
        {
            double test;
            Triangle tmp = new Triangle(10, 5, 10);

            test = tmp.Area();

            Assert.AreEqual(test, 25);

        }



    }
    }
