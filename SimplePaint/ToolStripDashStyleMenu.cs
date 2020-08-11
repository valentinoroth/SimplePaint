using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SimplePaint
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
    public class ToolStripDashStyleMenu : ToolStripDropDownButton
    {
        const int DROP_DOWN_WIDTH = 40;

        class DashStyleMenuItem : ToolStripMenuItem
        {
            public DashStyle dashStyle;
            public DashStyle DashStyle
            {
                get { return dashStyle; }
                set
                {
                    dashStyle = value;
                    Bitmap img = new Bitmap(DROP_DOWN_WIDTH - 8, 4);
                    var g = Graphics.FromImage(img);
                    g.DrawLine(new Pen(Color.Black, 2) { DashStyle = dashStyle }, 0, 1, img.Width-1, 1);
                    Image = img;
                }
            }

            public DashStyleMenuItem(DashStyle style) : base()
            {
                ImageScaling = ToolStripItemImageScaling.None;
                DisplayStyle = ToolStripItemDisplayStyle.Image;
                DashStyle = style;
            }

        }

        private DashStyleMenuItem selectedItem;

        public DashStyle SelectedDashStyle
        {
            get { return selectedItem.DashStyle; }
            set
            {
                foreach (var item in DropDownItems)
                {
                    var di = item as DashStyleMenuItem;
                    if (di.DashStyle == value)
                    {
                        SetSelectedItem(di);
                        break;
                    }
                }
            }
        }

        public ToolStripDashStyleMenu() : base()
        {
            ImageScaling = ToolStripItemImageScaling.None;
            DisplayStyle = ToolStripItemDisplayStyle.Image;

            selectedItem = new DashStyleMenuItem(DashStyle.Solid);
            DropDownItems.Add(selectedItem);
            DropDownItems.Add(new DashStyleMenuItem(DashStyle.Dash));
            DropDownItems.Add(new DashStyleMenuItem(DashStyle.Dot));
            DropDownItems.Add(new DashStyleMenuItem(DashStyle.DashDot));
            DropDownItems.Add(new DashStyleMenuItem(DashStyle.DashDotDot));

            DropDown.AutoSize = false;
            DropDown.Width = DROP_DOWN_WIDTH;
            DropDown.Height = DropDownItems.Count * selectedItem.Height + 4;

            DropDownItemClicked += (s, e) => { SetSelectedItem(e.ClickedItem as DashStyleMenuItem); };

        }

        private void SetSelectedItem(DashStyleMenuItem item)
        {
            selectedItem = item;
            Image = item.Image;
        }
    }
}
