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
        public PointF[] Points {  get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }
        public Color FillColor { get; set; } 

        public Quadrilateral(PointF p1, int width,int height, int offsetY, Color fillColor, Color color, int thickness)
        {
            Points = new PointF[] { p1 };
            Width = width;
            Height = height;
            Color = color;
            FillColor = fillColor;
            Thickness = thickness;
            // Вычисляем все 4 точки параллелограмма
            Points = CalculatePoints(p1, width, height, offsetY);
        }
        private PointF[] CalculatePoints(PointF p1, int width, int height, int offsetY)
        {
            PointF p2 = new PointF(p1.X + width, p1.Y - offsetY);
            PointF p3 = new PointF(p2.X , p2.Y + height);
            PointF p4 = new PointF(p1.X , p1.Y + height);
            return new PointF[] { p1, p2, p3, p4 };
        }
        public void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                g.DrawPolygon (pen, Points); 
            }
        }
        public void Fill(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(FillColor))
            { 
                g.FillPolygon (brush, Points);
            }
        }
    }
}
