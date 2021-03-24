using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int xA, xB, yA, yB;
            //  Console.Write("xA = ");
            //  xA = int.Parse(Console.ReadLine());
            //  Console.Write("yA = ");
            //  yA = int.Parse(Console.ReadLine());
            //  Console.Write("xB = ");
            //  xB = int.Parse(Console.ReadLine());
            //  Console.Write("yB = ");
            //  yB = int.Parse(Console.ReadLine());

            //   egyenesEgyenlete(xA, xB, yA, yB);
            //   tavolsag(xA, xB, yA, yB);

            //  int xC, yC;
            //
            //  Console.Write("xC = ");
            //  xC = int.Parse(Console.ReadLine());
            //  Console.Write("yC = ");
            //  yC = int.Parse(Console.ReadLine());
            //
            //  coll(xA, xB, xC, yA, yB, yC);

            concurenta();
        }

        private static void concurenta()
        {
            double a1, b1, c1, a2, b2, c2, a3, b3, c3;
            Console.Write("a1 = ");
            a1 = double.Parse(Console.ReadLine());
            Console.Write("b1 = ");
            b1 = double.Parse(Console.ReadLine());
            Console.Write("c1 = ");
            c1 = double.Parse(Console.ReadLine());
            Console.Write("a2 = ");
            a2 = double.Parse(Console.ReadLine());
            Console.Write("b2 = ");
            b2 = double.Parse(Console.ReadLine());
            Console.Write("c2 = ");
            c2 = double.Parse(Console.ReadLine());
            Console.Write("a3 = ");
            a3 = double.Parse(Console.ReadLine());
            Console.Write("b3 = ");
            b3 = double.Parse(Console.ReadLine());
            Console.Write("c3 = ");
            c3 = double.Parse(Console.ReadLine());

            double a = (a1*b2*c3) + (a2*b3*c1) + (a3*b1*c2) - (c1*b2*a3) - (c2*b3*a1) - (c3*a2*b1);

            if (a == 0)
                Console.WriteLine("Concurent");
            else
                Console.WriteLine("nu-i concurent ;(");
        }
            
        private static void coll(int xA, int xB, int xC, int yA, int yB, int yC)
        {
            double a = (xA * yB) + (xB * yC) + (xC * yA) - (yB * xC) - (xA * yC) - (xB * yA);
            Console.WriteLine(a);
            if (a == 0)
                Console.WriteLine("Colliniar");
            else
                Console.WriteLine("Nu-i colliniar :(");
        }

        private static void tavolsag(int xA, int xB, int yA, int yB)
        {
            double first = Math.Pow(xB - xA, 2);
            double second = Math.Pow(yB - yA, 2);
            Console.WriteLine($"Distanta: {Math.Sqrt(first + second)}");
        }

        private static void egyenesEgyenlete(int xA, int xB, int yA, int yB)
        {
            int primElement = yA - yB;
            int secElement = xA - xB;
            int triElement = xA * yB - xB * yA;

            string secSemn, triSemn;

            if (secElement < 0)
            {
                secSemn = "+";
                secElement = -secElement;
            }
            else
                secSemn = "-";

            if (triElement < 0)
            {
                triElement = -triElement;
                triSemn = "-";
            }
            else
                triSemn = "+";

            Console.WriteLine($"AB: {primElement}x {secSemn} {secElement}y {triSemn} {triElement} = 0");
        }
    }
}