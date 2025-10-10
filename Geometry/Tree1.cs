using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Geometry
{
    internal class Tree1
    {
        public static void DrawTree1(Graphics g,int x,int y, int size)
        {
            
           
            using (SolidBrush brush = new SolidBrush(Color.ForestGreen))
            {
                g.FillEllipse(brush, x, y, size, size);
                g.FillEllipse(brush, x + size / 2, y - size / 4, size, size);
                g.FillEllipse(brush, x + size, y, size, size);
                g.FillEllipse(brush, x + size / 3, y + size / 4, size, size);
                g.FillEllipse(brush, x + size * 2 / 3, y + size / 4, size, size);
            }
            using (Pen pen = new Pen(Color.Black, 2 ))
            {
                g.DrawEllipse(pen, x, y, size, size);
                g.DrawEllipse(pen, x + size / 2, y - size / 4, size, size);
                g.DrawEllipse(pen, x + size, y, size, size);
                g.DrawEllipse(pen, x + size / 3, y + size / 4, size, size);
                g.DrawEllipse(pen, x + size * 2 / 3, y + size / 4, size, size);
            }

        }

    }
}
