using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geome_0317
{
   
    public partial class Form1 : Form
    {
        private static Random rnd = new Random();
        private static int border = 10;
        private static int width;
        private static int height;
        public Form1()
        {
            InitializeComponent();
            myGraphics.initGraph(pictureBox1);
            width = pictureBox1.Width;
            height = pictureBox1.Height;
        }

       

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            myGraphics.refreshGraph();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Engine.clear();
            myGraphics.clearGraph();
            myGraphics.refreshGraph();
        }

        private void btn_addPoint_Click(object sender, EventArgs e)
        {

            string input = textBox1.Text;

            if (float.TryParse(input,out float n))
            {
                myGraphics.clearGraph();
                Engine.clear();

                for (int i = 0; i < n; i++)
                {
                    Engine.points.Add(new Point(rnd.Next(400), rnd.Next(300)));
                }
            }
            else
            {
                string[] line = textBox1.Text.Split(' ');
                float X = float.Parse(line[0]);
                float Y = float.Parse(line[1]);
                Engine.points.Add(new Point(X, Y));
            }
            Engine.drawPoints(myGraphics.gfx);
            myGraphics.refreshGraph();

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            myGraphics.clearGraph();
            Engine.remove();
            Engine.draw(myGraphics.gfx);
            myGraphics.refreshGraph();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Engine.drawLines(myGraphics.gfx);
            myGraphics.refreshGraph();
        }

        private void DrawLasloPoly(int n)
        {
            Engine.drawPolygon(myGraphics.gfx, n);
        }



        private void draw_polygon_Click(object sender, EventArgs e)
        {
            myGraphics.gfx.Clear(Color.AliceBlue);
            Engine.points.Clear();
            int n = int.Parse(textBox1.Text);
            if (n < 3) return;
            DrawLasloPoly(n);
            //DrawNonIntersectingPoly();
            myGraphics.refreshGraph();
        }


        private void button_Graham_Click(object sender, EventArgs e)
        {
            Graham();
            Engine.drawPoints(myGraphics.gfx);
            Engine.DrawHull();
            myGraphics.refreshGraph();
        }

        private void button_Jarvis_Click(object sender, EventArgs e)
        {
            Jarvis();
            Engine.drawPoints(myGraphics.gfx);
            Engine.DrawHull();
            myGraphics.refreshGraph();
        }

        private void FindLowestPoint()
        {
            int lowestPointIndex = 0;
            for (int i = 1; i < Engine.points.Count; i++)
            {
                if (Engine.points[i].Y > Engine.points[lowestPointIndex].Y)
                {
                    lowestPointIndex = i;
                }
                else if (Engine.points[i].Y == Engine.points[lowestPointIndex].Y)
                {
                    if (Engine.points[i].X < Engine.points[lowestPointIndex].X)
                    {
                        lowestPointIndex = i;
                    }
                }
            }
            Point aux = Engine.points[lowestPointIndex];
            Engine.points[lowestPointIndex] = Engine.points[0];
            Engine.points[0] = aux;
        }


        private int GetTurnType(Point a, Point b, Point c)
        {
            float area = (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);
            if (area < 0) return -1; // counterclockwise
            if (area > 0) return 1; // clockwise
            return 0; // collinear
        }

        private bool IsCounterClockwiseTurn(Point a, Point b, Point c)
        {
            return GetTurnType(a, b, c) == -1;
        }

        private void SortPointsByAngle(Point center)
        {
            List<Point> sortedPoints =
            Engine.points.GetRange(1, Engine.points.Count - 1).OrderBy(p => -Math.Atan2(p.Y - center.Y, p.X - center.X)).ToList();
            Point firstPoint = Engine.points[0];
            Engine.points.Clear();
            Engine.points.Add(firstPoint);
            Engine.points.AddRange(sortedPoints);
        }

        private void Graham()
        {
            Engine.hull.Clear();
            FindLowestPoint();
            SortPointsByAngle(Engine.points[0]);
            Engine.hull.Add(Engine.points[0]);
            Engine.hull.Add(Engine.points[1]);
            for (int i = 2; i < Engine.points.Count; i++)
            {
                while (Engine.hull.Count > 1 && !IsCounterClockwiseTurn(Engine.hull[Engine.hull.Count - 2], Engine.hull[Engine.hull.Count - 1], Engine.points[i]))
                {
                    Engine.hull.RemoveAt(Engine.hull.Count - 1);
                }
                Engine.hull.Add(Engine.points[i]);
            }
        }

        private void Jarvis()
        {
            Engine.hull.Clear();
            FindLowestPoint();
            Engine.hull.Add(Engine.points[0]);
            Point previous = Engine.points[0];
            while (true)
            {
                Point next = new Point();
                next.X = -1;
                next.Y = -1;
                foreach (Point p in Engine.points)
                {
                    if (p.X == previous.X && p.Y == previous.Y) continue;
                    if (next.X == -1 && next.Y == -1)
                    {
                        next = p;
                        continue;
                    }

                    if (IsCounterClockwiseTurn(previous, next, p))
                    {
                        next = p;
                    }
                }
                if (next.X == Engine.points[0].X && next.Y == Engine.points[0].Y) break;
                Engine.hull.Add(next);
                previous = next;
            }
        }

        
    }
    
}
