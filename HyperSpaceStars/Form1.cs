using System;
using SkiaSharp;
using System.Windows.Forms;

namespace HyperSpaceStars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BuildStarsArray();
            timerCanvas.Enabled = true;
        }

        struct Star
        {
            public int startX;
            public int startY;
            public double angle;
            public double speed;
        }

        static int numOfStars = 100;
        Random random = new Random();
        SKPaint paint = new SKPaint {
            Color = SKColors.FloralWhite,
            StrokeWidth = 2,
            Style = SKPaintStyle.Fill
        };
        Star[] stars = new Star[numOfStars];

        private void BuildStarsArray()
        {
            for (int i = 0; i < numOfStars; i++)
            {
                stars[i].startX = random.Next(0, skglCanvas.Width);
                stars[i].startY = random.Next(0, skglCanvas.Height);
                stars[i].angle = Math.Atan2(stars[i].startY - skglCanvas.Height/2, stars[i].startX - skglCanvas.Width/2);
                stars[i].speed = random.Next(5, 10);
            }
        }

        private void skglCanvas_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            e.Surface.Canvas.Clear(SKColors.Black);
            for (int i = 0; i < numOfStars; i++)
            {
                stars[i].startX += Convert.ToInt32(stars[i].speed * Math.Cos(stars[i].angle));
                stars[i].startY += Convert.ToInt32(stars[i].speed * Math.Sin(stars[i].angle));
                if (stars[i].startX < 0 || stars[i].startX > skglCanvas.Width || stars[i].startY < 0 || stars[i].startY > skglCanvas.Height)
                {
                    stars[i].startX = random.Next(0, skglCanvas.Width);
                    stars[i].startY = random.Next(0, skglCanvas.Height);
                    stars[i].angle = Math.Atan2(stars[i].startY - skglCanvas.Height / 2, stars[i].startX - skglCanvas.Width / 2);
                    stars[i].speed = random.Next(5, 10);
                }
                SKPoint point = new SKPoint(stars[i].startX, stars[i].startY);
                e.Surface.Canvas.DrawPoint(point, paint);

                //Draw tail
                int nextX = stars[i].startX;
                int nextY = stars[i].startY;
                int tailL = random.Next(2, 10);
                for (int j = 0; j < tailL; j++)
                {
                    nextX += Convert.ToInt32(j * Math.Cos(stars[i].angle));
                    nextY += Convert.ToInt32(j * Math.Sin(stars[i].angle));
                    SKPoint tPoint = new SKPoint(nextX, nextY);
                    e.Surface.Canvas.DrawPoint(tPoint, paint);
                }
            }
        }

        private void timerCanvas_Tick(object sender, EventArgs e)
        {
            skglCanvas.Invalidate();
            Application.DoEvents();
        }

    }
}
