using PesquisaDeSalario.Entities;
using PesquisaDeSalario.Entities.Enums;
using System.Globalization;

namespace PesquisaDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sistema de Visualização de Salário de Funcionários");
            Console.Write("Digite o nome da função de trabalho: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Digite os dados do funcionário abaixo");

            Console.Write("Nome: ");
            string workerName = Console.ReadLine();

            Console.Write("Digite o nível da função(Junior/MidLevel/Senior: ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Salário: R$");
            double workerBaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName);
            Worker worker = new Worker(workerName, workerLevel, workerBaseSalary, department);

            Console.Write("Digite o número de contratos que esse funcionário possui: ");
            int contracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < contracts; i++)
            {
                Console.WriteLine($"Digite as informações do {i + 1}° contrato do funcionário abaixo");
                Console.Write($"Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: R$");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Horas: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(hourContract);
            }

            Console.Write("Digite o mês e o ano referente que você deseja ver o total do salário (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            string mensagem = $"""
                Nome: {worker.Name}
                Department: {department.Name}
                Renda de {monthAndYear}: R${worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}
                """;
            Console.WriteLine(mensagem);


        }
    }
}
