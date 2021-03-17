using System;
using System.Collections.Generic;
using System.Drawing;

namespace Geome_0317
{
    public class Polygon
    {
        public static Random rnd = new Random();
        public static List<Point> points = new List<Point>();
        public Polygon(int n)
        {
            int size = 50;
            points.Add(new Point(rnd.Next(400 - size), rnd.Next(300 - size)));
            for (int i = 0; i < n; i++)
            {
                points.Add(new Point(rnd.Next(400 - size), rnd.Next(300 - size)));
            }
        }

        public static void drawPoints(Graphics gfx)
        {
            foreach (Point p in points)
                p.draw(gfx);
        }

        public static void drawLines(Graphics gfx)
        {
            Color color = Color.FromArgb(rnd.Next(250), rnd.Next(250), rnd.Next(250));
            Pen pen = new Pen(color);
            for (int i = 0; i < points.Count - 1; i++)
                gfx.DrawLine(pen, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            gfx.DrawLine(pen, points[points.Count - 1].X, points[points.Count - 1].Y, points[0].X, points[0].Y);
        }


        public void draw(Graphics gfx)
        {
            drawPoints(gfx);
            drawLines(gfx);
        }
    }
}
