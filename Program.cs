using System;
using exercicio_3.Entities;
using exercicio_3.Entities.Enums;
using System.Globalization;



namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string mail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate =  DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name,mail,birthdate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; n > i; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:" );
            Console.WriteLine(order);
        }
    }
}
