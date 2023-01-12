using System;
using exercicio_3.Entities.Enums;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace exercicio_3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public Client Client { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem iten)
        {
            Itens.Add(iten);
        }

        public void RemoveItem(OrderItem iten)
        {
            Itens.Remove(iten);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order itens: ");
            foreach (OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
