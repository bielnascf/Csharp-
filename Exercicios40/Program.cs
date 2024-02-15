using Exercicios40.Model.Entities;
using Exercicios40.Model.Enums;

namespace Exercicios40
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circulo() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Retangulo() { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}