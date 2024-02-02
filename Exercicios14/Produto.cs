using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios14
{
    class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
