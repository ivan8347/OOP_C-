using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Cloud
    {


        public static void DrawCloud(Graphics g, int x, int y, int size)
        {
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.FillEllipse(brush, x, y, size, size);
                g.FillEllipse(brush, x + size / 2, y - size / 4, size, size);
                g.FillEllipse(brush, x + size, y, size, size);
                g.FillEllipse(brush, x + size / 3, y + size / 4, size, size);
                g.FillEllipse(brush, x + size * 2 / 3, y + size / 4, size, size);
            }
        }


    }
}







