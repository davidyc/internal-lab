using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module_6;
using Module_6_task_3;

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

            Assert.AreEqual(test, 314.159265358979,1);

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
            Triangle tmp = new Triangle(5, 10, 10);

            test = tmp.Area();

            Assert.AreEqual(test, 24.206145913796,1);

        }


        [TestMethod]
        //[TestCase(10, ExpectedResult = "62.83185")]
        public void TestPerCircle_10()
        {
             double test;
             Circle tmp = new Circle(10);

             test = tmp.Perimeter();

             Assert.AreEqual(test, 62.83185,1);

        }

            [TestMethod]
            //[TestCase(10,5 ExpectedResult = "30")]
            public void TestPerRec_5_10()
            {
                double test;
                Rectangle tmp = new Rectangle(5, 10);

                test = tmp.Perimeter();

                Assert.AreEqual(test, 30);

            }

            [TestMethod]
            //[TestCase(5 ExpectedResult = "20")]
            public void TestPerSquare_5()
            {
                double test;
                Square tmp = new Square(5);

                test = tmp.Perimeter();

                Assert.AreEqual(test, 20);

            }

        [TestMethod]
        //[TestCase(10,10,5 ExpectedResult = "25")]
        public void TestPerTriAngle_10_5_10()
        {
            double test;
            Triangle tmp = new Triangle(10, 5, 10);

            test = tmp.Perimeter();

            Assert.AreEqual(test, 25);

        }


        [TestMethod]
        public void TestPolynomialOperatorPlus3x3()
        {           
            Polynomial pol1 = new Polynomial(3);
            pol1[0] = 1;
            pol1[1] = 2;
            pol1[2] = 3;
         
            Polynomial pol2 = new Polynomial(3);
            pol2[0] = 4;
            pol2[1] = 3;
            pol2[2] = 4;

            Polynomial sum = new Polynomial(3);
            sum[0] = 5;
            sum[1] = 5;
            sum[2] = 7;         
      
            Assert.AreEqual(true, sum == pol1 + pol2);
        }


        [TestMethod]
        public void PolynomialOperatorMinus3x3()
        {

            Polynomial pol1 = new Polynomial(3);
            pol1[0] = 3;
            pol1[1] = 2;
            pol1[2] = 1;

            Polynomial pol2 = new Polynomial(3);
            pol2[0] = 2;
            pol2[1] = 1;
            pol2[2] = 5;

            Polynomial sum = new Polynomial(3);
            sum[0] = 1;
            sum[1] = 1;
            sum[2] = -4;          

            Assert.AreEqual(true, sum == pol1 - pol2); 
        }

      
    }



}
    
