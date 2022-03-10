﻿using BFM1_Task1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFM1_Task1
{
    public partial class ModifyPart : Form
    {
        private int _rowIndex;
        public ModifyPart(int rowIndex, InHouse inHousePart)
        {
            InitializeComponent();
            _rowIndex = rowIndex;
            this.IDBox.Text = inHousePart.PartID.ToString();
            this.NameBox.Text = inHousePart.Name.ToString();
            this.InventoryBox.Text = inHousePart.Inventory.ToString();
            this.PriceBox.Text = inHousePart.Price.ToString();
            this.MinBox.Text = inHousePart.Min.ToString();
            this.MaxBox.Text = inHousePart.Max.ToString();
            this.MacID_CompNameBox.Text = inHousePart.MachineID.ToString();

        }

        public ModifyPart(int rowIndex, Outsourced outsourcedPart)
        {
            InitializeComponent();
            _rowIndex = rowIndex;
            this.IDBox.Text = outsourcedPart.PartID.ToString();
            this.NameBox.Text = outsourcedPart.Name.ToString();
            this.InventoryBox.Text = outsourcedPart.Inventory.ToString();
            this.PriceBox.Text = outsourcedPart.Price.ToString();
            this.MinBox.Text = outsourcedPart.Min.ToString();
            this.MaxBox.Text = outsourcedPart.Max.ToString();
            this.MacID_CompNameBox.Text = outsourcedPart.CompanyName.ToString();

        }


        private void button2_Click(object sender, EventArgs e)
        {
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

        public RadioButton inHouseButtonSwitch
        {
            get { return this.radioInHouse; }
            
        }

        public RadioButton outsourcedButtonSwitch
        {
            get { return this.radioOutsourced; }

        }

        private void ModifySave_Click(object sender, EventArgs e)
        {
            int _partID = Convert.ToInt32(IDBox.Text);
            string _name = NameBox.Text;
            int _inventory = Convert.ToInt32(InventoryBox.Text);
            decimal _price = Convert.ToDecimal(PriceBox.Text);
            int _min = Convert.ToInt32(MinBox.Text);
            int _max = Convert.ToInt32(MaxBox.Text);

            if (radioInHouse.Checked == true)
            {
                int _machineID = Convert.ToInt32(MacID_CompNameBox.Text);
                InHouse inHousePart = new InHouse(_partID, _name, _inventory, _price, _min, _max, _machineID);
                Inventory.UpdateInHousePart(_rowIndex, inHousePart);
            }
            else if (radioOutsourced.Checked == true)
            {
                string _companyName = MacID_CompNameBox.Text;
                Outsourced outSourcedPart = new Outsourced(_partID, _name, _inventory, _price, _min, _max, _companyName);
                Inventory.UpdateOutsourcedPart(_rowIndex, outSourcedPart);
            }

            this.Hide();
        }
    }
}
