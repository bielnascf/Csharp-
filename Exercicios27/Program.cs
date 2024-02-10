using Exercicios27.Entities;
using System.Drawing;
using System.Globalization;

namespace Exercicios27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de figuras: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura n° {i}");
                Console.Write("Retângulo ou Círculo (r/c): ");
                char shapeType = char.Parse(Console.ReadLine());

                Console.Write("Cor (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(shapeType == 'r')
                {
                    Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Altura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Entities.Rectangle(width, height, color));
                }
                else if(shapeType == 'c')
                {
                    Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
                else
                {
                    Console.WriteLine("Tipo inválido.");
                }
            }

            Console.WriteLine("Áreas das figuras");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
