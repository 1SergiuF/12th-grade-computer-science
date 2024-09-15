using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTest
{
    public partial class Form1 : Form
    {
        private List<Circle> circles;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            circles = new List<Circle>();

            for (int i = 0; i < 10; ++i)
            {
                int randRadius = random.Next(10, 100);
                int randX = random.Next(randRadius, this.Width - randRadius);
                int randY = random.Next(randRadius, this.Width - randRadius);

                circles.Add(new Circle(randX, randY, randRadius, Color.Red));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            for (int i = 0; i < 10; ++i)
            {
                g.DrawEllipse(new Pen(circles[i].C), new Rectangle(circles[i].X, circles[i].Y,
                    circles[i].R, circles[i].R));
            }
        }
    }
}
