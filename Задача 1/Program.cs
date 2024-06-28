using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static double GetSqrt(double a, double b, double c)
        {
            double p= (a+b+c)/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите стороны первого треугольника");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());
            double v1 = GetSqrt(x1, y1,z1);

            Console.WriteLine("Введите стороны второго треугольника");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());
            double v2 = GetSqrt(x2, y2, z2);

            if (v1 > v2) Console.WriteLine("Площадь первого треугольника больше");
            else
                if (v1 < v2) Console.WriteLine("Площадь второго треугольника больше");
            else Console.WriteLine("Площадь треугольников равна");
            Console.ReadKey();
        }
    }
}
