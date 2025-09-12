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
        public static void DrawCircle(Graphics g, int x, int y, int radius, Color fillColor, Color color, int thickness)
        {      
            using (Pen pen = new Pen(color, thickness))
            {
                g.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2);
            }
   
            using (SolidBrush brush = new SolidBrush(fillColor))
            {
                g.FillEllipse(brush, x - radius, y - radius, radius * 2, radius * 2);
            }

        }

    }

}
