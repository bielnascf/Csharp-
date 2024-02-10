using Exercicios24.Entities;
using System.Globalization;

namespace Exercicios24
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Digite o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}");

                Console.Write("Terceirizado (s/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string employeeName = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(outsourced == 's')
                {
                    Console.Write("Adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    OutsourcedEmployee outsourcedEmployee = new OutsourcedEmployee(employeeName, hours, valuePerHour, additionalCharge);
                    list.Add(outsourcedEmployee);
                }
                else
                {
                    Employee employee = new Employee(employeeName, hours, valuePerHour);
                    list.Add(employee);
                }
            }

            Console.WriteLine("Pagamentos: ");
            foreach(Employee employee in list)
            {
                Console.WriteLine($"{employee.Name} - R${employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
