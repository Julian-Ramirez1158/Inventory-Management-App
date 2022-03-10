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


        private void AddPartSave_Click(object sender, EventArgs e)
        {
            int _partID = Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1;
            string _name = NameBox.Text;
            int _inventory;
            decimal _price;
            int _min;
            int _max;

            try
            {
                _inventory = Convert.ToInt32(InventoryBox.Text);
                _price = Convert.ToDecimal(PriceBox.Text);
                _min = Convert.ToInt32(MinBox.Text);
                _max = Convert.ToInt32(MaxBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Min, and Max fields need to be numeric values.\n");
                return;
            }

            if (string.IsNullOrEmpty(MacID_CompNameBox.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Machine ID or Company Name is required. Please select a radio button.");
                errorProvider1.SetError(MacID_CompNameBox, dialogResult.ToString());
                return;
            }
            else
            {
                errorProvider1.SetError(MacID_CompNameBox, string.Empty);
            }

            if (radioInHouse.Checked == true)
            {
                int _machineID = Convert.ToInt32(MacID_CompNameBox.Text);
                Part InHousePart = new InHouse(_partID, _name, _inventory, _price, _min, _max, _machineID);
                Inventory.AllParts.Add(InHousePart);
            }
            else if (radioOutsourced.Checked == true)
            {
                string _companyName = MacID_CompNameBox.Text;
                Part OutSourcedPart = new Outsourced(_partID, _name, _inventory, _price, _min, _max, _companyName);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
