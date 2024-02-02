using Exercicios22.Entities;
using Exercicios22.Entities.Enums;

namespace Exercicios22
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 10,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string text = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(text);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}