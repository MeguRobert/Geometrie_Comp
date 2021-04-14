using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
        private static bool animationWasStarted = false;
        private static int tick = 100;
        public Form1()
        {
            InitializeComponent();
            myGraphics.initGraph(pictureBox1);
            width = pictureBox1.Width;
            height = pictureBox1.Height;
            timer.Interval = tick;
        }

        

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            myGraphics.refreshGraph();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                return;
            }
            Engine.clear();
            myGraphics.clearGraph();
            myGraphics.refreshGraph();
        }

        private void btn_addPoint_Click(object sender, EventArgs e)
        {
            myGraphics.clearGraph();
            Engine.clear();
            //output.Text = "Punctele eliminate sunt:" ;
            if (GetInputs() == 0) return;
            Engine.drawPoints(myGraphics.gfx);
            myGraphics.refreshGraph();

        }

        private int GetInputs()
        {
            string input = textBox1.Text;
            if (input == "")
            {
                return 0;
            }
            if (float.TryParse(input, out float n))
            {
                myGraphics.clearGraph();
                Engine.clear();

                for (int i = 0; i < n; i++)
                {
                    Engine.points.Add(new Point(rnd.Next(width), rnd.Next(height)));
                }
            }
            else
            {
                string[] line = textBox1.Text.Split(' ');
                float X = float.Parse(line[0]);
                float Y = float.Parse(line[1]);
                Engine.points.Add(new Point(X, Y));
            }
            return Engine.points.Count;
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
            Engine.clear();
            output.Text = "Aria Poligonului: ";
            int n = int.Parse(textBox1.Text);
            if (n < 3) return;
            DrawLasloPoly(n);
            myGraphics.refreshGraph();
        }

        private void DrawCordinates()
        {
            for (int i = 0; i < Engine.points.Count; i++)
            {
                Point p = Engine.points[i];
                string text = $"P{i}({p.X},{p.Y})";
                Font font = new Font(FontFamily.GenericSansSerif, 100);
                using (Font myfont = new Font("Arial" , 8))
                {
                    if (!checkBox_Show_cordinates.Checked)
                    {
                        text = " ";
                    }
                    myGraphics.gfx.DrawString(text, myfont, Brushes.Purple, p.X, p.Y);
                }

            }
            

        }

        private void button_Graham_Click(object sender, EventArgs e)
        {
            Graham();
            Engine.drawPoints(myGraphics.gfx);
            Engine.DrawHull(myGraphics.gfx);
            myGraphics.refreshGraph();
        }

        private void button_Jarvis_Click(object sender, EventArgs e)
        {
            Jarvis();
            Engine.drawPoints(myGraphics.gfx);
            Engine.DrawHull(myGraphics.gfx);
            myGraphics.refreshGraph();
        }

        private void button_QuickHull_Click(object sender, EventArgs e)
        {
            
            QuickHull();
            Engine.DrawHull(myGraphics.gfx);
            myGraphics.refreshGraph();

            foreach (Point point in Engine.points)
            {
                if (!Engine.hull.Contains(point))
                {
                    string str = $"{point.X} {point.Y}";
                    //output.AppendText(Environment.NewLine);
                    //output.AppendText(str);
                }
            }
        }

        private void QuickHull()
        {
            Engine.hull.Clear();
            int min_x = 0, max_x = 0;
            for (int i = 1; i < Engine.points.Count; i++)
            {
                if (Engine.points[i].X < Engine.points[min_x].X)
                    min_x = i;
                if (Engine.points[i].X > Engine.points[max_x].X)
                    max_x = i;
            }
            Engine.hull.Add(Engine.points[min_x]);
            Engine.hull.Add(Engine.points[max_x]);
            Point A = Engine.hull[0];
            Point B = Engine.hull[1];

            //the separator line
            if (checkBox_separatorLine.Checked)
            {
                myGraphics.gfx.DrawLine(new Pen(Color.Purple), A.X, A.Y, B.X, B.Y);
            }

            List<Point> S1 = new List<Point>();
            List<Point> S2 = new List<Point>();


            foreach (Point point in Engine.points)
            {
                float side = Matematics.FindSide(A, B, point);
                if (side == -1) S1.Add(point);
                side = Matematics.FindSide(B, A, point);
                if (side == -1) S2.Add(point);
            }

            foreach (Point point in S1)
            {
                //point.fillColor = Color.Blue;
                point.fillColor = Color.FromArgb(rnd.Next(255),rnd.Next(255),rnd.Next(255));
                point.draw(myGraphics.gfx);
            }

            foreach (Point point in S2)
            {
                //point.fillColor = Color.Green;
                point.fillColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                point.draw(myGraphics.gfx);
            }
            FindHull(S1, A, B);
            FindHull(S2, B, A);


            
        }

        private void FindHull(List<Point> sk, Point P, Point Q)
        {
            if (sk.Count == 0) return;
            int farthestPointIndex = 0;

            float max_dist = 0;
            for (int i = 0; i < sk.Count; i++)
            {
                float dist = Matematics.lineDist(P, Q, sk[i]);
                if (dist > max_dist)
                {
                    max_dist = dist;
                    farthestPointIndex = i;
                }

            }

            Point C = sk[farthestPointIndex];
            int idx = Engine.hull.IndexOf(P);
            Engine.hull.Insert(idx, C);


            List<Point> S1 = new List<Point>();
            List<Point> S2 = new List<Point>();

            foreach (Point point in Engine.points)
            {
                float side = Matematics.FindSide(P, C, point);
                if (side == -1) S1.Add(point);
                side = Matematics.FindSide(C, Q, point);
                if (side == -1) S2.Add(point);
            }


            FindHull(S1, P, C);
            FindHull(S2, C, Q);


            
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
            if (area > 0) return 1; // clockwiseollinear
            return 0;               // collinear
        }

        private bool IsCounterClockwiseTurn(Point points, Point b, Point c)
        {
            return GetTurnType(points, b, c) == -1;
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

        private void button_Animate_QuickHull_Click(object sender, EventArgs e)
        {
            timer.Start(); 
            QuickHull(); 
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //checkBox_Show_cordinates_CheckedChanged(sender, e);
            button_Disco_Click(sender, e);
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button_Triangulate_Click(object sender, EventArgs e)
        {
            double area = 0;
            int count = Engine.points.Count;
            if (count < 3) return;
            if (count == 3) { area = Matematics.Area(Engine.points[0], Engine.points[1], Engine.points[2]); return; }

            List<Point> points = Engine.points;// lista temporara
            List<int> indexList = new List<int>();
            
            for (int i = 0; i < points.Count; i++)
            {
                indexList.Add(i); //initializarea listei de indecsi de la 0 pana la nr de puncte
            }

            Point A;
            Point B;
            Point C;

            output.AppendText( Environment.NewLine);
            
            while (indexList.Count > 3)
            {
                for (int i = 0; i < indexList.Count; i++)
                {
                    int a = indexList[i]; // the index of current Item
                    int b = GetItem(indexList, i - 1); // the index of leftside neighbour
                    int c = GetItem(indexList, i + 1); // the index of righside neighbour

                    A = points[a];
                    B = points[b];
                    C = points[c];

                    int clockwise = GetTurnType(A, B, C);
                    if (clockwise != -1) continue; // make a salt to next index


                    bool isEar = true;  //presupunem ca este o ureche valida daca este 
                    for (int j = 0; j < points.Count; j++)
                    {
                        if (j == a || j == b || j == c)
                        {
                            continue; //excluding the current index and the neighbours from test
                        }

                        if (IsPointInTriangle(points[j], A,B,C)) 
                        {
                            isEar = false;
                            break;
                        }
                    }


                    if (isEar)
                    {
                        
                        Engine.triangles.Add(new Triangle(A, B, C)); //add the triangle in the list, if is a valid ear.

                        indexList.RemoveAt(i); //remove the current index from the indexlist

                        //drawing the line to make a triangle visualy
                        Pen pen = new Pen(Color.Green);
                        myGraphics.gfx.DrawLine(pen, C.X, C.Y, B.X, B.Y);
                        myGraphics.refreshGraph();
                        break;
                    }
                        
                }

            }


            //adding last 3 points what makes a triangle
            A = points[indexList[0]];
            B = points[indexList[1]];
            C = points[indexList[2]];
            Engine.triangles.Add(new Triangle(A, B, C));

            // calculate the polygon area using triangle's area.
            foreach (Triangle triangle in Engine.triangles)
            {
                area += Math.Abs(Matematics.Area(triangle.A, triangle.B, triangle.C));
                
            }

            output.AppendText($"{area}");

        }

        private bool IsPointInTriangle(Point P, Point A, Point B, Point C)
        {
            float areaOfTriangle = Math.Abs(Matematics.Area(A, B, C));
            float area_APB = Math.Abs(Matematics.Area(A, P, B));
            float area_APC = Math.Abs(Matematics.Area(A, P, C));
            float area_BPC = Math.Abs(Matematics.Area(B, P, C));
            return areaOfTriangle == area_APB + area_APC + area_BPC;
        }

        /// <summary>
        /// Treats the list as a circle. Is used for getting elements from list,
        /// keeping the elements in the list's boundary.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="index"></param>
        /// <returns>A specified element from the list</returns>
        public static T GetItem<T>(List<T> list, int index)
        {
            if (index >= list.Count)
            {
                return list[index % list.Count];
            }
            else if (index < 0)
            {
                return list[index % list.Count + list.Count];
            }
            else
            {
                return list[index];
            }
        }

        private void button_DivideEtConquer_Click(object sender, EventArgs e)
        {
            DivideEtConquer();
            Engine.DrawHull(myGraphics.gfx);
            myGraphics.refreshGraph();

            foreach (Point point in Engine.points)
            {
                if (!Engine.hull.Contains(point))
                {
                    string str = $"{point.X} {point.Y}";
                    output.AppendText(Environment.NewLine);
                    output.AppendText(str);
                }
            }

        }

        private void DivideEtConquer()
        {
            Engine.hull.Clear();
            int min_x = 0, max_x = 0;
            for (int i = 1; i < Engine.points.Count; i++)
            {
                if (Engine.points[i].X < Engine.points[min_x].X)
                    min_x = i;
                if (Engine.points[i].X > Engine.points[max_x].X)
                    max_x = i;
            }
            Engine.hull.Add(Engine.points[min_x]);
            Engine.hull.Add(Engine.points[max_x]);
            Point A = Engine.hull[0];
            Point B = Engine.hull[1];

            List<Point> S1 = new List<Point>();
            List<Point> S2 = new List<Point>();


            foreach (Point point in Engine.points)
            {
                float side = Matematics.FindSide(A, B, point);
                if (side == -1) S1.Add(point);
                side = Matematics.FindSide(B, A, point);
                if (side == -1) S2.Add(point);
            }
           
            FindHull(S1, A, B);
            FindHull(S2, B, A);
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            //this button is reserved for testing//

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button_Colorful_Click(object sender, EventArgs e)
        {
            if (Engine.triangles.Count == 0)
            {
                return;
            }

            foreach (Triangle triangle in Engine.triangles)
            {
                Color color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                triangle.Draw(color);
            }
            myGraphics.refreshGraph();
        }


        private void button_Disco_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
                
            }
            if (checkBox1.Checked)
            {
                timer.Stop();
            }

            //draw_polygon_Click(sender, e);
            //button_Triangulate_Click(sender, e);
            //button_QuickHull_Click(sender, e);
            button_Colorful_Click(sender, e);
            //button_QuickHull_Click(sender, e);
        }

        private void checkBox_Show_cordinates_CheckedChanged(object sender, EventArgs e)
        {
            DrawCordinates();
            myGraphics.refreshGraph();
        }
    }
    
}
