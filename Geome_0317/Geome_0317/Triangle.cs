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
    }
}