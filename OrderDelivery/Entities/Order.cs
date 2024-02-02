using OrderDelivery.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDelivery.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddOrderItem(OrderItem item)
        {
            Items.Add(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach (OrderItem item in Items)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Momento do Pedido: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Status do pedido: {Status}");
            sb.AppendLine($"Cliente: {Client}");
            sb.AppendLine($"Itens do pedido");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Preço total: R${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }

    }
}
