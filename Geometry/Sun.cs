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
    internal class Sun
    {
        public static void DrawSun(Graphics g, int x, int y)
        {
            using (Pen pen = new Pen(Color.Yellow,10))
            {
                g.DrawEllipse(pen, x - 50, y - 50, 100, 100);
                g.DrawLine(pen, x , y - 80, x, y + 80);
                g.DrawLine(pen,x - 80, y, x + 80, y);
                g.DrawLine(pen, x - 60,y - 60,x + 60,y + 60);
                g.DrawLine(pen, x - 60, y + 60, x + 60, y - 60);
            }
            using (SolidBrush brush = new SolidBrush(Color.Yellow))
            {
                g.FillEllipse(brush, x - 50,y - 50, 100, 100);
            }

        }
    }
}
