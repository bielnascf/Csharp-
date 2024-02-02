using System.Globalization;

namespace Exercicios14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Quantas pessoas você deseja informar a altura? ");
            //int qtdPessoas = int.Parse(Console.ReadLine());

            //double soma = 0, media;
            //double[] alturas = new double[qtdPessoas];

            //for(int i = 0;  i < qtdPessoas; i++)
            //{
            //    Console.Write($"Altura {i + 1}: ");
            //    alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    soma += alturas[i];
            //}

            //media = soma / qtdPessoas;

            //Console.WriteLine($"Média de altura das {qtdPessoas} pessoas é {media.ToString("F2", CultureInfo.InvariantCulture)}cm.");

            // ------------------------------------------------------------------------------------------------------------------------------

            Console.Write("Digite a quantidade de produtos: ");
            int qtdProdutos = int.Parse(Console.ReadLine());

            Produto[] produto = new Produto[qtdProdutos];

            double soma = 0, media;

            for (int i = 0; i < qtdProdutos; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produto[i] = new Produto(nome, preco);

                soma = soma + produto[i].Preco;
            }

            media = soma / qtdProdutos;

            Console.WriteLine($"A média dos preços dos produtos é R${media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}