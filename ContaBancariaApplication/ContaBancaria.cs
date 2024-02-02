using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaApplication
{
    class ContaBancaria
    {
        public string Conta { get; private set; }
        public string Titular { get; private set; }

        public double Saldo { get; private set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(string conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(string conta, string titular, double depositoInicial) : this(conta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;

            Console.WriteLine($"Valor de R${valorDeposito.ToString("F2", CultureInfo.InvariantCulture)} depositado com sucesso!");
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque + 5.0;

            Console.WriteLine($"Valor de R${valorSaque.ToString("F2", CultureInfo.InvariantCulture)} sacado com sucesso!");
        }
    }
}
