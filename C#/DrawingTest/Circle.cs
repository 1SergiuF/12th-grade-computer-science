using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTest
{
    internal class Circle : Control
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
        public Color C { get; set; }

        public Circle(int x, int y, int r, Color c)
        {
            X = x;
            Y = y;
            R = r; 
            C = c;
        }
    }
}
