using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private const int STEP = 10;
        private const int BOT_STEP = 3;

        private double deltaTime = 0.16;
        private const double DELTA_TIME = 0.16;

        private int Vx = 10;
        private int Vy = 10;

        private Point CircleStartLocation = new Point(391, 210);
        private Point Rectangle1StartLocation = new Point(12, 173);
        private Point Rectangle2StartLocation = new Point(776, 183);

        private bool isBotCatch;


        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == false) timer1.Start();

            switch (e.KeyCode)
            {
                case Keys.W:
                    if (Rectangle_1.Location.Y <= 0) break;
                    moveRectangle(Rectangle_1, 0, -STEP);
                    break;

                case Keys.S:
                    if (Rectangle_1.Location.Y >= 367) break;
                    moveRectangle(Rectangle_1, 0, STEP);
                    break;
            }
        }

        private void moveRectangle(PictureBox rectangle, int x, int y)
        {
            rectangle.Location = new Point(rectangle.Location.X + x, rectangle.Location.Y + y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Circle.Location = new Point(Circle.Location.X + Convert.ToInt32(Vx * deltaTime), Circle.Location.Y);
            Circle.Location = new Point(Circle.Location.X, Circle.Location.Y + Convert.ToInt32(Vy * deltaTime));


            // Відбивання від верхніх стінок
            if (Circle.Location.Y <= 0 || Circle.Location.Y >= 431)
            {
                deltaTime += 0.03;
                Vy = -Vy;
            }

            // Відбивання від ракеток
            if (Circle.Bounds.IntersectsWith(Rectangle_1.Bounds) || Circle.Bounds.IntersectsWith(Rectangle_2.Bounds))
            {
                deltaTime += 0.03;
                Vx = -Vx;
            }

            if (Circle.Bounds.IntersectsWith(Rectangle_2.Bounds))
            {
                isBotCatch = true;
            }

            // Завершення раунду
            if (Circle.Location.X <= 0 || Circle.Location.X >= 783)
            {
                if (Circle.Location.X <= 0) label2.Text = label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                else if (Circle.Location.X >= 783) label1.Text = label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 1);

                Circle.Location = CircleStartLocation;
                Rectangle_1.Location = Rectangle1StartLocation;
                Rectangle_2.Location = Rectangle2StartLocation;

                deltaTime = DELTA_TIME;

                timer1.Stop();
            }

            // Поведінка бота
            if (Circle.Location.X < 391) isBotCatch = false; 

            if (isBotCatch == true)
            {
                if (Rectangle_2.Location.Y < Rectangle2StartLocation.Y) moveRectangle(Rectangle_2, 0, BOT_STEP);
                else if (Rectangle_2.Location.Y > Rectangle2StartLocation.Y) moveRectangle(Rectangle_2, 0, -BOT_STEP);
            }

            if (Circle.Location.X > 391 && isBotCatch == false)
            {
                if (Circle.Location.Y > Rectangle_2.Location.Y)
                {
                    if (Rectangle_2.Location.Y <= 367)
                    {
                        moveRectangle(Rectangle_2, 0, BOT_STEP);
                    }
                }
                else if (Circle.Location.Y < Rectangle_2.Location.Y + Rectangle_2.Height)
                {
                    if (Rectangle_2.Location.Y >= 0)
                    {
                        moveRectangle(Rectangle_2, 0, -BOT_STEP);
                    }
                }
            }

        }
    }
}
