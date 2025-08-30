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
            Point point = new Point();
            //point.SetX(2);
            //point.SetY(3);
            point.Print();

            point.X = 7;
            point.Y = 8;
            Console.WriteLine($" Properties: X = {point.X}, Y = {point.Y}");






        }
    }
}
