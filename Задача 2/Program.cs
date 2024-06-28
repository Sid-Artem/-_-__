using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {   
        static void GetCube(double a, out double s, out double v)
        {
            s = 6*(a*a);
            v = a*a*a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double r= double.Parse(Console.ReadLine());
            double s;
            double v;
            GetCube(r, out s, out v);
            Console.WriteLine("{0:.00} {1:.00}" , s , v );
            Console.ReadKey();
        }
    }
}
