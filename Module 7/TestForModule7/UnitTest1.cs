using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module_Task2;

namespace TestForModule7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       // TitleCase("a an the of", "a clash of KINGS") => "A Clash of Kings"
        public void TestMethod1()
        {
            string sente = " clash of KINGS";
            string except = "a an the of";
            string result = "A Clash of Kings";

            Assert.AreEqual(result, TitleSenten.ConvertToTitleSentence(sente, except));
        }

        [TestMethod]
        // TitleCase("The In", "THE WIND IN THE WILLOWS") => "The Wind in the Willows"
        public void TestMethod2()
        {
            string sente = "THE WIND IN THE WILLOWS";
            string except = "The in";
            string result = "The Wind in the Willows";

            Assert.AreEqual(result, TitleSenten.ConvertToTitleSentence(sente, except));
        }

        [TestMethod]
        //TitleCase("the quick brown fox") => "The Quick Brown Fox"
        public void TestMethod3()
        {
            string sente = "the quick brown fox";            
            string result = "The Quick Brown Fox";

            Assert.AreEqual(result, TitleSenten.ConvertToTitleSentence(sente));
        }
    }
}

