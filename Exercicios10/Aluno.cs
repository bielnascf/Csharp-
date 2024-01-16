using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios10
{
    class Aluno
    {
        public double Nota1;
        public double Nota2;
        public double Media1;
        public double Media2;
        public double Media3;

        public double Media(double Nota1, double Nota2)
        {
            return (Nota1 + Nota2) / 2;
        }

        public void MediaFinal(double Media1, double Media2, double Media3)
        {
            var mediaFinal = (Media1 + Media2 + Media3) / 3;
            if(mediaFinal < 6.0)
            {
                Console.WriteLine($"Média Final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Situação Final: REPROVADO");
            }

            Console.WriteLine($"Média Final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Situação Final: APROVADO");
        }
    }
}
