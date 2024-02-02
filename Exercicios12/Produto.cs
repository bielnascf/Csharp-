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
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
            double precoTotal = Preco * Quantidade;

            string mensagem = $"""
                Dados atualizados
                Nome: {_nome}
                Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}
                Quantidade: {Quantidade} unidades
                Valor total: R${precoTotal.ToString("F2", CultureInfo.InvariantCulture)}
                """;
            Console.WriteLine(mensagem);
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
            double precoTotal = Preco * Quantidade;

            string mensagem = $"""
                Dados atualizados
                Nome: {_nome}
                Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}
                Quantidade: {Quantidade} unidades
                Valor total: R${precoTotal.ToString("F2", CultureInfo.InvariantCulture)}
                """;
            Console.WriteLine(mensagem);
        }
    }
}
