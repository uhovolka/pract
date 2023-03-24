using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            reshenie equation = new reshenie(1, 4, -4);
            equation.exct();
            Console.ReadKey(true);
        }

        class reshenie
        {
            private double a;
            private double b;
            private double c;
            private double d;
            private double x1;
            private double x2;

            private double discr()
            {
                d = Math.Pow(b, 2) - 4 * a * c;
                return d;
            }
            public void raschet()
            {
                this.d = discr();
                if (d > 0 || d == 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Корней нет");
                    Console.ReadKey();
                }

            }

            public reshenie(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public void exct()
            {
                raschet();
            }
        }
    }
}
