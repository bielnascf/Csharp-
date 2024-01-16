using System.Globalization;

namespace Exercicios10
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            var nota1 = aluno.Nota1;
            var nota2 = aluno.Nota2;
            var media1 = aluno.Media1;
            var media2 = aluno.Media2;
            var media3 = aluno.Media3;

            Linha();
            Console.WriteLine("Colégio Nossa Senhora das Mercês");
            Console.WriteLine("Bem vindo ao sistema de notas!");

            Linha();
            Console.WriteLine("1° TRIMESTRE");
            Console.Write("Nota da primeira prova: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota da segunda prova: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media1 = aluno.Media(nota1, nota2);
            Thread.Sleep(2000);
            Console.WriteLine($"MÉDIA: {media1.ToString("F1", CultureInfo.InvariantCulture)}");

            Linha();
            Console.WriteLine("2° TRIMESTRE");
            Console.Write("Nota da primeira prova: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota da segunda prova: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media2 = aluno.Media(nota1, nota2);
            Thread.Sleep(2000);
            Console.WriteLine($"MÉDIA: {media2.ToString("F1", CultureInfo.InvariantCulture)}");

            Linha();
            Console.WriteLine("3° TRIMESTRE");
            Console.Write("Nota da primeira prova: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota da segunda prova: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media3 = aluno.Media(nota1, nota2);
            Thread.Sleep(2000);
            Console.WriteLine($"MÉDIA: {media3.ToString("F1", CultureInfo.InvariantCulture)}");

            Thread.Sleep(1000);
            Console.WriteLine("Analisando...");
            Thread.Sleep(3000);

            Linha();
            aluno.MediaFinal(media1, media2, media3);
            Linha();
        }

        static void Linha()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
    }
}
