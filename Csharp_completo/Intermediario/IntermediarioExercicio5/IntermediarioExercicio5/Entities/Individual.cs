using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediarioExercicio5.Entities
{
    class Individual : Contribuinte
    {
        public double HealthSpending { get; set; }

        public Individual(string name, double anualIncome, double healthSpending) : base(name, anualIncome) 
        {
            HealthSpending = healthSpending;
        }

        public override double TotalTax()
        {
            double totalTax = 0;

            if (AnualIncome < 20000)
            {
                totalTax = AnualIncome * 0.15;
                totalTax -= HealthSpending * 0.5;
                return totalTax;

            }

            totalTax = AnualIncome * 0.25;
            totalTax -= HealthSpending * 0.5;
            return totalTax;
        }

    }
}
