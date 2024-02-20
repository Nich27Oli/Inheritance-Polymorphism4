using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism4.Entities
{
    public abstract class TaxPayer
    {
        public String Name { get; set; }
        public Double AnualIncome { get; set; }

        public TaxPayer() { }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
