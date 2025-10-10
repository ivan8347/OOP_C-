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
        
        public static void DrawRectangle(Graphics g, int x, int y, int width, int height, Color fillColor, Color color, int thickness)
        {
           
            using (Pen pen = new Pen(color, thickness))
            {   
                // Верхний левый угол
                g.DrawRectangle(pen, x, y, width, height);
            }
    
            using (SolidBrush brush = new SolidBrush(fillColor))
            {
               
                g.FillRectangle(brush, x, y, width, height);
            }

        }

    }
}
