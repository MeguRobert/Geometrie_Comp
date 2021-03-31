using System.Collections.Generic;
using System.Drawing;

namespace Geome_0317
{
    public static class Engine
    {
        public static List<Point> points = new List<Point>();
        public static List<Square> squares = new List<Square>();
        public static List<Point> hull = new List<Point>();

        public static void draw(Graphics gfx)
        {
            drawPoints(gfx);
            drawLines(gfx);
            drawSquares(gfx);
        }
        public static void drawSquares(Graphics gfx)
        {
            foreach (Square s in squares)
                s.draw(gfx);
        }
        public static void drawPolygon(Graphics gfx , int laturi)
        {
            Polygon.draw(gfx, laturi);
        }
        public static void drawPoints(Graphics gfx)
        {
            foreach (Point p in points)
                p.draw(gfx);
        }
        public static void DrawHull()
        {
            Pen pen = new Pen(Color.Red);
            for (int i = 0; i < hull.Count - 1; i++)
            {
                
                myGraphics.gfx.DrawLine(pen, hull[i].X,hull[i].Y, hull[i + 1].X,hull[i + 1].Y);
            }
            myGraphics.gfx.DrawLine(pen, hull[hull.Count - 1].X, hull[hull.Count - 1].Y, hull[0].X, hull[0].Y);
        }
        private static void DrawMyLine(List<Point> points1, int idx1, List<Point> points2, int idx2, Color lineColor)
        {

            Pen pen = new Pen(lineColor);
            myGraphics.gfx.DrawLine(pen, points1[idx1].X, points1[idx1].Y, points2[idx2].X, points2[idx2].Y);
        }
        private static void DrawMyLine(int idx1, int idx2, Color lineColor)
        {
            DrawMyLine(points, idx1, points, idx2, lineColor);
        }
        private static void DrawMyLine(int idx1, int idx2)
        {
            DrawMyLine(idx1, idx2, Color.Black);
        }

        public static void drawLines(Graphics gfx)
        {
            for (int i = 0; i < points.Count - 1; i++)
                gfx.DrawLine(Pens.Black, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            gfx.DrawLine(Pens.Black, points[points.Count - 1].X, points[points.Count - 1].Y, points[0].X, points[0].Y);
        }

        public static void remove()
        {
            points.RemoveAt(points.Count - 1);
            squares.RemoveAt(squares.Count - 1);
        }
        public static void clear()
        {
            points.Clear();
            //squares.Clear();
        }
    }
}