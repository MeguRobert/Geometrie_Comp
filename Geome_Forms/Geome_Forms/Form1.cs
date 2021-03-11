using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ClaseForms
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        List<Point> points = new List<Point>();
        List<Point> pointsForMedians = new List<Point>();
        int control = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = pictureBox1.CreateGraphics();
        }

        //distance
        float Euclid(Point A, Point B)
        {
            return (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

        

        void MinDist(int n, int idx1,  int idx2)
        {
            Color colorMin = Color.Green;
            float min = Euclid(points[0], points[1]);
            idx1 = 0;
            idx2 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    float t = Euclid(points[i], points[j]);
                    if (t < min)
                    {
                        min = t;
                        idx1 = i;
                        idx2 = j;
                    }
                }
            }
            //DrawMyLine(points,idx1, idx2 ,colorMin);
            
            float locx = points[idx1].X + points[idx1].X;
            //labelMin.Location.X = locx;
        }
        void MaxDist(int n, int idx1, int idx2)
        {
            Color colorMax = Color.BlueViolet;
            float max = Euclid(points[0], points[1]);
            idx1 = 0;
            idx2 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                
                for (int j = i + 1; j < n; j++)
                {
                    float t = Euclid(points[i], points[j]);
                    if (t > max)
                    {
                        max = t;
                        idx1 = i;
                        idx2 = j;
                    }
                }
            }
            //DrawMyLine(points,idx1, idx2 , colorMax);
            
        }

        private void DrawMyLine(List<Point> points1,int idx1, List<Point> points2, int idx2,Color lineColor)
        {
            
            Pen pen = new Pen(lineColor);
            gfx.DrawLine(pen, points1[idx1].X, points1[idx1].Y, points2[idx2].X, points2[idx2].Y);
        }
        private void DrawMyLine(int idx1, int idx2, Color lineColor)
        {
            DrawMyLine(points, idx1, points, idx2, lineColor);
        }
        private void DrawMyLine(int idx1, int idx2)
        {
            DrawMyLine(idx1, idx2, Color.Black);
        }
        private void DrawStar()
        {
            
        }

        private void ClearLastPoint()
        {
            points.RemoveAt(points.Count - 1);
            DrawPoints(points);
        }

        private void button1_Click(object sender, EventArgs e)
        {









            
            /*
            
           string message, title, defaultValue;
            object myValue;

            message = $"Input the point cordinates!";
            title = "C# : InputBox Example.";
            defaultValue = "";

            myValue = Interaction.InputBox(message, title, defaultValue, -1, -1);

            if ((string)myValue == "")
            {

            }*/
        }

        private void button_Draw_Click(object sender, EventArgs e)
        {
            control = 1; //pentru button back
            string[] line = textBox1.Text.Split(',');
            float x = int.Parse(line[0]);
            float y = int.Parse(line[1]);
            if (x>700 || y>400)
            {

            }
            Point newPoint = new Point(x, y);
            if (IsInTheList(newPoint))
            {
                label_message.Visible = true; 
            }
            else
            {
                points.Add(newPoint);
                label_message.Visible = false;
            }
            DrawPoints(points);
        }

        private void DrawPoints(List<Point> points)
        {
            foreach (Point point in points)
            {
                point.draw(gfx);
            }
        }

        private bool IsInTheList(Point newPoint)
        {
            foreach (Point point in points)
            {
                if (point.X == newPoint.X && point.Y == newPoint.Y)
                {
                    return true;
                }
            }
            return false;
        }
        
        private void button_DrawPoligon_Click(object sender, EventArgs e)
        {
            control = 2; //pentru button back
            if (points.Count == 0)
            {
                return;
            }
            for (int i = 1; i < points.Count; i++)
            {
                DrawMyLine(i - 1 , i );
            }
            DrawMyLine(points.Count - 1, 0);
        }

        private void button_DrawMedians_Click(object sender, EventArgs e)
        {
            control = 3; //pentru button back
            if (points.Count == 3 && pointsForMedians.Count==0)
            {
                pointsForMedians.Add(MedianPoint(1,2));
                pointsForMedians.Add(MedianPoint(2,0));
                pointsForMedians.Add(MedianPoint(0,1));
                foreach (Point point in pointsForMedians)
                {
                    point.draw(gfx);
                }
                for (int i = 0; i < pointsForMedians.Count; i++)
                {
                    DrawMyLine(points, i, pointsForMedians, i, Color.OrangeRed);
                }
            }
        }

        private Point MedianPoint(int idx1, int idx2)
        {
            float x = (points[idx1].X + points[idx2].X)/2;
            float y = (points[idx1].Y + points[idx2].Y)/2;
            return new Point(x, y);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            points.Clear();
            pointsForMedians.Clear();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            switch (control)
            {
                case 1:
                    ClearLastPoint();
                    break;
                default:
                    break;
            }
        }

        
    }
}
