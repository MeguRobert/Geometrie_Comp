using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_vectori_matematic_
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Press Enter...");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Problema:");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Problema1();
                        break;
                    case 2:
                        Problema2();
                        break;
                    case 3:
                        Problema3();
                        break;
                    default:
                        break;
                }
            }

        }

        


        /// <summary>
        /// Se dau 2 vectori care se introduc de la tastatura. Sa se scrie programul de determinare:
        /// a) Produsul scalar al vectorilor
        /// b) Se verifice daca vectorii sunt perpendiculari
        /// c) Sa se calculeze marimea celor 2 vectori.
        /// </summary>
        static int idx = 1;
        private static void Problema1()
        {
            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine(" P R O B L E M A   1");

            Console.WriteLine($"Introduceti v1:");
            Console.Write("x = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("v1=" + Vector(x1, y1, z1));

            Console.WriteLine($"Introduceti v2:");
            Console.Write("x = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("v2=" +  Vector(x2, y2, z2));

            double produs = x1 * x2 + y1 * y2 + z1 * z2;
            Console.WriteLine($"Produsul {produs}");
            if (produs == 0)
                Console.WriteLine("Vectorii sunt perpendicualri");
            else
                Console.WriteLine("Vectorii NU sunt perpendicualri");

            double marime = Math.Sqrt(x1*x1+y1*y1+z1*z1);
            Console.WriteLine("Marimea primului vector: " + marime);

            double marime2 = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);
            Console.WriteLine("Marimea al doilea vector: " + marime2);

        }

        private static void Problema2()
        {
            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine(" P R O B L E M A   2");

            Console.WriteLine($"Introduceti v1:");
            Console.Write("x = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("v1=" + Vector(x1, y1, z1));

            Console.WriteLine($"Introduceti v2:");
            Console.Write("x = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("v2=" + Vector(x2, y2, z2));


            int a = y1 * z2 - z1 * y2;
            int b = x2 * z1 - z2 * x1;
            int c = x1 * y2 - x2 * y1;
            string produsvectorial = Vector(a,b,c);
            Console.WriteLine($"Produsul vectorial: {produsvectorial}");
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Vectorii sunt coliniari");
            }
            else
            {
                Console.WriteLine("Vectorii NU sunt coliniari");
            }

            double marime = Math.Sqrt(a*a+b*b+c*c);
            Console.WriteLine("Aria palalelogrammului construit de cei doi vectori este: " + marime);
        }

        private static void Problema3()
        {
            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine(" P R O B L E M A   3");

            Console.WriteLine($"Introduceti v1:");
            Console.Write("x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("z1 = ");
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("v1=" + Vector(x1, y1, z1));

            Console.WriteLine($"Introduceti v2:");
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("z2 = ");
            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("v2=" + Vector(x2, y2, z2));

            Console.WriteLine($"Introduceti v3:");
            Console.Write("x3 = ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            int y3 = int.Parse(Console.ReadLine());
            Console.Write("z3 = ");
            int z3 = int.Parse(Console.ReadLine());
            Console.WriteLine("v3=" + Vector(x3, y3, z3));


            double produs_mixt = x1 * y2 * z3 + x2 * y3 * z1 + x3 * y1 * z2 - z1 * y2 * x3 - z2 * y3 * x1 - z3 * y1 * x2;

            Console.WriteLine($"Produsul mixt este = {produs_mixt}");

            if (produs_mixt == 0)
                Console.WriteLine("Vectorii sunt coplanari");
            else
                Console.WriteLine("Vectorii nu sunt coplanari");

            double volum = Math.Abs(produs_mixt);

            Console.WriteLine($"Volumul este {volum}");

        }
        private static string Vector( int x, int y, int z)
        {
            string result = null;
            if (x != 0)
            {
                result += $"{x}i";
                
            }
            if (y != 0)
            {
                result += $"{Write(y)}j";
            }
            if (z != 0)
            {
                result += $"{Write(z)}k";
            }
            if (result == null)
            {
                return "0";
            }
            return $"{ x }i{Write(y)}j{Write(z)}k";
        }

        private static string Write(int x)
        {

            if (x >= 0)
                return $"+{x.ToString()}";
            else
                return $"{x.ToString()}";
        }
    }
}
