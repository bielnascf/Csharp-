using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios9
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area(double Largura, double Altura)
        {
            return Largura * Altura;
        }

        public double Perimetro(double Largura, double Altura)
        {
            return (2 * Largura) + (2 * Altura);
        }

        public double Diagonal(double Largura, double Altura)
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
