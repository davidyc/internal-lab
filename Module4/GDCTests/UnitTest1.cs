using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module4;

namespace GDCTests
{
    [TestClass]
    public class UnitTest1
    {
              
        [TestMethod]
        //[TestCase(100, 1000, ExpectedResult = 100)]
        public void Test1()
        {    
            int actial = Task2.GCD(100, 1000); 
            
            Assert.AreEqual(100, actial); 
        }              
       
        [TestMethod]
        //[TestCase(100, 20, 200 ExpectedResult = 20)]
        public void Test2()
        {           
            int actial = Task2.GCD(100, 20, 200);
            
            Assert.AreEqual(20, actial);
        }

        [TestMethod]
        //[TestCase(15, 20, 200, 100 ExpectedResult = 5)]
        public void Test3()
        {
            int actial = Task2.GCD(15, 20, 200, 100);

            Assert.AreEqual(5, actial);
        }

        [TestMethod]
        //[TestCase(100, 1000, ExpectedResult = 100)]
        public void Test4()
        {
            int actial = Task2.BinaryGCD(100, 1000);

            Assert.AreEqual(100, actial);
        }

        [TestMethod]
        //[TestCase(100, 20, 200 ExpectedResult = 20)]
        public void Test5()
        {
            int actial = Task2.BinaryGCD(100, 20, 200);

            Assert.AreEqual(20, actial);
        }

        [TestMethod]
        //[TestCase(15, 20, 200, 100 ExpectedResult = 5)]
        public void Test6()
        {
            int actial = Task2.BinaryGCD(15, 20, 200, 100);

            Assert.AreEqual(5, actial);
        }




    }

}
