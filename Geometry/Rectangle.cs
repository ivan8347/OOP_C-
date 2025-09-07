using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Color Color { get; set; }
        public int Thickness { get; set; }
        public Color FillColor { get; set; } 
        public Rectangle(int x, int y, int width, int height, Color fillColor,Color color, int thickness )
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
            Thickness = thickness;
            FillColor = fillColor;
        }

        public void Draw(Graphics g)
        { 
            using (Pen pen = new Pen(Color, Thickness))
            {
                // Верхний левый угол
                int left = X - Width ;
                int top = Y - Height ;
                
                g.DrawRectangle(pen, left, top, Width, Height);
            }
        }
        public void Fill(Graphics g)
        {
           
                using (SolidBrush brush = new SolidBrush(FillColor))
                {
                    int left = X - Width ;
                    int top = Y - Height ;
                    g.FillRectangle(brush, left, top, Width, Height);
                }
            
        }
    }
}
