using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism4.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) 
            : base(name, anualIncome) 
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                AnualIncome *= 0.14;
            }
            else
            {
                AnualIncome *= 0.16;
            }

            return AnualIncome;
        }
    }
}
