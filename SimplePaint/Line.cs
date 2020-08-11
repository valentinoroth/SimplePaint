using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimplePaint
{
  public class Line : Shape
    {
        public Line(Pen color, int x1, int y1)
        {
            this.Color = color;
            this.X1 = x1;
            this.Y1 = y1;

        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(
                this.Color,
                X1,
                Y1,
                X2,
                Y2
            );
        }
    }
}
