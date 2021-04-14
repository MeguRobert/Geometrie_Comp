using System;
using System.Drawing;

namespace Geome_0317
{
    public class Triangle
    {
        public Point A;
        public Point B;
        public Point C;
        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Triangle(int idx1, int idx2, int idx3)
        {
            this.A = Engine.points[idx1];
            this.B = Engine.points[idx2];
            this.C = Engine.points[idx3];
        }

        public void Draw(Color color)
        {
            Pen pen = new Pen(color);
            SolidBrush sb = new SolidBrush(color);
            PointF[] pointf = new PointF[3];
            pointf[0] = new PointF(A.X,A.Y);
            pointf[1] = new PointF(B.X,B.Y);
            pointf[2] = new PointF(C.X,C.Y);



            myGraphics.gfx.FillPolygon(sb, pointf);
        }

        //public void draw(Graphics gfx)
        //{
        //    Random rnd 
        //    Color color = Color.FromArgb()
        //    Pen p = new Pen(drawColor);
        //    SolidBrush sb = new SolidBrush(fillColor);
        //    gfx.FillEllipse(sb, X - size, Y - size, size * 2 + 1, size * 2 + 1);
        //    gfx.DrawEllipse(p, X - size, Y - size, size * 2 + 1, size * 2 + 1);
        //    gfx.DrawString(nume, new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(X, Y));
        //}
    }
}