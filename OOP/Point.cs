//#define POINT
#define DISTANCE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP;

namespace OOP
{
    internal class Point
    {
#if POINT
        public double X { get; set; }
        public double Y { get; set; }


        //double x;
        //double y;
        //public double X { get { return x; } set { x = value; } }
        //public double Y { get { return y; } set { y = value; } }

        //public double GetX() { return x; }
        //public double GetY() { return y; }
        //public void SetX(double x) { this.x = x; }
        //public void SetY(double y) { this.y = y; }

        //Methods
        public void Print() { Console.WriteLine($" X = {X} Y = {Y}"); }
        //public void Print() { Console.WriteLine($" X = {GetX()} Y = {GetY()}"); }

#endif
#if DISTANCE
        public double X { get; set; }
        public double Y { get; set; }
        //					Constructors:
        public Point(double x = 0, double y = 0)
        {
            this.X = x;
            this.Y = y;
        }
        //					Methods:
        public double distance(Point other)
        {
            double x_distance = other.X - this.X;
            double y_distance = other.Y - this.Y;
            return Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
        }

#endif





    }
}
