using IntermediarioExericio2.Entities;
using IntermediarioExericio2.Entities.Enums;
using System;
using System.Xml;

namespace IntermediarioExericicio2
{
    class IntermediarioExericicio2
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birthdate (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(clientName, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(birthDate, status, client);

            Console.Write("How many items in this order? ");
            int qtyItems = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtyItems; i++) 
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Enter quantity bought: ");
                int qtyBought = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                order.Items.Add(new OrderItem(qtyBought, product));
            }

            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order.ToString());
        }
        
    }
}