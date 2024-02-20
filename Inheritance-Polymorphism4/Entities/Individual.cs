using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism4.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000)
            {
                AnualIncome = AnualIncome * 0.15;
            }
            else
            {
                AnualIncome = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                HealthExpenditures = HealthExpenditures * 0.5;
            }

            return AnualIncome - HealthExpenditures;
        }
    }
}
