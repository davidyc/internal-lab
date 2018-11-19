using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_7;

namespace TestForTask7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PolishNatationCanculete1()
        {
            int result = 20;
            string polishNatationExam = "10 2 5 * +";

            var resultOfFunction = PolishNatationCanculate.PolishNatationCanculete(polishNatationExam);

            Assert.AreEqual(result, resultOfFunction);
        }

        [TestMethod]
        public void PolishNatationCanculete2()
        {
            int result = 70;
            string polishNatationExam = "10 4 2 * * 10 -";

            var resultOfFunction = PolishNatationCanculate.PolishNatationCanculete(polishNatationExam);

            Assert.AreEqual(result, resultOfFunction);
        }

        [TestMethod]
        public void PolishNatationCanculete3()
        {
            int result = -8;
            string polishNatationExam = "10 2 + 4 2 / 10 * -";

            var resultOfFunction = PolishNatationCanculate.PolishNatationCanculete(polishNatationExam);

            Assert.AreEqual(result, resultOfFunction);
        }
    }
}
