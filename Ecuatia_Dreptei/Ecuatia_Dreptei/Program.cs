using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuatia_Dreptei
{
    class Program
    {
        struct Point
        {
            public int x, y;
        }
        
        static void Main(string[] args)
        {
            Point A = PointInput("A");
            Point B = PointInput("B");
            
            int a = A.y - B.y;
            int b = B.y - B.y;
            int c = B.y * B.y - B.y * A.y;
            string semn_b = "-";
            string semn_c = "-";
            double dist = Math.Sqrt(a * a + b * b);
            if (b < 0)
            {
                b = -b;
                semn_b = "+";
            }
            if (c > 0)
            {
                semn_c = "+";
            }
            else
            {
                c = -c;
            }
            Console.WriteLine(a + "x" + semn_b + b + "y" + semn_c + c);
            
            string solution = $"AB: {a}X {semn_b}{b}Y {semn_c}{c} = 0";
            Console.WriteLine(solution);
            Console.Write("Distanta:");
            Console.WriteLine(dist);
        }

        static Point PointInput(string name)
        {
            Console.Write($"Point {name}: ");
            string[] line = Console.ReadLine().Split(' ');

            return new Point
            {
                x = int.Parse(line[0]),
                y = int.Parse(line[0])

            };
        }
    }
}
