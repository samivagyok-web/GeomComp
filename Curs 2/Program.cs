using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            trei();
        }

        private static void unu()
        {
            double x1, y1, z1, x2, y2, z2;

            Console.Write("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("z1 = ");
            z1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = double.Parse(Console.ReadLine());
            Console.Write("z2 = ");
            z2 = double.Parse(Console.ReadLine());

            string semn1, semn2;

            if (y1 < 0)
            {
                semn1 = "-";
                y1 = -y1;
            }
            else
                semn1 = "+";

            if (z1 < 0)
            {
                semn2 = "-";
                z1 = -z1;
            }
            else
                semn2 = "+";

            Console.WriteLine($"Primul vector: {x1}i {semn1} {y1}j {semn2} {z1}k");

            if (y2 < 0)
            {
                semn1 = "-";
                y2 = -y2;
            }
            else
                semn1 = "+";

            if (z2 < 0)
            {
                semn2 = "-";
                z2 = -z2;
            }
            else
                semn2 = "+";

            Console.WriteLine($"Al doilea vector: {x2}i {semn1} {y2}j {semn2} {z2}k");


            double prodScal = (x1 * x2) + (y1 * y2) + (z1 * z2);

            if (prodScal == 0)
                Console.WriteLine("Perpendicular");
            else
                Console.WriteLine($"Produs scalar = {prodScal}");

            Console.WriteLine($"Marimea primului vector = {Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(z1, 2))}");
            Console.WriteLine($"Marimea al doilea vector = {Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2) + Math.Pow(z2, 2))}");
        }

        private static void doi()
        {
            double x1, y1, z1, x2, y2, z2;

            Console.Write("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("z1 = ");
            z1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = double.Parse(Console.ReadLine());
            Console.Write("z2 = ");
            z2 = double.Parse(Console.ReadLine());

            double i = (y1 * z2) - (z1 * y2);
            double j = (z1 * x2) - (x1 * z2);
            double k = (x1 * y2) - (x2 * y1);
            if (j < 0 && k > 0)
            {
                Console.WriteLine($"v1xv2= {i}i{j}j+{k}k");
            }
            if (j < 0 && k < 0)
            {
                Console.WriteLine($"v1xv2= {i}i{j}j{k}k");
            }
            if (j > 0 && k > 0)
            {
                Console.WriteLine($"v1xv2= {i}i+{j}j+{k}k");
            }
            if (j > 0 && k < 0)
            {
                Console.WriteLine($"v1xv2= {i}i+{j}j{k}k");
            }
            if (i == 0 && j == 0 && k == 0) Console.WriteLine($"v1xv2= 0");
            //Console.WriteLine($"Produsul vectorial :  {i}i {j}j {k}k");
            if (i == 0 && j == 0 && k == 0) Console.WriteLine("Sunt coliniari");
            else Console.WriteLine("NU sunt coliniari.");
            double aria = Math.Sqrt((i * i) + (j * j) + (k * k));
            Console.WriteLine($"Aria = {aria}");
        }

        private static void trei()
        {
            double x1, y1, z1, x2, y2, z2, x3, y3, z3;

            Console.Write("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("z1 = ");
            z1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = double.Parse(Console.ReadLine());
            Console.Write("z2 = ");
            z2 = double.Parse(Console.ReadLine());
            Console.Write("x3 = ");
            x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            y3 = double.Parse(Console.ReadLine());
            Console.Write("z3 = ");
            z3 = double.Parse(Console.ReadLine());

            semn(x1, y1, z1);
            semn(x2, y2, z2);
            semn(x3, y3, z3);

            double a = ((x1 * y2 * z3) + (x2 * y3 * z1) + (x3 * y1 * z2) - (z1 * y2 * x3) - (z2 * y3 * x1) - (z3 * x2 * y1));

            Console.WriteLine($"Produsul mixt: {a}");
            if (a == 0) Console.WriteLine("Coplanar");
            else
                Console.WriteLine("Nu-i coplanar");

            Console.WriteLine($"Volumul: {Math.Abs((x1 * y2 * z3) + (x2 * y3 * z1) + (x3 * y1 * z2) - (z1 * y2 * x3) - (z2 * y3 * x1) - (z3 * x2 * y1))}");
        }

        private static void semn(double x1, double y1, double z1)
        {
            string semn1, semn2;

            if (y1 < 0)
            {
                semn1 = "-";
                y1 = -y1;
            }
            else
                semn1 = "+";

            if (z1 < 0)
            {
                semn2 = "-";
                z1 = -z1;
            }
            else
                semn2 = "+";

            Console.WriteLine($"vector: {x1}i {semn1} {y1}j {semn2} {z1}k");
        }
    }
}
