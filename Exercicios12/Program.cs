using Exercicios8;
using System.Globalization;

namespace Exercicios12
{
    class Program
    {
        static void Main(string[] args)
        {

            Linha();
            Console.WriteLine("Digite os dados do produto abaixo");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Linha();

            Produto produto = new Produto(nome, preco, quantidade);
         
            double valorTotalEmEstoque = produto.ValorTotalEmEstoque();

            string dadosDoProduto = $"""
                Dados do Produto
                Nome: {produto.Nome}
                Preço: R${produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}
                Quantidade: {produto.Quantidade} unidades
                Valor total: R${valorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture)}
                """;

            Thread.Sleep(1000);
            Console.WriteLine(dadosDoProduto);
            Linha();

            Console.Write($"Quantos produtos do tipo {produto.Nome} você deseja adicionar ao estoque? ");
            int adicionarQuantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(adicionarQuantidade);
            Linha();

            Console.Write($"Quantos produtos do tipo {produto.Nome} você deseja remover? ");
            int removerQuantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(removerQuantidade);
            Linha();
        }


        static void Linha()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
    }
}
