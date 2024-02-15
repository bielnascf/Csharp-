using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelasContrato.Entities
{
    class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorTotalContrato { get; set; }

        public List<Parcelas> Parcelas { get; set; }

        public Contrato(int numeroContrato, DateTime dataContrato, double valorTotalContrato)
        {
            NumeroContrato = numeroContrato;
            DataContrato = dataContrato;
            ValorTotalContrato = valorTotalContrato;
            Parcelas = new List<Parcelas>();
        }

        public void AdicionarParcela(Parcelas parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
