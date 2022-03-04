using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BFM1_Task1.model;

namespace BFM1_Task1
{
    public partial class AddProduct : Form
    {
        BindingList<Part> addedAssParts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();

            // set data sources for both data grids
            dgvAllCandidateParts.DataSource = Inventory.AllParts;
            dgvPartsAssociated.DataSource = addedAssParts;

            // selects full row in data grid
            dgvAllCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartsAssociated.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // make data grid read only and turn multiselect off
            dgvAllCandidateParts.ReadOnly = true;
            dgvAllCandidateParts.MultiSelect = false;
            dgvPartsAssociated.ReadOnly = true;
            dgvPartsAssociated.MultiSelect = true;

            // remove blank bottom row
            dgvAllCandidateParts.AllowUserToAddRows = false;
            dgvPartsAssociated.AllowUserToAddRows = false;

            // hides InStock column
            dgvAllCandidateParts.Columns["InStock"].Visible = false;
            dgvPartsAssociated.Columns["InStock"].Visible = false;
        }

        private void julianBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAllCandidateParts.ClearSelection();
        }

        private void dgvPartsAssociated_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPartsAssociated.ClearSelection();
        }

        private void SearchParts_Click(object sender, EventArgs e)
        {
            dgvAllCandidateParts.ClearSelection();
            dgvAllCandidateParts.MultiSelect = true;

            bool partFound = false;
            if (!String.IsNullOrEmpty(PartsSearchBox.Text))
            {
                if (!Regex.IsMatch(PartsSearchBox.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Invalid input, search by part name.");
                }
                else
                {
                    for (int i = 0; i < Inventory.AllParts.Count; i++)
                    {
                        if (Inventory.AllParts[i].Name.ToUpper().Contains(PartsSearchBox.Text.ToUpper()))
                        {
                            dgvAllCandidateParts.Rows[i].Selected = true;
                            partFound = true;

                        }
                    }
                }
            }
            if (!partFound && (Regex.IsMatch(PartsSearchBox.Text, @"^[a-zA-Z]+$") || String.IsNullOrEmpty(PartsSearchBox.Text)))
            {
                MessageBox.Show("Part not found.");
            }
        }

        private void AddProductSave_Click(object sender, EventArgs e)
        {
            int _productID = Inventory.Products[Inventory.Products.Count - 1].ProductID + 1;
            string _name = NameBox.Text;
            int _inventory = Convert.ToInt32(InventoryBox.Text);
            decimal _price = Convert.ToDecimal(PriceBox.Text);
            int _min = Convert.ToInt32(MinBox.Text);
            int _max = Convert.ToInt32(MaxBox.Text);

            Product newProduct = new Product(_productID, _name, _inventory, _price, _min, _max);
            Inventory.Products.Add(newProduct);

            foreach (Part assPart in addedAssParts)
            {
                newProduct.AddAssPart(assPart);
            }
            this.Hide();
        }

        private void AddAssPartButton_Click(object sender, EventArgs e)
        {
            Part addedAssPart = (Part)dgvAllCandidateParts.CurrentRow.DataBoundItem;
            addedAssParts.Add(addedAssPart);
        }

        private void DeleteAssPartButton_Click(object sender, EventArgs e)
        {
            // check for row selection and null values
            if (dgvPartsAssociated.CurrentRow == null || !dgvPartsAssociated.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected! Please select a part.");
                return;
            }

            DialogResult userChoice = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo);

            if (userChoice == DialogResult.Yes)
            {
                Part P = dgvPartsAssociated.CurrentRow.DataBoundItem as Part;
                addedAssParts.Remove(P);
            }
            else return;
        }

        private void button3_Click(object sender, EventArgs e) // cancel button
        {
            this.Hide();
        }

    }
}
