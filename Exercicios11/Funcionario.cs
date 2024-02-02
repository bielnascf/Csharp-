using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios11
{
    class Funcionario
    {
        public string? Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            var Aumento = SalarioBruto * (porcentagem / 100);
            var salarioAumento = SalarioBruto - Imposto + Aumento;

            string mensagem = $"""
                Dados atualizados
                Funcionário: {Nome}
                Salário Bruto: R${SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}
                Imposto: R${Imposto.ToString("F2", CultureInfo.InvariantCulture)}
                Salário Líquido pós aumento: R${salarioAumento.ToString("F2", CultureInfo.InvariantCulture)}
                """;
            Console.WriteLine(mensagem);
        }
    }
}
