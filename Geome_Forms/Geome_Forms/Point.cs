using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClaseForms
{
    class Point
    {
        public Color fillColor;
        public Color drawColor;
        private static Random rnd = new Random();

        public Point(float x, float y)
        {
            X = x;
            Y = y;
            fillColor = Color.Red;
            drawColor = Color.Black;
        }

        public float X { get; set; }
        public float Y { get; set; }

        public void draw(Graphics gfx)
        {
            int size = 6;
            int halfOfSize = size/2;
            gfx.FillEllipse(new SolidBrush(fillColor), X - halfOfSize, Y - halfOfSize, size, size);
            gfx.DrawEllipse(new Pen(drawColor),        X - halfOfSize, Y - halfOfSize, size, size);
        }
    }
}
