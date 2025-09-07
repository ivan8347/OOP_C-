using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Circle
    {
         public int X {  get; set; }
         public int Y { get; set; }
         public int Radius { get; set; }
         public Color Color { get;set;}
         public int Thickness { get; set;}
         public Color FillColor { get; set; } 
         public Circle(int x, int y, int radius,Color fillColor, Color color, int thickness)
         {
             X = x;
             Y = y;
             Radius = radius;
             Color = color;
             Thickness = thickness;
             FillColor = fillColor;
         }

         public void Draw(Graphics g)
         {
             // Рисуем круг (элипс, вписанный в прямоугольник)
             using (Pen pen = new Pen(Color, Thickness))
             {
                 g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
             }
         }
         public void Fill(Graphics g)
         {
            
                 using (SolidBrush brush = new SolidBrush(FillColor))
                 {
                     g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
                 }
             
         }




    }
}