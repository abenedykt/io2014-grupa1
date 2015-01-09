using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Model
{
    public class Item
    {
        public Item(string id, string name, double unitPrice, double vatRate)
        {
            this.Id = id;
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.Vat = vatRate;
        }

        public string Id { get; set; }
        public double UnitPrice { get; set; }
        public string Name { get; set; }
        public double Vat { get; set; }
    }
}
