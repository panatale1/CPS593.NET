using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Linq;

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
            v.BreakDown("OUt of Gas");
            Assert.IsTrue(v.Log.Contains("Broke"));
        }
        [TestMethod]
        public void PlaneCanFly()
        {
            var v = new Plane();
            v.Drive();
            Assert.IsTrue(v.Log.Contains("Flew"));
            v.BreakDown("Engine Failure");
            Assert.IsTrue(v.Log.Contains("Fell"));
            v.BreakDown = x => v.Log += "\nWe Are Just Fine" + x;
            v.Log = "";
            v.BreakDown("Gremlins");
            Assert.IsTrue(v.Log.Contains("Fine"));
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
            Assert.IsTrue(v.Log.Contains("Autobot"));
        }
        IEnumerable<int> numbers = Enumerable.Range(0,100);
        [TestMethod]
        public void Linq101(){
            //var numbers = new[] { 0, 1, 2, 3, 4, 5 };
            var actual = new List<int>();
            foreach (var x in numbers)
            {
                if (x % 2 == 0)
                {
                    actual.Add(x);
                }
            }
            var actual2 = numbers.Where(y => y % 2 == 0);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(3, numbers.Count(y => y % 2 == 0));
        }
        [TestMethod]
        public void LinqSelect()
        {
            var actual = numbers.Select(x => x*x);
            Assert.IsTrue(actual.Contains(9801));

            var actual2 = numbers.Where(x => x % 3 == 0).Select(x => x * x);
            Assert.IsTrue(actual2.Contains(9801));
        }
        [TestMethod]
        public void LinqComplex()
        {
            var processes = System.Diagnostics.Process.GetProcesses();

            //var name = processes.Where(x => x.Threads.OfType<System.Diagnostics.ProcessThread>().Average(t => t.TotalProcessorTime.Milliseconds) > 100).Select(x => x.ProcessName);

            var names = processes.Select(x => new { x.ProcessName, ThreadCount = x.Threads.Count}).Where(x => x.ThreadCount < 10);

            var otherStuff = from x in processes 
                             where x.Modules.OfType<System.Diagnostics.ProcessModule>().Any(y => y.ModuleMemorySize > 1000)
                             orderby x.ProcessName
                             select new { x.ProcessName, x.PeakWorkingSet64, x.Responding };
        }
    }
}
