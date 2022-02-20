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
        public AddProduct()
        {
            InitializeComponent();

            dgvAllCandidateParts.DataSource = Inventory.AllParts;

            // selects full row in data grid
            dgvAllCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // make data grid read only and turn multiselect off
            dgvAllCandidateParts.ReadOnly = true;
            dgvAllCandidateParts.MultiSelect = false;

            // remove blank bottom row
            dgvAllCandidateParts.AllowUserToAddRows = false;

            // hides InStock column
            dgvAllCandidateParts.Columns["InStock"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void julianBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAllCandidateParts.ClearSelection();
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
    }
}
