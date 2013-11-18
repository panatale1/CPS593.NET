using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class VehicleUnitTest
    {
        [TestMethod]
        public void VehicleCanDrive()
        {
            var v = new Vehicle();
            v.Drive();
            Assert.IsTrue(v.Log.Contains("Drove"));

            v.BreakDown("Out of gas");
            Assert.IsTrue(v.Log.Contains("Broke"));
        }

        [TestMethod]
        public void PlaneCanFly()
        {
            var v = new Plane();
            v.Drive();
            Assert.IsTrue(v.Log.Contains("Flew"));

            v.BreakDown("Engine failure");
            Assert.IsTrue(v.Log.Contains("Fell"));

            v.BreakDown = x => v.Log += "We are just fine " + x;

            v.Log = "";
            v.BreakDown("Gremlins");
            Assert.IsTrue(v.Log.Contains("fine"));
        }

        [TestMethod]
        public void CrashesHurt()
        {
            var v = new Vehicle();

            v.Crash(x => x);
            Assert.IsTrue(v.Log.Contains("1"));

            v.Crash(x => x * 55);
            Assert.IsTrue(v.Log.Contains("55"));
        }

        [TestMethod]
        public void VehiclesCanTransform()
        {
            var v = new Vehicle();
            v.Transform();

            Assert.IsTrue(v.Log.Contains("autobot"));
        }

        IEnumerable<int> numbers = Enumerable.Range(0, 100);

        [TestMethod]
        public void Linq101()
        {
            var actual = new List<int>();
            foreach (var x in numbers)
            {
                if (x % 2 == 0) actual.Add(x);
            }
            
            Assert.AreEqual(3, actual.Count);

            var actual2 = numbers.Where(i => i % 2 == 0);
            Assert.AreEqual(3, actual2.Count());

            Assert.AreEqual(3, numbers.Count(i=> i % 2 == 0));
        }

        [TestMethod]
        public void LinqSelect()
        {
            var actual = numbers.Select( x => x*x );
            Assert.IsTrue(actual.Contains(9801));

            var actual2 = numbers.Where(x=> x % 33 == 0).Select(x => x * x);
            Assert.IsTrue(actual2.Contains(9801));

        }

        [TestMethod]
        public void LinqComplex()
        {
            var proccesses = System.Diagnostics.Process.GetProcesses();

            var names = proccesses
                .Select(x => new { x.ProcessName, ThreadCount = x.Threads.Count })
                .Where(x=> x.ThreadCount < 10);


            var otherstuff = from x in proccesses
                             where x.Modules.Count > 5
                             orderby x.ProcessName
                             select new { x.ProcessName,  x.PeakWorkingSet64, x.Responding };

        }
    }
}
