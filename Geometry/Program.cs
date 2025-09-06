using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                int width = 200;
                int height = 200;

                // Создаем пустое изображение
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        // Задаем фон
                        g.Clear(Color.White);

                        // Рисуем круг (элипс, вписанный в прямоугольник)
                        Pen pen = new Pen(Color.Blue, 3);
                        g.DrawEllipse(pen, 10, 10, width - 20, height - 20);
                    }

                    // Сохраняем изображение
                    bmp.Save("circle.png", System.Drawing.Imaging.ImageFormat.Png);
                }
            Process.Start("circle.png");
            Console.WriteLine("Изображение сохранено как circle.png");
            Console.WriteLine("Текущий каталог: " + Directory.GetCurrentDirectory());

        }

    
    }
}
