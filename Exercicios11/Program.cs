using System.Globalization;

namespace Exercicios11
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Linha();
            Console.Write("Digite o seu nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Digite o valor do seu salário bruto: R$");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do imposto: R$");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Linha();

            var salarioLiquido = funcionario.SalarioLiquido();

            string mensagem = $"""
                Funcionário: {funcionario.Nome}
                Salário Bruto: R${funcionario.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}
                Imposto: R${funcionario.Imposto.ToString("F2", CultureInfo.InvariantCulture)}
                """;
            Console.WriteLine(mensagem);
            Thread.Sleep(1000);
            Console.WriteLine("Calculando Salário Líquido...");
            Thread.Sleep(3000);

            Console.WriteLine($"Seu salário líquido equivale a R${salarioLiquido.ToString("F2", CultureInfo.InvariantCulture)}");
            Linha();

            string tabelaOpcao = """
                Deseja aumentar seu salário?
                1 - Sim
                2 - Não
                >>>> 
                """;

            Console.Write(tabelaOpcao);
            int opcao = int.Parse(Console.ReadLine());
            while (opcao > 2 || opcao < 1)
            {
                Console.Write("Opção inválida. Tente novamente: ");
                opcao = int.Parse(Console.ReadLine());
            }
            Linha();

            if (opcao == 1)
            {
                Console.Write("Deseja aumentar o salário em quantos % ?: ");
                double aumento = double.Parse(Console.ReadLine());

                funcionario.AumentarSalario(aumento);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Finalizando...");
            }
            Thread.Sleep(2000);
            Linha();
        }

        static void Linha()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
       
    }
}
