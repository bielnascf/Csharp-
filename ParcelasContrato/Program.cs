using ParcelasContrato.Entities;
using ParcelasContrato.Services;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace ParcelasContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato abaixo");

            Console.Write("Número do contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());

            Console.Write("Data do contrato (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine());

            Console.Write("Valor do contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numeroContrato, dataContrato, valorContrato);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contrato, meses);

            foreach (Parcelas parcela in contrato.Parcelas)
            {
                Console.WriteLine(parcela);
            } 
        }
    }
}