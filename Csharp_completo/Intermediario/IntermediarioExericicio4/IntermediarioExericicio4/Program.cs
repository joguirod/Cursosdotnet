using IntermediarioExericicio4.Entities;

namespace IntermediarioExericicio4
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i): ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Product usedProduct = new UsedProduct(name, price, manufactureDate);
                    products.Add(usedProduct);
                    continue;
                }

                else if (type == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    Product importedProduct = new ImportedProduct(name, price, customFee);
                    products.Add(importedProduct);
                    continue;
                }

                Product product = new Product(name, price);
                products.Add(product);
            }

            Console.WriteLine("PRICE TAGS:");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}