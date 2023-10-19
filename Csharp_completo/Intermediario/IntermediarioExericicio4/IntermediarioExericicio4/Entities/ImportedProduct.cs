using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediarioExericicio4.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice()} (Customs Fee: $ {CustomsFee})";

        }
    }
}
