using System;
using ExeAula132.Entities;
using ExeAula132.Entities.Enums;

namespace ExeAula132
{
    class ExeAula132
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inform client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientMail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Inform order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, clientMail, clientBirthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many itens to add to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informe #{i} item data: ");
                Console.Write("Product name? ");
                string productName = Console.ReadLine();
                Console.Write("Product price? ");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                Console.Write("Product Quantity? ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
