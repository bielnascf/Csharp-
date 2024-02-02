using OrderDelivery.Entities;
using OrderDelivery.Entities.Enums;
using System.Globalization;

namespace OrderDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string clientName = Console.ReadLine();

            Console.Write("Digite o seu email: ");
            string clientEmail = Console.ReadLine();

            Console.Write("Digite a sua data de nascimento (dd/mm/yyyy): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            Client client = new(clientName, clientEmail, clientBirthDate);

            Console.WriteLine("Digite abaixo as informações do pedido");

            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Digite o número de itens no pedido: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}° item");
                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();

                Console.Write("Preço do Produto: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddOrderItem(orderItem);
            }

            Console.WriteLine("Resumo do pedido");
            Console.WriteLine(order);

            
        }
    }
}