using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFM1_Task1.model
{
    public class Outsourced : Part
    {
        
        public string CompanyName { get; set; }

        public Outsourced(int _partID, string _name, int _inventory, decimal _price, int _min, int _max, string _companyName)
        {
            PartID = _partID;
            Name = _name;
            Inventory = _inventory;
            Price = _price;
            Min = _min;
            Max = _max;
            CompanyName = _companyName;
        }

    }
}
