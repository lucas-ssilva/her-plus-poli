using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_her___poli.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name,price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2") + "(Custom Fee $" + CustomsFee.ToString("F2") + ")" ;
        }
    }
}
