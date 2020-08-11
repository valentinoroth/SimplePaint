using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class Ellipse : Shape
    {
        public Ellipse(Pen color, int x, int y)
        {
            this.Color = color;
            this.X1 = x;
            this.Y1 = y;

        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(
                this.Color,
                X,
                Y,
                Width,
                Height
            );
        }
    }
}
