//#define STATIC
#define ANIMATION


#if STATIC
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

                    Cloud.DrawCloud(g, 300, 100, 50);
                    Cloud.DrawCloud(g, 700, 60, 50);
                    Cloud.DrawCloud(g, 1000, 100, 70);
                    Circle.DrawCircle(g, 100, 100, 60, Color.Yellow, Color.Yellow, 3);


                    Rectangle.DrawRectangle(g, 500, 300, 200, 150, Color.Violet, Color.Black, 3);
                    //var rectangle = new Rectangle(700, 450, 200, 150, Color.Violet, Color.Black, 3);
                    //rectangle.Fill(g);
                    //rectangle.Draw(g);
                    //var quadrilateral = new Quadrilateral(new Point(700, 300), new Point(850, 210), new Point(850, 340), new Point(700, 450), Color.Violet, Color.Black, 3);
                    //quadrilateral.Fill(g);
                    //quadrilateral.Draw(g);
                    Quadrilateral.DrawQuadrilateral(g, new Point(600, 250), new Point(750, 175), new Point(850, 210), new Point(700, 300), Color.Orange, Color.Black, 3);
                    Quadrilateral.DrawQuadrilateral(g, new Point(700, 300), new Point(850, 210), new Point(850, 340), new Point(700, 450), Color.Violet, Color.Black, 3);
                    Quadrilateral.DrawQuadrilateral(g, new Point(730, 380), new Point(830, 305), new Point(830, 260), new Point(730, 330), Color.White, Color.Black, 3);
                     g.DrawLine(new Pen(Color.Black,3), 780, 343, 780, 295);

                    //var quadrilateral_1 = new Quadrilateral(new Point(600, 250), new Point(750, 175), new Point(850, 210), new Point(700, 300), Color.Orange, Color.Black, 3);
                    //quadrilateral_1.Fill(g);
                    //quadrilateral_1.Draw(g);
                    Triangle.DrawTriangle(g, new Point(500, 300), new Point(700, 300), new Point(600, 250), Color.Violet, Color.Black, 3);
                    //Triangle.DrawTriangle(g, new Point(100, 450), new Point(200, 450), new Point(150, 350), Color.HotPink, Color.Black, 3);

                    //var triangle = new Triangle(new Point(500, 300), new Point(700, 300), new Point(600, 250), Color.Violet, Color.Black, 3);
                    //triangle.Fill(g);
                    //triangle.Draw(g);

                    Circle.DrawCircle(g, 600, 280, 10, Color.White, Color.Black, 3);
                   // Circle.DrawCircle(g, 150, 320, 30, Color.Pink, Color.Black, 3);
                    Girl.DrawGirl(g, 150, 450);
                    // var circle_1 = new Circle(600, 280, 10, Color.White, Color.Black, 3);
                    //circle_1.Fill(g); 
                    //circle_1.Draw(g); 
                    Rectangle.DrawRectangle(g, 550, 350, 100, 50, Color.White, Color.Black, 3);
                     g.DrawLine(new Pen(Color.Black,3), 600, 350, 600, 400);
                    // var rectangle_1 = new Rectangle(650, 390, 100, 50, Color.White, Color.Black, 5);
                    // rectangle_1.Fill(g);
                    // rectangle_1.Draw(g);
                }


                // Сохраняем изображение
                bmp.Save("output.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            Process.Start("output.png");
            Console.WriteLine("Текущий каталог: " + Directory.GetCurrentDirectory());
        }



    }
}

#endif

#if ANIMATION
using System;
using System.Drawing;
using System.Windows.Forms;
using Geometry;

namespace Animation
{
    public class MainForm : Form
    {
        private PictureBox pictureBox;
        private Timer timer;

        private float cloud1X = 300;
        private float cloud2X = 700;
        private float cloud3X = 1000;
        private float cloud4X = 500;
        private float girlX = 1000;
        private float girlY = 350;
        private float targetGirlY = 450;
        private int width = 1200;
        private int height = 600;
        private int cloudSpeed = 1;
        private int girlSpeed = 2;
        private bool movingLeft = true;
        private float circleX = 100;
       // private bool circleY = 100;
        private float circleSpeed = 0.5f;

