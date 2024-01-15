using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios6
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double AreaTriangulo()
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }
    }
}
