





using System;
using System.Drawing;
using System.Windows.Forms;
using Geometry;
using MyLibrary;

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
        private int cloudSpeed = 1;


        private float girlX = 100;
        private float girlY = 20;
        private int girlSpeed = 5;
        private float targetGirlY = 450;
        private bool moveLeft, moveRight, moveUp, moveDown;

        private float sunX = -50;
        private float sunSpeed = 5;

        private float moonX = -50;
        private float moonSpeed = 3;

        private int width = 1200;
        private int height = 800;
        bool showSun = true;

        private bool girlInZone = false;



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



            this.KeyDown += MainForm_KeyDown;
            this.KeyUp += MainForm_KeyUp;
            this.KeyPreview = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                float minX = 1100;
                float maxX = width;

                if (showSun)
                {
                    float t1 = (sunX - minX) / (maxX - minX);
                    if (t1 < 0) t1 = 0;
                    if (t1 > 1) t1 = 1;

                    Color startColor1 = Color.LightBlue;
                    Color endColor1 = Color.DarkSlateBlue;
                    int r1 = (int)(startColor1.R + (endColor1.R - startColor1.R) * t1);
                    int c1 = (int)(startColor1.G + (endColor1.G - startColor1.G) * t1);
                    int b1 = (int)(startColor1.B + (endColor1.B - startColor1.B) * t1);
                    Color backgroundColor1 = Color.FromArgb(r1, c1, b1);
                    g.FillRectangle(new SolidBrush(backgroundColor1), 0, 0, width, 300);
                    Sun.DrawSun(g, (int)sunX, 100);
                }
                else
                {
                    float t = (moonX - minX) / (maxX - minX);
                    if (t < 0) t = 0;
                    if (t > 1) t = 1;

                    Color startColor = Color.DarkSlateBlue;
                    Color endColor = Color.LightBlue;
                    int r = (int)(startColor.R + (endColor.R - startColor.R) * t);
                    int c = (int)(startColor.G + (endColor.G - startColor.G) * t);
                    int b = (int)(startColor.B + (endColor.B - startColor.B) * t);
                    Color backgroundColor = Color.FromArgb(r, c, b);
                    g.FillRectangle(new SolidBrush(backgroundColor), 0, 0, width, 300);
                    Moon.DrawMoon(g, (int)moonX, 100);
                }
                g.FillRectangle(Brushes.Green, 0, 300, width, 600);


                // Облака
                Cloud.DrawCloud(g, (int)cloud1X, 100, 50);
                Cloud.DrawCloud(g, (int)cloud2X, 60, 50);
                Cloud.DrawCloud(g, (int)cloud4X, 50, 30);
                Cloud.DrawCloud(g, (int)cloud3X, 100, 70);

              /* Geometry.Rectangle.DrawRectangle(g, 500, 300, 200, 150, Color.Violet, Color.Black, 3);
                Geometry.Rectangle.DrawRectangle(g, 550, 350, 100, 50, Color.White, Color.Black, 3);
                g.DrawLine(new Pen(Color.Black, 3), 600, 350, 600, 400);
                Triangle.DrawTriangle(g, new Point(500, 300), new Point(700, 300), new Point(600, 250), Color.Violet, Color.Black, 3);
                Quadrilateral.DrawQuadrilateral(g, new Point(600, 250), new Point(750, 175), new Point(850, 210), new Point(700, 300), Color.Orange, Color.Black, 3);
                Quadrilateral.DrawQuadrilateral(g, new Point(700, 300), new Point(850, 210), new Point(850, 340), new Point(700, 450), Color.Violet, Color.Black, 3);
                Quadrilateral.DrawQuadrilateral(g, new Point(730, 380), new Point(830, 305), new Point(830, 260), new Point(730, 330), Color.White, Color.Black, 3);
                g.DrawLine(new Pen(Color.Black, 3), 780, 343, 780, 295);
                Circle.DrawCircle(g, 600, 280, 10, Color.White, Color.Black, 3);*/

                pictureBox.Image?.Dispose();
                pictureBox.Image = bmp;
                cloud1X += cloudSpeed;
                cloud2X += cloudSpeed;
                cloud3X += cloudSpeed;
                cloud4X += cloudSpeed;
             
                float size = 30 + (girlY - 150) * 0.3f; 
                if (size < 10) size = 1;
                if (size > 80) size = 80; 
                int girlSize = (int)size;

                // Циклический эффект
                if (cloud1X > width + 50) cloud1X = -50;
                if (cloud2X > width + 50) cloud2X = -50;
                if (cloud3X > width + 50) cloud3X = -50;
                if (cloud4X > width + 50) cloud4X = -50;

                if (showSun)
                {
                    sunX += sunSpeed;
                    if (sunX > width + 50)
                    {
                        showSun = false; // переключиться на круг
                        moonX = -50;   // начать движение круга с левой стороны
                    }
                }
                else
                {
                    moonX += moonSpeed;
                    if (moonX > width + 50)
                    {
                        showSun = true; // переключиться на солнце
                        sunX = -50;     // начать движение солнца с левой стороны
                    }
                }

                if (moveUp && girlY > 0) girlY -= girlSpeed;
                if (moveDown && girlY < height - girlSize) girlY += girlSpeed;
                if (moveLeft && girlX > 0) girlX -= girlSpeed;
                if (moveRight && girlX < width - girlSize) girlX += girlSpeed;
                Tree.DrawTree(g, 50, 350, 50);
                Tree.DrawTree(g, 1000, 350, 40);
                Tree.DrawTree(g, 200, 300, 30);
                Tree.DrawTree(g, 950, 550, 100);
                Tree.DrawTree(g, 350, 550, 80);
                Tree.DrawTree(g, 750, 450, 50);

                Tree1.DrawTree1(g, 850, 350, 50);
                Tree1.DrawTree1(g, 750, 270, 70);
                Tree1.DrawTree1(g, 50, 550, 150);
                Tree1.DrawTree1(g, 380, 260, 110);
                Tree1.DrawTree1(g, 1050, 390, 80);
                Tree1.DrawTree1(g, 700, 550, 100);

                Hause.DrawHause(g, 500, 300, 60);
               
                Girl.DrawGirl(g, (int)girlX, (int)girlY, (int)size);
                Circle.DrawCircle(g, 600, 450, 10, Color.Red, Color.Red, 3);

                


                bool nowInZone = girlX == 600 && girlY == 450;


                if (nowInZone && !girlInZone)
                {
                    girlInZone = true;

                    try
                    {
                        System.Diagnostics.Process.Start("ConsoleTrainer.exe");

                        // MyLibrary.Class1.RunTrainer(); // вызов метода из DLL
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка запуска DLL: " + ex.Message);
                    }
                }
                else if (!nowInZone)
                {
                    girlInZone = false; // сбрасываем, если вышла из зоны
                }


                //if (nowInZone && !girlInZone)
                //{
                //    girlInZone = true;

                //    try
                //    {
                //        //System.Diagnostics.Process.Start("U:\\Users\\kit\\source\\repos\\Introdaction\\GAME2\\bin\\Debug\\GAME2.exe");
                //        System.Diagnostics.Process.Start(Class1.RunTrainer());
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Ошибка запуска: " + ex.Message);
                //    }
                //}

            }

        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) moveUp = true;
            if (e.KeyCode == Keys.S) moveDown = true;
            if (e.KeyCode == Keys.A) moveLeft = true;
            if (e.KeyCode == Keys.D) moveRight = true;
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) moveUp = false;
            if (e.KeyCode == Keys.S) moveDown = false;
            if (e.KeyCode == Keys.A) moveLeft = false;
            if (e.KeyCode == Keys.D) moveRight = false;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}





