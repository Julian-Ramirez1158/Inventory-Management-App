using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFM1_Task1.model
{
    public class InHouse : Part
    {
        
        public int MachineID { get; set; }

        public InHouse(int _partID, string _name, int _inventory, decimal _price, int _min, int _max, int _machineID)
        {
            PartID = _partID;
            Name = _name;
            Inventory = _inventory;
            Price = _price;
            Min = _min;
            Max = _max;
            MachineID = _machineID;

        }

    }
}
