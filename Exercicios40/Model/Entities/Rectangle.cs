

using System.Globalization;

namespace Exercicios40.Model.Entities
{
    class Retangulo : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"""
                Circle color: {Color}
                Width = {Width.ToString("F2", CultureInfo.InvariantCulture)}
                Height = {Height.ToString("F2", CultureInfo.InvariantCulture)}
                Area = {Area().ToString("F2", CultureInfo.InvariantCulture)};
                """;
        }
    }
}
