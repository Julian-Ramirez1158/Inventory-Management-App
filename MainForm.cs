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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            MainFormPopulate();

            

            // links data source (binding list in Part class) to GUI
            dgvParts.DataSource = Inventory.AllParts; // moving to inventory

            // selects full row in data grid
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // make data grid read only and turn multiselect off
            dgvParts.ReadOnly = true;
            dgvParts.MultiSelect = false;

            // remove blank bottom row
            dgvParts.AllowUserToAddRows = false;

            // hides InStock column
            dgvParts.Columns["InStock"].Visible = false;
            

            // datasourcing of Products
            dgvProducts.DataSource = Inventory.Products;

            // hides InStock column
            dgvProducts.Columns["InStock"].Visible = false;

            // add same functionality to Products data grid
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;


        }

        // Populate Datagrids

        public void MainFormPopulate()
        {
            Inventory.PopulatePartsList();
            Inventory.PopulateProductsList();
        }


        // Datagrid methods for parts

        private void julianBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // clears selection
            dgvParts.ClearSelection();
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show("Part selected!");
        }

        private void SearchParts_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();
            dgvParts.MultiSelect = true;

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
                            dgvParts.Rows[i].Selected = true;
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

        private void PartsAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddPart().ShowDialog();
            this.Show();
        }

        private void PartsModify_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null || !dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected! Please select a part.");
                return;
            }
            this.Hide();

            int rowIndex = dgvParts.CurrentRow.Index;

            if (dgvParts.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse inHousePart = (InHouse)dgvParts.CurrentRow.DataBoundItem;
                ModifyPart modPart = new ModifyPart(rowIndex, inHousePart);
                modPart.inHouseButtonSwitch.Checked = true;
                modPart.ShowDialog();
                //    Part P = dgvParts.CurrentRow.DataBoundItem as Part;
                //    Inventory.AllParts.Remove(P);
            }
            else
            {
                Outsourced outsourcedPart = (Outsourced)dgvParts.CurrentRow.DataBoundItem;
                ModifyPart modPart = new ModifyPart(rowIndex, outsourcedPart);
                modPart.outsourcedButtonSwitch.Checked = true;
                modPart.ShowDialog();
                //Part P = dgvParts.CurrentRow.DataBoundItem as Part;
                //Inventory.AllParts.Remove(P);
            }
            this.Show();

            
        }

        private void PartsDelete_Click(object sender, EventArgs e)
        {
            // check for row selection and null values
            if (dgvParts.CurrentRow == null || !dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected! Please select a part.");
                return;
            }

            DialogResult userChoice = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo);

            if (userChoice == DialogResult.Yes)
            {
                Part P = dgvParts.CurrentRow.DataBoundItem as Part;
                Inventory.AllParts.Remove(P);
            }
            else return;
            

            // int Index = dgvParts.CurrentCell.RowIndex;

        }

        // Datagrid methods for products

        private void julianProductsBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // clears selection
            dgvProducts.ClearSelection();
        }

        private void SearchProducts_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            dgvProducts.MultiSelect = true;

            bool productFound = false;
            if (!String.IsNullOrEmpty(ProductsSearchBox.Text))
            {
                if (!Regex.IsMatch(ProductsSearchBox.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Invalid input, search by product name.");
                }
                else
                {
                    for (int i = 0; i < Inventory.Products.Count; i++)
                    {
                        if (Inventory.Products[i].Name.ToUpper().Contains(ProductsSearchBox.Text.ToUpper()))
                        {
                            dgvProducts.Rows[i].Selected = true;
                            productFound = true;

                        }
                    }
                }
            }
            if (!productFound && (Regex.IsMatch(ProductsSearchBox.Text, @"^[a-zA-Z]+$") || String.IsNullOrEmpty(ProductsSearchBox.Text)))
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void ProductsAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProduct().ShowDialog();
            this.Show();
        }

        private void ProductsModify_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || !dgvProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected! Please select a product.");
                return;
            }
            this.Hide();
            new ModifyProduct().ShowDialog();
            this.Show();
        }

        private void DeleteProducts_Click(object sender, EventArgs e)
        {

            // check for row selection and null values
            if (dgvProducts.CurrentRow == null || !dgvProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected! Please select a product.");
                return;
            }

            DialogResult userChoice = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);

            if (userChoice == DialogResult.Yes)
            {
                Product P = dgvProducts.CurrentRow.DataBoundItem as Product;

                // add validation to ensure that products cannot be deleted if parts are associated with it

                Inventory.Products.Remove(P);
            }
            else return;
            

        }

        private void MainFormExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
