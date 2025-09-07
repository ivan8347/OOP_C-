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
                    Circle circle = new Circle(100, 100, 80,Color.Yellow, Color.Yellow, 3);
                     circle.Fill(g); // заливаем круг
                     circle.Draw(g); // рисуем контур
                    var rectangle = new Rectangle(700, 450,  200, 150, Color.Violet, Color.Black, 3 );
                    rectangle.Fill(g);
                    rectangle.Draw(g);
                    var p1 = new PointF(700, 300);
                    var quadrilateral = new Quadrilateral(p1, 150, 150, 100, Color.Violet, Color.Black, 3); 
                    quadrilateral.Fill(g);  
                    quadrilateral.Draw(g);





                }
                 // Сохраняем изображение
                 bmp.Save("output.png", System.Drawing.Imaging.ImageFormat.Png);
             }
             Process.Start("output.png");
             Console.WriteLine("Текущий каталог: " + Directory.GetCurrentDirectory());



          
        }
    }

}

        
    





