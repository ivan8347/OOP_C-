#define DISTANCE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if DISTANCE
            Point point = new Point();
            //point.SetX(2);
            //point.SetY(3);
            //point.Print();

            /*point.X = 7;
            point.Y = 8;
            Console.WriteLine($" Properties: X = {point.X}, Y = {point.Y}");*/
            Point p1 = new Point(0, 0);
            Point p2 = new Point(18, 16);

            Console.WriteLine($" Properties p1: X = {p1.X}, Y = {p1.Y}");
            Console.WriteLine($" Properties p2: X = {p2.X}, Y = {p2.Y}");
            Console.WriteLine($"Растояние между точками: {p1.distance(p2)}");

#endif

        }
    }
}
