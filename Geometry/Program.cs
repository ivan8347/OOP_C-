using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 1200;
            int height = 600;

            // Создаем пустое изображение
            using (Bitmap bmp = new Bitmap(width, height))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Задаем фон
                    g.FillRectangle(Brushes.LightBlue, 0, 0, width, 300);
                    g.FillRectangle(Brushes.Green, 0, 300, width, 300);

                    DrawingUtils.DrawCloud(g, 300, 100, 50);
                    DrawingUtils.DrawCloud(g, 700, 60, 50);
                    DrawingUtils.DrawCloud(g, 1000, 100, 70);

                    var circle = new Circle(100, 100, 60, Color.Yellow, Color.Yellow, 3);
                    circle.Fill(g); 
                    circle.Draw(g); 
                    var rectangle = new Rectangle(700, 450, 200, 150, Color.Violet, Color.Black, 3);
                    rectangle.Fill(g);
                    rectangle.Draw(g);

                    var quadrilateral = new Quadrilateral(new Point(700, 300), new Point(850, 210), new Point(850, 340),new Point(700,450), Color.Violet, Color.Black, 3);
                    quadrilateral.Fill(g);
                    quadrilateral.Draw(g); 


                    var quadrilateral_1 = new Quadrilateral(new Point(600, 250), new Point(750, 175), new Point(850,210),new Point(700,300), Color.Orange, Color.Black, 3);
                    quadrilateral_1.Fill(g);
                    quadrilateral_1.Draw(g);


                    var triangle = new Triangle(new Point(500, 300), new Point(700, 300), new Point(600, 250), Color.Violet, Color.Black, 3);
                    triangle.Fill(g);
                    triangle.Draw(g);

                    var circle_1 = new Circle(600, 280, 10, Color.White, Color.Black, 3);
                    circle_1.Fill(g); 
                    circle_1.Draw(g); 

                   var rectangle_1 = new Rectangle(650, 390, 100, 50, Color.White, Color.Black, 5);
                   rectangle_1.Fill(g);
                   rectangle_1.Draw(g);

                }
                // Сохраняем изображение
                bmp.Save("output.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            Process.Start("output.png");
            Console.WriteLine("Текущий каталог: " + Directory.GetCurrentDirectory());




        }
    }

}








