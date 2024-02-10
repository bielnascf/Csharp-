using Exercicios28.Entities;
using System.Globalization;

namespace Exercicios28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            List<Person> list = new List<Person>();

            for (int i = 1;  i <= n; i++)
            {
                Console.WriteLine($"Pessoa #{i}");
                Console.Write("Pessoa física ou jurídica (f/j): ");
                char personType = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Renda anual: $");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(personType == 'f')
                {
                    Console.Write("Gastos com saúde: $");
                    double healthExpedinture = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpedinture));
                }
                else if(personType == 'j')
                {
                    Console.Write("Número de funcionários: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, employees));
                }
                else
                {
                    Console.WriteLine("Tipo inválido.");
                }
            }

            double soma = 0;
            Console.WriteLine("Impostos a ser pagos");
            foreach (Person person in list)
            {
                double tax = person.Tax();
                Console.WriteLine($"""
                    {person.Name}: ${person.Tax().ToString("F2", CultureInfo.InvariantCulture)}
                    """);
                soma += tax;
            }

            Console.WriteLine($"Total: ${soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
