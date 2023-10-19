using System.IO;
using Exercicios.Entities;
using Exercicios.Entities.Exceptions;

namespace Exercicios
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write the file's path:");
            string path = Console.ReadLine();
            List<Product> products = new List<Product>();

            try
            {
                using (FileStream fs = new FileStream(@$"{path}", FileMode.Open)) {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] atributes = sr.ReadLine().Split(",");
                            string name = atributes[0];
                            double price = double.Parse(atributes[1]);
                            int quantity = int.Parse(atributes[2]);
                            Product product = new Product(name, price, quantity);
                            products.Add(product);

                        }

                    }
                }

                Directory.CreateDirectory(path + "\\out");

                using (StreamWriter sw = new StreamWriter(@$"{path}" + "\\summary.csv"))
                {
                    foreach (Product product in products)
                    {
                        sw.WriteLine(product);
                    }

                }
            }

            catch (IOException e) 
            {
                Console.WriteLine("Error: " + e.Message);
            }

            
        }
    }
}
