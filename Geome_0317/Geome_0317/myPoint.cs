using System.Drawing;

namespace Geome_0317
{
    public class Point
    {
        public static int size = 2;
        public float X, Y;
        public Color fillColor;
        public Color drawColor;
        public string nume;

        public Point(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
            this.fillColor = Color.Red;
            this.drawColor = Color.Black;
        }

        public Point(float X, float Y, Color fillColor, Color drawColor)
        {
            this.X = X;
            this.Y = Y;
            this.fillColor = fillColor;
            this.drawColor = drawColor;
        }

        public void draw(Graphics gfx)
        {
            Pen p = new Pen(drawColor);
            SolidBrush sb = new SolidBrush(fillColor);
            gfx.FillEllipse(sb, X - size, Y - size, size * 2 + 1, size * 2 + 1);
            gfx.DrawEllipse(p, X - size, Y - size, size * 2 + 1, size * 2 + 1);
            gfx.DrawString(nume, new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(X, Y));
        }
    }
}