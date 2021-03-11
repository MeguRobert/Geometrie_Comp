using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliniaritate
{
    class Program
    {
        static void Main(string[] args)
        {
            int Xa, Xb, Ya, Yb, Xc, Yc;
            Console.WriteLine("Coordonatele lui A:");
            Console.Write("Xa = ");
            Xa = int.Parse(Console.ReadLine());
            Console.Write("Ya = ");
            Ya = int.Parse(Console.ReadLine());
            Console.WriteLine("Coordonatele lui B:");
            Console.Write("Xb = ");
            Xb = int.Parse(Console.ReadLine());
            Console.Write("Yb = ");
            Yb = int.Parse(Console.ReadLine());
            Console.WriteLine("Coordonatele lui C:");
            Console.Write("Xc = ");
            Xc = int.Parse(Console.ReadLine());
            Console.Write("Yc = ");
            Yc = int.Parse(Console.ReadLine());

            int det = Xa * Yb + Xb * Yc + Ya * Xc -( Xc * Yb + Xb * Ya + Xa * Yc);

            if (det == 0)
            {
                Console.WriteLine("Sunt coliniare");
            }
            else
            {
                Console.WriteLine("NU Sunt coliniare");
            }
            
            
        }
    }
}
