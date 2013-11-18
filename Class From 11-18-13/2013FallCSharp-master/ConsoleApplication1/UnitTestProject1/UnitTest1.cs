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
            var zuck = ConsoleApplication1.Program.GetUserInfo("zuck");
            Assert.IsTrue(zuck.Contains("Mark"), "user name zuck should belong to Mark Zuckerberg");
        }

        [TestMethod]
        public void TestThatDogBarks()
        {
            var d = new Dog();
            var actual = d.Bark();
            Assert.AreEqual("woof", actual);
        }

        [TestMethod]
        public void TestThatDogCanSayOtherThings()
        {
            var d = new Dog();
            d.DogsWord = "meyow";
            //d.set_DogsWord("meyow");
            var actual = d.Bark();
            Assert.AreEqual("meyow", actual);
        }

        [TestMethod]
        public void TestThatDogCanSayLotsOfThings()
        {
            var d = new Dog();
            d.DogsWord = "meyow";

            d.LearnNewWord("Hello");
            d.LearnNewWord("How Are You");
            var actual = d.Bark();
            Assert.AreNotEqual("meyow", actual);
        }

        [TestMethod]
        public void TestThatDogCanRunAtAnySpeed()
        {
            var d = new Dog();
            d.Speed = "200";
            var actual = d.Run();
            Assert.AreEqual("I am running at 200 Miles an Hour", actual);
        }

        [TestMethod]
        public void TestDelegate()
        {
            Multiply MYFunc = (x,y) => x*y;

            Assert.AreEqual(4, MYFunc(2, 2));

            MYFunc = (x, y) => x - y;

            Assert.AreEqual(0, MYFunc(2, 2));
        }

        [TestMethod]
        public void TestDelegateSquared()
        {
            Func<int, int> Squared = x => x * x;

            Assert.AreEqual(4, Squared(2));
            Assert.AreEqual(9, Squared(3));
        }

    }
}
