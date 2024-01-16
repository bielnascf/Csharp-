using System.Globalization;

namespace Exercicios9
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            var largura = retangulo.Largura;
            var altura = retangulo.Altura;

            Console.WriteLine("Digite a largura e a altura de um retângulo qualquer");
            Console.Write("Largura (cm): ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura (cm): ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Linha();

            string tabela = """
                O que você deseja saber?
                1 - Area
                2 - Perimetro
                3 - Diagonal
                4 - Todas as informações acima 
                5 - Sair
                >>>>> 
                """;
            Console.Write(tabela);
            int opcao = int.Parse(Console.ReadLine());
            Linha();

            if(opcao == 1)
            {
                var area = retangulo.Area(largura, altura);

                Console.WriteLine($"A área desse retângulo é {area.ToString("F2", CultureInfo.InvariantCulture)}cm².");
            }
            else if(opcao == 2)
            {
                var perimetro = retangulo.Perimetro(largura, altura);

                Console.WriteLine($"O perímetro desse retângulo é {perimetro.ToString("F2", CultureInfo.InvariantCulture)}cm.");
            }
            else if(opcao == 3)
            {
                var diagonal = retangulo.Diagonal(largura, altura);

                Console.WriteLine($"A diagonal desse retângulo mede {diagonal.ToString("F2", CultureInfo.InvariantCulture)}cm.");
            }
            else if(opcao == 4)
            {
                var area = retangulo.Area(largura, altura);
                var perimetro = retangulo.Perimetro(largura, altura);
                var diagonal = retangulo.Diagonal(largura, altura);

                string mensagem = $"""
                    Área: {area.ToString("F2", CultureInfo.InvariantCulture)}cm²
                    Perimetro: {perimetro.ToString("F2", CultureInfo.InvariantCulture)}cm
                    Diagonal: {diagonal.ToString("F2", CultureInfo.InvariantCulture)}cm
                    """;
                Console.WriteLine(mensagem);

            }
            else if( opcao == 5)
            {
                Console.WriteLine("Finalizando Programa...");
                Thread.Sleep(2000);
            }
            
        }

        static void Linha()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
    }
}
