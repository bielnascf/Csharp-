using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelasContrato.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double PorcentagemJuros = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Juros(double quantia)
        {
            return quantia * PorcentagemJuros;
        }

        public double Interest(double quantia, int meses)
        {
            return quantia * MonthlyInterest * meses;
        }
    }
}
