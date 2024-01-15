using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios8
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double PrecoTotal;

        public double ValorTotalEmEstoque()
        {
            double precoTotal = Preco * Quantidade;

            return precoTotal;
        }

        public void AdicionarProdutos()
        {
            int quantidadeAdicionar = 0;
            Console.Write("Quantos você deseja adicionar ao estoque?: ");
            quantidadeAdicionar = int.Parse(Console.ReadLine());

            Quantidade += quantidadeAdicionar;
            PrecoTotal = Preco * Quantidade;

            string mensagem = $"""
                        Dados atualizados
                        Nome: {Nome}
                        Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}
                        Quantidade: {Quantidade} unidades
                        Total (R$) em estoque: R${PrecoTotal.ToString("F2", CultureInfo.InvariantCulture)}
                        """;

            Console.WriteLine(mensagem);
        }

        public void RemoverProdutos()
        {
            int quantidadeRemover = 0;
            Console.Write("Quantos você deseja remover do estoque?: ");
            quantidadeRemover = int.Parse(Console.ReadLine());

            Quantidade -= quantidadeRemover;
            PrecoTotal = Preco * Quantidade;

            string mensagem = $"""
                        Dados atualizados
                        Nome: {Nome}
                        Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}
                        Quantidade: {Quantidade} unidades
                        Total (R$) em estoque: R${PrecoTotal.ToString("F2", CultureInfo.InvariantCulture)}
                        """;

            Console.WriteLine(mensagem);
        }
    }
}
