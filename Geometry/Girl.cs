//#define STATIC
#define ANIMATION
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Girl
    {
#if STATIC
         public static void DrawGirl(Graphics g,int x,int y)
    {

        using (Pen pen = new Pen(Color.Black, 3))
        { 
            PointF A = new PointF(x , y);            //x =100    y=450
            PointF B = new PointF(x + 100, y);
            PointF C = new PointF(x + 50, y - 100);
            PointF[] points = { A,B,C };
            g.DrawPolygon(pen, points);
        }
        using (SolidBrush brush = new SolidBrush(Color.RoyalBlue))
        {
            PointF A = new PointF(x, y);
            PointF B = new PointF(x + 100, y);
            PointF C = new PointF(x + 50, y - 100);
            PointF[] points = { A, B, C };
            g.FillPolygon(brush, points);


        }
        using (SolidBrush brush = new SolidBrush(Color.Pink))
        {
            g.FillEllipse(brush, x + 20, y - 145, 60, 60);
        }

        using (Pen pen = new Pen(Color.Black, 3))
        { 
            g.DrawEllipse(pen, x + 20, y - 145, 60, 60);
            g.DrawEllipse(pen, x + 40, y - 120, 5, 5);    //глаз
            g.DrawEllipse(pen, x + 58, y - 120, 5, 5);     //глаз
                g.DrawArc(pen, x + 40, y - 108, 20,10, 0, 180); // улыбка
                g.DrawArc(pen, x + 45, y - 110, 10,3, 0, 180); // нос
               g.DrawLine(pen, x + 35, y , x + 25,y +  50);  // правая нога
               g.DrawLine(pen, x + 65, y , x + 75,y +  50);  // левая нога
               g.DrawLine(pen, x + 27, y - 60,x - 5,   y - 80);  // правая рука
               g.DrawLine(pen, x + 73, y - 60,x + 105, y - 80);  // левая рука
            g.DrawEllipse(pen, x + 90, y - 200, 50, 60); //шар

        }
        using (Pen pen = new Pen(Color.White, 3)) 
        { 
            g.DrawLine(pen, x + 105,y - 80,x + 117,y - 143); 
        }
        using (Pen pen = new Pen(Color.Red, 8))
        {
            g.DrawLine(pen,x + 25,y + 50,x + 10,y + 50);  // правая нога
            g.DrawLine(pen,x + 75,y + 50,x + 90,y + 50);  // левая нога
        }
        using (SolidBrush brush = new SolidBrush(Color.Red))   //шар
        {
            g.FillEllipse(brush, x + 90, y - 200, 50, 60);
           // g.FillEllipse(brush, 120, 305, 60, 60);
        }
        using (Pen pen = new Pen(Color.OrangeRed, 20))
        {
            g.DrawArc(pen,x + 18,y - 142, 70, 100, 180, 180);


        }    
    }

#endif

#if ANIMATION
        public static void DrawGirl(Graphics g, int x, int y, int size)
        {
            // Вместо жестких значений используем масштабный коэффициент
            float scale = size / 100f; // Предположим, что размер 100 — базовый

            using (Pen pen = new Pen(Color.Black, 3 * scale))
            {
                PointF A = new PointF(x, y);
                PointF B = new PointF(x + 100 * scale, y);
                PointF C = new PointF(x + 50 * scale, y - 100 * scale);
                PointF[] points = { A, B, C };
                g.DrawPolygon(pen, points);
            }

            using (SolidBrush brush = new SolidBrush(Color.RoyalBlue))
            {
                PointF A = new PointF(x, y);
                PointF B = new PointF(x + 100 * scale, y);
                PointF C = new PointF(x + 50 * scale, y - 100 * scale);
                PointF[] points = { A, B, C };
                g.FillPolygon(brush, points);
            }

            using (SolidBrush brush = new SolidBrush(Color.Pink))
            {
                g.FillEllipse(brush, x + 20 * scale, y - 145 * scale, 60 * scale, 60 * scale);
            }

            using (Pen pen = new Pen(Color.Black, 3 * scale))
            {
                // g.DrawEllipse(pen, x + 20 * scale, y - 145 * scale, 60 * scale, 60 * scale);
                g.DrawArc(pen, x + 40 * scale, y - 108 * scale, 20 * scale, 10 * scale, 0, 180); // улыбка
                g.DrawEllipse(pen, x + 40 * scale, y - 120 * scale, 5 * scale, 5 * scale);    // глаз
                g.DrawEllipse(pen, x + 58 * scale, y - 120 * scale, 5 * scale, 5 * scale);     // глаз
                g.DrawArc(pen, x + 45 * scale, y - 110 * scale, 10 * scale, 3 * scale, 0, 180); // нос
                g.DrawLine(pen, x + 35 * scale, y, x + 25 * scale, y + 50 * scale);  // правая нога
                g.DrawLine(pen, x + 65 * scale, y, x + 75 * scale, y + 50 * scale);  // левая нога
                g.DrawLine(pen, x + 27 * scale, y - 60 * scale, x - 5 * scale, y - 80 * scale);  // правая рука
                g.DrawLine(pen, x + 73 * scale, y - 60 * scale, x + 105 * scale, y - 80 * scale);  // левая рука
                g.DrawEllipse(pen, x + 90 * scale, y - 200 * scale, 50 * scale, 60 * scale); //шар
            }

            using (Pen pen = new Pen(Color.White, 3 * scale))
            {
                g.DrawLine(pen, x + 105 * scale, y - 80 * scale, x + 117 * scale, y - 143 * scale);
            }
            using (Pen pen = new Pen(Color.Red, 3 * scale))
            {
            }
            using (Pen pen = new Pen(Color.Red, 8 * scale))
            {
                g.DrawLine(pen, x + 25 * scale, y + 50 * scale, x + 10 * scale, y + 50 * scale);  // правая нога
                g.DrawLine(pen, x + 75 * scale, y + 50 * scale, x + 90 * scale, y + 50 * scale);  // левая нога
            }

            using (SolidBrush brush = new SolidBrush(Color.Red))
            {
                g.FillEllipse(brush, x + 90 * scale, y - 200 * scale, 50 * scale, 60 * scale);
            }

            using (Pen pen = new Pen(Color.OrangeRed, 20 * scale))
            {
                g.DrawArc(pen, x + 18 * scale, y - 142 * scale, 70 * scale, 100 * scale, 180, 180);
            }
        }

#endif

    }
}
