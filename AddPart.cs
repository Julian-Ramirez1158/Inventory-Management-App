using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BFM1_Task1.model;

namespace BFM1_Task1
{
    public partial class AddPart : Form
    {

        int _partID;
        string _name;
        int _inventory;
        decimal _price;
        int _min;
        int _max;
        int _machineID;
        string _companyName;

        
        public AddPart()
        {

            InitializeComponent();

        }

        



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {
            _partID = Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1;
            _name = NameBox.Text;
            _inventory = Convert.ToInt32(InventoryBox.Text);
            _price = Convert.ToDecimal(PriceBox.Text); 
            _min = Convert.ToInt32(MinBox.Text);
            _max = Convert.ToInt32(MaxBox.Text);

            Inventory.AddPart(
                _partID,
                _name,
                _inventory,
                _price,
                _min,
                _max
                );

            
            

            if (radioInHouse.Checked == true)
            {
                _machineID = Convert.ToInt32(MacID_CompNameBox.Text);
                new InHouse { PartID = _partID, Name = _name, Inventory = _inventory, Price = _price, Min = _min, Max = _max, MachineID = _machineID };
            }
            else if (radioOutsourced.Checked == true)
            {
                _companyName = MacID_CompNameBox.Text;
                new Outsourced { PartID = _partID, Name = _name, Inventory = _inventory, Price = _price, Min = _min, Max = _max, CompanyName = _companyName };
            }

            this.Hide();
        }

        

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
           
            label8.Location = new Point(105, 326);
            label8.Text = "Machine ID";
            
        }

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label8.Location = new Point(75, 326);
            label8.Text = "Company Name";
        }
    }
}
