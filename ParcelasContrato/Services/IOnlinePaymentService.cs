using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelasContrato.Services
{
    interface IOnlinePaymentService
    {
        double Juros(double quantia);

        double Interest(double quantia, int meses);
    }
}
