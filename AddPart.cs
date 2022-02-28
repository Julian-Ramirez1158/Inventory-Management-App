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
            int _partID = Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1;
            string _name = NameBox.Text;
            int _inventory = Convert.ToInt32(InventoryBox.Text);
            decimal _price = Convert.ToDecimal(PriceBox.Text); 
            int _min = Convert.ToInt32(MinBox.Text);
            int _max = Convert.ToInt32(MaxBox.Text);

            if (radioInHouse.Checked == true)
            {
                int _machineID = Convert.ToInt32(MacID_CompNameBox.Text);
                Part InHousePart = new InHouse ( _partID, _name, _inventory, _price, _min,  _max, _machineID );
                Inventory.AllParts.Add(InHousePart);
            }
            else if (radioOutsourced.Checked == true)
            {
                string _companyName = MacID_CompNameBox.Text;
                Part OutSourcedPart = new Outsourced ( _partID, _name, _inventory, _price, _min, _max,  _companyName );
                Inventory.AllParts.Add(OutSourcedPart);
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
