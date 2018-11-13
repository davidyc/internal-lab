using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module_Task2;
using Module7_Task3;

namespace UnitTestForModule7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // TitleCase("a an the of", "a clash of KINGS") => "A Clash of Kings"
        public void TestMethod1()
        {
            string sente = "a clash of KINGS";
            string except = "a an the of";
            string result = "A Clash of Kings ";

            Assert.AreEqual(result, TitleSenten.ConvertToTitleSentence(sente, except));
        }

        [TestMethod]
        // TitleCase("The In", "THE WIND IN THE WILLOWS") => "The Wind in the Willows"
        public void TestMethod2()
        {
            string sente = "THE WIND IN THE WILLOWS";
            string except = "The in";
            string result = "The Wind in the Willows ";

            Assert.AreEqual(result, TitleSenten.ConvertToTitleSentence(sente, except));
        }

        [TestMethod]
        //TitleCase("the quick brown fox") => "The Quick Brown Fox"
        public void TestMethod3()
        {
            string sente = "the quick brown fox";
            string result = "The Quick Brown Fox ";

            Assert.AreEqual(result, TitleSenten.ConvertToTitleSentence(sente));
        }

        [TestMethod]
        //AddOrChangeUrlParameter(«www.example.com », «key = value») => «www.example.com?key=value»
        public void TestMethodTask3_test1()
        {
            string URL = "www.example.com";
            string KeyValue = "key = value";

            string result = "www.example.com?key=value";

            Assert.AreEqual(result, URLString.AddOrChangeUrlParameter(URL, KeyValue));
        }


        [TestMethod]
        //AddOrChangeUrlParameter («www.example.com?key=value», «key2 = value2») =>  www.example.com?key=value&key2=value2
        public void TestMethodTask3_test2()
        {
            string URL = "www.example.com?key=value";
            string KeyValue = "key2 = value2";

            string result = "www.example.com?key=value&key2=value2";

            Assert.AreEqual(result, URLString.AddOrChangeUrlParameter(URL, KeyValue));
        }

        [TestMethod]
        //AddOrChangeUrlParameter(«www.example.com? key = oldValue», «key = newValue») => www.example.com?key=newValue
        public void TestMethodTask3_test3()
        {
            string URL = "www.example.com?key=oldValue";
            string KeyValue = "key=newValue";

            string result = "www.example.com?key=newValue";

            Assert.AreEqual(result, URLString.AddOrChangeUrlParameter(URL, KeyValue));
        }

        



    }
}
