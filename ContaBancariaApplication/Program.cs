using ContaBancariaApplication;
using System.Globalization;

namespace ContaBancariaApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();

            Linha();
            Console.WriteLine("Bem vindo ao Banco GBucks");
            Linha();
            Console.Write("Deseja criar Conta no nosso banco (1 - Sim / 2 - Nao)? ");
            int criarConta = int.Parse(Console.ReadLine());
            while (criarConta < 1 || criarConta > 2)
            {
                Console.Write("Resposta inválida. Digite 1 para Sim e 2 para Não: ");
                criarConta = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Thread.Sleep(1000);

            if (criarConta == 1)
            {
                Linha();
                Console.Write("Digite um número qualquer que possua 4 dígitos: ");
                string numeroConta = Console.ReadLine();
                while (numeroConta.Length != 4)
                {
                    Console.WriteLine("Número de conta inválido. Digite novamente!");
                    Console.Write("Digite um número qualquer que possua 4 dígitos: ");
                    numeroConta = Console.ReadLine();
                }

                Console.Write("Digite um nome para o titular da conta: ");
                string nomeTitular = Console.ReadLine();
                while (nomeTitular.Length < 7)
                {
                    Console.WriteLine("O nome do titular precisa ter no mínimo 7 letras. Caso necessário, adicione um sobrenome");
                    Console.Write("Digite um nome para o titular da conta: ");
                    nomeTitular = Console.ReadLine();
                }

                Console.Write("Gostaria de iniciar sua conta depositando algum valor (1 - Sim / 2 - Nao)? ");
                int iniciarDeposito = int.Parse(Console.ReadLine());
                while (iniciarDeposito < 1 || iniciarDeposito > 2)
                {
                    Console.WriteLine("Resposta inválida. Tende novamente.");
                    Console.Write("Iniciar sua conta depositando algum valor (1 para Sim e 2 para Não)? ");
                    iniciarDeposito = int.Parse(Console.ReadLine());
                }

                if (iniciarDeposito == 1)
                {
                    Console.Write("Digite a quantia que você deseja depositar: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contaBancaria = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);
                }
                else if (iniciarDeposito == 2)
                {
                    contaBancaria = new ContaBancaria(numeroConta, nomeTitular);

                }

                Console.WriteLine("Conta criada com sucesso!");
                Linha();
            }
            else if (criarConta == 2)
            {
                Linha();
                Console.WriteLine("Finalizando...");
                Console.WriteLine("Nós do banco GBucks agradecemos sua visita!");

                Linha();
                Thread.Sleep(1000);

                return;
            }

            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(2000);

            Linha();
            Console.WriteLine("Logar na sua conta");
            Linha();
            Console.Write("Número da conta: ");
            string loginConta = Console.ReadLine();
            while (loginConta != contaBancaria.Conta)
            {
                Console.WriteLine("Essa conta bancária não existe. Tente novamenente");
                Console.Write("Número da conta: ");
                loginConta = Console.ReadLine();
            }

            Console.Write("Nome do titular: ");
            string loginTitular = Console.ReadLine();
            while (loginTitular != contaBancaria.Titular)
            {
                Console.WriteLine("Esse nome de titular não existe. Tente novamente");
                Console.Write("Nome do titular: ");
                loginTitular = Console.ReadLine();
            }

            Console.WriteLine("Logado com sucesso!");
            Linha();


            Console.Clear();
            Thread.Sleep(2000);

            Console.WriteLine("O que deseja fazer?");
            string tabelaOpcoes = """
                1 - Ver saldo
                2 - Depositar
                3 - Saque
                4 - Informações da conta
                5 - Sair
                >>>> 
                """;

            while (true)
            {
                Console.Write(tabelaOpcoes);
                int opcao = int.Parse(Console.ReadLine());

                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(2000);

                if (opcao == 1)
                {
                    Console.WriteLine($"SALDO DA CONTA: R${contaBancaria.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite o valor que você deseja depositar: ");
                    double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contaBancaria.Deposito(valorDeposito);
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o valor que você deseja sacar: ");
                    double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contaBancaria.Saque(valorSaque);
                }
                else if (opcao == 4)
                {
                    Console.WriteLine($"NÚMERO DA CONTA: {contaBancaria.Conta}");
                    Console.WriteLine($"NOME DO TITULAR: {contaBancaria.Titular}");
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Finalizando aplicação...");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente");
                }

                Linha();
            }
        }

        static void Linha()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
    }
}
