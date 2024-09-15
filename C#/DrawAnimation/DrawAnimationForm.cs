using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawAnimation
{
    public partial class DrawAnimationForm : Form
    {
        private Timer timer = new Timer();
        private bool draw = false;
        private bool done = false;
        private int x1 = 100, y1 = 350, r = 20, x2 = 500, y2 = 90;
        float X = 0, Y = 0;
        int cnt = 0;
        double alpha, x0, y0;
        float dx, dy;
        bool reset = false;
        public DrawAnimationForm()
        {
            InitializeComponent();
            timer.Interval = 10;
            timer.Tick += HandleTick;
        }

        private void HandleTick(object sender, EventArgs e)
        {
            if (draw)
            {
                btnReseteaza.Enabled = false;
                X += dx;
                Y += dy;

                cnt++;
                if (cnt == 30)
                {
                    timer.Stop();
                    btnReseteaza.Enabled = true;
                    draw = false;
                    done = true;
                    cnt = 0;
                }

                pbDraw.Invalidate();
            }
        }

        private void btnDeseneaza_Click(object sender, EventArgs e)
        {
            alpha = Math.Atan2((double)(y2 -  y1), (double)(x2 - x1));
            x0 = r * Math.Cos(alpha);
            y0 = r * Math.Sin(alpha);
            float DX = (float)(x2 - x0) - (float)(x1 + x0);
            float DY = (float)(y2 - y0) - (float)(y1 + y0);
            dx = DX / 30;
            dy = DY / 30;

            X = (float)x1 + (float)x0;
            Y = (float)y1 + (float)y0;
            draw = true;

            timer.Start();
        }

        private void btnReseteaza_Click(object sender, EventArgs e)
        {
            reset = true;
        }

        private void pbDraw_Paint(object sender, PaintEventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 4);

            int width = 2 * r, height = 2 * r;
            e.Graphics.DrawEllipse(redPen, x1 - r, y1 - r, width, height);
            e.Graphics.DrawEllipse(redPen, x2 - r, y2 - r, width, height);

            if (draw)
                e.Graphics.DrawLine(redPen, (float)(x1 + x0), (float)(y1 + y0),
                    X, Y);
            if (done)
                e.Graphics.DrawLine(redPen, (float)(x1 + x0), (float)(y1 + y0),
                    (float)(x2 - x0), (float)(y2 - y0));

            if (reset)
                e.Graphics.Clear(Color.Black);
        }
    }
}
