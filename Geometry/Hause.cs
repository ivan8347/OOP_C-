using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class Hause
    {
        public static void DrawHause(Graphics g, int x, int y, int size)
        {
            float scale = size / 100f;
    

            using (SolidBrush brush = new SolidBrush(Color.Violet))
            {

                g.FillRectangle(brush, x, y, 200 * scale, 150 * scale);
            }
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.FillRectangle(brush, x + 50 * scale, y + 50 * scale, 100 * scale, 50 * scale);
            }
            using (SolidBrush brush = new SolidBrush(Color.Violet))
            {
                PointF A = new PointF(x, y);
                PointF B = new PointF(x + 200 * scale, y);
                PointF C = new PointF(x + 100 * scale, y - 50 * scale);
                PointF[] points = { A, B, C };
                g.FillPolygon(brush, points);
            }
            using (SolidBrush brush = new SolidBrush(Color.Orange))
            {
                PointF A = new PointF(x + 100 * scale, y - 50 * scale);
                PointF B = new PointF(x + 250 * scale, y - 125 * scale);
                PointF C = new PointF(x + 350 * scale, y - 90 * scale);
                PointF D = new PointF(x + 200 * scale,y);
                PointF[] points = { A, B, C, D};
                g.FillPolygon(brush, points);
            }
            using (SolidBrush brush = new SolidBrush(Color.Violet))
            {
                PointF A = new PointF(x + 200 * scale, y );
                PointF B = new PointF(x + 350 * scale, y - 90 * scale);
                PointF C = new PointF(x + 350 * scale, y + 40 * scale);
                PointF D = new PointF(x + 200 * scale, y + 150 * scale);
                PointF[] points = { A, B, C, D };
                g.FillPolygon(brush, points);
            }
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                PointF A = new PointF(x + 230 * scale, y + 80 * scale);
                PointF B = new PointF(x + 330 * scale, y + 5 * scale);
                PointF C = new PointF(x + 330 * scale, y - 40 * scale);
                PointF D = new PointF(x + 230 * scale, y + 30 * scale);
                PointF[] points = { A, B, C, D };
                g.FillPolygon(brush, points);
            }
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.FillEllipse(brush, x + 100 * scale - 10 * scale, y - 20 * scale - 10 * scale, 10 * scale * 2, 10 * scale * 2);
            }

            using (Pen pen = new Pen(Color.Black, 3 * scale ))
            {
                PointF A = new PointF(x, y);
                PointF B = new PointF(x + 200 * scale, y);
                PointF C = new PointF(x + 100 * scale, y - 50 * scale);
                PointF[] points = { A, B, C };
                g.DrawPolygon(pen, points);
            }
            using (Pen pen = new Pen(Color.Black, 3 * scale))
            {
                // Верхний левый угол
                g.DrawRectangle(pen, x, y, 200 * scale, 150 * scale);
                g.DrawRectangle(pen, x + 50 * scale, y + 50 * scale, 100 * scale, 50 * scale);
                g.DrawLine(pen, x + 100 * scale, y + 50 * scale, x + 100 * scale, y + 100 * scale);
                g.DrawLine(pen, x + 280 * scale, y + 43 * scale, x + 280 * scale, y - 5 * scale);
                g.DrawEllipse(pen, x + 100 * scale - 10 * scale, y - 20 * scale - 10 * scale, 10 * scale * 2, 10 * scale * 2);
            }
            using (Pen pen = new Pen(Color.Black, 3 * scale))
            {
                
                PointF A = new PointF(x + 100 * scale, y - 50 * scale);
                PointF B = new PointF(x + 250 * scale, y - 125 * scale);
                PointF C = new PointF(x + 350 * scale, y - 90 * scale);
                PointF D = new PointF(x + 200 * scale, y);
                PointF[] points = { A, B, C, D };
                g.DrawPolygon(pen, points);
            }
            using (Pen pen = new Pen(Color.Black, 3 * scale))
            {

                PointF A = new PointF(x + 200 * scale, y);
                PointF B = new PointF(x + 350 * scale, y - 90 * scale);
                PointF C = new PointF(x + 350 * scale, y + 40 * scale);
                PointF D = new PointF(x + 200 * scale, y + 150 * scale);
                PointF[] points = { A, B, C, D };
                g.DrawPolygon(pen, points);
            }
            using (Pen pen = new Pen(Color.Black, 3 * scale))
            {

                PointF A = new PointF(x + 230 * scale, y + 80 * scale);
                PointF B = new PointF(x + 330 * scale, y + 5 * scale);
                PointF C = new PointF(x + 330 * scale, y - 40 * scale);
                PointF D = new PointF(x + 230 * scale, y + 30 * scale);
                PointF[] points = { A, B, C, D };
                g.DrawPolygon(pen, points);
            }
        }

    }
}
