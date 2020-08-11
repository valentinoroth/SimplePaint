using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class PaintForm : Form
    {


        ToolStripButton selectedTool = null;

        //List<Line> lines = new List<Line>();

        //List<Rectangle> rectangles = new List<Rectangle>();

        List<Shape> shapes = new List<Shape>();

        public PaintForm()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            // e.Graphics.DrawLine(Pens.Black, lines.x1, lines.y1,  lines.x2, lines.y2);
            //e.Graphics.DrawLine(Pens.Black, 0,0,0,0);


            //foreach (var l in lines)
            //{
            //    e.Graphics.DrawLine(l.Color, l.X1, l.Y1, l.X2, l.Y2);
            //}
            //foreach (var l in rectangles)
            //{
            //    e.Graphics.DrawRectangle(l.Color, Math.Min(l.X1,l.X2), Math.Min(l.Y1, l.Y2), Math.Abs(l.X2-l.X1), Math.Abs(l.Y2 - l.Y1));
            //}

            foreach (var l in shapes)
            {
                l.Draw(e.Graphics);
            }

        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnLigne.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    shapes.Add(new Line(new Pen(toolScripColorButton1.SelectedColor), e.X, e.Y));
                }
            }
            else if (btnCarre.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    shapes.Add(new Rectangle(new Pen(toolScripColorButton1.SelectedColor), e.X, e.Y));
                }
            }
            else if (btnEllipse.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    shapes.Add(new Ellipse(new Pen(toolScripColorButton1.SelectedColor), e.X, e.Y));
                }
            }
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {


            if (btnLigne.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    shapes[shapes.Count - 1].X2 = e.X;
                    shapes[shapes.Count - 1].Y2 = e.Y;
                    DrawingPanel.Invalidate();
                }
            }
            else if(btnCarre.Checked){
                if (e.Button == MouseButtons.Left)
                {
                    shapes[shapes.Count - 1].X2 = e.X;
                    shapes[shapes.Count - 1].Y2 = e.Y;
                    DrawingPanel.Invalidate();
                }
            }
            else if (btnEllipse.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    shapes[shapes.Count - 1].X2 = e.X;
                    shapes[shapes.Count - 1].Y2 = e.Y;
                    DrawingPanel.Invalidate();
                }
            }

        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (btnLigne.Checked)
            {
                if (shapes[shapes.Count - 1].X2 == 0 && shapes[shapes.Count - 1].Y2 == 0)
                {
                    shapes.RemoveAt(shapes.Count - 1);
                }
            }
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SelectDrawingTool(e.ClickedItem);
        }

        private void SelectDrawingTool(ToolStripItem tool)
        {
            var si = tool as ToolStripButton;
            if (si == null)
                return;

            selectedTool = si;

            foreach (var i in ToolStrip.Items)
            {
                var btn = i as ToolStripButton;
                if (btn == null)
                    continue;
                btn.Checked = false;
            }

            selectedTool.Checked = true;
        }

    }
}
