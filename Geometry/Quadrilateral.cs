using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Quadrilateral
    {
      /*  public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }
        public Point P4 { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }
        public Color FillColor { get; set; }

        public Quadrilateral(Point p1, Point p2, Point p3, Point p4, Color fillColor, Color color, int thickness)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
            Color = color;
            FillColor = fillColor;
            Thickness = thickness;
        }
        public PointF[] CalculatePoints(int width, int height, int offsetY)
        {
            PointF p1 = new PointF(700, 300);
            PointF p2 = new PointF(p1.X + width, p1.Y - offsetY);
            PointF p3 = new PointF(p2.X, p2.Y + height);
            PointF p4 = new PointF(p1.X, p1.Y + height);
            return new PointF[] { p1, p2, p3, p4 };
        }
        public void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                Point[] points = { P1, P2, P3, P4 };
                g.DrawPolygon(pen, points);
            }
        }
        public void Fill(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                Point[] points = { P1, P2, P3, P4 };
                g.FillPolygon(brush, points);
            }
        }*/

        public static void DrawQuadrilateral(Graphics g, Point p1, Point p2, Point p3, Point p4, Color fillColor, Color color, int thickness)
        {
            Point[] points = { p1, p2, p3, p4 };
            using (Pen pen = new Pen(color, thickness))
            {
                // Верхний левый угол
                g.DrawPolygon(pen, points);
            }

            using (SolidBrush brush = new SolidBrush(fillColor))
            {

                g.FillPolygon(brush, points);
            }

        }



    }
}
