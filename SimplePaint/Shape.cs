using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public abstract class Shape 
    {
        public int Height { get => Math.Abs(Y2 - Y1); }
        public int Width { get => Math.Abs(X2 - X1); }
        public int X { get => Math.Min(X1, X2); }
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y { get => Math.Min(Y1, Y2); }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public Pen Color { get; set; }

        public Shape()
        {

        }

        public abstract void Draw(Graphics g);

    }
}
