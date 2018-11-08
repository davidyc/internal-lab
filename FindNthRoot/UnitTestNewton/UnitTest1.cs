using System;
using FindNthRoot;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestNewton
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// [TestCase(1, 5, 0.0001,ExpectedResult =1)]       
        /// </summary>
        [TestMethod]
        public void TestCase1()
        {
            double test;
            test = FindNewtonRoot.NewtonRoot(1.0, 5, 0.0001);

            Assert.AreEqual(test, 1.0, 1);

        }

        /// <summary>
        /// [TestCase(8, 3, 0.0001, ExpectedResult = 2)]     
        /// </summary>
        [TestMethod]
        public void TestCase2()
        {
            double test;
            test = FindNewtonRoot.NewtonRoot(8, 3, 0.0001);

            Assert.AreEqual(test, 2.0, 1);

        }


        /// <summary>
        /// [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]    
        /// </summary>
        [TestMethod]
        public void TestCase3()
        {
            double test;
            test = FindNewtonRoot.NewtonRoot(0.001, 3, 0.0001);

            Assert.AreEqual(test, 0.1, 1);

        }

        
    }
}
