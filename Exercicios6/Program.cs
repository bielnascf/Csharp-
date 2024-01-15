using System.Globalization;

namespace Exercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite abaixo as medidas do triângulos X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite abaixo as medidas do triângulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var AreaTrianguloX = x.AreaTriangulo();
            var AreaTrianguloY = y.AreaTriangulo();

            string mensagem = $"""A área do triangulo X é {AreaTrianguloX.ToString("F2", CultureInfo.InvariantCulture)}cm² e a área do triangulo Y é {AreaTrianguloY.ToString("F2", CultureInfo.InvariantCulture)}cm²""";
            Console.WriteLine(mensagem);
        }
    }
}