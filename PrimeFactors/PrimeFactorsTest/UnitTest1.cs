using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFactors;

namespace PrimeFactorsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int toSend = 9;
            string res = Program.PrimeFactors(toSend);
            string exRes = "3 x 1";

            Assert.AreEqual(exRes, res);
        }
    }
}
