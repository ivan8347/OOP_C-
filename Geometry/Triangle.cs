using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Triangle
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }
        public Color FillColor { get; set; }

        public Triangle(Point p1, Point p2, Point p3, Color fillColor, Color color, int thickness)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            Color = color;
            Thickness = thickness;
            FillColor = fillColor;
        }
        public void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                Point[] points = { P1, P2, P3 };

                g.DrawPolygon(pen, points);
            }
        }
        public void Fill(Graphics g)
        {

            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                Point[] points = { P1, P2, P3 };
                g.FillPolygon(brush, points);
            }

        }
    }
}
