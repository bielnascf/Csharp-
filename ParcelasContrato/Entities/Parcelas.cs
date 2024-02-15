using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelasContrato.Entities
{
    class Parcelas
    {
        public DateTime DataVencimento { get; set; }
        public double ValorParcela { get; set; }

        public Parcelas() { }
        
        public Parcelas(DateTime dataVencimento, double valorParcela)
        {
            DataVencimento = dataVencimento;
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return $"""
                {DataVencimento.ToString("(dd/MM/yyyy)")} - {ValorParcela.ToString("F2", CultureInfo.InvariantCulture)}
                """;
        }
    }
}