        public MainForm()
        {
            this.Width = width;
            this.Height = height;


            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            this.Controls.Add(pictureBox);

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Фон
                g.FillRectangle(Brushes.LightBlue, 0, 0, width, 300);
                g.FillRectangle(Brushes.Green, 0, 300, width, 300);

                Circle.DrawCircle(g,(int) circleX, 100, 50, Color.Yellow, Color.Yellow, 3);
                g.DrawLine(new Pen(Color.Yellow, 10), 100, 20, 100, 180);
                g.DrawLine(new Pen(Color.Yellow, 10), 20, 100, 180, 100);
                g.DrawLine(new Pen(Color.Yellow, 10), 160, 45, 45, 160);
                g.DrawLine(new Pen(Color.Yellow, 10), 45, 45, 160, 160);
                // Облака
                Cloud.DrawCloud(g, (int)cloud1X, 100, 50);
                Cloud.DrawCloud(g, (int)cloud2X, 60, 50);
                Cloud.DrawCloud(g, (int)cloud3X, 100, 70);
                Cloud.DrawCloud(g, (int)cloud4X, 50, 30);
                // Girl.DrawGirl(g, (int)girl, 450,5);


                Geometry.Rectangle.DrawRectangle(g, 500, 300, 200, 150, Color.Violet, Color.Black, 3);
                Geometry.Rectangle.DrawRectangle(g, 550, 350, 100, 50, Color.White, Color.Black, 3);
                g.DrawLine(new Pen(Color.Black, 3), 600, 350, 600, 400);
                Triangle.DrawTriangle(g, new Point(500, 300), new Point(700, 300), new Point(600, 250), Color.Violet, Color.Black, 3);
                Quadrilateral.DrawQuadrilateral(g, new Point(600, 250), new Point(750, 175), new Point(850, 210), new Point(700, 300), Color.Orange, Color.Black, 3);
                Quadrilateral.DrawQuadrilateral(g, new Point(700, 300), new Point(850, 210), new Point(850, 340), new Point(700, 450), Color.Violet, Color.Black, 3);
                Quadrilateral.DrawQuadrilateral(g, new Point(730, 380), new Point(830, 305), new Point(830, 260), new Point(730, 330), Color.White, Color.Black, 3);
                g.DrawLine(new Pen(Color.Black, 3), 780, 343, 780, 295);
                Circle.DrawCircle(g, 600, 280, 10, Color.White, Color.Black, 3);

              

                // Обновляем изображение PictureBox
                pictureBox.Image?.Dispose();
                pictureBox.Image = bmp;

                // Обновляем позиции облаков
                cloud1X += cloudSpeed;
                cloud2X += cloudSpeed;
                cloud3X += cloudSpeed;
                cloud4X += cloudSpeed;
                girlX -= girlSpeed;
                girlY += girlSpeed;
                circleX += circleSpeed;


                float size = 30 + (girlY - 250) * 0.3f; // например, базовый 30, увеличивается с girlY
                if (size < 30) size = 10; // минимальный размер
                if (size > 100) size = 100; // максимум
                int girlSize = (int)size;

                float deltaY = targetGirlY - girlY;
                girlY += deltaY * 0.01f;
                if (girlY > 450)
                {
                    targetGirlY = 220; // девочка поднимается вверх
                }
               
                // Циклический эффект
                if (cloud1X > width + 50) cloud1X = -50;
                if (cloud2X > width + 50) cloud2X = -50;
                if (cloud3X > width + 50) cloud3X = -50;
                if (cloud4X > width + 50) cloud4X = -50;
                if (circleX > width + 50) circleX = -50;

                if (girlX < 50) ;
                if (girlY > 300) ;
                Girl.DrawGirl(g, (int)girlX, (int)girlY, (int)size);

            }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}

#endif



