using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public class ToolScripColorButton : ToolStripButton
    {
        private Color selectedColor;

        public Color SelectedColor {
            get {
                return selectedColor; 
            }
            set { 

                selectedColor = value;
                UpdateImage();
            }
        }

        public System.Drawing.Rectangle ColorRectangle { get; set; } = new System.Drawing.Rectangle(0,13,16,3);
        

        protected override void OnClick(EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = dialog.Color;
                base.OnClick(e);
            }
        }

        private void UpdateImage()
        {
            if (Image == null)
                return;

            var g = Graphics.FromImage(Image);
            g.FillRectangle(new SolidBrush(SelectedColor),ColorRectangle);
            Invalidate();
        }
    }
}
