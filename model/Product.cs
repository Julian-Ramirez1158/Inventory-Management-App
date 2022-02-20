﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFM1_Task1.model
{
    public class Product 
    {

        public int ProductID { get; set; } 
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

    }

}
