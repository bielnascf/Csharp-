using ParcelasContrato.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;

namespace ParcelasContrato.Services
{
    class ContractService 
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contrato contrato, int meses)
        {
            double quantia = contrato.ValorTotalContrato / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.DataContrato.AddMonths(i);
                double quantiaAtualizada = quantia + _onlinePaymentService.Interest(quantia, i);
                double quantiaFinal = quantiaAtualizada + _onlinePaymentService.Juros(quantiaAtualizada);
                contrato.AdicionarParcela(new Parcelas(data, quantiaFinal));
            }


        }
    }
}
