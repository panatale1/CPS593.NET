using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

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
        [TestMethod]
        public void TestThatDogBarks()
        {
            var d = new Dog();
            var actual = d.Bark();
            Assert.AreEqual("woof", actual);
        }
        [TestMethod]
        public void TestThatDogSaysOtherThings()
        {
            var d = new Dog();
            d.DogsWord = "meyow";
            var actual = d.Bark();
            Assert.AreEqual("meyow",actual);
        }

        [TestMethod]
        public void TestThatDogCanRunAtAnySpeed()
        {
            var d = new Dog();
            d.Speed = "200";
            var actual = d.Run();
            Assert.AreEqual("I am running at 200 miles per hour.", actual);
        }

        [TestMethod]
        public void TestThatDogSaysLotsThings()
        {
            var d = new Dog();
            d.DogsWord = "meyow";
            d.LearnNewWord("Hello");
            d.LearnNewWord("How Are You");
            var actual = d.Bark();
            Assert.AreNotEqual("meyow", actual);
        }

        [TestMethod]
        public void TestDelegate()
        {
            Multiply MyFunc = (x, y) => x * y ;
            Assert.AreEqual(4, MyFunc(2, 2));

            MyFunc = (x, y) => x - y;
            Assert.AreEqual(0, MyFunc(2, 2));

            Func<int, int> Squared = x => x * x;
            Assert.AreEqual(4, Squared(2));
            Assert.AreEqual(9, Squared(3));
        }
    }
}
