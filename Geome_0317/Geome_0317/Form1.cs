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
        private static int tick = 1000;
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
            Engine.clear();
            myGraphics.clearGraph();
            myGraphics.refreshGraph();
        }

        private void btn_addPoint_Click(object sender, EventArgs e)
        {
            output.Text = "Punctele eliminate sunt:" ;
            if (GetInputs() == 0) return;
            Engine.drawPoints(myGraphics.gfx);
            DrawCordinates();
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
            Engine.points.Clear();
            output.Text = "Aria Poligonului: ";
            int n = int.Parse(textBox1.Text);
            if (n < 3) return;
            DrawLasloPoly(n);
            DrawCordinates();
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
                    output.AppendText(Environment.NewLine);
                    output.AppendText(str);
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
                point.fillColor = Color.Blue;
                point.draw(myGraphics.gfx);
            }

            foreach (Point point in S2)
            {
                point.fillColor = Color.Green;
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
            if (area > 0) return 1; // clockwise
            return 0; // collinear
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
           
            if (Engine.hull.Count != 0)
            {
                Engine.DrawHull(myGraphics.gfx); 
                myGraphics.refreshGraph();
            }
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
            if (count == 3) area = Matematics.Area(Engine.points[0], Engine.points[1], Engine.points[2]);

            List<Point> points = Engine.points;
            List<int> indexList = new List<int>();
            
            for (int i = 0; i < points.Count; i++)
            {
                indexList.Add(i);
            }

            //Engine.triangles = new List<Triangle>();

            int totalTriangleCount = points.Count - 2;
            int totalTriangleIndexCount = totalTriangleCount * 3;

            int[] triangles = new int[totalTriangleIndexCount];
            int currentTriangleIndex = 0;
            output.AppendText( Environment.NewLine);
            int whilecontor = 0; // just for test & debug
            while (indexList.Count > 3)
            {
                whilecontor++;
                for (int i = 0; i < points.Count; i++)
                {
                    int b = GetItem(indexList, i - 1); // the index of leftside neighbour
                    int a = indexList[i]; // the index of current Item
                    int c = GetItem(indexList, i + 1); // the index of righside neighbour

                    //maybe not implemented corectly
                    Vector v1 = new Vector(points[a], points[b]);
                    Vector v2 = new Vector(points[a], points[c]);
                    Vector v3 = new Vector(points[c], points[b]);



                    int clockwise = GetTurnType(points[a], points[b], points[c]);
                    if (clockwise != -1) continue; // make a salt to next index

                    output.AppendText($"{i}. Clockwise: {clockwise}" + Environment.NewLine);
                    bool isEar = true;  // este varf?
                
                    for (int j = 0; j < points.Count; j++)
                    {
                        if (j == a || j == b || j == c)
                        {
                            continue; //exclude the current index and the neighbours from test
                        }

                        if (IsPointInTriangle(points[j], v1.startPoint,v2.startPoint,v3.startPoint))
                        {
                            isEar = false;
                            output.AppendText($" IS An Ear? {isEar}" + Environment.NewLine);
                            break;
                        }
                    }


                    if (isEar)
                    {
                        triangles[currentTriangleIndex++] = a;
                        triangles[currentTriangleIndex++] = b;
                        triangles[currentTriangleIndex++] = c;

                        indexList.RemoveAt(i);
                        points.RemoveAt(i);

                        output.AppendText($"{i}. IS AN EAR!" + Environment.NewLine);


                        Pen pen = new Pen(Color.Green);

                        myGraphics.gfx.DrawLine(pen, v3.startPoint.X, v3.startPoint.Y, v3.endPoint.X, v3.endPoint.Y);
                        myGraphics.refreshGraph();
                        break;
                    }
                        
                }



                if (whilecontor > 10)
                {
                    break;
                }

            }


            //adding last 3 points what makes a triangle
            triangles[currentTriangleIndex++] = indexList[0];
            triangles[currentTriangleIndex++] = indexList[1];
            triangles[currentTriangleIndex++] = indexList[2];

            //output.AppendText($"{area}");
            output.AppendText($"AREEEAAAAAAAAAAA");


        }

        private bool IsPointInTriangle(Point P, Point A, Point B, Point C)
        {
            float areaOfTriangle = Matematics.Area(A, B, C);
            float area_APB = Matematics.Area(A, P, B);
            float area_APC = Matematics.Area(A, P, C);
            float area_BPC = Matematics.Area(B, P, C);

            return areaOfTriangle == area_APB + area_APC + area_BPC;
        }

        #region Mathematics


        private double Cosinus(Vector v1, Vector v2)
        {
            FormaVectoriala vectoriala1 = new FormaVectoriala(v1.startPoint, v1.endPoint);
            FormaVectoriala vectoriala2 = new FormaVectoriala(v2.startPoint, v2.endPoint);
            double numarator = ProdusVectorial(vectoriala1, vectoriala2);
            double numitor = ProdusModule(vectoriala1, vectoriala2);
            double cos = numarator / numitor;
            return cos;
        }

        private double ProdusModule(FormaVectoriala vectoriala1, FormaVectoriala vectoriala2)
        {
            return Math.Sqrt(Modulo(vectoriala1) * Modulo(vectoriala2)) ;
        }

        private double Modulo(FormaVectoriala vectoriala)
        {
            return vectoriala.a * vectoriala.a + vectoriala.b * vectoriala.b;
        }

        private double ProdusVectorial(FormaVectoriala vectoriala1, FormaVectoriala vectoriala2)
        {
            return vectoriala1.a * vectoriala2.a + vectoriala1.b * vectoriala2.b;
        }

        class FormaVectoriala
        {
            public int a;
            public int b;
            public FormaVectoriala(Point p1, Point p2)
            {
                a = (int)(p2.X - p1.X);
                b = (int)(p2.Y - p1.Y);
            }
        }
        #endregion

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
            //int side1 = Matematics.FindSide(Engine.points[0], Engine.points[1], Engine.points[3]);
            //int side2 = Matematics.FindSide(Engine.points[1], Engine.points[2], Engine.points[3]);
            //int side3 = Matematics.FindSide(Engine.points[2], Engine.points[0], Engine.points[3]);

            //output.AppendText($"{side1}" + Environment.NewLine );
            //output.AppendText($"{side2}" + Environment.NewLine );
            //output.AppendText($"{side3}" + Environment.NewLine );
            //if (side1 == -1 && side2 == -1 && side3 == -1)
            //{
            //    output.AppendText($"interior");
            //}
            //else
            //{
            //    output.AppendText($"exterior");
            //}

            Point A = Engine.points[0];
            Point B = Engine.points[1];
            Point C = Engine.points[2];



            Vector ba = new Vector(B, A);
            Vector bc = new Vector(B, C);

            double cos = Cosinus(ba, bc);
            output.AppendText($"Cos: {cos}");
        }
    }
    
}
