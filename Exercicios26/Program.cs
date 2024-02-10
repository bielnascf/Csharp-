using Exercicios26.Entities;
using System.Globalization;

namespace Exercicios26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1001, "Gabriel Nascimento", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1002, "Gabriela Moraes", 500.0, 150.00));
            accounts.Add(new SavingsAccount(1003, "Silvia Regina", 500.0, 0.02));
            accounts.Add(new BusinessAccount(1004, "Gilson Nascimento", 500.00, 3000.00));

            double soma = 0;
            foreach(Account account in accounts)
            {
                soma += account.Balance;
            }

            Console.WriteLine($"Total Balance: ${soma.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach(Account account in accounts)
            {
                account.WithDraw(10.0);
            }

            foreach(Account account in accounts)
            {
                Console.WriteLine($"Saldo atualizado para a conta {account.Number}: ${account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}