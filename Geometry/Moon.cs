using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;


namespace Geometry
{
    internal class Moon
    {
        public static void DrawMoon(Graphics g, int x, int y)
        {
            using (SolidBrush brush = new SolidBrush(Color.Yellow))
            {
                g.FillEllipse(brush, x - 50, y - 50, 100, 100);
            }
            // Вторая окружность — создает эффект полумесяца (смещена влево)
            using (SolidBrush brush = new SolidBrush(Color.DarkSlateBlue))
            { 
                
                g.FillEllipse(brush, x - 25, y - 60,100,100);   

            }
        }
    }
}