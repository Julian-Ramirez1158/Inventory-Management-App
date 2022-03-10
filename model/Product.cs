using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFM1_Task1.model
{
    public class Product 
    {

        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; } 
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int _productID, string _name, int _inventory, decimal _price, int _min, int _max)
        {
            ProductID = _productID;
            Name = _name;
            Inventory = _inventory;
            Price = _price;
            Min = _min;
            Max = _max;
        }

        public void AddAssPart(Part assPart)
        {
            AssociatedParts.Add(assPart);
        }

    }

}
