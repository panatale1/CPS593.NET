using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

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
    }
}
