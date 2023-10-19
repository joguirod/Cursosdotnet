using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }
        public int Quantity { get; set; }

        public Product() 
        {
        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalValue()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Name
            + ", "
            + TotalValue();
        }
    }
}
