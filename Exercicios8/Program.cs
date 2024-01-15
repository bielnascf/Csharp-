using System.Globalization;

namespace Exercicios8 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Linha();
            Console.WriteLine("Digite os dados do produto abaixo");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Linha();

            produto.PrecoTotal = produto.ValorTotalEmEstoque();

            string dadosDoProduto = $"""
                Dados do Produto
                Nome: {produto.Nome}
                Preço: R${produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}
                Quantidade: {produto.Quantidade} unidades
                Total (R$) em estoque: R${produto.PrecoTotal.ToString("F2", CultureInfo.InvariantCulture)}
                """;
            Thread.Sleep(1000);
            Console.WriteLine(dadosDoProduto);
            Linha();

            Thread.Sleep(1000);
            ControleEstoqueTabela();
            
            
            int opcao = int.Parse(Console.ReadLine());

            while(opcao < 1 || opcao > 3)
            {
                Console.Write("Opção inválida. Tente novamente: ");
                opcao = int.Parse(Console.ReadLine());
            }

            while(true)
            {
                if (opcao == 1)
                {
                    produto.AdicionarProdutos();
                    Thread.Sleep(2000);
                    break;
                }
                else if (opcao == 2)
                {
                    produto.RemoverProdutos();
                    Thread.Sleep(2000);
                    break;
                }
                else if(opcao == 3)
                {
                    Console.WriteLine("Finalizando Prograna...");
                    Thread.Sleep(3000);
                    break;
                }

            }
        }

        static void Linha()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }

        static void ControleEstoqueTabela()
        {
            string controleEstoque = $"""
                Controle de Estoque
                1 - Adicionar Produtos
                2 - Remover Produtos
                3 - Finalizar Programa
                >>> 
                """;
            Console.Write(controleEstoque);
        }
    }
}