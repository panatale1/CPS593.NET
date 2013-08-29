using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var json = ConsoleApplication1.Program.GetProfile("panatale1");
            Assert.IsNotNull(json);
            Assert.IsTrue(json.Contains("Pete"));
        }
    }
}
