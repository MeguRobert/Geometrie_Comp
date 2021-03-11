using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drepte_Concurente
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, b1, c1;
            double a2, b2, c2;
            double a3, b3, c3;
            Console.WriteLine("Coeficientii dreptului d1:");
            Console.Write("a1 = ");
            a1 = double.Parse(Console.ReadLine());
            Console.Write("b1 = ");
            b1 = double.Parse(Console.ReadLine());
            Console.Write("c1 = ");
            c1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Coeficientii dreptului d2:");
            Console.Write("a2 = ");
            a2 = double.Parse(Console.ReadLine());
            Console.Write("b2 = ");
            b2 = double.Parse(Console.ReadLine());
            Console.Write("c2 = ");
            c2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Coeficientii dreptului d1:");
            Console.Write("a3 = ");
            a3 = double.Parse(Console.ReadLine());
            Console.Write("b3 = ");
            b3 = double.Parse(Console.ReadLine());
            Console.Write("c3 = ");
            c3 = double.Parse(Console.ReadLine());

            string semn_b1 = $"{b1}";
            string semn_c1 = $"{c1}";
            string semn_b2 = $"{b2}";
            string semn_c2 = $"{c2}";
            string semn_b3 = $"{b3}";
            string semn_c3 = $"{c3}";

            if (b1 > 0) semn_b1 = $"+{b1}";
            if (c1 > 0) semn_c1 = $"+{c1}";
            if (b2 > 0) semn_b2 = $"+{b2}";
            if (c2 > 0) semn_c2 = $"+{c2}";
            if (b3 > 0) semn_b3 = $"+{b3}";
            if (c3 > 0) semn_c3 = $"+{c3}";

            string a = "", b="", c="";
            if (a1 != 0) a = $"{a1}x";
            if (b1 != 0) b = $"{semn_b1}y";
            if (c1 != 0) c = $"{semn_c1}";
            string d1 = $"d1: {a} {b} {c} = 0";
            a = ""; b = ""; c = "";
            if (a2 != 0) a = $"{a2}x";
            if (b2 != 0) b = $"{semn_b2}y";
            if (c2 != 0) c = $"{semn_c2}";
            string d2 = $"d2: {a} {b} {c} = 0";
            a = ""; b = ""; c = "";
            if (a3 != 0) a = $"{a3}x";
            if (b3 != 0) b = $"{semn_b3}y";
            if (c3 != 0) c = $"{semn_c3}";
            string d3 = $"d3: {a} {b} {c} = 0";

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            double det = a1 * b2 * c3 + c1 * a2 * b3 + b1 * c2 * a3 - ( c1 * b2 * a3 + a1 * c2 * b3 + b1 * a2 * c3 );

            if (det == 0)
            {
                Console.WriteLine("Sunt concurente");
            }
            else
            {
                Console.WriteLine("NU Sunt concurente");
            }

        }
    }
}
