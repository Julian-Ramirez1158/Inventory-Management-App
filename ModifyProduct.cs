using BFM1_Task1.model;
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

namespace BFM1_Task1
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> addedAssParts = new BindingList<Part>();
        public ModifyProduct(Product updatedProduct)
        {
            InitializeComponent();

            dgvAllCandidateParts.DataSource = Inventory.AllParts;
            dgvPartsAssociated.DataSource = addedAssParts;

            ProductIDBox.Text = updatedProduct.ProductID.ToString();
            NameBox.Text = updatedProduct.Name;
            InventoryBox.Text = updatedProduct.Inventory.ToString();
            PriceBox.Text = updatedProduct.Price.ToString();
            MinBox.Text = updatedProduct.Min.ToString();
            MaxBox.Text = updatedProduct.Max.ToString();

            foreach (Part assPart in updatedProduct.AssociatedParts)
            {
                addedAssParts.Add(assPart);
            }

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

        private void ModifyProductSave_Click(object sender, EventArgs e)
        {
            int _productID = Convert.ToInt32(ProductIDBox.Text);
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
                MessageBox.Show("Error: Inventory, Price, Min, and Max fields need to be numeric values.");
                return;
            }

            if (_max < _min)
            {
                MessageBox.Show("Error: Max value should be greater than Min value.");
                return;
            }

            if (_inventory > _max || _inventory < _min)
            {
                MessageBox.Show("Error: Inventory value should be between Min and Max values.");
                return;
            }

            Product updatedProduct = new Product(_productID, _name, _inventory, _price, _min, _max);

            Inventory.UpdateProduct(_productID, updatedProduct);
            foreach (Part assPart in addedAssParts)
            {
                updatedProduct.AddAssPart(assPart);
            }
            

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
