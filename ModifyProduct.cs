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
        public ModifyProduct()
        {
            InitializeComponent();
            
            dgvAllCandidateParts.DataSource = Inventory.AllParts;
            dgvPartsAssociated.DataSource = addedAssParts;

            foreach (Part assPart in Product.AssociatedParts)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
