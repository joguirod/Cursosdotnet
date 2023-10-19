using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediarioExercicio5.Entities
{
    class Company : Contribuinte
    {
        public int QtyEmployee { get; set; }

        public Company(string name, double anualIncome, int qtyEmployee) : base(name, anualIncome) 
        {
            QtyEmployee = qtyEmployee;
        }

        public override double TotalTax()
        {
            if (QtyEmployee > 10)
            {
                return AnualIncome * 0.16;
            }

            return AnualIncome * 0.14;
        }
    }
}
