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
    internal class Tree
    {
        public static void DrawTree(Graphics g, int x, int y, int size)
        {
            float scale = size / 100f;
            // Цвета
            Brush greenBrush = new SolidBrush(Color.ForestGreen);
            Pen Pen = new Pen(Color.Black, 2 * scale);
            Brush trunkBrush = new SolidBrush(Color.SaddleBrown);

            // Крона: три треугольника
            for (int i = 0; i < 3; i++)
            {
                float baseWidth = 100 * scale;
                float currentWidth = baseWidth - i * 20 * scale;
                float height = 60 * scale;
                float offsetY = i * 40 * scale;

                // Центрируем по базовой ширине
                float shiftX = (baseWidth - currentWidth) / 2;

                PointF left = new PointF(x + shiftX, y - offsetY);
                PointF right = new PointF(x + shiftX + currentWidth, y - offsetY);
                PointF top = new PointF(x + baseWidth / 2, y - offsetY - height);


                PointF[] triangle = { left, right, top };
                g.FillPolygon(greenBrush, triangle);
                g.DrawPolygon(Pen, triangle);
            }

            // Ствол
            float trunkWidth = 20 * scale;
            float trunkHeight = 40 * scale;
            RectangleF trunk = new RectangleF(x + 40 * scale, y, trunkWidth, trunkHeight);
            g.FillRectangle(trunkBrush, trunk);
            g.DrawRectangle(Pens.Black, trunk.X, trunk.Y, trunk.Width, trunk.Height);

        }
    }
}

