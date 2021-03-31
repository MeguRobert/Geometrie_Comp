using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geome_0317
{
    public class Matematics
    {
        private static List<int> myIndexes = new List<int>();

        static float Euclid(Point A, Point B)
        {
            return (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

        static float Area(Point A, Point B, Point C)
        {
            return 0.5f * ((A.X * B.Y) + (B.X * C.Y) + (C.X * A.Y) - (C.X * B.Y) - (A.X * C.Y) - (A.Y * B.X));
        }
        public float AreaPoligon(List<Point> points)
        {
            Point O = new Point(0, 0);
            float val = 0;
            for (int i = 0; i < points.Count - 1; i++)
            {
                val += Area(points[i], points[i + 1], O);
            }
            return Math.Abs(val);
        }

        public static (int,int) MinDist(int n, int idx1, int idx2)
        {
            float min = Euclid(Engine.points[0], Engine.points[1]);
            idx1 = 0;
            idx2 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    float t = Euclid(Engine.points[i], Engine.points[j]);
                    if (t < min)
                    {
                        min = t;
                        idx1 = i;
                        idx2 = j;
                    }
                }
            }
            return (idx1, idx2);
        }

        

        public static int TheNearestTo(int idx1)
        {
            if (myIndexes.Count == 0)
            {
                myIndexes.Add(0);
            }
            float min = 10000;
            
            int idx2 = 0;
            for (int i = 0; i < Engine.points.Count; i++)
            {
                if (idx1 == i) continue;
                if (myIndexes.Contains(i)) continue;
                float t = Euclid(Engine.points[idx1], Engine.points[i]);
                if (t < min)
                {
                    min = t;
                    idx2 = i;
                }
            }
            myIndexes.Add(idx2);
            return idx2;
        }

        public static void clear()
        {
           myIndexes.Clear();
        }
    }
}
