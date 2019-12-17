using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_her___poli.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct(string name, double price ,DateTime manufacturedDate) : base (name,price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public UsedProduct() { }

        public override string PriceTag()
        {
            return Name + "(Used) $ " + Price.ToString("F2") + "(Manufacture date: " + ManufacturedDate.ToString("dd/MM/yyyy") + ") ";
        }
    }
}
