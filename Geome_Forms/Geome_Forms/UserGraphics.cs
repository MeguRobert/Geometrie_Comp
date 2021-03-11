using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClaseForms
{
    class UserGraphics
    {
        public Graphics gfx;
        public Bitmap bmp;
        public PictureBox display;
        public int resx, resy;
        public Color backColor;


        public UserGraphics(PictureBox display, Color backColor)
        {
            this.display = display;
            this.backColor = backColor;
            resx = display.Width;
            resy = display.Height;
            bmp = new Bitmap(resx, resy);
            gfx = Graphics.FromImage(bmp);
            clear();
            refresh();
        }

        public void refresh()
        {
            display.Image = bmp;
        }

        public void clear()
        {
            gfx.Clear(backColor);
        }

    }
}
