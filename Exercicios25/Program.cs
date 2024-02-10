using Exercicios25.Entities;
using System.Globalization;

namespace Exercicios25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Produto #{i}");
                Console.Write("Comum, usado ou importado (c/u/i): ");
                char productType = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string productName = Console.ReadLine();

                Console.Write("Preço: $");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'c')
                {
                    list.Add(new Product(productName, productPrice));
                }
                else if(productType == 'u')
                {
                    Console.Write("Data de Fabricação (dd/mm/yyyy): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(productName, productPrice, manufactureDate));
                }
                else if(productType == 'i')
                {
                    Console.Write("Imposto: $");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(productName, productPrice, customFee));
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }

            Console.WriteLine("Etiquetas dos produtos");
            foreach(Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}