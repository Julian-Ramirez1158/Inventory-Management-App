using BFM1_Task1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFM1_Task1
{
    class Inventory 
    {

        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();
        

        public static void PopulatePartsList() 
        {
            AllParts.Add(
                 new Part { PartID = 0, Name = "Wheel", Inventory = 15, Price = (decimal)12.11, Min = 5, Max = 25 }
                );
            AllParts.Add(
                 new Part { PartID = 1, Name = "Pedal", Inventory = 11, Price = (decimal)8.22, Min = 5, Max = 25 }
                );
            AllParts.Add(
                 new Part { PartID = 2, Name = "Chain", Inventory = 12, Price = (decimal)8.33, Min = 5, Max = 25 }
                );
            AllParts.Add(
                 new Part { PartID = 3, Name = "Seat", Inventory = 8, Price = (decimal)4.55, Min = 2, Max = 15 }
                );
        }

        public static void PopulateProductsList()
        {
            Products.Add(new Product { ProductID = 0, Name = "Red Bicycle", Inventory = 15, Price = (decimal)11.44, Min = 1, Max = 25 });
            Products.Add(new Product{ ProductID = 1, Name = "Yellow Bicycle", Inventory = 19, Price = (decimal)9.66, Min = 1, Max = 2 });
            Products.Add(new Product{ ProductID = 2, Name = "Blue Bicycle", Inventory = 5, Price = (decimal)11.44, Min = 1, Max = 25 });
        }

        public void AddProduct()
        {
            //add product to products
            return;
        }

        public bool RemoveProduct()
        {
            return true;
        }

        public void lookupProduct(int id)
        {
            return;
        }

        public void UpdateProduct()
        {
            return;
        }

        public static void AddPart(int partID, string name, int inventory, decimal price, int min, int max)
        {
            AllParts.Add(new Part { PartID = partID, Name = name, Inventory = inventory, Price = price, Min = min, Max = max });
            
        }

        public void DeletePart()
        {
            return;
        }

        public void lookupPart(int id)
        {
            return;
        }

        public void UpdatePart()
        {
            return;
        }

    }
}
