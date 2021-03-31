using System;
using System.Collections.Generic;
using System.Drawing;

namespace Geome_0317
{
    public class Polygon
    {
        public static Random rnd = new Random();
        
        public Polygon()
        {
            int size = 50;
            
        }

        public static void drawPoints(Graphics gfx)
        {
            foreach (Point p in Engine.points)
                p.draw(gfx);
        }

        public static void drawLines(Graphics gfx)
        {
            Color color = Color.FromArgb(rnd.Next(250), rnd.Next(250), rnd.Next(250));
            Pen pen = new Pen(color);
            for (int i = 0; i < Engine.points.Count - 1; i++)
                gfx.DrawLine(pen, Engine.points[i].X, Engine.points[i].Y, Engine.points[i + 1].X, Engine.points[i + 1].Y);
            gfx.DrawLine(pen, Engine.points[Engine.points.Count - 1].X, Engine.points[Engine.points.Count - 1].Y, Engine.points[0].X, Engine.points[0].Y);
        }

        public static PointF[] MakePolygon()
        {
            PointF[] pointFs = new PointF[Engine.points.Count];
            for (int i = 0; i < pointFs.Length; i++)
            {
                pointFs[i] = new PointF(Engine.points[i].X, Engine.points[i].Y);
            }

            return pointFs;
        }

        public static PointF[] GeneratePolygon(PointF c, int n, float l)
        {
            PointF[] p = new PointF[n];
            float uc = (float)(Math.PI * 2) / (float)n;
            for (int i = 0; i < n; i++)
            {
                float x = c.X + l * (float)Math.Cos(uc * i);
                float y = c.Y + l * (float)Math.Sin(uc * i);
                p[i] = new PointF(x, y);
            }
            return p;
        }

        public static PointF[] GeneratePolygon(PointF c, int n)
        {
            int min = rnd.Next(5,50);
            int max = rnd.Next(50,450);
            PointF[] p = new PointF[n];
            float uc = (float)(Math.PI * 2) / (float)n;
            for (int i = 0; i < n; i++)
            {
                float l = rnd.Next(min, max);
                float x = c.X + l * (float)Math.Cos(uc * i);
                float y = c.Y + l * (float)Math.Sin(uc * i);
                p[i] = new PointF(x, y);
            }
            return p;
        }

        public static void draw(Graphics gfx, int laturi)
        {
            PointF c = new PointF(myGraphics.resx / 2, myGraphics.resy / 2);
            gfx.FillPolygon(new SolidBrush(Color.Red), GeneratePolygon(c, laturi));
            
        }
    }
}
