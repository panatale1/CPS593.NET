using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Vehicle
    {
        public Vehicle(){
            BreakDown = x => Log += "\nWe Broke Down";
        }
        public const int Speed = 10;
        public IEnumerable<string> Seats = new List<string> {"Driver","Shotgun","Rear", "Backseat Driver" };
        public String Log { get; set; }
        public virtual void Drive()
        {
            Log += "\nWe Drove Somewhere";
        }
        public Action<string> BreakDown { get; set; }
        public void Crash(Func<int, int> impact){
            foreach (var seat in Seats)
            {
                Log += "\n" + seat + " affected";
            }
            Log += "\nthat is: " + string.Join(", ", Seats);
            Log += "\r\nThe impact was: " + impact(Speed);
        }
    }

    public class Car:Vehicle
    {
        public void Park()
        {
            Drive();
            // get into parked state
        }
    }
    public class Plane : Vehicle
    {
        public Plane()
            : base()
        {
            BreakDown = (x) => Log += "\nWe Fell Down";
        }
        //Can only override VIRTUAL functions
        public override void Drive()
        {
            Log += "\nWe Flew Somewhere";
        }
    }

    public static class Extensions
    {
        public static void Transform(this Vehicle v)
        {
            v.Log += "\nI am now an Autobot";
        }
    }
    //LINQ kinda helps C# do functional programming
}
