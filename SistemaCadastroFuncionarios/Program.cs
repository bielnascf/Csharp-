using System.Globalization;

namespace Exercicios18
{
    class Program
    {
        static void Main(string[] args)
        {
            Linha();
            Console.WriteLine("Sistema de cadastro e Controle de funcionários");
            Linha();

            Console.Write("Digite a quantidade de funcionários que você deseja cadastrar: ");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());
            Linha();

            List<Funcionarios> funcionarios = new List<Funcionarios>();

            for (int i = 0; i < quantidadeFuncionarios; i++)
            {
                Console.WriteLine($"Funcionário {i + 1}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: R$");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionarios(id, nome, salario));
                Linha();
            }

            Console.Clear();
            Thread.Sleep(2000);

            string mensagem = """
                Controle de Funcionários
                [1] - Informações dos Funcionários
                [2] - Aumentar Salário
                [3] - Adicionar um Funcionário
                [4] - Remover um Funcionário
                [5] - Sair do Programa
                >>>> 
                """;

            while(true)
            {
                Linha();
                Console.Write(mensagem);
                int opcao = int.Parse(Console.ReadLine());
                Linha();

                Console.Clear();
                Thread.Sleep(1000);

                if (opcao == 1)
                {
                    Console.WriteLine("Lista de Funcionários atualizada");
                    foreach (Funcionarios funcionario in funcionarios)
                    {
                        string listaFuncionarios = $"""
                            Id: {funcionario.Id}
                            Nome: {funcionario.Nome}
                            Salário: R${funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}
                            """;
                        Console.WriteLine(listaFuncionarios);
                    }
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite o ID do funcionário que você deseja aumentar: ");
                    int pesquisarId = int.Parse(Console.ReadLine());

                    Funcionarios funcionario = funcionarios.Find(funci => funci.Id == pesquisarId);

                    if (funcionario != null)
                    {
                        Console.Write("Digite a porcentagem que você deseja aumentar: ");
                        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        funcionario.AumentarSalario(porcentagem);
                    }
                    else
                    {
                        Console.WriteLine("Esse ID não foi encontrado.");
                    }
                }
                else if(opcao == 3)
                {
                    Console.WriteLine("Adicionar Funcionário");
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Salário: R$");
                    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    funcionarios.Add(new Funcionarios(id, nome, salario));

                    Console.WriteLine("Adicionando funcionário...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Funcionário adicionado com sucesso!");
                }
                else if (opcao == 4)
                {
                    Console.Write("Digite o ID do funcionário que vocÊ deseja rewmover: ");
                    int pesquisarId = int.Parse(Console.ReadLine());

                    Funcionarios funcionario = funcionarios.Find(funci => funci.Id == pesquisarId);
                    funcionarios.Remove(funcionario);

                    Console.WriteLine("Removendo funcionário...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Funcionário removido com sucesso!");
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Finalizando...");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }

        static void Linha()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }

    }
}

