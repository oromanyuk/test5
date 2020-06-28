using System;

namespace ConsoleApp8
{
    class calc
    {
        public static void Kvurav(double a, double b, double c)
        {
            double d = b * b - 2 * a * c;
            if (d >= 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.WriteLine("Корней нет!");
            }
        }
        public static void Bikvurav(double a, double b, double c)
        {
            double d = b * b - 2 * a * c;
            if (d >= 0)
            {
                double t1 = (-b + Math.Sqrt(d)) / (2 * a);
                double t2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("t1 = " + t1);
                Console.WriteLine("t2 = " + t2);
                if (t1 < 0 && t2 < 0)
                {
                    Console.WriteLine("Корней нет!");
                }
                else
                {
                    if (t1 >= 0 && t2 >= 0)
                    {
                        double x1 = Math.Sqrt(t1);
                        double x2 = -x1;
                        double x3 = -Math.Sqrt(t2);
                        double x4 = -x3;
                        Console.WriteLine("x1= {0} x2={1} x3={2} x4={3}", x1, x2, x3, x4);
                    }
                    else
                    {
                        if (t1 >= 0)
                        {
                            double x1 = Math.Sqrt(t1);
                            double x2 = -x1;
                            Console.WriteLine("x1={0} x2={1}", x1, x2);
                        }
                        else
                        {
                            double x3 = -Math.Sqrt(t2);
                            double x4 = -x3;
                            Console.WriteLine("x1={0} x2={1}", x3, x4);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Корней нет!");
            }
        }

    }
    class calc2 : calc
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            calc2.Kvurav(2, 4, 5);
            calc2.Bikvurav(1, 13, 36);
        }
    }
}
