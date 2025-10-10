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
        public static void DrawTree1(Graphics g, int x, int y, int size)
        {
            float scale = size / 100f;
    
            using (SolidBrush brush = new SolidBrush(Color.SaddleBrown))
            {
               
                g.FillRectangle(brush, x + 30 * scale, y + 40 * scale, 15 * scale, 50 * scale);
            }

            using (SolidBrush brush = new SolidBrush(Color.ForestGreen))
            {
                g.FillEllipse(brush, x, y, 40 * scale, 40 * scale);
                g.FillEllipse(brush, x + 40 * scale / 2, y - 40 * scale / 2, 40 * scale, 40 * scale);
                g.FillEllipse(brush, x + 40 * scale, y, 40 * scale, 40 * scale);
                g.FillEllipse(brush, x + 40 * scale / 3, y + 40 * scale / 2, 40 * scale, 40 * scale);
                g.FillEllipse(brush, x + 2 * 40 * scale / 3, y + 40 * scale / 2, 40 * scale, 40 * scale);
            }

            using (Pen pen = new Pen(Color.Black, 2 * scale))
            {
                g.DrawEllipse(pen, x, y, 40 * scale, 40 * scale);
                g.DrawEllipse(pen, x + 40 * scale / 2, y - 40 * scale / 2, 40 * scale, 40 * scale);
                g.DrawEllipse(pen, x + 40 * scale, y, 40 * scale, 40 * scale);
                g.DrawEllipse(pen, x + 40 * scale / 3, y + 40 * scale / 2, 40 * scale, 40 * scale);
                g.DrawEllipse(pen, x + 2 * 40 * scale / 3, y + 40 * scale / 2, 40 * scale, 40 * scale);
            }
        }
    }
}
