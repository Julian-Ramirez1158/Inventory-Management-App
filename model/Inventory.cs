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

            Part sampleInPart1 = new InHouse(0, "Wheel", 15, (decimal)12.11, 5, 25, 42069);
            Part sampleInPart2 = new InHouse(1, "Pedal", 11, (decimal)8.22, 5, 25, 0302);
            Part sampleOutPart1 = new Outsourced(2, "Chain", 12, (decimal)8.33, 5, 25, "Relli Tech");
            Part sampleOutPart2 = new Outsourced(3, "Seat", 8, (decimal)4.55, 2, 15, "Crossmatch");

            AllParts.Add(sampleInPart1);
            AllParts.Add(sampleInPart2);
            AllParts.Add(sampleOutPart1);
            AllParts.Add(sampleOutPart2);
        }

        public static void PopulateProductsList()
        {
            Product sampleProduct1 = new Product(0, "Red Bicycle", 15, (decimal)11.44, 1, 25);
            Product sampleProduct2 = new Product(1, "Yellow Bicycle", 19, (decimal)9.66, 1, 20);
            Product sampleProduct3 = new Product(2, "Blue Bicycle", 5, (decimal)11.44, 1, 25);

            Products.Add(sampleProduct1);
            Products.Add(sampleProduct2);
            Products.Add(sampleProduct3);
        }

        public void AddProduct()
        {
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

        public static void UpdateProduct(int productID, Product updatedProduct)
        {

            foreach (Product modPart in Products)
            {
                if (modPart.ProductID == productID)
                {
                    modPart.Name = updatedProduct.Name;
                    modPart.Inventory = updatedProduct.Inventory;
                    modPart.Price = updatedProduct.Price;
                    modPart.Min = updatedProduct.Min;
                    modPart.Max = updatedProduct.Max;
                    modPart.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }

        public static void AddPart()
        {
            
        }

        public bool DeletePart()
        {
            
            return true;
        }

        public void lookupPart(int id)
        {
            return;
        }

        public static void UpdateInHousePart(int rowIndex, InHouse inHousePart)
        {
            if (AllParts[rowIndex].GetType() == typeof(Outsourced))
            {
                Outsourced modPart = (Outsourced)AllParts[rowIndex];
                AllParts.Remove(AllParts[rowIndex]);

                InHouse inHousePartUpdate = new InHouse(
                    inHousePart.PartID,
                    inHousePart.Name,
                    inHousePart.Inventory,
                    inHousePart.Price,
                    inHousePart.Min,
                    inHousePart.Max,
                    Convert.ToInt32(inHousePart.MachineID)
                );

                AllParts.Add(inHousePartUpdate);
            }
            else
            {
                InHouse modPart = (InHouse)AllParts[rowIndex];
                modPart.PartID = inHousePart.PartID;
                modPart.Name = inHousePart.Name;
                modPart.Inventory = inHousePart.Inventory;
                modPart.Price = inHousePart.Price;
                modPart.Max = inHousePart.Max;
                modPart.Min = inHousePart.Min;
                modPart.MachineID = inHousePart.MachineID;
            }

        }

        public static void UpdateOutsourcedPart(int rowIndex, Outsourced outsourcedPart)
        {
            if (AllParts[rowIndex].GetType() == typeof(InHouse))
            {
                InHouse modPart = (InHouse)AllParts[rowIndex];
                AllParts.Remove(AllParts[rowIndex]);

                Outsourced outSourcedPartUpdate = new Outsourced(
                    outsourcedPart.PartID,
                    outsourcedPart.Name,
                    outsourcedPart.Inventory,
                    outsourcedPart.Price,
                    outsourcedPart.Min,
                    outsourcedPart.Max,
                    outsourcedPart.CompanyName.ToString()
                );

                AllParts.Add(outSourcedPartUpdate);
                
            }
            else
            {
                Outsourced modPart = (Outsourced)AllParts[rowIndex];
                modPart.PartID = outsourcedPart.PartID;
                modPart.Name = outsourcedPart.Name;
                modPart.Inventory = outsourcedPart.Inventory;
                modPart.Price = outsourcedPart.Price;
                modPart.Max = outsourcedPart.Max;
                modPart.Min = outsourcedPart.Min;
                modPart.CompanyName = outsourcedPart.CompanyName;
            }

        }
    }
}
